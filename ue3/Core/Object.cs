using System.Diagnostics;

namespace ue3;

public partial class UObject
{
  public partial class FPointer
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FQWord
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FDouble
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FUntypedBulkData_Mirror
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FGuid
  {
    public void Serialise(FArchive archive)
    {
      archive.Serialise(ref A);
      archive.Serialise(ref B);
      archive.Serialise(ref C);
      archive.Serialise(ref D);
    }

    public new string ToString()
    {
      return String.Format("{0:x8}-{0:x8}-{0:x8}-{0:x8}", A, B, C, D);
    }
  }

  public partial class FVector
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FColor
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FLinearColor
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FBox
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FVector4
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FVector2D
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FTwoVectors
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FPlane
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FRotator
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FQuat
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FBoxSphereBounds
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FMatrix
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FPackedNormal
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FVector2DHalf
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FSphere
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FQuantizedSHVector
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FQuantizedSHVectorRGB
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FWordBulkData
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FIntBulkData
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FURL
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FGuidPair
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FPushedState
  {
    public void Serialise(FArchive archive)
    {
      archive.Serialise(ref State);
      archive.Serialise(ref Node);
      archive.Serialise(ref Offset);
    }
  }

  public partial class FTextureLookup
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FMaterial
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public virtual void Serialise(FArchive archive)
  {
    if (Class != GetStaticClass<UClass>())
    {
      Linker.FullyLoadObject(Class);
    }

    if (HasAnyFlags(EObjectFlags.RF_HasStack))
    {
      StateFrame = new();
      archive.Serialise(ref StateFrame.Node);
      archive.Serialise(ref StateFrame.StateNode);

      if (archive.Version < EFileVersion.REDUCED_PROBEMASK_REMOVED_IGNOREMASK) throw new NotImplementedException();
      else
      {
        archive.Serialise(ref StateFrame.ProbeMask);
      }

      if (archive.Version < EFileVersion.REDUCED_STATEFRAME_LATENTACTION_SIZE) throw new NotImplementedException();
      else
      {
        archive.Serialise(ref StateFrame.LatentAction);
      }

      archive.Serialise(ref StateFrame.StateStack);

      if (StateFrame.Node != null)
      {
        Linker.FullyLoadObject(StateFrame.Node);
        archive.Serialise(ref StateFrame.Offset);
      }
    }

    archive.Serialise(ref NetIndex);

    if (Class != GetStaticClass<UClass>())
    {
      // serialise script properties
      throw new NotImplementedException();
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