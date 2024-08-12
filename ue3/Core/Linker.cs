using System.Diagnostics;
using System.IO;
using System.Reflection;

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
          FileVersion = (ushort)EFileVersion.ADD_NORMAL_PARAMETERS;
          break;
        case 903:
          FileVersion = (ushort)EFileVersion.ANIMNOTIFY_TRAIL_SAMPLEFRAMERATE;
          break;
        case 904:
          FileVersion = (ushort)EFileVersion.VISUALIZETEXTURE;
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

      if (FileVersion >= (ushort)EFileVersion.ADDED_CROSSLEVEL_REFERENCES)
      {
        archive.Serialise(ref ImportExportGuidsOffset);
        archive.Serialise(ref ImportGuidsCount);
        archive.Serialise(ref ExportGuidsCount);
      }
      else
      {
        ImportExportGuidsOffset = -1;
      }

      if (FileVersion >= (ushort)EFileVersion.ASSET_THUMBNAILS_IN_PACKAGES)
        archive.Serialise(ref ThumbnailTableOffset);

      Guid = new();
      Guid.Serialise(archive);
      archive.Serialise(ref Generations);

      archive.Serialise(ref EngineVersion);
      archive.Serialise(ref CookedContentVersion);
      archive.Serialise(ref CompressionFlags);

      archive.Serialise(ref CompressedChunks);
      archive.Serialise(ref PackageSource);

      if (FileVersion >= (ushort)EFileVersion.ADDITIONAL_COOK_PACKAGE_SUMMARY)
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

  public virtual void FullyLoadObject(UObject InObject)
  {
  }

  public virtual void SerialiseObjectRef<T>(ref T InObject) where T : UObject
  {
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
    var asm = Assembly.GetExecutingAssembly();
    foreach (Type type in asm.GetTypes().Where(t => t == typeof(UObject) || t.IsSubclassOf(typeof(UObject))))
    {
      GetStaticClass(type.Name.Substring(1));
    }

    foreach (var pair in FileCache)
    {
      ULinkerLoad loader = new ULinkerLoad(pair.Key, pair.Value);
      loader.Class = GetStaticClass<ULinkerLoad>();
      GObjLoaders[pair.Key] = loader;
      GObjObjects[loader.GetPath()] = loader;
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
    archive.SetSourceLinker(this);

    Summary = new();
    Summary.PackageName = name;
    Summary.PackagePath = file;
    Summary.Serialise(archive);
    archive.Version = (EFileVersion)Summary.FileVersion;
  }

  public UObject LoadExport(FObjectExport Export)
  {
    if (Export._Object != null) return Export._Object;

    UObject outer = LoadByIndex(Export.OuterIndex);
    // loading Outer loaded this object
    if (Export._Object != null) return Export._Object;

    UObject CreatedObject;
    if (Export.ClassIndex == 0) // this is a class
    {
      CreatedObject = GetStaticClass(Export.ObjectName.Resolved);
      CreatedObject.Class = GetStaticClass<UClass>();
    }
    else
    {
      FName ClassName = GetEntryName(Export.ClassIndex);
      Type ClassType = Type.GetType("ue3.U" + ClassName.Resolved);
      if (ClassType == null) ClassType = Type.GetType("ue3.A" + ClassName.Resolved);
      if (ClassType == null) throw new PackageCorruptException("unknown class");

      Debug.Assert(ClassType.IsSubclassOf(typeof(UObject)));
      CreatedObject = (UObject)Activator.CreateInstance(ClassType);
      CreatedObject.Class = (UClass)LoadByIndex(Export.ClassIndex);
      Debug.Assert(CreatedObject.Class != null);

      // loading Class loaded this object
      if (Export._Object != null) return Export._Object;
    }

    CreatedObject.Outer = outer;
    CreatedObject.Name = Export.ObjectName;
    CreatedObject.Linker = this;
    CreatedObject.LinkerIndex = Array.FindIndex(Exports, match => match == Export);
    CreatedObject.ObjectFlags = Export.ObjectFlags;
    CreatedObject.SetFlag(EObjectFlags.RF_NeedLoad);

    GObjObjects[CreatedObject.GetPath()] = CreatedObject;
    return Export._Object = CreatedObject;
  }

  public UObject LoadImport(FObjectImport Import)
  {
    if (Import.XObject != null) return Import.XObject;

    if (Import.ClassName == EName.Class)
    {
      UObject ExistingObject = GetStaticClass(Import.ObjectName.Resolved);
      Import.SourceLinker = ExistingObject.Linker;
      Import.SourceIndex = ExistingObject.LinkerIndex;
      Import.XObject = ExistingObject;
      return ExistingObject;
    }

    string path = "";
    FName OuterName = GetEntryName(Import.OuterIndex);
    if (Import.OuterIndex != 0) path += OuterName.Resolved + ":";
    path += Import.ClassName.Resolved + "'";
    path += Import.ObjectName.Resolved;

    if (GObjObjects.ContainsKey(path))
    {
      UObject ExistingObject = GObjObjects[path];
      Import.SourceLinker = ExistingObject.Linker;
      Import.SourceIndex = ExistingObject.LinkerIndex;
      Import.XObject = ExistingObject;
      return ExistingObject;
    }

    GObjLoaders[Import.ClassPackage.Resolved].LoadImportExports();
    if (GObjObjects.ContainsKey(path))
    {
      UObject ExistingObject = GObjObjects[path];
      Import.SourceLinker = ExistingObject.Linker;
      Import.SourceIndex = ExistingObject.LinkerIndex;
      Import.XObject = ExistingObject;
      return ExistingObject;
    }

    if (OuterName != EName.None)
    {
      GObjLoaders[OuterName.Resolved].LoadImportExports();
      if (GObjObjects.ContainsKey(path))
      {
        UObject ExistingObject = GObjObjects[path];
        Import.SourceLinker = ExistingObject.Linker;
        Import.SourceIndex = ExistingObject.LinkerIndex;
        Import.XObject = ExistingObject;
        return ExistingObject;
      }
    }

    // @TODO: Import.ClassName == ObjectRedirector
    return null;
  }

  public UObject LoadByIndex(int index)
  {
    if (index == 0) return null;
    if (index < 0) return LoadImport(Imports[-index - 1]);
    else return LoadExport(Exports[index - 1]);
  }

  public void LoadImportExports()
  {
    if (Names != null) return; // already loaded

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

  public override void FullyLoadObject(UObject InObject)
  {
    if (!InObject.HasAnyFlags(EObjectFlags.RF_NeedLoad)) return;
    if (InObject.Linker != this)
    {
      InObject.Linker.FullyLoadObject(InObject);
      return;
    }

    if (InObject.IsA<UField>())
    {
      UField InStruct = (UField)InObject;
      if (InStruct.SuperField != null) FullyLoadObject(InStruct.SuperField);
      // loading the `SuperField` may have loaded us as well
      if (!InStruct.HasAnyFlags(EObjectFlags.RF_NeedLoad)) return;
    }

    InObject.ClearFlag(EObjectFlags.RF_NeedLoad);

    if (InObject.HasAnyFlags(EObjectFlags.RF_ClassDefaultObject))
    {
      // @TODO
    }
    else
    {
      FObjectExport Export = Exports[InObject.LinkerIndex];
      archive.Seek(Export.SerialOffset);

      InObject.Serialise(archive);

      int SerialisedBytes = archive.Tell() - Export.SerialOffset;
      if (SerialisedBytes < Export.SerialSize)
      {
        Debug.WriteLine("failed to fully serialise {0}'{1}, missed {2} bytes", InObject.Class.Name.Resolved, InObject.Name.Resolved,
          Export.SerialSize - SerialisedBytes);
      }
      else
      {
        Debug.WriteLine("failed to serialise {0}'{1}, out of bounds by {2} bytes", InObject.Class.Name.Resolved, InObject.Name.Resolved,
          SerialisedBytes - Export.SerialSize);
      }
    }
  }

  public override void SerialiseObjectRef<T>(ref T InObject)
  {
    int Index = 0;
    archive.Serialise(ref Index);

    if (Index == 0)
    {
      InObject = null;
      return;
    }

    if (Index < 0)
    {
      UObject xObject = Imports[-Index - 1].XObject;
      if (xObject != null) // some imports may be severed
      {
        if (!(xObject is T)) throw new PackageCorruptException();
        InObject = (T)xObject;
      }
    }
    else
    {
      UObject xObject = Exports[Index - 1]._Object;
      if (!(xObject is T)) throw new PackageCorruptException();
      InObject = (T)xObject;
    }
  }
}