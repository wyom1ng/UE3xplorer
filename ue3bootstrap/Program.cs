using ue3bootstrap;

Bootstrap bootstrap = new("E:\\ksf2_decompressed");

bootstrap.GenerateDataStructures([
  "Core", "Engine", "IpDrv", "GFxUI", "GameFramework", "OnlineSubsystemPC", "SFGame", "SFGameContent"
], "ue3");