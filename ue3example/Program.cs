using ue3;

ULinkerLoad.InitFileCache("E:\\ksf2_decompressed", "KOR");
foreach (ULinkerLoad.FPackageFileSummary Summary in ULinkerLoad.LoadSummaries())
{
}

foreach (var pair in UObject.GObjLoaders)
{
  ULinkerLoad Loader = pair.Value;
  Loader.LoadImportExports();

  foreach (ULinker.FObjectExport Export in Loader.Exports)
  {
    UObject Obj = Loader.LoadExport(Export);
    Loader.FullyLoadObject(Obj);
  }
}