using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace ue3;

public partial class ULinker
{
  public partial class FCompressedChunk
  {
    public void Serialise(FArchive Archive)
    {
      Archive.Serialise(ref CompressedSize);
      Archive.Serialise(ref UncompressedSize);
      Archive.Serialise(ref CompressedOffset);
      Archive.Serialise(ref UncompressedOffset);
    }
  }

  public partial class FGenerationInfo
  {
    public void Serialise(FArchive Archive)
    {
      Archive.Serialise(ref ExportCount);
      Archive.Serialise(ref NameCount);
      Archive.Serialise(ref NetObjectCount);
    }
  }

  public partial class FPackageFileSummary
  {
    public const uint PACKAGE_FILE_TAG = 0x9E2A83C1;
    public const uint PACKAGE_FILE_TAG_BYTESWAPPED = 0xC1832A9E;

    public void Serialise(FArchive Archive)
    {
      FileSize = Archive.Size();

      Archive.Serialise(ref Tag);
      if ((uint)Tag == PACKAGE_FILE_TAG_BYTESWAPPED)
        throw new NotImplementedException("byte swapping is not implemented");

      if ((uint)Tag != PACKAGE_FILE_TAG)
        throw new PackageCorruptException();

      Archive.Serialise(ref FileVersionRaw);
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

      Archive.Serialise(ref TotalHeaderSize);
      Archive.Serialise(ref FolderName);
      Archive.Serialise(ref PackageFlags);
      Archive.Serialise(ref NameCount);
      Archive.Serialise(ref NameOffset);
      Archive.Serialise(ref ExportCount);
      Archive.Serialise(ref ExportOffset);
      Archive.Serialise(ref ImportCount);
      Archive.Serialise(ref ImportOffset);
      Archive.Serialise(ref DependsOffset);

      if (FileVersion >= (ushort)EFileVersion.ADDED_CROSSLEVEL_REFERENCES)
      {
        Archive.Serialise(ref ImportExportGuidsOffset);
        Archive.Serialise(ref ImportGuidsCount);
        Archive.Serialise(ref ExportGuidsCount);
      }
      else
      {
        ImportExportGuidsOffset = -1;
      }

      if (FileVersion >= (ushort)EFileVersion.ASSET_THUMBNAILS_IN_PACKAGES)
        Archive.Serialise(ref ThumbnailTableOffset);

      Guid.Serialise(Archive);
      Archive.Serialise(ref Generations);

      Archive.Serialise(ref EngineVersion);
      Archive.Serialise(ref CookedContentVersion);
      Archive.Serialise(ref CompressionFlags);

      Archive.Serialise(ref CompressedChunks);
      Archive.Serialise(ref PackageSource);

      if (FileVersion >= (ushort)EFileVersion.ADDITIONAL_COOK_PACKAGE_SUMMARY)
        Archive.Serialise(ref AdditionalPackagesToCook);
    }
  }

  public partial class FObjectImport
  {
    public void Serialise(FArchive Archive)
    {
      Archive.Serialise(ref ClassPackage);
      Archive.Serialise(ref ClassName);
      Archive.Serialise(ref OuterIndex);
      Archive.Serialise(ref ObjectName);
    }
  }

  public partial class FObjectExport
  {
    public void Serialise(FArchive Archive)
    {
      Archive.Serialise(ref ClassIndex);
      Archive.Serialise(ref SuperIndex);
      Archive.Serialise(ref OuterIndex);
      Archive.Serialise(ref ObjectName);
      Archive.Serialise(ref ArchetypeIndex);
      Archive.Serialise(ref ObjectFlags);
      Archive.Serialise(ref SerialSize);
      Archive.Serialise(ref SerialOffset);
      Archive.Serialise(ref ExportFlags);
      Archive.Serialise(ref GenerationNetObjectCount);
      PackageGuid.Serialise(Archive);
      Archive.Serialise(ref PackageFlags);
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
  public static string BasePath;
  public static string Locale;

  public FObjectExport[] Exports;
  public FObjectImport[] Imports;
  public string[] Names;


  private FArchive Archive;

  public static void InitFileCache(string FilePath, string InLocale)
  {
    BasePath = FilePath;
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

    Archive = new FArchive(file);
    Archive.SetSourceLinker(this);

    Summary.PackageName = name;
    Summary.PackagePath = file;
    Summary.Serialise(Archive);
    Archive.Version = (EFileVersion)Summary.FileVersion;
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

    Archive.Seek(Summary.NameOffset);
    Names = new string[Summary.NameCount];
    NameMap = new(Summary.NameCount);
    for (int i = 0; i < Summary.NameCount; ++i)
    {
      ulong flags = 0;
      string name = "";

      Archive.Serialise(ref name);
      Archive.Serialise(ref flags);

      Names[i] = name;
      NameMap.Add(FName.ResolveNameAndCorrectCasing(name));
    }

    Archive.SetNames(Names);

    Archive.Seek(Summary.ImportOffset);
    Imports = new FObjectImport[Summary.ImportCount];
    for (int i = 0; i < Summary.ImportCount; ++i)
    {
      Imports[i] = new();
      Imports[i].Serialise(Archive);
    }

    Archive.Seek(Summary.ExportOffset);
    Exports = new FObjectExport[Summary.ExportCount];
    for (int i = 0; i < Summary.ExportCount; ++i)
    {
      Exports[i] = new();
      Exports[i].Serialise(Archive);
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
      Archive.Seek(Export.SerialOffset);

      InObject.Serialise(Archive);

      int SerialisedBytes = Archive.Tell() - Export.SerialOffset;
      if (SerialisedBytes < Export.SerialSize)
      {
        Debug.WriteLine("failed to fully serialise {0}'{1}, missed {2} bytes", InObject.Class.Name.Resolved, InObject.Name.Resolved,
          Export.SerialSize - SerialisedBytes);
      }
      else if (SerialisedBytes > Export.SerialSize)
      {
        Debug.WriteLine("failed to serialise {0}'{1}, out of bounds by {2} bytes", InObject.Class.Name.Resolved, InObject.Name.Resolved,
          SerialisedBytes - Export.SerialSize);
      }
    }
  }

  public override void SerialiseObjectRef<T>(ref T InObject)
  {
    int Index = 0;
    Archive.Serialise(ref Index);

    if (Index == 0)
    {
      InObject = null;
      return;
    }

    if (Index < 0)
    {
      UObject xObject = LoadImport(Imports[-Index - 1]);
      if (xObject != null) // some imports may be severed
      {
        if (!(xObject is T)) throw new PackageCorruptException();
        InObject = (T)xObject;
      }
    }
    else
    {
      UObject xObject = LoadExport(Exports[Index - 1]);
      if (!(xObject is T)) throw new PackageCorruptException();
      InObject = (T)xObject;
    }
  }
}