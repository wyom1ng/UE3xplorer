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
  public partial class FTexture2DMipMap
  {
    public void Serialise(FArchive Archive)
    {
      Data.Serialise(Archive);
      Archive.Serialise(ref SizeX);
      Archive.Serialise(ref SizeY);
    }
  }

  public override void Serialise(FArchive Archive)
  {
    base.Serialise(Archive);

    Archive.Serialise(ref Mips);

    if (Archive.Version >= EFileVersion.ADDED_TEXTURE_FILECACHE_GUIDS) TextureFileCacheGuid.Serialise(Archive);

    if (Archive.Version < EFileVersion.ADDED_TEXTURE_ORIGINAL_SIZE) throw new NotImplementedException();
    if (Archive.Version < EFileVersion.ADDED_TEXTURE_INTERNALFORMATLODBIAS) throw new NotImplementedException();

    if (Archive.Version >= EFileVersion.ADDED_TEXTURE_FILECACHE_GUIDS)
      Archive.Serialise(ref CachedPVRTCMips);
  }
}