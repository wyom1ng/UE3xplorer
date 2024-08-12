using System.Diagnostics;
using System.Reflection;

namespace ue3;

public partial class UStruct
{
  public partial class FPropertyTag
  {
    public void Serialise(FArchive Archive)
    {
      Archive.Serialise(ref Name);
      if (Name == EName.None) return;

      Archive.Serialise(ref Type);
      Archive.Serialise(ref Size);
      Archive.Serialise(ref ArrayIndex);

      if (Type == EName.StructProperty)
      {
        Archive.Serialise(ref StructName);
      }
      else if (Type == EName.BoolProperty)
      {
        if (Archive.Version < EFileVersion.PROPERTYTAG_BOOL_OPTIMIZATION) throw new NotImplementedException();
        Archive.Serialise(ref BoolVal);
      }
      else if (Type == EName.ByteProperty && Archive.Version >= EFileVersion.BYTEPROP_SERIALIZE_ENUM)
      {
        Archive.Serialise(ref EnumName);
      }
    }
  }

  public static void SerialiseTaggedProperties(FArchive Archive, object To, FName Name)
  {
    while (true)
    {
      FPropertyTag Tag = new();
      Tag.Serialise(Archive);

      if (Tag.Name == EName.None) break;

      int PropertyContentStart = Archive.Tell();

      FieldInfo Property = To.GetType().GetField(Tag.Name.Resolved, BindingFlags.Instance | BindingFlags.Public);
      Debug.Assert(Property != null);

      object PropertyValue = Property.GetValue(To);
      SerialiseProperty(Archive, Tag, Property.FieldType, ref PropertyValue);
      Property.SetValue(To, PropertyValue);

      int SerialisedBytes = Archive.Tell() - PropertyContentStart;
      if (SerialisedBytes < Tag.Size)
      {
        Debug.WriteLine("failed to fully serialise {0} {1}'{2}.{3}, missed {4} bytes", Tag.Type.Resolved, To.GetType().Name, Name.Resolved,
          Tag.Name.Resolved,
          Tag.Size - SerialisedBytes);
      }
      else if (SerialisedBytes > Tag.Size)
      {
        Debug.WriteLine("failed to serialise {0} {1}'{2}.{3}, out of bounds by {4} bytes", Tag.Type.Resolved, To.GetType().Name, Name.Resolved,
          Tag.Name.Resolved,
          SerialisedBytes - Tag.Size);
      }

      Archive.Seek(PropertyContentStart + Tag.Size);
    }
  }

  private static void SerialiseProperty(FArchive Archive, FPropertyTag Tag, Type type, ref object To)
  {
    if (Tag.Type == EName.ObjectProperty || Tag.Type == EName.ClassProperty || Tag.Type == "ComponentProperty")
    {
      UObject Value = (UObject)To;
      Archive.Serialise(ref Value);
      if (Value != null && Value.GetType() != type && !Value.GetType().IsSubclassOf(type)) throw new PackageCorruptException();
      To = Value;
    }
    else if (Tag.Type == EName.StructProperty)
    {
      if (type.GetInterfaces().Contains(typeof(ISerialisable)))
      {
        ISerialisable Value = (ISerialisable)To;
        Value.Serialise(Archive);
        To = Value;
      }
      else
      {
        object Value = To;
        SerialiseTaggedProperties(Archive, Value, Tag.Name);
        To = Value;
      }
    }
    else if (Tag.Type == EName.NameProperty)
    {
      FName Value = new();
      Archive.Serialise(ref Value);
      To = Value;
    }
    else if (Tag.Type == EName.IntProperty)
    {
      int Value = 0;
      Archive.Serialise(ref Value);
      To = Value;
    }
    else if (Tag.Type == EName.ByteProperty)
    {
      if (type == typeof(byte))
      {
        byte Value = 0;
        Archive.Serialise(ref Value);
        To = Value;
      }
      else
      {
        Debug.Assert(type.IsEnum);

        FName Value = new();
        Archive.Serialise(ref Value);
        To = Enum.Parse(type, Value.Resolved);
      }
    }
  }
}