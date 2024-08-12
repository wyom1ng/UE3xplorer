using System.Diagnostics;

namespace ue3;

public partial class UTexture
{
  public override void Serialise(FArchive Archive)
  {
    base.Serialise(Archive);

    SourceArt.Serialise(Archive);
  }
}

public partial class UTexture2D
{
  public partial class FTextureMipBulkData
  {
    public void SerialiseWithOwner(FArchive Archive, UTexture2D Owner)
    {
      Serialise(Archive);

      if (HasAnyFlags(EBulkDataFlags.StoreInSeparateFile) && Owner.TextureFileCacheName != EName.None && BulkDataSizeOnDisk > 0 && ElementCount > 0)
      {
        FArchive TFC = new(Path.Join(ULinkerLoad.BasePath, Owner.TextureFileCacheName.Resolved + ".tfc"));
        BulkData = new byte[ElementCount * GetElementSize()];
        TFC.Seek(BulkDataOffsetInFile);

        if (HasAnyFlags(EBulkDataFlags.SerializeCompressed))
        {
          if (!HasAnyFlags(EBulkDataFlags.SerializeCompressedLZO)) throw new NotImplementedException();

          TFC.SerialiseCompressedLZO(ref BulkData);
        }
        else
        {
          Debug.Assert(BulkDataSizeOnDisk == BulkData.Length);
          TFC.SerialiseRaw(ref BulkData);
        }
      }
    }
  }

  public override void Serialise(FArchive Archive)
  {
    base.Serialise(Archive);

    {
      int length = 0;
      Archive.Serialise(ref length);

      Mips = new(length);
      for (int i = 0; i < length; ++i)
      {
        FTexture2DMipMap Mip = new();
        SerialiseFTexture2DMipMap(Archive, ref Mip);
        Mips.Add(Mip);
      }
    }

    if (Archive.Version >= EFileVersion.ADDED_TEXTURE_FILECACHE_GUIDS) TextureFileCacheGuid.Serialise(Archive);

    if (Archive.Version < EFileVersion.ADDED_TEXTURE_ORIGINAL_SIZE) throw new NotImplementedException();
    if (Archive.Version < EFileVersion.ADDED_TEXTURE_INTERNALFORMATLODBIAS) throw new NotImplementedException();

    if (Archive.Version >= EFileVersion.ADDED_TEXTURE_FILECACHE_GUIDS)
    {
      int length = 0;
      Archive.Serialise(ref length);

      CachedPVRTCMips = new(length);
      for (int i = 0; i < length; ++i)
      {
        FTexture2DMipMap Mip = new();
        SerialiseFTexture2DMipMap(Archive, ref Mip);
        CachedPVRTCMips.Add(Mip);
      }
    }
  }

  private void SerialiseFTexture2DMipMap(FArchive Archive, ref FTexture2DMipMap Mip)
  {
    Mip.Data.SerialiseWithOwner(Archive, this);
    Archive.Serialise(ref Mip.SizeX);
    Archive.Serialise(ref Mip.SizeY);
  }
}