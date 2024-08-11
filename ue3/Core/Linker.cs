using System.Diagnostics;
using System.IO;

namespace ue3;

public partial class ULinker
{
  public partial class FCompressedChunk
  {
    public void Serialise(FArchive archive)
    {
      archive.Serialise(ref CompressedSize);
      archive.Serialise(ref UncompressedSize);
      archive.Serialise(ref CompressedOffset);
      archive.Serialise(ref UncompressedOffset);
    }
  }

  public partial class FGenerationInfo
  {
    public void Serialise(FArchive archive)
    {
      archive.Serialise(ref ExportCount);
      archive.Serialise(ref NameCount);
      archive.Serialise(ref NetObjectCount);
    }
  }

  public partial class FPackageFileSummary
  {
    public const uint PACKAGE_FILE_TAG = 0x9E2A83C1;
    public const uint PACKAGE_FILE_TAG_BYTESWAPPED = 0xC1832A9E;

    public void Serialise(FArchive archive)
    {
      FileSize = archive.Size();

      archive.Serialise(ref Tag);
      if ((uint)Tag == PACKAGE_FILE_TAG_BYTESWAPPED)
        throw new NotImplementedException("byte swapping is not implemented");

      if ((uint)Tag != PACKAGE_FILE_TAG)
        throw new PackageCorruptException();

      archive.Serialise(ref FileVersionRaw);
      switch (FileVersionRaw & 0xffff)
      {
        case 902:
          FileVersion = (ushort)EUnrealEngineObjectVersion.VER_ADD_NORMAL_PARAMETERS;
          break;
        case 903:
          FileVersion = (ushort)EUnrealEngineObjectVersion.VER_ANIMNOTIFY_TRAIL_SAMPLEFRAMERATE;
          break;
        case 904:
          FileVersion = (ushort)EUnrealEngineObjectVersion.VER_VISUALIZETEXTURE;
          break;
        default:
          FileVersion = (ushort)(FileVersionRaw & 0xffff);
          break;
      }

      FileVersionLicensee = (ushort)((FileVersionRaw >> 16) & 0xffff);

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

      if (FileVersion >= (ushort)EUnrealEngineObjectVersion.VER_ADDED_CROSSLEVEL_REFERENCES)
      {
        archive.Serialise(ref ImportExportGuidsOffset);
        archive.Serialise(ref ImportGuidsCount);
        archive.Serialise(ref ExportGuidsCount);
      }
      else
      {
        ImportExportGuidsOffset = -1;
      }

      if (FileVersion >= (ushort)EUnrealEngineObjectVersion.VER_ASSET_THUMBNAILS_IN_PACKAGES)
        archive.Serialise(ref ThumbnailTableOffset);

      Guid = new();
      Guid.Serialise(archive);
      archive.Serialise(ref Generations);

      archive.Serialise(ref EngineVersion);
      archive.Serialise(ref CookedContentVersion);
      archive.Serialise(ref CompressionFlags);

      archive.Serialise(ref CompressedChunks);
      archive.Serialise(ref PackageSource);

      if (FileVersion >= (ushort)EUnrealEngineObjectVersion.VER_ADDITIONAL_COOK_PACKAGE_SUMMARY)
        archive.Serialise(ref AdditionalPackagesToCook);
    }
  }

  public partial class FObjectImport
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }

  public partial class FObjectExport
  {
    public void Serialise(FArchive archive)
    {
      throw new NotImplementedException();
    }
  }
}

public class ULinkerLoad : ULinker
{
  public static Dictionary<string, string> FileCache = new();
  public static string Locale;
  
  private FArchive archive;

  public static void InitFileCache(string FilePath, string InLocale)
  {
    Locale = InLocale;
    
    foreach (string file in Directory.GetFiles(FilePath, "*.upk", SearchOption.TopDirectoryOnly))
    {
      string name = Path.GetFileNameWithoutExtension(file);
      bool hasLocaleExtension = name.EndsWith("_" + Locale);
      if (hasLocaleExtension) name = name.Substring(0, name.Length - Locale.Length - 1);

      // ignore duplicates (locale specific archives override generic versions)
      if (FileCache.ContainsKey(name) && !hasLocaleExtension) continue;

      FileCache[name] = file;
    }
  }

  public static IEnumerable<FPackageFileSummary> LoadSummaries()
  {
    foreach (var pair in FileCache)
    {
      ULinkerLoad loader = new ULinkerLoad(pair.Key, pair.Value);
      GObjLoaders[pair.Key] = loader;
      yield return loader.Summary;
    }
  }


  public ULinkerLoad(string name, string file)
  {
    archive = new FArchive(file);
    Summary = new();
    Summary.PackageName = name;
    Summary.PackagePath = file;
    Summary.Serialise(archive);
  }
}