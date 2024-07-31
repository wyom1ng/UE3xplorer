namespace ue3bootstrap;

public struct FName
{
  private static int nextIndex;
  private static readonly Dictionary<string, int> nameMap = new(StringComparer.OrdinalIgnoreCase);

  public int PackageIndex;
  public int Number;
  public int GlobalIndex;
  public string Resolved;

  public FName()
  {
  }

  public FName(EName name)
  {
    GlobalIndex = (int)name;
    Resolved = name.ToString();
  }

  public void ResolveFrom(string[] names)
  {
    EnsureNameMapIsInitialised();

    string s = names[PackageIndex];
    if (!nameMap.ContainsKey(s))
      nameMap[s] = nextIndex++;

    GlobalIndex = nameMap[s];

    if (Number > 0) s = $"{s}_{Number - 1}";
    Resolved = s;
  }

  public static string Split(string input, out string numberSegment)
  {
    int nameLength = input.Length;
    char lastChar = '\0';
    for (int i = nameLength - 1; i > 0; --i)
    {
      char currentChar = input[i];
      // check the last underscore to see if we need to split
      if (currentChar == '_')
      {
        // "somename_01" should not be split, so check the last numeric character
        bool isFirstNumericCharacter = i == nameLength - 2;
        if (lastChar != '0' || isFirstNumericCharacter) nameLength = i;
        break;
      }

      // not numeric, don't split "somename_12xyz3"
      if (currentChar < '0') break;
      if (currentChar > '9') break;
      lastChar = currentChar;
    }

    if (nameLength == input.Length)
    {
      numberSegment = "";
      return input;
    }

    string nameSegment = input[..nameLength];
    numberSegment = input[(nameLength + 1)..];
    return nameSegment;
  }

  public static FName ResolveNameAndCorrectCasing(string fullname)
  {
    EnsureNameMapIsInitialised();

    string number_segment;
    string name = Split(fullname, out number_segment);
    int number = 0;
    if (number_segment.Length > 0) number = 1 + int.Parse(number_segment);

    int index;
    if (nameMap.ContainsKey(name)) index = nameMap[name];
    else index = nextIndex++;

    nameMap.Remove(name);
    nameMap[name] = index;

    FName result = new();
    result.PackageIndex = -1;
    result.GlobalIndex = index;
    result.Number = number;
    result.Resolved = fullname;

    return result;
  }

  private static void EnsureNameMapIsInitialised()
  {
    if (nameMap.Count == 0)
    {
      foreach (EName name in Enum.GetValues(typeof(EName))) nameMap[name.ToString()] = (int)name;

      nextIndex = 1250;
    }
  }

  public static bool operator ==(FName lhs, FName rhs)
  {
    return lhs.GlobalIndex == rhs.GlobalIndex && lhs.Number == rhs.Number;
  }

  public static bool operator !=(FName lhs, FName rhs)
  {
    return lhs.GlobalIndex != rhs.GlobalIndex || lhs.Number != rhs.Number;
  }

  public static bool operator ==(FName lhs, EName rhs)
  {
    return lhs.Number == 0 && lhs.GlobalIndex == (int)rhs;
  }

  public static bool operator !=(FName lhs, EName rhs)
  {
    return lhs.Number != 0 || lhs.GlobalIndex != (int)rhs;
  }

  public static bool operator ==(FName lhs, string rhs)
  {
    return lhs.Resolved == rhs;
  }

  public static bool operator !=(FName lhs, string rhs)
  {
    return lhs.Resolved != rhs;
  }
}

public enum EName
{
  // Special zero value, meaning no name.
  None = 0,

// Class property types
  ByteProperty = 1,
  IntProperty = 2,
  BoolProperty = 3,
  FloatProperty = 4,
  ObjectProperty = 5,
  NameProperty = 6,
  DelegateProperty = 7,
  ClassProperty = 8,
  ArrayProperty = 9,
  StructProperty = 10,
  VectorProperty = 11,
  RotatorProperty = 12,
  StrProperty = 13,
  MapProperty = 14,
  InterfaceProperty = 15,

// Packages.
  Core = 20,
  Engine = 21,
  Editor = 22,
  Gameplay = 23,

// UnrealScript types.
  Byte = 80,
  Int = 81,
  Bool = 82,
  Float = 83,
  Name = 84,
  String = 85,
  Struct = 86,
  Vector = 87,
  Rotator = 88,
  SHVector = 89,
  Color = 90,
  Plane = 91,
  Button = 92,
  Matrix = 94,
  LinearColor = 95,
  QWord = 96,
  Pointer = 97,
  Double = 98,
  Quat = 99,
  Vector4 = 1250,

// Keywords.
  Begin = 100,
  State = 102,
  Function = 103,
  Self = 104,
  TRUE = 105,
  FALSE = 106,
  Transient = 107,
  Enum = 117,
  Replication = 119,
  Reliable = 120,
  Unreliable = 121,
  Always = 122,
  Server = 123,
  Client = 124,
  K2Call = 125,
  K2Override = 126,
  K2Pure = 127,

// Object class names.
  Field = 150,
  Object = 151,
  TextBuffer = 152,
  Linker = 153,
  LinkerLoad = 154,
  LinkerSave = 155,
  Subsystem = 156,
  Factory = 157,
  TextBufferFactory = 158,
  Exporter = 159,
  StackNode = 160,
  Property = 161,
  Camera = 162,
  PlayerInput = 163,
  Actor = 164,
  ObjectRedirector = 165,
  ObjectArchetype = 166,

// Constants.
  Vect = 600,
  Rot = 601,
  ArrayCount = 605,
  EnumCount = 606,
  Rng = 607,
  NameOf = 608,

// Flow control.
  Else = 620,
  If = 621,
  Goto = 622,
  Stop = 623,
  Until = 625,
  While = 626,
  Do = 627,
  Break = 628,
  For = 629,
  ForEach = 630,
  Assert = 631,
  Switch = 632,
  Case = 633,
  Default = 634,
  Continue = 635,
  ElseIf = 636,

// Variable overrides.
  Private = 640,
  Const = 641,
  Out = 642,
  Export = 643,
  DuplicateTransient = 644,
  NoImport = 645,
  Skip = 646,
  Coerce = 647,
  Optional = 648,
  Input = 649,
  Config = 650,
  EditorOnly = 651,
  NotForConsole = 652,
  EditConst = 653,
  Localized = 654,
  GlobalConfig = 655,
  SafeReplace = 656,
  New = 657,
  Protected = 658,
  Public = 659,
  EditInline = 660,
  EditInlineUse = 661,
  Deprecated = 662,
  Atomic = 663,
  Immutable = 664,
  Automated = 665,
  RepNotify = 666,
  Interp = 667,
  NoClear = 668,
  NonTransactional = 669,
  EditFixedSize = 670,
  ImmutableWhenCooked = 940,
  RepRetry = 941,
  PrivateWrite = 942,
  ProtectedWrite = 943,
  EditHide = 944,
  EditTextBox = 945,

// Class overrides.
  Intrinsic = 671,
  Within = 672,
  Abstract = 673,
  Package = 674,
  Guid = 675,
  Parent = 676,
  Class = 677,
  Extends = 678,
  NoExport = 679,
  Placeable = 680,
  PerObjectConfig = 681,
  NativeReplication = 682,
  NotPlaceable = 683,
  EditInlineNew = 684,
  NotEditInlineNew = 685,
  HideCategories = 686,
  ShowCategories = 687,
  CollapseCategories = 688,
  DontCollapseCategories = 689,
  DependsOn = 698,
  HideDropDown = 699,

  Implements = 950,
  Interface = 951,
  Inherits = 952,
  PerObjectLocalized = 953,
  NonTransient = 954,
  Archetype = 955,

  StrictConfig = 956,
  UnusedStructKeyword1 = 957,
  UnusedStructKeyword2 = 958,
  SerializeText = 959,
  CrossLevel = 960,
  CrossLevelActive = 961,
  CrossLevelPassive = 962,
  ClassGroup = 963,

// State overrides.
  Auto = 690,
  Ignores = 691,

// Auto-instanced subobjects
  Instanced = 692,

// Components.
  Component = 693,
  Components = 694,

// Calling overrides.
  Global = 695,
  Super = 696,
  Outer = 697,

// Function overrides.
  Operator = 700,
  PreOperator = 701,
  PostOperator = 702,
  Final = 703,
  Iterator = 704,
  Latent = 705,
  Return = 706,
  Singular = 707,
  Simulated = 708,
  Exec = 709,
  Event = 710,
  Static = 711,
  Native = 712,
  Invariant = 713,
  Delegate = 714,
  Virtual = 715,
  NoExportHeader = 716,
  DLLImport = 717,
  NativeOnly = 718,
  UnusedFunctionKeyword3 = 719,

// Variable declaration.
  Var = 720,
  Local = 721,
  Import = 722,
  From = 723,

// Special commands.
  Spawn = 730,
  Array = 731,
  Map = 732,
  AutoExpandCategories = 733,
  AutoCollapseCategories = 734,
  DontAutoCollapseCategories = 735,
  DontSortCategories = 736,

// Misc.
  Tag = 740,
  Role = 742,
  RemoteRole = 743,
  System = 744,
  User = 745,
  PersistentLevel = 746,
  TheWorld = 747,

// Platforms
  Windows = 750,
  XBox = 751,
  PlayStation = 752,
  Linux = 753,
  MacOSX = 754,
  PC = 755,

// Log messages.
  DevDecals = 756,
  PerfWarning = 757,
  DevStreaming = 758,
  DevLive = 759,
  Log = 760,
  Critical = 761,
  Init = 762,
  Exit = 763,
  Cmd = 764,
  Play = 765,
  Console = 766,
  Warning = 767,
  ExecWarning = 768,
  ScriptWarning = 769,
  ScriptLog = 770,
  Dev = 771,
  DevNet = 772,
  DevPath = 773,
  DevNetTraffic = 774,
  DevAudio = 775,
  DevLoad = 776,
  DevSave = 777,
  DevGarbage = 778,
  DevKill = 779,
  DevReplace = 780,
  DevUI = 781,
  DevSound = 782,
  DevCompile = 783,
  DevBind = 784,
  Localization = 785,
  Compatibility = 786,
  NetComeGo = 787,
  Title = 788,
  Error = 789,
  Heading = 790,
  SubHeading = 791,
  FriendlyError = 792,
  Progress = 793,
  UserPrompt = 794,
  SourceControl = 795,
  DevPhysics = 796,
  DevTick = 797,
  DevStats = 798,
  DevComponents = 799,
  DevMemory = 809,
  XMA = 810,
  WAV = 811,
  AILog = 812,
  DevParticle = 813,
  PerfEvent = 814,
  LocalizationWarning = 815,
  DevUIStyles = 816,
  DevUIStates = 817,
  DevUIFocus = 818,
  ParticleWarn = 819,
  UTrace = 854,
  DevCollision = 855,
  DevSHA = 856,
  DevSpawn = 857,
  DevAnim = 858,
  Hack = 859, // useful for putting this where we have have hacks so we can see often they are spamming out
  DevShaders = 1118,
  DevDataBase = 1119,
  DevDataStore = 1120,
  DevAudioVerbose = 1121,
  DevUIAnimation = 1125,
  DevHDDCaching = 1126,
  DevMovie = 1127,
  DevShadersDetailed = 1128,
  PlayerManagement = 1129, // log messages related to creating and removing local players
  DevPatch = 1130, // log messages related to script patching and other console patching
  DevLightmassSolver = 1131,
  DevAssetDataBase = 1132,
  GameStats = 200, // log messages related to the recording of game stats
  DevFaceFX = 201, // log messages related to FaceFX
  DevCrossLevel = 202, // log messages relating to cross level references
  DevConfig = 203, // log messages relating to cross level references
  DevCamera = 204, // log messages relating to camera
  DebugState = 205,
  DevAbsorbFuncs = 206, // log messages relating to absorbing non-simulated functions on clients
  DevLevelTools = 207, // log messages relating to level management tools
  DevGFxUI = 208, // log messages relating to the GFx UI
  DevGFxUIWarning = 209, // Warning log messages relating to the GFx UI
  DevNavMesh = 210, // log messages relating to NavMesh
  DevNavMeshWarning = 211, // Warning log messages relating to NavMesh
  DevMCP = 212, // log messages relating to MCP/LSP tasks
  DevBeacon = 213, // log messages for beacon functionality
  DevHTTP = 214, // log messages for http requests

// Console text colours.
  White = 800,
  Black = 801,
  Red = 802,
  Green = 803,
  Blue = 804,
  Cyan = 805,
  Magenta = 806,
  Yellow = 807,
  DefaultColor = 808,

// Misc.
  KeyType = 820,
  KeyEvent = 821,
  Write = 822,
  Message = 823,
  InitialState = 824,
  Texture = 825,
  Sound = 826,
  FireTexture = 827,
  IceTexture = 828,
  WaterTexture = 829,
  WaveTexture = 830,
  WetTexture = 831,
  Main = 832,
  VideoChange = 834,
  SendText = 835,
  SendBinary = 836,
  ConnectFailure = 837,
  Length = 838,
  Insert = 839,
  Remove = 840,
  Add = 1200,
  AddItem = 1201,
  RemoveItem = 1202,
  InsertItem = 1203,
  Sort = 1204,
  Game = 841,
  SequenceObjects = 842,
  PausedState = 843,
  ContinuedState = 844,
  SelectionColor = 845,
  Find = 846,
  UI = 847,
  DevCooking = 848,
  DevOnline = 849,
  DataBinding = 850,
  OptionMusic = 851,
  OptionSFX = 852,
  OptionVoice = 853,
  Linear = 1122,
  Point = 1123,
  Aniso = 1124,
  Master = 860,
  Ambient = 861,
  UnGrouped = 862,
  VoiceChat = 863,
  Brush = 1208,

  /**
   * Virtual data store names
   */
  Attributes = 865, // virtual data store for specifying text attributes (italic, bold, underline, etc.)
  Strings = 866, // virtual data store for looking up localized string values
  Images = 867, // virtual data store for specifying direct object references
  SceneData = 868, // virtual data store for per-scene data stores

// Script Preprocessor
  EndIf = 870,
  Include = 871,
  Define = 872,
  Undefine = 873,
  IsDefined = 874,
  NotDefined = 875,
  Debug = 876,
  Counter = 877,
  SetCounter = 878,
  GetCounter = 879,
  EngineVersion = 880,
  IfCondition = 881,

//@compatibility - class names that have property remapping (reserve 900 - 999)
  FontCharacter = 900,
  SourceState = 901,
  InitChild2StartBone = 902,
  SourceStyle = 903,
  SoundCueLocalized = 904,
  SoundCue = 905,
  RawDistributionFloat = 906,
  RawDistributionVector = 907,
  UIDockingSet = 908,
  DockPadding = 909,
  ScaleType = 912,
  EvalType = 913,
  AutoSizePadding = 914,

// PlayerController states added for efficient replication
  PlayerWalking = 915,
  PlayerClimbing = 916,
  PlayerDriving = 917,
  PlayerSwimming = 918,
  PlayerFlying = 919,
  Spectating = 920,
  PlayerWaiting = 921,
  WaitingForPawn = 922,
  RoundEnded = 923,
  Dead = 924,

// Game specific Logging Categories
  Gear_General = 1000,

  Gear_ActiveReload = 1001,
  Gear_MiniGames = 1002,
  Gear_ResurrectionSystem = 1003,
  Gear_VehicleSystem = 1004,
  Gear_CheckpointSystem = 1005,
  Cover = 1006,
  AICommand = 1007,
  Success = 1008,
  Failure = 1009,
  Aborted = 1010,
  PlayerTakingCover = 1011,
  Engaging = 1012,
  PlayerTurreting = 1013,
  Reviving = 1014,

  Nano_Locomotion = 1050,
  Nano_Melee = 1051,
  Nano_Powers = 1052,
  Nano_Missions = 1053,
  Nano_Weapons = 1054,
  Nano_Music = 1055,
  Nano_MCP = 1056,

  PlayerID = 1080,
  TeamID = 1081,
  HearSoundFinished = 1082,

// Needed for post time/locale deletion to export with proper case
  Time = 1100,

// Post processing volume support.
  PPVolume_BloomEffect = 1101,
  PPVolume_DOFEffect = 1102,
  PPVolume_MotionBlurEffect = 1103,
  PPVolume_SceneEffect = 1104,
  PPVolume_DOFAndBloomEffect = 1105,
  Desaturation = 1106,
  HighLights = 1107,
  MidTones = 1108,
  Shadows = 1109,
  PPVolume_UberPostProcessEffect = 1110,

// Script uses both cases which causes *Classes.h problems
  DeviceID = 1111,

// Needed for interpolation curve fixes.
  InterpCurveFloat = 1112,
  InterpCurveVector2D = 1113,
  InterpCurveVector = 1114,
  InterpCurveTwoVectors = 1115,
  InterpCurveQuat = 1116,

  UniqueNetId = 1117,

  PopUp = 1133,

  Team = 1134,

  DevDlc = 1135,

/*-----------------------------------------------------------------------------
        Special engine-generated probe messages.
-----------------------------------------------------------------------------*/

// Creation and destruction.
  Destroyed = 300, // Called immediately before actor is removed from actor list.

// Gaining/losing actors.
  GainedChild = 301, // Sent to a parent actor when another actor attaches to it.
  LostChild = 302, // Sent to a parent actor when another actor detaches from it.

// Physics & world interaction.
  HitWall = 303, // Ran into a wall.
  Falling = 304, // Actor is falling.
  Landed = 305, // Actor has landed.
  Touch = 306, // Actor was just touched by another actor.
  UnTouch = 307, // Actor touch just ended, always sent sometime after Touch.
  Bump = 308, // Actor was just touched and blocked. No interpenetration. No UnBump.
  BeginState = 309, // Just entered a new state.
  EndState = 310, // About to leave the current state.
  BaseChange = 311, // Sent to actor when its floor changes.
  Attach = 312, // Sent to actor when it's stepped on by another actor.
  Detach = 313, // Sent to actor when another actor steps off it.
  EncroachingOn = 314, // Encroaching on another actor.
  EncroachedBy = 315, // Being encroached by another actor.
  MayFall = 316,

// Updates.
  Tick = 317, // Clock tick update for nonplayer.

// AI.
  SeePlayer = 318, // Can see player.
  EnemyNotVisible = 319, // Current Enemy is not visible.
  HearNoise = 320, // Noise nearby.
  UpdateEyeHeight = 321, // Update eye level (after physics).
  SeeMonster = 322, // Can see non-player.
  SpecialHandling = 323, // Navigation point requests special handling.
  BotDesireability = 324, // Value of this inventory to bot.

// Controller notifications
  NotifyBump = 325,
  NotifyLanded = 326,
  NotifyHitWall = 327,
  PreBeginPlay = 328,
  PostBeginPlay = 329,

  UnusedProbe = 330,

// Special tag meaning 'All probes'.
  All = 331, // Special meaning, not a message.

  PoppedState = 398,
  PushedState = 399,

// Misc. Make sure this starts after ProbeMax
  MeshEmitterVertexColor = 400,
  TextureOffsetParameter = 401,
  TextureScaleParameter = 402,
  ImpactVel = 403,
  SlideVel = 404,
  TextureOffset1Parameter = 405,
  MeshEmitterDynamicParameter = 406,
  ExpressionInput = 407,

  OnAudioFinished = 1205,

  ForceScriptOrder = 1206,
  Mobile = 1207,
  Untitled = 1209
}