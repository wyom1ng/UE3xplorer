using System.Diagnostics;
using System.Reflection;
using ue3.Patch;

namespace ue3;

public class ULinker(string name, byte[] data) : FArchive(data)
{
  public static Dictionary<string, UClass> allClasses = new();
  public Dictionary<string, UClass> classes = new();
  public Dictionary<string, UEnum> enums = new();
  public FObjectExport[]? Exports;
  public FObjectImport[]? Imports;
  public FName Name = FName.ResolveNameAndCorrectCasing(name);
  public Dictionary<string, int> NameMap = new(StringComparer.OrdinalIgnoreCase);
  public string[]? Names;
  public Dictionary<string, Dictionary<string, UStruct>> structuresByOuter = new();

  public override void Serialise(ref FName name)
  {
    Serialise(ref name.PackageIndex);
    Serialise(ref name.Number);

    name.ResolveFrom(Names);
  }

  public UObject SerialiseObjectImport(FObjectImport import)
  {
    throw new NotImplementedException();
  }

  public UObject SerialiseObjectExport(FName package, FObjectExport export, int linkerIndex)
  {
    if (export.ResolvedObject != null) return export.ResolvedObject;

    if (export.ClassIndex == 0)
    {
      if (export.ObjectName == EName.None) return null;
      if (allClasses.ContainsKey(export.ObjectName.Resolved)) throw new PackageCorruptException("duplicate class");

      Seek(export.SerialOffset);
      UClass theClass = new(this, export, linkerIndex);
      theClass.Serialise(this);
      classes[export.ObjectName.Resolved] = theClass;
      allClasses[export.ObjectName.Resolved] = theClass;

      return theClass;
    }

    FName className;
    if (export.ClassIndex < 0)
      className = Imports[-export.ClassIndex - 1].ObjectName;
    else
      className = Exports[export.ClassIndex - 1].ObjectName;

    if (className == EName.Enum)
    {
      if (enums.ContainsKey(export.ObjectName.Resolved))
        // sopme enums are duplicated, but always identical
        return export.ResolvedObject = enums[export.ObjectName.Resolved];

      Seek(export.SerialOffset);
      UEnum enumeration = new(this, export, linkerIndex);
      enumeration.Serialise(this);

      enums[export.ObjectName.Resolved] = enumeration;
      return enumeration;
    }

    if (className == EName.Function)
      return null;

    if (className == EName.Struct || className == "ScriptStruct")
    {
      FName outerName;
      if (export.OuterIndex < 0) outerName = Imports[-export.OuterIndex - 1].ObjectName;
      else outerName = Exports[export.OuterIndex - 1].ObjectName;

      if (!structuresByOuter.ContainsKey(outerName.Resolved))
        structuresByOuter[outerName.Resolved] = new Dictionary<string, UStruct>();

      var byOuter = structuresByOuter[outerName.Resolved];
      if (byOuter.ContainsKey(export.ObjectName.Resolved))
        throw new PackageCorruptException("duplicate struct definition");

      Seek(export.SerialOffset);
      UStruct structure = new(this, export, linkerIndex);
      structure.Serialise(this);

      byOuter[export.ObjectName.Resolved] = structure;

      return structure;
    }

    return null;
  }

  public UProperty SerialiseProperty(FObjectExport export, int linkerIndex)
  {
    var fieldClassName = GetObjectName(export.ClassIndex);
    UProperty property;

    if (fieldClassName == EName.ArrayProperty) property = new UArrayProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.BoolProperty) property = new UBoolProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.ByteProperty) property = new UByteProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.DelegateProperty) property = new UDelegateProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.FloatProperty) property = new UFloatProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.InterfaceProperty) property = new UInterfaceProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.IntProperty) property = new UIntProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.MapProperty) property = new UMapProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.NameProperty) property = new UNameProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.StrProperty) property = new UStrProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.StructProperty) property = new UStructProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.ObjectProperty) property = new UObjectProperty(this, export, linkerIndex);
    else if (fieldClassName == EName.ClassProperty) property = new UObjectProperty(this, export, linkerIndex);
    else if (fieldClassName == "ComponentProperty") property = new UObjectProperty(this, export, linkerIndex);
    else throw new PackageCorruptException("unknown property type");

    Seek(export.SerialOffset);
    property.Serialise(this);
    return property;
  }

  public UObject? SerialiseObjectByIndex(int index)
  {
    if (index == 0) return null;
    if (index < 0)
      return SerialiseObjectImport(Imports[-index - 1]);

    return SerialiseObjectExport(Name, Exports[index - 1], index - 1);
  }

  public FName GetObjectName(int index)
  {
    if (index == 0) return new FName(EName.None);
    if (index < 0) return Imports[-index - 1].ObjectName;
    return Exports[index - 1].ObjectName;
  }

  public FName GetOuterName(int index)
  {
    if (index == 0) return new FName(EName.None);
    if (index < 0) return GetObjectName(Imports[-index - 1].OuterIndex);
    return GetObjectName(Exports[index - 1].OuterIndex);
  }

  public bool DerivesFromActor(string className)
  {
    return DerivesFrom(className, "Actor");
  }

  public bool DerivesFrom(string className, string from)
  {
    while (true)
    {
      if (className == from) return true;
      if (!allClasses.ContainsKey(className)) return false;

      UClass uClass = allClasses[className];
      className = uClass.Linker.GetObjectName(uClass.SuperFieldIndex).Resolved;
    }
  }
}

public class UObject(ULinker linker, FObjectExport export, int linkerIndex)
{
  public FObjectExport Export = export;
  public ULinker Linker = linker;
  public int LinkerIndex = linkerIndex;
  public FName Name = export.ObjectName;
  public int NetIndex;
  public EObjectFlags ObjectFlags = export.ObjectFlags;

  public FName Package;

  public virtual void Serialise(ULinker linker)
  {
    if (Export.ClassIndex != 0 && linker.GetObjectName(Export.ClassIndex).Resolved.EndsWith("Component"))
    {
      int templateOwnerClassIndex = 0;
      linker.Serialise(ref templateOwnerClassIndex);

      if ((Export.ObjectFlags & EObjectFlags.RF_ClassDefaultObject) != 0)
      {
        FName templateName = new();
        linker.Serialise(ref templateName);
      }
    }

    linker.Serialise(ref NetIndex);

    if (Export.ClassIndex != 0)
      SkipTaggedProperties(linker);
  }

  private void SkipTaggedProperties(ULinker linker)
  {
    while (true)
    {
      FName propertyName = new();
      linker.Serialise(ref propertyName);
      if (propertyName == EName.None) return;

      FName propertyType = new();
      linker.Serialise(ref propertyType);
      int size = 0;
      linker.Serialise(ref size);
      int arrayIndex = 0;
      linker.Serialise(ref arrayIndex);

      if (propertyType == EName.StructProperty)
      {
        FName structName = new();
        linker.Serialise(ref structName);
      }
      else if (propertyType == EName.BoolProperty)
      {
        byte boolValue = 0;
        linker.Serialise(ref boolValue);
      }
      else if (propertyType == EName.ByteProperty)
      {
        FName enumName = new();
        linker.Serialise(ref enumName);
      }

      linker.Skip(size);
    }
  }
}

public class UField(ULinker linker, FObjectExport export, int linkerIndex) : UObject(linker, export, linkerIndex)
{
  public int NextIndex;
  public int SuperFieldIndex;
  public FName SuperFieldName;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    linker.Serialise(ref SuperFieldIndex);
    linker.Serialise(ref NextIndex);

    SuperFieldName = linker.GetObjectName(SuperFieldIndex);
  }
}

public class UProperty(ULinker linker, FObjectExport export, int linkerIndex) : UField(linker, export, linkerIndex)
{
  public int ArrayDim;
  public int ArraySizeEnumIndex;
  public FName Category;
  public EPropertyFlags PropertyFlags;
  public ushort RepOffset;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    linker.Serialise(ref ArrayDim);

    ulong propertyFlagsRaw = (ulong)PropertyFlags;
    linker.Serialise(ref propertyFlagsRaw);
    PropertyFlags = (EPropertyFlags)propertyFlagsRaw;

    linker.Serialise(ref Category);
    linker.Serialise(ref ArraySizeEnumIndex);

    if ((PropertyFlags & EPropertyFlags.CPF_Net) != 0)
      linker.Serialise(ref RepOffset);
  }
}

public class UArrayProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
  public UProperty Inner;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    int innerIndex = 0;
    linker.Serialise(ref innerIndex);
    Debug.Assert(innerIndex > 0, "imported inners not implemented");

    var innerExport = linker.Exports[innerIndex - 1];
    Inner = linker.SerialiseProperty(innerExport, innerIndex - 1);
  }
}

public class UBoolProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
}

public class UByteProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
  public int InnerIndex;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    linker.Serialise(ref InnerIndex);
  }
}

public class UDelegateProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
  public int FunctionIndex;
  public int SourceDelegateIndex;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    linker.Serialise(ref FunctionIndex);
    linker.Serialise(ref SourceDelegateIndex);
  }
}

public class UFloatProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
}

public class UInterfaceProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
  public int InterfaceIndex;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    linker.Serialise(ref InterfaceIndex);
  }
}

public class UIntProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
}

public class UMapProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
  public int KeyIndex;
  public int MappedIndex;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    linker.Serialise(ref KeyIndex);
    linker.Serialise(ref MappedIndex);

    // should recursively serialise the inner properties, but in practice this is never set
    if (KeyIndex != 0 || MappedIndex != 0) throw new NotImplementedException();
  }
}

public class UNameProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
}

public class UStrProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
}

public class UStructProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
  public int StructIndex;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    linker.Serialise(ref StructIndex);
  }
}

public class UObjectProperty(ULinker linker, FObjectExport export, int linkerIndex) : UProperty(linker, export, linkerIndex)
{
  public int PropertyClassIndex;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    linker.Serialise(ref PropertyClassIndex);
  }
}

public class UStruct(ULinker linker, FObjectExport export, int linkerIndex) : UField(linker, export, linkerIndex)
{
  public int ChildrenIndex;

  public int CppTextIndex;

  public bool hasNativeSerialiser;
  public int Line;

  public List<FName> Properties = new();
  public Dictionary<string, UProperty> PropertyMap = new();
  public int ScriptBytecodeSize;
  public int ScriptStorageSize;
  public int ScriptTextIndex;
  public int TextPos;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    linker.Serialise(ref ScriptTextIndex);
    linker.Serialise(ref ChildrenIndex);
    linker.Serialise(ref CppTextIndex);
    linker.Serialise(ref Line);
    linker.Serialise(ref TextPos);
    linker.Serialise(ref ScriptBytecodeSize);
    linker.Serialise(ref ScriptStorageSize);
    linker.Skip(ScriptStorageSize);

    int offset = linker.Tell();

    /* serialise children */
    {
      int currentFieldIndex = ChildrenIndex;
      while (currentFieldIndex != 0)
      {
        Debug.Assert(currentFieldIndex > 0, "imported children not handled");

        var fieldExport = linker.Exports[currentFieldIndex - 1];
        linker.Seek(fieldExport.SerialOffset);

        UField field = new(linker, fieldExport, currentFieldIndex - 1);
        field.Serialise(linker);

        var fieldClassName = linker.GetObjectName(fieldExport.ClassIndex);
        if (fieldClassName.Resolved.EndsWith("Property"))
        {
          var propertyName = fieldExport.ObjectName;
          Properties.Add(propertyName);

          if (PropertyMap.ContainsKey(propertyName.Resolved)) throw new PackageCorruptException("duplicate property");
          PropertyMap[propertyName.Resolved] = linker.SerialiseProperty(fieldExport, currentFieldIndex - 1);
        }

        currentFieldIndex = field.NextIndex;
      }
    }


    linker.Seek(offset);
  }
}

public class UState(ULinker linker, FObjectExport export, int linkerIndex) : UStruct(linker, export, linkerIndex)
{
}

public class UClass(ULinker linker, FObjectExport export, int linkerIndex) : UState(linker, export, linkerIndex)
{
}

public class UEnum(ULinker linker, FObjectExport export, int linkerIndex) : UField(linker, export, linkerIndex)
{
  public FName[] Names;

  public override void Serialise(ULinker linker)
  {
    base.Serialise(linker);

    linker.Serialise(ref Names);
  }
}

public class Bootstrap(string basePath)
{
  public string BasePath = basePath;
  public ULinker[] Linkers;

  public void GenerateDataStructures(string[] packageNames, string to)
  {
    Linkers = new ULinker[packageNames.Length];

    int linkerIndex = 0;
    foreach (string packageName in packageNames)
    {
      byte[] data = File.ReadAllBytes(Path.Join(BasePath, packageName + ".upk"));
      var linker = new ULinker(packageName, data);
      Linkers[linkerIndex++] = linker;

      FPackageFileSummary summary = new();
      summary.Serialise(linker);


      linker.Seek(summary.NameOffset);
      linker.Names = new string[summary.NameCount];
      for (int i = 0; i < summary.NameCount; ++i)
      {
        ulong flags = 0;
        string name = "";

        linker.Serialise(ref name);
        linker.Serialise(ref flags);

        string nameSegment = FName.Split(name, out _);

        linker.Names[i] = name;
        linker.NameMap[nameSegment] = i;
      }

      linker.Seek(summary.ImportOffset);
      linker.Imports = new FObjectImport[summary.ImportCount];
      for (int i = 0; i < summary.ImportCount; ++i)
      {
        linker.Serialise(ref linker.Imports[i]);
        linker.Imports[i].ClassName.ResolveFrom(linker.Names);
        linker.Imports[i].ClassPackage.ResolveFrom(linker.Names);
        linker.Imports[i].ObjectName.ResolveFrom(linker.Names);
      }

      linker.Seek(summary.ExportOffset);
      linker.Exports = new FObjectExport[summary.ExportCount];
      for (int i = 0; i < summary.ExportCount; ++i)
      {
        linker.Serialise(ref linker.Exports[i]);
        linker.Exports[i].ObjectName.ResolveFrom(linker.Names);
      }

      for (int i = 0; i < summary.ExportCount; ++i)
      {
        var export = linker.Exports[i];
        linker.SerialiseObjectExport(linker.Name, export, i);
      }

      /* apply patches */
      {
        var asm = Assembly.GetExecutingAssembly();

        List<Type> patchedClasses = new();
        string patchNamespace = "ue3.Patch." + linker.Name;
        foreach (var type in asm.GetTypes())
          if (type.Namespace == patchNamespace)
            patchedClasses.Add(type);

        foreach (var patch in patchedClasses)
        {
          var className = FName.ResolveNameAndCorrectCasing(patch.Name);

          UClass patchedClass;
          if (linker.classes.ContainsKey(patch.Name))
          {
            patchedClass = linker.classes[patch.Name];
          }
          else
          {
            FObjectExport fakeExport = new();
            fakeExport.ObjectName = className;
            patchedClass = new UClass(linker, fakeExport, -1);

            linker.classes[patch.Name] = patchedClass;
          }

          if (patch.BaseType != null)
            patchedClass.SuperFieldName = FName.ResolveNameAndCorrectCasing(patch.BaseType.Name);
          patchedClass.hasNativeSerialiser = Attribute.GetCustomAttribute(patch, typeof(NativeAttribute)) != null;

          foreach (var field in patch.GetFields(BindingFlags.Instance | BindingFlags.Public))
          {
            var propertyName = FName.ResolveNameAndCorrectCasing(field.Name);

            UProperty patchedProperty;
            if (patchedClass.PropertyMap.ContainsKey(field.Name))
            {
              patchedProperty = patchedClass.PropertyMap[field.Name];
            }
            else
            {
              FObjectExport fakeExport = new();
              fakeExport.ObjectName = propertyName;
              // create correct type
              patchedProperty = new UProperty(linker, fakeExport, -1);
              patchedClass.PropertyMap[field.Name] = patchedProperty;
              patchedClass.Properties.Add(propertyName);
            }
          }

          // iterate properties
          // iterate contained structs
        }
      }


      /* codegen */
      {
        var file = File.OpenWrite(Path.Join(to, linker.Name.Resolved + ".cs"));
        var stream = new StreamWriter(file);

        stream.Write("/*===========================================================================\n" +
                     " *  This file was automatically generated. DO NOT modify!\n" +
                     "===========================================================================*/\n");
        stream.Write("namespace ue3.Gen;\n\n");

        foreach (var pair in linker.enums)
        {
          UEnum enumeration = pair.Value;
          stream.Write("public enum {0}\n{{\n", enumeration.Name.Resolved);
          foreach (FName name in enumeration.Names)
            stream.Write("  {0},\n", name.Resolved);
          stream.Write("}\n\n");
        }

        foreach (var pair in linker.classes)
        {
          UClass uClass = pair.Value;

          char prefix = linker.DerivesFromActor(uClass.Name.Resolved) ? 'A' : 'U';
          char superPrefix = uClass.Name == EName.Actor ? 'U' : prefix;
          string superClass = uClass.SuperFieldIndex == 0 ? "" : " : " + superPrefix + linker.GetObjectName(uClass.SuperFieldIndex).Resolved;
          stream.Write("public class {0}{1}{2}\n{{\n", prefix, uClass.Name.Resolved, superClass);

          if (linker.structuresByOuter.ContainsKey(uClass.Name.Resolved))
          {
            Dictionary<string, UStruct> byOuter = linker.structuresByOuter[uClass.Name.Resolved];

            foreach (var structPair in byOuter)
            {
              UStruct uStruct = structPair.Value;

              string superStruct = uStruct.SuperFieldIndex == 0 ? "" : " : F" + linker.GetObjectName(uStruct.SuperFieldIndex).Resolved;
              stream.Write("  public class F{0}{1}\n", uStruct.Name.Resolved, superStruct);
              stream.Write("  {\n");
              stream.Write("  }\n\n");
            }
          }

          foreach (FName propertyName in uClass.Properties)
          {
            UProperty property = uClass.PropertyMap[propertyName.Resolved];
            string typename = FormatPropertyType(property, uClass.Name.Resolved);

            stream.Write("  public {0} {1};\n", typename, property.Name.Resolved);
          }

          stream.Write("}\n\n");
        }

        stream.Close();
        file.Close();
      }
    }
  }

  private string FormatPropertyType(UProperty property, string className)
  {
    FName fieldClassName = property.Linker.GetObjectName(property.Export.ClassIndex);

    if (fieldClassName == EName.ArrayProperty)
    {
      UArrayProperty arrayProperty = property as UArrayProperty;
      string inner = FormatPropertyType(arrayProperty.Inner, className);
      return String.Format("List<{0}>", inner);
    }

    if (fieldClassName == EName.BoolProperty) return "bool";
    if (fieldClassName == EName.ByteProperty)
    {
      UByteProperty byteProperty = property as UByteProperty;
      if (byteProperty.InnerIndex == 0) return "byte";
      return property.Linker.GetObjectName(byteProperty.InnerIndex).Resolved;
    }

    if (fieldClassName == EName.DelegateProperty) return "FScriptDelegate";
    if (fieldClassName == EName.FloatProperty) return "float";
    if (fieldClassName == EName.InterfaceProperty) return "FScriptInterface";
    if (fieldClassName == EName.IntProperty) return "int";
    if (fieldClassName == EName.MapProperty)
    {
      UMapProperty mapProperty = property as UMapProperty;

      string key = "byte";
      if (mapProperty.KeyIndex != 0)
      {
        Debug.Assert(mapProperty.KeyIndex > 0);
        FObjectExport export = property.Linker.Exports[mapProperty.KeyIndex - 1];
        UProperty keyProperty = property.Linker.SerialiseProperty(export, mapProperty.KeyIndex - 1);
        key = FormatPropertyType(keyProperty, className);
      }

      string mapped = "byte";
      if (mapProperty.MappedIndex != 0)
      {
        Debug.Assert(mapProperty.MappedIndex > 0);
        FObjectExport export = property.Linker.Exports[mapProperty.MappedIndex - 1];
        UProperty mappedProperty = property.Linker.SerialiseProperty(export, mapProperty.MappedIndex - 1);
        mapped = FormatPropertyType(mappedProperty, className);
      }

      return String.Format("Dictionary<{0}, {1}>", key, mapped);
    }

    if (fieldClassName == EName.NameProperty) return "FName";
    if (fieldClassName == EName.StrProperty) return "string";
    if (fieldClassName == EName.StructProperty)
    {
      UStructProperty structProperty = property as UStructProperty;
      string name = property.Linker.GetObjectName(structProperty.StructIndex).Resolved;
      if (name == "QWord") return "ulong";
      if (name == "Double") return "double";


      string outer = property.Linker.GetOuterName(structProperty.StructIndex).Resolved;
      if (property.Linker.DerivesFrom(className, outer)) return "F" + name;

      char outerPrefix = property.Linker.DerivesFromActor(outer) ? 'A' : 'U';
      return String.Format("{0}{1}.F{2}", outerPrefix, outer, name);
    }

    if (fieldClassName == EName.ObjectProperty || fieldClassName == EName.ClassProperty || fieldClassName == "ComponentProperty")
    {
      UObjectProperty objectProperty = property as UObjectProperty;

      string objectName = property.Linker.GetObjectName(objectProperty.PropertyClassIndex).Resolved;
      char prefix = property.Linker.DerivesFromActor(objectName) ? 'A' : 'U';
      return prefix + objectName;
    }

    throw new PackageCorruptException("unknown property type");
  }
}