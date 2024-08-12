using System.Diagnostics;

namespace ue3;

public partial class UObject
{
  public partial class FPointer
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FQWord
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FDouble
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FUntypedBulkData_Mirror
  {
    public bool HasAnyFlags(EBulkDataFlags flags)
    {
      return (BulkDataFlags & (int)flags) != 0;
    }

    public void Serialise(FArchive Archive)
    {
      Archive.Serialise(ref BulkDataFlags);
      Archive.Serialise(ref ElementCount);
      Archive.Serialise(ref BulkDataSizeOnDisk);
      Archive.Serialise(ref BulkDataOffsetInFile);

      if (!HasAnyFlags(EBulkDataFlags.StoreInSeparateFile))
      {
        BulkData = new byte[ElementCount * GetElementSize()];
        SerialiseBulkData(Archive, BulkData);
      }
    }

    public void SerialiseBulkData(FArchive Archive, byte[] To)
    {
      if (HasAnyFlags(EBulkDataFlags.SerializeCompressed)) throw new NotImplementedException();
      else
      {
        Archive.SerialiseRaw(ref To);
      }
    }

    public virtual int GetElementSize()
    {
      Debug.Assert(false);
      return 0;
    }
  }

  public partial class FByteBulkData
  {
    public override int GetElementSize()
    {
      return sizeof(byte);
    }
  }

  public partial class FWordBulkData
  {
    public override int GetElementSize()
    {
      return sizeof(ushort);
    }
  }

  public partial class FIntBulkData
  {
    public override int GetElementSize()
    {
      return sizeof(uint);
    }
  }

  public partial class FGuid
  {
    public void Serialise(FArchive Archive)
    {
      Archive.Serialise(ref A);
      Archive.Serialise(ref B);
      Archive.Serialise(ref C);
      Archive.Serialise(ref D);
    }

    public new string ToString()
    {
      return String.Format("{0:x8}-{0:x8}-{0:x8}-{0:x8}", A, B, C, D);
    }
  }

  public partial class FVector
  {
    public void Serialise(FArchive Archive)
    {
      Archive.Serialise(ref X);
      Archive.Serialise(ref Y);
      Archive.Serialise(ref Z);
    }
  }

  public partial class FColor
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FLinearColor
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FBox
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FVector4
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FVector2D
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FTwoVectors
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FPlane
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FRotator
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FQuat
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FBoxSphereBounds
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FMatrix
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FPackedNormal
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FVector2DHalf
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FSphere
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FQuantizedSHVector
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FQuantizedSHVectorRGB
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FWordBulkData
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FIntBulkData
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FURL
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FGuidPair
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FPushedState
  {
    public void Serialise(FArchive Archive)
    {
      Archive.Serialise(ref State);
      Archive.Serialise(ref Node);
      Archive.Serialise(ref Offset);
    }
  }

  public partial class FTextureLookup
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FMaterial
  {
    public void Serialise(FArchive Archive)
    {
      throw new NotImplementedException();
    }
  }

  public virtual void Serialise(FArchive Archive)
  {
    if (Class != GetStaticClass<UClass>())
    {
      Linker.FullyLoadObject(Class);
    }

    if (HasAnyFlags(EObjectFlags.RF_HasStack))
    {
      Archive.Serialise(ref StateFrame.Node);
      Archive.Serialise(ref StateFrame.StateNode);

      if (Archive.Version < EFileVersion.REDUCED_PROBEMASK_REMOVED_IGNOREMASK) throw new NotImplementedException();
      else
      {
        Archive.Serialise(ref StateFrame.ProbeMask);
      }

      if (Archive.Version < EFileVersion.REDUCED_STATEFRAME_LATENTACTION_SIZE) throw new NotImplementedException();
      else
      {
        Archive.Serialise(ref StateFrame.LatentAction);
      }

      Archive.Serialise(ref StateFrame.StateStack);

      if (StateFrame.Node != null)
      {
        Linker.FullyLoadObject(StateFrame.Node);
        Archive.Serialise(ref StateFrame.Offset);
      }
    }

    Archive.Serialise(ref NetIndex);

    if (Class != GetStaticClass<UClass>())
    {
      UStruct.SerialiseTaggedProperties(Archive, this, Name);
    }
  }

  public static Dictionary<string, UObject> GObjObjects = new();
  public static Dictionary<string, ULinkerLoad> GObjLoaders = new();
  public static Dictionary<string, UClass> GStaticClasses = new();

  public string GetPath()
  {
    string path = "";
    if (Outer != null) path += Outer.Name.Resolved + ":";
    path += Class.Name.Resolved + "'";
    path += Name.Resolved;
    return path;
  }

  public static UClass GetStaticClass<T>() where T : UObject
  {
    return GetStaticClass(typeof(T).Name.Substring(1));
  }

  public static UClass GetStaticClass(string name)
  {
    if (GStaticClasses.TryGetValue(name, out UClass StaticClass)) return StaticClass;

    StaticClass = new UClass();
    StaticClass.Name = FName.ResolveName(name);

    GStaticClasses[name] = StaticClass;
    GObjObjects["Core:Class'" + name] = StaticClass;

    if (StaticClass.Name == EName.Class) StaticClass.Class = StaticClass;
    else StaticClass.Class = GetStaticClass<UClass>();


    Type ClassType = Type.GetType("ue3.U" + name);
    if (ClassType == null) ClassType = Type.GetType("ue3.A" + name);
    if (ClassType == null) throw new PackageCorruptException("unknown class");
    if (ClassType != typeof(UObject))
    {
      StaticClass.SuperField = GetStaticClass(ClassType.BaseType.Name.Substring(1));
    }

    return StaticClass;
  }

  public bool IsA<T>() where T : UObject
  {
    return IsA(GetStaticClass<T>());
  }

  public bool IsA(UClass SomeBase)
  {
    for (UClass TempClass = Class; TempClass != null; TempClass = (UClass)TempClass.SuperField)
    {
      if (TempClass == SomeBase)
      {
        return true;
      }
    }

    return false;
  }

  public void SetFlag(EObjectFlags flag)
  {
    ObjectFlags |= (ulong)flag;
  }

  public void ClearFlag(EObjectFlags flag)
  {
    ObjectFlags &= ~(ulong)flag;
  }

  public bool HasAnyFlags(EObjectFlags flags)
  {
    return (ObjectFlags & (ulong)flags) != 0;
  }

  public bool IsTemplate(EObjectFlags TemplateTypes = EObjectFlags.RF_ArchetypeObject | EObjectFlags.RF_ClassDefaultObject)
  {
    for (UObject TestOuter = this; TestOuter != null; TestOuter = TestOuter.Outer)
    {
      if (TestOuter.HasAnyFlags(TemplateTypes))
      {
        return true;
      }
    }

    return false;
  }
}