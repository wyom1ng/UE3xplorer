namespace ue3bootstrap;

public struct FGuid : ISerialisable
{
  public uint A, B, C, D;

  public void Serialise(FArchive archive)
  {
    archive.Serialise(ref A);
    archive.Serialise(ref B);
    archive.Serialise(ref C);
    archive.Serialise(ref D);
  }
}

public struct FGenerationInfo : ISerialisable
{
  public int ExportCount;
  public int NameCount;
  public int NetObjectCount;

  public void Serialise(FArchive archive)
  {
    archive.Serialise(ref ExportCount);
    archive.Serialise(ref NameCount);
    archive.Serialise(ref NetObjectCount);
  }
}

public struct FCompressedChunk : ISerialisable
{
  public int UncompressedOffset;
  public int UncompressedSize;
  public int CompressedOffset;
  public int CompressedSize;

  public void Serialise(FArchive archive)
  {
    archive.Serialise(ref UncompressedOffset);
    archive.Serialise(ref UncompressedSize);
    archive.Serialise(ref CompressedOffset);
    archive.Serialise(ref CompressedSize);
  }
}

public struct FPackageFileSummary
{
  public const uint PACKAGE_FILE_TAG = 0x9E2A83C1;
  public const uint PACKAGE_FILE_TAG_BYTESWAPPED = 0xC1832A9E;

  public int Tag;
  public uint RawFileVersion;
  public EUnrealEngineObjectVersion FileVersion;
  public short FileVersionLicensee;
  public int TotalHeaderSize;
  public uint PackageFlags;
  public string FolderName;
  public int NameCount;
  public int NameOffset;
  public int ExportCount;
  public int ExportOffset;
  public int ImportCount;
  public int ImportOffset;
  public int DependsOffset;
  public int ImportExportGuidsOffset;
  public int ImportGuidsCount;
  public int ExportGuidsCount;
  public int ThumbnailTableOffset;
  public FGuid Guid;
  public FGenerationInfo[] Generations;
  public int EngineVersion;
  public int CookedContentVersion;
  public uint CompressionFlags;
  public uint PackageSource;
  public FCompressedChunk[] CompressedChunks;
  public string[] AdditionalPackagesToCook;

  public void Serialise(FArchive archive)
  {
    archive.Serialise(ref Tag);
    if ((uint)Tag == PACKAGE_FILE_TAG_BYTESWAPPED)
      throw new NotImplementedException("byte swapping is not implemented");

    if ((uint)Tag != PACKAGE_FILE_TAG)
      throw new PackageCorruptException();

    archive.Serialise(ref RawFileVersion);
    switch (RawFileVersion & 0xffff)
    {
      case 902:
        FileVersion = EUnrealEngineObjectVersion.VER_ADD_NORMAL_PARAMETERS;
        break;
      case 903:
        FileVersion = EUnrealEngineObjectVersion.VER_ANIMNOTIFY_TRAIL_SAMPLEFRAMERATE;
        break;
      case 904:
        FileVersion = EUnrealEngineObjectVersion.VER_VISUALIZETEXTURE;
        break;
      default:
        FileVersion = (EUnrealEngineObjectVersion)(RawFileVersion & 0xffff);
        break;
    }

    FileVersionLicensee = (short)((RawFileVersion >> 16) & 0xffff);

    archive.Serialise(ref TotalHeaderSize);
    archive.Serialise(ref FolderName);
    archive.Serialise(ref PackageFlags);
    archive.Serialise(ref NameCount);
    archive.Serialise(ref NameOffset);
    archive.Serialise(ref ExportCount);
    archive.Serialise(ref ExportOffset);
    archive.Serialise(ref ImportCount);
    archive.Serialise(ref ImportOffset);
    archive.Serialise(ref DependsOffset);

    if (FileVersion >= EUnrealEngineObjectVersion.VER_ADDED_CROSSLEVEL_REFERENCES)
    {
      archive.Serialise(ref ImportExportGuidsOffset);
      archive.Serialise(ref ImportGuidsCount);
      archive.Serialise(ref ExportGuidsCount);
    }
    else
    {
      ImportExportGuidsOffset = -1;
    }

    if (FileVersion >= EUnrealEngineObjectVersion.VER_ASSET_THUMBNAILS_IN_PACKAGES)
      archive.Serialise(ref ThumbnailTableOffset);

    archive.Serialise(ref Guid);
    archive.Serialise(ref Generations);

    archive.Serialise(ref EngineVersion);
    archive.Serialise(ref CookedContentVersion);
    archive.Serialise(ref CompressionFlags);

    archive.Serialise(ref CompressedChunks);
    archive.Serialise(ref PackageSource);

    if (FileVersion >= EUnrealEngineObjectVersion.VER_ADDITIONAL_COOK_PACKAGE_SUMMARY)
      archive.Serialise(ref AdditionalPackagesToCook);
  }
}

public struct FObjectImport : ISerialisable
{
  public FName ClassPackage;
  public FName ClassName;
  public int OuterIndex;
  public FName ObjectName;

  public void Serialise(FArchive archive)
  {
    archive.Serialise(ref ClassPackage);
    archive.Serialise(ref ClassName);
    archive.Serialise(ref OuterIndex);
    archive.Serialise(ref ObjectName);
  }
}

public struct FObjectExport : ISerialisable
{
  public int ClassIndex;
  public int SuperIndex;
  public int OuterIndex;
  public FName ObjectName;
  public int ArchetypeIndex;
  public EObjectFlags ObjectFlags;

  public int SerialSize;
  public int SerialOffset;
  public uint ExportFlags;
  public int[] GenerationNetObjectCount;
  public FGuid PackageGuid;
  public uint PackageFlags;

  public UObject? ResolvedObject;

  public void Serialise(FArchive archive)
  {
    archive.Serialise(ref ClassIndex);
    archive.Serialise(ref SuperIndex);
    archive.Serialise(ref OuterIndex);
    archive.Serialise(ref ObjectName);
    archive.Serialise(ref ArchetypeIndex);

    ulong objectFlagsRaw = (ulong)ObjectFlags;
    archive.Serialise(ref objectFlagsRaw);
    ObjectFlags = (EObjectFlags)objectFlagsRaw;

    archive.Serialise(ref SerialSize);
    archive.Serialise(ref SerialOffset);

    archive.Serialise(ref ExportFlags);
    archive.Serialise(ref GenerationNetObjectCount);
    archive.Serialise(ref PackageGuid);
    archive.Serialise(ref PackageFlags);
  }
}