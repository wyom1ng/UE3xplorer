using ue3;

ULinkerLoad.InitFileCache("E:\\ksf2_decompressed", "KOR");
foreach (ULinkerLoad.FPackageFileSummary Summary in ULinkerLoad.LoadSummaries())
{
}

ULinkerLoad Loader = UObject.GObjLoaders["13F"];
Loader.LoadImportExports();

foreach (ULinker.FObjectExport Export in Loader.Exports)
{
  if (Export.ObjectName == "T_wood_01")
  {
    UObject WoodTexture = Loader.LoadExport(Export);
    Loader.FullyLoadObject(WoodTexture);

    break;
  }
}