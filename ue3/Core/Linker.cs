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
      archive.Serialise(ref ClassPackage);
      archive.Serialise(ref ClassName);
      archive.Serialise(ref OuterIndex);
      archive.Serialise(ref ObjectName);
    }
  }

  public partial class FObjectExport
  {
    public void Serialise(FArchive archive)
    {
      archive.Serialise(ref ClassIndex);
      archive.Serialise(ref SuperIndex);
      archive.Serialise(ref OuterIndex);
      archive.Serialise(ref ObjectName);
      archive.Serialise(ref ArchetypeIndex);
      archive.Serialise(ref ObjectFlags);
      archive.Serialise(ref SerialSize);
      archive.Serialise(ref SerialOffset);
      archive.Serialise(ref ExportFlags);
      archive.Serialise(ref GenerationNetObjectCount);
      PackageGuid = new();
      PackageGuid.Serialise(archive);
      archive.Serialise(ref PackageFlags);
    }
  }
}

public class ULinkerLoad : ULinker
{
  public static Dictionary<string, string> FileCache = new();
  public static string Locale;

  public FObjectExport[] Exports;
  public FObjectImport[] Imports;
  public string[] Names;


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

  public FName GetEntryClass(int entryIndex)
  {
    if (entryIndex == 0) return new FName(EName.None);
    if (entryIndex < 0) return Imports[-entryIndex - 1].ClassName;
    return GetEntryName(Exports[entryIndex - 1].ClassIndex);
  }

  public FName GetEntryName(int entryIndex)
  {
    if (entryIndex == 0) return new FName(EName.None);
    if (entryIndex < 0) return Imports[-entryIndex - 1].ObjectName;
    return Exports[entryIndex - 1].ObjectName;
  }


  public ULinkerLoad(string name, string file)
  {
    Name = FName.ResolveName(name);

    archive = new FArchive(file);
    Summary = new();
    Summary.PackageName = name;
    Summary.PackagePath = file;
    Summary.Serialise(archive);
  }

  public void Load()
  {
    archive.Seek(Summary.NameOffset);
    Names = new string[Summary.NameCount];
    NameMap = new(Summary.NameCount);
    for (int i = 0; i < Summary.NameCount; ++i)
    {
      ulong flags = 0;
      string name = "";

      archive.Serialise(ref name);
      archive.Serialise(ref flags);

      Names[i] = name;
      NameMap.Add(FName.ResolveNameAndCorrectCasing(name));
    }
    archive.SetNames(Names);

    archive.Seek(Summary.ImportOffset);
    Imports = new FObjectImport[Summary.ImportCount];
    for (int i = 0; i < Summary.ImportCount; ++i)
    {
      Imports[i] = new();
      Imports[i].Serialise(archive);
    }

    archive.Seek(Summary.ExportOffset);
    Exports = new FObjectExport[Summary.ExportCount];
    for (int i = 0; i < Summary.ExportCount; ++i)
    {
      Exports[i] = new();
      Exports[i].Serialise(archive);
    }
  }
}