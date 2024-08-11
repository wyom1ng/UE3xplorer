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
      throw new NotImplementedException();
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

  public void Serialise(FArchive archive)
  {
    throw new NotImplementedException();
  }

  public static List<UObject> GObjObjects = new();
  public static Dictionary<string, ULinkerLoad> GObjLoaders = new();
}