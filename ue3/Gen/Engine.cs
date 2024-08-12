/*===========================================================================
 *  This file was automatically generated. DO NOT modify!
===========================================================================*/
namespace ue3;

public enum EPhysics
{
  PHYS_None,
  PHYS_Walking,
  PHYS_Falling,
  PHYS_Swimming,
  PHYS_Flying,
  PHYS_Rotating,
  PHYS_Projectile,
  PHYS_Interpolating,
  PHYS_Spider,
  PHYS_Ladder,
  PHYS_RigidBody,
  PHYS_SoftBody,
  PHYS_NavMeshWalking,
  PHYS_Unused,
  PHYS_Custom,
  PHYS_MAX,
}

public enum EMoveDir
{
  MD_Stationary,
  MD_Forward,
  MD_Backward,
  MD_Left,
  MD_Right,
  MD_Up,
  MD_Down,
  MD_MAX,
}

public enum ECollisionType
{
  COLLIDE_CustomDefault,
  COLLIDE_NoCollision,
  COLLIDE_BlockAll,
  COLLIDE_BlockWeapons,
  COLLIDE_TouchAll,
  COLLIDE_TouchWeapons,
  COLLIDE_BlockAllButWeapons,
  COLLIDE_TouchAllButWeapons,
  COLLIDE_BlockWeaponsKickable,
  COLLIDE_MAX,
}

public enum ETravelType
{
  TRAVEL_Absolute,
  TRAVEL_Partial,
  TRAVEL_Relative,
  TRAVEL_MAX,
}

public enum EDoubleClickDir
{
  DCLICK_None,
  DCLICK_Left,
  DCLICK_Right,
  DCLICK_Forward,
  DCLICK_Back,
  DCLICK_Active,
  DCLICK_Done,
  DCLICK_MAX,
}

public enum EDetailMode
{
  DM_Low,
  DM_Medium,
  DM_High,
  DM_MAX,
}

public enum EOnlineDataAdvertisementType
{
  ODAT_DontAdvertise,
  ODAT_OnlineService,
  ODAT_QoS,
  ODAT_OnlineServiceAndQoS,
  ODAT_MAX,
}

public enum ESettingsDataType
{
  SDT_Empty,
  SDT_Int32,
  SDT_Int64,
  SDT_Double,
  SDT_String,
  SDT_Float,
  SDT_Blob,
  SDT_DateTime,
  SDT_MAX,
}

public enum ELoginStatus
{
  LS_NotLoggedIn,
  LS_UsingLocalProfile,
  LS_LoggedIn,
  LS_MAX,
}

public enum EFeaturePrivilegeLevel
{
  FPL_Disabled,
  FPL_EnabledFriendsOnly,
  FPL_Enabled,
  FPL_MAX,
}

public enum ENetworkNotificationPosition
{
  NNP_TopLeft,
  NNP_TopCenter,
  NNP_TopRight,
  NNP_CenterLeft,
  NNP_Center,
  NNP_CenterRight,
  NNP_BottomLeft,
  NNP_BottomCenter,
  NNP_BottomRight,
  NNP_MAX,
}

public enum EOnlineGameState
{
  OGS_NoSession,
  OGS_Pending,
  OGS_Starting,
  OGS_InProgress,
  OGS_Ending,
  OGS_Ended,
  OGS_MAX,
}

public enum EOnlineEnumerationReadState
{
  OERS_NotStarted,
  OERS_InProgress,
  OERS_Done,
  OERS_Failed,
  OERS_MAX,
}

public enum EOnlineFriendState
{
  OFS_Offline,
  OFS_Online,
  OFS_Away,
  OFS_Busy,
  OFS_MAX,
}

public enum EOnlineServerConnectionStatus
{
  OSCS_NotConnected,
  OSCS_Connected,
  OSCS_ConnectionDropped,
  OSCS_NoNetworkConnection,
  OSCS_ServiceUnavailable,
  OSCS_UpdateRequired,
  OSCS_ServersTooBusy,
  OSCS_DuplicateLoginDetected,
  OSCS_InvalidUser,
  OSCS_MAX,
}

public enum ENATType
{
  NAT_Unknown,
  NAT_Open,
  NAT_Moderate,
  NAT_Strict,
  NAT_MAX,
}

public enum ELanBeaconState
{
  LANB_NotUsingLanBeacon,
  LANB_Hosting,
  LANB_Searching,
  LANB_MAX,
}

public enum EOnlineAccountCreateStatus
{
  OACS_CreateSuccessful,
  OACS_UnknownError,
  OACS_InvalidUserName,
  OACS_InvalidPassword,
  OACS_InvalidUniqueUserName,
  OACS_UniqueUserNameInUse,
  OACS_ServiceUnavailable,
  OACS_MAX,
}

public enum GJKResult
{
  GJK_Intersect,
  GJK_NoIntersection,
  GJK_Fail,
  GJK_MAX,
}

public enum ESceneDepthPriorityGroup
{
  SDPG_UnrealEdBackground,
  SDPG_World,
  SDPG_Foreground,
  SDPG_UnrealEdForeground,
  SDPG_PostProcess,
  SDPG_MAX,
}

public enum ERadialImpulseFalloff
{
  RIF_Constant,
  RIF_Linear,
  RIF_MAX,
}

public enum ERBCollisionChannel
{
  RBCC_Default,
  RBCC_Nothing,
  RBCC_Pawn,
  RBCC_Vehicle,
  RBCC_Water,
  RBCC_GameplayPhysics,
  RBCC_EffectPhysics,
  RBCC_Untitled1,
  RBCC_Untitled2,
  RBCC_Untitled3,
  RBCC_Cloth,
  RBCC_FluidDrain,
  RBCC_SoftBody,
  RBCC_FracturedMeshPart,
  RBCC_BlockingVolume,
  RBCC_DeadPawn,
  RBCC_KillCamPawn,
  RBCC_Clothing,
  RBCC_ClothingCollision,
  RBCC_MAX,
}

public enum ENetRole
{
  ROLE_None,
  ROLE_SimulatedProxy,
  ROLE_AutonomousProxy,
  ROLE_Authority,
  ROLE_MAX,
}

public enum EViewTargetBlendFunction
{
  VTBlend_Linear,
  VTBlend_Cubic,
  VTBlend_EaseIn,
  VTBlend_EaseOut,
  VTBlend_EaseInOut,
  VTBlend_MAX,
}

public enum EFocusType
{
  FOCUS_Distance,
  FOCUS_Position,
  FOCUS_MAX,
}

public enum ECameraAnimPlaySpace
{
  CAPS_CameraLocal,
  CAPS_World,
  CAPS_UserDefined,
  CAPS_MAX,
}

public enum EMovieControlType
{
  MCT_Play,
  MCT_Stop,
  MCT_Pause,
  MCT_MAX,
}

public enum EOnlineGameSearchEntryType
{
  OGSET_Property,
  OGSET_LocalizedSetting,
  OGSET_ObjectProperty,
  OGSET_MAX,
}

public enum EOnlineGameSearchComparisonType
{
  OGSCT_Equals,
  OGSCT_NotEquals,
  OGSCT_GreaterThan,
  OGSCT_GreaterThanEquals,
  OGSCT_LessThan,
  OGSCT_LessThanEquals,
  OGSCT_MAX,
}

public enum EOnlineGameSearchSortType
{
  OGSSO_Ascending,
  OGSSO_Descending,
  OGSSO_MAX,
}

public enum EProgressMessageType
{
  PMT_Clear,
  PMT_Information,
  PMT_AdminMessage,
  PMT_DownloadProgress,
  PMT_ConnectionFailure,
  PMT_SocketFailure,
  PMT_MAX,
}

public enum EPhysBodyOp
{
  PBO_None,
  PBO_Term,
  PBO_Disable,
  PBO_MAX,
}

public enum EFaceFXRegOp
{
  FXRO_Add,
  FXRO_Multiply,
  FXRO_Replace,
  FXRO_MAX,
}

public enum EInstanceWeightUsage
{
  IWU_PartialSwap,
  IWU_FullSwap,
  IWU_MAX,
}

public enum ERootMotionMode
{
  RMM_Translate,
  RMM_Velocity,
  RMM_Ignore,
  RMM_Accel,
  RMM_Relative,
  RMM_MAX,
}

public enum ENavMeshEdgeType
{
  NAVEDGE_Normal,
  NAVEDGE_Mantle,
  NAVEDGE_Coverslip,
  NAVEDGE_SwatTurn,
  NAVEDGE_DropDown,
  NAVEDGE_PathObject,
  NAVEDGE_BackRefDummy,
  NAVEDGE_Jump,
  NAVEDGE_MAX,
}

public enum EAmbientOcclusionQuality
{
  AO_High,
  AO_Medium,
  AO_Low,
  AO_MAX,
}

public enum ECsgOper
{
  CSG_Active,
  CSG_Add,
  CSG_Subtract,
  CSG_Intersect,
  CSG_Deintersect,
  CSG_MAX,
}

public enum ReverbPreset
{
  REVERB_Default,
  REVERB_Bathroom,
  REVERB_StoneRoom,
  REVERB_Auditorium,
  REVERB_ConcertHall,
  REVERB_Cave,
  REVERB_Hallway,
  REVERB_StoneCorridor,
  REVERB_Alley,
  REVERB_Forest,
  REVERB_City,
  REVERB_Mountains,
  REVERB_Quarry,
  REVERB_Plain,
  REVERB_ParkingLot,
  REVERB_SewerPipe,
  REVERB_Underwater,
  REVERB_SmallRoom,
  REVERB_MediumRoom,
  REVERB_LargeRoom,
  REVERB_MediumHall,
  REVERB_LargeHall,
  REVERB_Plate,
  EIM_UndergroundPassage_1,
  EIM_SmallRoom_1,
  EIM_Warehouse_1,
  EIM_Warehouse_2,
  EIM_Frontyard_1,
  EIM_Lobby_1,
  EIM_Passage_1,
  REVERB_Custom,
  ReverbPreset_MAX,
}

public enum EPathFindingError
{
  PATHERROR_STARTPOLYNOTFOUND,
  PATHERROR_GOALPOLYNOTFOUND,
  PATHERROR_ANCHORPYLONNOTFOUND,
  PATHERROR_NOPATHFOUND,
  PATHERROR_COMPUTEVALIDFINALDEST_FAIL,
  PATHERROR_GETNEXTMOVELOCATION_FAIL,
  PATHERROR_MAX,
}

public enum ESoundDistanceCalc
{
  SOUNDDISTANCE_Normal,
  SOUNDDISTANCE_InfiniteXYPlane,
  SOUNDDISTANCE_InfiniteXZPlane,
  SOUNDDISTANCE_InfiniteYZPlane,
  SOUNDDISTANCE_MAX,
}

public enum SoundDistanceModel
{
  ATTENUATION_Linear,
  ATTENUATION_Logarithmic,
  ATTENUATION_Inverse,
  ATTENUATION_LogReverse,
  ATTENUATION_NaturalSound,
  ATTENUATION_MAX,
}

public enum AnimationKeyFormat
{
  AKF_ConstantKeyLerp,
  AKF_VariableKeyLerp,
  AKF_MAX,
}

public enum AnimationCompressionFormat
{
  ACF_None,
  ACF_Float96NoW,
  ACF_Fixed48NoW,
  ACF_IntervalFixed32NoW,
  ACF_Fixed32NoW,
  ACF_Float32NoW,
  ACF_MAX,
}

public enum ESliderType
{
  ST_1D,
  ST_2D,
  ST_MAX,
}

public enum EWeightCheck
{
  EWC_AnimNodeSlotNotPlaying,
  EWC_ChildIndexFullWeight,
  EWC_ChildIndexNotFullWeight,
  EWC_ChildIndexRelevant,
  EWC_ChildIndexNotRelevant,
  EWC_MAX,
}

public enum EBlendType
{
  EBT_ParentBoneSpace,
  EBT_MeshSpace,
  EBT_MAX,
}

public enum EAnimAimDir
{
  ANIMAIM_LEFTUP,
  ANIMAIM_CENTERUP,
  ANIMAIM_RIGHTUP,
  ANIMAIM_LEFTCENTER,
  ANIMAIM_CENTERCENTER,
  ANIMAIM_RIGHTCENTER,
  ANIMAIM_LEFTDOWN,
  ANIMAIM_CENTERDOWN,
  ANIMAIM_RIGHTDOWN,
  ANIMAIM_MAX,
}

public enum EAimID
{
  EAID_LeftUp,
  EAID_LeftDown,
  EAID_RightUp,
  EAID_RightDown,
  EAID_ZeroUp,
  EAID_ZeroDown,
  EAID_ZeroLeft,
  EAID_ZeroRight,
  EAID_CellLU,
  EAID_CellCU,
  EAID_CellRU,
  EAID_CellLC,
  EAID_CellCC,
  EAID_CellRC,
  EAID_CellLD,
  EAID_CellCD,
  EAID_CellRD,
  EAID_MAX,
}

public enum EBaseBlendType
{
  BBT_ByActorTag,
  BBT_ByActorClass,
  BBT_MAX,
}

public enum ERootRotationOption
{
  RRO_Default,
  RRO_Discard,
  RRO_Extract,
  RRO_MAX,
}

public enum ERootBoneAxis
{
  RBA_Default,
  RBA_Discard,
  RBA_Translate,
  RBA_MAX,
}

public enum EMobileTextureBlendFactorSource
{
  MTBFS_VertexColor,
  MTBFS_MaskTexture,
  MTBFS_MAX,
}

public enum ELightingBuildQuality
{
  Quality_Preview,
  Quality_Medium,
  Quality_High,
  Quality_Production,
  Quality_MAX,
}

public enum EMobileEmissiveColorSource
{
  MECS_EmissiveTexture,
  MECS_BaseTexture,
  MECS_Constant,
  MECS_MAX,
}

public enum EMobileValueSource
{
  MVS_Constant,
  MVS_VertexColorRed,
  MVS_VertexColorGreen,
  MVS_VertexColorBlue,
  MVS_VertexColorAlpha,
  MVS_BaseTextureRed,
  MVS_BaseTextureGreen,
  MVS_BaseTextureBlue,
  MVS_BaseTextureAlpha,
  MVS_MaskTextureRed,
  MVS_MaskTextureGreen,
  MVS_MaskTextureBlue,
  MVS_MaskTextureAlpha,
  MVS_NormalTextureAlpha,
  MVS_EmissiveTextureRed,
  MVS_EmissiveTextureGreen,
  MVS_EmissiveTextureBlue,
  MVS_EmissiveTextureAlpha,
  MVS_MAX,
}

public enum EMobileTexCoordsSource
{
  MTCS_TexCoords0,
  MTCS_TexCoords1,
  MTCS_TexCoords2,
  MTCS_TexCoords3,
  MTCS_MAX,
}

public enum EMobileAmbientOcclusionSource
{
  MAOS_Disabled,
  MAOS_VertexColorRed,
  MAOS_VertexColorGreen,
  MAOS_VertexColorBlue,
  MAOS_VertexColorAlpha,
  MAOS_MAX,
}

public enum EMobileAlphaValueSource
{
  MAVS_DiffuseTextureAlpha,
  MAVS_MaskTextureRed,
  MAVS_MaskTextureGreen,
  MAVS_MaskTextureBlue,
  MAVS_MAX,
}

public enum EMobileSpecularMask
{
  MSM_Constant,
  MSM_Luminance,
  MSM_DiffuseRed,
  MSM_DiffuseGreen,
  MSM_DiffuseBlue,
  MSM_DiffuseAlpha,
  MSM_MaskTextureRGB,
  MSM_MaskTextureRed,
  MSM_MaskTextureGreen,
  MSM_MaskTextureBlue,
  MSM_MaskTextureAlpha,
  MSM_MAX,
}

public enum EMobileEnvironmentBlendMode
{
  MEBM_Add,
  MEBM_Lerp,
  MEBM_MAX,
}

public enum ERaytracerSamplesPerPixel
{
  RT_SPP_1,
  RT_SPP_4,
  RT_SPP_8,
  RT_SPP_16,
  RT_SPP_32,
  RT_SPP_64,
  RT_SPP_128,
  RT_SPP_MAX,
}

public enum ERaytracerTraceDepth
{
  RT_TraceDepth_1,
  RT_TraceDepth_4,
  RT_TraceDepth_8,
  RT_TraceDepth_16,
  RT_TraceDepth_MAX,
}

public enum ERaytracerViewportSize
{
  RT_ViewportSize_Half,
  RT_ViewportSize_Full,
  RT_ViewportSize_Double,
  RT_ViewportSize_MAX,
}

public enum ERaytracerTextureSize
{
  RT_TextureSize_32,
  RT_TextureSize_64,
  RT_TextureSize_128,
  RT_TextureSize_256,
  RT_TextureSize_512,
  RT_TextureSize_1024,
  RT_TextureSize_MAX,
}

public enum EPathSearchType
{
  PST_Default,
  PST_Breadth,
  PST_NewBestPathTo,
  PST_Constraint,
  PST_MAX,
}

public enum ELightAffectsClassification
{
  LAC_USER_SELECTED,
  LAC_DYNAMIC_AFFECTING,
  LAC_STATIC_AFFECTING,
  LAC_DYNAMIC_AND_STATIC_AFFECTING,
  LAC_MAX,
}

public enum ELightShadowMode
{
  LightShadow_Normal,
  LightShadow_Modulate,
  LightShadow_ModulateBetter,
  LightShadow_MAX,
}

public enum EShadowProjectionTechnique
{
  ShadowProjTech_Default,
  ShadowProjTech_PCF,
  ShadowProjTech_VSM,
  ShadowProjTech_BPCF_Low,
  ShadowProjTech_BPCF_Medium,
  ShadowProjTech_BPCF_High,
  ShadowProjTech_MAX,
}

public enum EShadowFilterQuality
{
  SFQ_Low,
  SFQ_Medium,
  SFQ_High,
  SFQ_MAX,
}

public enum EDynamicLightEnvironmentBoundsMethod
{
  DLEB_OwnerComponents,
  DLEB_ManualOverride,
  DLEB_ActiveComponents,
  DLEB_MAX,
}

public enum ESoundClassName
{
  Master,
  ESoundClassName_MAX,
}

public enum EDebugState
{
  DEBUGSTATE_None,
  DEBUGSTATE_IsolateDryAudio,
  DEBUGSTATE_IsolateReverb,
  DEBUGSTATE_TestLPF,
  DEBUGSTATE_TestStereoBleed,
  DEBUGSTATE_TestLFEBleed,
  DEBUGSTATE_DisableLPF,
  DEBUGSTATE_MAX,
}

public enum ETTSSpeaker
{
  TTSSPEAKER_Paul,
  TTSSPEAKER_Harry,
  TTSSPEAKER_Frank,
  TTSSPEAKER_Dennis,
  TTSSPEAKER_Kit,
  TTSSPEAKER_Betty,
  TTSSPEAKER_Ursula,
  TTSSPEAKER_Rita,
  TTSSPEAKER_Wendy,
  TTSSPEAKER_MAX,
}

public enum EInitialOscillatorOffset
{
  EOO_OffsetRandom,
  EOO_OffsetZero,
  EOO_MAX,
}

public enum EFontImportCharacterSet
{
  FontICS_Default,
  FontICS_Ansi,
  FontICS_Symbol,
  FontICS_MAX,
}

public enum TextureCompressionSettings
{
  TC_Default,
  TC_Normalmap,
  TC_Displacementmap,
  TC_NormalmapAlpha,
  TC_Grayscale,
  TC_HighDynamicRange,
  TC_OneBitAlpha,
  TC_NormalmapUncompressed,
  TC_NormalmapBC5,
  TC_OneBitMonochrome,
  TC_MAX,
}

public enum EPixelFormat
{
  PF_Unknown,
  PF_A32B32G32R32F,
  PF_A8R8G8B8,
  PF_G8,
  PF_G16,
  PF_DXT1,
  PF_DXT3,
  PF_DXT5,
  PF_UYVY,
  PF_FloatRGB,
  PF_FloatRGBA,
  PF_DepthStencil,
  PF_ShadowDepth,
  PF_FilteredShadowDepth,
  PF_R32F,
  PF_G16R16,
  PF_G16R16F,
  PF_G16R16F_FILTER,
  PF_G32R32F,
  PF_A2B10G10R10,
  PF_A16B16G16R16,
  PF_D24,
  PF_R16F,
  PF_R16F_FILTER,
  PF_BC5,
  PF_V8U8,
  PF_A1,
  PF_MAX,
}

public enum TextureFilter
{
  TF_Nearest,
  TF_Linear,
  TF_MAX,
}

public enum TextureAddress
{
  TA_Wrap,
  TA_Clamp,
  TA_Mirror,
  TA_MAX,
}

public enum TextureGroup
{
  TEXTUREGROUP_World,
  TEXTUREGROUP_WorldNormalMap,
  TEXTUREGROUP_WorldSpecular,
  TEXTUREGROUP_Character,
  TEXTUREGROUP_CharacterNormalMap,
  TEXTUREGROUP_CharacterSpecular,
  TEXTUREGROUP_Weapon,
  TEXTUREGROUP_WeaponNormalMap,
  TEXTUREGROUP_WeaponSpecular,
  TEXTUREGROUP_Vehicle,
  TEXTUREGROUP_VehicleNormalMap,
  TEXTUREGROUP_VehicleSpecular,
  TEXTUREGROUP_Cinematic,
  TEXTUREGROUP_Effects,
  TEXTUREGROUP_EffectsNotFiltered,
  TEXTUREGROUP_Skybox,
  TEXTUREGROUP_UI,
  TEXTUREGROUP_Lightmap,
  TEXTUREGROUP_RenderTarget,
  TEXTUREGROUP_MobileFlattened,
  TEXTUREGROUP_ProcBuilding_Face,
  TEXTUREGROUP_ProcBuilding_LightMap,
  TEXTUREGROUP_Shadowmap,
  TEXTUREGROUP_ColorLookupTable,
  TEXTUREGROUP_MAX,
}

public enum TextureMipGenSettings
{
  TMGS_FromTextureGroup,
  TMGS_SimpleAverage,
  TMGS_Sharpen0,
  TMGS_Sharpen1,
  TMGS_Sharpen2,
  TMGS_Sharpen3,
  TMGS_Sharpen4,
  TMGS_Sharpen5,
  TMGS_Sharpen6,
  TMGS_Sharpen7,
  TMGS_Sharpen8,
  TMGS_Sharpen9,
  TMGS_Sharpen10,
  TMGS_NoMipmaps,
  TMGS_CompressGeneratedMips,
  TMGS_MAX,
}

public enum ETextureMipCount
{
  TMC_ResidentMips,
  TMC_AllMips,
  TMC_AllMipsBiased,
  TMC_MAX,
}

public enum EUIWidgetFace
{
  UIFACE_Left,
  UIFACE_Top,
  UIFACE_Right,
  UIFACE_Bottom,
  UIFACE_MAX,
}

public enum EUIOrientation
{
  UIORIENT_Horizontal,
  UIORIENT_Vertical,
  UIORIENT_MAX,
}

public enum ENetMode
{
  NM_Standalone,
  NM_DedicatedServer,
  NM_ListenServer,
  NM_Client,
  NM_MAX,
}

public enum EConsoleType
{
  CONSOLE_Any,
  CONSOLE_Xbox360,
  CONSOLE_PS3,
  CONSOLE_Mobile,
  CONSOLE_IPhone,
  CONSOLE_Tegra,
  CONSOLE_MAX,
}

public enum EInputPlatformType
{
  IPT_PC,
  IPT_360,
  IPT_PS3,
  IPT_MAX,
}

public enum EUIAlignment
{
  UIALIGN_Left,
  UIALIGN_Center,
  UIALIGN_Right,
  UIALIGN_Default,
  UIALIGN_MAX,
}

public enum ETextClipMode
{
  CLIP_None,
  CLIP_Normal,
  CLIP_Ellipsis,
  CLIP_Wrap,
  CLIP_MAX,
}

public enum ETextAutoScaleMode
{
  UIAUTOSCALE_None,
  UIAUTOSCALE_Normal,
  UIAUTOSCALE_Justified,
  UIAUTOSCALE_ResolutionBased,
  UIAUTOSCALE_MAX,
}

public enum EUIDefaultPenColor
{
  UIPEN_White,
  UIPEN_Black,
  UIPEN_Grey,
  UIPEN_MAX,
}

public enum EMaterialAdjustmentType
{
  ADJUST_None,
  ADJUST_Normal,
  ADJUST_Justified,
  ADJUST_Bound,
  ADJUST_Stretch,
  ADJUST_MAX,
}

public enum EUIDataProviderFieldType
{
  DATATYPE_Property,
  DATATYPE_Provider,
  DATATYPE_RangeProperty,
  DATATYPE_NetIdProperty,
  DATATYPE_Collection,
  DATATYPE_ProviderCollection,
  DATATYPE_MAX,
}

public enum ERotationAnchor
{
  RA_Absolute,
  RA_Center,
  RA_PivotLeft,
  RA_PivotRight,
  RA_PivotTop,
  RA_PivotBottom,
  RA_UpperLeft,
  RA_UpperRight,
  RA_LowerLeft,
  RA_LowerRight,
  RA_MAX,
}

public enum EUIExtentEvalType
{
  UIEXTENTEVAL_Pixels,
  UIEXTENTEVAL_PercentSelf,
  UIEXTENTEVAL_PercentOwner,
  UIEXTENTEVAL_PercentScene,
  UIEXTENTEVAL_PercentViewport,
  UIEXTENTEVAL_MAX,
}

public enum EUIDockPaddingEvalType
{
  UIPADDINGEVAL_Pixels,
  UIPADDINGEVAL_PercentTarget,
  UIPADDINGEVAL_PercentOwner,
  UIPADDINGEVAL_PercentScene,
  UIPADDINGEVAL_PercentViewport,
  UIPADDINGEVAL_MAX,
}

public enum EPositionEvalType
{
  EVALPOS_None,
  EVALPOS_PixelViewport,
  EVALPOS_PixelScene,
  EVALPOS_PixelOwner,
  EVALPOS_PercentageViewport,
  EVALPOS_PercentageOwner,
  EVALPOS_PercentageScene,
  EVALPOS_MAX,
}

public enum EUIPostProcessGroup
{
  UIPostProcess_None,
  UIPostProcess_Background,
  UIPostProcess_Foreground,
  UIPostProcess_BackgroundAndForeground,
  UIPostProcess_Dynamic,
  UIPostProcess_MAX,
}

public enum EUIAspectRatioConstraint
{
  UIASPECTRATIO_AdjustNone,
  UIASPECTRATIO_AdjustWidth,
  UIASPECTRATIO_AdjustHeight,
  UIASPECTRATIO_MAX,
}

public enum ETouchType
{
  Touch_Began,
  Touch_Moved,
  Touch_Stationary,
  Touch_Ended,
  Touch_Cancelled,
  Touch_MAX,
}

public enum EUIAnimationLoopMode
{
  UIANIMLOOP_None,
  UIANIMLOOP_Continuous,
  UIANIMLOOP_Bounce,
  UIANIMLOOP_MAX,
}

public enum EUIAnimationInterpMode
{
  UIANIMMODE_Linear,
  UIANIMMODE_EaseIn,
  UIANIMMODE_EaseOut,
  UIANIMMODE_EaseInOut,
  UIANIMMODE_MAX,
}

public enum EUIAnimNotifyType
{
  EANT_WidgetFunction,
  EANT_SceneFunction,
  EANT_KismetEvent,
  EANT_Sound,
  EANT_MAX,
}

public enum EUIAnimType
{
  EAT_None,
  EAT_Position,
  EAT_PositionOffset,
  EAT_RelPosition,
  EAT_Rotation,
  EAT_RelRotation,
  EAT_Color,
  EAT_Opacity,
  EAT_Visibility,
  EAT_Scale,
  EAT_Left,
  EAT_Top,
  EAT_Right,
  EAT_Bottom,
  EAT_PPBloom,
  EAT_PPBlurSampleSize,
  EAT_PPBlurAmount,
  EAT_MAX,
}

public enum EFadeType
{
  EFT_None,
  EFT_Fading,
  EFT_Pulsing,
  EFT_MAX,
}

public enum EEditBoxCharacterSet
{
  CHARSET_All,
  CHARSET_NoSpecial,
  CHARSET_AlphaOnly,
  CHARSET_NumericOnly,
  CHARSET_AlphaNumeric,
  CHARSET_MAX,
}

public enum ECoverGroupFillAction
{
  CGFA_Overwrite,
  CGFA_Add,
  CGFA_Remove,
  CGFA_Clear,
  CGFA_Cylinder,
  CGFA_MAX,
}

public enum ECoverLocationDescription
{
  CoverDesc_None,
  CoverDesc_InWindow,
  CoverDesc_InDoorway,
  CoverDesc_BehindCar,
  CoverDesc_BehindTruck,
  CoverDesc_OnTruck,
  CoverDesc_BehindBarrier,
  CoverDesc_BehindColumn,
  CoverDesc_BehindCrate,
  CoverDesc_BehindWall,
  CoverDesc_BehindStatue,
  CoverDesc_BehindSandbags,
  CoverDesc_MAX,
}

public enum ECoverAction
{
  CA_Default,
  CA_BlindLeft,
  CA_BlindRight,
  CA_LeanLeft,
  CA_LeanRight,
  CA_PopUp,
  CA_BlindUp,
  CA_PeekLeft,
  CA_PeekRight,
  CA_PeekUp,
  CA_MAX,
}

public enum ECoverType
{
  CT_None,
  CT_Standing,
  CT_MidLevel,
  CT_MAX,
}

public enum EFireLinkID
{
  FLI_FireLink,
  FLI_RejectedFireLink,
  FLI_MAX,
}

public enum EProviderAccessType
{
  ACCESS_ReadOnly,
  ACCESS_PerField,
  ACCESS_WriteAll,
  ACCESS_MAX,
}

public enum EDecalTransform
{
  DecalTransform_OwnerAbsolute,
  DecalTransform_OwnerRelative,
  DecalTransform_SpawnRelative,
  DecalTransform_MAX,
}

public enum EFilterMode
{
  FM_None,
  FM_Ignore,
  FM_Affect,
  FM_MAX,
}

public enum EMaterialUsage
{
  MATUSAGE_SkeletalMesh,
  MATUSAGE_FracturedMeshes,
  MATUSAGE_ParticleSprites,
  MATUSAGE_BeamTrails,
  MATUSAGE_ParticleSubUV,
  MATUSAGE_Foliage,
  MATUSAGE_SpeedTree,
  MATUSAGE_StaticLighting,
  MATUSAGE_GammaCorrection,
  MATUSAGE_LensFlare,
  MATUSAGE_InstancedMeshParticles,
  MATUSAGE_FluidSurface,
  MATUSAGE_Decals,
  MATUSAGE_MaterialEffect,
  MATUSAGE_MorphTargets,
  MATUSAGE_FogVolumes,
  MATUSAGE_RadialBlur,
  MATUSAGE_InstancedMeshes,
  MATUSAGE_SplineMesh,
  MATUSAGE_ScreenDoorFade,
  MATUSAGE_APEXMesh,
  MATUSAGE_MAX,
}

public enum EBlendMode
{
  BLEND_Opaque,
  BLEND_Masked,
  BLEND_Translucent,
  BLEND_Additive,
  BLEND_Modulate,
  BLEND_SoftMasked,
  BLEND_AlphaComposite,
  BLEND_MAX,
}

public enum EMaterialLightingModel
{
  MLM_Phong,
  MLM_NonDirectional,
  MLM_Unlit,
  MLM_SHPRT,
  MLM_Custom,
  MLM_Anisotropic,
  MLM_PhysicallyBasedPhong,
  MLM_GoldPhong,
  MLM_KSKSpecular,
  MLM_MAX,
}

public enum TeamIndexForIgnoreDeath
{
  TeamRed,
  TeamBlue,
  TeamEveryOne,
  TeamNone,
  TeamIndexForIgnoreDeath_MAX,
}

public enum DistributionParamMode
{
  DPM_Normal,
  DPM_Abs,
  DPM_Direct,
  DPM_MAX,
}

public enum EDoorType
{
  DOOR_Shoot,
  DOOR_Touch,
  DOOR_MAX,
}

public enum EParticleSysParamType
{
  PSPT_None,
  PSPT_Scalar,
  PSPT_Vector,
  PSPT_Color,
  PSPT_Actor,
  PSPT_Material,
  PSPT_MAX,
}

public enum ParticleReplayState
{
  PRS_Disabled,
  PRS_Capturing,
  PRS_Replaying,
  PRS_MAX,
}

public enum EParticleEventType
{
  EPET_Any,
  EPET_Spawn,
  EPET_Death,
  EPET_Collision,
  EPET_Kismet,
  EPET_MAX,
}

public enum ETransitionType
{
  TT_None,
  TT_Paused,
  TT_StartLoad,
  TT_Loading,
  TT_Saving,
  TT_Connecting,
  TT_Precaching,
  TT_TravelBegin,
  TT_TravelEnd,
  TT_HostMig,
  TT_MAX,
}

public enum FWFileType
{
  FWFT_Log,
  FWFT_Stats,
  FWFT_HTML,
  FWFT_User,
  FWFT_Debug,
  FWFT_MAX,
}

public enum EInfluenceType
{
  Fluid_Flow,
  Fluid_Raindrops,
  Fluid_Wave,
  Fluid_Sphere,
  Fluid_MAX,
}

public enum EWaveformFunction
{
  WF_Constant,
  WF_LinearIncreasing,
  WF_LinearDecreasing,
  WF_Sin0to90,
  WF_Sin90to180,
  WF_Sin0to180,
  WF_Noise,
  WF_MAX,
}

public enum EFullyLoadPackageType
{
  FULLYLOAD_Map,
  FULLYLOAD_Game_PreLoadClass,
  FULLYLOAD_Game_PostLoadClass,
  FULLYLOAD_Always,
  FULLYLOAD_Mutator,
  FULLYLOAD_MAX,
}

public enum EStandbyType
{
  STDBY_Rx,
  STDBY_Tx,
  STDBY_BadPing,
  STDBY_MAX,
}

public enum EPropertyValueMappingType
{
  PVMT_RawValue,
  PVMT_PredefinedValues,
  PVMT_Ranged,
  PVMT_IdMapped,
  PVMT_MAX,
}

public enum ESafeZoneType
{
  eSZ_TOP,
  eSZ_BOTTOM,
  eSZ_LEFT,
  eSZ_RIGHT,
  eSZ_MAX,
}

public enum ESplitScreenType
{
  eSST_NONE,
  eSST_2P_HORIZONTAL,
  eSST_2P_VERTICAL,
  eSST_3P_FAVOR_TOP,
  eSST_3P_FAVOR_BOTTOM,
  eSST_4P,
  eSST_MAX,
}

public enum EEdgeHandlingStatus
{
  EHS_AddedBothDirs,
  EHS_Added0to1,
  EHS_Added1to0,
  EHS_AddedNone,
  EHS_MAX,
}

public enum ETrackActiveCondition
{
  ETAC_Always,
  ETAC_GoreEnabled,
  ETAC_GoreDisabled,
  ETAC_MAX,
}

public enum ETrackToggleAction
{
  ETTA_Off,
  ETTA_On,
  ETTA_Toggle,
  ETTA_Trigger,
  ETTA_MAX,
}

public enum EVisibilityTrackCondition
{
  EVTC_Always,
  EVTC_GoreEnabled,
  EVTC_GoreDisabled,
  EVTC_MAX,
}

public enum EVisibilityTrackAction
{
  EVTA_Hide,
  EVTA_Show,
  EVTA_Toggle,
  EVTA_MAX,
}

public enum EInterpTrackMoveFrame
{
  IMF_World,
  IMF_RelativeToInitial,
  IMF_MAX,
}

public enum EInterpTrackMoveRotMode
{
  IMR_Keyframed,
  IMR_LookAtGroup,
  IMR_MAX,
}

public enum LevelGridCellShape
{
  LGCS_Box,
  LGCS_Hex,
  LGCS_MAX,
}

public enum EStreamingVolumeUsage
{
  SVB_Loading,
  SVB_LoadingAndVisibility,
  SVB_VisibilityBlockingOnLoad,
  SVB_BlockingOnLoad,
  SVB_LoadingNotVisible,
  SVB_MAX,
}

public enum ETextureColorChannel
{
  TCC_Red,
  TCC_Green,
  TCC_Blue,
  TCC_Alpha,
  TCC_MAX,
}

public enum ECustomMaterialOutputType
{
  CMOT_Float1,
  CMOT_Float2,
  CMOT_Float3,
  CMOT_Float4,
  CMOT_MAX,
}

public enum ESceneTextureType
{
  SceneTex_Lighting,
  SceneTex_MAX,
}

public enum EMaterialVectorCoordTransformSource
{
  TRANSFORMSOURCE_World,
  TRANSFORMSOURCE_Local,
  TRANSFORMSOURCE_Tangent,
  TRANSFORMSOURCE_View,
  TRANSFORMSOURCE_MAX,
}

public enum EMaterialVectorCoordTransform
{
  TRANSFORM_World,
  TRANSFORM_View,
  TRANSFORM_Local,
  TRANSFORM_Tangent,
  TRANSFORM_MAX,
}

public enum EMaterialPositionTransform
{
  TRANSFORMPOS_World,
  TRANSFORMPOS_MAX,
}

public enum FFG_ForceFieldCoordinates
{
  FFG_CARTESIAN,
  FFG_SPHERICAL,
  FFG_CYLINDRICAL,
  FFG_TOROIDAL,
  FFG_MAX,
}

public enum FFB_ForceFieldCoordinates
{
  FFB_CARTESIAN,
  FFB_SPHERICAL,
  FFB_CYLINDRICAL,
  FFB_TOROIDAL,
  FFB_MAX,
}

public enum EOnlineNewsType
{
  ONT_Unknown,
  ONT_GameNews,
  ONT_ContentAnnouncements,
  ONT_Misc,
  ONT_MAX,
}

public enum EOnlineProfilePropertyOwner
{
  OPPO_None,
  OPPO_OnlineService,
  OPPO_Game,
  OPPO_MAX,
}

public enum EOnlinePlayerStorageAsyncState
{
  OPAS_None,
  OPAS_Read,
  OPAS_Write,
  OPAS_MAX,
}

public enum EProfileSettingID
{
  PSI_Unknown,
  PSI_ControllerVibration,
  PSI_YInversion,
  PSI_GamerCred,
  PSI_GamerRep,
  PSI_VoiceMuted,
  PSI_VoiceThruSpeakers,
  PSI_VoiceVolume,
  PSI_GamerPictureKey,
  PSI_GamerMotto,
  PSI_GamerTitlesPlayed,
  PSI_GamerAchievementsEarned,
  PSI_GameDifficulty,
  PSI_ControllerSensitivity,
  PSI_PreferredColor1,
  PSI_PreferredColor2,
  PSI_AutoAim,
  PSI_AutoCenter,
  PSI_MovementControl,
  PSI_RaceTransmission,
  PSI_RaceCameraLocation,
  PSI_RaceBrakeControl,
  PSI_RaceAcceleratorControl,
  PSI_GameCredEarned,
  PSI_GameAchievementsEarned,
  PSI_EndLiveIds,
  PSI_ProfileVersionNum,
  PSI_ProfileSaveCount,
  PSI_MAX,
}

public enum EProfileDifficultyOptions
{
  PDO_Normal,
  PDO_Easy,
  PDO_Hard,
  PDO_MAX,
}

public enum EProfileControllerSensitivityOptions
{
  PCSO_Medium,
  PCSO_Low,
  PCSO_High,
  PCSO_MAX,
}

public enum EProfilePreferredColorOptions
{
  PPCO_None,
  PPCO_Black,
  PPCO_White,
  PPCO_Yellow,
  PPCO_Orange,
  PPCO_Pink,
  PPCO_Red,
  PPCO_Purple,
  PPCO_Blue,
  PPCO_Green,
  PPCO_Brown,
  PPCO_Silver,
  PPCO_MAX,
}

public enum EProfileAutoAimOptions
{
  PAAO_Off,
  PAAO_On,
  PAAO_MAX,
}

public enum EProfileAutoCenterOptions
{
  PACO_Off,
  PACO_On,
  PACO_MAX,
}

public enum EProfileMovementControlOptions
{
  PMCO_L_Thumbstick,
  PMCO_R_Thumbstick,
  PMCO_MAX,
}

public enum EProfileRaceTransmissionOptions
{
  PRTO_Auto,
  PRTO_Manual,
  PRTO_MAX,
}

public enum EProfileRaceCameraLocationOptions
{
  PRCLO_Behind,
  PRCLO_Front,
  PRCLO_Inside,
  PRCLO_MAX,
}

public enum EProfileRaceBrakeControlOptions
{
  PRBCO_Trigger,
  PRBCO_Button,
  PRBCO_MAX,
}

public enum EProfileRaceAcceleratorControlOptions
{
  PRACO_Trigger,
  PRACO_Button,
  PRACO_MAX,
}

public enum EProfileYInversionOptions
{
  PYIO_Off,
  PYIO_On,
  PYIO_MAX,
}

public enum EProfileXInversionOptions
{
  PXIO_Off,
  PXIO_On,
  PXIO_MAX,
}

public enum EProfileControllerVibrationToggleOptions
{
  PCVTO_Off,
  PCVTO_IgnoreThis,
  PCVTO_IgnoreThis2,
  PCVTO_On,
  PCVTO_MAX,
}

public enum EProfileVoiceThruSpeakersOptions
{
  PVTSO_Off,
  PVTSO_On,
  PVTSO_Both,
  PVTSO_MAX,
}

public enum EParticleBurstMethod
{
  EPBM_Instant,
  EPBM_Interpolated,
  EPBM_MAX,
}

public enum EParticleSubUVInterpMethod
{
  PSUVIM_None,
  PSUVIM_Linear,
  PSUVIM_Linear_Blend,
  PSUVIM_Random,
  PSUVIM_Random_Blend,
  PSUVIM_MAX,
}

public enum EEmitterRenderMode
{
  ERM_Normal,
  ERM_Point,
  ERM_Cross,
  ERM_None,
  ERM_MAX,
}

public enum EEmitterGoreMode
{
  EGM_Always,
  EGM_Gore,
  EGM_LowGore,
  EGM_MAX,
}

public enum EModuleType
{
  EPMT_General,
  EPMT_TypeData,
  EPMT_Beam,
  EPMT_Trail,
  EPMT_Spawn,
  EPMT_Required,
  EPMT_Event,
  EPMT_MAX,
}

public enum EParticleSourceSelectionMethod
{
  EPSSM_Random,
  EPSSM_Sequential,
  EPSSM_MAX,
}

public enum EAttractorParticleSelectionMethod
{
  EAPSM_Random,
  EAPSM_Sequential,
  EAPSM_MAX,
}

public enum Beam2SourceTargetMethod
{
  PEB2STM_Default,
  PEB2STM_UserSet,
  PEB2STM_Emitter,
  PEB2STM_Particle,
  PEB2STM_Actor,
  PEB2STM_MAX,
}

public enum Beam2SourceTargetTangentMethod
{
  PEB2STTM_Direct,
  PEB2STTM_UserSet,
  PEB2STTM_Distribution,
  PEB2STTM_Emitter,
  PEB2STTM_MAX,
}

public enum BeamModifierType
{
  PEB2MT_Source,
  PEB2MT_Target,
  PEB2MT_MAX,
}

public enum EParticleCollisionComplete
{
  EPCC_Kill,
  EPCC_Freeze,
  EPCC_HaltCollisions,
  EPCC_FreezeTranslation,
  EPCC_FreezeRotation,
  EPCC_FreezeMovement,
  EPCC_MAX,
}

public enum ELocationEmitterSelectionMethod
{
  ELESM_Random,
  ELESM_Sequential,
  ELESM_MAX,
}

public enum CylinderHeightAxis
{
  PMLPC_HEIGHTAXIS_X,
  PMLPC_HEIGHTAXIS_Y,
  PMLPC_HEIGHTAXIS_Z,
  PMLPC_HEIGHTAXIS_MAX,
}

public enum EOrbitChainMode
{
  EOChainMode_Add,
  EOChainMode_Scale,
  EOChainMode_Link,
  EOChainMode_MAX,
}

public enum EParticleAxisLock
{
  EPAL_NONE,
  EPAL_X,
  EPAL_Y,
  EPAL_Z,
  EPAL_NEGATIVE_X,
  EPAL_NEGATIVE_Y,
  EPAL_NEGATIVE_Z,
  EPAL_ROTATE_X,
  EPAL_ROTATE_Y,
  EPAL_ROTATE_Z,
  EPAL_MAX,
}

public enum EEmitterDynamicParameterValue
{
  EDPV_UserSet,
  EDPV_VelocityX,
  EDPV_VelocityY,
  EDPV_VelocityZ,
  EDPV_VelocityMag,
  EDPV_MAX,
}

public enum EParticleScreenAlignment
{
  PSA_Square,
  PSA_Rectangle,
  PSA_Velocity,
  PSA_TypeSpecific,
  PSA_MAX,
}

public enum EParticleSortMode
{
  PSORTMODE_None,
  PSORTMODE_ViewProjDepth,
  PSORTMODE_DistanceToView,
  PSORTMODE_Age_OldestFirst,
  PSORTMODE_Age_NewestFirst,
  PSORTMODE_MAX,
}

public enum EEmitterNormalsMode
{
  ENM_CameraFacing,
  ENM_Spherical,
  ENM_Cylindrical,
  ENM_MAX,
}

public enum ETrail2SourceMethod
{
  PET2SRCM_Default,
  PET2SRCM_Particle,
  PET2SRCM_Actor,
  PET2SRCM_MAX,
}

public enum ETrail2SpawnMethod
{
  PET2SM_Emitter,
  PET2SM_Velocity,
  PET2SM_Distance,
  PET2SM_MAX,
}

public enum ETrailTaperMethod
{
  PETTM_None,
  PETTM_Full,
  PETTM_Partial,
  PETTM_MAX,
}

public enum EBeamMethod
{
  PEBM_Distance,
  PEBM_EndPoints,
  PEBM_EndPoints_Interpolated,
  PEBM_UserSet_EndPoints,
  PEBM_UserSet_EndPoints_Interpolated,
  PEBM_MAX,
}

public enum EBeamEndPointMethod
{
  PEBEPM_Calculated,
  PEBEPM_Distribution,
  PEBEPM_Distribution_Constant,
  PEBEPM_MAX,
}

public enum EBeam2Method
{
  PEB2M_Distance,
  PEB2M_Target,
  PEB2M_Branch,
  PEB2M_MAX,
}

public enum EBeamTaperMethod
{
  PEBTM_None,
  PEBTM_Full,
  PEBTM_Partial,
  PEBTM_MAX,
}

public enum EMeshScreenAlignment
{
  PSMA_MeshFaceCameraWithRoll,
  PSMA_MeshFaceCameraWithSpin,
  PSMA_MeshFaceCameraWithLockedAxis,
  PSMA_MAX,
}

public enum EMeshCameraFacingUpAxis
{
  CameraFacing_NoneUP,
  CameraFacing_ZUp,
  CameraFacing_NegativeZUp,
  CameraFacing_YUp,
  CameraFacing_NegativeYUp,
  CameraFacing_MAX,
}

public enum EMeshCameraFacingOptions
{
  XAxisFacing_NoUp,
  XAxisFacing_ZUp,
  XAxisFacing_NegativeZUp,
  XAxisFacing_YUp,
  XAxisFacing_NegativeYUp,
  LockedAxis_ZAxisFacing,
  LockedAxis_NegativeZAxisFacing,
  LockedAxis_YAxisFacing,
  LockedAxis_NegativeYAxisFacing,
  VelocityAligned_ZAxisFacing,
  VelocityAligned_NegativeZAxisFacing,
  VelocityAligned_YAxisFacing,
  VelocityAligned_NegativeYAxisFacing,
  EMeshCameraFacingOptions_MAX,
}

public enum EPhysXMeshRotationMethod
{
  PMRM_Disabled,
  PMRM_Spherical,
  PMRM_Box,
  PMRM_LongBox,
  PMRM_FlatBox,
  PMRM_Velocity,
  PMRM_MAX,
}

public enum ETrailsRenderAxisOption
{
  Trails_CameraUp,
  Trails_SourceUp,
  Trails_WorldUp,
  Trails_MAX,
}

public enum ParticleSystemLODMethod
{
  PARTICLESYSTEMLODMETHOD_Automatic,
  PARTICLESYSTEMLODMETHOD_DirectSet,
  PARTICLESYSTEMLODMETHOD_ActivateAutomatic,
  PARTICLESYSTEMLODMETHOD_MAX,
}

public enum EParticleSystemOcclusionBoundsMethod
{
  EPSOBM_None,
  EPSOBM_ParticleBounds,
  EPSOBM_CustomBounds,
  EPSOBM_MAX,
}

public enum EScopeEdge
{
  EPSA_Top,
  EPSA_Bottom,
  EPSA_Left,
  EPSA_Right,
  EPSA_None,
  EPSA_MAX,
}

public enum EPBCornerType
{
  EPBC_Default,
  EPBC_Chamfer,
  EPBC_Round,
  EPBC_MAX,
}

public enum EProcBuildingAxis
{
  EPBAxis_X,
  EPBAxis_Z,
  EPBAxis_MAX,
}

public enum EProcBuildingEdge
{
  EPBE_Top,
  EPBE_Bottom,
  EPBE_Left,
  EPBE_Right,
  EPBE_MAX,
}

public enum EPhysEffectType
{
  EPMET_Impact,
  EPMET_Slide,
  EPMET_MAX,
}

public enum EPhysXDestructibleChunkState
{
  DCS_StaticRoot,
  DCS_StaticChild,
  DCS_DynamicRoot,
  DCS_DynamicChild,
  DCS_Hidden,
  DCS_MAX,
}

public enum ESimulationMethod
{
  ESM_SPH,
  ESM_NO_PARTICLE_INTERACTION,
  ESM_MIXED_MODE,
  ESM_MAX,
}

public enum EPacketSizeMultiplier
{
  EPSM_4,
  EPSM_8,
  EPSM_16,
  EPSM_32,
  EPSM_64,
  EPSM_128,
  EPSM_MAX,
}

public enum ESceneCaptureViewMode
{
  SceneCapView_Lit,
  SceneCapView_Unlit,
  SceneCapView_LitNoShadows,
  SceneCapView_Wire,
  SceneCapView_MAX,
}

public enum ESleepFamily
{
  SF_Normal,
  SF_Sensitive,
  SF_MAX,
}

public enum ERadialForceType
{
  RFT_Force,
  RFT_Impulse,
  RFT_MAX,
}

public enum ERouteDirection
{
  ERD_Forward,
  ERD_Reverse,
  ERD_MAX,
}

public enum ERouteType
{
  ERT_Linear,
  ERT_Loop,
  ERT_Circle,
  ERT_MAX,
}

public enum EPointSelection
{
  PS_Normal,
  PS_Random,
  PS_Reverse,
  PS_MAX,
}

public enum EMeshType
{
  MeshType_StaticMesh,
  MeshType_SkeletalMesh,
  MeshType_MAX,
}

public enum EParticleEventOutputType
{
  ePARTICLEOUT_Spawn,
  ePARTICLEOUT_Death,
  ePARTICLEOUT_Collision,
  ePARTICLEOUT_Kismet,
  ePARTICLEOUT_MAX,
}

public enum ESeqVarHM
{
  ESeqVarHM_Save,
  ESeqVarHM_Load,
  ESeqVarHM_Clear,
  ESeqVarHM_MAX,
}

public enum EBoneControlSpace
{
  BCS_WorldSpace,
  BCS_ActorSpace,
  BCS_ComponentSpace,
  BCS_ParentBoneSpace,
  BCS_BoneSpace,
  BCS_OtherBoneSpace,
  BCS_BaseMeshSpace,
  BCS_MAX,
}

public enum ESplineControlRotMode
{
  SCR_NoChange,
  SCR_AlongSpline,
  SCR_Interpolate,
  SCR_MAX,
}

public enum SoftBodyBoneType
{
  SOFTBODYBONE_Fixed,
  SOFTBODYBONE_BreakableAttachment,
  SOFTBODYBONE_TwoWayAttachment,
  SOFTBODYBONE_MAX,
}

public enum EDecompressionType
{
  DTYPE_Setup,
  DTYPE_Invalid,
  DTYPE_Preview,
  DTYPE_Native,
  DTYPE_RealTime,
  DTYPE_Procedural,
  DTYPE_Xenon,
  DTYPE_MAX,
}

public enum ESpeedTreeMeshType
{
  STMT_MinMinusOne,
  STMT_Branches1,
  STMT_Branches2,
  STMT_Fronds,
  STMT_LeafCards,
  STMT_LeafMeshes,
  STMT_Billboards,
  STMT_Max,
}

public enum EWheelSide
{
  SIDE_None,
  SIDE_Left,
  SIDE_Right,
  SIDE_MAX,
}

public enum ETerrainMappingType
{
  TMT_Auto,
  TMT_XY,
  TMT_XZ,
  TMT_YZ,
  TMT_MAX,
}

public enum TextureFlipBookMethod
{
  TFBM_UL_ROW,
  TFBM_UL_COL,
  TFBM_UR_ROW,
  TFBM_UR_COL,
  TFBM_LL_ROW,
  TFBM_LL_COL,
  TFBM_LR_ROW,
  TFBM_LR_COL,
  TFBM_RANDOM,
  TFBM_MAX,
}

public enum EMovieStreamSource
{
  MovieStream_File,
  MovieStream_Memory,
  MovieStream_MAX,
}

public enum EPostProcessAAType
{
  PostProcessAA_Off,
  PostProcessAA_FXAA0,
  PostProcessAA_FXAA1,
  PostProcessAA_FXAA2,
  PostProcessAA_FXAA3,
  PostProcessAA_FXAA4,
  PostProcessAA_FXAA5,
  PostProcessAA_MLAA,
  PostProcessAA_MAX,
}

public enum ECalloutButtonLayoutType
{
  CBLT_None,
  CBLT_DockLeft,
  CBLT_DockRight,
  CBLT_Centered,
  CBLT_Justified,
  CBLT_MAX,
}

public enum EUIListElementState
{
  ELEMENT_Normal,
  ELEMENT_Active,
  ELEMENT_Selected,
  ELEMENT_UnderCursor,
  ELEMENT_MAX,
}

public enum EColumnHeaderState
{
  COLUMNHEADER_Normal,
  COLUMNHEADER_PrimarySort,
  COLUMNHEADER_SecondarySort,
  COLUMNHEADER_MAX,
}

public enum ECondIsFocusedResultIndex
{
  ISFOCUSEDRESULT_True,
  ISFOCUSEDRESULT_False,
  ISFOCUSEDRESULT_MAX,
}

public enum ECellAutoSizeMode
{
  CELLAUTOSIZE_None,
  CELLAUTOSIZE_Uniform,
  CELLAUTOSIZE_Constrain,
  CELLAUTOSIZE_AdjustList,
  CELLAUTOSIZE_MAX,
}

public enum ECellLinkType
{
  LINKED_None,
  LINKED_Rows,
  LINKED_Columns,
  LINKED_MAX,
}

public enum EListWrapBehavior
{
  LISTWRAP_None,
  LISTWRAP_Smooth,
  LISTWRAP_Jump,
  LISTWRAP_MAX,
}

public enum EContextMenuItemType
{
  CMIT_Normal,
  CMIT_Submenu,
  CMIT_Separator,
  CMIT_Check,
  CMIT_Radio,
  CMIT_MAX,
}

public enum EMenuOptionType
{
  MENUOT_ComboReadOnly,
  MENUOT_ComboNumeric,
  MENUOT_CheckBox,
  MENUOT_Slider,
  MENUOT_Spinner,
  MENUOT_EditBox,
  MENUOT_CollectionCheckBox,
  MENUOT_CollapsingList,
  MENUOT_MAX,
}

public enum EStatsFetchType
{
  SFT_Player,
  SFT_CenteredOnPlayer,
  SFT_Friends,
  SFT_TopRankings,
  SFT_MAX,
}

public enum EFrameBoxImage
{
  FBI_TopLeft,
  FBI_Top,
  FBI_TopRight,
  FBI_CenterLeft,
  FBI_Center,
  FBI_CenterRight,
  FBI_BottomLeft,
  FBI_Bottom,
  FBI_BottomRight,
  FBI_MAX,
}

public enum ENavigationLinkType
{
  NAVLINK_Automatic,
  NAVLINK_Manual,
  NAVLINK_MAX,
}

public enum EScreenInputMode
{
  INPUTMODE_None,
  INPUTMODE_Locked,
  INPUTMODE_Selective,
  INPUTMODE_MatchingOnly,
  INPUTMODE_ActiveOnly,
  INPUTMODE_Free,
  INPUTMODE_Simultaneous,
  INPUTMODE_MAX,
}

public enum ESplitscreenRenderMode
{
  SPLITRENDER_Fullscreen,
  SPLITRENDER_PlayerOwner,
  SPLITRENDER_MAX,
}

public enum ESafeRegionType
{
  ESRT_FullRegion,
  ESRT_TextSafeRegion,
  ESRT_MAX,
}

public enum EUITabAutosizeType
{
  TAST_Manual,
  TAST_Fill,
  TAST_Auto,
  TAST_MAX,
}

public enum EWeaponFireType
{
  EWFT_InstantHit,
  EWFT_Projectile,
  EWFT_Custom,
  EWFT_None,
  EWFT_MAX,
}

public enum EParticleSystemUpdateMode
{
  EPSUM_RealTime,
  EPSUM_FixedTime,
  EPSUM_MAX,
}

public enum EInputTypes
{
  IT_XAxis,
  IT_YAxis,
  IT_MAX,
}

public enum EInputMatchAction
{
  IMA_GreaterThan,
  IMA_LessThan,
  IMA_MAX,
}

public enum EBuildingStatsBrowserColumns
{
  BSBC_Name,
  BSBC_Ruleset,
  BSBC_NumStaticMeshComps,
  BSBC_NumInstancedStaticMeshComps,
  BSBC_NumInstancedTris,
  BSBC_LightmapMemBytes,
  BSBC_ShadowmapMemBytes,
  BSBC_LODDiffuseMemBytes,
  BSBC_LODLightingMemBytes,
  BSBC_MAX,
}

public enum AvailableMovementMesh
{
  MOVEMENTMESH_NOTUSE,
  MOVEMENTMESH_WITHSOCKET,
  MOVEMENTMESH_WITHBONE,
  MOVEMENTMESH_MAX,
}

public enum BoneBreakOption
{
  BONEBREAK_SoftPreferred,
  BONEBREAK_AutoDetect,
  BONEBREAK_RigidPreferred,
  BONEBREAK_MAX,
}

public enum TriangleSortOption
{
  TRISORT_None,
  TRISORT_CenterRadialDistance,
  TRISORT_Random,
  TRISORT_Tootle,
  TRISORT_Custom,
  TRISORT_MAX,
}

public enum ClothMovementScaleGen
{
  ECMDM_DistToFixedVert,
  ECMDM_VertexBoneWeight,
  ECMDM_Empty,
  ECMDM_MAX,
}

public enum ClothBoneType
{
  CLOTHBONE_Fixed,
  CLOTHBONE_BreakableAttachment,
  CLOTHBONE_TearLine,
  CLOTHBONE_MAX,
}

public enum ERootMotionRotationMode
{
  RMRM_Ignore,
  RMRM_RotateActor,
  RMRM_MAX,
}

public enum EFaceFXBlendMode
{
  FXBM_Overwrite,
  FXBM_Additive,
  FXBM_MAX,
}

public enum ECoverDirection
{
  CD_Default,
  CD_Left,
  CD_Right,
  CD_Up,
  CD_MAX,
}

public enum ERouteFillAction
{
  RFA_Overwrite,
  RFA_Add,
  RFA_Remove,
  RFA_Clear,
  RFA_MAX,
}

public enum EUIAutoSizeConstraintType
{
  UIAUTOSIZEREGION_Minimum,
  UIAUTOSIZEREGION_Maximum,
  UIAUTOSIZEREGION_MAX,
}

public partial class AActor : UObject
{
  public class FRigidBodyState
  {
    public UObject.FVector Position = new();
    public UObject.FQuat Quaternion = new();
    public UObject.FVector LinVel = new();
    public UObject.FVector AngVel = new();
    public byte bNewData;
  }

  public class FRigidBodyContactInfo
  {
    public UObject.FVector ContactPosition = new();
    public UObject.FVector ContactNormal = new();
    public float ContactPenetration;
    public UObject.FVector[] ContactVelocity = new UObject.FVector[2];
    public UPhysicalMaterial[] PhysMaterial = new UPhysicalMaterial[2];
  }

  public class FCollisionImpactData
  {
    public List<AActor.FRigidBodyContactInfo> ContactInfos;
    public UObject.FVector TotalNormalForceVector = new();
    public UObject.FVector TotalFrictionForceVector = new();
  }

  public class FReplicatedHitImpulse
  {
    public UObject.FVector AppliedImpulse = new();
    public UObject.FVector HitLocation = new();
    public FName BoneName;
    public byte ImpulseCount;
    public bool bRadialImpulse;
  }

  public class FPhysEffectInfo
  {
    public float Threshold;
    public float ReFireDelay;
    public UParticleSystem Effect;
    public USoundCue Sound;
  }

  public partial class FActorReference : ISerialisable
  {
    public AActor Actor;
    public UObject.FGuid Guid = new();
  }

  public class FNavReference
  {
    public ANavigationPoint Nav;
    public UObject.FGuid Guid = new();
  }

  public class FBasedPosition
  {
    public AActor Base;
    public UObject.FVector Position = new();
    public UObject.FVector CachedBaseLocation = new();
    public UObject.FRotator CachedBaseRotation = new();
    public UObject.FVector CachedTransPosition = new();
  }

  public class FTimerData
  {
    public bool bLoop;
    public bool bPaused;
    public FName FuncName;
    public float Rate;
    public float Count;
    public float TimerTimeDilation;
    public UObject TimerObj;
  }

  public class FRelevantDelayInfo
  {
    public string PropertyName;
    public float RelevantDelayTime;
    public UObject.FMap_Mirror LastUpdateInfo = new();
  }

  public class FTraceHitInfo
  {
    public UMaterial Material;
    public UPhysicalMaterial PhysMaterial;
    public int Item;
    public int LevelIndex;
    public FName BoneName;
    public UPrimitiveComponent HitComponent;
  }

  public class FImpactInfo
  {
    public AActor HitActor;
    public UObject.FVector HitLocation = new();
    public UObject.FVector HitNormal = new();
    public UObject.FVector RayDir = new();
    public UObject.FVector StartTrace = new();
    public AActor.FTraceHitInfo HitInfo = new();
  }

  public class FAnimSlotInfo
  {
    public FName SlotName;
    public List<float> ChannelWeights;
  }

  public class FAnimSlotDesc
  {
    public FName SlotName;
    public int NumChannels;
  }

  public List<UActorComponent> Components;
  public List<UActorComponent> AllComponents;
  public FVector Location = new();
  public FRotator Rotation = new();
  public float DrawScale;
  public FVector DrawScale3D = new();
  public FVector PrePivot = new();
  public FColor EditorIconColor = new();
  public FRenderCommandFence DetachFence = new();
  public float CustomTimeDilation;
  public EPhysics Physics;
  public ENetRole RemoteRole;
  public ENetRole Role;
  public ECollisionType CollisionType;
  public ECollisionType ReplicatedCollisionType;
  public ETickingGroup TickGroup;
  public EDetailMode DetailMode;
  public AActor Owner;
  public AActor Base;
  public List<FTimerData> Timers;
  public bool bStatic;
  public bool bHidden;
  public bool bNoDelete;
  public bool bDeleteMe;
  public bool bTicked;
  public bool bOnlyOwnerSee;
  public bool bTickIsDisabled;
  public bool bWorldGeometry;
  public bool bAddToBspTree;
  public bool bIgnoreRigidBodyPawns;
  public bool bOrientOnSlope;
  public bool bIgnoreEncroachers;
  public bool bPushedByEncroachers;
  public bool bDestroyedByInterpActor;
  public bool bRouteBeginPlayEvenIfStatic;
  public bool bIsMoving;
  public bool bAlwaysEncroachCheck;
  public bool bHasAlternateTargetLocation;
  public bool bCanStepUpOn;
  public bool bNetTemporary;
  public bool bOnlyRelevantToOwner;
  public bool bNetDirty;
  public bool bAlwaysRelevant;
  public bool bReplicateInstigator;
  public bool bReplicateMovement;
  public bool bSkipActorPropertyReplication;
  public bool bUpdateSimulatedPosition;
  public bool bTearOff;
  public bool bOnlyDirtyReplication;
  public bool bKillCamRep;
  public bool bUseUnrelevantDelay;
  public bool IsInUnrelevantDelay;
  public bool bOnlyReplicateAlwaysReplicationProperties;
  public bool bUseRelevantDelay;
  public bool IsInRelevantDelay;
  public bool bAllowFluidSurfaceInteraction;
  public bool bDemoRecording;
  public bool bDemoOwner;
  public bool bForceDemoRelevant;
  public bool bNetInitialRotation;
  public bool bReplicateRigidBodyLocation;
  public bool bKillDuringLevelTransition;
  public bool bExchangedRoles;
  public bool bConsiderAllStaticMeshComponentsForStreaming;
  public bool bDebug;
  public bool bPostRenderIfNotVisible;
  public bool bForceNetUpdate;
  public bool bPendingNetUpdate;
  public bool bHardAttach;
  public bool bIgnoreBaseRotation;
  public bool bShadowParented;
  public bool bCanBeAdheredTo;
  public bool bCanBeFrictionedTo;
  public bool bHurtEntry;
  public bool bGameRelevant;
  public bool bMovable;
  public bool bDestroyInPainVolume;
  public bool bCanBeDamaged;
  public bool bShouldBaseAtStartup;
  public bool bPendingDelete;
  public bool bCanTeleport;
  public bool bAlwaysTick;
  public bool bBlocksNavigation;
  public bool BlockRigidBody;
  public bool bCollideWhenPlacing;
  public bool bCollideActors;
  public bool bCollideWorld;
  public bool bCollideComplex;
  public bool bBlockActors;
  public bool bProjTarget;
  public bool bBlocksTeleport;
  public bool bMoveIgnoresDestruction;
  public bool bNoEncroachCheck;
  public bool bCollideAsEncroacher;
  public bool bPhysRigidBodyOutOfWorldCheck;
  public bool bComponentOutsideWorld;
  public bool bForceOctreeSNFilter;
  public bool bRigidBodyWasAwake;
  public bool bCallRigidBodyWakeEvents;
  public bool bBounce;
  public bool bJustTeleported;
  public bool bNetInitial;
  public bool bNetOwner;
  public bool bNetViewTarget;
  public bool bHiddenEd;
  public bool bEditable;
  public bool bHiddenEdGroup;
  public bool bHiddenEdCustom;
  public bool bHiddenEdTemporary;
  public bool bHiddenEdLevel;
  public bool bEdShouldSnap;
  public bool bTempEditor;
  public bool bPathColliding;
  public bool bPathTemp;
  public bool bScriptInitialized;
  public bool bLockLocation;
  public bool bForceNetworkConsideration;
  public bool bAlwaysReplicateConsideration;
  public bool bForceAllowKismetModification;
  public bool bDoForceMovementReplication;
  public bool bIsViewTarget;
  public bool OutLineChangeState;
  public bool bIsKillCamDummy;
  public bool bDrawInKillCam;
  public bool bIrrelevantFromDS;
  public bool bPreventToReplicateCollisionProperties;
  public float UnrelevantDelayTime;
  public List<string> ReplicationIgnoreProperties;
  public List<string> AlwaysReplicationProperties;
  public List<FRelevantDelayInfo> UnrelevantDelayProperties;
  public float NetDriverTime;
  public List<FRelevantDelayInfo> RelevantDelayProperties;
  public int NetTag;
  public float NetUpdateTime;
  public float NetUpdateFrequency;
  public float NetPriority;
  public float InitialNetPriority;
  public float LastNetUpdateTime;
  public float TimeSinceLastTick;
  public float TickFrequency;
  public float TickFrequencyAtEndDistance;
  public float TickFrequencyDecreaseDistanceStart;
  public float TickFrequencyDecreaseDistanceEnd;
  public float TickFrequencyLastSeenTimeBeforeForcingMaxTickFrequency;
  public APawn Instigator;
  public AWorldInfo WorldInfo;
  public float LifeSpan;
  public float CreationTime;
  public float LastRenderTime;
  public FName Tag;
  public FName InitialState;
  public FName Group;
  public ulong HiddenEditorViews = new();
  public List<AActor> Touching;
  public List<AActor> Children;
  public float LatentFloat;
  public UAnimNodeSequence LatentSeqNode;
  public APhysicsVolume PhysicsVolume;
  public FVector Velocity = new();
  public FVector Acceleration = new();
  public FVector AngularVelocity = new();
  public USkeletalMeshComponent BaseSkelComponent;
  public FName BaseBoneName;
  public List<AActor> Attached;
  public FVector RelativeLocation = new();
  public FRotator RelativeRotation = new();
  public UPrimitiveComponent CollisionComponent;
  public int OverlapTag;
  public FRotator RotationRate = new();
  public AActor PendingTouch;
  public float MaxTickFreqWhenNotRendered;
  public UClass MessageClass;
  public List<UClass> SupportedEvents;
  public List<USequenceEvent> GeneratedEvents;
  public List<USeqAct_Latent> LatentActions;
  public float LastOutLineChangedTime;
  public FName WatingForLoadingState;
}

public class AInfo : AActor
{
  public class FKeyValuePair
  {
    public string Key;
    public string Value;
  }

  public class FPlayerResponseLine
  {
    public int PlayerNum;
    public int PlayerID;
    public string PlayerName;
    public int Ping;
    public int Score;
    public int StatsID;
    public List<AInfo.FKeyValuePair> PlayerInfo;
  }

  public class FServerResponseLine
  {
    public int ServerID;
    public string IP;
    public int Port;
    public int QueryPort;
    public string ServerName;
    public string MapName;
    public string GameType;
    public int CurrentPlayers;
    public int MaxPlayers;
    public int Ping;
    public List<AInfo.FKeyValuePair> ServerInfo;
    public List<AInfo.FPlayerResponseLine> PlayerInfo;
  }

}

public class USettings : UObject
{
  public class FSettingsData
  {
    public ESettingsDataType Type;
    public int Value1;
    public UObject.FPointer Value2 = new();
  }

  public class FSettingsProperty
  {
    public int PropertyId;
    public USettings.FSettingsData Data = new();
    public EOnlineDataAdvertisementType AdvertisementType;
  }

  public class FLocalizedStringSetting
  {
    public int Id;
    public int ValueIndex;
    public EOnlineDataAdvertisementType AdvertisementType;
  }

  public class FStringIdToStringMapping
  {
    public int Id;
    public FName Name;
    public bool bIsWildcard;
  }

  public class FLocalizedStringSettingMetaData
  {
    public int Id;
    public FName Name;
    public string ColumnHeaderText;
    public List<USettings.FStringIdToStringMapping> ValueMappings;
  }

  public class FIdToStringMapping
  {
    public int Id;
    public FName Name;
  }

  public class FSettingsPropertyPropertyMetaData
  {
    public int Id;
    public FName Name;
    public string ColumnHeaderText;
    public EPropertyValueMappingType MappingType;
    public List<USettings.FIdToStringMapping> ValueMappings;
    public List<USettings.FSettingsData> PredefinedValues;
    public float MinVal;
    public float MaxVal;
    public float RangeIncrement;
  }

  public List<FLocalizedStringSetting> LocalizedSettings;
  public List<FSettingsProperty> Properties;
  public List<FLocalizedStringSettingMetaData> LocalizedSettingsMappings;
  public List<FSettingsPropertyPropertyMetaData> PropertyMappings;
  public FScriptDelegate __NotifySettingValueUpdated__Delegate;
  public FScriptDelegate __NotifyPropertyValueUpdated__Delegate;
}

public class UOnlineSubsystem : UObject
{
  public class FFriendsQuery
  {
    public UOnlineSubsystem.FUniqueNetId UniqueId = new();
    public bool bIsFriend;
  }

  public class FOnlineFriend
  {
    public UOnlineSubsystem.FUniqueNetId UniqueId = new();
    public ulong SessionId = new();
    public string NickName;
    public string PresenceInfo;
    public EOnlineFriendState FriendState;
    public bool bIsOnline;
    public bool bIsPlaying;
    public bool bIsPlayingThisGame;
    public bool bIsJoinable;
    public bool bHasVoiceSupport;
    public bool bHaveInvited;
    public bool bHasInvitedYou;
  }

  public class FOnlineContent
  {
    public int UserIndex;
    public string FriendlyName;
    public string ContentPath;
    public List<string> ContentPackages;
    public List<string> ContentFiles;
  }

  public class FOnlineRegistrant
  {
    public UOnlineSubsystem.FUniqueNetId PlayerNetId = new();
  }

  public class FOnlineArbitrationRegistrant : FOnlineRegistrant
  {
    public ulong MachineId = new();
    public int Trustworthiness;
  }

  public class FSpeechRecognizedWord
  {
    public int WordId;
    public string WordText;
    public float Confidence;
  }

  public class FOnlinePlayerScore
  {
    public UOnlineSubsystem.FUniqueNetId PlayerID = new();
    public int TeamID;
    public int Score;
  }

  public class FLocalTalker
  {
    public bool bHasVoice;
    public bool bHasNetworkedVoice;
    public bool bIsRecognizingSpeech;
    public bool bWasTalking;
    public bool bIsTalking;
    public bool bIsRegistered;
  }

  public class FRemoteTalker
  {
    public UOnlineSubsystem.FUniqueNetId TalkerId = new();
    public float LastNotificationTime;
    public bool bWasTalking;
    public bool bIsTalking;
    public bool bIsRegistered;
  }

  public class FOnlineFriendMessage
  {
    public UOnlineSubsystem.FUniqueNetId SendingPlayerId = new();
    public string SendingPlayerNick;
    public bool bIsFriendInvite;
    public bool bIsGameInvite;
    public bool bWasAccepted;
    public bool bWasDenied;
    public string Message;
  }

  public class FNamedInterface
  {
    public FName InterfaceName;
    public UObject InterfaceObject;
  }

  public class FNamedInterfaceDef
  {
    public FName InterfaceName;
    public string InterfaceClassName;
  }

  public class FTitleFile
  {
    public string Filename;
    public EOnlineEnumerationReadState AsyncState;
    public List<byte> Data;
  }

  public class FCommunityContentFile
  {
    public int ContentId;
    public int FileId;
    public int ContentType;
    public int FileSize;
    public UOnlineSubsystem.FUniqueNetId Owner = new();
    public int DownloadCount;
    public float AverageRating;
    public int RatingCount;
    public int LastRatingGiven;
    public string LocalFilePath;
  }

  public class FCommunityContentMetadata
  {
    public int ContentType;
    public List<USettings.FSettingsProperty> MetadataItems;
  }

  public class FNamedSession
  {
    public FName SessionName;
    public UObject.FPointer SessionInfo = new();
    public UOnlineGameSettings GameSettings;
    public List<UOnlineSubsystem.FOnlineRegistrant> Registrants;
    public List<UOnlineSubsystem.FOnlineArbitrationRegistrant> ArbitrationRegistrants;
  }

  public class FUniqueNetId
  {
    public ulong Uid = new();
  }

  public class FAchievementDetails
  {
    public int Id;
    public string AchievementName;
    public string Description;
    public string HowTo;
    public USurface Image;
    public int GamerPoints;
    public bool bIsSecret;
    public bool bWasAchievedOnline;
    public bool bWasAchievedOffline;
  }

  public class FOnlinePartyMember
  {
    public UOnlineSubsystem.FUniqueNetId UniqueId = new();
    public string NickName;
    public byte LocalUserNum;
    public ENATType NatType;
    public int TitleId;
    public bool bIsLocal;
    public bool bIsInPartyVoice;
    public bool bIsTalking;
    public bool bIsInGameSession;
    public UObject.FPointer SessionInfo = new();
    public ulong Data1 = new();
    public ulong Data2 = new();
  }

  public FPointer VfTable_FTickableObject = new();
  public FScriptInterface AccountInterface;
  public FScriptInterface PlayerInterface;
  public FScriptInterface PlayerInterfaceEx;
  public FScriptInterface SystemInterface;
  public FScriptInterface GameInterface;
  public FScriptInterface ContentInterface;
  public FScriptInterface VoiceInterface;
  public FScriptInterface StatsInterface;
  public FScriptInterface NewsInterface;
  public FScriptInterface PartyChatInterface;
  public List<FNamedInterface> NamedInterfaces;
  public List<FNamedInterfaceDef> NamedInterfaceDefs;
  public List<FNamedSession> Sessions;
  public bool bUseBuildIdOverride;
  public int BuildIdOverride;
  public string IniLocPatcherClassName;
  public UIniLocPatcher Patcher;
  public float AsyncMinCompletionTime;
}

public class AAccessControl : AInfo
{
  public List<string> IPPolicies;
  public List<UOnlineSubsystem.FUniqueNetId> BannedIDs;
  public string IPBanned;
  public string WrongPassword;
  public string NeedPassword;
  public string SessionBanned;
  public string KickedMsg;
  public string DefaultKickReason;
  public string IdleKickReason;
  public UClass AdminClass;
  public string AdminPassword;
  public string GamePassword;
  public string[] ACDisplayText = new string[3];
  public string[] ACDescText = new string[3];
  public bool bDontAddDefaultAdmin;
}

public class UActorComponent : UComponent
{
  public FPointer Scene = new();
  public AActor Owner;
  public bool bAttached;
  public bool bTickInEditor;
  public bool bNeedsReattach;
  public bool bNeedsUpdateTransform;
  public ETickingGroup TickGroup;
  public bool bIrrelevantFromDS;
}

public class UActorFactory : UObject
{
  public UClass GameplayActorClass;
  public string MenuName;
  public int MenuPriority;
  public int AlternateMenuPriority;
  public UClass NewActorClass;
  public bool bPlaceable;
}

public class UActorFactoryActor : UActorFactory
{
  public UClass ActorClass;
}

public class UActorFactoryAI : UActorFactory
{
  public UClass ControllerClass;
  public UClass PawnClass;
  public string PawnName;
  public bool bGiveDefaultInventory;
  public List<UClass> InventoryList;
  public int TeamIndex;
}

public class UActorFactoryAmbientSound : UActorFactory
{
  public USoundCue AmbientSoundCue;
}

public class UActorFactoryAmbientSoundMovable : UActorFactoryAmbientSound
{
}

public class UActorFactoryAmbientSoundSimple : UActorFactory
{
  public USoundNodeWave SoundNodeWave;
}

public class UActorFactoryAmbientSoundNonLoop : UActorFactoryAmbientSoundSimple
{
}

public class UActorFactoryAmbientSoundSimpleToggleable : UActorFactoryAmbientSoundSimple
{
}

public class UActorFactoryApexDestructible : UActorFactory
{
  public UApexDestructibleAsset DestructibleAsset;
}

public class UActorFactoryArchetype : UActorFactory
{
  public AActor ArchetypeActor;
}

public class UActorFactoryCoverLink : UActorFactory
{
}

public class UActorFactoryDecal : UActorFactory
{
  public UMaterialInterface DecalMaterial;
}

public class UActorFactoryDecalMovable : UActorFactoryDecal
{
}

public class UActorFactoryDominantDirectionalLight : UActorFactory
{
}

public class UActorFactoryDominantDirectionalLightMovable : UActorFactory
{
}

public class UActorFactoryDynamicSM : UActorFactory
{
  public UStaticMesh StaticMesh;
  public FVector DrawScale3D = new();
  public bool bNoEncroachCheck;
  public bool bNotifyRigidBodyCollision;
  public bool bBlockRigidBody;
  public bool bUseCompartment;
  public bool bCastDynamicShadow;
  public ECollisionType CollisionType;
}

public class UActorFactoryEmitter : UActorFactory
{
  public UParticleSystem ParticleSystem;
}

public class UActorFactoryFogVolumeConstantDensityInfo : UActorFactory
{
  public UMaterialInterface SelectedMaterial;
  public bool bNothingSelected;
}

public class UActorFactoryFogVolumeLinearHalfspaceDensityInfo : UActorFactoryFogVolumeConstantDensityInfo
{
}

public class UActorFactoryFogVolumeSphericalDensityInfo : UActorFactoryFogVolumeConstantDensityInfo
{
}

public class UActorFactoryFracturedStaticMesh : UActorFactory
{
  public UFracturedStaticMesh FracturedStaticMesh;
  public FVector DrawScale3D = new();
}

public class UActorFactoryStaticMesh : UActorFactory
{
  public UStaticMesh StaticMesh;
  public FVector DrawScale3D = new();
}

public class UActorFactoryInteractiveFoliage : UActorFactoryStaticMesh
{
}

public class UActorFactoryLensFlare : UActorFactory
{
  public ULensFlare LensFlareObject;
}

public class UActorFactoryLight : UActorFactory
{
}

public class UActorFactoryMover : UActorFactoryDynamicSM
{
}

public class UActorFactoryPathNode : UActorFactory
{
}

public class UActorFactoryPhysicsAsset : UActorFactory
{
  public UPhysicsAsset PhysicsAsset;
  public USkeletalMesh SkeletalMesh;
  public bool bStartAwake;
  public bool bDamageAppliesImpulse;
  public bool bNotifyRigidBodyCollision;
  public bool bUseCompartment;
  public bool bCastDynamicShadow;
  public FVector InitialVelocity = new();
  public FVector DrawScale3D = new();
}

public class UActorFactoryPhysXDestructible : UActorFactory
{
  public UPhysXDestructible PhysXDestructible;
  public FVector DrawScale3D = new();
}

public class UActorFactoryPlayerStart : UActorFactory
{
}

public class UActorFactoryPylon : UActorFactory
{
}

public class UScene : UObject
{
}

public class UPrimitiveComponent : UActorComponent
{
  public class FRBCollisionChannelContainer
  {
    public bool Default;
    public bool Nothing;
    public bool Pawn;
    public bool Vehicle;
    public bool Water;
    public bool GameplayPhysics;
    public bool EffectPhysics;
    public bool Untitled1;
    public bool Untitled2;
    public bool Untitled3;
    public bool Cloth;
    public bool FluidDrain;
    public bool SoftBody;
    public bool FracturedMeshPart;
    public bool BlockingVolume;
    public bool DeadPawn;
    public bool KillCamPawn;
  }

  public class FMaterialViewRelevance
  {
    public bool bOpaque;
    public bool bTranslucent;
    public bool bDistortion;
    public bool bOneLayerDistortionRelevance;
    public bool bLit;
    public bool bUsesSceneColor;
    public bool bUseScreenDoorFade;
  }

  public FPointer SceneInfo = new();
  public int DetachFence;
  public float LocalToWorldDeterminant;
  public FMatrix LocalToWorld = new();
  public int MotionBlurInfoIndex;
  public List<FPointer> DecalList;
  public List<UDecalComponent> DecalsToReattach;
  public int Tag;
  public UPrimitiveComponent ShadowParent;
  public UPrimitiveComponent ReplacementPrimitive;
  public UFogVolumeDensityComponent FogVolumeComponent;
  public FBoxSphereBounds Bounds = new();
  public ULightEnvironmentComponent LightEnvironment;
  public ULightEnvironmentComponent PreviousLightEnvironment;
  public float MinDrawDistance;
  public float MassiveLODDistance;
  public float MaxDrawDistance;
  public float CachedMaxDrawDistance;
  public float CullDistance;
  public float CachedCullDistance;
  public ESceneDepthPriorityGroup DepthPriorityGroup;
  public ESceneDepthPriorityGroup ViewOwnerDepthPriorityGroup;
  public EDetailMode DetailMode;
  public ERBCollisionChannel RBChannel;
  public byte RBDominanceGroup;
  public float MotionBlurScale;
  public bool bUseViewOwnerDepthPriorityGroup;
  public bool bAllowCullDistanceVolume;
  public bool HiddenGame;
  public bool HiddenEditor;
  public bool bOwnerNoSee;
  public bool bOnlyOwnerSee;
  public bool bOnlyObserverSee;
  public bool bIgnoreOwnerHidden;
  public bool bUseAsOccluder;
  public bool bAllowApproximateOcclusion;
  public bool bFirstFrameOcclusion;
  public bool bIgnoreNearPlaneIntersection;
  public bool bSelectable;
  public bool bForceMipStreaming;
  public bool bAcceptsDecals;
  public bool bAcceptsDecalsDuringGameplay;
  public bool bAcceptsStaticDecals;
  public bool bAcceptsDynamicDecals;
  public bool bIsRefreshingDecals;
  public bool bAllowDecalAutomaticReAttach;
  public bool bAcceptsFoliage;
  public bool CastShadow;
  public bool CastStaticShadow;
  public bool bForceDirectLightMap;
  public bool bCastDynamicShadow;
  public bool bSelfShadowOnly;
  public bool bAcceptsDynamicDominantLightShadows;
  public bool bCastHiddenShadow;
  public bool bAcceptsLights;
  public bool bAcceptsDynamicLights;
  public bool bUsePrecomputedShadows;
  public bool bHasExplicitShadowParent;
  public bool bCullModulatedShadowOnBackfaces;
  public bool bCullModulatedShadowOnEmissive;
  public bool bAllowAmbientOcclusion;
  public bool CollideActors;
  public bool AlwaysCheckCollision;
  public bool BlockActors;
  public bool BlockZeroExtent;
  public bool BlockNonZeroExtent;
  public bool CanBlockCamera;
  public bool BlockRigidBody;
  public bool bDisableAllRigidBody;
  public bool bSkipRBGeomCreation;
  public bool bNotifyRigidBodyCollision;
  public bool bFluidDrain;
  public bool bFluidTwoWay;
  public bool bIgnoreRadialImpulse;
  public bool bIgnoreRadialForce;
  public bool bIgnoreForceField;
  public bool bUseCompartment;
  public bool AlwaysLoadOnClient;
  public bool AlwaysLoadOnServer;
  public bool bIgnoreHiddenActorsMembership;
  public bool AbsoluteTranslation;
  public bool AbsoluteRotation;
  public bool AbsoluteScale;
  public bool bAllowShadowFade;
  public bool bWasSNFiltered;
  public bool DrawOutLine;
  public bool bTargetingOutLine;
  public bool bOutLineMask;
  public List<int> OctreeNodes;
  public float OutLineIntense;
  public float OutLineCullDistance;
  public float OutLineOverlapDistance;
  public float OutLineFadeTime;
  public byte OutLineColorIndex;
  public float OutlineWidth;
  public FName AttachedSocketName;
  public int TranslucencySortPriority;
  public ULightComponent.FLightingChannelContainer LightingChannels = new();
  public FRBCollisionChannelContainer RBCollideWithChannels = new();
  public UPhysicalMaterial PhysMaterialOverride;
  public URB_BodyInstance BodyInstance;
  public FMatrix CachedParentToWorld = new();
  public FVector Translation = new();
  public FRotator Rotation = new();
  public float Scale;
  public FVector Scale3D = new();
  public float BoundsScale;
  public float LastSubmitTime;
  public float LastRenderTime;
  public float ScriptRigidBodyCollisionThreshold;
  public bool bSceneCaptureNoSee;
  public bool bOnlySceneCaptureSee;
}

public class UActorFactoryRigidBody : UActorFactoryDynamicSM
{
  public bool bStartAwake;
  public bool bDamageAppliesImpulse;
  public bool bLocalSpaceInitialVelocity;
  public bool bEnableStayUprightSpring;
  public FVector InitialVelocity = new();
  public UDistributionVector AdditionalVelocity;
  public UDistributionVector InitialAngularVelocity;
  public ERBCollisionChannel RBChannel;
  public float StayUprightTorqueFactor;
  public float StayUprightMaxTorque;
}

public class UActorFactorySkeletalMesh : UActorFactory
{
  public USkeletalMesh SkeletalMesh;
  public UAnimSet AnimSet;
  public FName AnimSequenceName;
}

public class UActorFactorySkeletalMeshCinematic : UActorFactorySkeletalMesh
{
}

public class UActorFactorySkeletalMeshMAT : UActorFactorySkeletalMesh
{
}

public class UActorFactoryTrigger : UActorFactory
{
}

public class UActorFactoryVehicle : UActorFactory
{
  public UClass VehicleClass;
}

public class AController : AActor
{
  public class FVisiblePortalInfo
  {
    public AActor Source;
    public AActor Destination;
  }

  public FPointer VfTable_IInterface_NavigationHandle = new();
  public APawn Pawn;
  public APlayerReplicationInfo PlayerReplicationInfo;
  public int PlayerNum;
  public AController NextController;
  public bool bIsPlayer;
  public bool bGodMode;
  public bool bAffectedByHitEffects;
  public bool bSoaking;
  public bool bSlowerZAcquire;
  public bool bNotifyPostLanded;
  public bool bNotifyApex;
  public bool bOverrideSearchStart;
  public bool bAdvancedTactics;
  public bool bCanDoSpecial;
  public bool bAdjusting;
  public bool bPreparingMove;
  public bool bForceStrafe;
  public bool bLOSflag;
  public bool bSkipExtraLOSChecks;
  public bool bNotifyFallingHitWall;
  public bool bEarlyOutOfSighTestsForSameType;
  public bool bPreciseDestination;
  public bool bSeeFriendly;
  public bool bUsingPathLanes;
  public bool bUseKillCam;
  public byte bFire;
  public byte bAltFire;
  public float MinHitWall;
  public UClass NavigationHandleClass;
  public UNavigationHandle NavigationHandle;
  public FVector OverrideSearchStart = new();
  public float MoveTimer;
  public AActor MoveTarget;
  public FBasedPosition DestinationPosition = new();
  public FBasedPosition FocalPosition = new();
  public AActor Focus;
  public AActor[] GoalList = new AActor[4];
  public FBasedPosition AdjustPosition = new();
  public ANavigationPoint StartSpot;
  public List<ANavigationPoint> RouteCache;
  public UReachSpec CurrentPath;
  public UReachSpec NextRoutePath;
  public FVector CurrentPathDir = new();
  public AActor RouteGoal;
  public float RouteDist;
  public float LastRouteFind;
  public AInterpActor PendingMover;
  public AActor FailedMoveTarget;
  public int MoveFailureCount;
  public float GroundPitchTime;
  public FVector ViewX = new();
  public FVector ViewY = new();
  public FVector ViewZ = new();
  public APawn ShotTarget;
  public AActor LastFailedReach;
  public float FailedReachTime;
  public FVector FailedReachLocation = new();
  public float SightCounter;
  public float SightCounterInterval;
  public float InUseNodeCostMultiplier;
  public int HighJumpNodeCostModifier;
  public float MaxMoveTowardPawnTargetTime;
  public APawn Enemy;
  public List<FVisiblePortalInfo> VisiblePortals;
  public float LaneOffset;
  public FRotator OldBasedRotation = new();
  public FVector NavMeshPath_SearchExtent_Modifier = new();
  public APawn KillCamViewPawn;
  public AController KillMeC;
}

public class UCylinderComponent : UPrimitiveComponent
{
  public float CollisionHeight;
  public float CollisionRadius;
  public FColor CylinderColor = new();
  public bool bDrawBoundingBox;
  public bool bDrawNonColliding;
  public bool bAlwaysRenderIfSelected;
}

public class UPostProcessEffect : UObject
{
  public bool bShowInEditor;
  public bool bShowInGame;
  public bool bUseWorldSettings;
  public bool bAffectsLightingOnly;
  public bool bUseSceneDepthOnly;
  public FName EffectName;
  public int NodePosY;
  public int NodePosX;
  public int DrawWidth;
  public int DrawHeight;
  public int OutDrawY;
  public int InDrawY;
  public ESceneDepthPriorityGroup SceneDPG;
}

public class UDOFEffect : UPostProcessEffect
{
  public float FalloffExponent;
  public float BlurKernelSize;
  public float MaxNearBlurAmount;
  public float MaxFarBlurAmount;
  public FColor ModulateBlurColor = new();
  public EFocusType FocusType;
  public float FocusInnerRadius;
  public float FocusDistance;
  public FVector FocusPosition = new();
}

public class ACamera : AActor
{
  public class FViewTargetTransitionParams
  {
    public float BlendTime;
    public EViewTargetBlendFunction BlendFunction;
    public float BlendExp;
    public bool bLockOutgoing;
  }

  public class FTCameraCache
  {
    public float TimeStamp;
    public UObject.FTPOV POV = new();
  }

  public class FTViewTarget
  {
    public AActor Target;
    public AController Controller;
    public UObject.FTPOV POV = new();
    public float AspectRatio;
    public APlayerReplicationInfo PRI;
  }

  public APlayerController PCOwner;
  public FName CameraStyle;
  public float DefaultFOV;
  public bool bLockedFOV;
  public bool bConstrainAspectRatio;
  public bool bEnableFading;
  public bool bEnableColorScaling;
  public bool bEnableColorScaleInterp;
  public float LockedFOV;
  public float ConstrainedAspectRatio;
  public float DefaultAspectRatio;
  public float NearPlane;
  public FColor FadeColor = new();
  public float FadeAmount;
  public float CamOverridePostProcessAlpha;
  public APostProcessVolume.FPostProcessSettings CamPostProcessSettings = new();
  public FVector ColorScale = new();
  public FVector DesiredColorScale = new();
  public FVector OriginalColorScale = new();
  public float ColorScaleInterpDuration;
  public float ColorScaleInterpStartTime;
  public FTCameraCache CameraCache = new();
  public FTCameraCache LastFrameCameraCache = new();
  public FTViewTarget ViewTarget = new();
  public FTViewTarget PendingViewTarget = new();
  public float BlendTimeToGo;
  public FViewTargetTransitionParams BlendParams = new();
  public List<UCameraModifier> ModifierList;
  public float FreeCamDistance;
  public FVector FreeCamOffset = new();
  public FVector2D FadeAlpha = new();
  public float FadeTime;
  public float FadeTimeRemaining;
  public float FadeDelay;
  public List<AEmitterCameraLensEffectBase> CameraLensEffects;
  public UCameraModifier_CameraShake CameraShakeCamMod;
  public UClass CameraShakeCamModClass;
  public UCameraAnimInst[] AnimInstPool = new UCameraAnimInst[8];
  public List<UCameraAnimInst> ActiveAnims;
  public List<UCameraAnimInst> FreeAnims;
  public ADynamicCameraActor AnimCameraActor;
}

public class USequenceObject : UObject
{
  public int ObjInstanceVersion;
  public USequence ParentSequence;
  public int ObjPosX;
  public int ObjPosY;
  public string ObjName;
  public string ObjCategory;
  public List<string> ObjRemoveInProject;
  public FColor ObjColor = new();
  public string ObjComment;
  public bool bDeletable;
  public bool bDrawFirst;
  public bool bDrawLast;
  public bool bOutputObjCommentToScreen;
  public bool bSuppressAutoComment;
  public int DrawWidth;
  public int DrawHeight;
}

public class USequenceOp : USequenceObject
{
  public class FSeqOpInputLink
  {
    public string LinkDesc;
    public bool bHasImpulse;
    public int QueuedActivations;
    public bool bDisabled;
    public bool bDisabledPIE;
    public USequenceOp LinkedOp;
    public int DrawY;
    public bool bHidden;
    public float ActivateDelay;
  }

  public class FSeqOpOutputInputLink
  {
    public USequenceOp LinkedOp;
    public int InputLinkIdx;
  }

  public class FSeqOpOutputLink
  {
    public List<USequenceOp.FSeqOpOutputInputLink> Links;
    public string LinkDesc;
    public bool bHasImpulse;
    public bool bDisabled;
    public bool bDisabledPIE;
    public USequenceOp LinkedOp;
    public float ActivateDelay;
    public int DrawY;
    public bool bHidden;
    public bool bMoving;
    public bool bClampedMax;
    public bool bClampedMin;
    public int OverrideDelta;
  }

  public class FSeqVarLink
  {
    public UClass ExpectedType;
    public List<USequenceVariable> LinkedVariables;
    public string LinkDesc;
    public FName LinkVar;
    public FName PropertyName;
    public bool bWriteable;
    public bool bModifiesLinkedObject;
    public bool bHidden;
    public int MinVars;
    public int MaxVars;
    public int DrawX;
    public UProperty CachedProperty;
    public bool bAllowAnyType;
    public bool bMoving;
    public bool bClampedMax;
    public bool bClampedMin;
    public int OverrideDelta;
  }

  public class FSeqEventLink
  {
    public UClass ExpectedType;
    public List<USequenceEvent> LinkedEvents;
    public string LinkDesc;
    public int DrawX;
    public bool bHidden;
    public bool bMoving;
    public bool bClampedMax;
    public bool bClampedMin;
    public int OverrideDelta;
  }

  public bool bActive;
  public bool bLatentExecution;
  public bool bAutoActivateOutputLinks;
  public bool bHaveMovingVarConnector;
  public bool bHaveMovingOutputConnector;
  public bool bPendingVarConnectorRecalc;
  public bool bPendingOutputConnectorRecalc;
  public List<FSeqOpInputLink> InputLinks;
  public List<FSeqOpOutputLink> OutputLinks;
  public List<FSeqVarLink> VariableLinks;
  public List<FSeqEventLink> EventLinks;
  public int PlayerIndex;
  public byte GamepadID;
  public int ActivateCount;
  public int SearchTag;
}

public class USequenceAction : USequenceOp
{
  public FName HandlerName;
  public bool bCallHandler;
  public List<UObject> Targets;
}

public class USeqAct_ControlMovieTexture : USequenceAction
{
  public UTextureMovie MovieTexture;
}

public class UOnlineGameSearch : USettings
{
  public class FOverrideSkill
  {
    public int LeaderboardId;
    public List<UOnlineSubsystem.FUniqueNetId> Players;
    public List<double> Mus;
    public List<double> Sigmas;
  }

  public class FNamedObjectProperty
  {
    public FName ObjectPropertyName;
    public string ObjectPropertyValue;
  }

  public class FOnlineGameSearchParameter
  {
    public int EntryId;
    public FName ObjectPropertyName;
    public EOnlineGameSearchEntryType EntryType;
    public EOnlineGameSearchComparisonType ComparisonType;
  }

  public class FOnlineGameSearchSortClause
  {
    public int EntryId;
    public FName ObjectPropertyName;
    public EOnlineGameSearchEntryType EntryType;
    public EOnlineGameSearchSortType SortType;
  }

  public class FOnlineGameSearchORClause
  {
    public List<UOnlineGameSearch.FOnlineGameSearchParameter> OrParams;
  }

  public class FOnlineGameSearchQuery
  {
    public List<UOnlineGameSearch.FOnlineGameSearchORClause> OrClauses;
    public List<UOnlineGameSearch.FOnlineGameSearchSortClause> SortClauses;
  }

  public class FOnlineGameSearchResult
  {
    public UOnlineGameSettings GameSettings;
    public UObject.FPointer PlatformData = new();
  }

  public int MaxSearchResults;
  public FLocalizedStringSetting Query = new();
  public bool bIsLanQuery;
  public bool bUsesArbitration;
  public bool bIsSearchInProgress;
  public UClass GameSettingsClass;
  public List<FOnlineGameSearchResult> Results;
  public FOverrideSkill ManualSkillOverride = new();
  public List<FNamedObjectProperty> NamedProperties;
  public FOnlineGameSearchQuery FilterQuery = new();
  public string AdditionalSearchCriteria;
  public int PingBucketSize;
}

public class UMeshComponent : UPrimitiveComponent
{
  public List<UMaterialInterface> Materials;
}

public class USkeletalMeshComponent : UMeshComponent
{
  public class FBonePair
  {
    public FName[] Bones = new FName[2];
  }

  public class FActiveMorph
  {
    public UMorphTarget Target;
    public float Weight;
  }

  public class FAttachment
  {
    public UActorComponent Component;
    public FName BoneName;
    public UObject.FVector RelativeLocation = new();
    public UObject.FRotator RelativeRotation = new();
    public UObject.FVector RelativeScale = new();
  }

  public USkeletalMesh SkeletalMesh;
  public USkeletalMeshComponent AttachedToSkelComponent;
  public UAnimTree AnimTreeTemplate;
  public UAnimNode Animations;
  public List<UAnimNode> AnimTickArray;
  public UPhysicsAsset PhysicsAsset;
  public UPhysicsAssetInstance PhysicsAssetInstance;
  public FPointer ApexClothing = new();
  public float PhysicsWeight;
  public float GlobalAnimRateScale;
  public FPointer MeshObject = new();
  public FColor WireframeColor = new();
  public List<UAnimNode.FBoneTransform> SpaceBases;
  public List<FBoneAtom> LocalAtoms;
  public List<FBoneAtom> CachedLocalAtoms;
  public List<UAnimNode.FBoneTransform> CachedSpaceBases;
  public int LowUpdateFrameRate;
  public List<byte> RequiredBones;
  public List<byte> ComposeOrderedRequiredBones;
  public USkeletalMeshComponent ParentAnimComponent;
  public List<int> ParentBoneMap;
  public List<UAnimSet> AnimSets;
  public List<UAnimSet> TemporarySavedAnimSets;
  public List<UMorphTargetSet> MorphSets;
  public List<FActiveMorph> ActiveMorphs;
  public List<FActiveMorph> ActiveCurveMorphs;
  public Dictionary<byte, byte> MorphTargetIndexMap;
  public List<FAttachment> Attachments;
  public List<byte> SkelControlIndex;
  public List<byte> PostPhysSkelControlIndex;
  public int ForcedLodModel;
  public int MinLodModel;
  public int PredictedLODLevel;
  public int OldPredictedLODLevel;
  public float MaxDistanceFactor;
  public int bForceWireframe;
  public int bForceRefpose;
  public int bOldForceRefPose;
  public bool bNoSkeletonUpdate;
  public int bDisplayBones;
  public int bShowPrePhysBones;
  public int bHideSkin;
  public int bForceRawOffset;
  public int bIgnoreControllers;
  public int bTransformFromAnimParent;
  public int TickTag;
  public int CachedAtomsTag;
  public int bUseSingleBodyPhysics;
  public int bRequiredBonesUpToDate;
  public float MinDistFactorForKinematicUpdate;
  public int FramesPhysicsAsleep;
  public bool bSkipAllUpdateWhenPhysicsAsleep;
  public bool bConsiderAllBodiesForBounds;
  public bool bUpdateSkelWhenNotRendered;
  public bool bIgnoreControllersWhenNotRendered;
  public bool bTickAnimNodesWhenNotRendered;
  public bool bNotUpdatingKinematicDueToDistance;
  public bool bForceDiscardRootMotion;
  public bool bRootMotionModeChangeNotify;
  public bool bRootMotionExtractedNotify;
  public bool bDisableFaceFXMaterialInstanceCreation;
  public bool bAnimTreeInitialised;
  public bool bForceMeshObjectUpdate;
  public bool bHasPhysicsAssetInstance;
  public bool bUpdateKinematicBonesFromAnimation;
  public bool bUpdateJointsFromAnimation;
  public bool bSkelCompFixed;
  public bool bHasHadPhysicsBlendedIn;
  public bool bForceUpdateAttachmentsInTick;
  public bool bEnableFullAnimWeightBodies;
  public bool bPerBoneVolumeEffects;
  public bool bSyncActorLocationToRootRigidBody;
  public bool bUseRawData;
  public bool bDisableWarningWhenAnimNotFound;
  public bool bOverrideAttachmentOwnerVisibility;
  public bool bNeedsToDeleteHitMask;
  public bool bPauseAnims;
  public bool bChartDistanceFactor;
  public bool bEnableLineCheckWithBounds;
  public FVector LineCheckBoundsScale = new();
  public bool bEnableClothSimulation;
  public bool bDisableClothCollision;
  public bool bClothFrozen;
  public bool bAutoFreezeClothWhenNotRendered;
  public bool bClothAwakeOnStartup;
  public bool bClothBaseVelClamp;
  public bool bClothBaseVelInterp;
  public bool bAttachClothVertsToBaseBody;
  public bool bIsClothOnStaticObject;
  public bool bUpdatedFixedClothVerts;
  public bool bClothPositionalDampening;
  public bool bClothWindRelativeToOwner;
  public bool bRecentlyRendered;
  public bool bCacheAnimSequenceNodes;
  public bool bNeedsInstanceWeightUpdate;
  public bool bAlwaysUseInstanceWeights;
  public bool bUpdateComposeSkeletonPasses;
  public bool bValidTemporarySavedAnimSets;
  public List<bool> HiddenMaterials;
  public List<UMaterialInterface> BackupMaterials;
  public EInstanceWeightUsage InstanceWeightUsage;
  public int InstanceWeightIdx;
  public List<FBonePair> InstanceVertexWeightBones;
  public FVector FrozenLocalToWorldPos = new();
  public FRotator FrozenLocalToWorldRot = new();
  public FVector ClothExternalForce = new();
  public FVector ClothWind = new();
  public FVector ClothBaseVelClampRange = new();
  public float ClothBlendWeight;
  public float ClothDynamicBlendWeight;
  public float ClothBlendMinDistanceFactor;
  public float ClothBlendMaxDistanceFactor;
  public FVector MinPosDampRange = new();
  public FVector MaxPosDampRange = new();
  public FVector MinPosDampScale = new();
  public FVector MaxPosDampScale = new();
  public FPointer ClothSim = new();
  public int SceneIndex;
  public List<FVector> ClothMeshPosData;
  public List<FVector> ClothMeshNormalData;
  public List<int> ClothMeshIndexData;
  public int NumClothMeshVerts;
  public int NumClothMeshIndices;
  public List<int> ClothMeshParentData;
  public int NumClothMeshParentIndices;
  public List<FVector> ClothMeshWeldedPosData;
  public List<FVector> ClothMeshWeldedNormalData;
  public List<int> ClothMeshWeldedIndexData;
  public int ClothDirtyBufferFlag;
  public ERBCollisionChannel ClothRBChannel;
  public FRBCollisionChannelContainer ClothRBCollideWithChannels = new();
  public float ClothForceScale;
  public float ClothImpulseScale;
  public float ClothAttachmentTearFactor;
  public bool bClothUseCompartment;
  public float MinDistanceForClothReset;
  public FVector LastClothLocation = new();
  public FPointer SoftBodySim = new();
  public int SoftBodySceneIndex;
  public bool bEnableSoftBodySimulation;
  public List<FVector> SoftBodyTetraPosData;
  public List<int> SoftBodyTetraIndexData;
  public int NumSoftBodyTetraVerts;
  public int NumSoftBodyTetraIndices;
  public float SoftBodyImpulseScale;
  public bool bSoftBodyFrozen;
  public bool bAutoFreezeSoftBodyWhenNotRendered;
  public bool bSoftBodyAwakeOnStartup;
  public bool bSoftBodyUseCompartment;
  public ERBCollisionChannel SoftBodyRBChannel;
  public FRBCollisionChannelContainer SoftBodyRBCollideWithChannels = new();
  public FPointer SoftBodyASVPlane = new();
  public UMaterial LimitMaterial;
  public FBoneAtom RootMotionDelta = new();
  public FVector RootMotionVelocity = new();
  public FVector RootBoneTranslation = new();
  public FVector RootMotionAccelScale = new();
  public ERootMotionMode RootMotionMode;
  public ERootMotionMode PreviousRMM;
  public ERootMotionMode PendingRMM;
  public ERootMotionMode OldPendingRMM;
  public int bRMMOneFrameDelay;
  public ERootMotionRotationMode RootMotionRotationMode;
  public EFaceFXBlendMode FaceFXBlendMode;
  public FPointer FaceFXActorInstance = new();
  public UAudioComponent CachedFaceFXAudioComp;
  public List<byte> BoneVisibility;
  public FBoneAtom LocalToWorldBoneAtom = new();
  public float ProgressiveDrawingFraction;
  public int UpdateRBBoneSkipCount;
  public bool bForceBlendInPhysics;
  public bool bForceUpdateBounds;
  public bool bUseParentLocalToWorld;
  public bool bConsiderOwnerBound;
  public bool bConsiderOwnerOriginForLocalToWorld;
  public FBox RootAdjustedLocalBoundingBox = new();
}

public class APlayerController : AController
{
  public class FInputEntry
  {
    public EInputTypes Type;
    public float Value;
    public float TimeDelta;
    public EInputMatchAction Action;
  }

  public class FInputMatchRequest
  {
    public List<APlayerController.FInputEntry> Inputs;
    public AActor MatchActor;
    public FName MatchFuncName;
    public FScriptDelegate MatchDelegate;
    public FName FailedFuncName;
    public FName RequestName;
    public int MatchIdx;
    public float LastMatchTime;
  }

  public class FDebugTextInfo
  {
    public AActor SrcActor;
    public UObject.FVector SrcActorOffset = new();
    public UObject.FVector SrcActorDesiredOffset = new();
    public string DebugText;
    public float TimeRemaining;
    public float Duration;
    public UObject.FColor TextColor = new();
    public bool bAbsoluteLocation;
  }

  public class FReusableSound
  {
    public AActor SourceActor;
    public UAudioComponent AudioComponent;
    public USoundCue SoundCue;
  }

  public class FClientAdjustment
  {
    public float TimeStamp;
    public EPhysics newPhysics;
    public UObject.FVector NewLoc = new();
    public UObject.FVector NewVel = new();
    public AActor NewBase;
    public UObject.FVector NewFloor = new();
    public byte bAckGoodMove;
    public bool bRequestResend;
  }

  public UPlayer Player;
  public ACamera PlayerCamera;
  public UClass CameraClass;
  public UClass PlayerOwnerDataStoreClass;
  public UPlayerOwnerDataStore CurrentPlayerData;
  public bool bFrozen;
  public bool bPressedJump;
  public bool bUpdatePosition;
  public bool bUpdating;
  public bool bNeverSwitchOnPickup;
  public bool bCheatFlying;
  public bool bCameraPositionLocked;
  public bool bShortConnectTimeOut;
  public bool bPendingDestroy;
  public bool bWasSpeedHack;
  public bool bWasSaturated;
  public bool bAimingHelp;
  public bool bClientSimulatingViewTarget;
  public bool bHasVoiceHandshakeCompleted;
  public bool bCinematicMode;
  public bool bCinemaDisableInputMove;
  public bool bCinemaDisableInputLook;
  public bool bIgnoreNetworkMessages;
  public bool bSceneCaptureAdjustForeground;
  public bool bReplicateAllPawns;
  public bool bIsUsingStreamingVolumes;
  public bool bIsExternalUIOpen;
  public bool bIsControllerConnected;
  public bool bCheckSoundOcclusion;
  public bool bLogHearSoundOverflow;
  public bool bCheckRelevancyThroughPortals;
  public bool bKillCamActive;
  public bool bKillCamFinPawn;
  public bool bKillCamFinKiller;
  public bool bKillCamVelInit;
  public bool bInitializeForKillCam;
  public bool bNeedResend;
  public bool bDebugClientAdjustPosition;
  public bool bWarnBadConnectionAlert;
  public bool bUseClientSmoothMovement;
  public float MaxResponseTime;
  public float WaitDelay;
  public APawn AcknowledgedPawn;
  public EDoubleClickDir DoubleClickDir;
  public byte bIgnoreMoveInput;
  public byte bIgnoreLookInput;
  public byte bRun;
  public byte bDuck;
  public byte bSprint;
  public byte NetPlayerIndex;
  public AActor ViewTarget;
  public APlayerReplicationInfo RealViewTarget;
  public UInterpTrackInstDirector ControllingDirTrackInst;
  public float FOVAngle;
  public float DesiredFOV;
  public float DefaultFOV;
  public float ForeFOVAngle;
  public float LODDistanceFactor;
  public AActor PrevViewTarget;
  public int TargetViewRotationForRep;
  public FRotator TargetViewRotation = new();
  public float TargetEyeHeight;
  public FRotator BlendedTargetViewRotation = new();
  public AHUD myHUD;
  public UClass SavedMoveClass;
  public USavedMove SavedMoves;
  public USavedMove FreeMoves;
  public USavedMove PendingMove;
  public FVector LastAckedAccel = new();
  public float CurrentTimeStamp;
  public float LastUpdateTime;
  public float ServerTimeStamp;
  public float TimeMargin;
  public float ClientUpdateTime;
  public float MaxTimeMargin;
  public float LastActiveTime;
  public int ClientCap;
  public float DynamicPingThreshold;
  public float LastPingUpdate;
  public float LastSpeedHackLog;
  public FClientAdjustment PendingAdjustment = new();
  public string QuickSaveString;
  public int GroundPitch;
  public FVector OldFloor = new();
  public ACheatManager CheatManager;
  public UClass CheatClass;
  public UPlayerInput PlayerInput;
  public UClass InputClass;
  public FVector FailedPathStart = new();
  public UCylinderComponent CylinderComponent;
  public string ForceFeedbackManagerClassName;
  public UForceFeedbackManager ForceFeedbackManager;
  public List<UInteraction> Interactions;
  public List<UOnlineSubsystem.FUniqueNetId> VoiceMuteList;
  public List<UOnlineSubsystem.FUniqueNetId> GameplayVoiceMuteList;
  public List<UOnlineSubsystem.FUniqueNetId> VoicePacketFilter;
  public UOnlineSubsystem OnlineSub;
  public FScriptInterface VoiceInterface;
  public UUIDataStore_OnlinePlayerData OnlinePlayerData;
  public float InteractDistance;
  public FName DelayedJoinSessionName;
  public List<FInputMatchRequest> InputRequests;
  public float LastBroadcastTime;
  public string[] LastBroadcastString = new string[4];
  public List<FName> PendingMapChangeLevelNames;
  public ACoverReplicator MyCoverReplicator;
  public List<FDebugTextInfo> DebugTextList;
  public float SpectatorCameraSpeed;
  public UNetConnection PendingSwapConnection;
  public float MinRespawnDelay;
  public int MaxConcurrentHearSounds;
  public List<UAudioComponent> HearSoundActiveComponents;
  public List<UAudioComponent> HearSoundPoolComponents;
  public List<FReusableSound> ReusableSounds;
  public List<AActor> HiddenActors;
  public float LastSpectatorStateSynchTime;
  public FRotator BlendedKillCamViewRotation = new();
  public float KillCamStartTime;
  public float KillCamEndTime;
  public float WorldKillCamStartTime;
  public float WorldKillCamEndTime;
  public int LatestSentRotation;
  public FRotator RotationVelocity = new();
  public int VeryShortAdjustCount;
  public int ShortAdjustCount;
  public int AdjustCount;
  public int LongClientAdjustCount;
  public float LastClientAdjustTime;
  public List<FName> IgnoreKeyBindName;
  public List<FName> NotifyKeyBindName;
  public FScriptDelegate __CanUnpause__Delegate;
  public FScriptDelegate __InputMatchDelegate__Delegate;
}

public class AAdmin : APlayerController
{
}

public class UReachSpec : UObject
{
  public FPointer NavOctreeObject = new();
  public int Distance;
  public FVector Direction = new();
  public ANavigationPoint Start;
  public AActor.FActorReference End = new();
  public int CollisionRadius;
  public int CollisionHeight;
  public int reachFlags;
  public int MaxLandingVelocity;
  public byte bPruned;
  public byte PathColorIndex;
  public bool bAddToNavigationOctree;
  public bool bCanCutCorners;
  public bool bCheckForObstructions;
  public bool bSkipPrune;
  public bool bDisabled;
  public List<UClass> PruneSpecList;
  public AActor BlockedBy;
}

public class UAdvancedReachSpec : UReachSpec
{
}

public class UAICommandBase : UObject
{
}

public class AAIController : AController
{
  public bool bAdjustFromWalls;
  public bool bReverseScriptedRoute;
  public float Skill;
  public AActor ScriptedMoveTarget;
  public ARoute ScriptedRoute;
  public int ScriptedRouteIndex;
  public AActor ScriptedFocus;
}

public class ANavigationPoint : AActor
{
  public class FNavigationOctreeObject
  {
    public UObject.FBox BoundingBox = new();
    public UObject.FVector BoxCenter = new();
    public UObject.FPointer OctreeNode = new();
    public UObject Owner;
    public byte OwnerType;
  }

  public class FDebugNavCost
  {
    public string Desc;
    public int Cost;
  }

  public class FCheckpointRecord
  {
    public bool bDisabled;
    public bool bBlocked;
  }

  public bool bEndPoint;
  public bool bTransientEndPoint;
  public bool bHideEditorPaths;
  public bool bCanReach;
  public bool bBlocked;
  public bool bOneWayPath;
  public bool bNeverUseStrafing;
  public bool bAlwaysUseStrafing;
  public bool bForceNoStrafing;
  public bool bAutoBuilt;
  public bool bSpecialMove;
  public bool bNoAutoConnect;
  public bool bNotBased;
  public bool bPathsChanged;
  public bool bDestinationOnly;
  public bool bSourceOnly;
  public bool bSpecialForced;
  public bool bMustBeReachable;
  public bool bBlockable;
  public bool bFlyingPreferred;
  public bool bMayCausePain;
  public bool bAlreadyVisited;
  public bool bVehicleDestination;
  public bool bMakeSourceOnly;
  public bool bMustTouchToReach;
  public bool bCanWalkOnToReach;
  public bool bBuildLongPaths;
  public bool bBlockedForVehicles;
  public bool bPreferredVehiclePath;
  public bool bHasCrossLevelPaths;
  public bool bShouldSaveForCheckpoint;
  public FNavigationOctreeObject NavOctreeObject = new();
  public List<UReachSpec> PathList;
  public List<FActorReference> EditorProscribedPaths;
  public List<FActorReference> EditorForcedPaths;
  public List<FActorReference> Volumes;
  public int visitedWeight;
  public int bestPathWeight;
  public ANavigationPoint nextNavigationPoint;
  public ANavigationPoint nextOrdered;
  public ANavigationPoint prevOrdered;
  public ANavigationPoint previousPath;
  public int Cost;
  public int ExtraCost;
  public int TransientCost;
  public int FearCost;
  public List<FDebugNavCost> CostArray;
  public ADroppedPickup InventoryCache;
  public float InventoryDist;
  public float LastDetourWeight;
  public UCylinderComponent CylinderComponent;
  public FCylinder MaxPathSize = new();
  public FGuid NavGuid = new();
  public USpriteComponent GoodSprite;
  public USpriteComponent BadSprite;
  public int NetworkID;
  public APawn AnchoredPawn;
  public float LastAnchoredPawnTime;
}

public partial class APylon : ANavigationPoint
{
  public partial class FPolyReference : ISerialisable
  {
    public AActor.FActorReference OwningPylon = new();
    public int PolyId;
    public UObject.FPointer CachedPoly = new();
  }

  public FPointer VfTable_IEditorLinkSelectionInterface = new();
  public FPointer NavMeshPtr = new();
  public FPointer ObstacleMesh = new();
  public FPointer DynamicObstacleMesh = new();
  public FPointer WorkingSetPtr = new();
  public FPointer PathObjectsThatAffectThisPylon = new();
  public List<FVector> NextPassSeedList;
  public FOctreeElementId OctreeId = new();
  public FPointer OctreeIWasAddedTo = new();
  public APylon NextPylon;
  public List<AVolume> ExpansionVolumes;
  public float ExpansionRadius;
  public float MaxExpansionRadius;
  public UDrawPylonRadiusComponent PylonRadiusPreview;
  public bool bImportedMesh;
  public bool bUseExpansionSphereOverride;
  public bool bNeedsCostCheck;
  public bool bDrawEdgePolys;
  public bool bDrawPolyBounds;
  public bool bRenderInShowPaths;
  public bool bDrawWalkableSurface;
  public bool bDrawObstacleSurface;
  public bool bBuildThisPylon;
  public bool bDisabled;
  public bool bForceObstacleMeshCollision;
  public FVector ExpansionSphereCenter = new();
  public UNavMeshRenderingComponent RenderingComp;
  public USpriteComponent BrokenSprite;
  public List<APylon> ImposterPylons;
  public List<AActor> OnBuild_DisableCollisionForThese;
  public List<AActor> OnBuild_EnableCollisionForThese;
  public float MaxPolyHeight_Optional;
  public int DebugEdgeCount;
}

public class AAISwitchablePylon : APylon
{
  public bool bOpen;
}

public class UAmbientOcclusionEffect : UPostProcessEffect
{
  public FLinearColor OcclusionColor = new();
  public float OcclusionPower;
  public float OcclusionScale;
  public float OcclusionBias;
  public float MinOcclusion;
  public bool SSAO2;
  public bool bAngleBasedSSAO;
  public float OcclusionRadius;
  public float OcclusionAttenuation;
  public EAmbientOcclusionQuality OcclusionQuality;
  public float OcclusionFadeoutMinDistance;
  public float OcclusionFadeoutMaxDistance;
  public float HaloDistanceThreshold;
  public float HaloDistanceScale;
  public float HaloOcclusion;
  public float EdgeDistanceThreshold;
  public float EdgeDistanceScale;
  public float FilterDistanceScale;
  public int FilterSize;
  public float HistoryConvergenceTime;
  public float HistoryWeightConvergenceTime;
}

public class AKeypoint : AActor
{
  public USpriteComponent SpriteComp;
}

public partial class UBrushComponent : UPrimitiveComponent
{
  public class FKCachedConvexData_Mirror
  {
    public List<int> CachedConvexElements;
  }

  public UModel Brush;
  public UKMeshProps.FKAggregateGeom BrushAggGeom = new();
  public FPointer BrushPhysDesc = new();
  public URB_BodySetup.FKCachedConvexData CachedPhysBrushData = new();
  public int CachedPhysBrushDataVersion;
  public bool bBlockComplexCollisionTrace;
}

public class ABrush : AActor
{
  public class FGeomSelection
  {
    public int Type;
    public int Index;
    public int SelectionIndex;
  }

  public ECsgOper CsgOper;
  public FColor BrushColor = new();
  public int PolyFlags;
  public bool bColored;
  public bool bSolidWhenSelected;
  public bool bPlaceableFromClassBrowser;
  public UModel Brush;
  public UBrushComponent BrushComponent;
  public List<FGeomSelection> SavedSelections;
}

public class AVolume : ABrush
{
  public AActor AssociatedActor;
  public int LocationPriority;
  public string LocationName;
  public bool bForcePawnWalk;
  public bool bProcessAllActors;
}

public class AReverbVolume : AVolume
{
  public class FAudioReverbEffect
  {
    public float Time;
    public float Volume;
    public float Density;
    public float Diffusion;
    public float Gain;
    public float GainHF;
    public float DecayTime;
    public float DecayHFRatio;
    public float ReflectionsGain;
    public float ReflectionsDelay;
    public float LateGain;
    public float LateDelay;
    public float AirAbsorptionGainHF;
    public float RoomRolloffFactor;
  }

  public class FReverbSettings
  {
    public bool bApplyReverb;
    public ReverbPreset ReverbType;
    public float Volume;
    public float FadeTime;
    public AReverbVolume.FAudioReverbEffect CustomReverbEffect = new();
  }

  public class FInteriorSettings
  {
    public bool bIsWorldInfo;
    public float ExteriorVolume;
    public float ExteriorTime;
    public float ExteriorLPF;
    public float ExteriorLPFTime;
    public float InteriorVolume;
    public float InteriorTime;
    public float InteriorLPF;
    public float InteriorLPFTime;
  }

  public float Priority;
  public FReverbSettings Settings = new();
  public FInteriorSettings AmbientZoneSettings = new();
  public AReverbVolume NextLowerPriorityVolume;
}

public class UAudioComponent : UActorComponent
{
  public class FAudioComponentParam
  {
    public FName ParamName;
    public float FloatParam;
    public USoundNodeWave WaveParam;
  }

  public USoundCue SoundCue;
  public USoundNode CueFirstNode;
  public List<FAudioComponentParam> InstanceParameters;
  public bool bUseOwnerLocation;
  public bool bAutoPlay;
  public bool bAutoDestroy;
  public bool bStopWhenOwnerDestroyed;
  public bool bShouldRemainActiveIfDropped;
  public bool bWasOccluded;
  public bool bWasFloorOccluded;
  public bool bSuppressSubtitles;
  public bool bWasPlaying;
  public bool bAllowSpatialization;
  public bool bFinished;
  public bool bPreviewComponent;
  public bool bIgnoreForFlushing;
  public float StereoBleed;
  public float LFEBleed;
  public bool bEQFilterApplied;
  public bool bAlwaysPlay;
  public bool bIsUISound;
  public bool bIsMusic;
  public bool bNoReverb;
  public List<FPointer> WaveInstances;
  public List<byte> SoundNodeData;
  public Dictionary<byte, byte> SoundNodeOffsetMap;
  public FMultiMap_Mirror SoundNodeResetWaveMap = new();
  public FPointer Listener = new();
  public float PlaybackTime;
  public APortalVolume PortalVolume;
  public FVector Location = new();
  public FVector ComponentLocation = new();
  public AActor LastOwner;
  public float SubtitlePriority;
  public float FadeInStartTime;
  public float FadeInStopTime;
  public float FadeInTargetVolume;
  public float FadeOutStartTime;
  public float FadeOutStopTime;
  public float FadeOutTargetVolume;
  public float AdjustVolumeStartTime;
  public float AdjustVolumeStopTime;
  public float AdjustVolumeTargetVolume;
  public float CurrAdjustVolumeTargetVolume;
  public USoundNode CurrentNotifyBufferFinishedHook;
  public FVector CurrentLocation = new();
  public float CurrentVolume;
  public float CurrentPitch;
  public float CurrentHighFrequencyGain;
  public int CurrentUseSpatialization;
  public int CurrentUseSeamlessLooping;
  public float CurrentVolumeMultiplier;
  public float CurrentPitchMultiplier;
  public float CurrentHighFrequencyGainMultiplier;
  public float CurrentVoiceCenterChannelVolume;
  public float CurrentVoiceRadioVolume;
  public double LastUpdateTime = new();
  public float SourceInteriorVolume;
  public float SourceInteriorLPF;
  public float CurrentInteriorVolume;
  public float CurrentInteriorLPF;
  public FVector LastLocation = new();
  public AReverbVolume.FInteriorSettings LastInteriorSettings = new();
  public int LastReverbVolumeIndex;
  public float VolumeMultiplier;
  public float PitchMultiplier;
  public float HighFrequencyGainMultiplier;
  public float OcclusionCheckInterval;
  public float OcclusionSoundVolume;
  public float LastOcclusionCheckTime;
  public UDrawSoundRadiusComponent PreviewSoundRadius;
  public FScriptDelegate __OnAudioFinished__Delegate;
  public FScriptDelegate __OnQueueSubtitles__Delegate;
}

public class AAmbientSound : AKeypoint
{
  public bool bAutoPlay;
  public bool bIsPlaying;
  public UAudioComponent AudioComponent;
}

public class AAmbientSoundMovable : AAmbientSound
{
  public bool bFadeOnToggle;
  public float FadeInDuration;
  public float FadeInVolumeLevel;
  public float FadeOutDuration;
  public float FadeOutVolumeLevel;
}

public partial class USoundCue : UObject
{
  public partial class FSoundNodeEditorData : ISerialisable
  {
    public int NodePosX;
    public int NodePosY;
  }

  public FName SoundClass;
  public USoundNode FirstNode;
  public Dictionary<USoundNode, FSoundNodeEditorData> EditorData;
  public float MaxAudibleDistance;
  public float VolumeMultiplier;
  public float PitchMultiplier;
  public float Duration;
  public UFaceFXAnimSet FaceFXAnimSetRef;
  public string FaceFXGroupName;
  public string FaceFXAnimName;
  public int MaxConcurrentPlayCount;
  public int CurrentPlayCount;
  public FName SoundGroup;
}

public class USoundNode : UObject
{
  public int NodeUpdateHint;
  public List<USoundNode> ChildNodes;
  public bool bIrrelevantFromDS;
}

public class UDistributionFloatUniform : UDistributionFloat
{
  public float Min;
  public float Max;
}

public class USoundNodeAttenuation : USoundNode
{
  public bool bAttenuate;
  public bool bSpatialize;
  public bool bAttenuateWithLPF;
  public bool bAttenuateWithLowPassFilter;
  public float dBAttenuationAtMax;
  public SoundDistanceModel DistanceAlgorithm;
  public ESoundDistanceCalc DistanceType;
  public SoundDistanceModel DistanceModel;
  public float RadiusMin;
  public float RadiusMax;
  public float LPFRadiusMin;
  public float LPFRadiusMax;
  public UDistributionFloat.FRawDistributionFloat MinRadius = new();
  public UDistributionFloat.FRawDistributionFloat MaxRadius = new();
  public UDistributionFloat.FRawDistributionFloat LPFMinRadius = new();
  public UDistributionFloat.FRawDistributionFloat LPFMaxRadius = new();
}

public class USoundNodeAmbient : USoundNode
{
  public class FAmbientSoundSlot
  {
    public USoundNodeWave Wave;
    public float PitchScale;
    public float VolumeScale;
    public float Weight;
  }

  public bool bAttenuate;
  public bool bSpatialize;
  public bool bAttenuateWithLPF;
  public bool bAttenuateWithLowPassFilter;
  public float dBAttenuationAtMax;
  public SoundDistanceModel DistanceModel;
  public float RadiusMin;
  public float RadiusMax;
  public float LPFRadiusMin;
  public float LPFRadiusMax;
  public float PitchMin;
  public float PitchMax;
  public float VolumeMin;
  public float VolumeMax;
  public List<FAmbientSoundSlot> SoundSlots;
  public USoundNodeWave Wave;
  public UDistributionFloat.FRawDistributionFloat MinRadius = new();
  public UDistributionFloat.FRawDistributionFloat MaxRadius = new();
  public UDistributionFloat.FRawDistributionFloat LPFMinRadius = new();
  public UDistributionFloat.FRawDistributionFloat LPFMaxRadius = new();
  public UDistributionFloat.FRawDistributionFloat PitchModulation = new();
  public UDistributionFloat.FRawDistributionFloat VolumeModulation = new();
}

public class AAmbientSoundSimple : AAmbientSound
{
  public USoundNodeAmbient AmbientProperties;
  public USoundCue SoundCueInstance;
  public USoundNodeAmbient SoundNodeInstance;
}

public class USoundNodeAmbientNonLoop : USoundNodeAmbient
{
  public float DelayMin;
  public float DelayMax;
  public UDistributionFloat.FRawDistributionFloat DelayTime = new();
}

public class AAmbientSoundNonLoop : AAmbientSoundSimple
{
}

public class AAmbientSoundSimpleToggleable : AAmbientSoundSimple
{
  public class FCheckpointRecord
  {
    public bool bCurrentlyPlaying;
  }

  public bool bCurrentlyPlaying;
  public bool bFadeOnToggle;
  public float FadeInDuration;
  public float FadeInVolumeLevel;
  public float FadeOutDuration;
  public float FadeOutVolumeLevel;
}

public partial class UAnimSequence : UObject
{
  public class FCompressedTrack
  {
    public List<byte> ByteStream;
    public List<float> Times;
    public float[] Mins = new float[3];
    public float[] Ranges = new float[3];
  }

  public class FAnimTag
  {
    public string Tag;
    public List<string> Contains;
  }

  public class FAnimNotifyEvent
  {
    public float Time;
    public UAnimNotify Notify;
    public FName Comment;
    public float Duration;
  }

  public partial class FRawAnimSequenceTrack : ISerialisable
  {
    public List<UObject.FVector> PosKeys;
    public List<UObject.FQuat> RotKeys;
  }

  public class FTimeModifier
  {
    public float Time;
    public float TargetStrength;
  }

  public class FSkelControlModifier
  {
    public FName SkelControlName;
    public List<UAnimSequence.FTimeModifier> Modifiers;
  }

  public class FTranslationTrack
  {
    public List<UObject.FVector> PosKeys;
    public List<float> Times;
  }

  public class FRotationTrack
  {
    public List<UObject.FQuat> RotKeys;
    public List<float> Times;
  }

  public class FCurveTrack
  {
    public FName CurveName;
    public List<float> CurveWeights;
  }

  public FName SequenceName;
  public List<FAnimNotifyEvent> Notifies;
  public List<UAnimMetaData> MetaData;
  public List<FSkelControlModifier> BoneControlModifiers;
  public float SequenceLength;
  public int NumFrames;
  public float RateScale;
  public bool bNoLoopingInterpolation;
  public bool bIsAdditive;
  public bool bAdditiveBuiltLooping;
  public bool bDoNotOverrideCompression;
  public bool bHasBeenUsed;
  public List<FRawAnimSequenceTrack> RawAnimData;
  public List<FRawAnimSequenceTrack> RawAnimationData;
  public List<FTranslationTrack> TranslationData;
  public List<FRotationTrack> RotationData;
  public List<FCurveTrack> CurveData;
  public UAnimationCompressionAlgorithm CompressionScheme;
  public AnimationCompressionFormat TranslationCompressionFormat;
  public AnimationCompressionFormat RotationCompressionFormat;
  public AnimationKeyFormat KeyEncodingFormat;
  public List<int> CompressedTrackOffsets;
  public List<byte> CompressedByteStream;
  public FPointer TranslationCodec = new();
  public FPointer RotationCodec = new();
  public List<FBoneAtom> AdditiveRefPose;
  public List<FRawAnimSequenceTrack> AdditiveBasePose;
  public FName AdditiveRefName;
  public List<UAnimSequence> AdditiveBasePoseAnimSeq;
  public List<UAnimSequence> AdditiveTargetPoseAnimSeq;
  public List<UAnimSequence> RelatedAdditiveAnimSeqs;
  public int EncodingPkgVersion;
  public int CompressCommandletVersion;
  public float UseScore;
  public List<FAnimTag> AnimTags;
}

public class UAnimationCompressionAlgorithm : UObject
{
  public string Description;
  public bool bNeedsSkeleton;
  public AnimationCompressionFormat TranslationCompressionFormat;
  public AnimationCompressionFormat RotationCompressionFormat;
}

public class UAnimationCompressionAlgorithm_BitwiseCompressOnly : UAnimationCompressionAlgorithm
{
}

public class UAnimationCompressionAlgorithm_RemoveEverySecondKey : UAnimationCompressionAlgorithm
{
  public int MinKeys;
  public bool bStartAtSecondKey;
}

public class UAnimationCompressionAlgorithm_RemoveLinearKeys : UAnimationCompressionAlgorithm
{
  public float MaxPosDiff;
  public float MaxAngleDiff;
  public float MaxEffectorDiff;
  public float MinEffectorDiff;
  public float ParentKeyScale;
  public bool bRetarget;
}

public class UAnimationCompressionAlgorithm_RemoveTrivialKeys : UAnimationCompressionAlgorithm
{
  public float MaxPosDiff;
  public float MaxAngleDiff;
}

public class UAnimationCompressionAlgorithm_RevertToRaw : UAnimationCompressionAlgorithm
{
}

public class UAnimMetaData : UObject
{
}

public class UAnimMetaData_SkelControl : UAnimMetaData
{
  public List<FName> SkelControlNameList;
  public bool bFullControlOverController;
  public FName SkelControlName;
}

public class UAnimMetaData_SkelControlKeyFrame : UAnimMetaData_SkelControl
{
  public List<UAnimSequence.FTimeModifier> KeyFrames;
}

public class UAnimObject : UObject
{
  public int DrawWidth;
  public int DrawHeight;
  public int NodePosX;
  public int NodePosY;
  public int OutDrawY;
  public string CategoryDesc;
  public USkeletalMeshComponent SkelComponent;
}

public class UAnimNode : UAnimObject
{
  public class FBoneTransform
  {
  }

  public class FCurveKey
  {
    public FName CurveName;
    public float Weight;
  }

  public bool bRelevant;
  public bool bJustBecameRelevant;
  public bool bSkipTickWhenZeroWeight;
  public bool bTickDuringPausedAnims;
  public bool bUsePOwner;
  public int NodeTickTag;
  public int NodeCachedAtomsTag;
  public float NodeTotalWeight;
  public float TotalWeightAccumulator;
  public FInlinePointerArray_Mirror ParentNodes = new();
  public FName NodeName;
  public List<FBoneAtom> CachedBoneAtoms;
  public byte CachedNumDesiredBones;
  public FBoneAtom CachedRootMotionDelta = new();
  public int bCachedHasRootMotion;
  public List<FCurveKey> CachedCurveKeys;
  public int SearchTag;
  public List<FCurveKey> LastUpdatedAnimMorphKeys;
  public APawn POwner;
}

public class UAnimNodeBlendBase : UAnimNode
{
  public class FAnimBlendChild
  {
    public FName Name;
    public UAnimNode Anim;
    public float Weight;
    public float TotalWeight;
    public float BlendWeight;
    public int bHasRootMotion;
    public UObject.FBoneAtom RootMotion = new();
    public bool bMirrorSkeleton;
    public bool bIsAdditive;
    public int DrawY;
  }

  public List<FAnimBlendChild> Children;
  public bool bFixNumChildren;
  public AlphaBlendType BlendType;
}

public class UAnimNode_MultiBlendPerBone : UAnimNodeBlendBase
{
  public class FWeightNodeRule
  {
    public FName NodeName;
    public UAnimNodeBlendBase CachedNode;
    public UAnimNodeSlot CachedSlotNode;
    public EWeightCheck WeightCheck;
    public int ChildIndex;
  }

  public class FWeightRule
  {
    public UAnimNode_MultiBlendPerBone.FWeightNodeRule FirstNode = new();
    public UAnimNode_MultiBlendPerBone.FWeightNodeRule SecondNode = new();
  }

  public class FBranchInfo
  {
    public FName BoneName;
    public float PerBoneWeightIncrease;
  }

  public class FPerBoneMaskInfo
  {
    public List<UAnimNode_MultiBlendPerBone.FBranchInfo> BranchList;
    public float DesiredWeight;
    public float BlendTimeToGo;
    public List<UAnimNode_MultiBlendPerBone.FWeightRule> WeightRuleList;
    public bool bWeightBasedOnNodeRules;
    public bool bDisableForNonLocalHumanPlayers;
    public bool bPendingBlend;
    public List<float> PerBoneWeights;
    public List<byte> TransformReqBone;
    public int TransformReqBoneIndex;
  }

  public APawn PawnOwner;
  public List<FPerBoneMaskInfo> MaskList;
  public EBlendType RotationBlendType;
}

public class UAnimNodeBlend : UAnimNodeBlendBase
{
  public float Child2Weight;
  public float Child2WeightTarget;
  public float BlendTimeToGo;
  public bool bSkipBlendWhenNotRendered;
}

public class UAnimNodeAdditiveBlending : UAnimNodeBlend
{
  public bool bPassThroughWhenNotRendered;
}

public partial class UAnimNodeAimOffset : UAnimNodeBlendBase
{
  public partial class FAimTransform : ISerialisable
  {
    public UObject.FQuat Quaternion = new();
    public UObject.FVector Translation = new();
  }

  public partial class FAimComponent : ISerialisable
  {
    public FName BoneName;
    public UAnimNodeAimOffset.FAimTransform LU = new();
    public UAnimNodeAimOffset.FAimTransform LC = new();
    public UAnimNodeAimOffset.FAimTransform LD = new();
    public UAnimNodeAimOffset.FAimTransform CU = new();
    public UAnimNodeAimOffset.FAimTransform CC = new();
    public UAnimNodeAimOffset.FAimTransform CD = new();
    public UAnimNodeAimOffset.FAimTransform RU = new();
    public UAnimNodeAimOffset.FAimTransform RC = new();
    public UAnimNodeAimOffset.FAimTransform RD = new();
  }

  public partial class FAimOffsetProfile : ISerialisable
  {
    public FName ProfileName;
    public UObject.FVector2D HorizontalRange = new();
    public UObject.FVector2D VerticalRange = new();
    public List<UAnimNodeAimOffset.FAimComponent> AimComponents;
    public FName AnimName_LU;
    public FName AnimName_LC;
    public FName AnimName_LD;
    public FName AnimName_CU;
    public FName AnimName_CC;
    public FName AnimName_CD;
    public FName AnimName_RU;
    public FName AnimName_RC;
    public FName AnimName_RD;
  }

  public FVector2D Aim = new();
  public FVector2D AngleOffset = new();
  public bool bForceAimDir;
  public bool bBakeFromAnimations;
  public bool bPassThroughWhenNotRendered;
  public bool bSynchronizeNodesInEditor;
  public int PassThroughAtOrAboveLOD;
  public EAnimAimDir ForcedAimDir;
  public List<byte> RequiredBones;
  public List<byte> AimCpntBoneIndex;
  public List<byte> AimCpntIndexLUT;
  public UAnimNodeAimOffset TemplateNode;
  public List<FAimOffsetProfile> Profiles;
  public int CurrentProfileIndex;
}

public class UAnimNodeBlendList : UAnimNodeBlendBase
{
  public List<float> TargetWeight;
  public float BlendTimeToGo;
  public int ActiveChildIndex;
  public bool bPlayActiveChild;
  public bool bForceChildFullWeightWhenBecomingRelevant;
  public bool bSkipBlendWhenNotRendered;
  public float SliderPosition;
  public int EditorActiveChildIndex;
}

public class UAnimNodeBlendByBase : UAnimNodeBlendList
{
  public EBaseBlendType Type;
  public FName ActorTag;
  public UClass ActorClass;
  public float BlendTime;
  public AActor CachedBase;
}

public class UAnimNodeBlendByPhysics : UAnimNodeBlendList
{
}

public class UAnimNodeBlendByPosture : UAnimNodeBlendList
{
}

public class UAnimNodeBlendByProperty : UAnimNodeBlendList
{
  public FName PropertyName;
  public bool bUseOwnersBase;
  public bool bForceUpdate;
  public bool bUseSpecificBlendTimes;
  public bool bSynchronizeNodesInEditor;
  public FName CachedPropertyName;
  public FPointer CachedFloatProperty = new();
  public FPointer CachedBoolProperty = new();
  public FPointer CachedByteProperty = new();
  public AActor CachedOwner;
  public float BlendTime;
  public float FloatPropMin;
  public float FloatPropMax;
  public float BlendToChild1Time;
  public float BlendToChild2Time;
}

public class UAnimNodeBlendBySpeed : UAnimNodeBlendList
{
  public float Speed;
  public int LastChannel;
  public float BlendUpTime;
  public float BlendDownTime;
  public float BlendDownPerc;
  public List<float> Constraints;
  public bool bUseAcceleration;
  public float BlendUpDelay;
  public float BlendDownDelay;
  public float BlendDelayRemaining;
}

public class UAnimNodeBlendDirectional : UAnimNodeBlendBase
{
  public float DirDegreesPerSecond;
  public float DirAngle;
  public int SingleAnimAtOrAboveLOD;
  public FRotator RotationOffset = new();
}

public class UAnimNodeBlendMultiBone : UAnimNodeBlendBase
{
  public class FChildBoneBlendInfo
  {
    public List<float> TargetPerBoneWeight;
    public FName InitTargetStartBone;
    public float InitPerBoneIncrease;
    public FName OldStartBone;
    public float OldBoneIncrease;
    public List<byte> TargetRequiredBones;
  }

  public List<FChildBoneBlendInfo> BlendTargetList;
  public List<byte> SourceRequiredBones;
}

public class UAnimNodeBlendPerBone : UAnimNodeBlend
{
  public bool bForceLocalSpaceBlend;
  public List<FName> BranchStartBoneName;
  public List<float> Child2PerBoneWeight;
  public List<byte> LocalToCompReqBones;
}

public class UAnimNodeCrossfader : UAnimNodeBlend
{
  public FName DefaultAnimSeqName;
  public bool bDontBlendOutOneShot;
  public float PendingBlendOutTimeOneShot;
}

public class UAnimNodeMirror : UAnimNodeBlendBase
{
  public bool bEnableMirroring;
}

public class UAnimNodeSequence : UAnimNode
{
  public FName AnimSeqName;
  public float Rate;
  public bool bPlaying;
  public bool bLooping;
  public bool bCauseActorAnimEnd;
  public bool bCauseActorAnimPlay;
  public bool bZeroRootRotation;
  public bool bZeroRootTranslation;
  public bool bDisableWarningWhenAnimNotFound;
  public bool bNoNotifies;
  public bool bForceRefposeWhenNotPlaying;
  public bool bIsIssuingNotifies;
  public bool bForceAlwaysSlave;
  public bool bSynchronize;
  public bool bReverseSync;
  public bool bShowTimeLineSlider;
  public bool bLoopCameraAnim;
  public bool bRandomizeCameraAnimLoopStartTime;
  public bool bEditorOnlyAddRefPoseToAdditiveAnimation;
  public float CurrentTime;
  public float PreviousTime;
  public UAnimSequence AnimSeq;
  public int AnimLinkupIndex;
  public float NotifyWeightThreshold;
  public FName SynchGroupName;
  public float SynchPosOffset;
  public UTexture2D DebugTrack;
  public UTexture2D DebugCarat;
  public UCameraAnim CameraAnim;
  public UCameraAnimInst ActiveCameraAnimInstance;
  public float CameraAnimScale;
  public float CameraAnimPlayRate;
  public float CameraAnimBlendInTime;
  public float CameraAnimBlendOutTime;
  public ERootBoneAxis[] RootBoneOption = new ERootBoneAxis[3];
  public ERootRotationOption[] RootRotationOption = new ERootRotationOption[3];
}

public class UAnimNodePlayCustomAnim : UAnimNodeBlend
{
  public bool bIsPlayingCustomAnim;
  public float CustomPendingBlendOutTime;
}

public class UAnimNodeRandom : UAnimNodeBlendList
{
  public class FRandomAnimInfo
  {
    public float Chance;
    public byte LoopCountMin;
    public byte LoopCountMax;
    public float BlendInTime;
    public UObject.FVector2D PlayRateRange = new();
    public bool bStillFrame;
    public byte LoopCount;
  }

  public List<FRandomAnimInfo> RandomInfo;
  public UAnimNodeSequence PlayingSeqNode;
  public int PendingChildIndex;
}

public class UAnimNodeScalePlayRate : UAnimNodeBlendBase
{
  public float ScaleByValue;
}

public class UAnimNodeScaleRateBySpeed : UAnimNodeScalePlayRate
{
  public float BaseSpeed;
}

public class UAnimNodeSequenceBlendBase : UAnimNodeSequence
{
  public class FAnimInfo
  {
    public FName AnimSeqName;
    public UAnimSequence AnimSeq;
    public int AnimLinkupIndex;
  }

  public class FAnimBlendInfo
  {
    public FName AnimName;
    public UAnimNodeSequenceBlendBase.FAnimInfo AnimInfo = new();
    public float Weight;
  }

  public List<FAnimBlendInfo> Anims;
}

public class UAnimNodeSequenceBlendByAim : UAnimNodeSequenceBlendBase
{
  public FVector2D Aim = new();
  public FVector2D PreviousAim = new();
  public FVector2D HorizontalRange = new();
  public FVector2D VerticalRange = new();
  public FVector2D AngleOffset = new();
  public FName AnimName_LU;
  public FName AnimName_LC;
  public FName AnimName_LD;
  public FName AnimName_CU;
  public FName AnimName_CC;
  public FName AnimName_CD;
  public FName AnimName_RU;
  public FName AnimName_RC;
  public FName AnimName_RD;
}

public class UAnimNodeSlot : UAnimNodeBlendBase
{
  public bool bIsPlayingCustomAnim;
  public bool bEarlyAnimEndNotify;
  public bool bSkipBlendWhenNotRendered;
  public bool bAdditiveAnimationsOverrideSource;
  public float PendingBlendOutTime;
  public int CustomChildIndex;
  public int TargetChildIndex;
  public List<float> TargetWeight;
  public float BlendTimeToGo;
  public UAnimNodeSynch SynchNode;
}

public class UAnimNodeSynch : UAnimNodeBlendBase
{
  public class FSynchGroup
  {
    public List<UAnimNodeSequence> SeqNodes;
    public UAnimNodeSequence MasterNode;
    public FName GroupName;
    public bool bFireSlaveNotifies;
    public float RateScale;
  }

  public List<FSynchGroup> Groups;
}

public class UAnimNotify : UObject
{
  public FColor NotifyColor = new();
}

public class UAnimNotify_CameraEffect : UAnimNotify
{
  public UClass CameraLensEffect;
}

public class UAnimNotify_Footstep : UAnimNotify
{
  public int FootDown;
  public bool bFirstPerson;
}

public class UAnimNotify_Kismet : UAnimNotify
{
  public FName NotifyName;
}

public class UAnimNotify_Scripted : UAnimNotify
{
}

public class UAnimNotify_PawnMaterialParam : UAnimNotify_Scripted
{
  public List<APawn.FScalarParameterInterpStruct> ScalarParameterInterpArray;
}

public class UAnimNotify_PlayFaceFXAnim : UAnimNotify_Scripted
{
  public UFaceFXAnimSet FaceFXAnimSetRef;
  public string GroupName;
  public string AnimName;
  public USoundCue SoundCueToPlay;
  public bool bOverridePlayingAnim;
  public float PlayFrequency;
}

public class UAnimNotify_PlayParticleEffect : UAnimNotify
{
  public UParticleSystem PSTemplate;
  public bool bIsExtremeContent;
  public bool bAttach;
  public bool bPreview;
  public bool bSkipIfOwnerIsHidden;
  public FName SocketName;
  public FName BoneName;
}

public class UAnimNotify_Rumble : UAnimNotify
{
  public UClass PredefinedWaveForm;
  public UForceFeedbackWaveform WaveForm;
  public bool bCheckForBasedPlayer;
  public float EffectRadius;
}

public class UAnimNotify_Script : UAnimNotify
{
  public FName NotifyName;
  public FName NotifyTickName;
  public FName NotifyEndName;
}

public class UAnimNotify_Sound : UAnimNotify
{
  public USoundCue SoundCue;
  public bool bFollowActor;
  public bool bIgnoreIfActorHidden;
  public FName BoneName;
  public float PercentToPlay;
  public float VolumeMultiplier;
  public float PitchMultiplier;
}

public class UAnimNotify_Trails : UAnimNotify
{
  public class FTrailSocketSamplePoint
  {
    public UObject.FVector Position = new();
    public UObject.FVector Velocity = new();
  }

  public class FTrailSamplePoint
  {
    public float RelativeTime;
    public UAnimNotify_Trails.FTrailSocketSamplePoint FirstEdgeSample = new();
    public UAnimNotify_Trails.FTrailSocketSamplePoint SecondEdgeSample = new();
    public UAnimNotify_Trails.FTrailSocketSamplePoint ControlPointSample = new();
  }

  public class FTrailSample
  {
    public float RelativeTime;
    public UObject.FVector FirstEdgeSample = new();
    public UObject.FVector SecondEdgeSample = new();
    public UObject.FVector ControlPointSample = new();
  }

  public UParticleSystem PSTemplate;
  public bool bIsExtremeContent;
  public bool bPreview;
  public bool bSkipIfOwnerIsHidden;
  public bool bResampleRequired;
  public FName FirstEdgeSocketName;
  public FName SecondEdgeSocketName;
  public FName ControlPointSocketName;
  public float LastStartTime;
  public float EndTime;
  public float SampleTimeStep;
  public List<FTrailSamplePoint> TrailSampleData;
  public float SamplesPerSecond;
  public List<FTrailSample> TrailSampledData;
  public float CurrentTime;
  public float TimeStep;
  public UAnimNodeSequence AnimNodeSeq;
}

public class UAnimNotify_ViewShake : UAnimNotify_Scripted
{
  public float Duration;
  public FVector RotAmplitude = new();
  public FVector RotFrequency = new();
  public FVector LocAmplitude = new();
  public FVector LocFrequency = new();
  public float FOVAmplitude;
  public float FOVFrequency;
  public bool bDoControllerVibration;
  public bool bUseBoneLocation;
  public float ShakeRadius;
  public FName BoneName;
  public UCameraShake ShakeParams;
}

public class UAnimSet : UObject
{
  public class FAnimSetMeshLinkup
  {
    public ulong SkelMeshLinkupRUID = new();
    public List<int> BoneToTrackTable;
    public List<byte> BoneUseAnimTranslation;
    public List<byte> ForceUseMeshTranslation;
  }

  public bool bAnimRotationOnly;
  public List<FName> TrackBoneNames;
  public List<UAnimSequence> Sequences;
  public Dictionary<byte, byte> SequenceCache;
  public List<FAnimSetMeshLinkup> LinkupCache;
  public List<FName> UseTranslationBoneNames;
  public List<FName> ForceMeshTranslationBoneNames;
  public FName PreviewSkelMeshName;
}

public class UAnimTree : UAnimNodeBlendBase
{
  public class FAnimGroup
  {
    public List<UAnimNodeSequence> SeqNodes;
    public UAnimNodeSequence SynchMaster;
    public UAnimNodeSequence NotifyMaster;
    public FName GroupName;
    public float RateScale;
    public float SynchPctPosition;
  }

  public class FSkelControlListHead
  {
    public FName BoneName;
    public USkelControlBase ControlHead;
    public int DrawY;
  }

  public class FPreviewSkelMeshStruct
  {
    public FName DisplayName;
    public USkeletalMesh PreviewSkelMesh;
    public List<UMorphTargetSet> PreviewMorphSets;
  }

  public class FPreviewSocketStruct
  {
    public FName DisplayName;
    public FName SocketName;
    public USkeletalMesh PreviewSkelMesh;
    public UStaticMesh PreviewStaticMesh;
  }

  public class FPreviewAnimSetsStruct
  {
    public FName DisplayName;
    public List<UAnimSet> PreviewAnimSets;
  }

  public List<FAnimGroup> AnimGroups;
  public List<FName> PrioritizedSkelBranches;
  public List<FName> ComposePrePassBoneNames;
  public List<FName> ComposePostPassBoneNames;
  public List<UMorphNodeBase> RootMorphNodes;
  public List<FSkelControlListHead> SkelControlLists;
  public List<FBoneAtom> SavedPose;
  public bool bUseSavedPose;
  public bool bBeingEdited;
  public int MorphConnDrawY;
  public float PreviewPlayRate;
  public USkeletalMesh PreviewSkelMesh;
  public USkeletalMesh SocketSkelMesh;
  public UStaticMesh SocketStaticMesh;
  public FName SocketName;
  public List<UAnimSet> PreviewAnimSets;
  public List<UMorphTargetSet> PreviewMorphSets;
  public List<FPreviewSkelMeshStruct> PreviewMeshList;
  public int PreviewMeshIndex;
  public List<FPreviewSocketStruct> PreviewSocketList;
  public int PreviewSocketIndex;
  public List<FPreviewAnimSetsStruct> PreviewAnimSetList;
  public int PreviewAnimSetListIndex;
  public int PreviewAnimSetIndex;
  public FVector PreviewCamPos = new();
  public FRotator PreviewCamRot = new();
  public FVector PreviewFloorPos = new();
  public int PreviewFloorYaw;
}

public class UApexAsset : UObject
{
  public List<UApexComponentBase> ApexComponents;
}

public class UApexClothingAsset : UApexAsset
{
  public FPointer MApexAsset = new();
  public List<UMaterialInterface> Materials;
  public UApexGenericAsset ApexClothingLibrary;
  public bool bUseHardwareCloth;
  public bool bFallbackSkinning;
  public bool bSlowStart;
  public int UVChannelForTangentUpdate;
  public float MaxDistanceBlendTime;
  public float ContinuousRotationThreshold;
  public float ContinuousDistanceThreshold;
  public float LodWeightsMaxDistance;
  public float LodWeightsDistanceWeight;
  public float LodWeightsBias;
  public float LodWeightsBenefitsBias;
}

public class UApexComponentBase : UMeshComponent
{
  public FPointer ComponentBaseResources = new();
  public FRenderCommandFence_Mirror ReleaseResourcesFence = new();
  public UApexAsset Asset;
  public FColor WireframeColor = new();
  public bool bAssetChanged;
}

public class ULightEnvironmentComponent : UActorComponent
{
  public bool bEnabled;
  public bool bForceNonCompositeDynamicLights;
  public bool bAllowDynamicShadowsOnTranslucency;
  public bool bAllowPreShadow;
  public bool bTranslucencyShadowed;
  public float DominantShadowFactor;
  public ULightComponent AffectingDominantLight;
  public List<UPrimitiveComponent> AffectedComponents;
}

public partial class ULightComponent : UActorComponent
{
  public class FLightingChannelContainer
  {
    public bool bInitialized;
    public bool BSP;
    public bool Static;
    public bool Dynamic;
    public bool CompositeDynamic;
    public bool Skybox;
    public bool Unnamed_1;
    public bool Unnamed_2;
    public bool Unnamed_3;
    public bool Unnamed_4;
    public bool Unnamed_5;
    public bool Unnamed_6;
    public bool Cinematic_1;
    public bool Cinematic_2;
    public bool Cinematic_3;
    public bool Cinematic_4;
    public bool Cinematic_5;
    public bool Cinematic_6;
    public bool Cinematic_7;
    public bool Cinematic_8;
    public bool Cinematic_9;
    public bool Cinematic_10;
    public bool Gameplay_1;
    public bool Gameplay_2;
    public bool Gameplay_3;
    public bool Gameplay_4;
    public bool Crowd;
  }

  public partial class FConvexVolume : ISerialisable
  {
    public List<UObject.FPlane> PermutedPlanes;
    public List<UObject.FPlane> Planes;
  }

  public FPointer SceneInfo = new();
  public FMatrix WorldToLight = new();
  public FMatrix LightToWorld = new();
  public FGuid LightGuid = new();
  public FGuid LightmapGuid = new();
  public float Brightness;
  public FColor LightColor = new();
  public ULightFunction Function;
  public float LightEnv_BouncedLightBrightness;
  public FColor LightEnv_BouncedModulationColor = new();
  public bool bEnabled;
  public bool CastShadows;
  public bool CastStaticShadows;
  public bool CastDynamicShadows;
  public bool bCastCompositeShadow;
  public bool bAffectCompositeShadowDirection;
  public bool bNonModulatedSelfShadowing;
  public bool bSelfShadowOnly;
  public bool bAllowPreShadow;
  public bool bForceDynamicLight;
  public bool UseDirectLightMap;
  public bool bHasLightEverBeenBuiltIntoLightMap;
  public bool bOnlyAffectSameAndSpecifiedLevels;
  public bool bCanAffectDynamicPrimitivesOutsideDynamicChannel;
  public bool bUseVolumes;
  public bool bRenderLightShafts;
  public bool bPrecomputedLightingIsValid;
  public ULightEnvironmentComponent LightEnvironment;
  public List<FName> OtherLevelsToAffect;
  public FLightingChannelContainer LightingChannels = new();
  public List<ABrush> InclusionVolumes;
  public List<ABrush> ExclusionVolumes;
  public List<FConvexVolume> InclusionConvexVolumes;
  public List<FConvexVolume> ExclusionConvexVolumes;
  public ELightAffectsClassification LightAffectsClassification;
  public ELightShadowMode LightShadowMode;
  public FLinearColor ModShadowColor = new();
  public float ModShadowFadeoutTime;
  public float ModShadowFadeoutExponent;
  public int LightListIndex;
  public EShadowProjectionTechnique ShadowProjectionTechnique;
  public EShadowFilterQuality ShadowFilterQuality;
  public int MinShadowResolution;
  public int MaxShadowResolution;
  public int ShadowFadeResolution;
  public float OcclusionDepthRange;
  public float BloomScale;
  public float BloomThreshold;
  public float BloomScreenBlendThreshold;
  public FColor BloomTint = new();
  public float RadialBlurPercent;
  public float OcclusionMaskDarkness;
}

public class UDynamicLightEnvironmentComponent : ULightEnvironmentComponent
{
  public FPointer State = new();
  public float InvisibleUpdateTime;
  public float MinTimeBetweenFullUpdates;
  public float ShadowInterpolationSpeed;
  public int NumVolumeVisibilitySamples;
  public FLinearColor AmbientShadowColor = new();
  public FVector AmbientShadowSourceDirection = new();
  public FLinearColor AmbientGlow = new();
  public float LightDesaturation;
  public float LightDistance;
  public float ShadowDistance;
  public bool bCastShadows;
  public bool bCompositeShadowsFromDynamicLights;
  public bool bForceCompositeAllLights;
  public bool bUseBooleanEnvironmentShadowing;
  public bool bDynamic;
  public bool bSynthesizeDirectionalLight;
  public bool bSynthesizeSHLight;
  public bool bForceAllowLightEnvSphericalHarmonicLights;
  public bool bRequiresNonLatentUpdates;
  public bool bTraceFromClosestBoundsPoint;
  public bool bIsCharacterLightEnvironment;
  public bool bOverrideOwnerLightingChannels;
  public float ModShadowFadeoutTime;
  public float ModShadowFadeoutExponent;
  public FLinearColor MaxModulatedShadowColor = new();
  public float IndirectLightingIntense;
  public float DominantShadowTransitionStartDistance;
  public float DominantShadowTransitionEndDistance;
  public int MinShadowResolution;
  public int MaxShadowResolution;
  public int ShadowFadeResolution;
  public EShadowFilterQuality ShadowFilterQuality;
  public ELightShadowMode LightShadowMode;
  public EDynamicLightEnvironmentBoundsMethod BoundsMethod;
  public float BouncedLightingFactor;
  public float MinShadowAngle;
  public FBoxSphereBounds OverriddenBounds = new();
  public ULightComponent.FLightingChannelContainer OverriddenLightingChannels = new();
  public List<ULightComponent> OverriddenLightComponents;
}

public class UApexStaticComponent : UApexComponentBase
{
}

public class UApexStaticDestructibleComponent : UApexStaticComponent
{
  public FPointer ApexDestructibleActor = new();
  public FPointer ApexDestructiblePreview = new();
}

public class AApexDestructibleActor : AActor
{
  public UApexStaticDestructibleComponent StaticDestructibleComponent;
  public List<byte> VisibilityFactors;
}

public class UApexDestructibleAsset : UApexAsset
{
  public class FNxDestructibleDepthParameters
  {
    public bool TAKE_IMPACT_DAMAGE;
    public bool IGNORE_POSE_UPDATES;
    public bool IGNORE_RAYCAST_CALLBACKS;
    public bool IGNORE_CONTACT_CALLBACKS;
    public bool USER_FLAG_0;
    public bool USER_FLAG_1;
    public bool USER_FLAG_2;
    public bool USER_FLAG_3;
  }

  public class FNxDestructibleParametersFlag
  {
    public bool ACCUMULATE_DAMAGE;
    public bool ASSET_DEFINED_SUPPORT;
    public bool WORLD_SUPPORT;
    public bool DEBRIS_TIMEOUT;
    public bool DEBRIS_MAX_SEPARATION;
    public bool CRUMBLE_SMALLEST_CHUNKS;
    public bool ACCURATE_RAYCASTS;
    public bool USE_VALID_BOUNDS;
  }

  public class FNxDestructibleParameters
  {
    public float DamageThreshold;
    public float DamageToRadius;
    public float DamageCap;
    public float ForceToDamage;
    public float ImpactVelocityThreshold;
    public float DamageToPercentDeformation;
    public float DeformationPercentLimit;
    public bool bFormExtendedStructures;
    public int SupportDepth;
    public int DebrisDepth;
    public int EssentialDepth;
    public float DebrisLifetimeMin;
    public float DebrisLifetimeMax;
    public float DebrisMaxSeparationMin;
    public float DebrisMaxSeparationMax;
    public UObject.FBox ValidBounds = new();
    public float MaxChunkSpeed;
    public float MassScaleExponent;
    public UApexDestructibleAsset.FNxDestructibleParametersFlag Flags = new();
    public float GrbVolumeLimit;
    public float GrbParticleSpacing;
    public float FractureImpulseScale;
    public List<UApexDestructibleAsset.FNxDestructibleDepthParameters> DepthParameters;
  }

  public FPointer MApexAsset = new();
  public List<UMaterialInterface> Materials;
  public string CrumbleEmitterName;
  public string DustEmitterName;
  public bool bDynamic;
  public FNxDestructibleParameters DestructibleParameters = new();
}

public class UApexDynamicComponent : UApexComponentBase
{
  public FPointer ComponentDynamicResources = new();
}

public class UApexGenericAsset : UApexAsset
{
  public FPointer MApexAsset = new();
}

public class UArrowComponent : UPrimitiveComponent
{
  public FColor ArrowColor = new();
  public float ArrowSize;
  public bool bTreatAsASprite;
}

public class UAudioDevice : USubsystem
{
  public class FListener
  {
    public APortalVolume PortalVolume;
    public UObject.FVector Location = new();
    public UObject.FVector Up = new();
    public UObject.FVector Right = new();
    public UObject.FVector Front = new();
  }

  public class FAudioClassInfo
  {
    public int NumResident;
    public int SizeResident;
    public int NumRealTime;
    public int SizeRealTime;
  }

  public int MaxChannels;
  public int CommonAudioPoolSize;
  public float LowPassFilterResonance;
  public float MinCompressedDurationEditor;
  public float MinCompressedDurationGame;
  public FPointer CommonAudioPool = new();
  public int CommonAudioPoolFreeBytes;
  public List<UAudioComponent> AudioComponents;
  public List<FPointer> Sources;
  public List<FPointer> FreeSources;
  public Dictionary<byte, byte> WaveInstanceSourceMap;
  public bool bGameWasTicking;
  public List<FListener> Listeners;
  public ulong CurrentTick = new();
  public Dictionary<byte, byte> SoundClasses;
  public Dictionary<byte, byte> SourceSoundClasses;
  public Dictionary<byte, byte> CurrentSoundClasses;
  public Dictionary<byte, byte> DestinationSoundClasses;
  public Dictionary<byte, byte> SoundModes;
  public FPointer Effects = new();
  public FName BaseSoundModeName;
  public USoundMode CurrentMode;
  public double SoundModeStartTime = new();
  public double SoundModeFadeInStartTime = new();
  public double SoundModeFadeInEndTime = new();
  public double SoundModeEndTime = new();
  public int ListenerVolumeIndex;
  public AReverbVolume.FInteriorSettings ListenerInteriorSettings = new();
  public double InteriorStartTime = new();
  public double InteriorEndTime = new();
  public double ExteriorEndTime = new();
  public double InteriorLPFEndTime = new();
  public double ExteriorLPFEndTime = new();
  public float InteriorVolumeInterp;
  public float InteriorLPFInterp;
  public float ExteriorVolumeInterp;
  public float ExteriorLPFInterp;
  public UAudioComponent TestAudioComponent;
  public FPointer TextToSpeech = new();
  public EDebugState DebugState;
  public float TransientMasterVolume;
  public float LastUpdateTime;
}

public class ALadder : ANavigationPoint
{
  public ALadderVolume MyLadder;
  public ALadder LadderList;
}

public class AAutoLadder : ALadder
{
}

public class UAutoNavMeshPathObstacleUnregister : UObject
{
  public FScriptInterface PathObstacleRef;
}

public class AAutoTestManager : AInfo
{
  public bool bAutomatedPerfTesting;
  public bool bAutoContinueToNextRound;
  public bool bUsingAutomatedTestingMapList;
  public bool bAutomatedTestingWithOpen;
  public bool bCheckingForFragmentation;
  public bool bCheckingForMemLeaks;
  public bool bDoingASentinelRun;
  public bool bSentinelStreamingLevelStillLoading;
  public int AutomatedPerfRemainingTime;
  public int AutomatedTestingMapIndex;
  public List<string> AutomatedMapTestingList;
  public int NumAutomatedMapTestingCycles;
  public int NumberOfMatchesPlayed;
  public int NumMapListCyclesDone;
  public string AutomatedTestingExecCommandToRunAtStartMatch;
  public string AutomatedMapTestingTransitionMap;
  public string SentinelTaskDescription;
  public string SentinelTaskParameter;
  public string SentinelTagDesc;
  public APlayerController SentinelPC;
  public List<FVector> SentinelTravelArray;
  public int SentinelNavigationIdx;
  public int SentinelIdx;
  public int NumRotationsIncrement;
  public int TravelPointsIncrement;
  public int NumMinutesPerMap;
  public List<string> CommandsToRunAtEachTravelTheWorldNode;
  public string CommandStringToExec;
}

public class ABlockingVolume : AVolume
{
  public bool bBlockCamera;
}

public class UBlurEffect : UPostProcessEffect
{
  public int BlurKernelSize;
}

public class UBookMark : UObject
{
  public FVector Location = new();
  public FRotator Rotation = new();
}

public class UBookMark2D : UObject
{
  public float Zoom2D;
  public FIntPoint Location = new();
}

public class ABroadcastHandler : AInfo
{
  public int SentText;
  public bool bMuteSpectators;
}

public class ABrushShape : ABrush
{
}

public class ACameraActor : AActor
{
  public bool bConstrainAspectRatio;
  public bool bCamOverridePostProcess;
  public float AspectRatio;
  public float FOVAngle;
  public float NearPlane;
  public float CamOverridePostProcessAlpha;
  public APostProcessVolume.FPostProcessSettings CamOverridePostProcess = new();
  public UDrawFrustumComponent DrawFrustum;
  public UStaticMeshComponent MeshComp;
  public FVector InitialLocation = new();
  public FRotator InitialRotation = new();
  public float TargetScore;
  public int InterpolatingStartCounter;
}

public class UCameraAnim : UObject
{
  public UInterpGroup CameraInterpGroup;
  public float AnimLength;
  public FBox BoundingBox = new();
  public APostProcessVolume.FPostProcessSettings BasePPSettings = new();
  public float BasePPSettingsAlpha;
  public float BaseFOV;
}

public class UInterpGroupInst : UObject
{
  public UInterpGroup Group;
  public AActor GroupActor;
  public List<UInterpTrackInst> TrackInst;
}

public class UCameraAnimInst : UObject
{
  public UCameraAnim CamAnim;
  public UInterpGroupInst InterpGroupInst;
  public float CurTime;
  public bool bLooping;
  public bool bFinished;
  public bool bAutoReleaseWhenFinished;
  public bool bBlendingIn;
  public bool bBlendingOut;
  public float BlendInTime;
  public float BlendOutTime;
  public float CurBlendInTime;
  public float CurBlendOutTime;
  public float PlayRate;
  public float BasePlayScale;
  public float TransientScaleModifier;
  public float CurrentBlendWeight;
  public float RemainingTime;
  public UInterpTrackMove MoveTrack;
  public UInterpTrackInstMove MoveInst;
  public UAnimNodeSequence SourceAnimNode;
  public ECameraAnimPlaySpace PlaySpace;
  public FMatrix UserPlaySpaceMatrix = new();
  public APostProcessVolume.FPostProcessSettings LastPPSettings = new();
  public float LastPPSettingsAlpha;
}

public class UCameraConeComponent : UPrimitiveComponent
{
}

public class UCameraModifier : UObject
{
  public bool bDisabled;
  public bool bPendingDisable;
  public bool bExclusive;
  public bool bDebug;
  public ACamera CameraOwner;
  public byte Priority;
  public float AlphaInTime;
  public float AlphaOutTime;
  public float Alpha;
  public float TargetAlpha;
}

public class UCameraShake : UObject
{
  public class FROscillator
  {
    public UCameraShake.FFOscillator Pitch = new();
    public UCameraShake.FFOscillator Yaw = new();
    public UCameraShake.FFOscillator Roll = new();
  }

  public class FVOscillator
  {
    public UCameraShake.FFOscillator X = new();
    public UCameraShake.FFOscillator Y = new();
    public UCameraShake.FFOscillator Z = new();
  }

  public class FFOscillator
  {
    public float Amplitude;
    public float Frequency;
    public EInitialOscillatorOffset InitialOffset;
  }

  public bool bSingleInstance;
  public bool bRandomAnimSegment;
  public float OscillationDuration;
  public float OscillationBlendInTime;
  public float OscillationBlendOutTime;
  public FROscillator RotOscillation = new();
  public FVOscillator LocOscillation = new();
  public FFOscillator FOVOscillation = new();
  public UCameraAnim Anim;
  public float AnimPlayRate;
  public float AnimScale;
  public float AnimBlendInTime;
  public float AnimBlendOutTime;
  public float RandomAnimSegmentDuration;
}

public class UCameraModifier_CameraShake : UCameraModifier
{
  public class FCameraShakeInstance
  {
    public UCameraShake SourceShake;
    public float OscillatorTimeRemaining;
    public bool bBlendingIn;
    public float CurrentBlendInTime;
    public bool bBlendingOut;
    public float CurrentBlendOutTime;
    public UObject.FVector LocSinOffset = new();
    public UObject.FVector RotSinOffset = new();
    public float FOVSinOffset;
    public float Scale;
    public UCameraAnimInst AnimInst;
    public ECameraAnimPlaySpace PlaySpace;
    public UObject.FMatrix UserPlaySpaceMatrix = new();
  }

  public List<FCameraShakeInstance> ActiveShakes;
  public float SplitScreenShakeScale;
}

public class UFontImportOptions : UObject
{
  public class FFontImportOptionsData
  {
    public string FontName;
    public float Height;
    public bool bEnableAntialiasing;
    public bool bEnableBold;
    public bool bEnableItalic;
    public bool bEnableUnderline;
    public bool bAlphaOnly;
    public EFontImportCharacterSet CharacterSet;
    public string Chars;
    public string UnicodeRange;
    public string CharsFilePath;
    public string CharsFileWildcard;
    public bool bCreatePrintableOnly;
    public bool bIncludeASCIIRange;
    public UObject.FLinearColor ForegroundColor = new();
    public bool bEnableDropShadow;
    public int TexturePageWidth;
    public int TexturePageMaxHeight;
    public int XPadding;
    public int YPadding;
    public int ExtendBoxTop;
    public int ExtendBoxBottom;
    public int ExtendBoxRight;
    public int ExtendBoxLeft;
    public bool bEnableLegacyMode;
    public int Kerning;
    public bool bUseDistanceFieldAlpha;
    public int DistanceFieldScaleFactor;
    public float DistanceFieldScanRadiusScale;
  }

  public FFontImportOptionsData Data = new();
}

public partial class UFont : UObject
{
  public partial class FFontCharacter : ISerialisable
  {
    public int StartU;
    public int StartV;
    public int USize;
    public int VSize;
    public byte TextureIndex;
    public int VerticalOffset;
  }

  public List<FFontCharacter> Characters;
  public List<UTexture2D> Textures;
  public Dictionary<ushort, ushort> CharRemap;
  public int IsRemapped;
  public float EmScale;
  public float Ascent;
  public float Descent;
  public float Leading;
  public int Kerning;
  public UFontImportOptions.FFontImportOptionsData ImportOptions = new();
  public int NumCharacters;
  public List<int> MaxCharHeight;
  public float ScalingFactor;
}

public class USurface : UObject
{
}

public partial class UTexture : USurface
{
  public class FTextureGroupContainer
  {
    public bool TEXTUREGROUP_World;
    public bool TEXTUREGROUP_WorldNormalMap;
    public bool TEXTUREGROUP_WorldSpecular;
    public bool TEXTUREGROUP_Character;
    public bool TEXTUREGROUP_CharacterNormalMap;
    public bool TEXTUREGROUP_CharacterSpecular;
    public bool TEXTUREGROUP_Weapon;
    public bool TEXTUREGROUP_WeaponNormalMap;
    public bool TEXTUREGROUP_WeaponSpecular;
    public bool TEXTUREGROUP_Vehicle;
    public bool TEXTUREGROUP_VehicleNormalMap;
    public bool TEXTUREGROUP_VehicleSpecular;
    public bool TEXTUREGROUP_Cinematic;
    public bool TEXTUREGROUP_Effects;
    public bool TEXTUREGROUP_EffectsNotFiltered;
    public bool TEXTUREGROUP_Skybox;
    public bool TEXTUREGROUP_UI;
    public bool TEXTUREGROUP_Lightmap;
    public bool TEXTUREGROUP_RenderTarget;
    public bool TEXTUREGROUP_MobileFlattened;
    public bool TEXTUREGROUP_ProcBuilding_Face;
    public bool TEXTUREGROUP_ProcBuilding_LightMap;
    public bool TEXTUREGROUP_Shadowmap;
    public bool TEXTUREGROUP_ColorLookupTable;
  }

  public bool SRGB;
  public bool RGBE;
  public bool bIsSourceArtUncompressed;
  public bool CompressionNoAlpha;
  public bool CompressionNone;
  public bool CompressionNoMipmaps;
  public bool CompressionFullDynamicRange;
  public bool DeferCompression;
  public bool NeverStream;
  public bool bDitherMipMapAlpha;
  public bool bPreserveBorderR;
  public bool bPreserveBorderG;
  public bool bPreserveBorderB;
  public bool bPreserveBorderA;
  public bool bNoTiling;
  public bool bAsyncResourceReleaseHasBeenStarted;
  public bool bUseCinematicMipLevels;
  public float[] UnpackMin = new float[4];
  public float[] UnpackMax = new float[4];
  public FByteBulkData SourceArt = new();
  public TextureCompressionSettings CompressionSettings;
  public TextureFilter Filter;
  public TextureGroup LODGroup;
  public TextureMipGenSettings MipGenSettings;
  public int LODBias;
  public int CachedCombinedLODBias;
  public int NumCinematicMipLevels;
  public string SourceFilePath;
  public string SourceFileTimestamp;
  public FPointer Resource = new();
  public FGuid LightingGuid = new();
  public float AdjustBrightness;
  public float AdjustBrightnessCurve;
  public float AdjustVibrance;
  public float AdjustSaturation;
  public float AdjustRGBCurve;
  public float AdjustHue;
  public int InternalFormatLODBias;
}

public partial class UTexture2D : UTexture
{
  public partial class FTexture2DMipMap : ISerialisable
  {
    public UObject.FByteBulkData Data = new();
    public int SizeX;
    public int SizeY;
  }

  public class FTextureLinkedListMirror
  {
    public UObject.FPointer Element = new();
    public UObject.FPointer Next = new();
    public UObject.FPointer PrevLink = new();
  }

  public List<FTexture2DMipMap> Mips;
  public List<FTexture2DMipMap> CachedPVRTCMips;
  public int SizeX;
  public int SizeY;
  public int OriginalSizeX;
  public int OriginalSizeY;
  public EPixelFormat Format;
  public TextureAddress AddressX;
  public TextureAddress AddressY;
  public bool bIsStreamable;
  public bool bHasCancelationPending;
  public bool bHasBeenLoadedFromPersistentArchive;
  public bool bForceMiplevelsToBeResident;
  public bool bGlobalForceMipLevelsToBeResident;
  public bool bHasBeenPaintedInEditor;
  public float ForceMipLevelsToBeResidentTimestamp;
  public FName TextureFileCacheName;
  public FGuid TextureFileCacheGuid = new();
  public int RequestedMips;
  public int ResidentMips;
  public FThreadSafeCounter PendingMipChangeRequestStatus = new();
  public List<byte> SystemMemoryData;
  public FTextureLinkedListMirror StreamableTexturesLink = new();
  public int MipTailBaseIdx;
  public FPointer ResourceMem = new();
  public int FirstResourceMemMip;
  public float Timer;
}

public class UCanvas : UObject
{
  public class FCanvasIcon
  {
    public UTexture Texture;
    public float U;
    public float V;
    public float UL;
    public float VL;
  }

  public class FDepthFieldGlowInfo
  {
    public bool bEnableGlow;
    public UObject.FLinearColor GlowColor = new();
    public UObject.FVector2D GlowOuterRadius = new();
    public UObject.FVector2D GlowInnerRadius = new();
  }

  public class FFontRenderInfo
  {
    public bool bClipText;
    public bool bEnableShadow;
    public UCanvas.FDepthFieldGlowInfo GlowInfo = new();
  }

  public UFont Font;
  public float OrgX;
  public float OrgY;
  public float ClipX;
  public float ClipY;
  public float CurX;
  public float CurY;
  public float CurZ;
  public float CurYL;
  public FColor DrawColor = new();
  public bool bCenter;
  public bool bNoSmooth;
  public int SizeX;
  public int SizeY;
  public FPointer Canvas = new();
  public FPointer SceneView = new();
  public FPlane ColorModulate = new();
  public UTexture2D DefaultTexture;
}

public class UCeilingReachSpec : UReachSpec
{
}

public class ACheatManager : AActor
{
  public ADebugCameraController DebugCameraControllerRef;
  public UClass DebugCameraControllerClass;
  public string ViewingFrom;
  public string OwnCamera;
}

public class UClipPadEntry : UObject
{
  public string Title;
  public string Text;
}

public class UCodecMovie : UObject
{
  public float PlaybackDuration;
}

public class UCodecMovieFallback : UCodecMovie
{
  public float CurrentTime;
}

public class AColorScaleVolume : AVolume
{
  public FVector ColorScale = new();
  public float InterpTime;
}

public class AZoneInfo : AInfo
{
  public float KillZ;
  public float SoftKill;
  public UClass KillZDamageType;
  public bool bSoftKillZ;
}

public class UPhysicsLODVerticalEmitter : UObject
{
  public int ParticlePercentage;
}

public class UPhysicsLODVerticalDestructible : UObject
{
  public int MaxDynamicChunkCount;
  public float DebrisLifetime;
}

public class AWorldInfo : AZoneInfo
{
  public class FWorldFractureSettings
  {
    public float ChanceOfPhysicsChunkOverride;
    public bool bEnableChanceOfPhysicsChunkOverride;
    public bool bLimitExplosionChunkSize;
    public float MaxExplosionChunkSize;
    public bool bLimitDamageChunkSize;
    public float MaxDamageChunkSize;
    public int MaxNumFacturedChunksToSpawnInAFrame;
    public float FractureExplosionVelScale;
  }

  public class FScreenMessageString
  {
    public ulong Key = new();
    public string ScreenMessage;
    public UObject.FColor DisplayColor = new();
    public float TimeToDisplay;
    public float CurrentTimeDisplayed;
  }

  public class FLightmassWorldInfoSettings
  {
    public float StaticLightingLevelScale;
    public int NumIndirectLightingBounces;
    public UObject.FColor EnvironmentColor = new();
    public float EnvironmentIntensity;
    public float EmissiveBoost;
    public float DiffuseBoost;
    public float SpecularBoost;
    public float IndirectNormalInfluenceBoost;
    public bool bUseAmbientOcclusion;
    public float DirectIlluminationOcclusionFraction;
    public float IndirectIlluminationOcclusionFraction;
    public float OcclusionExponent;
    public float FullyOccludedSamplesFraction;
    public float MaxOcclusionDistance;
    public bool bVisualizeMaterialDiffuse;
    public bool bVisualizeAmbientOcclusion;
  }

  public class FNavMeshPathConstraintCacheDatum
  {
    public int ListIdx;
    public UNavMeshPathConstraint[] List = new UNavMeshPathConstraint[5];
  }

  public class FNavMeshPathGoalEvaluatorCacheDatum
  {
    public int ListIdx;
    public UNavMeshPathGoalEvaluator[] List = new UNavMeshPathGoalEvaluator[5];
  }

  public class FNetViewer
  {
    public APlayerController InViewer;
    public AActor Viewer;
    public UObject.FVector ViewLocation = new();
    public UObject.FVector ViewDir = new();
  }

  public class FCompartmentRunList
  {
    public bool RigidBody;
    public bool Fluid;
    public bool Cloth;
    public bool SoftBody;
  }

  public class FPhysXSimulationProperties
  {
    public bool bUseHardware;
    public bool bFixedTimeStep;
    public float TimeStep;
    public int MaxSubSteps;
  }

  public class FPhysXSceneProperties
  {
    public AWorldInfo.FPhysXSimulationProperties PrimaryScene = new();
    public AWorldInfo.FPhysXSimulationProperties CompartmentRigidBody = new();
    public AWorldInfo.FPhysXSimulationProperties CompartmentFluid = new();
    public AWorldInfo.FPhysXSimulationProperties CompartmentCloth = new();
    public AWorldInfo.FPhysXSimulationProperties CompartmentSoftBody = new();
  }

  public class FApexModuleDestructibleSettings
  {
    public int MaxChunkIslandCount;
    public int MaxRrbActorCount;
    public float MaxChunkSeparationLOD;
  }

  public class FPhysXEmitterVerticalProperties
  {
    public bool bDisableLod;
    public int ParticlesLodMin;
    public int ParticlesLodMax;
    public int PacketsPerPhysXParticleSystemMax;
    public bool bApplyCylindricalPacketCulling;
    public float SpawnLodVsFifoBias;
  }

  public class FPhysXVerticalProperties
  {
    public AWorldInfo.FPhysXEmitterVerticalProperties Emitters = new();
  }

  public APostProcessVolume.FPostProcessSettings DefaultPostProcessSettings = new();
  public bool bUseForcePostProcessSettings;
  public bool bPersistPostProcessToNextLevel;
  public bool bMapNeedsLightingFullyRebuilt;
  public bool bMapHasDLEsOutsideOfImportanceVolume;
  public bool bMapHasMultipleDominantLightsAffectingOnePrimitive;
  public bool bMapHasPathingErrors;
  public bool bRequestedBlockOnAsyncLoading;
  public bool bBegunPlay;
  public bool bPlayersOnly;
  public bool bPlayersOnlyPending;
  public bool bPauseKismet;
  public bool bPauseForHostMigrationMessage;
  public bool bIgnoreCullDistanceVolume;
  public bool bDropDetail;
  public bool bAggressiveLOD;
  public bool bStartup;
  public bool bPathsRebuilt;
  public bool bHasPathNodes;
  public bool bIsMenuLevel;
  public bool bUseConsoleInput;
  public bool bNoDefaultInventoryForPlayer;
  public bool bIgnoreMusicTrackReplication;
  public bool bNoPathWarnings;
  public bool bHighPriorityLoading;
  public bool bHighPriorityLoadingLocal;
  public bool bUseProcBuildingRulesetOverride;
  public bool bBuiltOnDedicatedServer;
  public bool bSupportDoubleBufferedPhysics;
  public bool bEnableChanceOfPhysicsChunkOverride;
  public bool bLimitExplosionChunkSize;
  public bool bLimitDamageChunkSize;
  public bool bAllowLightEnvSphericalHarmonicLights;
  public bool bAllowModulateBetterShadows;
  public bool bIncreaseFogNearPrecision;
  public bool bUseGlobalIllumination;
  public bool bForceNoPrecomputedLighting;
  public bool bHaveActiveCrowd;
  public APostProcessVolume.FPostProcessSettings ForcePostProcessSettings = new();
  public float SquintModeKernelSize;
  public APostProcessVolume HighestPriorityPostProcessVolume;
  public AReverbVolume.FReverbSettings DefaultReverbSettings = new();
  public AReverbVolume.FInteriorSettings DefaultAmbientZoneSettings = new();
  public AReverbVolume HighestPriorityReverbVolume;
  public List<APortalVolume> PortalVolumes;
  public List<AEnvironmentVolume> EnvironmentVolumes;
  public List<ULevelStreaming> StreamingLevels;
  public double LastTimeUnbuiltLightingWasEncountered = new();
  public UBookMark[] BookMarks = new UBookMark[10];
  public UKismetBookMark[] KismetBookMarks = new UKismetBookMark[10];
  public List<UClipPadEntry> ClipPadEntries;
  public float TimeDilation;
  public float DemoPlayTimeDilation;
  public float TimeSeconds;
  public float RealTimeSeconds;
  public float AudioTimeSeconds;
  public float DeltaSeconds;
  public float PauseDelay;
  public float RealTimeToUnPause;
  public int ServerTime;
  public APlayerReplicationInfo Pauser;
  public string VisibleGroups;
  public string SelectedGroups;
  public UTexture2D DefaultTexture;
  public UTexture2D WireframeTexture;
  public UTexture2D WhiteSquareTexture;
  public UTexture2D LargeVertex;
  public UTexture2D BSPVertex;
  public UTexture2D BackgroundTexture;
  public int BackgroundImageSizeX;
  public int BackgroundImageSizeY;
  public List<string> DeferredExecs;
  public AGameReplicationInfo GRI;
  public ENetMode NetMode;
  public ETravelType NextTravelType;
  public ENetMode HostNetMode;
  public string ComputerName;
  public string EngineVersion;
  public string MinNetVersion;
  public AGameInfo Game;
  public float StallZ;
  public float WorldGravityZ;
  public float DefaultGravityZ;
  public float GlobalGravityZ;
  public float RBPhysicsGravityScaling;
  public ANavigationPoint NavigationPointList;
  public AController ControllerList;
  public APawn PawnList;
  public ACoverLink CoverList;
  public APylon PylonList;
  public AProjectile ProjectileList;
  public float MoveRepSize;
  public List<FNetViewer> ReplicationViewers;
  public string NextURL;
  public float NextSwitchCountdown;
  public int PackedLightAndShadowMapTextureSize;
  public FVector DefaultColorScale = new();
  public List<UClass> GameTypesSupportedOnThisMap;
  public UClass GameTypeForPIE;
  public List<UObject> ClientDestroyedActorContent;
  public List<FName> PreparingLevelNames;
  public FName CommittedPersistentLevelName;
  public UObjectReferencer PersistentMapForcedObjects;
  public UAudioComponent MusicComp;
  public UMusicTrackDataStructures.FMusicTrackStruct CurrentMusicTrack = new();
  public UMusicTrackDataStructures.FMusicTrackStruct ReplicatedMusicTrack = new();
  public string Title;
  public string Author;
  public UMapInfo MyMapInfo;
  public string EmitterPoolClassPath;
  public AEmitterPool MyEmitterPool;
  public string DecalManagerClassPath;
  public ADecalManager MyDecalManager;
  public string FractureManagerClassPath;
  public AFractureManager MyFractureManager;
  public string ParticleEventManagerClassPath;
  public AParticleEventManager MyParticleEventManager;
  public UProcBuildingRuleset ProcBuildingRulesetOverride;
  public float MaxPhysicsDeltaTime;
  public int MaxPhysicsSubsteps;
  public FPhysXSceneProperties PhysicsProperties = new();
  public List<FCompartmentRunList> CompartmentRunFrames;
  public float DefaultSkinWidth;
  public float ApexLODResourceBudget;
  public FApexModuleDestructibleSettings DestructibleSettings = new();
  public UPhysicsLODVerticalEmitter EmitterVertical;
  public UPhysicsLODVerticalDestructible DestructibleVertical;
  public FPhysXVerticalProperties VerticalProperties = new();
  public float ChanceOfPhysicsChunkOverride;
  public float MaxExplosionChunkSize;
  public float MaxDamageChunkSize;
  public float FractureExplosionVelScale;
  public int MaxNumFacturedChunksToSpawnInAFrame;
  public int NumFacturedChunksSpawnedThisFrame;
  public float FracturedMeshWeaponDamage;
  public float CharacterLitIndirectBrightness;
  public float CharacterLitIndirectContrastFactor;
  public float CharacterShadowedIndirectBrightness;
  public float CharacterShadowedIndirectContrastFactor;
  public float CharacterLightingContrastFactor;
  public FMap_Mirror ScreenMessages = new();
  public List<FScreenMessageString> PriorityScreenMessages;
  public List<APlayerReplicationInfo> MCPendingPRIs;
  public int MaxTrianglesPerLeaf;
  public ULightmassLevelSettings LMLevelSettings;
  public FLightmassWorldInfoSettings LightmassSettings = new();
  public Dictionary<byte, byte> NavMeshPathConstraintCache;
  public Dictionary<byte, byte> NavMeshPathGoalEvaluatorCache;
  public ACrowdPopulationManagerBase PopulationManager;
  public List<USeqAct_Latent> CrowdSpawnerActions;
  public List<FName> GoreSuppress;
}

public partial class UUIRoot : UObject
{
  public partial class FWIDGET_ID : FGuid
  {
  }

  public partial class FSTYLE_ID : FGuid
  {
  }

  public class FUIRangeData
  {
    public float CurrentValue;
    public float MinValue;
    public float MaxValue;
    public float NudgeValue;
    public bool bIntRange;
  }

  public class FTextureCoordinates
  {
    public float U;
    public float V;
    public float UL;
    public float VL;
  }

  public class FUIProviderScriptFieldValue
  {
    public FName PropertyTag;
    public EUIDataProviderFieldType PropertyType;
    public string StringValue;
    public USurface ImageValue;
    public List<int> ArrayValue;
    public UUIRoot.FUIRangeData RangeValue = new();
    public UOnlineSubsystem.FUniqueNetId NetIdValue = new();
    public UUIRoot.FTextureCoordinates AtlasCoordinates = new();
  }

  public class FUIProviderFieldValue : FUIProviderScriptFieldValue
  {
    public UObject.FPointer CustomStringNode = new();
  }

  public class FUIStyleReference
  {
    public FName DefaultStyleTag;
    public UClass RequiredStyleClass;
    public UUIRoot.FSTYLE_ID AssignedStyleID = new();
    public UUIStyle ResolvedStyle;
  }

  public class FUIScreenValue
  {
    public float Value;
    public EPositionEvalType ScaleType;
    public EUIOrientation Orientation;
  }

  public class FUIScreenValue_Extent
  {
    public float Value;
    public EUIExtentEvalType ScaleType;
    public EUIOrientation Orientation;
  }

  public class FUIScreenValue_Position
  {
    public float[] Value = new float[2];
    public EPositionEvalType[] ScaleType = new EPositionEvalType[2];
  }

  public class FUIScreenValue_Bounds
  {
    public float[] Value = new float[4];
    public EPositionEvalType[] ScaleType = new EPositionEvalType[4];
    public byte[] bInvalidated = new byte[4];
    public EUIAspectRatioConstraint AspectRatioMode;
  }

  public class FUIAnchorPosition : FUIScreenValue_Position
  {
    public float ZDepth;
  }

  public class FScreenPositionRange : FUIScreenValue_Position
  {
  }

  public class FUIScreenValue_DockPadding
  {
    public float[] PaddingValue = new float[4];
    public EUIDockPaddingEvalType[] PaddingScaleType = new EUIDockPaddingEvalType[4];
  }

  public class FUIScreenValue_AutoSizeRegion
  {
    public float[] Value = new float[2];
    public EUIExtentEvalType[] EvalType = new EUIExtentEvalType[2];
  }

  public class FAutoSizePadding : FUIScreenValue_AutoSizeRegion
  {
  }

  public class FAutoSizeData
  {
    public UUIRoot.FUIScreenValue_AutoSizeRegion Extent = new();
    public UUIRoot.FAutoSizePadding Padding = new();
    public bool bAutoSizeEnabled;
  }

  public class FUIRenderingSubregion
  {
    public UUIRoot.FUIScreenValue_Extent ClampRegionSize = new();
    public UUIRoot.FUIScreenValue_Extent ClampRegionOffset = new();
    public EUIAlignment ClampRegionAlignment;
    public bool bSubregionEnabled;
  }

  public class FInputEventSubscription
  {
    public FName KeyName;
    public List<UUIScreenObject> Subscribers;
  }

  public class FDefaultEventSpecification
  {
    public UUIEvent EventTemplate;
    public UClass EventState;
  }

  public class FInputKeyAction
  {
    public FName InputKeyName;
    public EInputEvent InputKeyState;
    public List<USequenceOp.FSeqOpOutputInputLink> TriggeredOps;
    public List<USequenceOp> ActionsToExecute;
  }

  public class FStateInputKeyAction : FInputKeyAction
  {
    public UClass Scope;
  }

  public class FPlayerInteractionData
  {
    public UUIObject FocusedControl;
    public UUIObject LastFocusedControl;
  }

  public class FUIFocusPropagationData
  {
    public UUIObject FirstFocusTarget;
    public UUIObject LastFocusTarget;
    public UUIObject NextFocusTarget;
    public UUIObject PrevFocusTarget;
    public bool bPendingReceiveFocus;
  }

  public class FUINavigationData
  {
    public UUIObject[] NavigationTarget = new UUIObject[4];
    public UUIObject[] ForcedNavigationTarget = new UUIObject[4];
    public byte[] bNullOverride = new byte[4];
  }

  public class FUIDockingSet
  {
    public UUIObject OwnerWidget;
    public UUIObject[] TargetWidget = new UUIObject[4];
    public UUIRoot.FUIScreenValue_DockPadding DockPadding = new();
    public bool bLockWidthWhenDocked;
    public bool bLockHeightWhenDocked;
    public EUIWidgetFace[] TargetFace = new EUIWidgetFace[4];
    public byte[] bResolved = new byte[4];
    public byte[] bLinking = new byte[4];
  }

  public class FUIDockingNode
  {
    public UUIObject Widget;
    public EUIWidgetFace Face;
  }

  public class FUIRotation
  {
    public UObject.FRotator Rotation = new();
    public UObject.FMatrix TransformMatrix = new();
    public UUIRoot.FUIAnchorPosition AnchorPosition = new();
    public ERotationAnchor AnchorType;
  }

  public class FUIDataStoreBinding
  {
    public FScriptInterface Subscriber;
    public EUIDataProviderFieldType RequiredFieldType;
    public string MarkupString;
    public int BindingIndex;
    public FName DataStoreName;
    public FName DataStoreField;
    public UUIDataStore ResolvedDataStore;
  }

  public class FUIStyleSubscriberReference
  {
    public FName SubscriberId;
    public FScriptInterface Subscriber;
  }

  public class FStyleReferenceId
  {
    public FName StyleReferenceTag;
    public UProperty StyleProperty;
  }

  public class FUITextAttributes
  {
    public bool Bold;
    public bool Italic;
    public bool Underline;
    public bool Shadow;
    public bool Strikethrough;
  }

  public class FUIImageAdjustmentData
  {
    public UUIRoot.FUIScreenValue_Extent[] ProtectedRegion = new UUIRoot.FUIScreenValue_Extent[2];
    public EMaterialAdjustmentType AdjustmentType;
    public EUIAlignment Alignment;
  }

  public class FUIStringCaretParameters
  {
    public bool bDisplayCaret;
    public EUIDefaultPenColor CaretType;
    public float CaretWidth;
    public FName CaretStyle;
    public int CaretPosition;
    public UMaterialInterface CaretMaterial;
  }

  public class FRenderParameters
  {
    public float DrawX;
    public float DrawY;
    public float DrawZ;
    public float DrawXL;
    public float DrawYL;
    public UObject.FVector2D Scaling = new();
    public UFont DrawFont;
    public EUIAlignment[] TextAlignment = new EUIAlignment[2];
    public UObject.FVector2D ImageExtent = new();
    public UUIRoot.FTextureCoordinates DrawCoords = new();
    public UObject.FVector2D SpacingAdjust = new();
    public float ViewportHeight;
    public bool bUseOverrideColor;
    public UObject.FLinearColor OverideDrawColor = new();
  }

  public class FTextAutoScaleValue
  {
    public float MinScale;
    public ETextAutoScaleMode AutoScaleMode;
  }

  public class FUIStyleOverride
  {
    public UObject.FLinearColor DrawColor = new();
    public float Opacity;
    public float[] Padding = new float[2];
    public bool bOverrideDrawColor;
    public bool bOverrideOpacity;
    public bool bOverridePadding;
  }

  public class FUITextStyleOverride : FUIStyleOverride
  {
    public UFont DrawFont;
    public UUIRoot.FUITextAttributes TextAttributes = new();
    public EUIAlignment[] TextAlignment = new EUIAlignment[2];
    public ETextClipMode ClipMode;
    public EUIAlignment ClipAlignment;
    public UUIRoot.FTextAutoScaleValue AutoScaling = new();
    public float[] DrawScale = new float[2];
    public float[] SpacingAdjust = new float[2];
    public bool bOverrideDrawFont;
    public bool bOverrideAttributes;
    public bool bOverrideAlignment;
    public bool bOverrideClipMode;
    public bool bOverrideClipAlignment;
    public bool bOverrideAutoScale;
    public bool bOverrideScale;
    public bool bOverrideSpacingAdjust;
  }

  public class FUIImageStyleOverride : FUIStyleOverride
  {
    public UUIRoot.FTextureCoordinates Coordinates = new();
    public UUIRoot.FUIImageAdjustmentData[] Formatting = new UUIRoot.FUIImageAdjustmentData[2];
    public bool bOverrideCoordinates;
    public bool bOverrideFormatting;
  }

  public class FUICombinedStyleData
  {
    public UObject.FLinearColor TextColor = new();
    public UObject.FLinearColor ImageColor = new();
    public float[] TextPadding = new float[2];
    public float[] ImagePadding = new float[2];
    public UFont DrawFont;
    public USurface FallbackImage;
    public UUIRoot.FTextureCoordinates AtlasCoords = new();
    public UUIRoot.FUITextAttributes TextAttributes = new();
    public EUIAlignment[] TextAlignment = new EUIAlignment[2];
    public ETextClipMode TextClipMode;
    public EUIAlignment TextClipAlignment;
    public UUIRoot.FUIImageAdjustmentData[] AdjustmentType = new UUIRoot.FUIImageAdjustmentData[2];
    public UUIRoot.FTextAutoScaleValue TextAutoScaling = new();
    public UObject.FVector2D TextScale = new();
    public UObject.FVector2D TextSpacingAdjust = new();
    public bool bInitialized;
  }

  public class FUIStringNodeModifier
  {
    public class FModifierData
    {
      public UUIStyle_Data Style;
      public List<UFont> InlineFontStack;
    }

    public UUIRoot.FUICombinedStyleData CustomStyleData = new();
    public UUIRoot.FUICombinedStyleData BaseStyleData = new();
    public List<FModifierData> ModifierStack;
    public UUIState CurrentMenuState;
  }

  public class FUIStringNode
  {
    public UObject.FPointer VfTable = new();
    public UUIDataStore NodeDataStore;
    public UObject.FPointer ParentNode = new();
    public string SourceText;
    public UObject.FVector2D Extent = new();
    public UObject.FVector2D Scaling = new();
    public bool bForceWrap;
  }

  public class FUIStringNode_Text : FUIStringNode
  {
    public string RenderedText;
    public UUIRoot.FUICombinedStyleData NodeStyleParameters = new();
  }

  public class FUIStringNode_Image : FUIStringNode
  {
    public UObject.FVector2D ForcedExtent = new();
    public UUIRoot.FTextureCoordinates TexCoords = new();
    public UUITexture RenderedImage;
  }

  public class FUIStringNode_NestedMarkupParent : FUIStringNode
  {
  }

  public class FUIStringNode_FormattedNodeParent : FUIStringNode_Text
  {
  }

  public class FWrappedStringElement
  {
    public string Value;
    public UObject.FVector2D LineExtent = new();
  }

  public class FUIMouseCursor
  {
    public FName CursorStyle;
    public UUITexture Cursor;
  }

  public class FInputEventParameters
  {
    public int PlayerIndex;
    public int ControllerId;
    public FName InputKeyName;
    public EInputEvent EventType;
    public float InputDelta;
    public float DeltaTime;
    public bool bAltPressed;
    public bool bCtrlPressed;
    public bool bShiftPressed;
  }

  public class FSubscribedInputEventParameters : FInputEventParameters
  {
    public FName InputAliasName;
  }

  public class FUIAxisEmulationDefinition
  {
    public FName AxisInputKey;
    public FName AdjacentAxisInputKey;
    public bool bEmulateButtonPress;
    public FName[] InputKeyToEmulate = new FName[2];
  }

  public class FRawInputKeyEventData
  {
    public FName InputKeyName;
    public byte ModifierKeyFlags;
  }

  public class FUIInputActionAlias
  {
    public FName InputAliasName;
    public List<UUIRoot.FRawInputKeyEventData> LinkedInputKeys;
  }

  public class FUIInputAliasValue
  {
    public byte ModifierFlagMask;
    public FName InputAliasName;
  }

  public class FUIInputAliasMap
  {
    public UObject.FMultiMap_Mirror InputAliasLookupTable = new();
  }

  public class FUIInputAliasStateMap
  {
    public string StateClassName;
    public UClass State;
    public List<UUIRoot.FUIInputActionAlias> StateInputAliases;
  }

  public class FUIInputAliasClassMap
  {
    public string WidgetClassName;
    public UClass WidgetClass;
    public List<UUIRoot.FUIInputAliasStateMap> WidgetStates;
    public Dictionary<byte, byte> StateLookupTable;
    public Dictionary<byte, byte> StateReverseLookupTable;
  }

}

public class UInteraction : UUIRoot
{
  public FScriptDelegate __OnReceivedNativeInputKey__Delegate;
  public FScriptDelegate __OnReceivedNativeInputAxis__Delegate;
  public FScriptDelegate __OnReceivedNativeInputChar__Delegate;
  public FScriptDelegate __OnInitialize__Delegate;
}

public class UConsole : UInteraction
{
  public class FAutoCompleteCommand
  {
    public string Command;
    public string Desc;
  }

  public class FAutoCompleteNode
  {
    public int IndexChar;
    public List<int> AutoCompleteListIndices;
    public List<UObject.FPointer> ChildNodes;
  }

  public ULocalPlayer ConsoleTargetPlayer;
  public UUIScene LargeConsoleScene;
  public UUIScene MiniConsoleScene;
  public UUILabel ConsoleBufferText;
  public UConsoleEntry MiniConsoleInput;
  public UConsoleEntry LargeConsoleInput;
  public UTexture2D DefaultTexture_Black;
  public UTexture2D DefaultTexture_White;
  public FName ConsoleKey;
  public FName TypeKey;
  public int MaxScrollbackSize;
  public List<string> Scrollback;
  public int SBHead;
  public int SBPos;
  public int HistoryTop;
  public int HistoryBot;
  public int HistoryCur;
  public string[] History = new string[16];
  public bool bNavigatingHistory;
  public bool bCaptureKeyInput;
  public bool bCtrl;
  public bool bEnableUI;
  public bool bAutoCompleteLocked;
  public bool bRequireCtrlToNavigateAutoComplete;
  public bool bIsRuntimeAutoCompleteUpToDate;
  public string TypedStr;
  public int TypedStrPos;
  public List<FAutoCompleteCommand> ManualAutoCompleteList;
  public List<FAutoCompleteCommand> AutoCompleteList;
  public int AutoCompleteIndex;
  public FAutoCompleteNode AutoCompleteTree = new();
  public List<int> AutoCompleteIndices;
}

public class UUIAnimation : UUIRoot
{
  public class FUIAnimationNotify
  {
    public EUIAnimNotifyType NotifyType;
    public FName NotifyName;
  }

  public class FUIAnimationRawData
  {
    public float DestAsFloat;
    public UObject.FLinearColor DestAsColor = new();
    public UObject.FRotator DestAsRotator = new();
    public UObject.FVector DestAsVector = new();
    public UUIAnimation.FUIAnimationNotify DestAsNotify = new();
  }

  public class FUIAnimationKeyFrame
  {
    public float RemainingTime;
    public EUIAnimationInterpMode InterpMode;
    public float InterpExponent;
    public UUIAnimation.FUIAnimationRawData Data = new();
  }

  public class FUIAnimTrack
  {
    public EUIAnimType TrackType;
    public List<UUIAnimation.FUIAnimationKeyFrame> KeyFrames;
    public List<UUIAnimation.FUIAnimationKeyFrame> LoopFrames;
  }

  public class FUIAnimSequence
  {
    public UUIAnimationSeq SequenceRef;
    public List<UUIAnimation.FUIAnimTrack> AnimationTracks;
    public EUIAnimationLoopMode LoopMode;
    public float PlaybackRate;
  }

}

public class UUIScreenObject : UUIRoot
{
  public FUIScreenValue_Bounds Position = new();
  public float ZDepth;
  public bool bHidden;
  public bool bInitialized;
  public bool bNeverFocus;
  public bool bSupportsFocusHint;
  public bool bOverrideInputOrder;
  public bool bAnimating;
  public bool bAnimationPaused;
  public bool bSupports3DPrimitives;
  public List<UUIObject> Children;
  public List<UClass> DefaultStates;
  public UClass InitialState;
  public List<UUIState> InactiveStates;
  public List<UUIState> StateStack;
  public List<FPlayerInteractionData> FocusControls;
  public List<FUIFocusPropagationData> FocusPropagation;
  public List<UUIAnimation.FUIAnimSequence> AnimStack;
  public int AnimationCount;
  public float AnimationDebugMultiplier;
  public float Opacity;
  public UUIComp_Event EventProvider;
  public FName FocusedCue;
  public FName MouseEnterCue;
  public FName NavigateUpCue;
  public FName NavigateDownCue;
  public FName NavigateLeftCue;
  public FName NavigateRightCue;
  public List<FScriptDelegate> KeyFrameCompletedDelegates;
  public List<FScriptDelegate> TrackCompletedDelegates;
  public FScriptDelegate __NotifyActiveSkinChanged__Delegate;
  public FScriptDelegate __OnRawInputKey__Delegate;
  public FScriptDelegate __OnRawInputAxis__Delegate;
  public FScriptDelegate __OnProcessInputKey__Delegate;
  public FScriptDelegate __OnProcessInputAxis__Delegate;
  public FScriptDelegate __NotifyPositionChanged__Delegate;
  public FScriptDelegate __NotifyResolutionChanged__Delegate;
  public FScriptDelegate __NotifyActiveStateChanged__Delegate;
  public FScriptDelegate __NotifyVisibilityChanged__Delegate;
  public FScriptDelegate __OnInitialSceneUpdate__Delegate;
  public FScriptDelegate __OnUIAnim_KeyFrameCompleted__Delegate;
  public FScriptDelegate __OnUIAnim_TrackCompleted__Delegate;
}

public class UUIComponent : UComponent
{
}

public class UUIComp_Event : UUIComponent
{
  public List<UUIRoot.FDefaultEventSpecification> DefaultEvents;
  public UUISequence EventContainer;
  public UUIEvent_ProcessInput InputProcessor;
  public List<FName> DisabledEventAliases;
}

public class UUIObject : UUIScreenObject
{
  public FWIDGET_ID WidgetID = new();
  public FName WidgetTag;
  public UUIObject Owner;
  public UUIScene OwnerScene;
  public FUIStyleReference PrimaryStyle = new();
  public byte PlayerInputMask;
  public EUIPostProcessGroup MaskPostProcess;
  public FUINavigationData NavigationTargets = new();
  public int TabIndex;
  public FUIDockingSet DockTargets = new();
  public float[] RenderBounds = new float[4];
  public FVector2D[] RenderBoundsVertices = new FVector2D[4];
  public FUIRotation Rotation = new();
  public FVector RenderOffset = new();
  public int PrivateFlags;
  public FUIDataStoreBinding ToolTip = new();
  public FUIDataStoreBinding ContextMenuData = new();
  public UUIObject AnimationParent;
  public List<FScriptInterface> StyleSubscribers;
  public bool bEnableActiveCursorUpdates;
  public bool bSupportsPrimaryStyle;
  public bool bEnableSceneUpdateNotifications;
  public bool bDebugShowBounds;
  public FColor DebugBoundsColor = new();
  public FScriptDelegate __OnCreate__Delegate;
  public FScriptDelegate __OnPreSceneUpdate__Delegate;
  public FScriptDelegate __OnPostSceneUpdate__Delegate;
  public FScriptDelegate __OnValueChanged__Delegate;
  public FScriptDelegate __OnRefreshSubscriberValue__Delegate;
  public FScriptDelegate __OnPressed__Delegate;
  public FScriptDelegate __OnPressRepeat__Delegate;
  public FScriptDelegate __OnPressRelease__Delegate;
  public FScriptDelegate __OnClicked__Delegate;
  public FScriptDelegate __OnDoubleClick__Delegate;
  public FScriptDelegate __OnOpenContextMenu__Delegate;
  public FScriptDelegate __OnCloseContextMenu__Delegate;
  public FScriptDelegate __OnContextMenuItemSelected__Delegate;
}

public class USequenceEvent : USequenceOp
{
  public List<USequenceEvent> DuplicateEvts;
  public AActor Originator;
  public AActor Instigator;
  public float ActivationTime;
  public int TriggerCount;
  public int MaxTriggerCount;
  public float ReTriggerDelay;
  public bool bEnabled;
  public bool bPlayerOnly;
  public bool bRegistered;
  public bool bClientSideOnly;
  public byte Priority;
  public int MaxWidth;
}

public class UUIEvent : USequenceEvent
{
  public int SubobjectVersionModifier;
  public UUIScreenObject EventOwner;
  public UObject EventActivator;
  public string Description;
  public bool bShouldRegisterEvent;
  public bool bPropagateEvent;
  public FScriptDelegate __AllowEventActivation__Delegate;
}

public class UUIEvent_Initialized : UUIEvent
{
}

public class UUIComp_DrawComponents : UUIComponent
{
  public EFadeType FadeType;
  public float FadeAlpha;
  public float FadeTarget;
  public float FadeTime;
  public float LastRenderTime;
  public float FadeRate;
  public FScriptDelegate __OnFadeComplete__Delegate;
}

public class UUIComp_DrawString : UUIComp_DrawComponents
{
  public FPointer VfTable_IUIStyleResolver = new();
  public FScriptInterface SubscriberOwner;
  public FName StyleResolverTag;
  public UUIString ValueString;
  public UClass StringClass;
  public bool bDropShadow;
  public bool bIgnoreMarkup;
  public bool bAllowBoundsAdjustment;
  public bool bRefreshString;
  public bool bReapplyFormatting;
  public FVector2D DropShadowOffset = new();
  public FLinearColor DropShadowColor = new();
  public UUIRoot.FAutoSizeData[] AutoSizeParameters = new UUIRoot.FAutoSizeData[2];
  public UUIRoot.FUIRenderingSubregion[] ClampRegion = new UUIRoot.FUIRenderingSubregion[2];
  public UUIRoot.FUITextStyleOverride TextStyleCustomization = new();
  public UUIRoot.FUIStyleReference StringStyle = new();
}

public class UUILabel : UUIObject
{
  public FPointer VfTable_IUIDataStoreSubscriber = new();
  public FPointer VfTable_IUIStringRenderer = new();
  public FUIDataStoreBinding DataSource = new();
  public UUIComp_DrawString StringRenderComponent;
  public UUIComp_DrawImage LabelBackground;
}

public class UUIComp_DrawImage : UUIComp_DrawComponents
{
  public FPointer VfTable_IUIStyleResolver = new();
  public FPointer VfTable_ICustomPropertyItemHandler = new();
  public FName StyleResolverTag;
  public UUITexture ImageRef;
  public UUIRoot.FUIImageStyleOverride StyleCustomization = new();
  public UUIRoot.FUIStyleReference ImageStyle = new();
}

public class UUIImage : UUIObject
{
  public FPointer VfTable_IUIDataStorePublisher = new();
  public FUIDataStoreBinding ImageDataSource = new();
  public UUIComp_DrawImage ImageComponent;
}

public class UUIComp_DrawStringEditbox : UUIComp_DrawString
{
  public class FUIStringSelectionRegion
  {
    public int SelectionStartCharIndex;
    public int SelectionEndCharIndex;
  }

  public string UserText;
  public UUIRoot.FUIStringCaretParameters StringCaret = new();
  public FUIStringSelectionRegion SelectionRegion = new();
  public FLinearColor SelectionTextColor = new();
  public FLinearColor SelectionBackgroundColor = new();
  public FPointer CaretNode = new();
  public int FirstCharacterPosition;
  public bool bRecalculateFirstCharacter;
  public float CaretOffset;
}

public class UUIEditBox : UUIObject
{
  public FPointer VfTable_IUIDataStorePublisher = new();
  public FUIDataStoreBinding DataSource = new();
  public UUIComp_DrawStringEditbox StringRenderComponent;
  public UUIComp_DrawImage BackgroundImageComponent;
  public string InitialValue;
  public bool bReadOnly;
  public bool bPasswordMode;
  public int MaxCharacters;
  public EEditBoxCharacterSet CharacterSet;
  public FScriptDelegate __OnSubmitText__Delegate;
}

public class UConsoleEntry : UUIObject
{
  public UUILabel ConsolePromptLabel;
  public UUIImage ConsolePromptBackground;
  public UUIEditBox InputBox;
  public UUIImage LowerConsoleBorder;
  public UUIImage UpperConsoleBorder;
  public int CursorPosition;
  public bool bRenderCursor;
}

public class ACoverGroup : AInfo
{
  public List<FActorReference> CoverLinkRefs;
  public float AutoSelectRadius;
  public float AutoSelectHeight;
}

public class UCoverGroupRenderingComponent : UPrimitiveComponent
{
}

public partial class ACoverLink : ANavigationPoint
{
  public class FFireLinkItem
  {
    public ECoverType SrcType;
    public ECoverAction SrcAction;
    public ECoverType DestType;
    public ECoverAction DestAction;
  }

  public class FFireLink
  {
    public List<byte> Interactions;
    public int PackedProperties_CoverPairRefAndDynamicInfo;
    public bool bFallbackLink;
    public bool bDynamicIndexInited;
  }

  public class FDynamicLinkInfo
  {
    public UObject.FVector LastTargetLocation = new();
    public UObject.FVector LastSrcLocation = new();
  }

  public class FExposedLink
  {
    public ACoverLink.FCoverReference TargetActor = new();
    public byte ExposedScale;
  }

  public class FSlotMoveRef
  {
    public APylon.FPolyReference Poly = new();
    public AActor.FBasedPosition Dest = new();
    public int Direction;
  }

  public partial class FCoverSlot : ISerialisable
  {
    public APawn SlotOwner;
    public float SlotValidAfterTime;
    public ECoverType ForceCoverType;
    public ECoverType CoverType;
    public ECoverLocationDescription LocationDescription;
    public UObject.FVector LocationOffset = new();
    public UObject.FRotator RotationOffset = new();
    public List<ECoverAction> Actions;
    public List<ACoverLink.FFireLink> FireLinks;
    public List<ACoverLink.FFireLink> RejectedFireLinks;
    public List<int> ExposedCoverPackedProperties;
    public int TurnTargetPackedProperties;
    public List<ACoverLink.FSlotMoveRef> SlipRefs;
    public List<ACoverLink.FCoverInfo> OverlapClaimsList;
    public bool bLeanLeft;
    public bool bLeanRight;
    public bool bForceCanPopUp;
    public bool bCanPopUp;
    public bool bCanMantle;
    public bool bCanClimbUp;
    public bool bForceCanCoverSlip_Left;
    public bool bForceCanCoverSlip_Right;
    public bool bCanCoverSlip_Left;
    public bool bCanCoverSlip_Right;
    public bool bCanSwatTurn_Left;
    public bool bCanSwatTurn_Right;
    public bool bEnabled;
    public bool bAllowPopup;
    public bool bAllowMantle;
    public bool bAllowCoverSlip;
    public bool bAllowClimbUp;
    public bool bAllowSwatTurn;
    public bool bForceNoGroundAdjust;
    public bool bPlayerOnly;
    public bool bPreferLeanOverPopup;
    public bool bDestructible;
    public bool bSelected;
    public bool bFailedToFindSurface;
  }

  public partial class FCoverReference : FActorReference
  {
    public int SlotIdx;
  }

  public class FCoverInfo
  {
    public ACoverLink Link;
    public int SlotIdx;
  }

  public class FCovPosInfo
  {
    public ACoverLink Link;
    public int LtSlotIdx;
    public int RtSlotIdx;
    public float LtToRtPct;
    public UObject.FVector Location = new();
    public UObject.FVector Normal = new();
    public UObject.FVector Tangent = new();
  }

  public bool GLOBAL_bUseSlotMarkers;
  public bool bDisabled;
  public bool bClaimAllSlots;
  public bool bAutoSort;
  public bool bAutoAdjust;
  public bool bCircular;
  public bool bLooped;
  public bool bPlayerOnly;
  public bool bDynamicCover;
  public bool bFractureOnTouch;
  public bool bDebug_FireLinks;
  public bool bDebug_ExposedLinks;
  public bool bDebug_CoverGen;
  public bool bDoAutoSlotDensityFixup;
  public float LeanTraceDist;
  public List<FCoverSlot> Slots;
  public List<FDynamicLinkInfo> DynamicLinkInfos;
  public List<APawn> Claims;
  public float InvalidateDistance;
  public float MaxFireLinkDist;
  public FVector CircularOrigin = new();
  public float CircularRadius;
  public float AlignDist;
  public float AutoCoverSlotInterval;
  public float StandHeight;
  public float MidHeight;
  public FVector StandingLeanOffset = new();
  public FVector CrouchLeanOffset = new();
  public FVector PopupOffset = new();
  public float SlipDist;
  public float TurnDist;
  public float DangerScale;
  public ACoverLink NextCoverLink;
  public ECoverLocationDescription LocationDescription;
}

public partial class UStaticMeshComponent : UMeshComponent
{
  public partial class FStaticMeshComponentLODInfo : ISerialisable
  {
    public List<UShadowMap2D> ShadowMaps;
    public List<UShadowMap1D> ShadowVertexBuffers;
    public UEngineTypes.FLightMap LightMap = new();
    public UStaticMesh.FColorVertexBuffer OverrideVertexColors = new();
  }

  public class FLODMaterialInfo
  {
    public List<UMaterialInterface> Materials;
  }

  public int ForcedLodModel;
  public int PreviousLODLevel;
  public UStaticMesh StaticMesh;
  public FColor WireframeColor = new();
  public bool bIgnoreInstanceForTextureStreaming;
  public bool bOverrideLightMapResolution;
  public bool bOverrideLightMapRes;
  public int OverriddenLightMapResolution;
  public int OverriddenLightMapRes;
  public float OverriddenLODMaxRange;
  public int SubDivisionStepSize;
  public bool bUseSubDivisions;
  public bool bForceStaticDecals;
  public bool bNeverBecomeDynamic;
  public List<FGuid> IrrelevantLights;
  public List<FStaticMeshComponentLODInfo> LODData;
  public List<FLODMaterialInfo> LODMaterials;
  public UEngineTypes.FLightmassPrimitiveSettings LightmassSettings = new();
  public int StaticMeshComponentID;
}

public class UCoverMeshComponent : UStaticMeshComponent
{
  public class FCoverMeshes
  {
    public UStaticMesh Base;
    public UStaticMesh LeanLeft;
    public UStaticMesh LeanRight;
    public UStaticMesh LeanLeftPref;
    public UStaticMesh LeanRightPref;
    public UStaticMesh Climb;
    public UStaticMesh Mantle;
    public UStaticMesh SlipLeft;
    public UStaticMesh SlipRight;
    public UStaticMesh SwatLeft;
    public UStaticMesh SwatRight;
    public UStaticMesh PopUp;
    public UStaticMesh PlayerOnly;
  }

  public List<FCoverMeshes> Meshes;
  public FVector LocationOffset = new();
  public UStaticMesh AutoAdjustOn;
  public UStaticMesh AutoAdjustOff;
  public UStaticMesh Disabled;
  public bool bShowWhenNotSelected;
}

public class AReplicationInfo : AInfo
{
}

public class ACoverReplicator : AReplicationInfo
{
  public class FManualCoverTypeInfo
  {
    public byte SlotIndex;
    public ECoverType ManualCoverType;
  }

  public class FCoverReplicationInfo
  {
    public ACoverLink Link;
    public List<byte> SlotsEnabled;
    public List<byte> SlotsDisabled;
    public List<byte> SlotsAdjusted;
    public List<ACoverReplicator.FManualCoverTypeInfo> SlotsCoverTypeChanged;
  }

  public List<FCoverReplicationInfo> CoverReplicationData;
}

public class UForcedReachSpec : UReachSpec
{
}

public class UCoverSlipReachSpec : UForcedReachSpec
{
  public byte SpecDirection;
}

public class ACrowdAgentBase : AActor
{
  public FPointer VfTable_IInterface_NavigationHandle = new();
}

public class ACrowdPopulationManagerBase : AActor
{
}

public class ACullDistanceVolume : AVolume
{
  public class FCullDistanceSizePair
  {
    public float Size;
    public float CullDistance;
  }

  public List<FCullDistanceSizePair> CullDistances;
  public bool bEnabled;
}

public class UUIDataProvider : UUIRoot
{
  public class FUIDataProviderField
  {
    public FName FieldTag;
    public EUIDataProviderFieldType FieldType;
    public List<UUIDataProvider> FieldProviders;
  }

  public EProviderAccessType WriteAccessType;
  public List<FScriptDelegate> ProviderChangedNotifies;
  public FScriptDelegate __OnDataProviderPropertyChange__Delegate;
}

public class UUIDataStore : UUIDataProvider
{
  public FName Tag;
  public List<FScriptDelegate> RefreshSubscriberNotifies;
  public FScriptDelegate __OnDataStoreValueUpdated__Delegate;
}

public class UUIDataStore_GameState : UUIDataStore
{
  public FScriptDelegate __OnRefreshDataFieldValue__Delegate;
}

public class UCurrentGameDataStore : UUIDataStore_GameState
{
  public class FGameDataProviderTypes
  {
    public UClass GameDataProviderClass;
    public UClass PlayerDataProviderClass;
    public UClass TeamDataProviderClass;
  }

  public FPointer VfTable_IUIListElementProvider = new();
  public FGameDataProviderTypes ProviderTypes = new();
  public UGameInfoDataProvider GameData;
  public List<UPlayerDataProvider> PlayerData;
  public List<UTeamDataProvider> TeamData;
  public bool bRefreshPlayerDataProviders;
  public bool bRefreshTeamDataProviders;
  public FScriptDelegate __OnAddTeamProvider__Delegate;
}

public class UUIPropertyDataProvider : UUIDataProvider
{
  public List<UClass> ComplexPropertyTypes;
  public FScriptDelegate __CanSupportComplexPropertyType__Delegate;
}

public class UUIDynamicDataProvider : UUIPropertyDataProvider
{
  public FPointer VfTable_IUIListElementCellProvider = new();
  public UClass DataClass;
  public UObject DataSource;
}

public class UInventoryDataProvider : UUIDynamicDataProvider
{
}

public class UWeaponDataProvider : UInventoryDataProvider
{
}

public class UCurrentWeaponDataProvider : UWeaponDataProvider
{
}

public class UCurveEdPresetCurve : UObject
{
  public class FPresetGeneratedPoint
  {
    public float KeyIn;
    public float KeyOut;
    public bool TangentsValid;
    public float TangentIn;
    public float TangentOut;
    public EInterpCurveMode IntepMode;
  }

  public string CurveName;
  public List<FPresetGeneratedPoint> Points;
}

public class UCustomPropertyItemHandler : UInterface
{
}

public class UDamageType : UObject
{
  public bool bArmorStops;
  public bool bAlwaysGibs;
  public bool bNeverGibs;
  public bool bLocationalHit;
  public bool bCausesBlood;
  public bool bCausedByWorld;
  public bool bAlwaysCauseDamage;
  public bool bExtraMomentumZ;
  public bool bCausesFracture;
  public bool bIgnoreDriverDamageMult;
  public bool bRadialDamageVelChange;
  public bool bUseSeperateHitType;
  public bool bUseOnlyRagDoll;
  public bool bUseOnlyRagDollNonViewTarget;
  public bool bAllowHeadShot;
  public bool bAllowCriticalShot;
  public bool bSpecialCombatMsgType;
  public float KDamageImpulse;
  public float KDeathVel;
  public float KDeathUpKick;
  public float RadialDamageImpulse;
  public float VehicleDamageScaling;
  public float VehicleMomentumScaling;
  public UForceFeedbackWaveform DamagedFFWaveform;
  public UForceFeedbackWaveform KilledFFWaveform;
  public float FracturedMeshDamage;
  public int AdditionalHitType;
  public int CombatMsgType;
  public USoundCue TakeDamageSound;
  public USoundCue DyingSound;
  public UClass ExtraDamageType;
}

public class UDataStoreClient : UUIRoot
{
  public class FPlayerDataStoreGroup
  {
    public ULocalPlayer PlayerOwner;
    public List<UUIDataStore> DataStores;
  }

  public List<string> GlobalDataStoreClasses;
  public List<UUIDataStore> GlobalDataStores;
  public List<string> PlayerDataStoreClassNames;
  public List<UClass> PlayerDataStoreClasses;
  public List<FPlayerDataStoreGroup> PlayerDataStores;
}

public class ADebugCameraController : APlayerController
{
  public FName PrimaryKey;
  public FName SecondaryKey;
  public FName UnselectKey;
  public bool bShowSelectedInfo;
  public bool bIsFrozenRendering;
  public APlayerController OryginalControllerRef;
  public UPlayer OryginalPlayer;
  public UDrawFrustumComponent DrawFrustum;
  public AActor SelectedActor;
  public UPrimitiveComponent SelectedComponent;
}

public class AHUD : AActor
{
  public class FConsoleMessage
  {
    public string Text;
    public UObject.FColor TextColor = new();
    public float MessageLife;
    public APlayerReplicationInfo PRI;
  }

  public class FHudLocalizedMessage
  {
    public UClass Message;
    public string StringMessage;
    public int Switch;
    public float EndOfLife;
    public float Lifetime;
    public float PosY;
    public UObject.FColor DrawColor = new();
    public int FontSize;
    public UFont StringFont;
    public float DX;
    public float DY;
    public bool Drawn;
    public int Count;
    public UObject OptionalObject;
  }

  public class FKismetDrawTextInfo
  {
    public string MessageText;
    public UFont MessageFont;
    public UObject.FVector2D MessageFontScale = new();
    public UObject.FVector2D MessageOffset = new();
    public UObject.FColor MessageColor = new();
    public float MessageEndTime;
  }

  public FColor WhiteColor = new();
  public FColor GreenColor = new();
  public FColor RedColor = new();
  public APlayerController PlayerOwner;
  public AScoreBoard ScoreBoard;
  public bool bLostFocusPaused;
  public bool bShowHUD;
  public bool bShowScores;
  public bool bShowDebugInfo;
  public bool bShowBadConnectionAlert;
  public bool bMessageBeep;
  public bool bRenderFullScreen;
  public bool bScaleCanvasForCinematicMode;
  public bool bShowOverlays;
  public float HudCanvasScale;
  public List<AActor> PostRenderedActors;
  public List<FConsoleMessage> ConsoleMessages;
  public FColor ConsoleColor = new();
  public int ConsoleMessageCount;
  public int ConsoleFontSize;
  public int MessageFontOffset;
  public int MaxHUDAreaMessageCount;
  public FHudLocalizedMessage[] LocalMessages = new FHudLocalizedMessage[8];
  public float ConsoleMessagePosX;
  public float ConsoleMessagePosY;
  public UCanvas Canvas;
  public float LastHUDRenderTime;
  public float RenderDelta;
  public float SizeX;
  public float SizeY;
  public float CenterX;
  public float CenterY;
  public float RatioX;
  public float RatioY;
  public List<FName> DebugDisplay;
  public List<FKismetDrawTextInfo> KismetTextInfo;
}

public class ADebugCameraHUD : AHUD
{
}

public class UInput : UInteraction
{
  public class FKeyBind
  {
    public FName Name;
    public string Command;
    public bool Control;
    public bool Shift;
    public bool Alt;
    public bool bIgnoreCtrl;
    public bool bIgnoreShift;
    public bool bIgnoreAlt;
  }

  public List<FKeyBind> Bindings;
  public List<FName> PressedKeys;
  public EInputEvent CurrentEvent;
  public float CurrentDelta;
  public float CurrentDeltaTime;
  public Dictionary<byte, byte> NameToPtr;
  public List<FPointer> AxisArray;
}

public class UPlayerInput : UInput
{
  public bool bUsingGamepad;
  public bool bInvertMouse;
  public bool bInvertTurn;
  public bool bWasForward;
  public bool bWasBack;
  public bool bWasLeft;
  public bool bWasRight;
  public bool bEdgeForward;
  public bool bEdgeBack;
  public bool bEdgeLeft;
  public bool bEdgeRight;
  public bool bEnableMouseSmoothing;
  public bool bEnableFOVScaling;
  public bool bLockTurnUntilRelease;
  public FName LastAxisKeyName;
  public float DoubleClickTimer;
  public float DoubleClickTime;
  public float MouseSensitivity;
  public float FOVScalingBasis;
  public float aBaseX;
  public float aBaseY;
  public float aBaseZ;
  public float aMouseX;
  public float aMouseY;
  public float aForward;
  public float aTurn;
  public float aStrafe;
  public float aUp;
  public float aLookUp;
  public float aRightAnalogTrigger;
  public float aLeftAnalogTrigger;
  public float aPS3AccelX;
  public float aPS3AccelY;
  public float aPS3AccelZ;
  public float aPS3Gyro;
  public float RawJoyUp;
  public float RawJoyRight;
  public float RawJoyLookRight;
  public float RawJoyLookUp;
  public float MoveForwardSpeed;
  public float MoveStrafeSpeed;
  public float LookRightScale;
  public float LookUpScale;
  public byte bStrafe;
  public byte bXAxis;
  public byte bYAxis;
  public float[] ZeroTime = new float[2];
  public float[] SmoothedMouse = new float[2];
  public int MouseSamples;
  public float MouseSamplingTotal;
  public float AutoUnlockTurnTime;
}

public class UDebugCameraInput : UPlayerInput
{
}

public class UDebugManager : UObject
{
  public int FirstColoredMip;
}

public partial class UDecalComponent : UPrimitiveComponent
{
  public class FDecalReceiver
  {
    public UPrimitiveComponent Component;
    public UObject.FPointer RenderData = new();
  }

  public class FDecalVertex
  {
    public UObject.FVector2D LightMapCoordinate = new();
    public UObject.FVector Position = new();
    public UObject.FPackedNormal TangentX = new();
    public UObject.FPackedNormal TangentZ = new();
  }

  public partial class FStaticReceiverData : ISerialisable
  {
    public UPrimitiveComponent Component;
    public int Data;
    public List<ushort> Indices;
    public int InstanceIndex;
    public UEngineTypes.FLightMap LightMap1D = new();
    public uint NumTriangles;
    public List<UShadowMap1D> ShadowMap1D;
    public List<UDecalComponent.FDecalVertex> Vertices;
  }

  public UMaterialInterface DecalMaterial;
  public float Width;
  public float Height;
  public float TileX;
  public float TileY;
  public float OffsetX;
  public float OffsetY;
  public float DecalRotation;
  public float FieldOfView;
  public float NearPlane;
  public float FarPlane;
  public FVector Location = new();
  public FRotator Orientation = new();
  public FVector HitLocation = new();
  public FVector HitNormal = new();
  public FVector HitTangent = new();
  public FVector HitBinormal = new();
  public bool bNoClip;
  public bool bStaticDecal;
  public bool bProjectOnBackfaces;
  public bool bProjectOnHidden;
  public bool bProjectOnBSP;
  public bool bProjectOnStaticMeshes;
  public bool bProjectOnSkeletalMeshes;
  public bool bProjectOnTerrain;
  public bool bFlipBackfaceDirection;
  public bool bMovableDecal;
  public bool bHasBeenAttached;
  public UPrimitiveComponent HitComponent;
  public FName HitBone;
  public int HitNodeIndex;
  public int HitLevelIndex;
  public int FracturedStaticMeshComponentIndex;
  public List<int> HitNodeIndices;
  public List<FDecalReceiver> DecalReceivers;
  public List<FStaticReceiverData> StaticReceivers;
  public FPointer ReleaseResourcesFence = new();
  public List<FPlane> Planes;
  public float DepthBias;
  public float SlopeScaleDepthBias;
  public int SortOrder;
  public float BackfaceAngle;
  public FVector2D BlendRange = new();
  public EDecalTransform DecalTransform;
  public EFilterMode FilterMode;
  public List<AActor> Filter;
  public List<UPrimitiveComponent> ReceiverImages;
  public FVector ParentRelativeLocation = new();
  public FRotator ParentRelativeOrientation = new();
  public FVector OriginalParentRelativeLocation = new();
  public FVector OriginalParentRelativeOrientationVec = new();
}

public class ADecalActorBase : AActor
{
  public UDecalComponent Decal;
}

public class ADecalActor : ADecalActorBase
{
}

public class ADecalActorMovable : ADecalActorBase
{
}

public class ADecalManager : AActor
{
  public class FActiveDecalInfo
  {
    public UDecalComponent Decal;
    public float LifetimeRemaining;
  }

  public UDecalComponent DecalTemplate;
  public List<UDecalComponent> PoolDecals;
  public int MaxActiveDecals;
  public float DecalLifeSpan;
  public float DecalDepthBias;
  public FVector2D DecalBlendRange = new();
  public List<FActiveDecalInfo> ActiveDecals;
}

public partial class UMaterialInterface : USurface
{
  public class FLightmassMaterialInterfaceSettings
  {
    public float EmissiveBoost;
    public float DiffuseBoost;
    public float SpecularBoost;
    public float ExportResolutionScale;
    public float DistanceFieldPenumbraScale;
    public bool bOverrideEmissiveBoost;
    public bool bOverrideDiffuseBoost;
    public bool bOverrideSpecularBoost;
    public bool bOverrideExportResolutionScale;
    public bool bOverrideDistanceFieldPenumbraScale;
  }

  public class FStaticSwitchParameter
  {
    public bool bOverride;
    public UObject.FGuid ExpressionGUID = new();
    public FName ParameterName;
    public bool Value;
  }

  public class FStaticComponentMaskParameter
  {
    public uint A;
    public uint B;
    public bool bOverride;
    public UObject.FGuid ExpressionGUID = new();
    public uint G;
    public FName ParameterName;
    public uint R;
  }

  public class FNormalParameter
  {
    public bool bOverride;
    public byte CompressionSettings;
    public UObject.FGuid ExpressionGUID = new();
    public FName ParameterName;
  }

  public class FStaticTerrainLayerWeightParameter
  {
    public bool bOverride;
    public UObject.FGuid ExpressionGUID = new();
    public FName ParameterName;
    public int WeightmapIndex;
  }

  public partial class FStaticParameterSet : ISerialisable
  {
    public UObject.FGuid BaseMaterialId = new();
    public List<UMaterialInterface.FNormalParameter> NormalParameters;
    public List<UMaterialInterface.FStaticComponentMaskParameter> StaticComponentMaskParameters;
    public List<UMaterialInterface.FStaticSwitchParameter> StaticSwitchParameters;
    public List<UMaterialInterface.FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters;
  }

  public class FMaterialUniformExpression
  {
    public FName Type;
  }

  public class FMaterialUniformExpressionRef
  {
    public ulong Index = new();
  }

  public class FMaterialUniformExpressionAbs : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef X = new();
  }

  public class FMaterialUniformExpressionCeil : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef X = new();
  }

  public class FMaterialUniformExpressionClamp : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef Input = new();
    public UMaterialInterface.FMaterialUniformExpressionRef Max = new();
    public UMaterialInterface.FMaterialUniformExpressionRef Min = new();
  }

  public class FMaterialUniformExpressionFloor : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef X = new();
  }

  public class FMaterialUniformExpressionFmod : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef A = new();
    public UMaterialInterface.FMaterialUniformExpressionRef B = new();
  }

  public class FMaterialUniformExpressionFrac : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef X = new();
  }

  public class FMaterialUniformExpressionMin : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef A = new();
    public UMaterialInterface.FMaterialUniformExpressionRef B = new();
  }

  public class FMaterialUniformExpressionMax : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef A = new();
    public UMaterialInterface.FMaterialUniformExpressionRef B = new();
  }

  public class FMaterialUniformExpressionSine : FMaterialUniformExpression
  {
    public bool bIsCosine;
    public UMaterialInterface.FMaterialUniformExpressionRef X = new();
  }

  public class FMaterialUniformExpressionSquareRoot : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef X = new();
  }

  public class FMaterialUniformExpressionAppendVector : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef A = new();
    public UMaterialInterface.FMaterialUniformExpressionRef B = new();
    public uint NumComponentsA;
  }

  public class FMaterialUniformExpressionVectorParameter : FMaterialUniformExpression
  {
    public UObject.FLinearColor DefaultValue = new();
    public FName ParameterName;
  }

  public class FMaterialUniformExpressionConstant : FMaterialUniformExpression
  {
    public UObject.FLinearColor Value = new();
    public byte ValueType;
  }

  public class FMaterialUniformExpressionFoldedMath : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef A = new();
    public UMaterialInterface.FMaterialUniformExpressionRef B = new();
    public byte Op;
  }

  public class FMaterialUniformExpressionLength : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef X = new();
  }

  public class FMaterialUniformExpressionPeriodic : FMaterialUniformExpression
  {
    public UMaterialInterface.FMaterialUniformExpressionRef X = new();
  }

  public class FMaterialUniformExpressionRealTime : FMaterialUniformExpression
  {
  }

  public class FMaterialUniformExpressionScalarParameter : FMaterialUniformExpression
  {
    public float DefaultValue;
    public FName ParameterName;
  }

  public class FMaterialUniformExpressionTexture : FMaterialUniformExpression
  {
    public int TextureIndex;
  }

  public class FMaterialUniformExpressionTextureParameter : FMaterialUniformExpressionTexture
  {
    public FName ParameterName;
  }

  public class FMaterialUniformExpressionFlipBookTextureParameter : FMaterialUniformExpressionTexture
  {
  }

  public class FMaterialUniformExpressionTime : FMaterialUniformExpression
  {
  }

  public class FShaderFrequencyUniformExpressions
  {
    public List<byte> MaterialUniformExpressionStorage;
    public List<UMaterialInterface.FMaterialUniformExpressionRef> UniformScalarExpressions;
    public List<UMaterialInterface.FMaterialUniformExpressionRef> UniformVectorExpressions;
  }

  public class FUniformExpressionSet
  {
    public UMaterialInterface.FShaderFrequencyUniformExpressions PixelExpressions = new();
    public UMaterialInterface.FShaderFrequencyUniformExpressions UniformCubeTextureExpressions = new();
    public UMaterialInterface.FShaderFrequencyUniformExpressions VertexExpressions = new();
  }

  public FRenderCommandFence_Mirror ParentRefFence = new();
  public FLightmassMaterialInterfaceSettings LightmassSettings = new();
  public string PreviewMesh;
  public FGuid LightingGuid = new();
  public UTexture FlattenedTexture;
}

public partial class UMaterial : UMaterialInterface
{
  public class FMaterialInput
  {
    public UMaterialExpression Expression;
    public int Mask;
    public int MaskR;
    public int MaskG;
    public int MaskB;
    public int MaskA;
    public int GCC64_Padding;
  }

  public class FColorMaterialInput : FMaterialInput
  {
    public bool UseConstant;
    public UObject.FColor Constant = new();
  }

  public class FScalarMaterialInput : FMaterialInput
  {
    public bool UseConstant;
    public float Constant;
  }

  public class FVectorMaterialInput : FMaterialInput
  {
    public bool UseConstant;
    public UObject.FVector Constant = new();
  }

  public class FVector2MaterialInput : FMaterialInput
  {
    public bool UseConstant;
    public float ConstantX;
    public float ConstantY;
  }

  public UPhysicalMaterial PhysMaterial;
  public UClass PhysicalMaterial;
  public UTexture2D PhysMaterialMask;
  public int PhysMaterialMaskUVChannel;
  public UPhysicalMaterial BlackPhysicalMaterial;
  public UPhysicalMaterial WhitePhysicalMaterial;
  public FColorMaterialInput DiffuseColor = new();
  public FScalarMaterialInput DiffusePower = new();
  public FColorMaterialInput SpecularColor = new();
  public FScalarMaterialInput SpecularPower = new();
  public FVectorMaterialInput Normal = new();
  public FColorMaterialInput EmissiveColor = new();
  public FScalarMaterialInput Opacity = new();
  public FScalarMaterialInput OpacityMask = new();
  public float OpacityMaskClipValue;
  public FVector2MaterialInput Distortion = new();
  public EBlendMode BlendMode;
  public EMaterialLightingModel LightingModel;
  public FColorMaterialInput CustomLighting = new();
  public FColorMaterialInput CustomSkylightDiffuse = new();
  public FVectorMaterialInput AnisotropicDirection = new();
  public FScalarMaterialInput TwoSidedLightingMask = new();
  public FColorMaterialInput TwoSidedLightingColor = new();
  public FVectorMaterialInput WorldPositionOffset = new();
  public bool EnableSkinSubsurfaceScattering;
  public bool TwoSided;
  public bool TwoSidedSeparatePass;
  public bool bDisableDepthTest;
  public bool bAllowFog;
  public bool bTranslucencyReceiveDominantShadowsFromStatic;
  public bool bTranslucencyInheritDominantShadowsFromOpaque;
  public bool bAllowTranslucencyDoF;
  public bool bUseOneLayerDistortion;
  public bool bUseLitTranslucencyDepthPass;
  public bool bUseLitTranslucencyPostRenderDepthPass;
  public bool bCastLitTranslucencyShadowAsMasked;
  public bool bUsedAsLightFunction;
  public bool bUsedWithFogVolumes;
  public bool bUsedAsSpecialEngineMaterial;
  public bool bUsedWithSkeletalMesh;
  public bool bUsedWithFracturedMeshes;
  public bool bUsedWithParticleSystem;
  public bool bUsedWithParticleSprites;
  public bool bUsedWithBeamTrails;
  public bool bUsedWithParticleSubUV;
  public bool bUsedWithFoliage;
  public bool bUsedWithSpeedTree;
  public bool bUsedWithStaticLighting;
  public bool bUsedWithLensFlare;
  public bool bUsedWithGammaCorrection;
  public bool bUsedWithInstancedMeshParticles;
  public bool bUsedWithFluidSurfaces;
  public bool bUsedWithDecals;
  public bool bUsedWithMaterialEffect;
  public bool bUsedWithMorphTargets;
  public bool bUsedWithRadialBlur;
  public bool bUsedWithInstancedMeshes;
  public bool bUsedWithSplineMeshes;
  public bool bUsedWithAPEXMeshes;
  public bool bUsedWithScreenDoorFade;
  public bool Wireframe;
  public bool bPerPixelCameraVector;
  public bool bAllowLightmapSpecular;
  public bool bIsFallbackMaterial;
  public bool bIsSM2PMaterial;
  public bool bUsesDistortion;
  public bool bIsMasked;
  public bool bIsPreviewMaterial;
  public UMaterial FallbackMaterial;
  public UMaterial SM2PMaterial;
  public FMaterialResource[] MaterialResources = new FMaterialResource[3];
  public FPointer[] DefaultMaterialInstances = new FPointer[2];
  public int EditorX;
  public int EditorY;
  public int EditorPitch;
  public int EditorYaw;
  public List<UMaterialExpression> Expressions;
  public List<UMaterialExpressionComment> EditorComments;
  public List<UMaterialExpressionCompound> EditorCompounds;
  public Dictionary<byte, byte> EditorParameters;
  public List<UTexture> ReferencedTextures;
  public List<FGuid> ReferencedTextureGuids;
}

public class UDecalMaterial : UMaterial
{
}

public class APhysicsVolume : AVolume
{
  public class FCheckpointRecord
  {
    public bool bPainCausing;
  }

  public FVector ZoneVelocity = new();
  public bool bVelocityAffectsWalking;
  public bool bPainCausing;
  public bool bAIShouldIgnorePain;
  public bool bEntryPain;
  public bool BACKUP_bPainCausing;
  public bool bDestructive;
  public bool bNoInventory;
  public bool bMoveProjectiles;
  public bool bBounceVelocity;
  public bool bNeutralZone;
  public bool bCrowdAgentsPlayDeathAnim;
  public bool bPhysicsOnContact;
  public bool bUseActorGravity;
  public bool bStairVolume;
  public bool bWaterVolume;
  public float GroundFriction;
  public float TerminalVelocity;
  public float DamagePerSec;
  public UClass DamageType;
  public int Priority;
  public float FluidFriction;
  public float PainInterval;
  public float RigidBodyDamping;
  public float MaxDampingForce;
  public TeamIndexForIgnoreDeath IgnoreDeathScoreTeam;
  public AInfo PainTimer;
  public AController DamageInstigator;
  public APhysicsVolume NextPhysicsVolume;
  public float MinimumSpeedToPlayAnim;
}

public class ADefaultPhysicsVolume : APhysicsVolume
{
}

public class ALight : AActor
{
  public ULightComponent LightComponent;
  public bool bEnabled;
}

public class UDirectionalLightComponent : ULightComponent
{
  public float TraceDistance;
  public float WholeSceneDynamicShadowRadius;
  public int NumWholeSceneDynamicShadowCascades;
  public float CascadeDistributionExponent;
  public UEngineTypes.FLightmassDirectionalLightSettings LightmassSettings = new();
}

public class ADirectionalLight : ALight
{
}

public class ADirectionalLightToggleable : ADirectionalLight
{
}

public class UDistributionFloatConstant : UDistributionFloat
{
  public float Constant;
}

public class UDistributionFloatConstantCurve : UDistributionFloat
{
  public FInterpCurveFloat ConstantCurve = new();
}

public class UDistributionFloatParameterBase : UDistributionFloatConstant
{
  public FName ParameterName;
  public float MinInput;
  public float MaxInput;
  public float MinOutput;
  public float MaxOutput;
  public DistributionParamMode ParamMode;
}

public class UDistributionFloatParticleParameter : UDistributionFloatParameterBase
{
}

public class UDistributionFloatSoundParameter : UDistributionFloatParameterBase
{
}

public class UDistributionFloatUniformCurve : UDistributionFloat
{
  public FInterpCurveVector2D ConstantCurve = new();
}

public class UDistributionVectorConstant : UDistributionVector
{
  public FVector Constant = new();
  public bool bLockAxes;
  public EDistributionVectorLockFlags LockedAxes;
}

public class UDistributionVectorConstantCurve : UDistributionVector
{
  public FInterpCurveVector ConstantCurve = new();
  public bool bLockAxes;
  public EDistributionVectorLockFlags LockedAxes;
}

public class UDistributionVectorParameterBase : UDistributionVectorConstant
{
  public FName ParameterName;
  public FVector MinInput = new();
  public FVector MaxInput = new();
  public FVector MinOutput = new();
  public FVector MaxOutput = new();
  public DistributionParamMode[] ParamModes = new DistributionParamMode[3];
}

public class UDistributionVectorParticleParameter : UDistributionVectorParameterBase
{
}

public class UDistributionVectorUniform : UDistributionVector
{
  public FVector Max = new();
  public FVector Min = new();
  public bool bLockAxes;
  public bool bUseExtremes;
  public EDistributionVectorLockFlags LockedAxes;
  public EDistributionVectorMirrorFlags[] MirrorFlags = new EDistributionVectorMirrorFlags[3];
}

public class UDistributionVectorUniformCurve : UDistributionVector
{
  public FInterpCurveTwoVectors ConstantCurve = new();
  public bool bLockAxes1;
  public bool bLockAxes2;
  public bool bUseExtremes;
  public EDistributionVectorLockFlags[] LockedAxes = new EDistributionVectorLockFlags[2];
  public EDistributionVectorMirrorFlags[] MirrorFlags = new EDistributionVectorMirrorFlags[3];
}

public class UDmgType_Crushed : UDamageType
{
}

public class UDmgType_Fell : UDamageType
{
}

public class UKillZDamageType : UDamageType
{
}

public class UDmgType_Suicided : UKillZDamageType
{
}

public class UDmgType_Telefragged : UDamageType
{
}

public class UDOFAndBloomEffect : UDOFEffect
{
  public float BloomScale;
  public float SceneMultiplier;
  public float BlurBloomKernelSize;
  public bool bEnableSeparateBloom;
  public bool bEnableReferenceDOF;
}

public class UDOFBloomMotionBlurEffect : UDOFAndBloomEffect
{
  public float MaxVelocity;
  public float MotionBlurAmount;
  public bool FullMotionBlur;
  public float CameraRotationThreshold;
  public float CameraTranslationThreshold;
}

public partial class UDominantDirectionalLightComponent : UDirectionalLightComponent
{
  public UEngineTypes.FDominantShadowInfo DominantLightShadowInfo = new();
  public List<ushort> DominantLightShadowMap;
}

public class ADominantDirectionalLight : ADirectionalLight
{
}

public class ADominantDirectionalLightMovable : ADominantDirectionalLight
{
}

public class UPointLightComponent : ULightComponent
{
  public float ShadowRadiusMultiplier;
  public float Radius;
  public float FalloffExponent;
  public float ShadowFalloffExponent;
  public float MinShadowFalloffRadius;
  public FMatrix CachedParentToWorld = new();
  public FVector Translation = new();
  public UDrawLightRadiusComponent PreviewLightRadius;
  public UEngineTypes.FLightmassPointLightSettings LightmassSettings = new();
  public UDrawLightRadiusComponent PreviewLightSourceRadius;
}

public class APointLight : ALight
{
}

public class UDominantPointLightComponent : UPointLightComponent
{
}

public class ADominantPointLight : APointLight
{
}

public class USpotLightComponent : UPointLightComponent
{
  public float InnerConeAngle;
  public float OuterConeAngle;
  public UDrawLightConeComponent PreviewInnerCone;
  public UDrawLightConeComponent PreviewOuterCone;
  public FRotator Rotation = new();
}

public class ASpotLight : ALight
{
}

public partial class UDominantSpotLightComponent : USpotLightComponent
{
  public UEngineTypes.FDominantShadowInfo DominantLightShadowInfo = new();
  public List<ushort> DominantLightShadowMap;
}

public class ADominantSpotLight : ASpotLight
{
}

public class ADoorMarker : ANavigationPoint
{
  public AInterpActor MyDoor;
  public EDoorType DoorType;
  public AActor DoorTrigger;
  public bool bWaitUntilCompletelyOpened;
  public bool bInitiallyClosed;
  public bool bBlockedWhenClosed;
  public bool bDoorOpen;
  public bool bTempDisabledCollision;
}

public class UDrawBoxComponent : UPrimitiveComponent
{
  public FColor BoxColor = new();
  public UMaterial BoxMaterial;
  public FVector BoxExtent = new();
  public bool bDrawWireBox;
  public bool bDrawLitBox;
}

public partial class UDrawBSPTreeComponent : UPrimitiveComponent
{
  public UModel Model;
}

public class UDrawCapsuleComponent : UPrimitiveComponent
{
  public FColor CapsuleColor = new();
  public UMaterial CapsuleMaterial;
  public float CapsuleHeight;
  public float CapsuleRadius;
  public bool bDrawWireCapsule;
  public bool bDrawLitCapsule;
}

public class UDrawConeComponent : UPrimitiveComponent
{
  public FColor ConeColor = new();
  public float ConeRadius;
  public float ConeAngle;
  public int ConeSides;
}

public class UDrawCylinderComponent : UPrimitiveComponent
{
  public FColor CylinderColor = new();
  public UMaterial CylinderMaterial;
  public float CylinderRadius;
  public float CylinderTopRadius;
  public float CylinderHeight;
  public float CylinderHeightOffset;
  public int CylinderSides;
  public bool bDrawWireCylinder;
  public bool bDrawLitCylinder;
}

public class UDrawFrustumComponent : UPrimitiveComponent
{
  public FColor FrustumColor = new();
  public float FrustumAngle;
  public float FrustumAspectRatio;
  public float FrustumStartDist;
  public float FrustumEndDist;
  public UTexture Texture;
}

public class UDrawLightConeComponent : UDrawConeComponent
{
}

public class UDrawSphereComponent : UPrimitiveComponent
{
  public FColor SphereColor = new();
  public UMaterial SphereMaterial;
  public float SphereRadius;
  public int SphereSides;
  public bool bDrawWireSphere;
  public bool bDrawLitSphere;
}

public class UDrawLightRadiusComponent : UDrawSphereComponent
{
}

public class UDrawPylonRadiusComponent : UDrawSphereComponent
{
}

public class UDrawQuadComponent : UPrimitiveComponent
{
  public UTexture Texture;
  public float Width;
  public float Height;
}

public class UDrawSoundRadiusComponent : UDrawSphereComponent
{
}

public class ADroppedPickup : AActor
{
  public AInventory Inventory;
  public UClass InventoryClass;
  public ANavigationPoint PickupCache;
  public bool bFadeOut;
}

public class ADynamicAnchor : ANavigationPoint
{
  public AController CurrentUser;
}

public class ADynamicBlockingVolume : ABlockingVolume
{
  public class FCheckpointRecord
  {
    public UObject.FVector Location = new();
    public UObject.FRotator Rotation = new();
    public bool bCollideActors;
    public bool bBlockActors;
    public bool bNeedsReplication;
  }

  public bool bEnabled;
}

public class ADynamicCameraActor : ACameraActor
{
}

public class ADynamicPhysicsVolume : APhysicsVolume
{
  public bool bEnabled;
}

public class ADynamicPylon : APylon
{
  public bool bMoving;
}

public class ADynamicSMActor : AActor
{
  public UStaticMeshComponent StaticMeshComponent;
  public UDynamicLightEnvironmentComponent LightEnvironment;
  public UStaticMesh ReplicatedMesh;
  public UMaterialInterface ReplicatedMaterial;
  public bool bForceStaticDecals;
  public bool bPawnCanBaseOn;
  public bool bSafeBaseIfAsleep;
  public FVector ReplicatedMeshTranslation = new();
  public FRotator ReplicatedMeshRotation = new();
  public FVector ReplicatedMeshScale3D = new();
  public FVector InitialLocation = new();
  public FRotator InitialRotation = new();
}

public class ADynamicSMActor_Spawnable : ADynamicSMActor
{
}

public class ATriggerVolume : AVolume
{
}

public class ADynamicTriggerVolume : ATriggerVolume
{
  public bool bEnabled;
}

public class UEdCoordSystem : UObject
{
  public FMatrix M = new();
  public string Desc;
}

public class UEditorLinkSelectionInterface : UInterface
{
}

public class UParticleSystemComponent : UPrimitiveComponent
{
  public class FParticleSysParam
  {
    public FName Name;
    public EParticleSysParamType ParamType;
    public float Scalar;
    public UObject.FVector Vector = new();
    public UObject.FColor Color = new();
    public AActor Actor;
    public UMaterialInterface Material;
  }

  public class FParticleEventData
  {
    public int Type;
    public FName EventName;
    public float EmitterTime;
    public UObject.FVector Location = new();
    public UObject.FVector Direction = new();
    public UObject.FVector Velocity = new();
  }

  public class FParticleEventSpawnData : FParticleEventData
  {
  }

  public class FParticleEventDeathData : FParticleEventData
  {
    public float ParticleTime;
  }

  public class FParticleEventCollideData : FParticleEventData
  {
    public float ParticleTime;
    public UObject.FVector Normal = new();
    public float Time;
    public int Item;
    public FName BoneName;
  }

  public class FParticleEventKismetData : FParticleEventData
  {
    public bool UsePSysCompLocation;
    public UObject.FVector Normal = new();
  }

  public class FParticleEmitterInstance
  {
  }

  public class FParticleEmitterInstanceMotionBlurInfo
  {
    public UObject.FMap_Mirror ParticleMBInfoMap = new();
  }

  public class FViewParticleEmitterInstanceMotionBlurInfo
  {
    public UObject.FMap_Mirror EmitterInstanceMBInfoMap = new();
  }

  public UParticleSystem Template;
  public UClass LightEnvironmentClass;
  public List<FPointer> EmitterInstances;
  public List<UStaticMeshComponent> SMComponents;
  public List<UMaterialInterface> SMMaterialInterfaces;
  public List<FViewParticleEmitterInstanceMotionBlurInfo> ViewMBInfoArray;
  public bool bAutoActivate;
  public bool bWasCompleted;
  public bool bSuppressSpawning;
  public bool bWasDeactivated;
  public bool bResetOnDetach;
  public bool bUpdateOnDedicatedServer;
  public bool bJustAttached;
  public bool bIsActive;
  public bool bIsCameraLensEffect;
  public bool bWarmingUp;
  public bool bIsCachedInPool;
  public bool bOverrideLODMethod;
  public bool bSkipUpdateDynamicDataDuringTick;
  public bool bUpdateComponentInTick;
  public bool bDeferredBeamUpdate;
  public bool bForcedInActive;
  public bool bIsWarmingUp;
  public bool bIsViewRelevanceDirty;
  public bool bRecacheViewRelevance;
  public bool bLODUpdatePending;
  public bool bSkipSpawnCountCheck;
  public bool bForceLODUpdateByDistance;
  public bool bForceUpdateWhenNotRendered;
  public List<FParticleSysParam> InstanceParameters;
  public FVector OldPosition = new();
  public FVector PartSysVelocity = new();
  public float WarmupTime;
  public int LODLevel;
  public float SecondsBeforeInactive;
  public float TimeSinceLastForceUpdateTransform;
  public float MaxTimeBeforeForceUpdateTransform;
  public int EditorLODLevel;
  public float AccumTickTime;
  public ParticleSystemLODMethod LODMethod;
  public ParticleReplayState ReplayState;
  public List<FMaterialViewRelevance> CachedViewRelevanceFlags;
  public List<UParticleSystemReplay> ReplayClips;
  public int ReplayClipIDNumber;
  public int ReplayFrameIndex;
  public float AccumLODDistanceCheckTime;
  public List<FParticleEventSpawnData> SpawnEvents;
  public List<FParticleEventDeathData> DeathEvents;
  public List<FParticleEventCollideData> CollisionEvents;
  public List<FParticleEventKismetData> KismetEvents;
  public FPointer ReleaseResourcesFence = new();
  public float CustomTimeDilation;
  public float EmitterDelay;
  public float TickTime;
  public FScriptDelegate __OnSystemFinished__Delegate;
}

public class AEmitter : AActor
{
  public class FCheckpointRecord
  {
    public bool bIsActive;
  }

  public UParticleSystemComponent ParticleSystemComponent;
  public UDynamicLightEnvironmentComponent LightEnvironment;
  public bool bDestroyOnSystemFinish;
  public bool bPostUpdateTickGroup;
  public bool bCurrentlyActive;
  public bool bForceUpdateLastRenderTime;
  public FVector InitialLocation = new();
  public FRotator InitialRotation = new();
}

public class AEmitterCameraLensEffectBase : AEmitter
{
  public UParticleSystem PS_CameraEffect;
  public UParticleSystem PS_CameraEffectNonExtremeContent;
  public float BaseFOV;
  public float DistFromCamera;
  public bool bAllowMultipleInstances;
  public ACamera BaseCamera;
}

public class AEmitterPool : AActor
{
  public class FEmitterBaseInfo
  {
    public UParticleSystemComponent PSC;
    public AActor Base;
    public UObject.FVector RelativeLocation = new();
    public UObject.FRotator RelativeRotation = new();
    public bool bInheritBaseScale;
  }

  public UParticleSystemComponent PSCTemplate;
  public List<UParticleSystemComponent> PoolComponents;
  public List<UParticleSystemComponent> ActiveComponents;
  public int MaxActiveEffects;
  public bool bLogPoolOverflow;
  public bool bLogPoolOverflowList;
  public List<FEmitterBaseInfo> RelativePSCs;
  public float SMC_MIC_ReductionTime;
  public float SMC_MIC_CurrentReductionTime;
  public int IdealStaticMeshComponents;
  public int IdealMaterialInstanceConstants;
  public List<UStaticMeshComponent> FreeSMComponents;
  public List<UMaterialInstanceConstant> FreeMatInstConsts;
}

public class AEmitterSpawnable : AEmitter
{
  public UParticleSystem ParticleTemplate;
}

public class UEngine : USubsystem
{
  public class FStatColorMapEntry
  {
    public float In;
    public UObject.FColor Out = new();
  }

  public class FStatColorMapping
  {
    public string StatName;
    public List<UEngine.FStatColorMapEntry> ColorMap;
    public bool DisableBlend;
  }

  public class FDropNoteInfo
  {
    public UObject.FVector Location = new();
    public UObject.FRotator Rotation = new();
    public string Comment;
  }

  public UFont TinyFont;
  public string TinyFontName;
  public UFont SmallFont;
  public string SmallFontName;
  public UFont MediumFont;
  public string MediumFontName;
  public UFont LargeFont;
  public string LargeFontName;
  public UFont SubtitleFont;
  public string SubtitleFontName;
  public List<UFont> AdditionalFonts;
  public List<string> AdditionalFontNames;
  public UClass ConsoleClass;
  public string ConsoleClassName;
  public UClass GameViewportClientClass;
  public string GameViewportClientClassName;
  public UClass DataStoreClientClass;
  public string DataStoreClientClassName;
  public UClass LocalPlayerClass;
  public string LocalPlayerClassName;
  public UMaterial DefaultMaterial;
  public string DefaultMaterialName;
  public UMaterial DefaultDecalMaterial;
  public string DefaultDecalMaterialName;
  public UTexture DefaultTexture;
  public string DefaultTextureName;
  public UMaterial WireframeMaterial;
  public string WireframeMaterialName;
  public UMaterial EmissiveTexturedMaterial;
  public string EmissiveTexturedMaterialName;
  public UMaterial GeomMaterial;
  public string GeomMaterialName;
  public UMaterial DefaultFogVolumeMaterial;
  public string DefaultFogVolumeMaterialName;
  public UMaterial TickMaterial;
  public string TickMaterialName;
  public UMaterial CrossMaterial;
  public string CrossMaterialName;
  public UMaterial LevelColorationLitMaterial;
  public string LevelColorationLitMaterialName;
  public UMaterial LevelColorationUnlitMaterial;
  public string LevelColorationUnlitMaterialName;
  public UMaterial LightingTexelDensityMaterial;
  public string LightingTexelDensityName;
  public UMaterial ShadedLevelColorationLitMaterial;
  public string ShadedLevelColorationLitMaterialName;
  public UMaterial ShadedLevelColorationUnlitMaterial;
  public string ShadedLevelColorationUnlitMaterialName;
  public UMaterial RemoveSurfaceMaterial;
  public string RemoveSurfaceMaterialName;
  public UMaterial VertexColorMaterial;
  public string VertexColorMaterialName;
  public UMaterial VertexColorViewModeMaterial_ColorOnly;
  public string VertexColorViewModeMaterialName_ColorOnly;
  public UMaterial VertexColorViewModeMaterial_AlphaAsColor;
  public string VertexColorViewModeMaterialName_AlphaAsColor;
  public UMaterial VertexColorViewModeMaterial_RedOnly;
  public string VertexColorViewModeMaterialName_RedOnly;
  public UMaterial VertexColorViewModeMaterial_GreenOnly;
  public string VertexColorViewModeMaterialName_GreenOnly;
  public UMaterial VertexColorViewModeMaterial_BlueOnly;
  public string VertexColorViewModeMaterialName_BlueOnly;
  public UMaterial HeatmapMaterial;
  public string HeatmapMaterialName;
  public UMaterial BoneWeightMaterial;
  public string BoneWeightMaterialName;
  public UMaterial TangentColorMaterial;
  public string TangentColorMaterialName;
  public UMaterial ProcBuildingSimpleMaterial;
  public string ProcBuildingSimpleMaterialName;
  public UMaterial PortalMaterial;
  public string PortalMaterialName;
  public UMaterial SolidFaceMaterial;
  public string SolidFaceMaterialName;
  public UStaticMesh BuildingQuadStaticMesh;
  public string BuildingQuadStaticMeshName;
  public float ProcBuildingLODColorTexelsPerWorldUnit;
  public float ProcBuildingLODLightingTexelsPerWorldUnit;
  public int MaxProcBuildingLODColorTextureSize;
  public int MaxProcBuildingLODLightingTextureSize;
  public bool UseProcBuildingLODTextureCropping;
  public bool ForcePowerOfTwoProcBuildingLODTextures;
  public bool bCombineSimilarMappings;
  public bool bRenderLightMapDensityGrayscale;
  public bool bUseSound;
  public bool bUseTextureStreaming;
  public bool bUseBackgroundLevelStreaming;
  public bool bSubtitlesEnabled;
  public bool bSubtitlesForcedOff;
  public bool bSmoothFrameRate;
  public bool HACK_UseTickFrequency;
  public bool bUseActorDetailMode;
  public bool bUseClothSimulation;
  public bool bUseUnrelevantDelay;
  public bool bCheckD3DDeviceChange;
  public bool bUseRelevantDelay;
  public bool bRepViaDOREPOnly;
  public bool bCollectNetworkChart;
  public bool bShouldGenerateSimpleLightmaps;
  public bool bForceStaticTerrain;
  public bool bMapObjectCountWritetoConfig;
  public bool bForceCPUSkinning;
  public bool bUsePostProcessEffects;
  public bool bOnScreenKismetWarnings;
  public bool bEnableKismetLogging;
  public bool bAllowMatureLanguage;
  public bool bRenderTerrainCollisionAsOverlay;
  public bool bDisablePhysXHardwareSupport;
  public bool bPauseOnLossOfFocus;
  public bool bCheckParticleRenderSize;
  public bool bEnableColorClear;
  public bool bAreConstraintsDirty;
  public bool bHasPendingGlobalReattach;
  public bool bUseMobileEmulation;
  public bool bEnableOnScreenDebugMessages;
  public bool bEnableOnScreenDebugMessagesDisplay;
  public bool bSuppressMapWarnings;
  public bool bCookSeparateSharedMPGameContent;
  public bool bDisableAILogging;
  public bool bNoWantTick;
  public float MaxRMSDForCombiningMappings;
  public FLinearColor LightingOnlyBrightness = new();
  public List<FColor> LightComplexityColors;
  public List<FLinearColor> ShaderComplexityColors;
  public float MaxPixelShaderAdditiveComplexityCount;
  public float MinTextureDensity;
  public float IdealTextureDensity;
  public float MaxTextureDensity;
  public float MinLightMapDensity;
  public float IdealLightMapDensity;
  public float MaxLightMapDensity;
  public float RenderLightMapDensityGrayscaleScale;
  public float RenderLightMapDensityColorScale;
  public FLinearColor LightMapDensityVertexMappedColor = new();
  public FLinearColor LightMapDensitySelectedColor = new();
  public List<FStatColorMapping> StatColorMappings;
  public UMaterial EditorBrushMaterial;
  public string EditorBrushMaterialName;
  public UPhysicalMaterial DefaultPhysMaterial;
  public string DefaultPhysMaterialName;
  public UMaterial TerrainErrorMaterial;
  public string TerrainErrorMaterialName;
  public int TerrainMaterialMaxTextureCount;
  public int TerrainTessellationCheckCount;
  public float TerrainTessellationCheckDistance;
  public UClass OnlineSubsystemClass;
  public string DefaultOnlineSubsystemName;
  public string DefaultOnlineSubsystemDediName;
  public UPostProcessChain DefaultPostProcess;
  public string DefaultPostProcessName;
  public string LowLevelPostProcessName;
  public UPostProcessChain ThumbnailSkeletalMeshPostProcess;
  public string ThumbnailSkeletalMeshPostProcessName;
  public UPostProcessChain ThumbnailParticleSystemPostProcess;
  public string ThumbnailParticleSystemPostProcessName;
  public UPostProcessChain ThumbnailMaterialPostProcess;
  public string ThumbnailMaterialPostProcessName;
  public UPostProcessChain DefaultUIScenePostProcess;
  public string DefaultUIScenePostProcessName;
  public UMaterial DefaultUICaretMaterial;
  public string DefaultUICaretMaterialName;
  public UMaterial SceneCaptureReflectActorMaterial;
  public string SceneCaptureReflectActorMaterialName;
  public UMaterial SceneCaptureCubeActorMaterial;
  public string SceneCaptureCubeActorMaterialName;
  public UTexture2D ScreenDoorNoiseTexture;
  public string ScreenDoorNoiseTextureName;
  public UTexture2D RandomAngleTexture;
  public string RandomAngleTextureName;
  public UTexture2D RandomNormalTexture;
  public string RandomNormalTextureName;
  public UTexture2D RandomMirrorDiscTexture;
  public string RandomMirrorDiscTextureName;
  public UTexture2D MLAA_Area33Texture;
  public string MLAA_Area33TextureName;
  public UTexture2D BeckMannTexture;
  public string BeckMannTextureName;
  public UTexture WeightMapPlaceholderTexture;
  public string WeightMapPlaceholderTextureName;
  public UTexture2D LightMapDensityTexture;
  public string LightMapDensityTextureName;
  public UTexture2D LightMapDensityNormal;
  public string LightMapDensityNormalName;
  public USoundNodeWave DefaultSound;
  public string DefaultSoundName;
  public float TimeBetweenPurgingPendingKillObjects;
  public UClient Client;
  public List<ULocalPlayer> GamePlayers;
  public UGameViewportClient GameViewport;
  public List<string> DeferredCommands;
  public int TickCycles;
  public int GameCycles;
  public int ClientCycles;
  public UTranslationContext GlobalTranslationContext;
  public float MaxSmoothedFrameRate;
  public float MinSmoothedFrameRate;
  public UDebugManager DebugManager;
  public FPointer RemoteControlExec = new();
  public FPointer MobileMaterialEmulator = new();
  public FColor C_WorldBox = new();
  public FColor C_BrushWire = new();
  public FColor C_AddWire = new();
  public FColor C_SubtractWire = new();
  public FColor C_SemiSolidWire = new();
  public FColor C_NonSolidWire = new();
  public FColor C_WireBackground = new();
  public FColor C_ScaleBoxHi = new();
  public FColor C_VolumeCollision = new();
  public FColor C_BSPCollision = new();
  public FColor C_OrthoBackground = new();
  public FColor C_Volume = new();
  public FColor C_BrushShape = new();
  public float StreamingDistanceFactor;
  public string ScoutClassName;
  public ETransitionType TransitionType;
  public string TransitionDescription;
  public string TransitionGameType;
  public float TransitionLoadingProgress;
  public float MeshLODRange;
  public float CameraRotationThreshold;
  public float CameraTranslationThreshold;
  public float PrimitiveProbablyVisibleTime;
  public float PercentUnoccludedRequeries;
  public float MaxOcclusionPixelsFraction;
  public int MaxFluidNumVerts;
  public float FluidSimulationTimeLimit;
  public int MaxParticleResize;
  public int MaxParticleResizeWarn;
  public int MaxParticleVertexMemory;
  public int MaxParticleSpriteCount;
  public int MaxParticleSubUVCount;
  public int BeginUPTryCount;
  public List<FDropNoteInfo> PendingDroppedNotes;
  public string DynamicCoverMeshComponentName;
  public float NetClientTicksPerSecond;
  public float MaxTrackedOcclusionIncrement;
  public float TrackedOcclusionStepSize;
  public FLinearColor DefaultSelectedMaterialColor = new();
  public FLinearColor SelectedMaterialColor = new();
  public FLinearColor UnselectedMaterialColor = new();
  public List<FName> IgnoreSimulatedFuncWarnings;
}

public partial class UEngineTypes : UObject
{
  public class FSubtitleCue
  {
    public string Text;
    public float Time;
    public string MapName;
  }

  public class FLocalizedSubtitle
  {
    public List<UEngineTypes.FSubtitleCue> Subtitles;
    public bool bMature;
    public bool bManualWordWrap;
  }

  public class FDominantShadowInfo
  {
    public UObject.FMatrix WorldToLight = new();
    public UObject.FMatrix LightToWorld = new();
    public UObject.FBox LightSpaceImportanceBounds = new();
    public int ShadowMapSizeX;
    public int ShadowMapSizeY;
  }

  public class FLightmassLightSettings
  {
    public float IndirectLightingScale;
    public float IndirectLightingSaturation;
    public float ShadowExponent;
  }

  public class FLightmassPointLightSettings : FLightmassLightSettings
  {
    public float LightSourceRadius;
  }

  public class FLightmassDirectionalLightSettings : FLightmassLightSettings
  {
    public float LightSourceAngle;
  }

  public class FLightmassPrimitiveSettings
  {
    public bool bUseTwoSidedLighting;
    public bool bShadowIndirectOnly;
    public bool bUseEmissiveForStaticLighting;
    public float EmissiveLightFalloffExponent;
    public float EmissiveLightExplicitInfluenceRadius;
    public float EmissiveBoost;
    public float DiffuseBoost;
    public float SpecularBoost;
    public float FullyOccludedSamplesFraction;
  }

  public class FLightmassDebugOptions
  {
    public bool bDebugMode;
    public bool bStatsEnabled;
    public bool bGatherBSPSurfacesAcrossComponents;
    public float CoplanarTolerance;
    public bool bUseDeterministicLighting;
    public bool bUseImmediateImport;
    public bool bImmediateProcessMappings;
    public bool bSortMappings;
    public bool bDumpBinaryFiles;
    public bool bDebugMaterials;
    public bool bPadMappings;
    public bool bDebugPaddings;
    public bool bOnlyCalcDebugTexelMappings;
    public bool bUseRandomColors;
    public bool bColorBordersGreen;
    public bool bColorByExecutionTime;
    public float ExecutionTimeDivisor;
    public bool bInitialized;
  }

  public class FSwarmDebugOptions
  {
    public bool bDistributionEnabled;
    public bool bForceContentExport;
    public bool bInitialized;
  }

  public class FRootMotionCurve
  {
    public FName AnimName;
    public UObject.FInterpCurveVector Curve = new();
    public float MaxCurveTime;
  }

  public class FPrimitiveMaterialRef
  {
    public UPrimitiveComponent Primitive;
    public int MaterialIndex;
  }

  public class FMaterialReferenceList
  {
    public UMaterialInterface TargetMaterial;
    public List<UEngineTypes.FPrimitiveMaterialRef> AffectedMaterialRefs;
  }

  public class FVelocityObstacleStat
  {
    public UObject.FVector Position = new();
    public UObject.FVector Velocity = new();
    public float Radius;
    public int Priority;
  }

  public partial class FQuantizedDirectionalLightSampleBulkData : FUntypedBulkData_Mirror
  {
  }

  public partial class FQuantizedSimpleLightSampleBulkData : FUntypedBulkData_Mirror
  {
  }

  public partial class FLightMap : ISerialisable
  {
    public UObject.FVector2D CoordinateBias = new();
    public UObject.FVector2D CoordinateScale = new();
    public UEngineTypes.FQuantizedDirectionalLightSampleBulkData DirectionalSamples = new();
    public List<UObject.FGuid> LightGuids;
    public uint LightMapType;
    public UObject Owner;
    public UObject.FVector4[] ScaleVectors = new UObject.FVector4[3];
    public UEngineTypes.FQuantizedSimpleLightSampleBulkData SimpleSamples = new();
    public ULightMapTexture2D[] Textures = new ULightMapTexture2D[3];
  }

  public class FBasedPosition
  {
    public AActor Base;
    public UObject.FVector Position = new();
  }

}

public class AEnvironmentVolume : AVolume
{
  public FPointer VfTable_IInterface_NavMeshPathObstacle = new();
  public FPointer VfTable_IInterface_NavMeshPathObject = new();
  public bool bSplitNavMesh;
}

public class UExponentialHeightFogComponent : UActorComponent
{
  public bool bEnabled;
  public float FogHeight;
  public float FogDensity;
  public float FogHeightFalloff;
  public float LightTerminatorAngle;
  public float OppositeLightBrightness;
  public FColor OppositeLightColor = new();
  public float LightInscatteringBrightness;
  public FColor LightInscatteringColor = new();
}

public class AExponentialHeightFog : AInfo
{
  public UExponentialHeightFogComponent Component;
  public bool bEnabled;
}

public class UFaceFXAnimSet : UObject
{
  public UFaceFXAsset DefaultFaceFXAsset;
  public FPointer InternalFaceFXAnimSet = new();
  public List<byte> RawFaceFXAnimSetBytes;
  public List<byte> RawFaceFXMiniSessionBytes;
  public List<USoundCue> ReferencedSoundCues;
  public int NumLoadErrors;
}

public class UFaceFXAsset : UObject
{
  public USkeletalMesh DefaultSkelMesh;
  public FPointer FaceFXActor = new();
  public List<byte> RawFaceFXActorBytes;
  public List<byte> RawFaceFXSessionBytes;
  public List<UMorphTargetSet> PreviewMorphSets;
  public List<UFaceFXAnimSet> MountedFaceFXAnimSets;
  public List<USoundCue> ReferencedSoundCues;
  public int NumLoadErrors;
}

public class ULocalMessage : UObject
{
  public bool bIsSpecial;
  public bool bIsUnique;
  public bool bIsPartiallyUnique;
  public bool bIsConsoleMessage;
  public bool bBeep;
  public bool bCountInstances;
  public float Lifetime;
  public FColor DrawColor = new();
  public float PosY;
  public int FontSize;
  public int HudDrawType;
}

public class UFailedConnect : ULocalMessage
{
  public string[] FailMessage = new string[4];
}

public class AFileWriter : AInfo
{
  public FPointer ArchivePtr = new();
  public string Filename;
  public FWFileType FileType;
  public bool bFlushEachWrite;
  public bool bWantsAsyncWrites;
}

public class AFileLog : AFileWriter
{
}

public class UFloorToCeilingReachSpec : UForcedReachSpec
{
}

public class UFluidInfluenceComponent : UPrimitiveComponent
{
  public bool bActive;
  public bool RaindropFillEntireFluid;
  public bool bIsToggleTriggered;
  public AFluidSurfaceActor FluidActor;
  public EInfluenceType InfluenceType;
  public float MaxDistance;
  public float WaveStrength;
  public float WaveFrequency;
  public float WavePhase;
  public float WaveRadius;
  public float RaindropAreaRadius;
  public float RaindropRadius;
  public float RaindropStrength;
  public float RaindropRate;
  public float FlowSpeed;
  public int FlowNumRipples;
  public float FlowSideMotionRadius;
  public float FlowWaveRadius;
  public float FlowStrength;
  public float FlowFrequency;
  public float SphereOuterRadius;
  public float SphereInnerRadius;
  public float SphereStrength;
  public float CurrentAngle;
  public float CurrentTimer;
  public AFluidSurfaceActor CurrentFluidActor;
}

public class AFluidInfluenceActor : AActor
{
  public UArrowComponent FlowDirection;
  public USpriteComponent Sprite;
  public UFluidInfluenceComponent InfluenceComponent;
  public bool bActive;
  public bool bToggled;
}

public partial class UFluidSurfaceComponent : UPrimitiveComponent
{
  public class FLightMapRef
  {
    public UObject.FPointer Reference = new();
  }

  public UMaterialInterface FluidMaterial;
  public int LightMapResolution;
  public UEngineTypes.FLightmassPrimitiveSettings LightmassSettings = new();
  public bool EnableSimulation;
  public bool EnableDetail;
  public bool bPause;
  public bool bShowSimulationNormals;
  public bool bShowSimulationPosition;
  public bool bShowDetailNormals;
  public bool bShowDetailPosition;
  public bool bShowFluidSimulation;
  public bool bShowFluidDetail;
  public bool bTestRipple;
  public bool bTestRippleCenterOnDetail;
  public int SimulationQuadsX;
  public int SimulationQuadsY;
  public float GridSpacing;
  public float GridSpacingLowRes;
  public AActor TargetSimulation;
  public float GPUTessellationFactor;
  public float FluidDamping;
  public float FluidTravelSpeed;
  public float FluidHeightScale;
  public float FluidUpdateRate;
  public float ForceImpact;
  public float ForceContinuous;
  public float LightingContrast;
  public AActor TargetDetail;
  public float DeactivationDistance;
  public int DetailResolution;
  public float DetailSize;
  public float DetailDamping;
  public float DetailTravelSpeed;
  public float DetailTransfer;
  public float DetailHeightScale;
  public float DetailUpdateRate;
  public float NormalLength;
  public float TestRippleSpeed;
  public float TestRippleFrequency;
  public float TestRippleRadius;
  public float FluidWidth;
  public float FluidHeight;
  public float TestRippleTime;
  public float TestRippleAngle;
  public float DeactivationTimer;
  public float ViewDistance;
  public FVector SimulationPosition = new();
  public FVector DetailPosition = new();
  public List<byte> ClampMap;
  public List<UShadowMap2D> ShadowMaps;
  public UEngineTypes.FLightMap LightMap = new();
  public FPointer FluidSimulation = new();
}

public class AFluidSurfaceActor : AActor
{
  public UFluidSurfaceComponent FluidComponent;
  public UParticleSystem ProjectileEntryEffect;
}

public class AFluidSurfaceActorMovable : AFluidSurfaceActor
{
}

public class UFogVolumeDensityComponent : UActorComponent
{
  public UMaterialInterface FogMaterial;
  public UMaterialInterface DefaultFogVolumeMaterial;
  public bool bEnabled;
  public bool bAffectsTranslucency;
  public FLinearColor SimpleLightColor = new();
  public FLinearColor ApproxFogLightColor = new();
  public float StartDistance;
  public List<AActor> FogVolumeActors;
}

public class UFogVolumeConeDensityComponent : UFogVolumeDensityComponent
{
  public float MaxDensity;
  public FVector ConeVertex = new();
  public float ConeRadius;
  public FVector ConeAxis = new();
  public float ConeMaxAngle;
  public UDrawLightConeComponent PreviewCone;
}

public class AFogVolumeDensityInfo : AInfo
{
  public class FCheckpointRecord
  {
    public bool bEnabled;
  }

  public UFogVolumeDensityComponent DensityComponent;
  public UStaticMeshComponent AutomaticMeshComponent;
  public bool bEnabled;
}

public class AFogVolumeConeDensityInfo : AFogVolumeDensityInfo
{
}

public class UFogVolumeConstantDensityComponent : UFogVolumeDensityComponent
{
  public float Density;
}

public class AFogVolumeConstantDensityInfo : AFogVolumeDensityInfo
{
}

public class UFogVolumeLinearHalfspaceDensityComponent : UFogVolumeDensityComponent
{
  public float PlaneDistanceFactor;
  public FPlane HalfspacePlane = new();
}

public class AFogVolumeLinearHalfspaceDensityInfo : AFogVolumeDensityInfo
{
}

public class UFogVolumeSphericalDensityComponent : UFogVolumeDensityComponent
{
  public float MaxDensity;
  public FVector SphereCenter = new();
  public float SphereRadius;
  public UDrawLightRadiusComponent PreviewSphereRadius;
}

public class AFogVolumeSphericalDensityInfo : AFogVolumeDensityInfo
{
}

public class UFoliageComponent : UPrimitiveComponent
{
  public class FFoliageInstanceBase
  {
    public UObject.FVector Location = new();
    public UObject.FVector XAxis = new();
    public UObject.FVector YAxis = new();
    public UObject.FVector ZAxis = new();
    public float DistanceFactorSquared;
  }

  public class FStoredFoliageInstance : FFoliageInstanceBase
  {
    public UObject.FColor[] StaticLighting = new UObject.FColor[3];
  }

  public List<FStoredFoliageInstance> LitInstances;
  public List<FGuid> StaticallyRelevantLights;
  public List<FGuid> StaticallyIrrelevantLights;
  public float[] DirectionalStaticLightingScale = new float[3];
  public float[] SimpleStaticLightingScale = new float[3];
  public UStaticMesh InstanceStaticMesh;
  public UMaterialInterface Material;
  public float MaxDrawRadius;
  public float MinTransitionRadius;
  public float MinThinningRadius;
  public FVector MinScale = new();
  public FVector MaxScale = new();
  public float SwayScale;
  public UEngineTypes.FLightmassPrimitiveSettings LightmassSettings = new();
}

public class AFoliageFactory : AVolume
{
  public class FFoliageMesh
  {
    public UStaticMesh InstanceStaticMesh;
    public UMaterialInterface Material;
    public float MaxDrawRadius;
    public float MinTransitionRadius;
    public float MinThinningRadius;
    public UObject.FVector MinScale = new();
    public UObject.FVector MaxScale = new();
    public float MinUniformScale;
    public float MaxUniformScale;
    public float SwayScale;
    public int Seed;
    public float SurfaceAreaPerInstance;
    public bool bCreateInstancesOnBSP;
    public bool bCreateInstancesOnStaticMeshes;
    public bool bCreateInstancesOnTerrain;
    public UEngineTypes.FLightmassPrimitiveSettings LightmassSettings = new();
    public UFoliageComponent Component;
  }

  public List<FFoliageMesh> Meshes;
  public float VolumeFalloffRadius;
  public float VolumeFalloffExponent;
  public float SurfaceDensityUpFacing;
  public float SurfaceDensityDownFacing;
  public float SurfaceDensitySideFacing;
  public float FacingFalloffExponent;
  public int MaxInstanceCount;
}

public class UForceFeedbackManager : UObject
{
  public bool bAllowsForceFeedback;
  public bool bIsPaused;
  public UForceFeedbackWaveform FFWaveform;
  public int CurrentSample;
  public float ElapsedTime;
  public float ScaleAllWaveformsBy;
}

public class UForceFeedbackWaveform : UObject
{
  public class FWaveformSample
  {
    public byte LeftAmplitude;
    public byte RightAmplitude;
    public EWaveformFunction LeftFunction;
    public EWaveformFunction RightFunction;
    public float Duration;
  }

  public bool bIsLooping;
  public List<FWaveformSample> Samples;
}

public class UForceFieldShape : UObject
{
}

public class UForceFieldShapeBox : UForceFieldShape
{
  public UDrawBoxComponent Shape;
}

public class UForceFieldShapeCapsule : UForceFieldShape
{
  public UDrawCapsuleComponent Shape;
}

public class UForceFieldShapeSphere : UForceFieldShape
{
  public UDrawSphereComponent Shape;
}

public class UFracturedBaseComponent : UStaticMeshComponent
{
  public FPointer ComponentBaseResources = new();
  public FRenderCommandFence_Mirror ReleaseResourcesFence = new();
  public List<byte> VisibleFragments;
  public bool bVisibilityHasChanged;
  public bool bVisibilityReset;
  public bool bInitialVisibilityValue;
  public bool bUseDynamicIndexBuffer;
  public bool bUseDynamicIBWithHiddenFragments;
  public int NumResourceIndices;
  public int ComponentIndexBufferSize;
  public int bResetStaticMesh;
}

public class UFracturedSkinnedMeshComponent : UFracturedBaseComponent
{
  public FPointer ComponentSkinResources = new();
  public List<FMatrix> FragmentTransforms;
  public List<UFracturedStaticMeshComponent> DependentComponents;
  public bool bBecameVisible;
  public bool bFragmentTransformsChanged;
}

public class UFracturedStaticMeshComponent : UFracturedBaseComponent
{
  public class FFragmentGroup
  {
    public List<int> FragmentIndices;
    public bool bGroupIsRooted;
  }

  public List<byte> FragmentNeighborsVisible;
  public FBox VisibleBox = new();
  public bool bUseSkinnedRendering;
  public bool bUseVisibleVertsForBounds;
  public bool bTopFragmentsRootNonDestroyable;
  public bool bBottomFragmentsRootNonDestroyable;
  public float TopBottomFragmentDistThreshold;
  public UMaterialInterface LoseChunkOutsideMaterialOverride;
  public float FragmentBoundsMaxZ;
  public float FragmentBoundsMinZ;
  public UFracturedSkinnedMeshComponent SkinnedComponent;
}

public class AFracturedStaticMeshActor : AActor
{
  public class FDeferredPartToSpawn
  {
    public int ChunkIndex;
    public UObject.FVector InitialVel = new();
    public UObject.FVector InitialAngVel = new();
    public float RelativeScale;
    public bool bExplosion;
  }

  public int MaxPartsToSpawnAtOnce;
  public UFracturedStaticMeshComponent FracturedStaticMeshComponent;
  public UFracturedSkinnedMeshComponent SkinnedComponent;
  public List<int> ChunkHealth;
  public bool bHasShownMissingSoundWarning;
  public bool bBreakChunksOnActorTouch;
  public List<UClass> FracturedByDamageType;
  public float ChunkHealthScale;
  public List<UParticleSystem> OverrideFragmentDestroyEffects;
  public float FractureCullMinDistance;
  public float FractureCullMaxDistance;
  public List<FDeferredPartToSpawn> DeferredPartsToSpawn;
  public FPhysEffectInfo PartImpactEffect = new();
  public USoundCue ExplosionFractureSound;
  public USoundCue SingleChunkFractureSound;
  public UMaterialInterface MI_LoseChunkPreviousMaterial;
}

public class AFracturedSMActorSpawnable : AFracturedStaticMeshActor
{
}

public class AFracturedStaticMeshPart : AFracturedStaticMeshActor
{
  public float DestroyPartRadiusFactor;
  public AFracturedStaticMeshActor BaseFracturedMeshActor;
  public bool bHasBeenRecycled;
  public bool bChangeRBChannelWhenAsleep;
  public bool bCompositeThatExplodesOnImpact;
  public float LastSpawnTime;
  public int PartPoolIndex;
  public float FracPartGravScale;
  public ERBCollisionChannel AsleepRBChannel;
  public FVector OldVelocity = new();
  public float CurrentVibrationLevel;
  public float LastImpactSoundTime;
}

public class AFractureManager : AActor
{
  public int FSMPartPoolSize;
  public bool bEnableAntiVibration;
  public bool bEnableSpawnChunkEffectForRadialDamage;
  public float DestroyVibrationLevel;
  public float DestroyMinAngVel;
  public float ExplosionVelScale;
  public List<AFracturedStaticMeshPart> PartPool;
  public List<int> FreeParts;
  public List<AFracturedStaticMeshActor> ActorsWithDeferredPartsToSpawn;
}

public class UGameEngine : UEngine
{
  public class FFullyLoadedPackagesInfo
  {
    public EFullyLoadPackageType FullyLoadType;
    public string Tag;
    public List<FName> PackagesToLoad;
    public List<UObject> LoadedObjects;
  }

  public class FNamedNetDriver
  {
    public FName NetDriverName;
    public UObject.FPointer NetDriver = new();
  }

  public class FLevelStreamingStatus
  {
    public FName PackageName;
    public bool bShouldBeLoaded;
    public bool bShouldBeVisible;
  }

  public class FURL
  {
    public string Protocol;
    public string Host;
    public int Port;
    public string Map;
    public List<string> Op;
    public string Portal;
    public int Valid;
    public string ServerIP;
    public int ServerPort;
    public bool bUseRelayServer;
    public string RelayServerIP;
    public int RelayServerPort;
    public string ClanServerIP;
    public int ClanServerPort;
    public string ClanBaseURL;
    public string MessengerServerIP;
    public int MessengerServerPort;
  }

  public UPendingLevel GPendingLevel;
  public string PendingLevelPlayerControllerClassName;
  public FURL LastURL = new();
  public FURL LastRemoteURL = new();
  public List<string> ServerActors;
  public string TravelURL;
  public byte TravelType;
  public bool bWorldWasLoadedThisTick;
  public bool bShouldCommitPendingMapChange;
  public bool bClearAnimSetLinkupCachesOnLoadMap;
  public bool bIndependentLoadMap;
  public UOnlineSubsystem OnlineSubsystem;
  public List<FName> LevelsToLoadForPendingMapChange;
  public List<ULevel> LoadedLevelsForPendingMapChange;
  public string PendingMapChangeFailureDescription;
  public float MaxDeltaTime;
  public List<FLevelStreamingStatus> PendingLevelStreamingStatusUpdates;
  public List<UObjectReferencer> ObjectReferencers;
  public List<FFullyLoadedPackagesInfo> PackagesToFullyLoad;
  public List<FNamedNetDriver> NamedNetDrivers;
}

public class AGameInfo : AInfo
{
  public class FGameClassShortName
  {
    public string ShortName;
    public string GameClassName;
  }

  public class FGameTypePrefix
  {
    public string Prefix;
    public bool bUsesCommonPackage;
    public string GameType;
    public List<string> AdditionalGameTypes;
    public List<string> ForcedObjects;
  }

  public bool bRestartLevel;
  public bool bPauseable;
  public bool bTeamGame;
  public bool bGameEnded;
  public bool bOverTime;
  public bool bDelayedStart;
  public bool bWaitingToStartMatch;
  public bool bChangeLevels;
  public bool bAlreadyChanged;
  public bool bAdminCanPause;
  public bool bGameRestarted;
  public bool bLevelChange;
  public bool bKickLiveIdlers;
  public bool bUsingArbitration;
  public bool bHasArbitratedHandshakeBegun;
  public bool bNeedsEndGameHandshake;
  public bool bIsEndGameHandshakeComplete;
  public bool bHasEndGameHandshakeBegun;
  public bool bFixedPlayerStart;
  public bool bDoFearCostFallOff;
  public bool bUseSeamlessTravel;
  public bool bHasNetworkError;
  public bool bRequiresPushToTalk;
  public bool bIsStandbyCheckingEnabled;
  public bool bHasStandbyCheatTriggered;
  public string CauseEventCommand;
  public string BugLocString;
  public string BugRotString;
  public List<APlayerController> PendingArbitrationPCs;
  public List<APlayerController> ArbitrationPCs;
  public float ArbitrationHandshakeTimeout;
  public float GameDifficulty;
  public int GoreLevel;
  public float GameSpeed;
  public UClass DefaultPawnClass;
  public UClass ScoreBoardType;
  public UClass HUDType;
  public int MaxSpectators;
  public int MaxSpectatorsAllowed;
  public int NumSpectators;
  public int MaxPlayers;
  public int MaxPlayersAllowed;
  public int NumPlayers;
  public int NumBots;
  public int NumTravellingPlayers;
  public int CurrentID;
  public string DefaultPlayerName;
  public string GameName;
  public float FearCostFallOff;
  public int GoalScore;
  public int MaxLives;
  public float TimeLimit;
  public UClass DeathMessageClass;
  public UClass GameMessageClass;
  public AMutator BaseMutator;
  public UClass AccessControlClass;
  public AAccessControl AccessControl;
  public UClass BroadcastHandlerClass;
  public ABroadcastHandler BroadcastHandler;
  public UClass AutoTestManagerClass;
  public AAutoTestManager MyAutoTestManager;
  public UClass PlayerControllerClass;
  public UClass PlayerReplicationInfoClass;
  public UClass GameReplicationInfoClass;
  public AGameReplicationInfo GameReplicationInfo;
  public float MaxIdleTime;
  public float MaxTimeMargin;
  public float TimeMarginSlack;
  public float MinTimeMargin;
  public List<APlayerReplicationInfo> InactivePRIArray;
  public List<FScriptDelegate> Pausers;
  public UOnlineSubsystem OnlineSub;
  public FScriptInterface GameInterface;
  public UClass OnlineStatsWriteClass;
  public int LeaderboardId;
  public int ArbitratedLeaderboardId;
  public ACoverReplicator CoverReplicatorBase;
  public UClass OnlineGameSettingsClass;
  public string ServerOptions;
  public int AdjustedNetSpeed;
  public float LastNetSpeedUpdateTime;
  public int TotalNetBandwidth;
  public int MinDynamicBandwidth;
  public int MaxDynamicBandwidth;
  public float StandbyRxCheatTime;
  public float StandbyTxCheatTime;
  public int BadPingThreshold;
  public float PercentMissingForRxStandby;
  public float PercentMissingForTxStandby;
  public float PercentForBadPing;
  public List<FGameClassShortName> GameInfoClassAliases;
  public string DefaultGameType;
  public List<FGameTypePrefix> DefaultMapPrefixes;
  public List<FGameTypePrefix> CustomMapPrefixes;
  public UGameplayEventsWriter GameplayEventsWriter;
  public FScriptDelegate __CanUnpause__Delegate;
}

public class UGameInfoDataProvider : UUIDynamicDataProvider
{
  public AGameReplicationInfo GameDataSource;
}

public class UGameMessage : ULocalMessage
{
  public string SwitchLevelMessage;
  public string LeftMessage;
  public string FailedTeamMessage;
  public string FailedPlaceMessage;
  public string FailedSpawnMessage;
  public string EnteredMessage;
  public string MaxedOutMessage;
  public string ArbitrationMessage;
  public string OvertimeMessage;
  public string GlobalNameChange;
  public string NewTeamMessage;
  public string NewTeamMessageTrailer;
  public string NoNameChange;
  public string VoteStarted;
  public string VotePassed;
  public string MustHaveStats;
  public string CantBeSpectator;
  public string CantBePlayer;
  public string BecameSpectator;
  public string NewPlayerMessage;
  public string KickWarning;
  public string NewSpecMessage;
  public string SpecEnteredMessage;
}

public class UGameplayEvents : UObject
{
  public class FGameplayEventsHeader
  {
    public int EngineVersion;
    public int StatsWriterVersion;
    public int StreamOffset;
    public int FooterOffset;
    public int TotalStreamSize;
    public int FileSize;
  }

  public class FGameSessionInformation
  {
    public int AppTitleID;
    public int PlatformType;
    public string Language;
    public string GameplaySessionTimestamp;
    public float GameplaySessionStartTime;
    public float GameplaySessionEndTime;
    public bool bGameplaySessionInProgress;
    public string GameplaySessionID;
    public string GameClassName;
    public string MapName;
    public string MapURL;
  }

  public class FTeamInformation
  {
    public int TeamIndex;
    public string TeamName;
    public UObject.FColor TeamColor = new();
    public int MaxSize;
  }

  public class FPlayerInformationNew
  {
    public string ControllerName;
    public string PlayerName;
    public UOnlineSubsystem.FUniqueNetId UniqueId = new();
    public string UniqueIdHash;
    public bool bIsBot;
    public byte TeamIndex;
  }

  public class FGameplayEventMetaData
  {
    public int EventID;
    public FName EventName;
    public EPropertyValueMappingType MappingType;
    public int MaxValue;
  }

  public class FWeaponClassEventData
  {
    public string WeaponClassName;
  }

  public class FDamageClassEventData
  {
    public string DamageClassName;
  }

  public class FProjectileClassEventData
  {
    public string ProjectileClassName;
  }

  public class FPawnClassEventData
  {
    public string PawnClassName;
  }

  public FPointer Archive = new();
  public string StatsFileName;
  public FGameplayEventsHeader Header = new();
  public FGameSessionInformation CurrentSessionInfo = new();
  public List<FPlayerInformationNew> PlayerList;
  public List<FTeamInformation> TeamList;
  public List<FGameplayEventMetaData> SupportedEvents;
  public List<FWeaponClassEventData> WeaponClassArray;
  public List<FDamageClassEventData> DamageClassArray;
  public List<FProjectileClassEventData> ProjectileClassArray;
  public List<FPawnClassEventData> PawnClassArray;
  public List<string> ActorArray;
  public List<string> SoundCueArray;
}

public class UGameplayEventsReader : UGameplayEvents
{
  public List<int> EventIDFilter;
}

public class UGameplayEventsWriter : UGameplayEvents
{
  public AGameInfo Game;
}

public class AGameReplicationInfo : AReplicationInfo
{
  public UClass GameClass;
  public UCurrentGameDataStore CurrentGameData;
  public bool bStopCountDown;
  public bool bMatchHasBegun;
  public bool bMatchIsOver;
  public bool bNeedProjectedLocation;
  public int RemainingTime;
  public int ElapsedTime;
  public int RemainingMinute;
  public int GoalScore;
  public float TimeLimit;
  public List<ATeamInfo> Teams;
  public string ServerName;
  public AActor Winner;
  public List<APlayerReplicationInfo> PRIArray;
  public List<APlayerReplicationInfo> InactivePRIArray;
}

public class UUISceneClient : UUIRoot
{
  public FPointer VfTable_FExec = new();
  public FPointer RenderViewport = new();
  public UUISkin ActiveSkin;
  public FIntPoint MousePosition = new();
  public UUIObject ActiveControl;
  public UDataStoreClient DataStoreManager;
  public UMaterialInstanceConstant OpacityParameter;
  public FName OpacityParameterName;
  public FMatrix CanvasToScreen = new();
  public FMatrix InvCanvasToScreen = new();
  public UPostProcessChain UIScenePostProcess;
  public bool bEnablePostProcess;
}

public class UGameUISceneClient : UUISceneClient
{
  public List<UUIScene> ActiveScenes;
  public UUITexture CurrentMouseCursor;
  public bool bRenderCursor;
  public bool bUpdateInputProcessingStatus;
  public bool bUpdateCursorRenderStatus;
  public bool bUpdateSceneViewportSizes;
  public bool bEnableDebugInput;
  public bool bRenderDebugInfo;
  public bool bRenderDebugInfoAtTop;
  public bool bRenderActiveControlInfo;
  public bool bRenderFocusedControlInfo;
  public bool bRenderTargetControlInfo;
  public bool bSelectVisibleTargetsOnly;
  public bool bInteractiveMode;
  public bool bDisplayFullPaths;
  public bool bShowWidgetPath;
  public bool bShowRenderBounds;
  public bool bShowCurrentState;
  public bool bShowMousePos;
  public bool bRestrictActiveControlToFocusedScene;
  public bool bCaptureUnprocessedInput;
  public bool bSynchronizePlayers;
  public bool bKillRestoreMenuProgression;
  public bool bDebugResolveScene;
  public bool bBlockSceneUpdates;
  public bool bBlockUpdatesAfterStackModification;
  public float LatestDeltaTime;
  public double DoubleClickStartTime = new();
  public FIntPoint DoubleClickStartPosition = new();
  public UTexture[] DefaultUITexture = new UTexture[3];
  public FMap_Mirror InitialPressedKeys = new();
  public UClass MessageBoxClass;
  public float OverlaySceneAlphaModulation;
  public UUIScreenObject DebugTarget;
  public List<UUIAnimationSeq> AnimSequencePool;
  public List<FName> NavAliases;
  public List<FName> AxisInputKeys;
}

public class UGameViewportClient : UObject
{
  public class FPerPlayerSplitscreenData
  {
    public float SizeX;
    public float SizeY;
    public float OriginX;
    public float OriginY;
  }

  public class FSplitscreenData
  {
    public List<UGameViewportClient.FPerPlayerSplitscreenData> PlayerData;
  }

  public class FDebugDisplayProperty
  {
    public UObject Obj;
    public FName PropertyName;
    public bool bSpecialProperty;
  }

  public class FShowFlags_Mirror
  {
    public ulong flags0 = new();
    public ulong flags1 = new();
  }

  public class FExportShowFlags_Mirror : FShowFlags_Mirror
  {
  }

  public class FTitleSafeZoneArea
  {
    public float MaxPercentX;
    public float MaxPercentY;
    public float RecommendedPercentX;
    public float RecommendedPercentY;
  }

  public FPointer VfTable_FViewportClient = new();
  public FPointer VfTable_FExec = new();
  public FPointer Viewport = new();
  public FPointer ViewportFrame = new();
  public List<UInteraction> GlobalInteractions;
  public UClass UIControllerClass;
  public UUIInteraction UIController;
  public UConsole ViewportConsole;
  public FExportShowFlags_Mirror ShowFlags = new();
  public string LoadingMessage;
  public string SavingMessage;
  public string ConnectingMessage;
  public string PausedMessage;
  public string PrecachingMessage;
  public bool bShowTitleSafeZone;
  public bool bDisplayHardwareMouseCursor;
  public bool bDisplayingUIMouseCursor;
  public bool bUIMouseCaptureOverride;
  public bool bOverrideDiffuseAndSpecular;
  public bool bSeparateSpecular;
  public bool bDisableWorldRendering;
  public bool bCapturedWorldRendering;
  public bool bDebugNoGFxUI;
  public FTitleSafeZoneArea TitleSafeZone = new();
  public List<FSplitscreenData> SplitscreenInfo;
  public ESplitScreenType DesiredSplitscreenType;
  public ESplitScreenType ActiveSplitscreenType;
  public ESplitScreenType Default2PSplitType;
  public ESplitScreenType Default3PSplitType;
  public string[] ProgressMessage = new string[2];
  public float ProgressTimeOut;
  public float ProgressFadeTime;
  public List<FDebugDisplayProperty> DebugProperties;
  public FPointer ScaleformInteraction = new();
  public FScriptDelegate __HandleInputKey__Delegate;
  public FScriptDelegate __HandleInputAxis__Delegate;
  public FScriptDelegate __HandleInputChar__Delegate;
}

public class AGeneratedMeshAreaLight : ASpotLight
{
}

public class UGenericParamListStatEntry : UObject
{
  public FPointer StatEvent = new();
  public UGameplayEventsWriter Writer;
}

public class UPathGoalEvaluator : UObject
{
  public UPathGoalEvaluator NextEvaluator;
  public ANavigationPoint GeneratedGoal;
  public int MaxPathVisits;
  public int CacheIdx;
}

public class UGoal_AtActor : UPathGoalEvaluator
{
  public AActor GoalActor;
  public float GoalDist;
  public bool bKeepPartial;
}

public class UGoal_Null : UPathGoalEvaluator
{
}

public class AGravityVolume : APhysicsVolume
{
  public float GravityZ;
}

public class UHeightFogComponent : UActorComponent
{
  public bool bEnabled;
  public float Height;
  public float Density;
  public float LightBrightness;
  public FColor LightColor = new();
  public float ExtinctionDistance;
  public float StartDistance;
}

public class AHeightFog : AInfo
{
  public UHeightFogComponent Component;
  public bool bEnabled;
}

public class UIniLocPatcher : UObject
{
  public class FIniLocFileEntry
  {
    public string Filename;
    public EOnlineEnumerationReadState ReadState;
  }

  public List<FIniLocFileEntry> Files;
  public FScriptInterface SystemInterface;
  public FScriptDelegate __OnReadTitleFileComplete__Delegate;
}

public class UInstancedStaticMeshComponent : UStaticMeshComponent
{
  public class FInstancedStaticMeshInstanceData
  {
    public UObject.FMatrix Transform = new();
    public UObject.FVector2D LightmapUVBias = new();
    public UObject.FVector2D ShadowmapUVBias = new();
  }

  public class FInstancedStaticMeshMappingInfo
  {
    public UObject.FPointer Mapping = new();
    public UObject.FPointer LightMap = new();
    public UTexture2D LightmapTexture;
    public UShadowMap2D ShadowmapTexture;
  }

  public List<FInstancedStaticMeshInstanceData> PerInstanceData;
  public List<FInstancedStaticMeshInstanceData> PerInstanceSMData;
  public int NumPendingLightmaps;
  public int ComponentJoinKey;
  public List<FInstancedStaticMeshMappingInfo> CachedMappings;
  public int InstancingRandomSeed;
}

public class AStaticMeshActorBase : AActor
{
}

public class AStaticMeshActor : AStaticMeshActorBase
{
  public UStaticMeshComponent StaticMeshComponent;
  public bool bDisableAutoBaseOnProcBuilding;
}

public class UInteractiveFoliageComponent : UStaticMeshComponent
{
  public FPointer FoliageSceneProxy = new();
}

public class AInteractiveFoliageActor : AStaticMeshActor
{
  public UCylinderComponent CylinderComponent;
  public FVector TouchingActorEntryPosition = new();
  public FVector FoliageVelocity = new();
  public FVector FoliageForce = new();
  public FVector FoliagePosition = new();
  public float FoliageDamageImpulseScale;
  public float FoliageTouchImpulseScale;
  public float FoliageStiffness;
  public float FoliageStiffnessQuadratic;
  public float FoliageDamping;
  public float MaxDamageImpulse;
  public float MaxTouchImpulse;
  public float MaxForce;
  public float Mass;
}

public class UInterface_NavigationHandle : UInterface
{
}

public class UInterface_NavMeshPathObject : UInterface
{
}

public class UInterface_NavMeshPathObstacle : UInterface
{
}

public class UInterface_NavMeshPathSwitch : UInterface_NavMeshPathObject
{
}

public class UInterface_RVO : UInterface
{
}

public class AInterpActor : ADynamicSMActor
{
  public class FCheckpointRecord
  {
    public UObject.FVector Location = new();
    public UObject.FRotator Rotation = new();
    public ECollisionType CollisionType;
    public bool bHidden;
    public bool bIsShutdown;
    public bool bNeedsPositionReplication;
  }

  public bool bShouldSaveForCheckpoint;
  public bool bMonitorMover;
  public bool bMonitorZVelocity;
  public bool bDestroyProjectilesOnEncroach;
  public bool bContinueOnEncroachPhysicsObject;
  public bool bStopOnEncroach;
  public bool bShouldShadowParentAllAttachedActors;
  public bool bIsLift;
  public bool bDisableTickWhenStop;
  public bool bInitLocationWhenFellOutOfWorld;
  public bool bClientSideOnly;
  public bool bCanSplashEfect;
  public bool bAllowCullDistanceVolume;
  public ANavigationPoint MyMarker;
  public float MaxZVelocity;
  public float StayOpenTime;
  public USoundCue OpenSound;
  public USoundCue OpeningAmbientSound;
  public USoundCue OpenedSound;
  public USoundCue CloseSound;
  public USoundCue ClosingAmbientSound;
  public USoundCue ClosedSound;
  public UAudioComponent AmbientSoundComponent;
  public AActor BaseActorForReset;
  public USkeletalMeshComponent BaseSkelComponentForReset;
  public FName BaseBoneNameForReset;
  public int InterpolatingStartCounter;
}

public class AInterpActor_ForCinematic : AInterpActor
{
}

public class UInterpCurveEdSetup : UObject
{
  public class FCurveEdEntry
  {
    public UObject CurveObject;
    public UObject.FColor CurveColor = new();
    public string CurveName;
    public int bHideCurve;
    public int bColorCurve;
    public int bFloatingPointColorCurve;
    public int bClamp;
    public float ClampLow;
    public float ClampHigh;
  }

  public class FCurveEdTab
  {
    public string TabName;
    public List<UInterpCurveEdSetup.FCurveEdEntry> Curves;
    public float ViewStartInput;
    public float ViewEndInput;
    public float ViewStartOutput;
    public float ViewEndOutput;
  }

  public List<FCurveEdTab> Tabs;
  public int ActiveTab;
}

public class USequenceVariable : USequenceObject
{
  public FName VarName;
  public bool bHostMigration;
}

public class UInterpData : USequenceVariable
{
  public float InterpLength;
  public float PathBuildTime;
  public List<UInterpGroup> InterpGroups;
  public UInterpCurveEdSetup CurveEdSetup;
  public List<UInterpFilter> InterpFilters;
  public UInterpFilter SelectedFilter;
  public List<UInterpFilter> DefaultFilters;
  public float EdSectionStart;
  public float EdSectionEnd;
  public bool bShouldBakeAndPrune;
}

public class UInterpFilter : UObject
{
  public string Caption;
}

public class UInterpFilter_Classes : UInterpFilter
{
  public UClass ClassToFilterBy;
  public List<UClass> TrackClasses;
}

public class UInterpFilter_Custom : UInterpFilter
{
  public List<UInterpGroup> GroupsToInclude;
}

public class UInterpGroup : UObject
{
  public class FInterpEdSelKey
  {
    public UInterpGroup Group;
    public UInterpTrack Track;
    public int KeyIndex;
    public float UnsnappedPosition;
  }

  public FPointer VfTable_FInterpEdInputInterface = new();
  public List<UInterpTrack> InterpTracks;
  public FName GroupName;
  public FColor GroupColor = new();
  public List<UAnimSet> GroupAnimSets;
  public bool bCollapsed;
  public bool bVisible;
  public bool bIsFolder;
  public bool bIsParented;
  public bool bIsSelected;
}

public class UInterpGroupAI : UInterpGroup
{
  public UClass PreviewPawnClass;
  public FName StageMarkGroup;
  public bool SnapToRootBoneLocationWhenFinished;
  public bool bNoEncroachmentCheck;
  public bool bDisableWorldCollision;
  public bool bIgnoreLegacyHeightAdjust;
  public bool bRecreatePreviewPawn;
  public bool bRefreshStageMarkGroup;
}

public class UInterpGroupDirector : UInterpGroup
{
}

public class UInterpGroupInstAI : UInterpGroupInst
{
  public UInterpGroupAI AIGroup;
  public EPhysics SavedPhysics;
  public bool bSavedNoEncroachCheck;
  public bool bSavedCollideActors;
  public bool bSavedBlockActors;
  public APawn PreviewPawn;
  public AActor StageMarkActor;
}

public class UInterpGroupInstDirector : UInterpGroupInst
{
}

public class UInterpTrack : UObject
{
  public FPointer VfTable_FInterpEdInputInterface = new();
  public FPointer CurveEdVTable = new();
  public UClass TrackInstClass;
  public ETrackActiveCondition ActiveCondition;
  public string TrackTitle;
  public bool bOnePerGroup;
  public bool bDirGroupOnly;
  public bool bDisableTrack;
  public bool bIsAnimControlTrack;
  public bool bVisible;
  public bool bIsSelected;
  public bool bIsRecording;
}

public class UInterpTrackFloatBase : UInterpTrack
{
  public FInterpCurveFloat FloatTrack = new();
  public float CurveTension;
}

public class UInterpTrackAnimControl : UInterpTrackFloatBase
{
  public class FAnimControlTrackKey
  {
    public float StartTime;
    public FName AnimSeqName;
    public float AnimStartOffset;
    public float AnimEndOffset;
    public float AnimPlayRate;
    public bool bLooping;
    public bool bReverse;
  }

  public List<UAnimSet> AnimSets;
  public FName SlotName;
  public List<FAnimControlTrackKey> AnimSeqs;
}

public class UInterpTrackVectorBase : UInterpTrack
{
  public FInterpCurveVector VectorTrack = new();
  public float CurveTension;
}

public class UInterpTrackAudioMaster : UInterpTrackVectorBase
{
}

public class UInterpTrackBoolProp : UInterpTrack
{
  public class FBoolTrackKey
  {
    public float Time;
    public bool Value;
  }

  public List<FBoolTrackKey> BoolTrack;
  public FName PropertyName;
}

public class UInterpTrackColorProp : UInterpTrackVectorBase
{
  public FName PropertyName;
}

public class UInterpTrackColorScale : UInterpTrackVectorBase
{
}

public class UInterpTrackDirector : UInterpTrack
{
  public class FDirectorTrackCut
  {
    public float Time;
    public float TransitionTime;
    public FName TargetCamGroup;
  }

  public List<FDirectorTrackCut> CutTrack;
  public bool bSimulateCameraCutsOnClients;
}

public class UInterpTrackEvent : UInterpTrack
{
  public class FEventTrackKey
  {
    public float Time;
    public FName EventName;
  }

  public List<FEventTrackKey> EventTrack;
  public bool bFireEventsWhenForwards;
  public bool bFireEventsWhenBackwards;
  public bool bFireEventsWhenJumpingForwards;
}

public class UInterpTrackFaceFX : UInterpTrack
{
  public class FFaceFXTrackKey
  {
    public float StartTime;
    public string FaceFXGroupName;
    public string FaceFXSeqName;
  }

  public class FFaceFXSoundCueKey
  {
    public USoundCue FaceFXSoundCue;
  }

  public List<UFaceFXAnimSet> FaceFXAnimSets;
  public List<FFaceFXTrackKey> FaceFXSeqs;
  public UFaceFXAsset CachedActorFXAsset;
  public List<FFaceFXSoundCueKey> FaceFXSoundCueKeys;
}

public class UInterpTrackFade : UInterpTrackFloatBase
{
  public bool bPersistFade;
}

public class UInterpTrackFloatMaterialParam : UInterpTrackFloatBase
{
  public List<UEngineTypes.FMaterialReferenceList> Materials;
  public UMaterialInterface Material;
  public FName ParamName;
  public bool bNeedsMaterialRefsUpdate;
}

public class UInterpTrackFloatParticleParam : UInterpTrackFloatBase
{
  public FName ParamName;
}

public class UInterpTrackFloatProp : UInterpTrackFloatBase
{
  public FName PropertyName;
}

public class UInterpTrackInst : UObject
{
}

public class UInterpTrackInstAnimControl : UInterpTrackInst
{
  public float LastUpdatePosition;
}

public class UInterpTrackInstAudioMaster : UInterpTrackInst
{
}

public class UInterpTrackInstProperty : UInterpTrackInst
{
  public UFunction PropertyUpdateCallback;
  public UObject PropertyOuterObjectInst;
}

public class UInterpTrackInstBoolProp : UInterpTrackInstProperty
{
  public FPointer BoolProp = new();
  public bool ResetBool;
}

public class UInterpTrackInstColorProp : UInterpTrackInstProperty
{
  public FPointer ColorProp = new();
  public FColor ResetColor = new();
}

public class UInterpTrackInstColorScale : UInterpTrackInst
{
}

public class UInterpTrackInstDirector : UInterpTrackInst
{
  public AActor OldViewTarget;
}

public class UInterpTrackInstEvent : UInterpTrackInst
{
  public float LastUpdatePosition;
}

public class UInterpTrackInstFaceFX : UInterpTrackInst
{
  public bool bFirstUpdate;
  public float LastUpdatePosition;
}

public class UInterpTrackInstFade : UInterpTrackInst
{
}

public class UInterpTrackInstFloatMaterialParam : UInterpTrackInst
{
  public class FFloatMaterialParamMICData
  {
    public List<UMaterialInstanceConstant> MICs;
    public List<float> MICResetFloats;
  }

  public List<FFloatMaterialParamMICData> MICInfos;
  public UInterpTrackFloatMaterialParam InstancedTrack;
}

public class UInterpTrackInstFloatParticleParam : UInterpTrackInst
{
  public float ResetFloat;
}

public class UInterpTrackInstFloatProp : UInterpTrackInstProperty
{
  public FPointer FloatProp = new();
  public float ResetFloat;
}

public class UInterpTrackInstLinearColorProp : UInterpTrackInstProperty
{
  public FPointer ColorProp = new();
  public FLinearColor ResetColor = new();
}

public class UInterpTrackInstMorphWeight : UInterpTrackInst
{
}

public class UInterpTrackInstMove : UInterpTrackInst
{
  public FVector ResetLocation = new();
  public FRotator ResetRotation = new();
  public FMatrix InitialTM = new();
  public FQuat InitialQuat = new();
}

public class UInterpTrackInstParticleReplay : UInterpTrackInst
{
  public float LastUpdatePosition;
}

public class UInterpTrackInstSkelControlScale : UInterpTrackInst
{
}

public class UInterpTrackInstSlomo : UInterpTrackInst
{
  public float OldTimeDilation;
  public float OldMatineePlayRate;
}

public class UInterpTrackInstSound : UInterpTrackInst
{
  public float LastUpdatePosition;
  public UAudioComponent PlayAudioComp;
}

public class UInterpTrackToggle : UInterpTrack
{
  public class FToggleTrackKey
  {
    public float Time;
    public ETrackToggleAction ToggleAction;
  }

  public List<FToggleTrackKey> ToggleTrack;
  public bool bActivateSystemEachUpdate;
  public bool bFireEventsWhenForwards;
  public bool bFireEventsWhenBackwards;
  public bool bFireEventsWhenJumpingForwards;
}

public class UInterpTrackInstToggle : UInterpTrackInst
{
  public ETrackToggleAction Action;
  public float LastUpdatePosition;
  public bool bSavedActiveState;
}

public class UInterpTrackInstVectorMaterialParam : UInterpTrackInst
{
  public class FVectorMaterialParamMICData
  {
    public List<UMaterialInstanceConstant> MICs;
    public List<UObject.FVector> MICResetVectors;
  }

  public List<FVectorMaterialParamMICData> MICInfos;
  public UInterpTrackVectorMaterialParam InstancedTrack;
}

public class UInterpTrackInstVectorProp : UInterpTrackInstProperty
{
  public FPointer VectorProp = new();
  public FVector ResetVector = new();
}

public class UInterpTrackVisibility : UInterpTrack
{
  public class FVisibilityTrackKey
  {
    public float Time;
    public EVisibilityTrackAction Action;
    public EVisibilityTrackCondition ActiveCondition;
  }

  public List<FVisibilityTrackKey> VisibilityTrack;
  public bool bFireEventsWhenForwards;
  public bool bFireEventsWhenBackwards;
  public bool bFireEventsWhenJumpingForwards;
}

public class UInterpTrackInstVisibility : UInterpTrackInst
{
  public EVisibilityTrackAction Action;
  public float LastUpdatePosition;
}

public class UInterpTrackLinearColorBase : UInterpTrack
{
  public FInterpCurveLinearColor LinearColorTrack = new();
  public float CurveTension;
}

public class UInterpTrackLinearColorProp : UInterpTrackLinearColorBase
{
  public FName PropertyName;
}

public class UInterpTrackMorphWeight : UInterpTrackFloatBase
{
  public FName MorphNodeName;
}

public class UInterpTrackMove : UInterpTrack
{
  public class FInterpLookupPoint
  {
    public FName GroupName;
    public float Time;
  }

  public class FInterpLookupTrack
  {
    public List<UInterpTrackMove.FInterpLookupPoint> Points;
  }

  public FInterpCurveVector PosTrack = new();
  public FInterpCurveVector EulerTrack = new();
  public FInterpLookupTrack LookupTrack = new();
  public FName LookAtGroupName;
  public float LinCurveTension;
  public float AngCurveTension;
  public bool bUseQuatInterpolation;
  public bool bShowArrowAtKeys;
  public bool bDisableMovement;
  public bool bShowTranslationOnCurveEd;
  public bool bShowRotationOnCurveEd;
  public bool bHide3DTrack;
  public bool bIgnoreBaseActorMovement;
  public EInterpTrackMoveFrame MoveFrame;
  public EInterpTrackMoveRotMode RotMode;
}

public class UInterpTrackParticleReplay : UInterpTrack
{
  public class FParticleReplayTrackKey
  {
    public float Time;
    public float Duration;
    public int ClipIDNumber;
  }

  public List<FParticleReplayTrackKey> TrackKeys;
  public bool bIsCapturingReplay;
  public float FixedTimeStep;
}

public class UInterpTrackSkelControlScale : UInterpTrackFloatBase
{
  public FName SkelControlName;
}

public class UInterpTrackSlomo : UInterpTrackFloatBase
{
}

public class UInterpTrackSound : UInterpTrackVectorBase
{
  public class FSoundTrackKey
  {
    public float Time;
    public float Volume;
    public float Pitch;
    public USoundCue Sound;
  }

  public List<FSoundTrackKey> Sounds;
  public bool bPlayOnReverse;
  public bool bContinueSoundOnMatineeEnd;
  public bool bSuppressSubtitles;
}

public class UInterpTrackVectorMaterialParam : UInterpTrackVectorBase
{
  public List<UEngineTypes.FMaterialReferenceList> Materials;
  public UMaterialInterface Material;
  public FName ParamName;
  public bool bNeedsMaterialRefsUpdate;
}

public class UInterpTrackVectorProp : UInterpTrackVectorBase
{
  public FName PropertyName;
}

public class AInventory : AActor
{
  public AInventory Inventory;
  public AInventoryManager InvManager;
  public string ItemName;
  public bool bRenderOverlays;
  public bool bReceiveOwnerEvents;
  public bool bDropOnDeath;
  public bool bDelayedSpawn;
  public bool bPredictRespawns;
  public float RespawnTime;
  public float MaxDesireability;
  public string PickupMessage;
  public USoundCue PickupSound;
  public string PickupForce;
  public UClass DroppedPickupClass;
  public UPrimitiveComponent DroppedPickupMesh;
  public UPrimitiveComponent PickupFactoryMesh;
  public UParticleSystemComponent DroppedPickupParticles;
}

public class AInventoryManager : AActor
{
  public AInventory InventoryChain;
  public AWeapon PendingWeapon;
  public AWeapon LastAttemptedSwitchToWeapon;
  public bool bMustHoldWeapon;
  public List<int> PendingFire;
}

public class AKActor : ADynamicSMActor
{
  public bool bDamageAppliesImpulse;
  public bool bWakeOnLevelStart;
  public bool bCurrentSlide;
  public bool bSlideActive;
  public bool bEnableStayUprightSpring;
  public bool bLimitMaxPhysicsVelocity;
  public bool bNeedsRBStateReplication;
  public bool bDisableClientSidePawnInteractions;
  public UParticleSystemComponent ImpactEffectComponent;
  public UAudioComponent ImpactSoundComponent;
  public UAudioComponent ImpactSoundComponent2;
  public float LastImpactTime;
  public FPhysEffectInfo ImpactEffectInfo = new();
  public UParticleSystemComponent SlideEffectComponent;
  public UAudioComponent SlideSoundComponent;
  public float LastSlideTime;
  public FPhysEffectInfo SlideEffectInfo = new();
  public float StayUprightTorqueFactor;
  public float StayUprightMaxTorque;
  public float MaxPhysicsVelocity;
  public FRigidBodyState RBState = new();
  public float AngErrorAccumulator;
  public FVector ReplicatedDrawScale3D = new();
}

public class AKActorFromStatic : AKActor
{
  public AActor MyStaticMeshActor;
  public float MaxImpulseSpeed;
}

public class AKActorSpawnable : AKActor
{
  public bool bRecycleScaleToZero;
  public bool bScalingToZero;
}

public class AKAsset : AActor
{
  public USkeletalMeshComponent SkeletalMeshComponent;
  public bool bDamageAppliesImpulse;
  public bool bWakeOnLevelStart;
  public bool bBlockPawns;
  public USkeletalMesh ReplicatedMesh;
  public UPhysicsAsset ReplicatedPhysAsset;
}

public class AKAssetSpawnable : AKAsset
{
}

public class UKismetBookMark : UBookMark2D
{
  public string BookMarkSequencePathName;
}

public class UKMeshProps : UObject
{
  public class FKSphereElem
  {
    public UObject.FMatrix TM = new();
    public float Radius;
    public bool bNoRBCollision;
    public bool bPerPolyShape;
  }

  public class FKBoxElem
  {
    public UObject.FMatrix TM = new();
    public float X;
    public float Y;
    public float Z;
    public bool bNoRBCollision;
    public bool bPerPolyShape;
  }

  public class FKSphylElem
  {
    public UObject.FMatrix TM = new();
    public float Radius;
    public float Length;
    public bool bNoRBCollision;
    public bool bPerPolyShape;
  }

  public class FKConvexElem
  {
    public List<UObject.FVector> VertexData;
    public List<UObject.FPlane> PermutedVertexData;
    public List<int> FaceTriData;
    public List<UObject.FVector> EdgeDirections;
    public List<UObject.FVector> FaceNormalDirections;
    public List<UObject.FPlane> FacePlaneData;
    public UObject.FBox ElemBox = new();
  }

  public class FKAggregateGeom
  {
    public List<UKMeshProps.FKSphereElem> SphereElems;
    public List<UKMeshProps.FKBoxElem> BoxElems;
    public List<UKMeshProps.FKSphylElem> SphylElems;
    public List<UKMeshProps.FKConvexElem> ConvexElems;
    public UObject.FPointer RenderInfo = new();
    public bool bSkipCloseAndParallelChecks;
  }

  public FVector COMNudge = new();
  public FKAggregateGeom AggGeom = new();
}

public class ULadderReachSpec : UReachSpec
{
}

public class ALadderVolume : APhysicsVolume
{
  public FRotator WallDir = new();
  public FVector LookDir = new();
  public FVector ClimbDir = new();
  public ALadder LadderList;
  public bool bNoPhysicalLadder;
  public bool bAutoPath;
  public bool bAllowLadderStrafing;
  public APawn PendingClimber;
  public UArrowComponent WallDirArrow;
}

public class ULensFlare : UObject
{
  public class FLensFlareElementCurvePair
  {
    public string CurveName;
    public UObject CurveObject;
  }

  public class FLensFlareElement
  {
    public FName ElementName;
    public float RayDistance;
    public bool bIsEnabled;
    public bool bUseSourceDistance;
    public bool bNormalizeRadialDistance;
    public bool bModulateColorBySource;
    public UObject.FVector Size = new();
    public List<UMaterialInterface> LFMaterials;
    public UDistributionFloat.FRawDistributionFloat LFMaterialIndex = new();
    public UDistributionFloat.FRawDistributionFloat Scaling = new();
    public UDistributionVector.FRawDistributionVector AxisScaling = new();
    public UDistributionFloat.FRawDistributionFloat Rotation = new();
    public UDistributionVector.FRawDistributionVector Color = new();
    public UDistributionFloat.FRawDistributionFloat Alpha = new();
    public UDistributionVector.FRawDistributionVector Offset = new();
    public UDistributionVector.FRawDistributionVector DistMap_Scale = new();
    public UDistributionVector.FRawDistributionVector DistMap_Color = new();
    public UDistributionFloat.FRawDistributionFloat DistMap_Alpha = new();
  }

  public FLensFlareElement SourceElement = new();
  public UStaticMesh SourceMesh;
  public ESceneDepthPriorityGroup SourceDPG;
  public ESceneDepthPriorityGroup ReflectionsDPG;
  public List<FLensFlareElement> Reflections;
  public float OuterCone;
  public float InnerCone;
  public float ConeFudgeFactor;
  public float Radius;
  public UDistributionFloat.FRawDistributionFloat ScreenPercentageMap = new();
  public bool bUseFixedRelativeBoundingBox;
  public bool bRenderDebugLines;
  public bool ThumbnailImageOutOfDate;
  public FBox FixedRelativeBoundingBox = new();
  public UInterpCurveEdSetup CurveEdSetup;
  public int ReflectionCount;
  public FRotator ThumbnailAngle = new();
  public float ThumbnailDistance;
  public UTexture2D ThumbnailImage;
}

public class ULensFlareComponent : UPrimitiveComponent
{
  public class FLensFlareElementInstance
  {
  }

  public class FLensFlareElementMaterials
  {
    public List<UMaterialInterface> ElementMaterials;
  }

  public ULensFlare Template;
  public UDrawLightConeComponent PreviewInnerCone;
  public UDrawLightConeComponent PreviewOuterCone;
  public UDrawLightRadiusComponent PreviewRadius;
  public bool bAutoActivate;
  public bool bIsActive;
  public bool bHasTranslucency;
  public bool bHasUnlitTranslucency;
  public bool bHasUnlitDistortion;
  public bool bUsesSceneColor;
  public float OuterCone;
  public float InnerCone;
  public float ConeFudgeFactor;
  public float Radius;
  public FLinearColor SourceColor = new();
  public EDetailMode MaxDetailMode;
  public List<FLensFlareElementMaterials> Materials;
  public FPointer ReleaseResourcesFence = new();
}

public class ALensFlareSource : AActor
{
  public ULensFlareComponent LensFlareComp;
  public bool bCurrentlyActive;
}

public class ALevelGridVolume : AVolume
{
  public class FLevelGridCellCoordinate
  {
    public int X;
    public int Y;
    public int Z;
  }

  public string LevelGridVolumeName;
  public LevelGridCellShape CellShape;
  public int[] Subdivisions = new int[3];
  public float LoadingDistance;
  public float KeepLoadedRange;
  public UKMeshProps.FKConvexElem CellConvexElem = new();
}

public class ULevelGridVolumeRenderingComponent : UPrimitiveComponent
{
}

public class ULevelStreaming : UObject
{
  public FName PackageName;
  public ULevel LoadedLevel;
  public FVector Offset = new();
  public FVector OldOffset = new();
  public bool bIsVisible;
  public bool bHasLoadRequestPending;
  public bool bHasUnloadRequestPending;
  public bool bShouldBeVisibleInEditor;
  public bool bBoundingBoxVisible;
  public bool bLocked;
  public bool bIsFullyStatic;
  public bool bShouldBeLoaded;
  public bool bShouldBeVisible;
  public bool bShouldBlockOnLoad;
  public bool bDrawOnLevelStatusMap;
  public bool bIsRequestingUnloadAndRemoval;
  public FColor DrawColor = new();
  public List<ALevelStreamingVolume> EditorStreamingVolumes;
  public float MinTimeBetweenVolumeUnloadRequests;
  public float LastVolumeUnloadRequestTime;
  public List<string> Keywords;
  public ALevelGridVolume EditorGridVolume;
  public int[] GridPosition = new int[3];
}

public class ULevelStreamingAlwaysLoaded : ULevelStreaming
{
  public bool bIsProceduralBuildingLODLevel;
}

public class ULevelStreamingDistance : ULevelStreaming
{
  public FVector Origin = new();
  public float MaxDistance;
}

public class ULevelStreamingKismet : ULevelStreaming
{
}

public class ULevelStreamingPersistent : ULevelStreaming
{
}

public class ALevelStreamingVolume : AVolume
{
  public class FCheckpointRecord
  {
    public bool bDisabled;
  }

  public List<ULevelStreaming> StreamingLevels;
  public bool bEditorPreVisOnly;
  public bool bDisabled;
  public bool bTestDistanceToVolume;
  public EStreamingVolumeUsage StreamingUsage;
  public EStreamingVolumeUsage Usage;
  public float TestVolumeDistance;
}

public class ALiftCenter : ANavigationPoint
{
  public AInterpActor MyLift;
  public float MaxDist2D;
  public FVector LiftOffset = new();
  public bool bJumpLift;
  public float CollisionHeight;
  public ATrigger LiftTrigger;
}

public class ALiftExit : ANavigationPoint
{
  public ALiftCenter MyLiftCenter;
  public bool bExitOnly;
}

public class ULightFunction : UObject
{
  public UMaterialInterface SourceMaterial;
  public FVector Scale = new();
}

public class ULightmappedSurfaceCollection : UObject
{
  public UModel SourceModel;
  public List<int> Surfaces;
}

public class ALightmassCharacterIndirectDetailVolume : AVolume
{
}

public class ALightmassImportanceVolume : AVolume
{
}

public class ULightmassLevelSettings : UObject
{
  public int NumIndirectLightingBounces;
  public FColor EnvironmentColor = new();
  public float EnvironmentIntensity;
  public float EmissiveBoost;
  public float DiffuseBoost;
  public float SpecularBoost;
  public bool bUseAmbientOcclusion;
  public bool bVisualizeAmbientOcclusion;
  public float DirectIlluminationOcclusionFraction;
  public float IndirectIlluminationOcclusionFraction;
  public float OcclusionExponent;
  public float FullyOccludedSamplesFraction;
  public float MaxOcclusionDistance;
}

public class ULightmassPrimitiveSettingsObject : UObject
{
  public UEngineTypes.FLightmassPrimitiveSettings LightmassSettings = new();
}

public class ALightVolume : AVolume
{
}

public class ULineBatchComponent : UPrimitiveComponent
{
  public FPointer FPrimitiveDrawInterfaceVfTable = new();
  public FPointer FPrimitiveDrawInterfaceView = new();
  public List<FPointer> BatchedLines;
  public List<FPointer> BatchedPoints;
  public float DefaultLifeTime;
}

public class UPlayer : UObject
{
  public FPointer VfTable_FExec = new();
  public APlayerController Actor;
  public int CurrentNetSpeed;
  public int ConfiguredInternetSpeed;
  public int ConfiguredLanSpeed;
  public float PP_DesaturationMultiplier;
  public float PP_HighlightsMultiplier;
  public float PP_MidTonesMultiplier;
  public float PP_ShadowsMultiplier;
}

public class ULocalPlayer : UPlayer
{
  public class FSynchronizedActorVisibilityHistory
  {
    public UObject.FPointer State = new();
    public UObject.FPointer CriticalSection = new();
  }

  public class FSynchronizedPlayerZoneInfoHistory
  {
    public UObject.FPointer PlayerZoneInfo = new();
    public UObject.FPointer CriticalSection = new();
  }

  public class FCurrentPostProcessVolumeInfo
  {
    public APostProcessVolume.FPostProcessSettings LastSettings = new();
    public APostProcessVolume LastVolumeUsed;
    public float BlendStartTime;
    public float LastBlendTime;
  }

  public int ControllerId;
  public UGameViewportClient ViewportClient;
  public FVector2D Origin = new();
  public FVector2D Size = new();
  public UPostProcessChain PlayerPostProcess;
  public List<UPostProcessChain> PlayerPostProcessChains;
  public FPointer ViewState = new();
  public FSynchronizedActorVisibilityHistory ActorVisibilityHistory = new();
  public FSynchronizedPlayerZoneInfoHistory PlayerZoneInfoHistory = new();
  public FVector LastViewLocation = new();
  public FCurrentPostProcessVolumeInfo CurrentPPInfo = new();
  public FCurrentPostProcessVolumeInfo LevelPPInfo = new();
  public APostProcessVolume.FPostProcessSettings OverridePPDeltaSettings = new();
  public float OverridePPRecoveryTime;
  public float OverridePPStartTime;
  public float OverridePPEndTime;
  public float OverridePPOpacity;
  public bool bOverridePostProcessSettings;
  public bool bRecoveryFromPostProcessOverride;
  public bool bWantToResetToMapDefaultPP;
  public bool bSentSplitJoin;
  public APostProcessVolume.FPostProcessSettings PostProcessSettingsOverride = new();
  public string LastMap;
}

public class UMantleReachSpec : UForcedReachSpec
{
  public bool bClimbUp;
}

public class UMapInfo : UObject
{
  public float MapVersion;
  public int TotalMapObjectNumber;
}

public class UMaskWorldAlphaEffect : UPostProcessEffect
{
}

public class UMaterialEffect : UPostProcessEffect
{
  public UMaterialInterface Material;
}

public class UMaterialExpression : UObject
{
  public class FExpressionInput
  {
    public UMaterialExpression Expression;
    public int Mask;
    public int MaskR;
    public int MaskG;
    public int MaskB;
    public int MaskA;
    public int GCC64_Padding;
  }

  public int EditorX;
  public int EditorY;
  public int MaterialExpressionEditorX;
  public int MaterialExpressionEditorY;
  public bool bRealtimePreview;
  public bool bNeedToUpdatePreview;
  public bool bIsParameterExpression;
  public bool bShowOutputNameOnPin;
  public bool bHidePreviewWindow;
  public UMaterialExpressionCompound Compound;
  public string Desc;
  public List<FName> MenuCategories;
}

public class UMaterialExpressionAbs : UMaterialExpression
{
  public FExpressionInput Input = new();
}

public class UMaterialExpressionAdd : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
}

public class UMaterialExpressionTextureSample : UMaterialExpression
{
  public UTexture Texture;
  public FExpressionInput Coordinates = new();
}

public class UMaterialExpressionTextureSampleParameter : UMaterialExpressionTextureSample
{
  public FName ParameterName;
  public FGuid ExpressionGUID = new();
}

public class UMaterialExpressionTextureSampleParameter2D : UMaterialExpressionTextureSampleParameter
{
}

public class UMaterialExpressionAntialiasedTextureMask : UMaterialExpressionTextureSampleParameter2D
{
  public float Threshold;
  public ETextureColorChannel Channel;
}

public class UMaterialExpressionAppendVector : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
}

public class UMaterialExpressionBumpOffset : UMaterialExpression
{
  public FExpressionInput Coordinate = new();
  public FExpressionInput Height = new();
  public float HeightRatio;
  public float ReferencePlane;
}

public class UMaterialExpressionCameraVector : UMaterialExpression
{
}

public class UMaterialExpressionCameraWorldPosition : UMaterialExpression
{
}

public class UMaterialExpressionCeil : UMaterialExpression
{
  public FExpressionInput Input = new();
}

public class UMaterialExpressionClamp : UMaterialExpression
{
  public FExpressionInput Input = new();
  public FExpressionInput Min = new();
  public FExpressionInput Max = new();
}

public class UMaterialExpressionComment : UMaterialExpression
{
  public int PosX;
  public int PosY;
  public int SizeX;
  public int SizeY;
  public string Text;
}

public class UMaterialExpressionComponentMask : UMaterialExpression
{
  public FExpressionInput Input = new();
  public bool R;
  public bool G;
  public bool B;
  public bool A;
}

public class UMaterialExpressionCompound : UMaterialExpression
{
  public List<UMaterialExpression> MaterialExpressions;
  public string Caption;
  public bool bExpanded;
}

public class UMaterialExpressionConstant : UMaterialExpression
{
  public float R;
}

public class UMaterialExpressionConstant2Vector : UMaterialExpression
{
  public float R;
  public float G;
}

public class UMaterialExpressionConstant3Vector : UMaterialExpression
{
  public float R;
  public float G;
  public float B;
}

public class UMaterialExpressionConstant4Vector : UMaterialExpression
{
  public float R;
  public float G;
  public float B;
  public float A;
}

public class UMaterialExpressionConstantBiasScale : UMaterialExpression
{
  public FExpressionInput Input = new();
  public float Bias;
  public float Scale;
}

public class UMaterialExpressionConstantClamp : UMaterialExpression
{
  public FExpressionInput Input = new();
  public float Min;
  public float Max;
}

public class UMaterialExpressionCosine : UMaterialExpression
{
  public FExpressionInput Input = new();
  public float Period;
}

public class UMaterialExpressionCrossProduct : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
}

public class UMaterialExpressionCustom : UMaterialExpression
{
  public class FCustomInput
  {
    public string InputName;
    public UMaterialExpression.FExpressionInput Input = new();
  }

  public string Code;
  public ECustomMaterialOutputType OutputType;
  public string Description;
  public List<FCustomInput> Inputs;
}

public class UMaterialExpressionCustomTexture : UMaterialExpression
{
  public UTexture Texture;
}

public class UMaterialExpressionDepthBiasBlend : UMaterialExpressionTextureSample
{
  public bool bNormalize;
  public float BiasScale;
  public FExpressionInput Bias = new();
}

public class UMaterialExpressionDepthBiasedAlpha : UMaterialExpression
{
  public bool bNormalize;
  public float BiasScale;
  public FExpressionInput Alpha = new();
  public FExpressionInput Bias = new();
}

public class UMaterialExpressionDepthBiasedBlend : UMaterialExpression
{
  public bool bNormalize;
  public float BiasScale;
  public FExpressionInput RGB = new();
  public FExpressionInput Alpha = new();
  public FExpressionInput Bias = new();
}

public class UMaterialExpressionDeriveNormalZ : UMaterialExpression
{
  public FExpressionInput InXY = new();
}

public class UMaterialExpressionDesaturation : UMaterialExpression
{
  public FExpressionInput Input = new();
  public FExpressionInput Percent = new();
  public FLinearColor LuminanceFactors = new();
}

public class UMaterialExpressionDestColor : UMaterialExpression
{
}

public class UMaterialExpressionDestDepth : UMaterialExpression
{
  public bool bNormalize;
}

public class UMaterialExpressionDistance : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
}

public class UMaterialExpressionDivide : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
}

public class UMaterialExpressionDotProduct : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
}

public class UMaterialExpressionDynamicParameter : UMaterialExpression
{
  public List<string> ParamNames;
}

public class UMaterialExpressionFlipBookSample : UMaterialExpressionTextureSample
{
}

public class UMaterialExpressionFloor : UMaterialExpression
{
  public FExpressionInput Input = new();
}

public class UMaterialExpressionFluidNormal : UMaterialExpression
{
}

public class UMaterialExpressionFmod : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
}

public class UMaterialExpressionFoliageImpulseDirection : UMaterialExpression
{
}

public class UMaterialExpressionFoliageNormalizedRotationAxisAndAngle : UMaterialExpression
{
}

public class UMaterialExpressionFontSample : UMaterialExpression
{
  public UFont Font;
  public int FontTexturePage;
}

public class UMaterialExpressionFontSampleParameter : UMaterialExpressionFontSample
{
  public FName ParameterName;
  public FGuid ExpressionGUID = new();
}

public class UMaterialExpressionFrac : UMaterialExpression
{
  public FExpressionInput Input = new();
}

public class UMaterialExpressionFresnel : UMaterialExpression
{
  public float Exponent;
  public FExpressionInput Normal = new();
}

public class UMaterialExpressionGlossinessToSpecularPower : UMaterialExpression
{
  public FExpressionInput Glossiness = new();
}

public class UMaterialExpressionIf : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
  public FExpressionInput AGreaterThanB = new();
  public FExpressionInput AEqualsB = new();
  public FExpressionInput ALessThanB = new();
}

public class UMaterialExpressionLensFlareIntensity : UMaterialExpression
{
}

public class UMaterialExpressionLensFlareOcclusion : UMaterialExpression
{
}

public class UMaterialExpressionLensFlareRadialDistance : UMaterialExpression
{
}

public class UMaterialExpressionLensFlareRayDistance : UMaterialExpression
{
}

public class UMaterialExpressionLensFlareSourceDistance : UMaterialExpression
{
}

public class UMaterialExpressionLightmapUVs : UMaterialExpression
{
}

public class UMaterialExpressionLightmassReplace : UMaterialExpression
{
  public FExpressionInput Realtime = new();
  public FExpressionInput Lightmass = new();
}

public class UMaterialExpressionLightVector : UMaterialExpression
{
}

public class UMaterialExpressionLinearInterpolate : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
  public FExpressionInput Alpha = new();
}

public class UMaterialExpressionMeshEmitterDynamicParameter : UMaterialExpressionDynamicParameter
{
}

public class UMaterialExpressionMeshEmitterVertexColor : UMaterialExpression
{
}

public class UMaterialExpressionMeshSubUV : UMaterialExpressionTextureSample
{
}

public class UMaterialExpressionMeshSubUVBlend : UMaterialExpressionMeshSubUV
{
}

public class UMaterialExpressionMultiply : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
}

public class UMaterialExpressionNormalize : UMaterialExpression
{
  public FExpressionInput VectorInput = new();
}

public class UMaterialExpressionObjectOrientation : UMaterialExpression
{
}

public class UMaterialExpressionObjectRadius : UMaterialExpression
{
}

public class UMaterialExpressionObjectWorldPosition : UMaterialExpression
{
}

public class UMaterialExpressionOcclusionPercentage : UMaterialExpression
{
}

public class UMaterialExpressionOneMinus : UMaterialExpression
{
  public FExpressionInput Input = new();
}

public class UMaterialExpressionPanner : UMaterialExpression
{
  public FExpressionInput Coordinate = new();
  public FExpressionInput Time = new();
  public float SpeedX;
  public float SpeedY;
}

public class UMaterialExpressionParameter : UMaterialExpression
{
  public FName ParameterName;
  public FGuid ExpressionGUID = new();
}

public class UMaterialExpressionParticleMacroUV : UMaterialExpression
{
  public bool bUseViewSpace;
}

public class UMaterialExpressionParticleSubUV : UMaterialExpressionTextureSample
{
}

public class UMaterialExpressionPBPhongCubeTextureSample : UMaterialExpression
{
  public UTextureCube PBPhongCube;
  public FExpressionInput Coordinates = new();
  public FExpressionInput Glossiness = new();
}

public class UMaterialExpressionPerInstanceRandom : UMaterialExpression
{
}

public class UMaterialExpressionPixelDepth : UMaterialExpression
{
  public bool bNormalize;
}

public class UMaterialExpressionPower : UMaterialExpression
{
  public FExpressionInput Base = new();
  public FExpressionInput Exponent = new();
}

public class UMaterialExpressionReflectionVector : UMaterialExpression
{
}

public class UMaterialExpressionRotateAboutAxis : UMaterialExpression
{
  public FExpressionInput NormalizedRotationAxisAndAngle = new();
  public FExpressionInput PositionOnAxis = new();
  public FExpressionInput Position = new();
}

public class UMaterialExpressionRotator : UMaterialExpression
{
  public FExpressionInput Coordinate = new();
  public FExpressionInput Time = new();
  public float CenterX;
  public float CenterY;
  public float Speed;
}

public class UMaterialExpressionScalarParameter : UMaterialExpressionParameter
{
  public float DefaultValue;
}

public class UMaterialExpressionSceneDepth : UMaterialExpression
{
  public FExpressionInput Coordinates = new();
  public bool bNormalize;
}

public class UMaterialExpressionSceneTexture : UMaterialExpression
{
  public FExpressionInput Coordinates = new();
  public ESceneTextureType SceneTextureType;
  public bool ScreenAlign;
}

public class UMaterialExpressionScreenPosition : UMaterialExpression
{
  public bool ScreenAlign;
}

public class UMaterialExpressionSine : UMaterialExpression
{
  public FExpressionInput Input = new();
  public float Period;
}

public class UMaterialExpressionSphereMask : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
  public float AttenuationRadius;
  public float HardnessPercent;
}

public class UMaterialExpressionSquareRoot : UMaterialExpression
{
  public FExpressionInput Input = new();
}

public class UMaterialExpressionStaticComponentMaskParameter : UMaterialExpressionParameter
{
  public FExpressionInput Input = new();
  public bool DefaultR;
  public bool DefaultG;
  public bool DefaultB;
  public bool DefaultA;
  public FPointer InstanceOverride = new();
}

public class UMaterialExpressionStaticSwitchParameter : UMaterialExpressionParameter
{
  public bool DefaultValue;
  public bool ExtendedCaptionDisplay;
  public FExpressionInput A = new();
  public FExpressionInput B = new();
  public FPointer InstanceOverride = new();
}

public class UMaterialExpressionSubtract : UMaterialExpression
{
  public FExpressionInput A = new();
  public FExpressionInput B = new();
}

public class UMaterialExpressionTextureCoordinate : UMaterialExpression
{
  public int CoordinateIndex;
  public float UTiling;
  public float VTiling;
  public bool UnMirrorU;
  public bool UnMirrorV;
}

public class UTextureCube : UTexture
{
  public int SizeX;
  public int SizeY;
  public EPixelFormat Format;
  public int NumMips;
  public bool bIsCubemapValid;
  public UTexture2D FacePosX;
  public UTexture2D FaceNegX;
  public UTexture2D FacePosY;
  public UTexture2D FaceNegY;
  public UTexture2D FacePosZ;
  public UTexture2D FaceNegZ;
}

public class UMaterialExpressionTextureSampleParameterCube : UMaterialExpressionTextureSampleParameter
{
}

public class UMaterialExpressionTextureSampleParameterMeshSubUV : UMaterialExpressionTextureSampleParameter2D
{
}

public class UMaterialExpressionTextureSampleParameterMeshSubUVBlend : UMaterialExpressionTextureSampleParameterMeshSubUV
{
}

public class UMaterialExpressionTextureSampleParameterMovie : UMaterialExpressionTextureSampleParameter
{
}

public class UMaterialExpressionTextureSampleParameterNormal : UMaterialExpressionTextureSampleParameter
{
  public FPointer InstanceOverride = new();
}

public class UMaterialExpressionTextureSampleParameterSubUV : UMaterialExpressionTextureSampleParameter2D
{
}

public class UMaterialExpressionTime : UMaterialExpression
{
  public bool bIgnorePause;
}

public class UMaterialExpressionTransform : UMaterialExpression
{
  public FExpressionInput Input = new();
  public EMaterialVectorCoordTransformSource TransformSourceType;
  public EMaterialVectorCoordTransform TransformType;
}

public class UMaterialExpressionTransformPosition : UMaterialExpression
{
  public FExpressionInput Input = new();
  public EMaterialPositionTransform TransformType;
}

public class UMaterialExpressionTwoSidedSign : UMaterialExpression
{
}

public class UMaterialExpressionVectorParameter : UMaterialExpressionParameter
{
  public FLinearColor DefaultValue = new();
}

public class UMaterialExpressionVertexColor : UMaterialExpression
{
}

public class UMaterialExpressionWindDirectionAndSpeed : UMaterialExpression
{
}

public class UMaterialExpressionWorldNormal : UMaterialExpression
{
}

public class UMaterialExpressionWorldPosition : UMaterialExpression
{
}

public partial class UMaterialInstance : UMaterialInterface
{
  public UPhysicalMaterial PhysMaterial;
  public UMaterialInterface Parent;
  public UTexture2D PhysMaterialMask;
  public int PhysMaterialMaskUVChannel;
  public UPhysicalMaterial BlackPhysicalMaterial;
  public UPhysicalMaterial WhitePhysicalMaterial;
  public bool bHasStaticPermutationResource;
  public bool bStaticPermutationDirty;
  public bool ReentrantFlag;
  public FStaticParameterSet[] StaticParameters = new FStaticParameterSet[3];
  public FMaterial[] StaticPermutationResources = new FMaterial[3];
  public FPointer[] Resources = new FPointer[2];
  public List<UTexture> ReferencedTextures;
  public List<FGuid> ReferencedTextureGuids;
  public FGuid ParentLightingGuid = new();
}

public class AMaterialInstanceActor : AActor
{
  public UMaterialInstanceConstant MatInst;
}

public class UMaterialInstanceConstant : UMaterialInstance
{
  public class FFontParameterValue
  {
    public FName ParameterName;
    public UFont FontValue;
    public int FontPage;
    public UObject.FGuid ExpressionGUID = new();
  }

  public class FScalarParameterValue
  {
    public FName ParameterName;
    public float ParameterValue;
    public UObject.FGuid ExpressionGUID = new();
  }

  public class FTextureParameterValue
  {
    public FName ParameterName;
    public UTexture ParameterValue;
    public UObject.FGuid ExpressionGUID = new();
  }

  public class FVectorParameterValue
  {
    public FName ParameterName;
    public UObject.FLinearColor ParameterValue = new();
    public UObject.FGuid ExpressionGUID = new();
  }

  public List<FFontParameterValue> FontParameterValues;
  public List<FScalarParameterValue> ScalarParameterValues;
  public List<FTextureParameterValue> TextureParameterValues;
  public List<FVectorParameterValue> VectorParameterValues;
}

public class UMaterialInstanceTimeVarying : UMaterialInstance
{
  public class FParameterValueOverTime
  {
    public UObject.FGuid ExpressionGUID = new();
    public float StartTime;
    public FName ParameterName;
    public bool bLoop;
    public bool bAutoActivate;
    public float CycleTime;
    public bool bNormalizeTime;
    public float OffsetTime;
    public bool bOffsetFromEnd;
  }

  public class FFontParameterValueOverTime : FParameterValueOverTime
  {
    public UFont FontValue;
    public int FontPage;
  }

  public class FScalarParameterValueOverTime : FParameterValueOverTime
  {
    public float ParameterValue;
    public UObject.FInterpCurveFloat ParameterValueCurve = new();
  }

  public class FTextureParameterValueOverTime : FParameterValueOverTime
  {
    public UTexture ParameterValue;
  }

  public class FVectorParameterValueOverTime : FParameterValueOverTime
  {
    public UObject.FLinearColor ParameterValue = new();
    public UObject.FInterpCurveVector ParameterValueCurve = new();
  }

  public bool bAutoActivateAll;
  public float Duration;
  public List<FFontParameterValueOverTime> FontParameterValues;
  public List<FScalarParameterValueOverTime> ScalarParameterValues;
  public List<FTextureParameterValueOverTime> TextureParameterValues;
  public List<FVectorParameterValueOverTime> VectorParameterValues;
}

public class AMatineeActor : AActor
{
  public USeqAct_Interp InterpAction;
  public bool bIsPlaying;
  public bool bReversePlayback;
  public bool bPaused;
  public bool AllAIGroupsInitialized;
  public float PlayRate;
  public float Position;
  public FName[] AIGroupNames = new FName[10];
  public APawn[] AIGroupPawns = new APawn[10];
  public int[] AIGroupInitStage = new int[10];
  public float ClientSidePositionErrorTolerance;
}

public class APawn : AActor
{
  public class FScalarParameterInterpStruct
  {
    public FName ParameterName;
    public float ParameterValue;
    public float InterpTime;
    public float WarmupTime;
  }

  public class FsLine2D
  {
    public UObject.FVector2D Start = new();
    public UObject.FVector2D End = new();
  }

  public float MaxStepHeight;
  public float MaxJumpHeight;
  public float WalkableFloorZ;
  public float LedgeCheckThreshold;
  public FVector PartialLedgeMoveDir = new();
  public AController Controller;
  public APawn NextPawn;
  public float NetRelevancyTime;
  public APlayerController LastRealViewer;
  public AActor LastViewer;
  public bool bUpAndOut;
  public bool bIsWalking;
  public bool bIsSprinting;
  public bool bWantsToCrouch;
  public bool bIsCrouched;
  public bool bTryToUncrouch;
  public bool bCanCrouch;
  public bool bRocketJumpCrouch;
  public bool bCrawler;
  public bool bCheckLadder;
  public bool bCheckWater;
  public bool bReducedSpeed;
  public bool bJumpCapable;
  public bool bCanJump;
  public bool bCanWalk;
  public bool bCanSwim;
  public bool bCanFly;
  public bool bCanClimbLadders;
  public bool bCanStrafe;
  public bool bAvoidLedges;
  public bool bStopAtLedges;
  public bool bAllowLedgeOverhang;
  public bool bPartiallyOverLedge;
  public bool bSimulateGravity;
  public bool bIgnoreForces;
  public bool bCanWalkOffLedges;
  public bool bCanBeBaseForPawns;
  public bool bSimGravityDisabled;
  public bool bDirectHitWall;
  public bool bPushesRigidBodies;
  public bool bForceFloorCheck;
  public bool bForceKeepAnchor;
  public bool bCanMantle;
  public bool bCanClimbUp;
  public bool bCanClimbCeilings;
  public bool bCanSwatTurn;
  public bool bCanLeap;
  public bool bCanCoverSlip;
  public bool bDisplayPathErrors;
  public bool bIsFemale;
  public bool bCanPickupInventory;
  public bool bAmbientCreature;
  public bool bLOSHearing;
  public bool bMuffledHearing;
  public bool bDontPossess;
  public bool bAutoFire;
  public bool bRollToDesired;
  public bool bStationary;
  public bool bCachedRelevant;
  public bool bNoWeaponFiring;
  public bool bModifyReachSpecCost;
  public bool bModifyNavPointDest;
  public bool bPathfindsAsVehicle;
  public bool bRunPhysicsWithNoController;
  public bool bForceMaxAccel;
  public bool bLimitFallAccel;
  public bool bReplicateHealthToAll;
  public bool bForceRMVelocity;
  public bool bForceRegularVelocity;
  public bool bUsedHovering;
  public bool bPlayedDeath;
  public bool bDesiredRotationSet;
  public bool bLockDesiredRotation;
  public bool bUnlockWhenReached;
  public bool bNeedsBaseTickedFirst;
  public bool bUsedByMatinee;
  public bool bRootMotionFromInterpCurve;
  public bool bDebugShowCameraLocation;
  public bool bKillCamRigidBody;
  public bool b2DHitTest;
  public bool bWaterLadder;
  public EPhysics WalkingPhysics;
  public EPathSearchType PathSearchType;
  public byte RemoteViewPitch;
  public byte FlashCount;
  public byte FiringMode;
  public float UncrouchTime;
  public float CrouchHeight;
  public float CrouchRadius;
  public int FullHeight;
  public float NonPreferredVehiclePathMultiplier;
  public UPathConstraint PathConstraintList;
  public UPathGoalEvaluator PathGoalList;
  public float DesiredSpeed;
  public float MaxDesiredSpeed;
  public float HearingThreshold;
  public float Alertness;
  public float SightRadius;
  public float PeripheralVision;
  public float AvgPhysicsTime;
  public float Mass;
  public float Buoyancy;
  public float MeleeRange;
  public ANavigationPoint Anchor;
  public int AnchorItem;
  public ANavigationPoint LastAnchor;
  public float FindAnchorFailedTime;
  public float LastValidAnchorTime;
  public float DestinationOffset;
  public float NextPathRadius;
  public FVector SerpentineDir = new();
  public float SerpentineDist;
  public float SerpentineTime;
  public float SpawnTime;
  public int MaxPitchLimit;
  public float GroundSpeed;
  public float WaterSpeed;
  public float AirSpeed;
  public float LadderSpeed;
  public float AccelRate;
  public float JumpZ;
  public float OutofWaterZ;
  public float MaxOutOfWaterStepHeight;
  public float AirControl;
  public float WalkingPct;
  public float CrouchedPct;
  public float MaxFallSpeed;
  public float AIMaxFallSpeedFactor;
  public float BaseEyeHeight;
  public float EyeHeight;
  public FVector Floor = new();
  public float SplashTime;
  public float OldZ;
  public APhysicsVolume HeadVolume;
  public int Health;
  public int HealthMax;
  public float BreathTime;
  public float UnderWaterTime;
  public float LastPainTime;
  public FVector RMVelocity = new();
  public FVector noise1spot = new();
  public float noise1time;
  public APawn noise1other;
  public float noise1loudness;
  public FVector noise2spot = new();
  public float noise2time;
  public APawn noise2other;
  public float noise2loudness;
  public float SoundDampening;
  public float DamageScaling;
  public string MenuName;
  public UClass ControllerClass;
  public APlayerReplicationInfo PlayerReplicationInfo;
  public ALadderVolume OnLadder;
  public FName LandMovementState;
  public FName WaterMovementState;
  public APlayerStart LastStartSpot;
  public float LastStartTime;
  public FVector TearOffMomentum = new();
  public USkeletalMeshComponent Mesh;
  public UCylinderComponent CylinderComponent;
  public float RBPushRadius;
  public float RBPushStrength;
  public AVehicle DrivenVehicle;
  public float AlwaysRelevantDistanceSquared;
  public float VehicleCheckRadius;
  public AController LastHitBy;
  public float ViewPitchMin;
  public float ViewPitchMax;
  public int AllowedYawError;
  public FRotator DesiredRotation = new();
  public UClass InventoryManagerClass;
  public AInventoryManager InvManager;
  public AWeapon Weapon;
  public FVector FlashLocation = new();
  public FVector LastFiringFlashLocation = new();
  public int ShotCount;
  public UPrimitiveComponent PreRagdollCollisionComponent;
  public URB_BodyInstance PhysicsPushBody;
  public int FailedLandingCount;
  public List<UAnimNodeSlot> SlotNodes;
  public List<UInterpGroup> InterpGroupList;
  public UAudioComponent FacialAudioComp;
  public UMaterialInstanceConstant MIC_PawnMat;
  public UMaterialInstanceConstant MIC_PawnHair;
  public List<FScalarParameterInterpStruct> ScalarParameterInterpArray;
  public UEngineTypes.FRootMotionCurve RootMotionInterpCurve = new();
  public float RootMotionInterpRate;
  public float RootMotionInterpCurrentTime;
  public FVector RootMotionInterpCurveLastValue = new();
  public FRotator KillCamViewRotation = new();
  public int KillCamViewRotationYaw;
  public int KillCamViewRotationPitch;
  public FVector SmoothAdjustLocation = new();
  public FVector2D[] ProjectedLocation = new FVector2D[2];
  public float lasttime2DHitTest;
  public FVector Hit2DWorldLoc = new();
  public float Base2dPenetResi;
}

public class AMatineePawn : APawn
{
  public USkeletalMesh PreviewMesh;
}

public class UPrimitiveComponentFactory : UObject
{
  public bool CollideActors;
  public bool BlockActors;
  public bool BlockZeroExtent;
  public bool BlockNonZeroExtent;
  public bool BlockRigidBody;
  public bool HiddenGame;
  public bool HiddenEditor;
  public bool CastShadow;
}

public class UMeshComponentFactory : UPrimitiveComponentFactory
{
  public List<UMaterialInterface> Materials;
}

public class UMICforSFCubeMap : UMaterialInstanceConstant
{
}

public class UMITVforSFCubeMap : UMaterialInstanceTimeVarying
{
}

public partial class UModelComponent : UPrimitiveComponent
{
  public class FModelElement
  {
    public UModelComponent Component;
    public List<UObject.FGuid> IrrelevantLights;
    public UEngineTypes.FLightMap LightMap = new();
    public UMaterialInterface Material;
    public List<ushort> Nodes;
    public List<UShadowMap2D> ShadowMaps;
  }

  public UModel Model;
  public int ZoneIndex;
  public int BSPZoneIndex;
  public ushort ComponentIndex;
  public List<ushort> Nodes;
  public List<FModelElement> Elements;
}

public class UMorphNodeBase : UAnimObject
{
  public FName NodeName;
  public bool bDrawSlider;
}

public class UMorphNodeMultiPose : UMorphNodeBase
{
  public List<UMorphTarget> Targets;
  public List<FName> MorphNames;
  public List<float> Weights;
}

public class UMorphNodePose : UMorphNodeBase
{
  public UMorphTarget Target;
  public FName MorphName;
  public float Weight;
}

public class UMorphNodeWeightBase : UMorphNodeBase
{
  public class FMorphNodeConn
  {
    public List<UMorphNodeBase> ChildNodes;
    public FName ConnName;
    public int DrawY;
  }

  public List<FMorphNodeConn> NodeConns;
}

public class UMorphNodeWeight : UMorphNodeWeightBase
{
  public float NodeWeight;
}

public class UMorphNodeWeightByBoneAngle : UMorphNodeWeightBase
{
  public class FBoneAngleMorph
  {
    public float Angle;
    public float TargetWeight;
  }

  public float Angle;
  public float NodeWeight;
  public FName BaseBoneName;
  public EAxis BaseBoneAxis;
  public EAxis AngleBoneAxis;
  public bool bInvertBaseBoneAxis;
  public bool bInvertAngleBoneAxis;
  public bool bControlMaterialParameter;
  public FName AngleBoneName;
  public int MaterialSlotId;
  public FName ScalarParameterName;
  public UMaterialInstanceConstant MaterialInstanceConstant;
  public List<FBoneAngleMorph> WeightArray;
}

public class UMorphNodeWeightByBoneRotation : UMorphNodeWeightBase
{
  public float Angle;
  public float NodeWeight;
  public FName BoneName;
  public EAxis BoneAxis;
  public bool bInvertBoneAxis;
  public bool bControlMaterialParameter;
  public List<UMorphNodeWeightByBoneAngle.FBoneAngleMorph> WeightArray;
  public int MaterialSlotId;
  public FName ScalarParameterName;
  public UMaterialInstanceConstant MaterialInstanceConstant;
}

public partial class UMorphTarget : UObject
{
  public class FMorphTargetVertex
  {
    public UObject.FVector PositionDelta = new();
    public ushort SourceIdx;
    public UObject.FPackedNormal TangentZDelta = new();
  }

  public class FMorphTargetLODModel
  {
    public int NumBaseMeshVerts;
  }

  public List<int> MorphLODModels;
  public int MaterialSlotId;
  public FName ScalarParameterName;
  public UMaterialInstanceConstant MaterialInstanceConstant;
}

public class UMorphTargetSet : UObject
{
  public List<UMorphTarget> Targets;
  public USkeletalMesh BaseSkelMesh;
  public FArray_Mirror RawWedgePointIndices = new();
}

public class UMorphWeightSequence : UObject
{
}

public class UMotionBlurEffect : UPostProcessEffect
{
  public float MaxVelocity;
  public float MotionBlurAmount;
  public bool FullMotionBlur;
  public float CameraRotationThreshold;
  public float CameraTranslationThreshold;
}

public class UMultiFont : UFont
{
  public List<float> ResolutionTestTable;
}

public class UMusicTrackDataStructures : UObject
{
  public class FMusicTrackStruct
  {
    public USoundCue TheSoundCue;
    public bool bAutoPlay;
    public bool bPersistentAcrossLevels;
    public float FadeInTime;
    public float FadeInVolumeLevel;
    public float FadeOutTime;
    public float FadeOutVolumeLevel;
  }

}

public class AMutator : AInfo
{
  public AMutator NextMutator;
  public List<string> GroupNames;
  public bool bUserAdded;
  public string EventName;
}

public class UNavigationHandle : UObject
{
  public class FPolySegmentSpan
  {
    public UObject.FPointer Poly = new();
    public UObject.FVector P1 = new();
    public UObject.FVector P2 = new();
  }

  public class FEdgePointer
  {
    public UObject.FPointer Dummy = new();
  }

  public class FPathStore
  {
    public List<UNavigationHandle.FEdgePointer> EdgeList;
  }

  public class FNavMeshPathParams
  {
    public UObject.FPointer Interface = new();
    public bool bCanMantle;
    public bool bNeedsMantleValidityTest;
    public bool bAbleToSearch;
    public UObject.FVector SearchExtent = new();
    public float SearchLaneMultiplier;
    public UObject.FVector SearchStart = new();
    public float MaxDropHeight;
    public float MinWalkableZ;
    public float MaxHoverDistance;
  }

  public APylon AnchorPylon;
  public FPointer AnchorPoly = new();
  public FPathStore PathCache = new();
  public FPointer BestUnfinishedPathPoint = new();
  public FPointer CurrentEdge = new();
  public FPointer SubGoal_DestPoly = new();
  public AActor.FBasedPosition FinalDestination = new();
  public bool bSkipRouteCacheUpdates;
  public bool bUseORforEvaluateGoal;
  public bool bDebugConstraintsAndGoalEvals;
  public bool bUltraVerbosePathDebugging;
  public bool bDebug_Breadcrumbs;
  public UNavMeshPathConstraint PathConstraintList;
  public UNavMeshPathGoalEvaluator PathGoalList;
  public FNavMeshPathParams CachedPathParams = new();
  public EPathFindingError LastPathError;
  public float LastPathFailTime;
  public FVector[] Breadcrumbs = new FVector[10];
  public int BreadCrumbMostRecentIdx;
  public float BreadCrumbDistanceInterval;
}

public class ANavMeshBoundsVolume : AVolume
{
}

public class UNavMeshPathGoalEvaluator : UObject
{
  public class FBiasedGoalActor
  {
    public AActor Goal;
    public int ExtraCost;
  }

  public UNavMeshPathGoalEvaluator NextEvaluator;
  public int MaxPathVisits;
  public bool bAlwaysCallEvaluateGoal;
  public int NumNodesThrownOut;
  public int NumNodesProcessed;
}

public class UNavMeshGoal_At : UNavMeshPathGoalEvaluator
{
  public FVector Goal = new();
  public float GoalDist;
  public bool bKeepPartial;
  public bool bWeightPartialByDist;
  public bool bGoalInSamePolyAsAnchor;
  public float PartialDistSq;
  public FPointer GoalPoly = new();
  public FPointer PartialGoal = new();
}

public class UNavMeshGoal_ClosestActorInList : UNavMeshPathGoalEvaluator
{
  public List<FBiasedGoalActor> GoalList;
  public FMultiMap_Mirror PolyToGoalActorMap = new();
  public FPointer CachedAnchorPoly = new();
}

public class UNavMeshGoal_Filter : UObject
{
  public bool bShowDebug;
  public int NumNodesThrownOut;
  public int NumNodesProcessed;
}

public class UNavMeshGoal_GenericFilterContainer : UNavMeshPathGoalEvaluator
{
  public List<UNavMeshGoal_Filter> GoalFilters;
  public FPointer SuccessfulGoal = new();
  public UNavigationHandle MyNavigationHandle;
}

public class UNavMeshGoal_Null : UNavMeshPathGoalEvaluator
{
  public FPointer PartialGoal = new();
}

public class UNavMeshGoal_PolyEncompassesAI : UNavMeshPathGoalEvaluator
{
  public FVector OverrideExtentToCheck = new();
}

public class UNavMeshGoal_Random : UNavMeshPathGoalEvaluator
{
  public int MinDist;
  public float BestRating;
  public FPointer PartialGoal = new();
}

public class UNavMeshGoal_WithinDistanceEnvelope : UNavMeshPathGoalEvaluator
{
  public float MaxDistance;
  public float MinDistance;
  public float MinTraversalDist;
  public FVector EnvelopeTestPoint = new();
}

public class UNavMeshGoalFilter_MinPathDistance : UNavMeshGoal_Filter
{
  public int MinDistancePathShouldBe;
}

public class UNavMeshGoalFilter_NotNearOtherAI : UNavMeshGoal_Filter
{
  public float DistanceToCheck;
}

public class UNavMeshGoalFilter_OutOfViewFrom : UNavMeshGoal_Filter
{
  public FPointer GoalPoly = new();
  public FVector OutOfViewLocation = new();
}

public class UNavMeshGoalFilter_OutSideOfDotProductWedge : UNavMeshGoal_Filter
{
  public FVector Location = new();
  public FVector Rotation = new();
  public float Epsilon;
}

public class UNavMeshGoalFilter_PolyEncompassesAI : UNavMeshGoal_Filter
{
  public FVector OverrideExtentToCheck = new();
}

public class ANavMeshObstacle : AActor
{
  public class FCheckpointRecord
  {
    public bool bEnabled;
  }

  public FPointer VfTable_IInterface_NavMeshPathObstacle = new();
  public bool bEnabled;
  public bool bPreserveInternalGeo;
}

public class UNavMeshPathConstraint : UObject
{
  public UNavMeshPathConstraint NextConstraint;
  public int NumNodesProcessed;
  public int NumThrownOutNodes;
  public float AddedDirectCost;
  public float AddedHeuristicCost;
}

public class UNavMeshPath_AlongLine : UNavMeshPathConstraint
{
  public FVector Direction = new();
}

public class UNavMeshPath_EnforceTwoWayEdges : UNavMeshPathConstraint
{
}

public class UNavMeshPath_MinDistBetweenSpecsOfType : UNavMeshPathConstraint
{
  public float MinDistBetweenEdgeTypes;
  public FVector InitLocation = new();
  public ENavMeshEdgeType EdgeType;
  public float Penalty;
}

public class UNavMeshPath_SameCoverLink : UNavMeshPathConstraint
{
  public ACoverLink TestLink;
}

public class UNavMeshPath_Toward : UNavMeshPathConstraint
{
  public AActor GoalActor;
  public FVector GoalPoint = new();
}

public class UNavMeshPath_WithinDistanceEnvelope : UNavMeshPathConstraint
{
  public float MaxDistance;
  public float MinDistance;
  public bool bSoft;
  public bool bOnlyThrowOutNodesThatLeaveEnvelope;
  public float SoftStartPenalty;
  public FVector EnvelopeTestPoint = new();
}

public class UNavMeshPath_WithinTraversalDist : UNavMeshPathConstraint
{
  public float MaxTraversalDist;
  public bool bSoft;
  public float SoftStartPenalty;
}

public class UNavMeshRenderingComponent : UPrimitiveComponent
{
}

public class ANote : AActor
{
  public string Text;
}

public class ANxForceField : AActor
{
  public int ExcludeChannel;
  public bool bForceActive;
  public UPrimitiveComponent.FRBCollisionChannelContainer CollideWithChannels = new();
  public ERBCollisionChannel RBChannel;
  public FPointer ForceField = new();
  public List<FPointer> ConvexMeshes;
  public List<FPointer> ExclusionShapes;
  public List<FPointer> ExclusionShapePoses;
  public FPointer U2NRotation = new();
  public int SceneIndex;
}

public class ANxCylindricalForceField : ANxForceField
{
  public float RadialStrength;
  public float RotationalStrength;
  public float LiftStrength;
  public float ForceRadius;
  public float ForceTopRadius;
  public float LiftFalloffHeight;
  public float EscapeVelocity;
  public float ForceHeight;
  public float HeightOffset;
  public bool UseSpecialRadialForce;
  public FPointer Kernel = new();
}

public class ANxCylindricalForceFieldCapsule : ANxCylindricalForceField
{
  public UDrawCapsuleComponent RenderComponent;
}

public class ANxForceFieldGeneric : ANxForceField
{
  public UForceFieldShape Shape;
  public UActorComponent DrawComponent;
  public float RoughExtentX;
  public float RoughExtentY;
  public float RoughExtentZ;
  public FFG_ForceFieldCoordinates Coordinates;
  public FVector Constant = new();
  public FVector PositionMultiplierX = new();
  public FVector PositionMultiplierY = new();
  public FVector PositionMultiplierZ = new();
  public FVector PositionTarget = new();
  public FVector VelocityMultiplierX = new();
  public FVector VelocityMultiplierY = new();
  public FVector VelocityMultiplierZ = new();
  public FVector VelocityTarget = new();
  public FVector Noise = new();
  public FVector FalloffLinear = new();
  public FVector FalloffQuadratic = new();
  public float TorusRadius;
  public FPointer LinearKernel = new();
}

public class ANxForceFieldRadial : ANxForceField
{
  public UForceFieldShape Shape;
  public UActorComponent DrawComponent;
  public float ForceStrength;
  public float ForceRadius;
  public float SelfRotationStrength;
  public ERadialImpulseFalloff ForceFalloff;
  public FPointer Kernel = new();
}

public class ANxForceFieldTornado : ANxForceField
{
  public UForceFieldShape Shape;
  public UActorComponent DrawComponent;
  public float RadialStrength;
  public float RotationalStrength;
  public float LiftStrength;
  public float ForceRadius;
  public float ForceTopRadius;
  public float LiftFalloffHeight;
  public float EscapeVelocity;
  public float ForceHeight;
  public float HeightOffset;
  public bool BSpecialRadialForceMode;
  public float SelfRotationStrength;
  public FPointer Kernel = new();
}

public class ANxGenericForceField : ANxForceField
{
  public FFG_ForceFieldCoordinates Coordinates;
  public FVector Constant = new();
  public FVector PositionMultiplierX = new();
  public FVector PositionMultiplierY = new();
  public FVector PositionMultiplierZ = new();
  public FVector PositionTarget = new();
  public FVector VelocityMultiplierX = new();
  public FVector VelocityMultiplierY = new();
  public FVector VelocityMultiplierZ = new();
  public FVector VelocityTarget = new();
  public FVector Noise = new();
  public FVector FalloffLinear = new();
  public FVector FalloffQuadratic = new();
  public float TorusRadius;
  public FPointer LinearKernel = new();
}

public class ANxGenericForceFieldBox : ANxGenericForceField
{
  public UDrawBoxComponent RenderComponent;
  public FVector BoxExtent = new();
}

public class ANxGenericForceFieldBrush : AVolume
{
  public int ExcludeChannel;
  public UPrimitiveComponent.FRBCollisionChannelContainer CollideWithChannels = new();
  public ERBCollisionChannel RBChannel;
  public FFB_ForceFieldCoordinates Coordinates;
  public FVector Constant = new();
  public FVector PositionMultiplierX = new();
  public FVector PositionMultiplierY = new();
  public FVector PositionMultiplierZ = new();
  public FVector PositionTarget = new();
  public FVector VelocityMultiplierX = new();
  public FVector VelocityMultiplierY = new();
  public FVector VelocityMultiplierZ = new();
  public FVector VelocityTarget = new();
  public FVector Noise = new();
  public FVector FalloffLinear = new();
  public FVector FalloffQuadratic = new();
  public float TorusRadius;
  public FPointer ForceField = new();
  public List<FPointer> ConvexMeshes;
  public List<FPointer> ExclusionShapes;
  public List<FPointer> ExclusionShapePoses;
  public FPointer LinearKernel = new();
}

public class ANxGenericForceFieldCapsule : ANxGenericForceField
{
  public UDrawCapsuleComponent RenderComponent;
  public float CapsuleHeight;
  public float CapsuleRadius;
}

public class ANxRadialForceField : ANxForceField
{
  public UDrawSphereComponent RenderComponent;
  public float ForceStrength;
  public float ForceRadius;
  public ERadialImpulseFalloff ForceFalloff;
  public FPointer LinearKernel = new();
}

public class ANxRadialCustomForceField : ANxRadialForceField
{
  public float SelfRotationStrength;
  public FPointer Kernel = new();
}

public class ANxTornadoAngularForceField : ANxForceField
{
  public float RadialStrength;
  public float RotationalStrength;
  public float LiftStrength;
  public float ForceRadius;
  public float ForceTopRadius;
  public float LiftFalloffHeight;
  public float EscapeVelocity;
  public float ForceHeight;
  public float HeightOffset;
  public bool BSpecialRadialForceMode;
  public float SelfRotationStrength;
  public FPointer Kernel = new();
}

public class ANxTornadoAngularForceFieldCapsule : ANxTornadoAngularForceField
{
  public UDrawCapsuleComponent RenderComponent;
}

public class ANxTornadoForceField : ANxForceField
{
  public float RadialStrength;
  public float RotationalStrength;
  public float LiftStrength;
  public float ForceRadius;
  public float ForceTopRadius;
  public float LiftFalloffHeight;
  public float EscapeVelocity;
  public float ForceHeight;
  public float HeightOffset;
  public bool BSpecialRadialForceMode;
  public FPointer Kernel = new();
}

public class ANxTornadoForceFieldCapsule : ANxTornadoForceField
{
  public UDrawCapsuleComponent RenderComponent;
}

public class AObjective : ANavigationPoint
{
}

public class UObjectReferencer : UObject
{
  public List<UObject> ReferencedObjects;
}

public class UOnlineAccountInterface : UInterface
{
  public FScriptDelegate __OnCreateOnlineAccountCompleted__Delegate;
}

public class UOnlineCommunityContentInterface : UInterface
{
  public FScriptDelegate __OnReadContentListComplete__Delegate;
  public FScriptDelegate __OnReadFriendsContentListComplete__Delegate;
  public FScriptDelegate __OnUploadContentComplete__Delegate;
  public FScriptDelegate __OnDownloadContentComplete__Delegate;
  public FScriptDelegate __OnGetContentPayloadComplete__Delegate;
}

public class UOnlineContentInterface : UInterface
{
  public FScriptDelegate __OnContentChange__Delegate;
  public FScriptDelegate __OnReadContentComplete__Delegate;
  public FScriptDelegate __OnQueryAvailableDownloadsComplete__Delegate;
}

public class UOnlineEventsInterface : UInterface
{
}

public class UOnlineGameInterface : UInterface
{
  public FScriptDelegate __OnCreateOnlineGameComplete__Delegate;
  public FScriptDelegate __OnUpdateOnlineGameComplete__Delegate;
  public FScriptDelegate __OnDestroyOnlineGameComplete__Delegate;
  public FScriptDelegate __OnFindOnlineGamesComplete__Delegate;
  public FScriptDelegate __OnCancelFindOnlineGamesComplete__Delegate;
  public FScriptDelegate __OnJoinOnlineGameComplete__Delegate;
  public FScriptDelegate __OnRegisterPlayerComplete__Delegate;
  public FScriptDelegate __OnUnregisterPlayerComplete__Delegate;
  public FScriptDelegate __OnStartOnlineGameComplete__Delegate;
  public FScriptDelegate __OnEndOnlineGameComplete__Delegate;
  public FScriptDelegate __OnArbitrationRegistrationComplete__Delegate;
  public FScriptDelegate __OnGameInviteAccepted__Delegate;
}

public class UOnlineGameplayEvents : UObject
{
  public class FPlayerInformation
  {
    public string ControllerName;
    public string PlayerName;
    public UOnlineSubsystem.FUniqueNetId UniqueId = new();
    public bool bIsBot;
    public int LastPlayerEventIdx;
  }

  public class FGameplayEvent
  {
    public int PlayerEventAndTarget;
    public int EventNameAndDesc;
  }

  public class FPlayerEvent
  {
    public float EventTime;
    public UObject.FVector EventLocation = new();
    public int PlayerIndexAndYaw;
    public int PlayerPitchAndRoll;
  }

  public List<FPlayerInformation> PlayerList;
  public List<string> EventDescList;
  public List<FName> EventNames;
  public List<FGameplayEvent> GameplayEvents;
  public List<FPlayerEvent> PlayerEvents;
  public string GameplaySessionStartTime;
  public bool bGameplaySessionInProgress;
  public FGuid GameplaySessionID = new();
}

public class UOnlineGameSettings : USettings
{
  public int NumPublicConnections;
  public int NumPrivateConnections;
  public int NumOpenPublicConnections;
  public int NumOpenPrivateConnections;
  public ulong ServerNonce = new();
  public bool bShouldAdvertise;
  public bool bIsLanMatch;
  public bool bUsesStats;
  public bool bAllowJoinInProgress;
  public bool bAllowInvites;
  public bool bUsesPresence;
  public bool bAllowJoinViaPresence;
  public bool bAllowJoinViaPresenceFriendsOnly;
  public bool bUsesArbitration;
  public bool bAntiCheatProtected;
  public bool bWasFromInvite;
  public bool bIsDedicated;
  public bool bHasSkillUpdateInProgress;
  public string OwningPlayerName;
  public UOnlineSubsystem.FUniqueNetId OwningPlayerId = new();
  public int PingInMs;
  public float MatchQuality;
  public EOnlineGameState GameState;
  public int BuildUniqueId;
}

public class UOnlineNewsInterface : UInterface
{
  public FScriptDelegate __OnReadNewsCompleted__Delegate;
}

public class UOnlinePartyChatInterface : UInterface
{
  public FScriptDelegate __OnSendPartyGameInvitesComplete__Delegate;
  public FScriptDelegate __OnPartyMemberListChanged__Delegate;
  public FScriptDelegate __OnPartyMembersInfoChanged__Delegate;
}

public class UOnlinePlayerInterface : UInterface
{
  public FScriptDelegate __OnLoginChange__Delegate;
  public FScriptDelegate __OnLoginCancelled__Delegate;
  public FScriptDelegate __OnMutingChange__Delegate;
  public FScriptDelegate __OnFriendsChange__Delegate;
  public FScriptDelegate __OnLoginFailed__Delegate;
  public FScriptDelegate __OnLogoutCompleted__Delegate;
  public FScriptDelegate __OnLoginStatusChange__Delegate;
  public FScriptDelegate __OnReadProfileSettingsComplete__Delegate;
  public FScriptDelegate __OnWriteProfileSettingsComplete__Delegate;
  public FScriptDelegate __OnReadPlayerStorageComplete__Delegate;
  public FScriptDelegate __OnReadPlayerStorageForNetIdComplete__Delegate;
  public FScriptDelegate __OnWritePlayerStorageComplete__Delegate;
  public FScriptDelegate __OnReadFriendsComplete__Delegate;
  public FScriptDelegate __OnKeyboardInputComplete__Delegate;
  public FScriptDelegate __OnAddFriendByNameComplete__Delegate;
  public FScriptDelegate __OnFriendInviteReceived__Delegate;
  public FScriptDelegate __OnReceivedGameInvite__Delegate;
  public FScriptDelegate __OnJoinFriendGameComplete__Delegate;
  public FScriptDelegate __OnFriendMessageReceived__Delegate;
  public FScriptDelegate __OnUnlockAchievementComplete__Delegate;
  public FScriptDelegate __OnReadAchievementsComplete__Delegate;
}

public class UOnlinePlayerInterfaceEx : UInterface
{
  public FScriptDelegate __OnDeviceSelectionComplete__Delegate;
  public FScriptDelegate __OnProfileDataChanged__Delegate;
}

public class UOnlinePlayerStorage : UObject
{
  public class FOnlineProfileSetting
  {
    public EOnlineProfilePropertyOwner Owner;
    public USettings.FSettingsProperty ProfileSetting = new();
  }

  public int VersionNumber;
  public List<FOnlineProfileSetting> ProfileSettings;
  public List<USettings.FSettingsPropertyPropertyMetaData> ProfileMappings;
  public EOnlinePlayerStorageAsyncState AsyncState;
  public FScriptDelegate __NotifySettingValueUpdated__Delegate;
}

public class UUIResourceDataProvider : UUIPropertyDataProvider
{
  public FPointer VfTable_IUIListElementProvider = new();
  public FPointer VfTable_IUIListElementCellProvider = new();
  public bool bDataBindingPropertiesOnly;
  public bool bSkipDuringEnumeration;
}

public class UOnlinePlaylistGameTypeProvider : UUIResourceDataProvider
{
  public FName PlaylistGameTypeName;
  public string DisplayName;
  public string Description;
  public int GameTypeId;
}

public class UOnlinePlaylistManager : UObject
{
  public class FConfiguredGameSetting
  {
    public int GameSettingId;
    public string GameSettingsClassName;
    public string URL;
    public UOnlineGameSettings GameSettings;
  }

  public class FPlaylist
  {
    public List<UOnlinePlaylistManager.FConfiguredGameSetting> ConfiguredGames;
    public int PlaylistId;
    public string LocalizationString;
    public List<int> ContentIds;
    public int TeamSize;
    public int TeamCount;
    public string Name;
    public bool bIsArbitrated;
    public bool bDisableDedicatedServerSearches;
  }

  public List<FPlaylist> Playlists;
  public List<string> PlaylistFileNames;
  public List<FName> DatastoresToRefresh;
  public int DownloadCount;
  public int SuccessfulCount;
  public int VersionNumber;
  public FScriptDelegate __OnReadPlaylistComplete__Delegate;
}

public class UOnlinePlaylistProvider : UUIResourceDataProvider
{
  public int PlaylistId;
  public List<FName> PlaylistGameTypeNames;
  public string DisplayName;
  public bool bIsArbitrated;
  public int Priority;
}

public class UOnlineProfileSettings : UOnlinePlayerStorage
{
  public List<int> ProfileSettingIds;
  public List<FOnlineProfileSetting> DefaultSettings;
  public List<USettings.FIdToStringMapping> OwnerMappings;
}

public class UOnlineRecentPlayersList : UObject
{
  public class FRecentParty
  {
    public UOnlineSubsystem.FUniqueNetId PartyLeader = new();
    public List<UOnlineSubsystem.FUniqueNetId> PartyMembers;
  }

  public class FCurrentPlayerMet
  {
    public int TeamNum;
    public int Skill;
    public UOnlineSubsystem.FUniqueNetId NetId = new();
  }

  public List<UOnlineSubsystem.FUniqueNetId> RecentPlayers;
  public List<FRecentParty> RecentParties;
  public FRecentParty LastParty = new();
  public int MaxRecentPlayers;
  public int MaxRecentParties;
  public int RecentPlayersAddIndex;
  public int RecentPartiesAddIndex;
  public List<FCurrentPlayerMet> CurrentPlayers;
}

public class UOnlineStats : UObject
{
  public List<USettings.FStringIdToStringMapping> ViewIdMappings;
}

public class UOnlineStatsInterface : UInterface
{
  public FScriptDelegate __OnReadOnlineStatsComplete__Delegate;
  public FScriptDelegate __OnFlushOnlineStatsComplete__Delegate;
  public FScriptDelegate __OnRegisterHostStatGuidComplete__Delegate;
}

public class UOnlineStatsRead : UOnlineStats
{
  public class FOnlineStatsColumn
  {
    public int ColumnNo;
    public USettings.FSettingsData StatValue = new();
  }

  public class FOnlineStatsRow
  {
    public UOnlineSubsystem.FUniqueNetId PlayerID = new();
    public USettings.FSettingsData Rank = new();
    public string NickName;
    public List<UOnlineStatsRead.FOnlineStatsColumn> Columns;
  }

  public class FColumnMetaData
  {
    public int Id;
    public FName Name;
    public string ColumnName;
  }

  public int ViewId;
  public int SortColumnId;
  public List<int> ColumnIds;
  public int TotalRowsInView;
  public List<FOnlineStatsRow> Rows;
  public List<FColumnMetaData> ColumnMappings;
  public string ViewName;
  public int TitleId;
}

public class UOnlineStatsWrite : UOnlineStats
{
  public List<USettings.FStringIdToStringMapping> StatMappings;
  public List<USettings.FSettingsProperty> Properties;
  public List<int> ViewIds;
  public List<int> ArbitratedViewIds;
  public int RatingId;
  public FScriptDelegate __OnStatsWriteComplete__Delegate;
}

public class UOnlineSystemInterface : UInterface
{
  public FScriptDelegate __OnLinkStatusChange__Delegate;
  public FScriptDelegate __OnExternalUIChange__Delegate;
  public FScriptDelegate __OnControllerChange__Delegate;
  public FScriptDelegate __OnConnectionStatusChange__Delegate;
  public FScriptDelegate __OnStorageDeviceChange__Delegate;
  public FScriptDelegate __OnReadTitleFileComplete__Delegate;
}

public class UOnlineVoiceInterface : UInterface
{
  public FScriptDelegate __OnPlayerTalkingStateChange__Delegate;
  public FScriptDelegate __OnRecognitionComplete__Delegate;
}

public class UOutLineEffect : UPostProcessEffect
{
  public int BlurKernelSize;
  public FColor[] ModulateBlurColor = new FColor[7];
  public float ColorIntense;
  public float BlurSize;
  public float DepthBias;
  public float GaussFilterIntense;
  public FVector4[] ModulateBlurColorVector = new FVector4[7];
}

public class UParticleEmitter : UObject
{
  public class FParticleBurst
  {
    public int Count;
    public int CountLow;
    public float Time;
  }

  public FName EmitterName;
  public int SubUVDataOffset;
  public EEmitterRenderMode EmitterRenderMode;
  public EEmitterGoreMode EmitterGoreMode;
  public FColor EmitterEditorColor = new();
  public List<UParticleLODLevel> LODLevels;
  public bool ConvertedModules;
  public bool bCollapsed;
  public bool bIsSoloing;
  public bool bCookedOut;
  public bool bIrrelevantFromDS;
  public int PeakActiveParticles;
  public int InitialAllocationCount;
}

public class AParticleEventManager : AActor
{
}

public class UParticleLightEnvironmentComponent : UDynamicLightEnvironmentComponent
{
  public int ReferenceCount;
  public bool bAllowDLESharing;
}

public class UParticleLODLevel : UObject
{
  public int Level;
  public bool bEnabled;
  public bool ConvertedModules;
  public bool bIrrelevantFromDS;
  public UParticleModuleRequired RequiredModule;
  public List<UParticleModule> Modules;
  public UParticleModule TypeDataModule;
  public UParticleModuleSpawn SpawnModule;
  public UParticleModuleEventGenerator EventGenerator;
  public List<UParticleModuleSpawnBase> SpawningModules;
  public List<UParticleModule> SpawnModules;
  public List<UParticleModule> UpdateModules;
  public List<UParticleModuleOrbit> OrbitModules;
  public List<UParticleModuleEventReceiverBase> EventReceiverModules;
  public int PeakActiveParticles;
}

public class UParticleModule : UObject
{
  public class FParticleCurvePair
  {
    public string CurveName;
    public UObject CurveObject;
  }

  public bool bSpawnModule;
  public bool bUpdateModule;
  public bool bFinalUpdateModule;
  public bool bCurvesAsColor;
  public bool b3DDrawMode;
  public bool bSupported3DDrawMode;
  public bool bEnabled;
  public bool bEditable;
  public bool LODDuplicate;
  public bool bIrrelevantFromDS;
  public byte LODValidity;
  public FColor ModuleEditorColor = new();
}

public class UParticleModuleAccelerationBase : UParticleModule
{
  public bool bAlwaysInWorldSpace;
}

public class UParticleModuleAcceleration : UParticleModuleAccelerationBase
{
  public UDistributionVector.FRawDistributionVector Acceleration = new();
  public bool bApplyOwnerScale;
}

public class UParticleModuleAccelerationOverLifetime : UParticleModuleAccelerationBase
{
  public UDistributionVector.FRawDistributionVector AccelOverLife = new();
}

public class UParticleModuleAttractorBase : UParticleModule
{
}

public class UParticleModuleAttractorLine : UParticleModuleAttractorBase
{
  public FVector EndPoint0 = new();
  public FVector EndPoint1 = new();
  public UDistributionFloat.FRawDistributionFloat Range = new();
  public UDistributionFloat.FRawDistributionFloat Strength = new();
}

public class UParticleModuleAttractorParticle : UParticleModuleAttractorBase
{
  public FName EmitterName;
  public UDistributionFloat.FRawDistributionFloat Range = new();
  public bool bStrengthByDistance;
  public bool bAffectBaseVelocity;
  public bool bRenewSource;
  public bool bInheritSourceVel;
  public UDistributionFloat.FRawDistributionFloat Strength = new();
  public EAttractorParticleSelectionMethod SelectionMethod;
  public int LastSelIndex;
}

public class UParticleModuleAttractorPoint : UParticleModuleAttractorBase
{
  public UDistributionVector.FRawDistributionVector Position = new();
  public UDistributionFloat.FRawDistributionFloat Range = new();
  public UDistributionFloat.FRawDistributionFloat Strength = new();
  public bool StrengthByDistance;
  public bool bAffectBaseVelocity;
  public bool bOverrideVelocity;
  public bool bUseWorldSpacePosition;
}

public class UParticleModuleBeamBase : UParticleModule
{
}

public class UParticleModuleBeamModifier : UParticleModuleBeamBase
{
  public class FBeamModifierOptions
  {
    public bool bModify;
    public bool bScale;
    public bool bLock;
  }

  public BeamModifierType ModifierType;
  public FBeamModifierOptions PositionOptions = new();
  public UDistributionVector.FRawDistributionVector Position = new();
  public FBeamModifierOptions TangentOptions = new();
  public UDistributionVector.FRawDistributionVector Tangent = new();
  public bool bAbsoluteTangent;
  public FBeamModifierOptions StrengthOptions = new();
  public UDistributionFloat.FRawDistributionFloat Strength = new();
}

public class UParticleModuleBeamNoise : UParticleModuleBeamBase
{
  public bool bLowFreq_Enabled;
  public bool bNRScaleEmitterTime;
  public bool bSmooth;
  public bool bNoiseLock;
  public bool bOscillate;
  public bool bUseNoiseTangents;
  public bool bTargetNoise;
  public bool bApplyNoiseScale;
  public int Frequency;
  public int Frequency_LowRange;
  public UDistributionVector.FRawDistributionVector NoiseRange = new();
  public UDistributionFloat.FRawDistributionFloat NoiseRangeScale = new();
  public UDistributionVector.FRawDistributionVector NoiseSpeed = new();
  public float NoiseLockRadius;
  public float NoiseLockTime;
  public float NoiseTension;
  public UDistributionFloat.FRawDistributionFloat NoiseTangentStrength = new();
  public int NoiseTessellation;
  public float FrequencyDistance;
  public UDistributionFloat.FRawDistributionFloat NoiseScale = new();
}

public class UParticleModuleBeamSource : UParticleModuleBeamBase
{
  public Beam2SourceTargetMethod SourceMethod;
  public Beam2SourceTargetTangentMethod SourceTangentMethod;
  public FName SourceName;
  public bool bSourceAbsolute;
  public bool bLockSource;
  public bool bLockSourceTangent;
  public bool bLockSourceStength;
  public UDistributionVector.FRawDistributionVector Source = new();
  public UDistributionVector.FRawDistributionVector SourceTangent = new();
  public UDistributionFloat.FRawDistributionFloat SourceStrength = new();
}

public class UParticleModuleBeamTarget : UParticleModuleBeamBase
{
  public Beam2SourceTargetMethod TargetMethod;
  public Beam2SourceTargetTangentMethod TargetTangentMethod;
  public FName TargetName;
  public UDistributionVector.FRawDistributionVector Target = new();
  public bool bTargetAbsolute;
  public bool bLockTarget;
  public bool bLockTargetTangent;
  public bool bLockTargetStength;
  public UDistributionVector.FRawDistributionVector TargetTangent = new();
  public UDistributionFloat.FRawDistributionFloat TargetStrength = new();
  public float LockRadius;
}

public class UParticleModuleCollisionBase : UParticleModule
{
}

public class UParticleModuleCollision : UParticleModuleCollisionBase
{
  public UDistributionVector.FRawDistributionVector DampingFactor = new();
  public UDistributionVector.FRawDistributionVector DampingFactorRotation = new();
  public UDistributionFloat.FRawDistributionFloat MaxCollisions = new();
  public EParticleCollisionComplete CollisionCompletionOption;
  public bool bApplyPhysics;
  public bool bPawnsDoNotDecrementCount;
  public bool bOnlyVerticalNormalsDecrementCount;
  public bool bDropDetail;
  public UDistributionFloat.FRawDistributionFloat ParticleMass = new();
  public float DirScalar;
  public float VerticalFudgeFactor;
  public UDistributionFloat.FRawDistributionFloat DelayAmount = new();
}

public class UParticleModuleColorBase : UParticleModule
{
}

public class UParticleModuleColor : UParticleModuleColorBase
{
  public UDistributionVector.FRawDistributionVector StartColor = new();
  public UDistributionFloat.FRawDistributionFloat StartAlpha = new();
  public bool bClampAlpha;
}

public class UParticleModuleColorByParameter : UParticleModuleColorBase
{
  public FName ColorParam;
  public FColor DefaultColor = new();
}

public class UParticleModuleColorOverLife : UParticleModuleColorBase
{
  public UDistributionVector.FRawDistributionVector ColorOverLife = new();
  public UDistributionFloat.FRawDistributionFloat AlphaOverLife = new();
  public bool bClampAlpha;
}

public class UParticleModuleColorScaleOverLife : UParticleModuleColorBase
{
  public UDistributionVector.FRawDistributionVector ColorScaleOverLife = new();
  public UDistributionFloat.FRawDistributionFloat AlphaScaleOverLife = new();
  public bool bEmitterTime;
}

public class UParticleModuleEventBase : UParticleModule
{
}

public class UParticleModuleEventGenerator : UParticleModuleEventBase
{
  public class FParticleEvent_GenerateInfo
  {
    public EParticleEventType Type;
    public int Frequency;
    public int LowFreq;
    public int ParticleFrequency;
    public bool FirstTimeOnly;
    public bool LastTimeOnly;
    public bool UseReflectedImpactVector;
    public FName CustomName;
    public List<UParticleModuleEventSendToGame> ParticleModuleEventsToSendToGame;
  }

  public List<FParticleEvent_GenerateInfo> Events;
}

public class UParticleModuleEventReceiverBase : UParticleModuleEventBase
{
  public EParticleEventType EventGeneratorType;
  public FName EventName;
}

public class UParticleModuleEventReceiverKillParticles : UParticleModuleEventReceiverBase
{
  public bool bStopSpawning;
}

public class UParticleModuleEventReceiverSpawn : UParticleModuleEventReceiverBase
{
  public EParticleEventType EventGeneratorType;
  public FName EventName;
  public UDistributionFloat.FRawDistributionFloat SpawnCount = new();
  public bool bUseParticleTime;
  public bool bUsePSysLocation;
  public bool bInheritVelocity;
  public UDistributionVector.FRawDistributionVector InheritVelocityScale = new();
}

public class UParticleModuleEventSendToGame : UObject
{
}

public class UParticleModuleKillBase : UParticleModule
{
}

public class UParticleModuleKillBox : UParticleModuleKillBase
{
  public UDistributionVector.FRawDistributionVector LowerLeftCorner = new();
  public UDistributionVector.FRawDistributionVector UpperRightCorner = new();
  public bool bAbsolute;
  public bool bKillInside;
}

public class UParticleModuleKillHeight : UParticleModuleKillBase
{
  public UDistributionFloat.FRawDistributionFloat Height = new();
  public bool bAbsolute;
  public bool bFloor;
}

public class UParticleModuleLifetimeBase : UParticleModule
{
}

public class UParticleModuleLifetime : UParticleModuleLifetimeBase
{
  public UDistributionFloat.FRawDistributionFloat Lifetime = new();
}

public class UParticleModuleLocationBase : UParticleModule
{
}

public class UParticleModuleLocation : UParticleModuleLocationBase
{
  public UDistributionVector.FRawDistributionVector StartLocation = new();
}

public class UParticleModuleLocationDirect : UParticleModuleLocationBase
{
  public UDistributionVector.FRawDistributionVector Location = new();
  public UDistributionVector.FRawDistributionVector LocationOffset = new();
  public UDistributionVector.FRawDistributionVector ScaleFactor = new();
  public UDistributionVector.FRawDistributionVector Direction = new();
}

public class UParticleModuleLocationEmitter : UParticleModuleLocationBase
{
  public FName EmitterName;
  public ELocationEmitterSelectionMethod SelectionMethod;
  public bool InheritSourceVelocity;
  public bool bInheritSourceRotation;
  public float InheritSourceVelocityScale;
  public float InheritSourceRotationScale;
}

public class UParticleModuleLocationEmitterDirect : UParticleModuleLocationBase
{
  public FName EmitterName;
}

public class UParticleModuleLocationPrimitiveBase : UParticleModuleLocationBase
{
  public bool Positive_X;
  public bool Positive_Y;
  public bool Positive_Z;
  public bool Negative_X;
  public bool Negative_Y;
  public bool Negative_Z;
  public bool SurfaceOnly;
  public bool Velocity;
  public UDistributionFloat.FRawDistributionFloat VelocityScale = new();
  public UDistributionVector.FRawDistributionVector StartLocation = new();
}

public class UParticleModuleLocationPrimitiveCylinder : UParticleModuleLocationPrimitiveBase
{
  public bool RadialVelocity;
  public UDistributionFloat.FRawDistributionFloat StartRadius = new();
  public UDistributionFloat.FRawDistributionFloat StartHeight = new();
  public CylinderHeightAxis HeightAxis;
}

public class UParticleModuleLocationPrimitiveSphere : UParticleModuleLocationPrimitiveBase
{
  public UDistributionFloat.FRawDistributionFloat StartRadius = new();
}

public class UParticleModuleMaterialBase : UParticleModule
{
}

public class UParticleModuleMaterialByParameter : UParticleModuleMaterialBase
{
  public List<FName> MaterialParameters;
  public List<UMaterialInterface> DefaultMaterials;
}

public class UParticleModuleMeshMaterial : UParticleModuleMaterialBase
{
  public List<UMaterialInterface> MeshMaterials;
}

public class UParticleModuleRotationBase : UParticleModule
{
}

public class UParticleModuleMeshRotation : UParticleModuleRotationBase
{
  public UDistributionVector.FRawDistributionVector StartRotation = new();
  public bool bInheritParent;
}

public class UParticleModuleRotationRateBase : UParticleModule
{
}

public class UParticleModuleMeshRotationRate : UParticleModuleRotationRateBase
{
  public UDistributionVector.FRawDistributionVector StartRotationRate = new();
}

public class UParticleModuleMeshRotationRateMultiplyLife : UParticleModuleRotationRateBase
{
  public UDistributionVector.FRawDistributionVector LifeMultiplier = new();
}

public class UParticleModuleMeshRotationRateOverLife : UParticleModuleRotationRateBase
{
  public UDistributionVector.FRawDistributionVector RotRate = new();
  public bool bScaleRotRate;
}

public class UParticleModuleOrbitBase : UParticleModule
{
  public bool bUseEmitterTime;
}

public class UParticleModuleOrbit : UParticleModuleOrbitBase
{
  public class FOrbitOptions
  {
    public bool bProcessDuringSpawn;
    public bool bProcessDuringUpdate;
    public bool bUseEmitterTime;
  }

  public EOrbitChainMode ChainMode;
  public UDistributionVector.FRawDistributionVector OffsetAmount = new();
  public FOrbitOptions OffsetOptions = new();
  public UDistributionVector.FRawDistributionVector RotationAmount = new();
  public FOrbitOptions RotationOptions = new();
  public UDistributionVector.FRawDistributionVector RotationRateAmount = new();
  public FOrbitOptions RotationRateOptions = new();
}

public class UParticleModuleOrientationBase : UParticleModule
{
}

public class UParticleModuleOrientationAxisLock : UParticleModuleOrientationBase
{
  public EParticleAxisLock LockAxisFlags;
}

public class UParticleModuleParameterBase : UParticleModule
{
}

public class UParticleModuleParameterDynamic : UParticleModuleParameterBase
{
  public class FEmitterDynamicParameter
  {
    public FName ParamName;
    public bool bUseEmitterTime;
    public bool bSpawnTimeOnly;
    public EEmitterDynamicParameterValue ValueMethod;
    public bool bScaleVelocityByParamValue;
    public UDistributionFloat.FRawDistributionFloat ParamValue = new();
  }

  public List<FEmitterDynamicParameter> DynamicParams;
}

public class UParticleSpriteEmitter : UParticleEmitter
{
}

public class UParticleModuleRequired : UParticleModule
{
  public UMaterialInterface Material;
  public EParticleScreenAlignment ScreenAlignment;
  public EParticleSortMode SortMode;
  public EParticleBurstMethod ParticleBurstMethod;
  public EParticleSubUVInterpMethod InterpolationMethod;
  public EEmitterNormalsMode EmitterNormalsMode;
  public bool bUseLocalSpace;
  public bool bKillOnDeactivate;
  public bool bKillOnCompleted;
  public bool bRequiresSorting;
  public bool bUseLegacyEmitterTime;
  public bool bEmitterDurationUseRange;
  public bool bDurationRecalcEachLoop;
  public bool bEmitterDelayUseRange;
  public bool bDelayFirstLoopOnly;
  public bool bScaleUV;
  public bool bDirectUV;
  public bool bUseMaxDrawCount;
  public float EmitterDuration;
  public float EmitterDurationLow;
  public int EmitterLoops;
  public UDistributionFloat.FRawDistributionFloat SpawnRate = new();
  public List<UParticleEmitter.FParticleBurst> BurstList;
  public float EmitterDelay;
  public float EmitterDelayLow;
  public int SubImages_Horizontal;
  public int SubImages_Vertical;
  public float RandomImageTime;
  public int RandomImageChanges;
  public int MaxDrawCount;
  public float DownsampleThresholdScreenFraction;
  public FVector NormalsSphereCenter = new();
  public FVector NormalsCylinderDirection = new();
}

public class UParticleModuleRotation : UParticleModuleRotationBase
{
  public UDistributionFloat.FRawDistributionFloat StartRotation = new();
}

public class UParticleModuleRotationOverLifetime : UParticleModuleRotationBase
{
  public UDistributionFloat.FRawDistributionFloat RotationOverLife = new();
  public bool Scale;
}

public class UParticleModuleRotationRate : UParticleModuleRotationRateBase
{
  public UDistributionFloat.FRawDistributionFloat StartRotationRate = new();
}

public class UParticleModuleRotationRateMultiplyLife : UParticleModuleRotationRateBase
{
  public UDistributionFloat.FRawDistributionFloat LifeMultiplier = new();
}

public class UParticleModuleSizeBase : UParticleModule
{
}

public class UParticleModuleSize : UParticleModuleSizeBase
{
  public UDistributionVector.FRawDistributionVector StartSize = new();
}

public class UParticleModuleSizeMultiplyLife : UParticleModuleSizeBase
{
  public UDistributionVector.FRawDistributionVector LifeMultiplier = new();
  public bool MultiplyX;
  public bool MultiplyY;
  public bool MultiplyZ;
}

public class UParticleModuleSizeMultiplyVelocity : UParticleModuleSizeBase
{
  public UDistributionVector.FRawDistributionVector VelocityMultiplier = new();
  public bool MultiplyX;
  public bool MultiplyY;
  public bool MultiplyZ;
}

public class UParticleModuleSizeScale : UParticleModuleSizeBase
{
  public UDistributionVector.FRawDistributionVector SizeScale = new();
  public bool EnableX;
  public bool EnableY;
  public bool EnableZ;
}

public class UParticleModuleSizeScaleByTime : UParticleModuleSizeBase
{
  public UDistributionVector.FRawDistributionVector SizeScaleByTime = new();
  public bool bEnableX;
  public bool bEnableY;
  public bool bEnableZ;
}

public class UParticleModuleSourceMovement : UParticleModuleLocationBase
{
  public UDistributionVector.FRawDistributionVector SourceMovementScale = new();
}

public class UParticleModuleSpawnBase : UParticleModule
{
  public bool bProcessSpawnRate;
  public bool bProcessBurstList;
}

public class UParticleModuleSpawn : UParticleModuleSpawnBase
{
  public UDistributionFloat.FRawDistributionFloat Rate = new();
  public UDistributionFloat.FRawDistributionFloat RateScale = new();
  public EParticleBurstMethod ParticleBurstMethod;
  public List<UParticleEmitter.FParticleBurst> BurstList;
}

public class UParticleModuleSpawnPerUnit : UParticleModuleSpawnBase
{
  public float UnitScalar;
  public UDistributionFloat.FRawDistributionFloat SpawnPerUnit = new();
  public bool bIgnoreSpawnRateWhenMoving;
  public float MovementTolerance;
}

public class UParticleModuleStoreSpawnTimeBase : UParticleModule
{
}

public class UParticleModuleStoreSpawnTime : UParticleModuleStoreSpawnTimeBase
{
}

public class UParticleModuleSubUVBase : UParticleModule
{
}

public class UParticleModuleSubUV : UParticleModuleSubUVBase
{
  public UDistributionFloat.FRawDistributionFloat SubImageIndex = new();
}

public class UParticleModuleSubUVDirect : UParticleModuleSubUVBase
{
  public UDistributionVector.FRawDistributionVector SubUVPosition = new();
  public UDistributionVector.FRawDistributionVector SubUVSize = new();
}

public class UParticleModuleSubUVMovie : UParticleModuleSubUV
{
  public bool bUseEmitterTime;
  public UDistributionFloat.FRawDistributionFloat FrameRate = new();
  public int StartingFrame;
}

public class UParticleModuleSubUVSelect : UParticleModuleSubUVBase
{
  public UDistributionVector.FRawDistributionVector SubImageSelect = new();
}

public class UParticleModuleTrailBase : UParticleModule
{
}

public class UParticleModuleTrailSource : UParticleModuleTrailBase
{
  public ETrail2SourceMethod SourceMethod;
  public EParticleSourceSelectionMethod SelectionMethod;
  public FName SourceName;
  public UDistributionFloat.FRawDistributionFloat SourceStrength = new();
  public bool bLockSourceStength;
  public bool bInheritRotation;
  public int SourceOffsetCount;
  public List<FVector> SourceOffsetDefaults;
}

public class UParticleModuleTrailSpawn : UParticleModuleTrailBase
{
  public UDistributionFloatParticleParameter SpawnDistanceMap;
  public float MinSpawnVelocity;
}

public class UParticleModuleTrailTaper : UParticleModuleTrailBase
{
  public ETrailTaperMethod TaperMethod;
  public UDistributionFloat.FRawDistributionFloat TaperFactor = new();
}

public class UParticleModuleTypeDataBase : UParticleModule
{
}

public class UParticleModuleTypeDataAnimTrail : UParticleModuleTypeDataBase
{
  public FName ControlEdgeName;
  public int SheetsPerTrail;
  public bool bDeadTrailsOnDeactivate;
  public bool bClipSourceSegement;
  public bool bEnablePreviousTangentRecalculation;
  public bool bTangentRecalculationEveryFrame;
  public bool bRenderGeometry;
  public bool bRenderSpawnPoints;
  public bool bRenderTangents;
  public bool bRenderTessellation;
  public float TilingDistance;
  public float DistanceTessellationStepSize;
  public float TangentTessellationScalar;
}

public class UParticleModuleTypeDataBeam : UParticleModuleTypeDataBase
{
  public EBeamMethod BeamMethod;
  public EBeamEndPointMethod EndPointMethod;
  public UDistributionFloat.FRawDistributionFloat Distance = new();
  public UDistributionVector.FRawDistributionVector EndPoint = new();
  public int TessellationFactor;
  public UDistributionFloat.FRawDistributionFloat EmitterStrength = new();
  public UDistributionFloat.FRawDistributionFloat TargetStrength = new();
  public UDistributionVector.FRawDistributionVector EndPointDirection = new();
  public int TextureTile;
  public bool RenderGeometry;
  public bool RenderDirectLine;
  public bool RenderLines;
  public bool RenderTessellation;
}

public class UParticleModuleTypeDataBeam2 : UParticleModuleTypeDataBase
{
  public class FBeamTargetData
  {
    public FName TargetName;
    public float TargetPercentage;
  }

  public EBeam2Method BeamMethod;
  public EBeamTaperMethod TaperMethod;
  public int TextureTile;
  public float TextureTileDistance;
  public int Sheets;
  public int MaxBeamCount;
  public float Speed;
  public int InterpolationPoints;
  public bool bAlwaysOn;
  public bool RenderGeometry;
  public bool RenderDirectLine;
  public bool RenderLines;
  public bool RenderTessellation;
  public int UpVectorStepSize;
  public FName BranchParentName;
  public UDistributionFloat.FRawDistributionFloat Distance = new();
  public UDistributionFloat.FRawDistributionFloat TaperFactor = new();
  public UDistributionFloat.FRawDistributionFloat TaperScale = new();
}

public class UParticleModuleTypeDataMesh : UParticleModuleTypeDataBase
{
  public UStaticMesh Mesh;
  public bool CastShadows;
  public bool DoCollisions;
  public bool bAllowMotionBlur;
  public bool bOverrideMaterial;
  public bool bCameraFacing;
  public bool bApplyParticleRotationAsSpin;
  public EMeshScreenAlignment MeshAlignment;
  public EParticleAxisLock AxisLockOption;
  public EMeshCameraFacingUpAxis CameraFacingUpAxisOption;
  public EMeshCameraFacingOptions CameraFacingOption;
  public float Pitch;
  public float Roll;
  public float Yaw;
}

public class UParticleModuleTypeDataMeshPhysX : UParticleModuleTypeDataMesh
{
  public UPhysXParticleSystem PhysXParSys;
  public EPhysXMeshRotationMethod PhysXRotationMethod;
  public float FluidRotationCoefficient;
  public FPointer RenderInstance = new();
  public UParticleModuleTypeDataPhysX.FPhysXEmitterVerticalLodProperties VerticalLod = new();
}

public class UParticleModuleTypeDataPhysX : UParticleModuleTypeDataBase
{
  public class FPhysXEmitterVerticalLodProperties
  {
    public float WeightForFifo;
    public float WeightForSpawnLod;
    public float SpawnLodRateVsLifeBias;
    public float RelativeFadeoutTime;
  }

  public UPhysXParticleSystem PhysXParSys;
  public FPhysXEmitterVerticalLodProperties VerticalLod = new();
}

public class UParticleModuleTypeDataRibbon : UParticleModuleTypeDataBase
{
  public int MaxTessellationBetweenParticles;
  public int SheetsPerTrail;
  public int MaxTrailCount;
  public int MaxParticleInTrailCount;
  public bool bDeadTrailsOnDeactivate;
  public bool bClipSourceSegement;
  public bool bEnablePreviousTangentRecalculation;
  public bool bTangentRecalculationEveryFrame;
  public bool bRenderGeometry;
  public bool bRenderSpawnPoints;
  public bool bRenderTangents;
  public bool bRenderTessellation;
  public ETrailsRenderAxisOption RenderAxis;
  public float TangentSpawningScalar;
  public float TilingDistance;
  public float DistanceTessellationStepSize;
  public float TangentTessellationScalar;
}

public class UParticleModuleTypeDataTrail : UParticleModuleTypeDataBase
{
  public bool RenderGeometry;
  public bool RenderLines;
  public bool RenderTessellation;
  public bool Tapered;
  public bool SpawnByDistance;
  public int TessellationFactor;
  public UDistributionFloat.FRawDistributionFloat Tension = new();
  public FVector SpawnDistance = new();
}

public class UParticleModuleTypeDataTrail2 : UParticleModuleTypeDataBase
{
  public int TessellationFactor;
  public float TessellationFactorDistance;
  public float TessellationStrength;
  public int TextureTile;
  public int Sheets;
  public int MaxTrailCount;
  public int MaxParticleInTrailCount;
  public bool bClipSourceSegement;
  public bool RenderGeometry;
  public bool RenderDirectLine;
  public bool RenderLines;
  public bool RenderTessellation;
}

public class UParticleModuleUberBase : UParticleModule
{
  public List<FName> RequiredModules;
}

public class UParticleModuleUberLTISIVCL : UParticleModuleUberBase
{
  public UDistributionFloat.FRawDistributionFloat Lifetime = new();
  public UDistributionVector.FRawDistributionVector StartSize = new();
  public UDistributionVector.FRawDistributionVector StartVelocity = new();
  public UDistributionFloat.FRawDistributionFloat StartVelocityRadial = new();
  public UDistributionVector.FRawDistributionVector ColorOverLife = new();
  public UDistributionFloat.FRawDistributionFloat AlphaOverLife = new();
}

public class UParticleModuleUberLTISIVCLIL : UParticleModuleUberBase
{
  public UDistributionFloat.FRawDistributionFloat Lifetime = new();
  public UDistributionVector.FRawDistributionVector StartSize = new();
  public UDistributionVector.FRawDistributionVector StartVelocity = new();
  public UDistributionFloat.FRawDistributionFloat StartVelocityRadial = new();
  public UDistributionVector.FRawDistributionVector ColorOverLife = new();
  public UDistributionFloat.FRawDistributionFloat AlphaOverLife = new();
  public UDistributionVector.FRawDistributionVector StartLocation = new();
}

public class UParticleModuleUberLTISIVCLILIRSSBLIRR : UParticleModuleUberBase
{
  public UDistributionFloat.FRawDistributionFloat Lifetime = new();
  public UDistributionVector.FRawDistributionVector StartSize = new();
  public UDistributionVector.FRawDistributionVector StartVelocity = new();
  public UDistributionFloat.FRawDistributionFloat StartVelocityRadial = new();
  public UDistributionVector.FRawDistributionVector ColorOverLife = new();
  public UDistributionFloat.FRawDistributionFloat AlphaOverLife = new();
  public UDistributionVector.FRawDistributionVector StartLocation = new();
  public UDistributionFloat.FRawDistributionFloat StartRotation = new();
  public UDistributionVector.FRawDistributionVector SizeLifeMultiplier = new();
  public bool SizeMultiplyX;
  public bool SizeMultiplyY;
  public bool SizeMultiplyZ;
  public UDistributionFloat.FRawDistributionFloat StartRotationRate = new();
}

public class UParticleModuleUberRainDrops : UParticleModuleUberBase
{
  public float LifetimeMin;
  public float LifetimeMax;
  public FVector StartSizeMin = new();
  public FVector StartSizeMax = new();
  public FVector StartVelocityMin = new();
  public FVector StartVelocityMax = new();
  public float StartVelocityRadialMin;
  public float StartVelocityRadialMax;
  public FVector ColorOverLife = new();
  public float AlphaOverLife;
  public bool bIsUsingCylinder;
  public bool bPositive_X;
  public bool bPositive_Y;
  public bool bPositive_Z;
  public bool bNegative_X;
  public bool bNegative_Y;
  public bool bNegative_Z;
  public bool bSurfaceOnly;
  public bool bVelocity;
  public bool bRadialVelocity;
  public float PC_VelocityScale;
  public FVector PC_StartLocation = new();
  public float PC_StartRadius;
  public float PC_StartHeight;
  public CylinderHeightAxis PC_HeightAxis;
  public FVector StartLocationMin = new();
  public FVector StartLocationMax = new();
}

public class UParticleModuleUberRainImpacts : UParticleModuleUberBase
{
  public UDistributionFloat.FRawDistributionFloat Lifetime = new();
  public UDistributionVector.FRawDistributionVector StartSize = new();
  public UDistributionVector.FRawDistributionVector StartRotation = new();
  public bool bInheritParent;
  public bool MultiplyX;
  public bool MultiplyY;
  public bool MultiplyZ;
  public bool bIsUsingCylinder;
  public bool bPositive_X;
  public bool bPositive_Y;
  public bool bPositive_Z;
  public bool bNegative_X;
  public bool bNegative_Y;
  public bool bNegative_Z;
  public bool bSurfaceOnly;
  public bool bVelocity;
  public bool bRadialVelocity;
  public UDistributionVector.FRawDistributionVector LifeMultiplier = new();
  public UDistributionFloat.FRawDistributionFloat PC_VelocityScale = new();
  public UDistributionVector.FRawDistributionVector PC_StartLocation = new();
  public UDistributionFloat.FRawDistributionFloat PC_StartRadius = new();
  public UDistributionFloat.FRawDistributionFloat PC_StartHeight = new();
  public CylinderHeightAxis PC_HeightAxis;
  public UDistributionVector.FRawDistributionVector ColorOverLife = new();
  public UDistributionFloat.FRawDistributionFloat AlphaOverLife = new();
}

public class UParticleModuleUberRainSplashA : UParticleModuleUberBase
{
  public UDistributionFloat.FRawDistributionFloat Lifetime = new();
  public UDistributionVector.FRawDistributionVector StartSize = new();
  public UDistributionVector.FRawDistributionVector StartRotation = new();
  public bool bInheritParent;
  public bool MultiplyX;
  public bool MultiplyY;
  public bool MultiplyZ;
  public UDistributionVector.FRawDistributionVector LifeMultiplier = new();
  public UDistributionVector.FRawDistributionVector ColorOverLife = new();
  public UDistributionFloat.FRawDistributionFloat AlphaOverLife = new();
}

public class UParticleModuleUberRainSplashB : UParticleModuleUberBase
{
  public UDistributionFloat.FRawDistributionFloat Lifetime = new();
  public UDistributionVector.FRawDistributionVector StartSize = new();
  public UDistributionVector.FRawDistributionVector ColorOverLife = new();
  public UDistributionFloat.FRawDistributionFloat AlphaOverLife = new();
  public UDistributionVector.FRawDistributionVector LifeMultiplier = new();
  public bool MultiplyX;
  public bool MultiplyY;
  public bool MultiplyZ;
  public UDistributionFloat.FRawDistributionFloat StartRotationRate = new();
}

public class UParticleModuleVelocityBase : UParticleModule
{
  public bool bInWorldSpace;
  public bool bApplyOwnerScale;
}

public class UParticleModuleVelocity : UParticleModuleVelocityBase
{
  public UDistributionVector.FRawDistributionVector StartVelocity = new();
  public UDistributionFloat.FRawDistributionFloat StartVelocityRadial = new();
}

public class UParticleModuleVelocityInheritParent : UParticleModuleVelocityBase
{
  public UDistributionVector.FRawDistributionVector Scale = new();
}

public class UParticleModuleVelocityOverLifetime : UParticleModuleVelocityBase
{
  public UDistributionVector.FRawDistributionVector VelOverLife = new();
  public bool Absolute;
}

public class UParticleSystem : UObject
{
  public class FParticleSystemLOD
  {
    public bool bLit;
  }

  public class FLODSoloTrack
  {
    public List<byte> SoloEnableSetting;
  }

  public EParticleSystemUpdateMode SystemUpdateMode;
  public ParticleSystemLODMethod LODMethod;
  public EParticleSystemOcclusionBoundsMethod OcclusionBoundsMethod;
  public EDetailMode DetailMode;
  public float UpdateTime_FPS;
  public float UpdateTime_Delta;
  public float WarmupTime;
  public List<UParticleEmitter> Emitters;
  public UParticleSystemComponent PreviewComponent;
  public FRotator ThumbnailAngle = new();
  public float ThumbnailDistance;
  public float ThumbnailWarmup;
  public bool bLit;
  public bool bOrientZAxisTowardCamera;
  public bool bIgnoreLODBias;
  public bool bRegenerateLODDuplicate;
  public bool bUseFixedRelativeBoundingBox;
  public bool bShouldResetPeakCounts;
  public bool bHasPhysics;
  public bool bUseRealtimeThumbnail;
  public bool ThumbnailImageOutOfDate;
  public bool bSkipSpawnCountCheck;
  public bool bUseDelayRange;
  public UInterpCurveEdSetup CurveEdSetup;
  public float LODDistanceCheckTime;
  public List<float> LODDistances;
  public int EditorLODSetting;
  public List<FParticleSystemLOD> LODSettings;
  public FBox FixedRelativeBoundingBox = new();
  public float SecondsBeforeInactive;
  public string FloorMesh;
  public FVector FloorPosition = new();
  public FRotator FloorRotation = new();
  public float FloorScale;
  public FVector FloorScale3D = new();
  public FColor BackgroundColor = new();
  public UTexture2D ThumbnailImage;
  public float Delay;
  public float DelayLow;
  public FVector MacroUVPosition = new();
  public float MacroUVRadius;
  public FBox CustomOcclusionBounds = new();
  public List<FLODSoloTrack> SoloTracking;
}

public class UParticleSystemReplay : UObject
{
  public class FParticleEmitterReplayFrame
  {
    public int EmitterType;
    public int OriginalEmitterIndex;
    public UObject.FPointer FrameState = new();
  }

  public class FParticleSystemReplayFrame
  {
    public List<UParticleSystemReplay.FParticleEmitterReplayFrame> Emitters;
  }

  public int ClipIDNumber;
  public List<FParticleSystemReplayFrame> Frames;
}

public class UPathConstraint : UObject
{
  public int CacheIdx;
  public UPathConstraint NextConstraint;
}

public class UPath_AlongLine : UPathConstraint
{
  public FVector Direction = new();
}

public class UPath_AvoidInEscapableNodes : UPathConstraint
{
  public int Radius;
  public int Height;
  public int MaxFallSpeed;
  public int MoveFlags;
}

public class UPath_MinDistBetweenSpecsOfType : UPathConstraint
{
  public float MinDistBetweenSpecTypes;
  public FVector InitLocation = new();
  public UClass ReachSpecClass;
}

public class UPath_TowardGoal : UPathConstraint
{
  public AActor GoalActor;
}

public class UPath_TowardPoint : UPathConstraint
{
  public FVector GoalPoint = new();
}

public class UPath_WithinDistanceEnvelope : UPathConstraint
{
  public float MaxDistance;
  public float MinDistance;
  public bool bSoft;
  public bool bOnlyThrowOutNodesThatLeaveEnvelope;
  public float SoftStartPenalty;
  public FVector EnvelopeTestPoint = new();
}

public class UPath_WithinTraversalDist : UPathConstraint
{
  public float MaxTraversalDist;
  public bool bSoft;
  public float SoftStartPenalty;
}

public class APathBlockingVolume : AVolume
{
}

public class APathNode : ANavigationPoint
{
}

public class APathNode_Dynamic : APathNode
{
}

public class UPathRenderingComponent : UPrimitiveComponent
{
}

public class APathTargetPoint : AKeypoint
{
}

public class UPBRuleNodeBase : UObject
{
  public class FPBRuleLink
  {
    public UPBRuleNodeBase NextRule;
    public FName LinkName;
    public int DrawY;
  }

  public List<FPBRuleLink> NextRules;
  public string Comment;
  public int RulePosX;
  public int RulePosY;
  public int InDrawY;
  public int DrawWidth;
  public int DrawHeight;
}

public class UProcBuildingRuleset : UObject
{
  public class FPBVariationInfo
  {
    public FName VariationName;
    public bool bMeshOnTopOfFacePoly;
  }

  public class FPBParamSwatch
  {
    public FName SwatchName;
    public List<AProcBuilding.FPBMaterialParam> Params;
  }

  public UPBRuleNodeBase RootRule;
  public bool bBeingEdited;
  public bool bEnableInteriorTexture;
  public bool bLODOnlyRoof;
  public bool bPickRandomSwatch;
  public UMaterialInterface DefaultRoofMaterial;
  public UMaterialInterface DefaultFloorMaterial;
  public UMaterialInterface DefaultNonRectWallMaterial;
  public float RoofZOffset;
  public float NotRoofZOffset;
  public float FloorZOffset;
  public float NotFloorZOffset;
  public float RoofPolyInset;
  public float FloorPolyInset;
  public float BuildingLODSpecular;
  public float RoofEdgeScopeRaise;
  public UTexture LODCubemap;
  public UTexture InteriorTexture;
  public List<FPBVariationInfo> Variations;
  public List<FPBParamSwatch> ParamSwatches;
  public List<UPBRuleNodeComment> Comments;
}

public class AProcBuilding : AVolume
{
  public class FPBScope2D
  {
    public UObject.FMatrix ScopeFrame = new();
    public float DimX;
    public float DimZ;
  }

  public class FPBScopeProcessInfo
  {
    public AProcBuilding OwningBuilding;
    public UProcBuildingRuleset Ruleset;
    public FName RulesetVariation;
    public bool bGenerateLODPoly;
    public bool bPartOfNonRect;
  }

  public class FPBFaceUVInfo
  {
    public UObject.FVector2D Offset = new();
    public UObject.FVector2D Size = new();
  }

  public class FPBEdgeInfo
  {
    public UObject.FVector EdgeEnd = new();
    public UObject.FVector EdgeStart = new();
    public int ScopeAIndex;
    public EScopeEdge ScopeAEdge;
    public int ScopeBIndex;
    public EScopeEdge ScopeBEdge;
    public float EdgeAngle;
  }

  public class FPBMeshCompInfo
  {
    public UStaticMeshComponent MeshComp;
    public int TopLevelScopeIndex;
  }

  public class FPBFracMeshCompInfo
  {
    public UFracturedStaticMeshComponent FracMeshComp;
    public int TopLevelScopeIndex;
  }

  public class FPBMaterialParam
  {
    public FName ParamName;
    public UObject.FLinearColor Color = new();
  }

  public class FPBMemUsageInfo
  {
    public AProcBuilding Building;
    public UProcBuildingRuleset Ruleset;
    public int NumStaticMeshComponent;
    public int NumInstancedStaticMeshComponents;
    public int NumInstancedTris;
    public int LightmapMemBytes;
    public int ShadowmapMemBytes;
    public int LODDiffuseMemBytes;
    public int LODLightingMemBytes;
  }

  public UProcBuildingRuleset Ruleset;
  public List<FPBMeshCompInfo> BuildingMeshCompInfos;
  public List<FPBFracMeshCompInfo> BuildingFracMeshCompInfos;
  public UStaticMeshComponent SimpleMeshComp;
  public bool bGenerateRoofMesh;
  public bool bGenerateFloorMesh;
  public bool bApplyRulesToRoof;
  public bool bApplyRulesToFloor;
  public bool bSplitWallsAtRoofLevels;
  public bool bSplitWallsAtWallEdges;
  public bool bQuickEdited;
  public bool bBuildingBrushCollision;
  public bool bDebugDrawEdgeInfo;
  public bool bDebugDrawScopes;
  public List<UStaticMeshComponent> LODMeshComps;
  public List<FPBFaceUVInfo> LODMeshUVInfos;
  public List<FPBScope2D> TopLevelScopes;
  public int NumMeshedTopLevelScopes;
  public List<FPBFaceUVInfo> TopLevelScopeUVInfos;
  public List<FPBScopeProcessInfo> TopLevelScopeInfos;
  public List<FPBEdgeInfo> EdgeInfos;
  public float MaxFacadeZ;
  public float MinFacadeZ;
  public List<AProcBuilding> OverlappingBuildings;
  public float SimpleMeshMassiveLODDistance;
  public float RenderToTexturePullBackAmount;
  public int RoofLightmapRes;
  public int NonRectWallLightmapRes;
  public float LODRenderToTextureScale;
  public FName ParamSwatchName;
  public List<FPBMaterialParam> BuildingMaterialParams;
  public List<UMaterialInstanceConstant> BuildingMatParamMICs;
  public AStaticMeshActor LowLODPersistentActor;
  public UStaticMeshComponent CurrentSimpleMeshComp;
  public AActor CurrentSimpleMeshActor;
  public List<AProcBuilding> AttachedBuildings;
  public int BuildingInstanceVersion;
}

public class UPBRuleNodeAlternate : UPBRuleNodeBase
{
  public EProcBuildingAxis RepeatAxis;
  public float ASize;
  public float BMaxSize;
  public bool bInvertPatternOrder;
  public bool bEqualSizeAB;
}

public class UPBRuleNodeComment : UPBRuleNodeBase
{
  public int SizeX;
  public int SizeY;
  public int BorderWidth;
  public FColor BorderColor = new();
  public bool bFilled;
  public FColor FillColor = new();
}

public class UPBRuleNodeCorner : UPBRuleNodeBase
{
  public class FRBCornerAngleInfo
  {
    public float Angle;
    public float CornerSize;
  }

  public float CornerSize;
  public List<FRBCornerAngleInfo> Angles;
  public float FlatThreshold;
  public bool bNoMeshForConcaveCorners;
  public bool bUseAdjacentRulesetForRightGap;
  public EPBCornerType CornerType;
  public float CornerShapeOffset;
  public int RoundTesselation;
  public float RoundCurvature;
}

public class UPBRuleNodeCycle : UPBRuleNodeBase
{
  public EProcBuildingAxis RepeatAxis;
  public float RepeatSize;
  public int CycleSize;
  public bool bFixRepeatSize;
}

public class UPBRuleNodeEdgeAngle : UPBRuleNodeBase
{
  public class FRBEdgeAngleInfo
  {
    public float Angle;
  }

  public EProcBuildingEdge Edge;
  public List<FRBEdgeAngleInfo> Angles;
}

public class UPBRuleNodeEdgeMesh : UPBRuleNodeBase
{
  public float FlatThreshold;
  public float MainXPullIn;
}

public class UPBRuleNodeExtractTopBottom : UPBRuleNodeBase
{
  public float ExtractTopZ;
  public float ExtractNotTopZ;
  public float ExtractBottomZ;
  public float ExtractNotBottomZ;
}

public class UPBRuleNodeLODQuad : UPBRuleNodeBase
{
  public float MassiveLODDistanceScale;
}

public class UPBRuleNodeMesh : UPBRuleNodeBase
{
  public class FBuildingMatOverrides
  {
    public List<UMaterialInterface> MaterialOptions;
  }

  public class FBuildingMeshInfo
  {
    public UStaticMesh Mesh;
    public float DimX;
    public float DimZ;
    public float Chance;
    public UDistributionVector Translation;
    public UDistributionVector Rotation;
    public bool bMeshScaleTranslation;
    public bool bOverrideMeshLightMapRes;
    public int OverriddenMeshLightMapRes;
    public List<UMaterialInterface> MaterialOverrides;
    public List<UPBRuleNodeMesh.FBuildingMatOverrides> SectionOverrides;
  }

  public List<FBuildingMeshInfo> BuildingMeshes;
  public FBuildingMeshInfo PartialOccludedBuildingMesh = new();
  public bool bDoOcclusionTest;
  public bool bBlockAll;
}

public class UPBRuleNodeOcclusion : UPBRuleNodeBase
{
}

public class UPBRuleNodeQuad : UPBRuleNodeBase
{
  public UMaterialInterface Material;
  public float RepeatMaxSizeX;
  public float RepeatMaxSizeZ;
  public int QuadLightmapRes;
  public float YOffset;
  public bool bDisableMaterialRepeat;
}

public class UPBRuleNodeRandom : UPBRuleNodeBase
{
  public int NumOutputs;
  public int MinNumExecuted;
  public int MaxNumExecuted;
}

public class UPBRuleNodeRepeat : UPBRuleNodeBase
{
  public EProcBuildingAxis RepeatAxis;
  public float RepeatMaxSize;
}

public class UPBRuleNodeSize : UPBRuleNodeBase
{
  public EProcBuildingAxis SizeAxis;
  public float DecisionSize;
  public bool bUseTopLevelScopeSize;
}

public class UPBRuleNodeSplit : UPBRuleNodeBase
{
  public class FRBSplitInfo
  {
    public bool bFixSize;
    public float FixedSize;
    public float ExpandRatio;
    public FName SplitName;
  }

  public EProcBuildingAxis SplitAxis;
  public List<FRBSplitInfo> SplitSetup;
}

public class UPBRuleNodeSubRuleset : UPBRuleNodeBase
{
  public UProcBuildingRuleset SubRuleset;
}

public class UPBRuleNodeTransform : UPBRuleNodeBase
{
  public UDistributionVector Translation;
  public UDistributionVector Rotation;
  public UDistributionVector Scale;
}

public class UPBRuleNodeVariation : UPBRuleNodeBase
{
  public bool bVariationOfScopeOnLeft;
}

public class UPBRuleNodeWindowWall : UPBRuleNodeBase
{
  public float CellMaxSizeX;
  public float CellMaxSizeZ;
  public float WindowSizeX;
  public float WindowSizeZ;
  public float WindowPosX;
  public float WindowPosZ;
  public bool bScaleWindowWithCell;
  public float YOffset;
  public UMaterialInterface Material;
}

public class UPhysicalMaterial : UObject
{
  public int MaterialIndex;
  public float Friction;
  public float Restitution;
  public bool bForceConeFriction;
  public bool bEnableAnisotropicFriction;
  public FVector AnisoFrictionDir = new();
  public float FrictionV;
  public float Density;
  public float AngularDamping;
  public float LinearDamping;
  public float MagneticResponse;
  public float WindResponse;
  public float ImpactThreshold;
  public float ImpactReFireDelay;
  public UParticleSystem ImpactEffect;
  public USoundCue ImpactSound;
  public float SlideThreshold;
  public float SlideReFireDelay;
  public UParticleSystem SlideEffect;
  public USoundCue SlideSound;
  public USoundCue FractureSoundExplosion;
  public USoundCue FractureSoundSingle;
  public UPhysicalMaterial Parent;
  public UPhysicalMaterialPropertyBase PhysicalMaterialProperty;
}

public class UPhysicalMaterialPropertyBase : UObject
{
}

public class UPhysicsAsset : UObject
{
  public USkeletalMesh DefaultSkelMesh;
  public List<URB_BodySetup> BodySetup;
  public FMap_Mirror BodySetupIndexMap = new();
  public List<int> BoundsBodies;
  public List<URB_ConstraintSetup> ConstraintSetup;
  public UPhysicsAssetInstance DefaultInstance;
}

public partial class UPhysicsAssetInstance : UObject
{
  public class FRigidBodyIndexPair
  {
    public int[] Indices = new int[2];
  }

  public AActor Owner;
  public int RootBodyIndex;
  public List<URB_BodyInstance> Bodies;
  public List<URB_ConstraintInstance> Constraints;
  public Dictionary<FRigidBodyIndexPair, bool> CollisionDisableTable;
  public float LinearSpringScale;
  public float LinearDampingScale;
  public float LinearForceLimitScale;
  public float AngularSpringScale;
  public float AngularDampingScale;
  public float AngularForceLimitScale;
  public bool bInitBodies;
}

public class UPhysXDestructible : UObject
{
  public class FPhysXDestructibleDepthParameters
  {
    public bool bTakeImpactDamage;
    public bool bPlaySoundEffect;
    public bool bPlayParticleEffect;
    public bool bDoNotTimeOut;
    public bool bNoKillDummy;
  }

  public class FPhysXDestructibleParameters
  {
    public float DamageThreshold;
    public float DamageToRadius;
    public float DamageCap;
    public float ForceToDamage;
    public USoundCue FractureSound;
    public UParticleSystem CrumbleParticleSystem;
    public float CrumbleParticleSize;
    public bool bAccumulateDamage;
    public float ScaledDamageToRadius;
    public List<UPhysXDestructible.FPhysXDestructibleDepthParameters> DepthParameters;
  }

  public UFracturedStaticMesh FracturedStaticMesh;
  public List<UPhysXDestructibleAsset> DestructibleAssets;
  public FPhysXDestructibleParameters DestructibleParameters = new();
  public List<FVector> CookingScales;
}

public class APhysXDestructibleActor : AFracturedStaticMeshActor
{
  public class FSpawnBasis
  {
    public UObject.FVector Location = new();
    public UObject.FRotator Rotation = new();
    public float Scale;
  }

  public UPhysXDestructibleComponent DestructibleComponent;
  public ULightEnvironmentComponent LightEnvironment;
  public UPhysXDestructible PhysXDestructible;
  public UPhysXDestructibleStructure Structure;
  public List<int> PartFirstChunkIndices;
  public List<APhysXDestructiblePart> Parts;
  public List<int> Neighbors;
  public UPhysXDestructible.FPhysXDestructibleParameters DestructibleParameters = new();
  public float LinearSize;
  public bool bPlayFractureSound;
  public bool bSupportChunksTouchWorld;
  public bool bSupportChunksInSupportFragment;
  public List<FSpawnBasis> EffectBases;
  public FPointer VolumeFill = new();
  public int PerFrameProcessBudget;
  public int SupportDepth;
  public byte NumPartsRemaining;
}

public class UPhysXDestructibleAsset : UObject
{
  public class FPhysXDestructibleAssetChunk
  {
    public int Index;
    public int FragmentIndex;
    public float Volume;
    public float Size;
    public int Depth;
    public int ParentIndex;
    public int FirstChildIndex;
    public int NumChildren;
    public int MeshIndex;
    public int BoneIndex;
    public FName BoneName;
    public int BodyIndex;
  }

  public List<FPhysXDestructibleAssetChunk> ChunkTree;
  public List<USkeletalMesh> Meshes;
  public List<UPhysicsAsset> Assets;
  public int MaxDepth;
}

public class UPhysXDestructibleComponent : UPrimitiveComponent
{
  public URB_BodySetup DetailedCollision;
  public List<byte> Fragmented;
  public List<int> BoxElemStart;
  public List<int> ConvexElemStart;
}

public class APhysXDestructiblePart : AActor
{
  public int FirstChunk;
  public int NumChunks;
  public UPhysXDestructibleStructure Structure;
  public APhysXDestructibleActor DestructibleActor;
  public UPhysXDestructibleAsset DestructibleAsset;
  public ULightEnvironmentComponent LightEnvironment;
  public List<USkeletalMeshComponent> SkeletalMeshComponents;
  public List<byte> NumChunksRemaining;
  public byte NumMeshesRemaining;
}

public class UPhysXDestructibleStructure : UObject
{
  public class FPhysXDestructibleChunk
  {
    public bool WorldCentroidValid;
    public bool WorldMatrixValid;
    public bool bCrumble;
    public bool IsEnvironmentSupported;
    public bool IsRouting;
    public bool IsRouteValid;
    public bool IsRouteBlocker;
    public int ActorIndex;
    public int FragmentIndex;
    public int Index;
    public int MeshIndex;
    public int BoneIndex;
    public FName BoneName;
    public int BodyIndex;
    public UObject.FVector RelativeCentroid = new();
    public UObject.FVector WorldCentroid = new();
    public UObject.FMatrix RelativeMatrix = new();
    public UObject.FMatrix WorldMatrix = new();
    public float Radius;
    public int ParentIndex;
    public int FirstChildIndex;
    public int NumChildren;
    public int Depth;
    public float Age;
    public float Damage;
    public float Size;
    public EPhysXDestructibleChunkState CurrentState;
    public UObject.FPointer Structure = new();
    public int FIFOIndex;
    public int FirstOverlapIndex;
    public int NumOverlaps;
    public int ShortestRoute;
    public int NumSupporters;
    public int NumChildrenDup;
  }

  public class FPhysXDestructibleOverlap
  {
    public int ChunkIndex0;
    public int ChunkIndex1;
    public int Adjacent;
  }

  public FPointer Manager = new();
  public List<APhysXDestructibleActor> Actors;
  public List<APhysXDestructibleActor> ActorKillList;
  public List<FPhysXDestructibleChunk> Chunks;
  public List<FPhysXDestructibleOverlap> Overlaps;
  public List<int> Active;
  public List<int> PseudoSupporterFifo;
  public int PseudoSupporterFifoStart;
  public List<int> FractureOriginFifo;
  public int FractureOriginFifoStart;
  public List<int> FractureOriginChunks;
  public List<int> RouteUpdateArea;
  public int PerFrameProcessBudget;
  public List<int> PassiveFractureChunks;
  public List<int> RouteUpdateFifo;
  public int RouteUpdateFifoStart;
  public int SupportDepth;
}

public class APhysXEmitterSpawnable : AEmitter
{
  public class FIndexedRBState
  {
    public UObject.FVector CenterOfMass = new();
    public UObject.FVector LinearVelocity = new();
    public UObject.FVector AngularVelocity = new();
    public int Index;
  }

  public class FRBVolumeFill
  {
    public List<APhysXEmitterSpawnable.FIndexedRBState> RBStates;
    public List<UObject.FVector> Positions;
  }

  public FPointer VolumeFill = new();
  public UParticleSystem ParticleTemplate;
}

public class UPhysXParticleSystem : UObject
{
  public int MaxParticles;
  public int ParticleSpawnReserve;
  public ERBCollisionChannel RBChannel;
  public ESimulationMethod SimulationMethod;
  public EPacketSizeMultiplier PacketSizeMultiplier;
  public UPrimitiveComponent.FRBCollisionChannelContainer RBCollideWithChannels = new();
  public float CollisionDistance;
  public float RestitutionWithStaticShapes;
  public float RestitutionWithDynamicShapes;
  public float FrictionWithStaticShapes;
  public float FrictionWithDynamicShapes;
  public bool bDynamicCollision;
  public bool bDisableGravity;
  public bool bStaticCollision;
  public bool bTwoWayCollision;
  public bool bDestroy;
  public bool bSyncFailed;
  public bool bIsInGame;
  public float MaxMotionDistance;
  public float Damping;
  public FVector ExternalAcceleration = new();
  public float RestParticleDistance;
  public float RestDensity;
  public float KernelRadiusMultiplier;
  public float Stiffness;
  public float Viscosity;
  public float CollisionResponseCoefficient;
  public FPointer CascadeScene = new();
  public FPointer PSys = new();
}

public class UPickupDataProvider : UUIDynamicDataProvider
{
}

public class APickupFactory : ANavigationPoint
{
  public bool bOnlyReplicateHidden;
  public bool bPickupHidden;
  public bool bPredictRespawns;
  public bool bIsSuperItem;
  public bool bRespawnPaused;
  public UClass InventoryType;
  public float RespawnEffectTime;
  public float MaxDesireability;
  public UPrimitiveComponent PickupMesh;
  public APickupFactory ReplacementFactory;
  public APickupFactory OriginalFactory;
}

public class UPlayerDataProvider : UUIDynamicDataProvider
{
}

public class UPlayerManagerInteraction : UInteraction
{
}

public class UPlayerOwnerDataProvider : UPlayerDataProvider
{
  public UPlayerDataProvider PlayerData;
}

public class UPlayerOwnerDataStore : UUIDataStore_GameState
{
  public class FPlayerDataProviderTypes
  {
    public UClass PlayerOwnerDataProviderClass;
    public UClass CurrentWeaponDataProviderClass;
    public UClass WeaponDataProviderClass;
    public UClass PowerupDataProviderClass;
  }

  public FPlayerDataProviderTypes ProviderTypes = new();
  public UPlayerOwnerDataProvider PlayerData;
  public UCurrentWeaponDataProvider CurrentWeapon;
  public List<UWeaponDataProvider> WeaponList;
  public List<UPowerupDataProvider> PowerupList;
}

public class APlayerReplicationInfo : AReplicationInfo
{
  public class FAutomatedTestingDatum
  {
    public int NumberOfMatchesPlayed;
    public int NumMapListCyclesDone;
  }

  public float Score;
  public int Deaths;
  public byte Ping;
  public ETTSSpeaker TTSSpeaker;
  public AActor PlayerLocationHint;
  public int NumLives;
  public string PlayerName;
  public string OldName;
  public int PlayerID;
  public ATeamInfo Team;
  public int SplitscreenIndex;
  public bool bAdmin;
  public bool bIsFemale;
  public bool bIsSpectator;
  public bool bOnlySpectator;
  public bool bWaitingPlayer;
  public bool bReadyToPlay;
  public bool bOutOfLives;
  public bool bBot;
  public bool bHasFlag;
  public bool bHasBeenWelcomed;
  public bool bIsInactive;
  public bool bFromPreviousLevel;
  public int StartTime;
  public string StringSpectating;
  public string StringUnknown;
  public int Kills;
  public UClass GameMessageClass;
  public float ExactPing;
  public string SavedNetworkAddress;
  public UOnlineSubsystem.FUniqueNetId UniqueId = new();
  public FName SessionName;
  public FAutomatedTestingDatum AutomatedTestingData = new();
  public int StatConnectionCounts;
  public int StatPingTotals;
  public int StatPingMin;
  public int StatPingMax;
  public int StatPKLTotal;
  public int StatPKLMin;
  public int StatPKLMax;
  public int StatMaxInBPS;
  public int StatAvgInBPS;
  public int StatMaxOutBPS;
  public int StatAvgOutBPS;
  public UTexture2D Avatar;
}

public class APlayerStart : ANavigationPoint
{
  public bool bEnabled;
  public bool bPrimaryStart;
  public int TeamIndex;
}

public class APointLightMovable : APointLight
{
}

public class APointLightToggleable : APointLight
{
  public class FCheckpointRecord
  {
    public bool bEnabled;
  }

}

public class APortalMarker : ANavigationPoint
{
  public APortalTeleporter MyPortal;
}

public class ASceneCaptureActor : AActor
{
  public USceneCaptureComponent SceneCapture;
}

public class USceneCaptureComponent : UActorComponent
{
  public bool bEnabled;
  public bool bEnablePostProcess;
  public bool bEnableFog;
  public bool bUseMainScenePostProcessSettings;
  public bool bSkipUpdateIfTextureUsersOccluded;
  public bool bSkipUpdateIfOwnerOccluded;
  public bool bSkipRenderingDepthPrepass;
  public bool bIsOneFrameCapture;
  public bool bNeedsSceneUpdate;
  public FColor ClearColor = new();
  public ESceneCaptureViewMode ViewMode;
  public int SceneLOD;
  public float FrameRate;
  public UPostProcessChain PostProcess;
  public float MaxUpdateDist;
  public float MaxViewDistanceOverride;
  public float MaxStreamingUpdateDist;
  public FPointer CaptureInfo = new();
  public FPointer ViewState = new();
  public List<FPointer> PostProcessProxies;
}

public class USceneCaptureReflectComponent : USceneCaptureComponent
{
  public UTextureRenderTarget2D TextureTarget;
  public float ScaleFOV;
}

public class ASceneCaptureReflectActor : ASceneCaptureActor
{
  public UStaticMeshComponent StaticMesh;
  public UMaterialInstanceConstant ReflectMaterialInst;
}

public class USceneCapturePortalComponent : USceneCaptureComponent
{
  public UTextureRenderTarget2D TextureTarget;
  public float ScaleFOV;
  public AActor ViewDestination;
}

public class ASceneCapturePortalActor : ASceneCaptureReflectActor
{
}

public class APortalTeleporter : ASceneCapturePortalActor
{
  public APortalTeleporter SisterPortal;
  public int TextureResolutionX;
  public int TextureResolutionY;
  public APortalMarker MyMarker;
  public bool bMovablePortal;
  public bool bAlwaysTeleportNonPawns;
  public bool bCanTeleportVehicles;
}

public class APortalVolume : AVolume
{
  public List<APortalTeleporter> Portals;
}

public class UPostProcessChain : UObject
{
  public List<UPostProcessEffect> Effects;
}

public class APostProcessVolume : AVolume
{
  public class FLUTBlender
  {
    public List<UTexture> LUTTextures;
    public List<float> LUTWeights;
  }

  public class FPostProcessSettings
  {
    public bool bOverride_EnableBloom;
    public bool bOverride_EnableDOF;
    public bool bOverride_EnableMotionBlur;
    public bool bOverride_EnableSceneEffect;
    public bool bOverride_AllowAmbientOcclusion;
    public bool bOverride_OverrideRimShaderColor;
    public bool bOverride_Bloom_Scale;
    public bool bOverride_Bloom_InterpolationDuration;
    public bool bOverride_DOF_FalloffExponent;
    public bool bOverride_DOF_BlurKernelSize;
    public bool bOverride_DOF_BlurBloomKernelSize;
    public bool bOverride_DOF_MaxNearBlurAmount;
    public bool bOverride_DOF_MaxFarBlurAmount;
    public bool bOverride_DOF_ModulateBlurColor;
    public bool bOverride_DOF_FocusType;
    public bool bOverride_DOF_FocusInnerRadius;
    public bool bOverride_DOF_FocusDistance;
    public bool bOverride_DOF_FocusPosition;
    public bool bOverride_DOF_InterpolationDuration;
    public bool bOverride_MotionBlur_MaxVelocity;
    public bool bOverride_MotionBlur_Amount;
    public bool bOverride_MotionBlur_FullMotionBlur;
    public bool bOverride_MotionBlur_CameraRotationThreshold;
    public bool bOverride_MotionBlur_CameraTranslationThreshold;
    public bool bOverride_MotionBlur_InterpolationDuration;
    public bool bOverride_Scene_Desaturation;
    public bool bOverride_Scene_HighLights;
    public bool bOverride_Scene_MidTones;
    public bool bOverride_Scene_Shadows;
    public bool bOverride_Scene_InterpolationDuration;
    public bool bOverride_RimShader_Color;
    public bool bOverride_RimShader_InterpolationDuration;
    public bool bEnableBloom;
    public bool bEnableDOF;
    public bool bEnableMotionBlur;
    public bool bEnableSceneEffect;
    public bool bAllowAmbientOcclusion;
    public bool bOverrideRimShaderColor;
    public float Bloom_Scale;
    public float Bloom_InterpolationDuration;
    public float DOF_FalloffExponent;
    public float DOF_BlurKernelSize;
    public float DOF_BlurBloomKernelSize;
    public float DOF_MaxNearBlurAmount;
    public float DOF_MaxFarBlurAmount;
    public UObject.FColor DOF_ModulateBlurColor = new();
    public EFocusType DOF_FocusType;
    public float DOF_FocusInnerRadius;
    public float DOF_FocusDistance;
    public UObject.FVector DOF_FocusPosition = new();
    public float DOF_InterpolationDuration;
    public float MotionBlur_MaxVelocity;
    public float MotionBlur_Amount;
    public bool MotionBlur_FullMotionBlur;
    public float MotionBlur_CameraRotationThreshold;
    public float MotionBlur_CameraTranslationThreshold;
    public float MotionBlur_InterpolationDuration;
    public float Scene_Desaturation;
    public UObject.FVector Scene_HighLights = new();
    public UObject.FVector Scene_MidTones = new();
    public UObject.FVector Scene_Shadows = new();
    public float Scene_InterpolationDuration;
    public float IndirectLightingIntense;
    public FName CubeMapActorName;
    public UObject.FLinearColor RimShader_Color = new();
    public float RimShader_InterpolationDuration;
    public UTexture ColorGrading_LookupTable;
    public APostProcessVolume.FLUTBlender ColorGradingLUT = new();
  }

  public float Priority;
  public FPostProcessSettings Settings = new();
  public APostProcessVolume NextLowerPriorityVolume;
  public bool bEnabled;
}

public class APotentialClimbWatcher : AInfo
{
}

public class UPowerupDataProvider : UInventoryDataProvider
{
}

public class UPrefab : UObject
{
  public int PrefabVersion;
  public List<UObject> PrefabArchetypes;
  public List<UObject> RemovedArchetypes;
  public UPrefabSequence PrefabSequence;
  public UTexture2D PrefabPreview;
}

public partial class APrefabInstance : AActor
{
  public UPrefab TemplatePrefab;
  public int TemplateVersion;
  public Dictionary<UObject, UObject> ArchetypeToInstanceMap;
  public UPrefabSequence SequenceInstance;
  public int PI_PackageVersion;
  public int PI_LicenseePackageVersion;
  public List<byte> PI_Bytes;
  public List<UObject> PI_CompleteObjects;
  public List<UObject> PI_ReferencedObjects;
  public List<string> PI_SavedNames;
  public Dictionary<UObject, int> PI_ObjectMap;
}

public class USequence : USequenceOp
{
  public class FActivateOp
  {
    public USequenceOp ActivatorOp;
    public USequenceOp Op;
    public int InputIdx;
    public float RemainingDelay;
  }

  public class FQueuedActivationInfo
  {
    public USequenceEvent ActivatedEvent;
    public AActor InOriginator;
    public AActor InInstigator;
    public List<int> ActivateIndices;
    public bool bPushTop;
  }

  public FPointer LogFile = new();
  public List<USequenceObject> SequenceObjects;
  public List<USequenceOp> ActiveSequenceOps;
  public List<USequence> NestedSequences;
  public List<USequenceEvent> UnregisteredEvents;
  public List<FActivateOp> DelayedActivatedOps;
  public bool bEnabled;
  public List<FQueuedActivationInfo> QueuedActivations;
  public int DefaultViewX;
  public int DefaultViewY;
  public float DefaultViewZoom;
}

public class UPrefabSequence : USequence
{
  public APrefabInstance OwnerPrefab;
}

public class UPrefabSequenceContainer : USequence
{
}

public class AProcBuilding_SimpleLODActor : AStaticMeshActor
{
}

public class AProjectile : AActor
{
  public float Speed;
  public float MaxSpeed;
  public bool bSwitchToZeroCollision;
  public bool bBlockedByInstigator;
  public bool bBegunPlay;
  public bool bRotationFollowsVelocity;
  public bool bNotBlockedByShield;
  public AActor ZeroCollider;
  public UPrimitiveComponent ZeroColliderComponent;
  public float Damage;
  public float DamageRadius;
  public float MomentumTransfer;
  public UClass MyDamageType;
  public USoundCue SpawnSound;
  public USoundCue ImpactSound;
  public AController InstigatorController;
  public AActor ImpactedActor;
  public float NetCullDistanceSquared;
  public UCylinderComponent CylinderComponent;
  public AProjectile NextProjectile;
}

public class UProscribedReachSpec : UReachSpec
{
}

public class APylonSeed : AActor
{
  public FPointer VfTable_IInterface_NavMeshPathObject = new();
}

public class URadialBlurComponent : UActorComponent
{
  public UMaterialInterface Material;
  public ESceneDepthPriorityGroup DepthPriorityGroup;
  public float BlurScale;
  public float BlurFalloffExponent;
  public float BlurOpacity;
  public float MaxCullDistance;
  public float DistanceFalloffExponent;
  public bool bRenderAsVelocity;
  public bool bEnabled;
  public FMatrix LocalToWorld = new();
}

public class ARadialBlurActor : AActor
{
  public URadialBlurComponent RadialBlur;
  public float BlurScale;
  public float BlurFalloffExponent;
  public float BlurOpacity;
}

public class URB_BodyInstance : UObject
{
  public UPrimitiveComponent OwnerComponent;
  public int BodyIndex;
  public FVector Velocity = new();
  public FVector PreviousVelocity = new();
  public int SceneIndex;
  public FPointer BodyData = new();
  public FPointer BoneSpring = new();
  public FPointer BoneSpringKinActor = new();
  public bool bEnableBoneSpringLinear;
  public bool bEnableBoneSpringAngular;
  public bool bDisableOnOverextension;
  public bool bNotifyOwnerOnOverextension;
  public bool bTeleportOnOverextension;
  public bool bUseKinActorForBoneSpring;
  public bool bMakeSpringToBaseCollisionComponent;
  public bool bOnlyCollideWithPawns;
  public bool bEnableCollisionResponse;
  public bool bPushBody;
  public bool bForceUnfixed;
  public bool bInstanceAlwaysFullAnimWeight;
  public float BoneLinearSpring;
  public float BoneLinearDamping;
  public float BoneAngularSpring;
  public float BoneAngularDamping;
  public float OverextensionThreshold;
  public float CustomGravityFactor;
  public float LastEffectPlayedTime;
  public UPhysicalMaterial PhysMaterialOverride;
  public float ContactReportForceThreshold;
  public float InstanceMassScale;
  public float InstanceDampingScale;
}

public partial class URB_BodySetup : UKMeshProps
{
  public partial class FKCachedConvexDataElement : ISerialisable
  {
    public List<byte> ConvexElementData;
  }

  public partial class FKCachedConvexData : ISerialisable
  {
    public List<URB_BodySetup.FKCachedConvexDataElement> CachedConvexElements;
  }

  public class FKCachedPerTriData
  {
    public List<byte> CachedPerTriData;
  }

  public ESleepFamily SleepFamily;
  public FName BoneName;
  public bool bFixed;
  public bool bNoCollision;
  public bool bBlockZeroExtent;
  public bool bBlockNonZeroExtent;
  public bool bEnableContinuousCollisionDetection;
  public bool bAlwaysFullAnimWeight;
  public bool bConsiderForBounds;
  public UPhysicalMaterial PhysMaterial;
  public float MassScale;
  public List<FPointer> CollisionGeom;
  public List<FVector> CollisionGeomScale3D;
  public List<FVector> PreCachedPhysScale;
  public List<FKCachedConvexData> PreCachedPhysData;
  public int PreCachedPhysDataVersion;
}

public class ARigidBodyBase : AActor
{
}

public class URB_ConstraintDrawComponent : UPrimitiveComponent
{
  public UMaterialInterface LimitMaterial;
}

public class URB_ConstraintInstance : UObject
{
  public AActor Owner;
  public UPrimitiveComponent OwnerComponent;
  public int ConstraintIndex;
  public int SceneIndex;
  public bool bInHardware;
  public bool bLinearXPositionDrive;
  public bool bLinearXVelocityDrive;
  public bool bLinearYPositionDrive;
  public bool bLinearYVelocityDrive;
  public bool bLinearZPositionDrive;
  public bool bLinearZVelocityDrive;
  public bool bSwingPositionDrive;
  public bool bSwingVelocityDrive;
  public bool bTwistPositionDrive;
  public bool bTwistVelocityDrive;
  public bool bAngularSlerpDrive;
  public bool bTerminated;
  public FPointer ConstraintData = new();
  public FVector LinearPositionTarget = new();
  public FVector LinearVelocityTarget = new();
  public float LinearDriveSpring;
  public float LinearDriveDamping;
  public float LinearDriveForceLimit;
  public FQuat AngularPositionTarget = new();
  public FVector AngularVelocityTarget = new();
  public float AngularDriveSpring;
  public float AngularDriveDamping;
  public float AngularDriveForceLimit;
  public FPointer DummyKinActor = new();
}

public class ARB_ConstraintActor : ARigidBodyBase
{
  public AActor ConstraintActor1;
  public AActor ConstraintActor2;
  public URB_ConstraintSetup ConstraintSetup;
  public URB_ConstraintInstance ConstraintInstance;
  public bool bDisableCollision;
  public bool bUpdateActor1RefFrame;
  public bool bUpdateActor2RefFrame;
  public AActor PulleyPivotActor1;
  public AActor PulleyPivotActor2;
}

public class URB_ConstraintSetup : UObject
{
  public class FLinearDOFSetup
  {
    public byte bLimited;
    public float LimitSize;
  }

  public FName JointName;
  public FName ConstraintBone1;
  public FName ConstraintBone2;
  public FVector Pos1 = new();
  public FVector PriAxis1 = new();
  public FVector SecAxis1 = new();
  public FVector Pos2 = new();
  public FVector PriAxis2 = new();
  public FVector SecAxis2 = new();
  public FVector PulleyPivot1 = new();
  public FVector PulleyPivot2 = new();
  public bool bEnableProjection;
  public bool bLinearLimitSoft;
  public bool bLinearBreakable;
  public bool bSwingLimited;
  public bool bTwistLimited;
  public bool bSwingLimitSoft;
  public bool bTwistLimitSoft;
  public bool bAngularBreakable;
  public bool bIsPulley;
  public bool bMaintainMinDistance;
  public FLinearDOFSetup LinearXSetup = new();
  public FLinearDOFSetup LinearYSetup = new();
  public FLinearDOFSetup LinearZSetup = new();
  public float LinearLimitStiffness;
  public float LinearLimitDamping;
  public float LinearBreakThreshold;
  public float Swing1LimitAngle;
  public float Swing2LimitAngle;
  public float TwistLimitAngle;
  public float SwingLimitStiffness;
  public float SwingLimitDamping;
  public float TwistLimitStiffness;
  public float TwistLimitDamping;
  public float AngularBreakThreshold;
  public float PulleyRatio;
}

public class URB_BSJointSetup : URB_ConstraintSetup
{
}

public class ARB_BSJointActor : ARB_ConstraintActor
{
}

public class ARB_ConstraintActorSpawnable : ARB_ConstraintActor
{
}

public class ARB_CylindricalForceActor : ARigidBodyBase
{
  public UDrawCylinderComponent RenderComponent;
  public float RadialStrength;
  public float RotationalStrength;
  public float LiftStrength;
  public float LiftFalloffHeight;
  public float EscapeVelocity;
  public float ForceRadius;
  public float ForceTopRadius;
  public float ForceHeight;
  public float HeightOffset;
  public bool bForceActive;
  public bool bForceApplyToCloth;
  public bool bForceApplyToFluid;
  public bool bForceApplyToRigidBodies;
  public bool bForceApplyToProjectiles;
  public UPrimitiveComponent.FRBCollisionChannelContainer CollideWithChannels = new();
}

public class URB_DistanceJointSetup : URB_ConstraintSetup
{
}

public class ARB_ForceFieldExcludeVolume : AVolume
{
  public int ForceFieldChannel;
}

public class URB_Handle : UActorComponent
{
  public UPrimitiveComponent GrabbedComponent;
  public FName GrabbedBoneName;
  public int SceneIndex;
  public bool bInHardware;
  public bool bRotationConstrained;
  public bool bInterpolating;
  public FPointer HandleData = new();
  public FPointer KinActorData = new();
  public float LinearDamping;
  public float LinearStiffness;
  public FVector LinearStiffnessScale3D = new();
  public FVector LinearDampingScale3D = new();
  public float AngularDamping;
  public float AngularStiffness;
  public FVector Destination = new();
  public FVector StepSize = new();
  public FVector Location = new();
}

public class URB_HingeSetup : URB_ConstraintSetup
{
}

public class ARB_HingeActor : ARB_ConstraintActor
{
}

public class ARB_LineImpulseActor : ARigidBodyBase
{
  public float ImpulseStrength;
  public float ImpulseRange;
  public bool bVelChange;
  public bool bStopAtFirstHit;
  public bool bCauseFracture;
  public UArrowComponent Arrow;
  public byte ImpulseCount;
}

public class URB_PrismaticSetup : URB_ConstraintSetup
{
}

public class ARB_PrismaticActor : ARB_ConstraintActor
{
}

public class URB_PulleyJointSetup : URB_ConstraintSetup
{
}

public class ARB_PulleyJointActor : ARB_ConstraintActor
{
}

public class ARB_RadialForceActor : ARigidBodyBase
{
  public UDrawSphereComponent RenderComponent;
  public float ForceStrength;
  public float ForceRadius;
  public float SwirlStrength;
  public float SpinTorque;
  public ERadialImpulseFalloff ForceFalloff;
  public ERadialForceType RadialForceMode;
  public bool bForceActive;
  public bool bForceApplyToCloth;
  public bool bForceApplyToFluid;
  public bool bForceApplyToRigidBodies;
  public bool bForceApplyToProjectiles;
  public UPrimitiveComponent.FRBCollisionChannelContainer CollideWithChannels = new();
}

public class URB_RadialImpulseComponent : UPrimitiveComponent
{
  public ERadialImpulseFalloff ImpulseFalloff;
  public float ImpulseStrength;
  public float ImpulseRadius;
  public bool bVelChange;
  public bool bCauseFracture;
  public UDrawSphereComponent PreviewSphere;
}

public class ARB_RadialImpulseActor : ARigidBodyBase
{
  public UDrawSphereComponent RenderComponent;
  public URB_RadialImpulseComponent ImpulseComponent;
  public byte ImpulseCount;
}

public class URB_SkelJointSetup : URB_ConstraintSetup
{
}

public class URB_Spring : UActorComponent
{
  public UPrimitiveComponent Component1;
  public FName BoneName1;
  public UPrimitiveComponent Component2;
  public FName BoneName2;
  public int SceneIndex;
  public bool bInHardware;
  public bool bEnableForceMassRatio;
  public FPointer SpringData = new();
  public float TimeSinceActivation;
  public float MinBodyMass;
  public float SpringSaturateDist;
  public float SpringMaxForce;
  public float MaxForceMassRatio;
  public FInterpCurveFloat SpringMaxForceTimeScale = new();
  public float DampSaturateVel;
  public float DampMaxForce;
}

public class URB_StayUprightSetup : URB_ConstraintSetup
{
}

public class ARB_Thruster : ARigidBodyBase
{
  public bool bThrustEnabled;
  public float ThrustStrength;
}

public class ARoute : AInfo
{
  public FPointer VfTable_IEditorLinkSelectionInterface = new();
  public ERouteType RouteType;
  public List<FActorReference> RouteList;
  public float FudgeFactor;
  public int RouteIndexOffset;
}

public class URouteRenderingComponent : UPrimitiveComponent
{
}

public class USavedMove : UObject
{
  public USavedMove NextMove;
  public float TimeStamp;
  public float Delta;
  public bool bRun;
  public bool bDuck;
  public bool bPressedJump;
  public bool bSprint;
  public bool bPreciseDestination;
  public bool bForceRMVelocity;
  public bool bForceMaxAccel;
  public bool bRootMotionFromInterpCurve;
  public EDoubleClickDir DoubleClickMove;
  public EPhysics SavedPhysics;
  public ERootMotionMode RootMotionMode;
  public FVector StartLocation = new();
  public FVector StartRelativeLocation = new();
  public FVector StartVelocity = new();
  public FVector StartFloor = new();
  public FVector SavedLocation = new();
  public FVector SavedVelocity = new();
  public FVector SavedRelativeLocation = new();
  public FVector RMVelocity = new();
  public FVector Acceleration = new();
  public FRotator Rotation = new();
  public AActor StartBase;
  public AActor EndBase;
  public float CustomTimeDilation;
  public float AccelDotThreshold;
  public float RootMotionInterpCurrentTime;
  public FVector RootMotionInterpCurveLastValue = new();
}

public class USaveGameSummary : UObject
{
  public FName BaseLevel;
  public string Description;
}

public class USceneCapture2DComponent : USceneCaptureComponent
{
  public UTextureRenderTarget2D TextureTarget;
  public float FieldOfView;
  public float NearPlane;
  public float FarPlane;
  public bool bUpdateMatrices;
  public bool bIsRelevantToMainScene;
  public FMatrix ViewMatrix = new();
  public FMatrix ProjMatrix = new();
}

public class ASceneCapture2DActor : ASceneCaptureActor
{
  public UDrawFrustumComponent DrawFrustum;
}

public class USceneCapture2DHitMaskComponent : USceneCaptureComponent
{
  public UTextureRenderTarget2D TextureTarget;
  public USkeletalMeshComponent SkeletalMeshComp;
  public int RenderSection;
  public int ForceLOD;
  public float FadingStartTimeAfterHit;
  public float FadingPercentage;
  public float FadingDurationTime;
  public float FadingIntervalTime;
}

public class USceneCaptureCubeMapComponent : USceneCaptureComponent
{
  public UTextureRenderTargetCube TextureTarget;
  public float NearPlane;
  public float FarPlane;
  public FVector WorldLocation = new();
}

public class ASceneCaptureCubeMapActor : ASceneCaptureActor
{
  public UStaticMeshComponent StaticMesh;
  public UMaterialInstanceConstant CubeMaterialInst;
}

public class USceneDataStore : UUIDataStore
{
  public FPointer VfTable_IUIListElementProvider = new();
  public FPointer VfTable_IUIListElementCellProvider = new();
  public UUIScene OwnerScene;
  public UUIDynamicFieldProvider SceneDataProvider;
}

public class USceneTransitionEffect : UPostProcessEffect
{
}

public class AScoreBoard : AHUD
{
  public bool bDisplayMessages;
}

public class AScout : APawn
{
  public class FPathSizeInfo
  {
    public FName Desc;
    public float Radius;
    public float Height;
    public float CrouchHeight;
    public byte PathColor;
  }

  public List<FPathSizeInfo> PathSizes;
  public float TestJumpZ;
  public float TestGroundSpeed;
  public float TestMaxFallSpeed;
  public float TestFallSpeed;
  public float MaxLandingVelocity;
  public int MinNumPlayerStarts;
  public UClass DefaultReachSpecClass;
  public List<FColor> EdgePathColors;
  public float NavMeshGen_StepSize;
  public float NavMeshGen_EntityHalfHeight;
  public float NavMeshGen_StartingHeightOffset;
  public float NavMeshGen_MaxDropHeight;
  public float NavMeshGen_MaxStepHeight;
  public float NavMeshGen_VertZDeltaSnapThresh;
  public float NavMeshGen_MinPolyArea;
  public float NavMeshGen_BorderBackfill_CheckDist;
  public float NavMeshGen_MinMergeDotAreaThreshold;
  public float NavMeshGen_MinMergeDotSmallArea;
  public float NavMeshGen_MinMergeDotLargeArea;
  public float NavMeshGen_MaxPolyHeight;
  public float NavMeshGen_HeightMergeThreshold;
  public float NavMeshGen_EdgeMaxDelta;
  public float NavMeshGen_MaxGroundCheckSize;
  public float NavMeshGen_MinEdgeLength;
  public bool NavMeshGen_ExpansionDoObstacleMeshSimplification;
  public bool bHightlightOneWayReachSpecs;
  public float MinMantleFallDist;
  public float MaxMantleFallDist;
  public float MinMantleLateralDist;
  public float MaxMantleLateralDist;
  public float MaxMantleFallTime;
}

public class UUIContainer : UUIObject
{
  public UUIComp_AutoAlignment AutoAlignment;
}

public class UUIPanel : UUIContainer
{
  public UUIComp_DrawImage BackgroundImageComponent;
  public bool bEnforceClipping;
}

public class UScriptConsoleEntry : UUIPanel
{
  public UUIEditBox InputBox;
  public UUIImage UpperConsoleBorder;
  public UUIImage LowerConsoleBorder;
}

public class UTextureRenderTarget : UTexture
{
  public bool bUpdateImmediate;
  public bool bNeedsTwoCopies;
  public bool bRenderOnce;
  public float TargetGamma;
}

public class UTextureRenderTarget2D : UTextureRenderTarget
{
  public int SizeX;
  public int SizeY;
  public EPixelFormat Format;
  public TextureAddress AddressX;
  public TextureAddress AddressY;
  public FLinearColor ClearColor = new();
  public bool bForceLinearGamma;
}

public class UScriptedTexture : UTextureRenderTarget2D
{
  public bool bNeedsUpdate;
  public bool bSkipNextClear;
  public FScriptDelegate __Render__Delegate;
}

public class USeqAct_SetSequenceVariable : USequenceAction
{
}

public class USeqAct_AccessObjectList : USeqAct_SetSequenceVariable
{
  public UObject OutputObject;
  public int ObjectIndex;
}

public class USeqAct_ActivateRemoteEvent : USequenceAction
{
  public AActor Instigator;
  public FName EventName;
  public USequence SequenceToActivate;
  public bool bStatusIsOk;
}

public class USeqAct_Latent : USequenceAction
{
  public List<AActor> LatentActors;
  public bool bAborted;
}

public class USeqAct_ActorFactory : USeqAct_Latent
{
  public bool bEnabled;
  public bool bIsSpawning;
  public bool bCheckSpawnCollision;
  public UActorFactory Factory;
  public EPointSelection PointSelection;
  public List<AActor> SpawnPoints;
  public List<FVector> SpawnLocations;
  public List<FVector> SpawnOrientations;
  public int SpawnCount;
  public float SpawnDelay;
  public int LastSpawnIdx;
  public int SpawnedCount;
  public float RemainingDelay;
}

public class USeqAct_ActorFactoryEx : USeqAct_ActorFactory
{
}

public class USeqAct_AddFloat : USeqAct_SetSequenceVariable
{
  public float ValueA;
  public float ValueB;
  public float FloatResult;
  public int IntResult;
}

public class USeqAct_AddImpulse : USequenceAction
{
  public FVector Impulse = new();
  public FVector Position = new();
  public FName BoneName;
  public bool bVelChange;
}

public class USeqAct_AddInt : USeqAct_SetSequenceVariable
{
  public int ValueA;
  public int ValueB;
  public float FloatResult;
  public int IntResult;
}

public class USeqAct_AddRadialImpulse : USequenceAction
{
  public float Impulse;
  public float ImpulseRadius;
  public ERadialImpulseFalloff Falloff;
  public FVector Position = new();
  public AActor SpawnPoint;
  public bool bVelChange;
}

public class USeqAct_AddRemoveFaceFXAnimSet : USequenceAction
{
  public List<UFaceFXAnimSet> FaceFXAnimSets;
}

public class USeqAct_AIAbortMoveToActor : USequenceAction
{
}

public class USeqAct_AIMoveToActor : USeqAct_Latent
{
  public bool bInterruptable;
  public bool bPickClosest;
  public List<AActor> Destination;
  public float MovementSpeedModifier;
  public AActor LookAt;
  public int LastDestinationChoice;
}

public class USeqAct_AndGate : USequenceAction
{
  public bool bOpen;
  public List<bool> LinkedOutputFiredStatus;
  public List<FPointer> LinkedOutputs;
}

public class USeqAct_ApplySoundNode : USequenceAction
{
  public USoundCue PlaySound;
  public USoundNode ApplyNode;
}

public class USeqAct_AssignController : USequenceAction
{
  public UClass ControllerClass;
}

public class USeqAct_AttachToActor : USequenceAction
{
  public bool bDetach;
  public bool bHardAttach;
  public bool bUseRelativeOffset;
  public bool bUseRelativeRotation;
  public FName BoneName;
  public FVector RelativeOffset = new();
  public FRotator RelativeRotation = new();
}

public class USeqAct_AttachToEvent : USequenceAction
{
  public bool bPreferController;
}

public class USeqAct_CameraFade : USequenceAction
{
  public FColor FadeColor = new();
  public FVector2D FadeAlpha = new();
  public float FadeOpacity;
  public float FadeTime;
  public bool bPersistFade;
  public float FadeTimeRemaining;
  public List<APlayerController> CachedPCs;
}

public class USeqAct_CameraLookAt : USequenceAction
{
  public bool bAffectCamera;
  public bool bAlwaysFocus;
  public bool bAdjustCamera;
  public bool bTurnInPlace;
  public bool bIgnoreTrace;
  public bool bAffectHead;
  public bool bRotatePlayerWithCamera;
  public bool bToggleGodMode;
  public bool bLeaveCameraRotation;
  public bool bDisableInput;
  public bool bUsedTimer;
  public bool bCheckLineOfSight;
  public FVector2D InterpSpeedRange = new();
  public FVector2D InFocusFOV = new();
  public FName FocusBoneName;
  public string TextDisplay;
  public float TotalTime;
  public float CameraFOV;
  public float RemainingTime;
}

public class USeqAct_CameraShake : USequenceAction
{
  public UCameraShake Shake;
  public float ShakeScale;
  public bool bDoControllerVibration;
  public bool bRadialShake;
  public bool bOrientTowardRadialEpicenter;
  public float RadialShake_InnerRadius;
  public float RadialShake_OuterRadius;
  public float RadialShake_Falloff;
  public ECameraAnimPlaySpace PlaySpace;
  public AActor LocationActor;
}

public class USeqAct_CastToFloat : USeqAct_SetSequenceVariable
{
  public int Value;
  public float FloatResult;
}

public class USeqAct_CastToInt : USeqAct_SetSequenceVariable
{
  public bool bTruncate;
  public float Value;
  public int IntResult;
}

public class USeqAct_ChangeCollision : USequenceAction
{
  public bool bClientSideOnly;
  public bool bCollideActors;
  public bool bBlockActors;
  public bool bIgnoreEncroachers;
  public ECollisionType CollisionType;
}

public class USeqAct_CommitMapChange : USequenceAction
{
}

public class USeqAct_ConsoleCommand : USequenceAction
{
  public string Command;
  public List<string> Commands;
}

public class USeqAct_ConvertToString : USequenceAction
{
  public bool bIncludeVarComment;
  public string VarSeparator;
  public int NumberOfInputs;
}

public class USeqAct_Delay : USeqAct_Latent
{
  public bool bDelayActive;
  public bool bStartWillRestart;
  public float DefaultDuration;
  public float Duration;
  public float LastUpdateTime;
  public float RemainingTime;
}

public class USeqAct_DelaySwitch : USeqAct_Latent
{
  public int LinkCount;
  public int CurrentIdx;
  public float SwitchDelay;
  public float NextLinkTime;
}

public class USeqAct_Destroy : USequenceAction
{
  public bool bDestroyBasedActors;
  public List<UClass> IgnoreBasedClasses;
}

public class USeqAct_DivideFloat : USeqAct_SetSequenceVariable
{
  public float ValueA;
  public float ValueB;
  public float FloatResult;
  public int IntResult;
}

public class USeqAct_DivideInt : USeqAct_SetSequenceVariable
{
  public int ValueA;
  public int ValueB;
  public float FloatResult;
  public int IntResult;
}

public class USeqAct_DrawText : USequenceAction
{
  public float DisplayTimeSeconds;
  public bool bDisplayOnObject;
  public AHUD.FKismetDrawTextInfo DrawTextInfo = new();
}

public class USeqAct_FinishSequence : USequenceAction
{
  public string OutputLabel;
}

public class USeqAct_FlyThroughHasEnded : USequenceAction
{
}

public class USeqAct_ForceFeedback : USequenceAction
{
  public UForceFeedbackWaveform FFWaveform;
  public UClass PredefinedWaveForm;
}

public class USeqAct_ForceGarbageCollection : USeqAct_Latent
{
}

public class USeqAct_Gate : USequenceAction
{
  public bool bOpen;
  public int AutoCloseCount;
  public int CurrentCloseCount;
}

public class USeqAct_GetDistance : USequenceAction
{
  public float Distance;
}

public class USeqAct_GetLocationAndRotation : USequenceAction
{
  public FVector Location = new();
  public FVector RotationVector = new();
  public FName SocketOrBoneName;
}

public class USeqAct_GetProperty : USequenceAction
{
  public FName PropertyName;
}

public class USeqAct_GetVectorComponents : USequenceAction
{
  public FVector InVector = new();
  public float X;
  public float Y;
  public float Z;
}

public class USeqAct_GetVelocity : USequenceAction
{
  public float VelocityMag;
  public FVector VelocityVect = new();
}

public class USeqAct_GiveInventory : USequenceAction
{
  public List<UClass> InventoryList;
  public bool bClearExisting;
  public bool bForceReplace;
}

public class USeqAct_IgnoreDeathForPhysicsVolume : USequenceAction
{
  public TeamIndexForIgnoreDeath IgnoreDeathScoreTeam;
}

public partial class USeqAct_Interp : USeqAct_Latent
{
  public partial class FSavedTransform : ISerialisable
  {
    public UObject.FVector Location = new();
    public UObject.FRotator Rotation = new();
  }

  public class FCameraCutInfo
  {
    public UObject.FVector Location = new();
    public float TimeStamp;
  }

  public Dictionary<AActor, FSavedTransform> SavedActorTransforms;
  public Dictionary<byte, byte> SavedActorVisibilities;
  public float PlayRate;
  public float Position;
  public float ForceStartPosition;
  public bool bIsPlaying;
  public bool bPaused;
  public bool bIsBeingEdited;
  public bool bLooping;
  public bool bRewindOnPlay;
  public bool bNoResetOnRewind;
  public bool bRewindIfAlreadyPlaying;
  public bool bReversePlayback;
  public bool bInterpForPathBuilding;
  public bool bForceStartPos;
  public bool bIgnorePrevPos;
  public bool bClientSideOnly;
  public bool bSkipUpdateIfNotVisible;
  public bool bIsSkippable;
  public bool bIgnoreBaseActorMovementForMatineeRecord;
  public bool bShouldShowGore;
  public List<ACoverLink> LinkedCover;
  public UInterpData InterpData;
  public List<UInterpGroupInst> GroupInst;
  public UClass ReplicatedActorClass;
  public AMatineeActor ReplicatedActor;
  public int PreferredSplitScreenNum;
  public List<FCameraCutInfo> CameraCuts;
  public float TerminationTime;
}

public class USeqAct_IsInObjectList : USequenceAction
{
  public bool bCheckForAllObjects;
  public bool bObjectFound;
}

public class USeqAct_LevelStreamingBase : USeqAct_Latent
{
  public bool bMakeVisibleAfterLoad;
  public bool bShouldBlockOnLoad;
}

public class USeqAct_LevelStreaming : USeqAct_LevelStreamingBase
{
  public ULevelStreaming Level;
  public FName LevelName;
  public bool bStatusIsOk;
}

public class USeqAct_LevelVisibility : USeqAct_Latent
{
  public ULevelStreaming Level;
  public FName LevelName;
  public bool bStatusIsOk;
}

public class USeqAct_Log : USequenceAction
{
  public bool bOutputToScreen;
  public bool bIncludeObjComment;
  public float TargetDuration;
  public FVector TargetOffset = new();
}

public class USeqAct_ModifyCover : USequenceAction
{
  public List<int> Slots;
  public ECoverType ManualCoverType;
  public bool bManualAdjustPlayersOnly;
}

public class USeqAct_ModifyHealth : USequenceAction
{
  public UClass DamageType;
  public float Momentum;
  public float Amount;
  public float Radius;
  public bool bHeal;
  public bool bRadial;
  public bool bFalloff;
  public AActor Instigator;
}

public class USeqAct_ModifyObjectList : USeqAct_SetSequenceVariable
{
  public int ListEntriesCount;
}

public class USeqAct_MultiLevelStreaming : USeqAct_LevelStreamingBase
{
  public class FLevelStreamingNameCombo
  {
    public ULevelStreaming Level;
    public FName LevelName;
  }

  public List<FLevelStreamingNameCombo> Levels;
  public bool bUnloadAllOtherLevels;
  public bool bStatusIsOk;
}

public class USeqAct_MultiplyFloat : USeqAct_SetSequenceVariable
{
  public float ValueA;
  public float ValueB;
  public float FloatResult;
  public int IntResult;
}

public class USeqAct_MultiplyInt : USeqAct_SetSequenceVariable
{
  public int ValueA;
  public int ValueB;
  public float FloatResult;
  public int IntResult;
}

public class USeqAct_ParticleEventGenerator : USequenceAction
{
  public bool bEnabled;
  public bool bUseEmitterLocation;
  public AActor Instigator;
  public List<string> EventNames;
  public float EventTime;
  public FVector EventLocation = new();
  public FVector EventDirection = new();
  public FVector EventVelocity = new();
  public FVector EventNormal = new();
}

public class USeqAct_PlayCameraAnim : USequenceAction
{
  public UCameraAnim CameraAnim;
  public bool bLoop;
  public bool bRandomStartTime;
  public float BlendInTime;
  public float BlendOutTime;
  public float Rate;
  public float IntensityScale;
  public ECameraAnimPlaySpace PlaySpace;
  public AActor UserDefinedSpaceActor;
}

public class USeqAct_PlayFaceFXAnim : USequenceAction
{
  public UFaceFXAnimSet FaceFXAnimSetRef;
  public string FaceFXGroupName;
  public string FaceFXAnimName;
  public USoundCue SoundCueToPlay;
}

public class USeqAct_PlayMusicTrack : USequenceAction
{
  public UMusicTrackDataStructures.FMusicTrackStruct MusicTrack = new();
}

public class USeqAct_PlaySound : USeqAct_Latent
{
  public USoundCue PlaySound;
  public float ExtraDelay;
  public float SoundDuration;
  public float FadeInTime;
  public float FadeOutTime;
  public float VolumeMultiplier;
  public float PitchMultiplier;
  public bool bSuppressSubtitles;
  public bool bStopped;
  public bool bClientSideOnly;
}

public class USeqAct_Possess : USequenceAction
{
  public APawn PawnToPossess;
  public bool bKillOldPawn;
  public bool bTryToLeaveVehicle;
}

public class USeqAct_PrepareMapChange : USeqAct_Latent
{
  public FName MainLevelName;
  public List<FName> InitiallyLoadedSecondaryLevelNames;
  public bool bIsHighPriority;
  public bool bStatusIsOk;
}

public class USeqAct_Switch : USequenceAction
{
  public int LinkCount;
  public int IncrementAmount;
  public bool bLooping;
  public bool bAutoDisableLinks;
  public List<int> Indices;
  public List<int> OriginalIndices;
}

public class USeqAct_RandomSwitch : USeqAct_Switch
{
  public List<int> AutoDisabledIndices;
  public int RemainCount;
}

public class USeqAct_RangeSwitch : USequenceAction
{
  public class FSwitchRange
  {
    public int Min;
    public int Max;
  }

  public List<FSwitchRange> Ranges;
}

public class USeqAct_SetBlockRigidBody : USequenceAction
{
}

public class USeqAct_SetBool : USeqAct_SetSequenceVariable
{
  public bool DefaultValue;
}

public class USeqAct_SetCameraTarget : USequenceAction
{
  public AActor CameraTarget;
  public ACamera.FViewTargetTransitionParams TransitionParams = new();
}

public class USeqAct_SetDamageInstigator : USequenceAction
{
  public AActor DamageInstigator;
}

public class USeqAct_SetDOFParams : USeqAct_Latent
{
  public float FalloffExponent;
  public float BlurKernelSize;
  public float MaxNearBlurAmount;
  public float MaxFarBlurAmount;
  public FColor ModulateBlurColor = new();
  public float FocusInnerRadius;
  public float FocusDistance;
  public FVector FocusPosition = new();
  public float InterpolateSeconds;
  public float InterpolateElapsed;
  public float OldFalloffExponent;
  public float OldBlurKernelSize;
  public float OldMaxNearBlurAmount;
  public float OldMaxFarBlurAmount;
  public FColor OldModulateBlurColor = new();
  public float OldFocusInnerRadius;
  public float OldFocusDistance;
  public FVector OldFocusPosition = new();
}

public class USeqAct_SetFloat : USeqAct_SetSequenceVariable
{
  public float Target;
  public List<float> Value;
}

public class USeqAct_SetInt : USeqAct_SetSequenceVariable
{
  public int Target;
  public List<int> Value;
}

public class USeqAct_SetLocation : USeqAct_SetSequenceVariable
{
  public bool bSetLocation;
  public bool bSetRotation;
  public FVector LocationValue = new();
  public FRotator RotationValue = new();
  public UObject Target;
}

public class USeqAct_SetMaterial : USequenceAction
{
  public UMaterialInterface NewMaterial;
  public int MaterialIndex;
}

public class USeqAct_SetPostProcessEffectProperties : USequenceAction
{
  public FName PostProcessEffectName;
}

public class USeqAct_SetMaterialEffectProperties : USeqAct_SetPostProcessEffectProperties
{
  public UMaterialInterface Material;
  public UObject ObjectReference;
}

public class USeqAct_SetMatInstScalarParam : USequenceAction
{
  public UMaterialInstanceConstant MatInst;
  public FName ParamName;
  public float ScalarValue;
}

public class USeqAct_SetMatInstTexParam : USequenceAction
{
  public UMaterialInstanceConstant MatInst;
  public UTexture NewTexture;
  public FName ParamName;
}

public class USeqAct_SetMatInstVectorParam : USequenceAction
{
  public UMaterialInstanceConstant MatInst;
  public FName ParamName;
  public FLinearColor VectorValue = new();
}

public class USeqAct_SetMesh : USequenceAction
{
  public USkeletalMesh NewSkeletalMesh;
  public UStaticMesh NewStaticMesh;
  public EMeshType MeshType;
  public bool bIsAllowedToMove;
  public bool bAllowDecalsToReattach;
}

public class USeqAct_SetMotionBlurParams : USeqAct_Latent
{
  public float MotionBlurAmount;
  public float InterpolateSeconds;
  public float InterpolateElapsed;
  public float OldMotionBlurAmount;
}

public class USeqAct_SetObject : USeqAct_SetSequenceVariable
{
  public UObject DefaultValue;
  public UObject Value;
}

public class USeqAct_SetOutLine : USequenceAction
{
  public bool bDrawOutline;
  public byte OutLineIndex;
  public byte TeamIndex;
}

public class USeqAct_SetParticleSysParam : USequenceAction
{
  public List<UParticleSystemComponent.FParticleSysParam> InstanceParameters;
  public bool bOverrideScalar;
  public float ScalarValue;
}

public class USeqAct_SetPhysics : USequenceAction
{
  public EPhysics newPhysics;
  public bool bClientSideOnly;
}

public class USeqAct_SetRigidBodyIgnoreVehicles : USequenceAction
{
}

public class USeqAct_SetSkelControlTarget : USequenceAction
{
  public FName SkelControlName;
  public List<UObject> TargetActors;
}

public class USeqAct_SetSoundMode : USequenceAction
{
  public USoundMode SoundMode;
  public bool bTopPriority;
}

public class USeqAct_SetString : USeqAct_SetSequenceVariable
{
  public string Target;
  public string Value;
}

public class USeqAct_SetVector : USeqAct_SetSequenceVariable
{
  public FVector DefaultValue = new();
}

public class USeqAct_SetVectorComponents : USequenceAction
{
  public FVector OutVector = new();
  public float X;
  public float Y;
  public float Z;
}

public class USeqAct_SetVelocity : USequenceAction
{
  public FVector VelocityDir = new();
  public float VelocityMag;
  public bool bVelocityRelativeToActorRotation;
}

public class USeqAct_StreamInTextures : USeqAct_Latent
{
  public bool bLocationBased;
  public bool bStreamingActive;
  public float Seconds;
  public float StopTimestamp;
  public List<UObject> LocationActors;
  public List<UMaterialInterface> ForceMaterials;
  public UTexture.FTextureGroupContainer CinematicTextureGroups = new();
  public int SelectedCinematicTextureGroups;
}

public class USeqAct_SubtractFloat : USeqAct_SetSequenceVariable
{
  public float ValueA;
  public float ValueB;
  public float FloatResult;
  public int IntResult;
}

public class USeqAct_SubtractInt : USeqAct_SetSequenceVariable
{
  public int ValueA;
  public int ValueB;
  public float FloatResult;
  public int IntResult;
}

public class USeqAct_Teleport : USequenceAction
{
  public bool bUpdateRotation;
  public bool bDoForceTeleport;
}

public class USeqAct_Timer : USequenceAction
{
  public float ActivationTime;
  public float Time;
}

public class USeqAct_Toggle : USequenceAction
{
  public bool bClientSideOnly;
}

public class USeqAct_ToggleAffectedByHitEffects : USequenceAction
{
}

public class USeqAct_ToggleCinematicMode : USequenceAction
{
  public bool bDisableMovement;
  public bool bDisableTurning;
  public bool bHidePlayer;
  public bool bDisableInput;
  public bool bHideHUD;
  public bool bDeadBodies;
  public bool bDroppedPickups;
}

public class USeqAct_ToggleConstraintDrive : USequenceAction
{
  public bool bEnableAngularPositionDrive;
  public bool bEnableAngularVelocityDrive;
  public bool bEnableLinearPositionDrive;
  public bool bEnableLinearvelocityDrive;
}

public class USeqAct_ToggleGodMode : USequenceAction
{
}

public class USeqAct_ToggleHidden : USeqAct_Toggle
{
  public bool bToggleBasedActors;
  public List<UClass> IgnoreBasedClasses;
}

public class USeqAct_ToggleHUD : USequenceAction
{
}

public class USeqAct_ToggleInput : USeqAct_Toggle
{
  public bool bToggleMovement;
  public bool bToggleTurning;
}

public class USeqAct_TogglePostProcessEffect : USeqAct_SetPostProcessEffectProperties
{
  public bool Value;
}

public class USeqAct_Trace : USequenceAction
{
  public bool bTraceActors;
  public bool bTraceWorld;
  public FVector TraceExtent = new();
  public FVector StartOffset = new();
  public FVector EndOffset = new();
  public UObject HitObject;
  public float Distance;
  public FVector HitLocation = new();
}

public class USeqAct_UpdatePhysBonesFromAnim : USequenceAction
{
}

public class USeqAct_WaitForLevelsVisible : USeqAct_Latent
{
  public List<FName> LevelNames;
  public bool bShouldBlockOnLoad;
}

public class USequenceCondition : USequenceOp
{
}

public class USeqCond_CompareBool : USequenceCondition
{
}

public class USeqCond_CompareFloat : USequenceCondition
{
  public float ValueA;
  public float ValueB;
}

public class USeqCond_CompareInt : USequenceCondition
{
  public int ValueA;
  public int ValueB;
}

public class USeqCond_CompareObject : USequenceCondition
{
}

public class USeqCond_GetServerType : USequenceCondition
{
}

public class USeqCond_Increment : USequenceCondition
{
  public int IncrementAmount;
  public int ValueA;
  public int ValueB;
}

public class USeqCond_IncrementFloat : USequenceCondition
{
  public float IncrementAmount;
  public float ValueA;
  public float ValueB;
}

public class USeqCond_IsAlive : USequenceCondition
{
}

public class USeqCond_IsConsole : USequenceCondition
{
}

public class USeqCond_IsInCombat : USequenceCondition
{
}

public class USeqCond_IsLoggedIn : USequenceCondition
{
  public int NumNeededLoggedIn;
}

public class USeqCond_IsSameTeam : USequenceCondition
{
}

public class USeqCond_SwitchBase : USequenceCondition
{
}

public class USeqCond_SwitchClass : USeqCond_SwitchBase
{
  public class FSwitchClassInfo
  {
    public FName ClassName;
    public byte bFallThru;
  }

  public List<FSwitchClassInfo> ClassArray;
}

public class USeqCond_SwitchObject : USeqCond_SwitchBase
{
  public class FSwitchObjectCase
  {
    public UObject ObjectValue;
    public bool bFallThru;
    public bool bDefaultValue;
  }

  public List<FSwitchObjectCase> SupportedValues;
  public UClass MetaClass;
}

public class USeqCond_SwitchPlatform : USequenceCondition
{
}

public class USeqEvent_AIReachedRouteActor : USequenceEvent
{
}

public class USeqEvent_AISeeEnemy : USequenceEvent
{
  public float MaxSightDistance;
}

public class USeqEvent_AnimNotify : USequenceEvent
{
  public FName NotifyName;
}

public class USeqEvent_Console : USequenceEvent
{
  public FName ConsoleEventName;
  public string EventDesc;
}

public class USeqEvent_ConstraintBroken : USequenceEvent
{
}

public class USeqEvent_Death : USequenceEvent
{
}

public class USeqEvent_Destroyed : USequenceEvent
{
}

public class USeqEvent_GetInventory : USequenceEvent
{
}

public class USeqEvent_HitWall : USequenceEvent
{
}

public class USeqEvent_LevelBeginning : USequenceEvent
{
}

public class USeqEvent_LevelLoaded : USequenceEvent
{
}

public class USeqEvent_LevelStartup : USequenceEvent
{
}

public class USeqEvent_LOS : USequenceEvent
{
  public float ScreenCenterDistance;
  public float TriggerDistance;
  public bool bCheckForObstructions;
}

public class USeqEvent_Mover : USequenceEvent
{
  public float StayOpenTime;
}

public class USeqEvent_ParticleEvent : USequenceEvent
{
  public EParticleEventOutputType EventType;
  public FVector EventPosition = new();
  public float EventEmitterTime;
  public FVector EventVelocity = new();
  public float EventParticleTime;
  public FVector EventNormal = new();
  public bool UseRelfectedImpactVector;
}

public class USeqEvent_PickupStatusChange : USequenceEvent
{
}

public class USeqEvent_PlayerSpawned : USequenceEvent
{
  public UObject SpawnPoint;
}

public class USeqEvent_ProjectileLanded : USequenceEvent
{
  public float MaxDistance;
}

public class USeqEvent_RemoteEvent : USequenceEvent
{
  public FName EventName;
  public bool bStatusIsOk;
}

public class USeqEvent_RigidBodyCollision : USequenceEvent
{
  public float MinCollisionVelocity;
}

public class USeqEvent_SeeDeath : USequenceEvent
{
}

public class USeqEvent_SequenceActivated : USequenceEvent
{
  public string InputLabel;
}

public class USeqEvent_TakeDamage : USequenceEvent
{
  public float MinDamageAmount;
  public List<float> DamageThresholds;
  public List<UClass> DamageTypes;
  public List<UClass> IgnoreDamageTypes;
  public float CurrentDamage;
  public bool bResetDamageOnToggle;
  public bool bApplyPlayerCountToDamageThresholds;
  public float DamageThresholdAmountForPlayerCount;
}

public class USeqEvent_Touch : USequenceEvent
{
  public List<UClass> ClassProximityTypes;
  public List<UClass> IgnoredClassProximityTypes;
  public bool bForceOverlapping;
  public bool bUseInstigator;
  public bool bAllowDeadPawns;
  public List<AActor> TouchedList;
}

public class USeqEvent_Used : USequenceEvent
{
  public bool bAimToInteract;
  public float InteractDistance;
  public string InteractText;
  public UTexture2D InteractIcon;
  public List<UClass> ClassProximityTypes;
  public List<UClass> IgnoredClassProximityTypes;
}

public class USequenceFrame : USequenceObject
{
  public int SizeX;
  public int SizeY;
  public int BorderWidth;
  public bool bDrawBox;
  public bool bFilled;
  public bool bTileFill;
  public FColor BorderColor = new();
  public FColor FillColor = new();
  public UTexture2D FillTexture;
  public UMaterial FillMaterial;
}

public class USequenceFrameWrapped : USequenceFrame
{
}

public class ASeqValueForHostMigration : AActor
{
  public class FHMSeqIntValue
  {
    public FName SeqVarName;
    public int SeqValue;
  }

  public class FHMSeqFloatValue
  {
    public FName SeqVarName;
    public float SeqValue;
  }

  public class FHMSeqStringValue
  {
    public FName SeqVarName;
    public string SeqValue;
  }

  public class FHMSeqVectorValue
  {
    public FName SeqVarName;
    public UObject.FVector SeqValue = new();
  }

  public FHMSeqIntValue[] arrBoolValue = new FHMSeqIntValue[16];
  public FHMSeqIntValue[] arrIntValue = new FHMSeqIntValue[16];
  public FHMSeqFloatValue[] arrFloatValue = new FHMSeqFloatValue[16];
  public FHMSeqStringValue[] arrStringValue = new FHMSeqStringValue[8];
  public FHMSeqVectorValue[] arrVectorValue = new FHMSeqVectorValue[8];
}

public class USeqVar_Bool : USequenceVariable
{
  public int bValue;
}

public class USeqVar_Byte : USequenceVariable
{
}

public class USeqVar_Object : USequenceVariable
{
  public UObject ObjValue;
  public FVector ActorLocation = new();
  public List<UClass> SupportedClasses;
}

public class USeqVar_Character : USeqVar_Object
{
  public UClass PawnClass;
}

public class USeqVar_External : USequenceVariable
{
  public UClass ExpectedType;
  public string VariableLabel;
}

public class USeqVar_Float : USequenceVariable
{
  public float FloatValue;
}

public class USeqVar_Group : USeqVar_Object
{
  public FName GroupName;
  public bool bCachedList;
  public List<UObject> Actors;
}

public class USeqVar_Int : USequenceVariable
{
  public int IntValue;
}

public class USeqVar_Name : USequenceVariable
{
}

public class USeqVar_Named : USequenceVariable
{
  public UClass ExpectedType;
  public FName FindVarName;
  public bool bStatusIsOk;
}

public class USeqVar_ObjectList : USeqVar_Object
{
  public List<UObject> ObjList;
}

public class USeqVar_ObjectVolume : USeqVar_Object
{
  public float LastUpdateTime;
  public List<UObject> ContainedObjects;
  public List<UClass> ExcludeClassList;
  public bool bCollidingOnly;
}

public class USeqVar_Player : USeqVar_Object
{
  public List<UObject> Players;
  public bool bAllPlayers;
  public int PlayerIdx;
}

public class USeqVar_RandomFloat : USeqVar_Float
{
  public float Min;
  public float Max;
}

public class USeqVar_RandomInt : USeqVar_Int
{
  public int Min;
  public int Max;
}

public class USeqVar_String : USequenceVariable
{
  public string StrValue;
}

public class USeqVar_UIRange : USequenceVariable
{
}

public class USeqVar_Union : USequenceVariable
{
}

public class USeqVar_UniqueNetId : USequenceVariable
{
}

public class USeqVar_Vector : USequenceVariable
{
  public FVector VectValue = new();
}

public class UUISettingsProvider : UUIPropertyDataProvider
{
  public FName ProviderTag;
}

public class USessionSettingsProvider : UUISettingsProvider
{
  public UClass ProviderClientClass;
  public UClass ProviderClientMetaClass;
  public UClass ProviderClient;
}

public class USessionSettingsProvider_GameInfo : USessionSettingsProvider
{
}

public class USFClientResetInterface : UInterface
{
}

public class USFSoundNodeGender : USoundNode
{
}

public class USFSoundNodeRandom : USoundNode
{
  public float RandomizeIfOverTime;
  public float LastPlayedTime;
  public int LastPlayedNode;
}

public class USFSoundNodeSpatialized : USoundNode
{
}

public class UShadowMap2D : UObject
{
  public UShadowMapTexture2D Texture;
  public FVector2D CoordinateScale = new();
  public FVector2D CoordinateBias = new();
  public FGuid LightGuid = new();
  public bool bIsShadowFactorTexture;
  public UInstancedStaticMeshComponent Component;
  public int InstanceIndex;
}

public class UShadowMapTexture2D : UTexture2D
{
  public int ShadowmapFlags;
}

public class USkelControlBase : UAnimObject
{
  public FName ControlName;
  public float ControlStrength;
  public float BlendInTime;
  public float BlendOutTime;
  public AlphaBlendType BlendType;
  public bool bPostPhysicsController;
  public bool bSetStrengthFromAnimNode;
  public bool bInitializedCachedNodeList;
  public bool bControlledByAnimMetada;
  public bool bPropagateSetActive;
  public bool bIgnoreWhenNotRendered;
  public bool bShouldTickInScript;
  public bool bEnableEaseInOut;
  public float StrengthTarget;
  public float BlendTimeToGo;
  public List<FName> StrengthAnimNodeNameList;
  public List<UAnimNode> CachedNodeList;
  public float AnimMetadataWeight;
  public List<UAnimNodeSequence> AnimMetadataCachedAnimNodeSeqList;
  public float BoneScale;
  public int ControlTickTag;
  public int IgnoreAtOrAboveLOD;
  public USkelControlBase NextControl;
  public int ControlPosX;
  public int ControlPosY;
}

public class USkelControl_CCD_IK : USkelControlBase
{
  public FVector EffectorLocation = new();
  public EBoneControlSpace EffectorLocationSpace;
  public FName EffectorSpaceBoneName;
  public FVector EffectorTranslationFromBone = new();
  public int NumBones;
  public int MaxPerBoneIterations;
  public int IterationsCount;
  public float Precision;
  public bool bStartFromTail;
  public bool bNoTurnOptimization;
  public List<float> AngleConstraint;
  public float MaxAngleSteps;
}

public class USkelControl_TwistBone : USkelControlBase
{
  public FName SourceBoneName;
  public float TwistAngleScale;
}

public class USkelControlLimb : USkelControlBase
{
  public FVector EffectorLocation = new();
  public EBoneControlSpace EffectorLocationSpace;
  public EBoneControlSpace JointTargetLocationSpace;
  public EAxis BoneAxis;
  public EAxis JointAxis;
  public FName EffectorSpaceBoneName;
  public FVector JointTargetLocation = new();
  public FName JointTargetSpaceBoneName;
  public bool bInvertBoneAxis;
  public bool bInvertJointAxis;
  public bool bMaintainEffectorRelRot;
  public bool bTakeRotationFromEffectorSpace;
  public bool bAllowStretching;
  public FVector2D StretchLimits = new();
  public FName StretchRollBoneName;
}

public class USkelControlFootPlacement : USkelControlLimb
{
  public float FootOffset;
  public EAxis FootUpAxis;
  public FRotator FootRotOffset = new();
  public bool bInvertFootUpAxis;
  public bool bOrientFootToGround;
  public bool bOnlyEnableForUpAdjustment;
  public float MaxUpAdjustment;
  public float MaxDownAdjustment;
  public float MaxFootOrientAdjust;
}

public class USkelControlSingleBone : USkelControlBase
{
  public bool bApplyTranslation;
  public bool bApplyRotation;
  public bool bAddTranslation;
  public bool bAddRotation;
  public bool bRemoveMeshRotation;
  public FVector BoneTranslation = new();
  public EBoneControlSpace BoneTranslationSpace;
  public EBoneControlSpace BoneRotationSpace;
  public FName TranslationSpaceBoneName;
  public FRotator BoneRotation = new();
  public FName RotationSpaceBoneName;
}

public class USkelControlHandlebars : USkelControlSingleBone
{
  public EAxis WheelRollAxis;
  public EAxis HandlebarRotateAxis;
  public FName WheelBoneName;
  public bool bInvertRotation;
  public int SteerWheelBoneIndex;
}

public class USkelControlLookAt : USkelControlBase
{
  public FVector TargetLocation = new();
  public EBoneControlSpace TargetLocationSpace;
  public EAxis LookAtAxis;
  public EAxis UpAxis;
  public EBoneControlSpace AllowRotationSpace;
  public FName TargetSpaceBoneName;
  public bool bInvertLookAtAxis;
  public bool bDefineUpAxis;
  public bool bInvertUpAxis;
  public bool bEnableLimit;
  public bool bLimitBasedOnRefPose;
  public bool bDisableBeyondLimit;
  public bool bNotifyBeyondLimit;
  public bool bShowLimit;
  public bool bAllowRotationX;
  public bool bAllowRotationY;
  public bool bAllowRotationZ;
  public bool bEnableInterpolateToTarget;
  public float TargetLocationInterpSpeed;
  public FVector DesiredTargetLocation = new();
  public float MaxAngle;
  public float OuterMaxAngle;
  public float DeadZoneAngle;
  public FName AllowRotationOtherBoneName;
  public float LookAtAlpha;
  public float LookAtAlphaTarget;
  public float LookAtAlphaBlendTimeToGo;
  public FVector LimitLookDir = new();
  public FVector BaseLookDir = new();
  public FVector BaseBonePos = new();
  public float LastCalcTime;
}

public class USkelControlSpline : USkelControlBase
{
  public int SplineLength;
  public EAxis SplineBoneAxis;
  public ESplineControlRotMode BoneRotMode;
  public bool bInvertSplineBoneAxis;
  public float EndSplineTension;
  public float StartSplineTension;
}

public class USkelControlTrail : USkelControlBase
{
  public int ChainLength;
  public EAxis ChainBoneAxis;
  public bool bInvertChainBoneAxis;
  public bool bLimitStretch;
  public bool bActorSpaceFakeVel;
  public bool bHadValidStrength;
  public float TrailRelaxation;
  public float StretchLimit;
  public FVector FakeVelocity = new();
  public float ThisTimstep;
  public List<FVector> TrailBoneLocations;
  public FMatrix OldLocalToWorld = new();
}

public class USkelControlWheel : USkelControlSingleBone
{
  public float WheelDisplacement;
  public float WheelMaxRenderDisplacement;
  public float WheelRoll;
  public EAxis WheelRollAxis;
  public EAxis WheelSteeringAxis;
  public float WheelSteering;
  public bool bInvertWheelRoll;
  public bool bInvertWheelSteering;
}

public partial class USkeletalMesh : UObject
{
  public class FSoftBodySpecialBoneInfo
  {
    public FName BoneName;
    public SoftBodyBoneType BoneType;
    public List<int> AttachedVertexIndices;
  }

  public class FSkeletalMeshLODInfo
  {
    public float DisplayFactor;
    public float LODHysteresis;
    public List<int> LODMaterialMap;
    public List<bool> bEnableShadowCasting;
    public List<TriangleSortOption> TriangleSorting;
  }

  public class FBoneMirrorInfo
  {
    public int SourceIndex;
    public EAxis BoneFlipAxis;
  }

  public class FBoneMirrorExport
  {
    public FName BoneName;
    public FName SourceBoneName;
    public EAxis BoneFlipAxis;
  }

  public class FClothSpecialBoneInfo
  {
    public FName BoneName;
    public ClothBoneType BoneType;
    public List<int> AttachedVertexIndices;
  }

  public class FSoftBodyTetraLink
  {
    public int Index;
    public UObject.FVector Bary = new();
  }

  public class FVJointPos
  {
    public UObject.FQuat Orientation = new();
    public UObject.FVector Position = new();
  }

  public partial class FMeshBone : ISerialisable
  {
    public UObject.FColor BoneColor = new();
    public USkeletalMesh.FVJointPos BonePos = new();
    public int Depth;
    public uint Flags;
    public FName Name;
    public int NumChildren;
    public int ParentIndex;
  }

  public partial class FSkelMeshSection : ISerialisable
  {
    public uint BaseIndex;
    public byte bSelected;
    public ushort ChunkIndex;
    public ushort MaterialIndex;
    public ushort NumTriangles;
    public byte TriangleSorting;
  }

  public class FRigidSkinVertex
  {
    public byte Bone;
    public UObject.FColor Color = new();
    public UObject.FVector Position = new();
    public UObject.FPackedNormal TangentX = new();
    public UObject.FPackedNormal TangentY = new();
    public UObject.FPackedNormal TangentZ = new();
    public UObject.FVector2D[] UVs = new UObject.FVector2D[4];
  }

  public class FSoftSkinVertex
  {
    public UObject.FColor Color = new();
    public byte[] InfluenceBones = new byte[4];
    public byte[] InfluenceWeights = new byte[4];
    public UObject.FVector Position = new();
    public UObject.FPackedNormal TangentX = new();
    public UObject.FPackedNormal TangentY = new();
    public UObject.FPackedNormal TangentZ = new();
    public UObject.FVector2D[] UVs = new UObject.FVector2D[4];
  }

  public partial class FSkelMeshChunk : ISerialisable
  {
    public uint BaseVertexIndex;
    public List<ushort> BoneMap;
    public int MaxBoneInfluences;
    public int NumRigidVertices;
    public int NumSoftVertices;
    public List<USkeletalMesh.FRigidSkinVertex> RigidVertices;
    public List<USkeletalMesh.FSoftSkinVertex> SoftVertices;
  }

  public class FSkeletalMeshVertexBuffer
  {
    public bool bUseFullPrecisionUVs;
    public bool bUsePackedPosition;
    public UObject.FVector MeshExtension = new();
    public UObject.FVector MeshOrigin = new();
    public uint NumTexCoords;
    public List<byte> UntypedData;
  }

  public class FSkeletalMeshVertexColorBuffer
  {
    public List<UObject.FColor> Data;
  }

  public class FVertexInfluence
  {
    public byte[] Bones = new byte[4];
    public byte[] Weights = new byte[4];
  }

  public class FBoneIndexPair
  {
    public int[] BoneIdx = new int[2];
  }

  public partial class FSkeletalMeshVertexInfluences : ISerialisable
  {
    public List<USkeletalMesh.FSkelMeshChunk> Chunks;
    public List<USkeletalMesh.FVertexInfluence> Influences;
    public List<byte> RequiredBones;
    public List<USkeletalMesh.FSkelMeshSection> Sections;
    public Dictionary<USkeletalMesh.FBoneIndexPair, List<uint>> VertexInfluenceMapping;
  }

  public class FStaticLODModel
  {
    public List<ushort> ActiveBoneIndices;
    public List<USkeletalMesh.FSkelMeshChunk> Chunks;
    public List<UObject.FColor> ColorVertexBuffer;
    public List<ushort> DynamicIndexBuffer;
    public uint NumTexCoords;
    public uint NumVertices;
    public UObject.FWordBulkData RawPointIndices = new();
    public List<byte> RequiredBones;
    public List<USkeletalMesh.FSkelMeshSection> Sections;
    public uint Size;
    public USkeletalMesh.FSkeletalMeshVertexBuffer VertexBufferGPUSkin = new();
    public List<USkeletalMesh.FSkeletalMeshVertexInfluences> VertexInfluences;
  }

  public FBoxSphereBounds Bounds = new();
  public List<UMaterialInterface> Materials;
  public List<UApexClothingAsset> ClothingAssets;
  public FVector Origin = new();
  public FRotator RotOrigin = new();
  public List<FMeshBone> RefSkeleton;
  public int SkeletalDepth;
  public Dictionary<FName, int> NameIndexMap;
  public List<FStaticLODModel> LODModels;
  public List<UAnimNode.FBoneTransform> RefBasesInvMatrix;
  public List<FBoneMirrorInfo> SkelMirrorTable;
  public EAxis SkelMirrorAxis;
  public EAxis SkelMirrorFlipAxis;
  public List<USkeletalMeshSocket> Sockets;
  public AvailableMovementMesh MovementMeshOption;
  public FName MovementMeshName;
  public List<string> BoneBreakNames;
  public List<BoneBreakOption> BoneBreakOptions;
  public List<FSkeletalMeshLODInfo> LODInfo;
  public List<FName> PerPolyCollisionBones;
  public List<FName> AddToParentPerPolyCollisionBone;
  public List<int> PerPolyBoneKDOPs;
  public bool bPerPolyUseSoftWeighting;
  public bool bUseSimpleLineCollision;
  public bool bUseSimpleBoxCollision;
  public bool bForceCPUSkinning;
  public bool bUseFullPrecisionUVs;
  public bool bUsePackedPosition;
  public UFaceFXAsset FaceFXAsset;
  public UPhysicsAsset BoundsPreviewAsset;
  public List<UMorphTargetSet> PreviewMorphSets;
  public int LODBiasPC;
  public int LODBiasPS3;
  public int LODBiasXbox360;
  public string SourceFilePath;
  public string SourceFileTimestamp;
  public List<FPointer> ClothMesh;
  public List<float> ClothMeshScale;
  public List<int> ClothToGraphicsVertMap;
  public List<float> ClothMovementScale;
  public ClothMovementScaleGen ClothMovementScaleGenMode;
  public float ClothToAnimMeshMaxDist;
  public bool bLimitClothToAnimMesh;
  public List<int> ClothWeldingMap;
  public int ClothWeldingDomain;
  public List<int> ClothWeldedIndices;
  public bool bForceNoWelding;
  public int NumFreeClothVerts;
  public List<int> ClothIndexBuffer;
  public List<FName> ClothBones;
  public int ClothHierarchyLevels;
  public bool bEnableClothBendConstraints;
  public bool bEnableClothDamping;
  public bool bUseClothCOMDamping;
  public float ClothStretchStiffness;
  public float ClothBendStiffness;
  public float ClothDensity;
  public float ClothThickness;
  public float ClothDamping;
  public int ClothIterations;
  public int ClothHierarchicalIterations;
  public float ClothFriction;
  public float ClothRelativeGridSpacing;
  public float ClothPressure;
  public float ClothCollisionResponseCoefficient;
  public float ClothAttachmentResponseCoefficient;
  public float ClothAttachmentTearFactor;
  public float ClothSleepLinearVelocity;
  public float HardStretchLimitFactor;
  public bool bHardStretchLimit;
  public bool bEnableClothOrthoBendConstraints;
  public bool bEnableClothSelfCollision;
  public bool bEnableClothPressure;
  public bool bEnableClothTwoWayCollision;
  public List<FClothSpecialBoneInfo> ClothSpecialBones;
  public bool bEnableClothLineChecks;
  public bool bClothMetal;
  public float ClothMetalImpulseThreshold;
  public float ClothMetalPenetrationDepth;
  public float ClothMetalMaxDeformationDistance;
  public bool bEnableClothTearing;
  public float ClothTearFactor;
  public int ClothTearReserve;
  public bool bEnableValidBounds;
  public FVector ValidBoundsMin = new();
  public FVector ValidBoundsMax = new();
  public FMap_Mirror ClothTornTriMap = new();
  public List<int> SoftBodySurfaceToGraphicsVertMap;
  public List<int> SoftBodySurfaceIndices;
  public List<FVector> SoftBodyTetraVertsUnscaled;
  public List<int> SoftBodyTetraIndices;
  public List<FSoftBodyTetraLink> SoftBodyTetraLinks;
  public List<FPointer> CachedSoftBodyMeshes;
  public List<float> CachedSoftBodyMeshScales;
  public List<FName> SoftBodyBones;
  public List<FSoftBodySpecialBoneInfo> SoftBodySpecialBones;
  public float SoftBodyVolumeStiffness;
  public float SoftBodyStretchingStiffness;
  public float SoftBodyDensity;
  public float SoftBodyParticleRadius;
  public float SoftBodyDamping;
  public int SoftBodySolverIterations;
  public float SoftBodyFriction;
  public float SoftBodyRelativeGridSpacing;
  public float SoftBodySleepLinearVelocity;
  public bool bEnableSoftBodySelfCollision;
  public float SoftBodyAttachmentResponse;
  public float SoftBodyCollisionResponse;
  public float SoftBodyDetailLevel;
  public int SoftBodySubdivisionLevel;
  public bool bSoftBodyIsoSurface;
  public bool bEnableSoftBodyDamping;
  public bool bUseSoftBodyCOMDamping;
  public float SoftBodyAttachmentThreshold;
  public bool bEnableSoftBodyTwoWayCollision;
  public float SoftBodyAttachmentTearFactor;
  public bool bEnableSoftBodyLineChecks;
  public bool bHasVertexColors;
  public List<bool> GraphicsIndexIsCloth;
  public int ReleaseResourcesFence;
  public ulong SkelMeshRUID = new();
  public FVector2D UVOffset = new();
  public FVector2D UVScale = new();
  public byte unknown108;
  public FName unknown10C;
}

public class ASkeletalMeshActor : AActor
{
  public class FCheckpointRecord
  {
    public bool bReplicated;
    public bool bHidden;
    public bool bSavedPosition;
    public UObject.FVector Location = new();
    public UObject.FRotator Rotation = new();
  }

  public class FSkelMeshActorControlTarget
  {
    public FName ControlName;
    public AActor TargetActor;
  }

  public bool bDamageAppliesImpulse;
  public bool bShouldDoAnimNotifies;
  public bool bCollideActors_OldValue;
  public USkeletalMeshComponent SkeletalMeshComponent;
  public ULightEnvironmentComponent LightEnvironment;
  public UAudioComponent FacialAudioComp;
  public USkeletalMesh ReplicatedMesh;
  public UMaterialInterface ReplicatedMaterial;
  public List<FSkelMeshActorControlTarget> ControlTargets;
  public List<UInterpGroup> InterpGroupList;
  public FName SavedAnimSeqName;
  public float SavedCurrentTime;
  public int InterpolatingStartCounter;
}

public class ASkeletalMeshActorBasedOnExtremeContent : ASkeletalMeshActor
{
  public class FSkelMaterialSetterDatum
  {
    public int MaterialIndex;
    public UMaterialInterface TheMaterial;
  }

  public List<FSkelMaterialSetterDatum> ExtremeContent;
  public List<FSkelMaterialSetterDatum> NonExtremeContent;
}

public class ASkeletalMeshCinematicActor : ASkeletalMeshActor
{
  public bool bDisableTickWhenHidden;
}

public class ASkeletalMeshActorMAT : ASkeletalMeshCinematicActor
{
  public List<UAnimNodeSlot> SlotNodes;
  public int Gender;
  public List<string> AssortedNames;
}

public class ASkeletalMeshActorMATSpawnable : ASkeletalMeshActorMAT
{
}

public class ASkeletalMeshActorSpawnable : ASkeletalMeshActor
{
}

public class USkeletalMeshSocket : UObject
{
  public FName SocketName;
  public FName BoneName;
  public FVector RelativeLocation = new();
  public FRotator RelativeRotation = new();
  public FVector RelativeScale = new();
  public USkeletalMesh PreviewSkelMesh;
  public USkeletalMeshComponent PreviewSkelComp;
  public UStaticMesh PreviewStaticMesh;
}

public class USkyLightComponent : ULightComponent
{
  public float LowerBrightness;
  public FColor LowerColor = new();
}

public class ASkyLight : ALight
{
}

public class ASkyLightToggleable : ASkyLight
{
}

public class USlotToSlotReachSpec : UForcedReachSpec
{
  public byte SpecDirection;
}

public partial class USoundClass : UObject
{
  public class FSoundClassEditorData
  {
    public int NodePosX;
    public int NodePosY;
  }

  public class FSoundClassProperties
  {
    public float Volume;
    public float Pitch;
    public float StereoBleed;
    public float LFEBleed;
    public float VoiceCenterChannelVolume;
    public float VoiceRadioVolume;
    public bool bApplyEffects;
    public bool bAlwaysPlay;
    public bool bIsUISound;
    public bool bIsMusic;
    public bool bReverb;
  }

  public FSoundClassProperties Properties = new();
  public List<FName> ChildClassNames;
  public bool bIsChild;
  public int MenuID;
  public Dictionary<USoundClass, FSoundClassEditorData> EditorData;
}

public class USoundMode : UObject
{
  public class FAudioEQEffect
  {
    public double RootTime = new();
    public float HFFrequency;
    public float HFGain;
    public float MFCutoffFrequency;
    public float MFBandwidth;
    public float MFGain;
    public float LFFrequency;
    public float LFGain;
  }

  public class FSoundClassAdjuster
  {
    public ESoundClassName SoundClassName;
    public FName SoundClass;
    public float VolumeAdjuster;
    public float PitchAdjuster;
    public bool bApplyToChildren;
  }

  public int Priority;
  public bool bApplyEQ;
  public FAudioEQEffect EQSettings = new();
  public List<FSoundClassAdjuster> SoundClassEffects;
  public float InitialDelay;
  public float FadeInTime;
  public float Duration;
  public float FadeOutTime;
}

public class USoundNodeConcatenator : USoundNode
{
  public List<float> InputVolume;
}

public class USoundNodeDelay : USoundNode
{
  public float DelayMin;
  public float DelayMax;
  public UDistributionFloat.FRawDistributionFloat DelayDuration = new();
}

public class USoundNodeDistanceCrossFade : USoundNode
{
  public class FDistanceDatum
  {
    public float FadeInDistanceStart;
    public float FadeInDistanceEnd;
    public float FadeOutDistanceStart;
    public float FadeOutDistanceEnd;
    public float Volume;
    public UDistributionFloat.FRawDistributionFloat FadeInDistance = new();
    public UDistributionFloat.FRawDistributionFloat FadeOutDistance = new();
  }

  public List<FDistanceDatum> CrossFadeInput;
}

public class USoundNodeLooping : USoundNode
{
  public bool bLoopIndefinitely;
  public float LoopCountMin;
  public float LoopCountMax;
  public UDistributionFloat.FRawDistributionFloat LoopCount = new();
}

public class USoundNodeMature : USoundNode
{
}

public class USoundNodeMixer : USoundNode
{
  public List<float> InputVolume;
}

public class USoundNodeModulator : USoundNode
{
  public float PitchMin;
  public float PitchMax;
  public float VolumeMin;
  public float VolumeMax;
  public UDistributionFloat.FRawDistributionFloat PitchModulation = new();
  public UDistributionFloat.FRawDistributionFloat VolumeModulation = new();
}

public class USoundNodeModulatorContinuous : USoundNode
{
  public UDistributionFloat.FRawDistributionFloat PitchModulation = new();
  public UDistributionFloat.FRawDistributionFloat VolumeModulation = new();
}

public class USoundNodeOscillator : USoundNode
{
  public bool bModulateVolume;
  public bool bModulatePitch;
  public float AmplitudeMin;
  public float AmplitudeMax;
  public float FrequencyMin;
  public float FrequencyMax;
  public float OffsetMin;
  public float OffsetMax;
  public float CenterMin;
  public float CenterMax;
  public UDistributionFloat.FRawDistributionFloat Amplitude = new();
  public UDistributionFloat.FRawDistributionFloat Frequency = new();
  public UDistributionFloat.FRawDistributionFloat Offset = new();
  public UDistributionFloat.FRawDistributionFloat Center = new();
}

public class USoundNodeRandom : USoundNode
{
  public List<float> Weights;
  public bool bRandomizeWithoutReplacement;
  public List<bool> HasBeenUsed;
  public int NumRandomUsed;
}

public partial class USoundNodeWave : USoundNode
{
  public int CompressionQuality;
  public bool bForceRealTimeDecompression;
  public bool bLoopingSound;
  public bool bDynamicResource;
  public bool bUseTTS;
  public bool bProcedural;
  public bool bMature;
  public bool bManualWordWrap;
  public ETTSSpeaker TTSSpeaker;
  public EDecompressionType DecompressionType;
  public string SpokenText;
  public float Volume;
  public float Pitch;
  public float Duration;
  public int NumChannels;
  public int SampleRate;
  public List<int> ChannelOffsets;
  public List<int> ChannelSizes;
  public FUntypedBulkData_Mirror RawData = new();
  public FPointer VorbisDecompressor = new();
  public FPointer RawPCMData = new();
  public int RawPCMDataSize;
  public FUntypedBulkData_Mirror CompressedPCData = new();
  public FUntypedBulkData_Mirror CompressedXbox360Data = new();
  public FUntypedBulkData_Mirror CompressedPS3Data = new();
  public int ResourceID;
  public int ResourceSize;
  public FPointer ResourceData = new();
  public List<UEngineTypes.FSubtitleCue> Subtitles;
  public string Comment;
  public List<UEngineTypes.FLocalizedSubtitle> LocalizedSubtitles;
  public string SourceFilePath;
  public string SourceFileTimestamp;
}

public class USoundNodeWaveParam : USoundNode
{
  public FName WaveParameterName;
}

public class USoundNodeWaveStreaming : USoundNodeWave
{
  public List<byte> QueuedAudio;
}

public class USpeechRecognition : UObject
{
  public class FRecognisableWord
  {
    public int Id;
    public string ReferenceWord;
    public string PhoneticWord;
  }

  public class FRecogVocabulary
  {
    public List<USpeechRecognition.FRecognisableWord> WhoDictionary;
    public List<USpeechRecognition.FRecognisableWord> WhatDictionary;
    public List<USpeechRecognition.FRecognisableWord> WhereDictionary;
    public string VocabName;
    public List<byte> VocabData;
    public List<byte> WorkingVocabData;
  }

  public class FRecogUserData
  {
    public int ActiveVocabularies;
    public List<byte> UserData;
  }

  public string Language;
  public float ConfidenceThreshhold;
  public List<FRecogVocabulary> Vocabularies;
  public List<byte> VoiceData;
  public List<byte> WorkingVoiceData;
  public List<byte> UserData;
  public FRecogUserData[] InstanceData = new FRecogUserData[4];
  public bool bDirty;
  public bool bInitialised;
  public FPointer FnxVoiceData = new();
}

public class USpeedTree : UObject
{
  public bool bLegacySpeedTree;
  public FPointer SRH = new();
  public float LeafStaticShadowOpacity;
  public UMaterialInterface Branch1Material;
  public UMaterialInterface Branch2Material;
  public UMaterialInterface FrondMaterial;
  public UMaterialInterface LeafCardMaterial;
  public UMaterialInterface LeafMeshMaterial;
  public UMaterialInterface BillboardMaterial;
  public float WindStrength;
  public FVector WindDirection = new();
  public FGuid LightingGuid = new();
}

public partial class USpeedTreeComponent : UPrimitiveComponent
{
  public class FSpeedTreeStaticLight
  {
    public UObject.FGuid Guid = new();
    public UShadowMap1D BranchShadowMap;
    public UShadowMap1D FrondShadowMap;
    public UShadowMap1D LeafMeshShadowMap;
    public UShadowMap1D LeafCardShadowMap;
    public UShadowMap1D BillboardShadowMap;
  }

  public class FLightMapRef
  {
    public UObject.FPointer Reference = new();
  }

  public USpeedTree SpeedTree;
  public bool bUseLeafCards;
  public bool bUseLeafMeshes;
  public bool bUseBranches;
  public bool bUseFronds;
  public bool bUseBillboards;
  public float Lod3DStart;
  public float Lod3DEnd;
  public float LodBillboardStart;
  public float LodBillboardEnd;
  public float LodLevelOverride;
  public UMaterialInterface Branch1Material;
  public UMaterialInterface Branch2Material;
  public UMaterialInterface FrondMaterial;
  public UMaterialInterface LeafCardMaterial;
  public UMaterialInterface LeafMeshMaterial;
  public UMaterialInterface BillboardMaterial;
  public UTexture2D SpeedTreeIcon;
  public List<FSpeedTreeStaticLight> StaticLights;
  public UEngineTypes.FLightMap BranchLightMap = new();
  public UEngineTypes.FLightMap FrondLightMap = new();
  public UEngineTypes.FLightMap LeafMeshLightMap = new();
  public UEngineTypes.FLightMap LeafCardLightMap = new();
  public UEngineTypes.FLightMap BillboardLightMap = new();
  public FMatrix RotationOnlyMatrix = new();
  public UEngineTypes.FLightmassPrimitiveSettings LightmassSettings = new();
}

public class ASpeedTreeActor : AActor
{
  public USpeedTreeComponent SpeedTreeComponent;
}

public class USpeedTreeActorFactory : UActorFactory
{
  public USpeedTree SpeedTree;
}

public class USpeedTreeComponentFactory : UPrimitiveComponentFactory
{
  public USpeedTreeComponent SpeedTreeComponent;
}

public class USphericalHarmonicLightComponent : ULightComponent
{
  public FSHVectorRGB WorldSpaceIncidentLighting = new();
  public bool bRenderBeforeModShadows;
}

public class ASplineActor : AActor
{
  public class FSplineConnection
  {
    public USplineComponent SplineComponent;
    public ASplineActor ConnectTo;
  }

  public List<FSplineConnection> Connections;
  public FVector SplineActorTangent = new();
  public FColor SplineColor = new();
  public bool bDisableDestination;
  public bool bAlreadyVisited;
  public List<ASplineActor> LinksFrom;
  public ASplineActor nextOrdered;
  public ASplineActor prevOrdered;
  public ASplineActor previousPath;
  public int bestPathWeight;
  public int visitedWeight;
  public FInterpCurveFloat SplineVelocityOverTime = new();
}

public class USplineComponent : UPrimitiveComponent
{
  public FInterpCurveVector SplineInfo = new();
  public float SplineCurviness;
  public FColor SplineColor = new();
  public float SplineDrawRes;
  public float SplineArrowSize;
  public bool bSplineDisabled;
  public FInterpCurveFloat SplineReparamTable = new();
}

public class ASplineLoftActor : ASplineActor
{
  public float ScaleX;
  public float ScaleY;
  public List<USplineMeshComponent> SplineMeshComps;
  public UStaticMesh DeformMesh;
  public List<UMaterialInterface> DeformMeshMaterials;
  public float Roll;
  public FVector WorldXDir = new();
  public FVector2D Offset = new();
  public bool bSmoothInterpRollAndScale;
  public bool bAcceptsLights;
  public UDynamicLightEnvironmentComponent MeshLightEnvironment;
}

public class ASplineLoftActorMovable : ASplineLoftActor
{
}

public class USplineMeshComponent : UStaticMeshComponent
{
  public class FSplineMeshParams
  {
    public UObject.FVector StartPos = new();
    public UObject.FVector StartTangent = new();
    public UObject.FVector2D StartScale = new();
    public float StartRoll;
    public UObject.FVector2D StartOffset = new();
    public UObject.FVector EndPos = new();
    public UObject.FVector EndTangent = new();
    public UObject.FVector2D EndScale = new();
    public float EndRoll;
    public UObject.FVector2D EndOffset = new();
  }

  public FSplineMeshParams SplineParams = new();
  public FVector SplineXDir = new();
  public bool bSmoothInterpRollScale;
}

public class ASpotLightMovable : ASpotLight
{
}

public class ASpotLightToggleable : ASpotLight
{
  public class FCheckpointRecord
  {
    public bool bEnabled;
  }

}

public class USpriteComponent : UPrimitiveComponent
{
  public UTexture2D Sprite;
  public bool bIsScreenSizeScaled;
  public float ScreenSize;
  public float U;
  public float UL;
  public float V;
  public float VL;
}

public partial class AStaticLightCollectionActor : ALight
{
  public List<ULightComponent> LightComponents;
  public int MaxLightComponents;
}

public class AStaticMeshActorBasedOnExtremeContent : AActor
{
  public class FSMMaterialSetterDatum
  {
    public int MaterialIndex;
    public UMaterialInterface TheMaterial;
  }

  public UStaticMeshComponent StaticMeshComponent;
  public List<FSMMaterialSetterDatum> ExtremeContent;
  public List<FSMMaterialSetterDatum> NonExtremeContent;
}

public partial class AStaticMeshCollectionActor : AStaticMeshActorBase
{
  public List<UStaticMeshComponent> StaticMeshComponents;
  public int MaxStaticMeshComponents;
}

public class UStaticMeshComponentFactory : UMeshComponentFactory
{
  public UStaticMesh StaticMesh;
}

public class UTranslatorTag : UObject
{
  public FName Tag;
}

public class UStringsTag : UTranslatorTag
{
}

public class AVehicle : APawn
{
  public APawn Driver;
  public bool bDriving;
  public bool bDriverIsVisible;
  public bool bAttachDriver;
  public bool bTurnInPlace;
  public bool bSeparateTurretFocus;
  public bool bFollowLookDir;
  public bool bHasHandbrake;
  public bool bScriptedRise;
  public bool bDuckObstacles;
  public bool bIsNoPhysics;
  public bool bAvoidReversing;
  public bool bRetryPathfindingWithDriver;
  public bool bIgnoreStallZ;
  public bool bDoExtraNetRelevancyTraces;
  public List<FVector> ExitPositions;
  public float ExitRadius;
  public FVector ExitOffset = new();
  public float Steering;
  public float Throttle;
  public float Rise;
  public FVector TargetLocationAdjustment = new();
  public float DriverDamageMult;
  public float MomentumMult;
  public UClass CrushedDamageType;
  public float MinCrushSpeed;
  public float ForceCrushPenetration;
  public byte StuckCount;
  public float ThrottleTime;
  public float StuckTime;
  public float OldSteering;
  public float OnlySteeringStartTime;
  public float OldThrottle;
  public float AIMoveCheckTime;
  public float VehicleMovingTime;
  public float TurnTime;
}

public class ASVehicle : AVehicle
{
  public class FVehicleState
  {
    public AActor.FRigidBodyState RBState = new();
    public byte ServerBrake;
    public byte ServerGas;
    public byte ServerSteering;
    public byte ServerRise;
    public bool bServerHandbrake;
    public int ServerView;
  }

  public USVehicleSimBase SimObj;
  public List<USVehicleWheel> Wheels;
  public FVector COMOffset = new();
  public FVector InertiaTensorMultiplier = new();
  public bool bStayUpright;
  public bool bUseSuspensionAxis;
  public bool bUpdateWheelShapes;
  public bool bVehicleOnGround;
  public bool bVehicleOnWater;
  public bool bIsInverted;
  public bool bChassisTouchingGround;
  public bool bWasChassisTouchingGroundLastTick;
  public bool bCanFlip;
  public bool bFlipRight;
  public bool bIsUprighting;
  public bool bOutputHandbrake;
  public bool bHoldingDownHandbrake;
  public float StayUprightRollResistAngle;
  public float StayUprightPitchResistAngle;
  public float StayUprightStiffness;
  public float StayUprightDamping;
  public URB_StayUprightSetup StayUprightConstraintSetup;
  public URB_ConstraintInstance StayUprightConstraintInstance;
  public float HeavySuspensionShiftPercent;
  public float MaxSpeed;
  public float MaxAngularVelocity;
  public float TimeOffGround;
  public float UprightLiftStrength;
  public float UprightTorqueStrength;
  public float UprightTime;
  public float UprightStartTime;
  public UAudioComponent EngineSound;
  public UAudioComponent SquealSound;
  public USoundCue CollisionSound;
  public USoundCue EnterVehicleSound;
  public USoundCue ExitVehicleSound;
  public float CollisionIntervalSecs;
  public float SquealThreshold;
  public float SquealLatThreshold;
  public float LatAngleVolumeMult;
  public float EngineStartOffsetSecs;
  public float EngineStopOffsetSecs;
  public float LastCollisionSoundTime;
  public float OutputBrake;
  public float OutputGas;
  public float OutputSteering;
  public float OutputRise;
  public float ForwardVel;
  public int NumPoweredWheels;
  public FVector BaseOffset = new();
  public float CamDist;
  public int DriverViewPitch;
  public int DriverViewYaw;
  public FVehicleState VState = new();
  public float AngErrorAccumulator;
  public float RadialImpulseScaling;
}

public class USVehicleSimBase : UActorComponent
{
  public float WheelSuspensionStiffness;
  public float WheelSuspensionDamping;
  public float WheelSuspensionBias;
  public float WheelLongExtremumSlip;
  public float WheelLongExtremumValue;
  public float WheelLongAsymptoteSlip;
  public float WheelLongAsymptoteValue;
  public float WheelLatExtremumSlip;
  public float WheelLatExtremumValue;
  public float WheelLatAsymptoteSlip;
  public float WheelLatAsymptoteValue;
  public float WheelInertia;
  public bool bWheelSpeedOverride;
  public bool bClampedFrictionModel;
  public bool bAutoDrive;
  public float AutoDriveSteer;
}

public class USVehicleSimCar : USVehicleSimBase
{
  public float ChassisTorqueScale;
  public FInterpCurveFloat MaxSteerAngleCurve = new();
  public float SteerSpeed;
  public float ReverseThrottle;
  public float EngineBrakeFactor;
  public float MaxBrakeTorque;
  public float StopThreshold;
  public bool bIsDriving;
  public float ActualSteering;
  public float TimeSinceThrottle;
}

public class USVehicleSimTank : USVehicleSimCar
{
  public float LeftTrackVel;
  public float RightTrackVel;
  public float LeftTrackTorque;
  public float RightTrackTorque;
  public float MaxEngineTorque;
  public float EngineDamping;
  public float InsideTrackTorqueFactor;
  public float SteeringLatStiffnessFactor;
  public float TurnInPlaceThrottle;
  public float TurnMaxGripReduction;
  public float TurnGripScaleRate;
  public bool bTurnInPlaceOnSteer;
}

public class USVehicleWheel : UComponent
{
  public float Steer;
  public float MotorTorque;
  public float BrakeTorque;
  public float ChassisTorque;
  public bool bPoweredWheel;
  public bool bHoverWheel;
  public bool bCollidesVehicles;
  public bool bCollidesPawns;
  public bool bIsSquealing;
  public bool bWheelOnGround;
  public float SteerFactor;
  public FName SkelControlName;
  public USkelControlWheel WheelControl;
  public FName BoneName;
  public FVector BoneOffset = new();
  public float WheelRadius;
  public float SuspensionTravel;
  public float SuspensionSpeed;
  public UParticleSystem WheelParticleSystem;
  public EWheelSide Side;
  public float LongSlipFactor;
  public float LatSlipFactor;
  public float HandbrakeLongSlipFactor;
  public float HandbrakeLatSlipFactor;
  public float ParkedSlipFactor;
  public FVector WheelPosition = new();
  public float SpinVel;
  public float LongSlipRatio;
  public float LatSlipAngle;
  public FVector ContactNormal = new();
  public FVector LongDirection = new();
  public FVector LatDirection = new();
  public float ContactForce;
  public float LongImpulse;
  public float LatImpulse;
  public float DesiredSuspensionPosition;
  public float SuspensionPosition;
  public float CurrentRotation;
  public FPointer WheelShape = new();
  public int WheelMaterialIndex;
  public UClass WheelPSCClass;
  public UParticleSystemComponent WheelParticleComp;
  public FName SlipParticleParamName;
}

public class USwatTurnReachSpec : UForcedReachSpec
{
  public byte SpecDirection;
}

public class ATargetPoint : AKeypoint
{
  public UTexture2D SpawnSpriteTexture;
  public int SpawnRefCount;
}

public class UTeamDataProvider : UUIDynamicDataProvider
{
  public FPointer VfTable_IUIListElementProvider = new();
  public FName PlayerListFieldName;
  public List<UPlayerDataProvider> Players;
}

public class ATeamInfo : AReplicationInfo
{
  public string TeamName;
  public int Size;
  public float Score;
  public int TeamIndex;
  public FColor TeamColor = new();
}

public class ATeleporter : ANavigationPoint
{
  public string URL;
  public FName ProductRequired;
  public bool bChangesVelocity;
  public bool bChangesYaw;
  public bool bReversesX;
  public bool bReversesY;
  public bool bReversesZ;
  public bool bEnabled;
  public bool bCanTeleportVehicles;
  public FVector TargetVelocity = new();
  public float LastFired;
}

public class UTeleportReachSpec : UReachSpec
{
}

public partial class ATerrain : AInfo
{
  public partial class FTerrainHeight : ISerialisable
  {
    public ushort Value;
  }

  public partial class FTerrainInfoData : ISerialisable
  {
    public byte Data;
  }

  public class FTerrainWeightedMaterial
  {
  }

  public class FTerrainLayer
  {
    public string Name;
    public UTerrainLayerSetup Setup;
    public int AlphaMapIndex;
    public bool Highlighted;
    public bool WireframeHighlighted;
    public bool Hidden;
    public UObject.FColor HighlightColor = new();
    public UObject.FColor WireframeColor = new();
    public int MinX;
    public int MinY;
    public int MaxX;
    public int MaxY;
  }

  public partial class FAlphaMap : ISerialisable
  {
    public List<byte> Data;
  }

  public class FTerrainDecorationInstance
  {
    public UPrimitiveComponent Component;
    public float X;
    public float Y;
    public float Scale;
    public int Yaw;
  }

  public class FTerrainDecoration
  {
    public UPrimitiveComponentFactory Factory;
    public float MinScale;
    public float MaxScale;
    public float Density;
    public float SlopeRotationBlend;
    public int RandSeed;
    public List<ATerrain.FTerrainDecorationInstance> Instances;
  }

  public class FTerrainDecoLayer
  {
    public string Name;
    public List<ATerrain.FTerrainDecoration> Decorations;
    public int AlphaMapIndex;
  }

  public partial class FTerrainMaterialResource : FMaterial
  {
    public UObject.FGuid LightingGuid = new();
    public ATerrain.FTerrainMaterialMask Mask = new();
    public List<UObject.FGuid> MaterialIds;
    public ATerrain Terrain;
  }

  public partial class FCachedTerrainMaterialArray : ISerialisable
  {
    public List<ATerrain.FTerrainMaterialResource> CachedMaterials;
  }

  public class FSelectedTerrainVertex
  {
    public int X;
    public int Y;
    public int Weight;
  }

  public partial class FTerrainMaterialMask : ISerialisable
  {
    public ulong BitMask = new();
    public int NumBits;
  }

  public List<FTerrainHeight> Heights;
  public List<FTerrainInfoData> InfoData;
  public List<FTerrainLayer> Layers;
  public int NormalMapLayer;
  public List<FTerrainDecoLayer> DecoLayers;
  public List<FAlphaMap> AlphaMaps;
  public List<UTerrainComponent> TerrainComponents;
  public int NumSectionsX;
  public int NumSectionsY;
  public int SectionSize;
  public List<FTerrainWeightedMaterial> WeightedMaterials;
  public List<UTerrainWeightMapTexture> WeightedTextureMaps;
  public List<byte> CachedDisplacements;
  public float MaxCollisionDisplacement;
  public int MaxTesselationLevel;
  public int MinTessellationLevel;
  public float TesselationDistanceScale;
  public float TessellationCheckDistance;
  public int CollisionTesselationLevel;
  public FCachedTerrainMaterialArray[] CachedTerrainMaterials = new FCachedTerrainMaterialArray[3];
  public int NumVerticesX;
  public int NumVerticesY;
  public int NumPatchesX;
  public int NumPatchesY;
  public int MaxComponentSize;
  public int StaticLightingResolution;
  public bool bIsOverridingLightResolution;
  public bool bBilinearFilterLightmapGeneration;
  public bool bCastShadow;
  public bool bForceDirectLightMap;
  public bool bCastDynamicShadow;
  public bool bEnableSpecular;
  public bool bBlockRigidBody;
  public bool bAllowRigidBodyUnderneath;
  public bool bAcceptsDynamicLights;
  public bool bMorphingEnabled;
  public bool bMorphingGradientsEnabled;
  public bool bLocked;
  public bool bHeightmapLocked;
  public bool bShowingCollision;
  public bool bUseWorldOriginTextureUVs;
  public bool bShowWireframe;
  public UPhysicalMaterial TerrainPhysMaterialOverride;
  public ULightComponent.FLightingChannelContainer LightingChannels = new();
  public UEngineTypes.FLightmassPrimitiveSettings LightmassSettings = new();
  public FPointer ReleaseResourcesFence = new();
  public int EditorTessellationLevel;
  public List<FSelectedTerrainVertex> SelectedVertices;
  public FColor WireframeColor = new();
  public FGuid LightingGuid = new();
}

public partial class UTerrainComponent : UPrimitiveComponent
{
  public partial class FTerrainkDOPTree : ISerialisable
  {
    public List<int> Nodes;
    public List<int> Triangles;
  }

  public class FTerrainBVTree
  {
    public List<UTerrainComponent.FTerrainBVNode> Nodes;
  }

  public class FTerrainSubRegion
  {
    public ushort XPos;
    public ushort XSize;
    public ushort YPos;
    public ushort YSize;
  }

  public class FTerrainBVNode
  {
    public bool bIsLeaf;
    public UObject.FBox BoundingVolume = new();
    public UTerrainComponent.FTerrainSubRegion Region = new();
  }

  public class FTerrainPatchBounds
  {
    public float MaxDisplacement;
    public float MaxHeight;
    public float MinHeight;
  }

  public List<UShadowMap2D> ShadowMaps;
  public List<FGuid> IrrelevantLights;
  public FPointer TerrainObject = new();
  public int SectionBaseX;
  public int SectionBaseY;
  public int SectionSizeX;
  public int SectionSizeY;
  public int TrueSectionSizeX;
  public int TrueSectionSizeY;
  public UEngineTypes.FLightMap LightMap = new();
  public List<FTerrainPatchBounds> PatchBounds;
  public List<int> PatchBatches;
  public List<int> BatchMaterials;
  public int FullBatch;
  public FPointer PatchBatchOffsets = new();
  public FPointer WorkingOffsets = new();
  public FPointer PatchBatchTriangles = new();
  public FPointer PatchCachedTessellationValues = new();
  public FPointer TesselationLevels = new();
  public FTerrainBVTree BVTree = new();
  public List<FVector> CollisionVertices;
  public FPointer RBHeightfield = new();
  public bool bDisplayCollisionLevel;
}

public class UTerrainLayerSetup : UObject
{
  public class FFilterLimit
  {
    public bool Enabled;
    public float Base;
    public float NoiseScale;
    public float NoiseAmount;
  }

  public class FTerrainFilteredMaterial
  {
    public bool UseNoise;
    public float NoiseScale;
    public float NoisePercent;
    public UTerrainLayerSetup.FFilterLimit MinHeight = new();
    public UTerrainLayerSetup.FFilterLimit MaxHeight = new();
    public UTerrainLayerSetup.FFilterLimit MinSlope = new();
    public UTerrainLayerSetup.FFilterLimit MaxSlope = new();
    public float Alpha;
    public UTerrainMaterial Material;
  }

  public List<FTerrainFilteredMaterial> Materials;
}

public class UTerrainMaterial : UObject
{
  public class FTerrainFoliageMesh
  {
    public UStaticMesh StaticMesh;
    public UMaterialInterface Material;
    public int Density;
    public float MaxDrawRadius;
    public float MinTransitionRadius;
    public float MinScale;
    public float MaxScale;
    public float MinUniformScale;
    public float MaxUniformScale;
    public float MinThinningRadius;
    public int Seed;
    public float SwayScale;
    public float AlphaMapThreshold;
    public float SlopeRotationBlend;
  }

  public FMatrix LocalToMapping = new();
  public ETerrainMappingType MappingType;
  public float MappingScale;
  public float MappingRotation;
  public float MappingPanU;
  public float MappingPanV;
  public UMaterialInterface Material;
  public UTexture2D DisplacementMap;
  public float DisplacementScale;
  public List<FTerrainFoliageMesh> FoliageMeshes;
}

public class UTerrainWeightMapTexture : UTexture2D
{
  public class FTerrainWeightedMaterial
  {
  }

  public ATerrain ParentTerrain;
  public List<FPointer> WeightedMaterials;
}

public class ATestSplittingVolume : AVolume
{
  public FPointer VfTable_IInterface_NavMeshPathObject = new();
}

public class UTexture2DComposite : UTexture
{
  public class FSourceTexture2DRegion
  {
    public int OffsetX;
    public int OffsetY;
    public int SizeX;
    public int SizeY;
    public UTexture2D Texture2D;
  }

  public List<FSourceTexture2DRegion> SourceRegions;
  public int MaxTextureSize;
  public int MaxTextureSizeX;
  public int MaxTextureSizeY;
}

public class UTexture2DDynamic : UTexture
{
  public int SizeX;
  public int SizeY;
  public EPixelFormat Format;
  public int NumMips;
  public bool bIsResolveTarget;
}

public class UTextureFlipBook : UTexture2D
{
  public FPointer VfTable_FTickableObject = new();
  public float TimeIntoMovie;
  public float TimeSinceLastFrame;
  public float HorizontalScale;
  public float VerticalScale;
  public bool bPaused;
  public bool bStopped;
  public bool bLooping;
  public bool bAutoPlay;
  public int HorizontalImages;
  public int VerticalImages;
  public TextureFlipBookMethod FBMethod;
  public float FrameRate;
  public float FrameTime;
  public int CurrentRow;
  public int CurrentColumn;
  public float RenderOffsetU;
  public float RenderOffsetV;
  public FPointer ReleaseResourcesFence = new();
}

public class UTextureMovie : UTexture
{
  public int SizeX;
  public int SizeY;
  public EPixelFormat Format;
  public TextureAddress AddressX;
  public TextureAddress AddressY;
  public EMovieStreamSource MovieStreamSource;
  public UClass DecoderClass;
  public UCodecMovie Decoder;
  public bool Paused;
  public bool Stopped;
  public bool Looping;
  public bool AutoPlay;
  public FUntypedBulkData_Mirror Data = new();
  public FPointer ReleaseCodecFence = new();
}

public class UTextureRenderTargetCube : UTextureRenderTarget
{
  public int SizeX;
  public EPixelFormat Format;
}

public class UTranslationContext : UObject
{
  public List<UTranslatorTag> TranslatorTags;
}

public class ATrigger : AActor
{
  public class FCheckpointRecord
  {
    public bool bCollideActors;
  }

  public UCylinderComponent CylinderComponent;
  public bool bRecentlyTriggered;
  public float AITriggerDelay;
}

public class ATrigger_Dynamic : ATrigger
{
}

public class ATrigger_LOS : ATrigger
{
  public List<APlayerController> PCsWithLOS;
}

public class ATriggeredPath : ANavigationPoint
{
  public bool bOpen;
  public AActor MyTrigger;
}

public class ATriggerStreamingLevel : ATrigger
{
  public class FLevelStreamingData
  {
    public bool bShouldBeLoaded;
    public bool bShouldBeVisible;
    public bool bShouldBlockOnLoad;
    public ULevelStreaming Level;
  }

  public List<FLevelStreamingData> Levels;
}

public class UUberPostProcessEffect : UDOFBloomMotionBlurEffect
{
  public FVector SceneShadows = new();
  public FVector SceneHighLights = new();
  public FVector SceneMidTones = new();
  public float SceneDesaturation;
  public bool bEnableHDRTonemapper;
  public float EdgeDetectionThreshold;
  public EPostProcessAAType PostProcessAAType;
}

public class UUIAction : USequenceAction
{
  public bool bAutoTargetOwner;
}

public class UUIAction_ActivateLevelEvent : UUIAction
{
  public FName EventName;
}

public class UUIAction_Scene : UUIAction
{
  public UUIScene Scene;
  public byte ForcedScenePriority;
}

public class UUIAction_CloseScene : UUIAction_Scene
{
}

public class UUIAction_ConsoleCommand : UUIAction
{
  public string Command;
}

public class UUIAction_OpenScene : UUIAction_Scene
{
  public UUIScene OpenedScene;
  public int DesiredPlayerIndex;
}

public class UUIAnimationSeq : UUIAnimation
{
  public FName SeqName;
  public List<FUIAnimTrack> Tracks;
  public EUIAnimationLoopMode LoopMode;
}

public class UUIButton : UUIObject
{
  public UUIComp_DrawImage BackgroundImageComponent;
  public FName ClickedCue;
}

public class UUIEvent_OnClick : UUIEvent
{
}

public class UUILabelButton : UUIButton
{
  public FPointer VfTable_IUIDataStorePublisher = new();
  public FUIDataStoreBinding CaptionDataSource = new();
  public UUIComp_DrawString StringRenderComponent;
}

public class UUICalloutButton : UUILabelButton
{
  public string DefaultMarkupStringTemplate;
  public FName CalloutDataStoreTag;
  public FName InputAliasTag;
  public EUIAlignment IconAlignment;
  public bool bSupportsButtonRepeat;
  public bool bPlayErrorSoundWhenDisabled;
}

public class UUICalloutButtonPanel : UUIContainer
{
  public UUICalloutButton ButtonTemplate;
  public List<UUICalloutButton> CalloutButtons;
  public EUIOrientation ButtonBarOrientation;
  public ECalloutButtonLayoutType ButtonLayout;
  public FUIScreenValue_Extent[] ButtonPadding = new FUIScreenValue_Extent[2];
  public Dictionary<byte, byte> ButtonInputKeyMappings;
  public List<FName> CalloutButtonAliases;
  public bool bGeneratingInitialButtons;
  public bool bSupportsButtonRepeat;
  public bool bRefreshButtonDocking;
}

public class UUICharacterSummary : UUIResourceDataProvider
{
  public string ClassPathName;
  public string CharacterName;
  public string CharacterBio;
  public bool bIsDisabled;
}

public class UUICheckbox : UUIButton
{
  public FPointer VfTable_IUIDataStorePublisher = new();
  public FName CheckedCue;
  public FName UncheckedCue;
  public FUIDataStoreBinding ValueDataSource = new();
  public UUIComp_DrawImage CheckedImageComponent;
  public bool bIsChecked;
}

public class UUIComboBox : UUIObject
{
  public FPointer VfTable_IUIDataStorePublisher = new();
  public UClass ComboEditboxClass;
  public UClass ComboButtonClass;
  public UClass ComboListClass;
  public UUIEditBox ComboEditbox;
  public UUIToggleButton ComboButton;
  public UUIList ComboList;
  public UUIComp_DrawCaption CaptionRenderComponent;
  public UUIComp_DrawImage BackgroundRenderComponent;
  public FUIDataStoreBinding CaptionDataSource = new();
  public FName OpenList;
  public FName DecrementCue;
  public bool bDockListToButton;
  public FScriptDelegate __CreateCustomComboEditbox__Delegate;
  public FScriptDelegate __CreateCustomComboButton__Delegate;
  public FScriptDelegate __CreateCustomComboList__Delegate;
}

public class UUIComp_AutoAlignment : UUIComponent
{
  public EUIAlignment HorzAlignment;
  public EUIAlignment VertAlignment;
}

public class UUIComp_ListComponentBase : UUIComponent
{
}

public class UUIComp_ListPresenterBase : UUIComp_ListComponentBase
{
  public class FUIListItemDataBinding
  {
    public FScriptInterface DataSourceProvider;
    public FName DataSourceTag;
    public int DataSourceIndex;
  }

  public bool bReapplyFormatting;
}

public class UUITexture : UUIRoot
{
  public FUICombinedStyleData ImageStyleData = new();
  public USurface ImageTexture;
}

public class UUIComp_ListPresenter : UUIComp_ListPresenterBase
{
  public class FUIListElementCell
  {
    public int ContainerElementIndex;
    public UUIList OwnerList;
    public UUIRoot.FUIStyleReference[] CellStyle = new UUIRoot.FUIStyleReference[4];
    public UObject ValueObject;
  }

  public class FUIListElementCellTemplate : FUIListElementCell
  {
    public FName CellDataField;
    public string ColumnHeaderText;
    public UUIRoot.FUIScreenValue_Extent CellSize = new();
    public float CellPosition;
  }

  public class FUIListItem
  {
    public UUIComp_ListPresenterBase.FUIListItemDataBinding DataSource = new();
    public List<UUIComp_ListPresenter.FUIListElementCell> Cells;
    public EUIListElementState ElementState;
    public UUIObject ElementWidget;
  }

  public class FUIElementCellSchema
  {
    public List<UUIComp_ListPresenter.FUIListElementCellTemplate> Cells;
  }

  public FPointer VfTable_ICustomPropertyItemHandler = new();
  public FUIElementCellSchema ElementSchema = new();
  public UUIRoot.FUIScreenValue_Extent SelectionHintPadding = new();
  public List<FUIListItem> ListItems;
  public UUITexture[] ColumnHeaderBackground = new UUITexture[3];
  public UUITexture[] ListItemOverlay = new UUITexture[4];
  public UUIRoot.FTextureCoordinates[] ColumnHeaderBackgroundCoordinates = new UUIRoot.FTextureCoordinates[3];
  public UUIRoot.FTextureCoordinates[] ListItemOverlayCoordinates = new UUIRoot.FTextureCoordinates[4];
  public int MaxElementsPerPage;
  public bool bDisplayColumnHeaders;
}

public class UUIComp_ListPresenterCascade : UUIComp_ListPresenter
{
}

public class UUIComp_ContextMenuListPresenter : UUIComp_ListPresenterCascade
{
}

public class UUIComp_DrawCaption : UUIComp_DrawString
{
}

public class UUIComp_DrawStringSlider : UUIComp_DrawString
{
}

public class UUIComp_ListElementSorter : UUIComp_ListComponentBase
{
  public class FUIListSortingParameters
  {
    public int PrimaryIndex;
    public int SecondaryIndex;
    public bool bReversePrimarySorting;
    public bool bReverseSecondarySorting;
    public bool bCaseSensitive;
    public bool bIntSortPrimary;
    public bool bIntSortSecondary;
    public bool bFloatSortPrimary;
    public bool bFloatSortSecondary;
  }

  public bool bAllowCompoundSorting;
  public bool bReversePrimarySorting;
  public bool bReverseSecondarySorting;
  public int InitialSortColumn;
  public int InitialSecondarySortColumn;
  public int PrimarySortColumn;
  public int SecondarySortColumn;
  public FScriptDelegate __OverrideListSort__Delegate;
}

public class UUIComp_ListPresenterTree : UUIComp_ListPresenter
{
}

public class UUIComp_ObjectListPresenter : UUIComp_ListPresenter
{
}

public class UUICond_IsFocused : USequenceCondition
{
}

public class UUICond_SwitchWidget : USeqCond_SwitchObject
{
}

public class UUIConfigProvider : UUIDataProvider
{
}

public class UUIConfigFileProvider : UUIConfigProvider
{
  public List<UUIConfigSectionProvider> Sections;
  public string ConfigFileName;
}

public class UUIConfigSectionProvider : UUIConfigProvider
{
  public string SectionName;
}

public class UUIScrollbar : UUIObject
{
  public UUIComp_DrawImage BackgroundImageComponent;
  public UUIScrollbarButton IncrementButton;
  public UUIScrollbarButton DecrementButton;
  public UUIScrollbarMarkerButton MarkerButton;
  public FUIStyleReference IncrementStyle = new();
  public FUIStyleReference DecrementStyle = new();
  public FUIStyleReference MarkerStyle = new();
  public float NudgeValue;
  public float NudgeMultiplier;
  public float NudgePercent;
  public float MarkerPosPercent;
  public float MarkerSizePercent;
  public FUIScreenValue_Extent BarWidth = new();
  public FUIScreenValue_Extent MinimumMarkerSize = new();
  public FUIScreenValue_Extent ButtonsExtent = new();
  public EUIOrientation ScrollbarOrientation;
  public bool bAddCornerPadding;
  public bool bInitializeMarker;
  public FUIScreenValue_Position MousePosition = new();
  public float MousePositionDelta;
  public FScriptDelegate __OnScrollActivity__Delegate;
  public FScriptDelegate __OnClickedScrollZone__Delegate;
}

public class UUIList : UUIObject
{
  public class FCellHitDetectionInfo
  {
    public int HitColumn;
    public int HitRow;
    public int ResizeColumn;
    public int ResizeRow;
  }

  public FPointer VfTable_IUIDataStorePublisher = new();
  public FUIScreenValue_Extent RowHeight = new();
  public FUIScreenValue_Extent MinColumnSize = new();
  public FUIScreenValue_Extent ColumnWidth = new();
  public FUIScreenValue_Extent HeaderCellPadding = new();
  public FUIScreenValue_Extent HeaderElementSpacing = new();
  public FUIScreenValue_Extent CellSpacing = new();
  public FUIScreenValue_Extent CellPadding = new();
  public int Index;
  public int TopIndex;
  public int MaxVisibleItems;
  public int ColumnCount;
  public int RowCount;
  public ECellAutoSizeMode ColumnAutoSizeMode;
  public ECellAutoSizeMode RowAutoSizeMode;
  public ECellLinkType CellLinkType;
  public EListWrapBehavior WrapType;
  public bool bEnableMultiSelect;
  public bool bEnableVerticalScrollbar;
  public bool bInitializeScrollbars;
  public bool bAllowDisabledItemSelection;
  public bool bSingleClickSubmission;
  public bool bUpdateItemUnderCursor;
  public bool bHoverStateOverridesSelected;
  public bool bForceFullPageDisplay;
  public bool bAllowColumnResizing;
  public bool bDisplayDataBindings;
  public bool bSortingList;
  public UUIScrollbar VerticalScrollbar;
  public FUIStyleReference[] GlobalCellStyle = new FUIStyleReference[4];
  public FUIStyleReference ColumnHeaderStyle = new();
  public FUIStyleReference[] ColumnHeaderBackgroundStyle = new FUIStyleReference[3];
  public FUIStyleReference[] ItemOverlayStyle = new FUIStyleReference[4];
  public int ResizeColumn;
  public int SetIndexMutex;
  public int ValueChangeNotificationMutex;
  public FUIDataStoreBinding DataSource = new();
  public FScriptInterface DataProvider;
  public List<int> Items;
  public List<int> SelectedItems;
  public UUIComp_DrawImage BackgroundImageComponent;
  public UUIComp_ListElementSorter SortComponent;
  public UUIComp_ListPresenterBase CellDataComponent;
  public FName SubmitDataSuccessCue;
  public FName SubmitDataFailedCue;
  public FName DecrementIndexCue;
  public FName IncrementIndexCue;
  public FName SortAscendingCue;
  public FName SortDescendingCue;
  public FScriptDelegate __OnSubmitSelection__Delegate;
  public FScriptDelegate __OnListElementsSorted__Delegate;
  public FScriptDelegate __ShouldDisableElement__Delegate;
  public FScriptDelegate __OnOverrideListElementState__Delegate;
}

public class UUIContextMenu : UUIList
{
  public class FContextMenuItem
  {
    public UUIContextMenu OwnerMenu;
    public UObject.FPointer ParentItem = new();
    public EContextMenuItemType ItemType;
    public string ItemText;
    public int ItemId;
  }

  public UUIObject InvokingWidget;
  public List<FContextMenuItem> MenuItems;
  public bool bResolvePosition;
}

public partial class UUISkin : UUIDataStore
{
  public class FUISoundCue
  {
    public FName SoundName;
    public USoundCue SoundToPlay;
  }

  public class FUICursorStyle
  {
    public UUITexture CursorImage;
    public FName CursorImageStyle;
  }

  public List<UUIStyle> Styles;
  public List<string> StyleGroups;
  public List<FUISoundCue> SoundCues;
  public Dictionary<byte, byte> StyleLookupTable;
  public Dictionary<byte, byte> StyleNameMap;
  public List<string> StyleGroupMap;
  public Dictionary<FName, FUICursorStyle> CursorMap;
  public Dictionary<byte, byte> SoundCueMap;
}

public class UUICustomSkin : UUISkin
{
  public Dictionary<byte, byte> WidgetStyleMap;
}

public class UUIDataProvider_MenuItem : UUIResourceDataProvider
{
  public EMenuOptionType OptionType;
  public EEditBoxCharacterSet EditboxAllowedChars;
  public List<FName> OptionSet;
  public string DataStoreMarkup;
  public string DescriptionMarkup;
  public FName RequiredGameMode;
  public string FriendlyName;
  public string CustomFriendlyName;
  public string Description;
  public bool bEditableCombo;
  public bool bNumericCombo;
  public bool bKeyboardOrMouseOption;
  public bool bOnlineOnly;
  public bool bOfflineOnly;
  public bool bSearchAllInis;
  public bool bRemoveOn360;
  public bool bRemoveOnPC;
  public bool bRemoveOnPS3;
  public int EditBoxMaxLength;
  public FUIRangeData RangeData = new();
  public List<FName> SchemaCellFields;
  public string IniName;
}

public class UUIDataProvider_OnlinePlayerDataBase : UUIDataProvider
{
  public int PlayerControllerId;
}

public class UUIDataProvider_OnlineFriendMessages : UUIDataProvider_OnlinePlayerDataBase
{
  public FPointer VfTable_IUIListElementCellProvider = new();
  public List<UOnlineSubsystem.FOnlineFriendMessage> Messages;
  public string SendingPlayerNameCol;
  public string bIsFriendInviteCol;
  public string bWasAcceptedCol;
  public string bWasDeniedCol;
  public string MessageCol;
  public string LastInviteFrom;
}

public class UUIDataProvider_OnlineFriends : UUIDataProvider_OnlinePlayerDataBase
{
  public FPointer VfTable_IUIListElementCellProvider = new();
  public List<UOnlineSubsystem.FOnlineFriend> FriendsList;
  public string NickNameCol;
  public string PresenceInfoCol;
  public string FriendStateCol;
  public string bIsOnlineCol;
  public string bIsPlayingCol;
  public string bIsPlayingThisGameCol;
  public string bIsJoinableCol;
  public string bHasVoiceSupportCol;
  public string bHaveInvitedCol;
  public string bHasInvitedYouCol;
  public string OfflineText;
  public string OnlineText;
  public string AwayText;
  public string BusyText;
}

public class UUIDataProvider_OnlinePartyChatList : UUIDataProvider_OnlinePlayerDataBase
{
  public FPointer VfTable_IUIListElementCellProvider = new();
  public List<UOnlineSubsystem.FOnlinePartyMember> PartyMembersList;
  public List<string> NatTypes;
  public string NickNameCol;
  public string NatTypeCol;
  public string IsLocalCol;
  public string IsInPartyVoiceCol;
  public string IsTalkingCol;
  public string IsInGameSessionCol;
  public string IsPlayingThisGameCol;
}

public class UUIDataProvider_OnlinePlayerStorage : UUIDataProvider_OnlinePlayerDataBase
{
  public class FPlayerStorageArrayProvider
  {
    public int PlayerStorageId;
    public FName PlayerStorageName;
    public UUIDataProvider_OnlinePlayerStorageArray Provider;
  }

  public UOnlinePlayerStorage Profile;
  public FName ProviderName;
  public bool bWasErrorLastRead;
  public List<FPlayerStorageArrayProvider> PlayerStorageArrayProviders;
}

public class UUIDataProvider_OnlinePlayerStorageArray : UUIDataProvider
{
  public FPointer VfTable_IUIListElementProvider = new();
  public FPointer VfTable_IUIListElementCellProvider = new();
  public UOnlinePlayerStorage PlayerStorage;
  public int PlayerStorageId;
  public FName PlayerStorageName;
  public string ColumnHeaderText;
  public List<FName> Values;
}

public class UUIDataProvider_OnlineProfileSettings : UUIDataProvider_OnlinePlayerStorage
{
}

public class UUIDataProvider_PlayerAchievements : UUIDataProvider_OnlinePlayerDataBase
{
  public FPointer VfTable_IUIListElementCellProvider = new();
  public List<UOnlineSubsystem.FAchievementDetails> Achievements;
}

public class UUIDataProvider_Settings : UUIDynamicDataProvider
{
  public class FSettingsArrayProvider
  {
    public int SettingsId;
    public FName SettingsName;
    public UUIDataProvider_SettingsArray Provider;
  }

  public USettings Settings;
  public List<FSettingsArrayProvider> SettingsArrayProviders;
  public bool bIsAListRow;
}

public class UUIDataProvider_SettingsArray : UUIDataProvider
{
  public FPointer VfTable_IUIListElementProvider = new();
  public FPointer VfTable_IUIListElementCellProvider = new();
  public USettings Settings;
  public int SettingsId;
  public FName SettingsName;
  public string ColumnHeaderText;
  public List<USettings.FIdToStringMapping> Values;
}

public class UUIDataStore_Color : UUIDataStore
{
}

public class UUIDataStore_DynamicResource : UUIDataStore
{
  public class FDynamicResourceProviderDefinition
  {
    public FName ProviderTag;
    public string ProviderClassName;
    public UClass ProviderClass;
  }

  public FPointer VfTable_IUIListElementProvider = new();
  public UUIDataProvider_OnlineProfileSettings ProfileProvider;
  public UUIDataStore_GameResource GameResourceDataStore;
  public List<FDynamicResourceProviderDefinition> ResourceProviderDefinitions;
  public FMultiMap_Mirror ResourceProviders = new();
}

public class UUIDataStore_Fonts : UUIDataStore
{
}

public class UUIDataStore_GameResource : UUIDataStore
{
  public class FGameResourceDataProvider
  {
    public FName ProviderTag;
    public string ProviderClassName;
    public bool bExpandProviders;
    public UClass ProviderClass;
  }

  public FPointer VfTable_IUIListElementProvider = new();
  public List<FGameResourceDataProvider> ElementProviderTypes;
  public FMultiMap_Mirror ListElementProviders = new();
}

public class UUIDataStore_Gamma : UUIDataStore
{
}

public class UUIDataStore_Images : UUIDataStore
{
}

public class UUIDataStore_StringBase : UUIDataStore
{
}

public class UUIDataStore_InputAlias : UUIDataStore_StringBase
{
  public class FUIInputKeyData
  {
    public UUIRoot.FRawInputKeyEventData InputKeyData = new();
    public string ButtonFontMarkupString;
  }

  public class FUIDataStoreInputAlias
  {
    public FName AliasName;
    public UUIDataStore_InputAlias.FUIInputKeyData[] PlatformInputKeys = new UUIDataStore_InputAlias.FUIInputKeyData[3];
  }

  public List<FUIDataStoreInputAlias> InputAliases;
  public Dictionary<byte, byte> InputAliasLookupMap;
}

public class UUIDataStore_MenuItems : UUIDataStore_GameResource
{
  public FName CurrentGameSettingsTag;
  public FMultiMap_Mirror OptionProviders = new();
  public List<UUIDataProvider_MenuItem> DynamicProviders;
}

public class UUIDataStore_Remote : UUIDataStore
{
}

public class UUIDataStore_OnlineGameSearch : UUIDataStore_Remote
{
  public class FGameSearchCfg
  {
    public UClass GameSearchClass;
    public UClass DefaultGameSettingsClass;
    public UClass SearchResultsProviderClass;
    public UUIDataProvider_Settings DesiredSettingsProvider;
    public List<UUIDataProvider_Settings> SearchResults;
    public UOnlineGameSearch Search;
    public FName SearchName;
  }

  public FPointer VfTable_IUIListElementProvider = new();
  public FPointer VfTable_IUIListElementCellProvider = new();
  public FName SearchResultsName;
  public UOnlineSubsystem OnlineSub;
  public FScriptInterface GameInterface;
  public List<FGameSearchCfg> GameSearchCfgList;
  public int SelectedIndex;
  public int ActiveSearchIndex;
}

public class UUIDataStore_Settings : UUIDataStore
{
}

public class UUIDataStore_OnlineGameSettings : UUIDataStore_Settings
{
  public class FGameSettingsCfg
  {
    public UClass GameSettingsClass;
    public UUIDataProvider_Settings Provider;
    public UOnlineGameSettings GameSettings;
    public FName SettingsName;
  }

  public List<FGameSettingsCfg> GameSettingsCfgList;
  public UClass SettingsProviderClass;
  public int SelectedIndex;
}

public class UUIDataStore_OnlinePlayerData : UUIDataStore_Remote
{
  public FPointer VfTable_IUIListElementProvider = new();
  public UUIDataProvider_OnlineFriends FriendsProvider;
  public int PlayerControllerId;
  public string PlayerNick;
  public int NumNewDownloads;
  public int NumTotalDownloads;
  public string ProfileSettingsClassName;
  public UClass ProfileSettingsClass;
  public UUIDataProvider_OnlineProfileSettings ProfileProvider;
  public string PlayerStorageClassName;
  public UClass PlayerStorageClass;
  public UUIDataProvider_OnlinePlayerStorage StorageProvider;
  public UUIDataProvider_OnlineFriendMessages FriendMessagesProvider;
  public UUIDataProvider_PlayerAchievements AchievementsProvider;
  public string FriendsProviderClassName;
  public UClass FriendsProviderClass;
  public string FriendMessagesProviderClassName;
  public UClass FriendMessagesProviderClass;
  public string AchievementsProviderClassName;
  public UClass AchievementsProviderClass;
  public string PartyChatProviderClassName;
  public UClass PartyChatProviderClass;
  public UUIDataProvider_OnlinePartyChatList PartyChatProvider;
}

public class UUIDataStore_OnlinePlaylists : UUIDataStore
{
  public FPointer VfTable_IUIListElementProvider = new();
  public string ProviderClassName;
  public UClass ProviderClass;
  public List<UUIResourceDataProvider> RankedDataProviders;
  public List<UUIResourceDataProvider> UnRankedDataProviders;
}

public class UUIDataStore_OnlineStats : UUIDataStore_Remote
{
  public class FPlayerNickMetaData
  {
    public FName PlayerNickName;
    public string PlayerNickColumnName;
  }

  public class FRankMetaData
  {
    public FName RankName;
    public string RankColumnName;
  }

  public FPointer VfTable_IUIListElementProvider = new();
  public FPointer VfTable_IUIListElementCellProvider = new();
  public List<UClass> StatsReadClasses;
  public FName StatsReadName;
  public FPlayerNickMetaData PlayerNickData = new();
  public FRankMetaData RankNameMetaData = new();
  public FName TotalRowsName;
  public List<UOnlineStatsRead> StatsReadObjects;
  public UOnlineStatsRead StatsRead;
  public EStatsFetchType CurrentReadType;
  public FScriptInterface StatsInterface;
  public FScriptInterface PlayerInterface;
}

public class UUIDataStore_Registry : UUIDataStore
{
  public UUIDynamicFieldProvider RegistryDataProvider;
}

public class UUIDataStore_SessionSettings : UUIDataStore_Settings
{
  public List<string> SessionSettingsProviderClassNames;
  public List<UClass> SessionSettingsProviderClasses;
  public List<USessionSettingsProvider> SessionSettings;
}

public class UUIDataStore_StringAliasMap : UUIDataStore_StringBase
{
  public class FUIMenuInputMap
  {
    public FName FieldName;
    public FName Set;
    public string MappedText;
  }

  public List<FUIMenuInputMap> MenuInputMapArray;
  public FMap_Mirror MenuInputSets = new();
  public int PlayerIndex;
}

public class UUIDataStore_Strings : UUIDataStore_StringBase
{
  public List<UUIConfigFileProvider> LocFileProviders;
}

public class UUIDataStoreSubscriber : UInterface
{
}

public class UUIDataStorePublisher : UUIDataStoreSubscriber
{
}

public partial class UUIDynamicFieldProvider : UUIDataProvider
{
  public List<FUIProviderScriptFieldValue> PersistentDataFields;
  public List<FUIProviderScriptFieldValue> RuntimeDataFields;
  public Dictionary<FName, Dictionary<FName, List<string>>> PersistentCollectionData;
  public FMap_Mirror RuntimeCollectionData = new();
}

public class UUIString : UUIRoot
{
  public List<FPointer> Nodes;
  public FUICombinedStyleData StringStyleData = new();
  public FVector2D StringExtent = new();
}

public class UUIEditboxString : UUIString
{
}

public class UUIEvent_CalloutButtonInputProxy : UUIEvent
{
  public UUICalloutButtonPanel ButtonPanel;
}

public class UUIEvent_MetaObject : UUIEvent
{
  public FPointer VfTable_FCallbackEventDevice = new();
}

public class UUIEvent_OnDoubleClick : UUIEvent
{
}

public class UUIEvent_State : UUIEvent
{
}

public class UUIEvent_OnEnterState : UUIEvent_State
{
}

public class UUIEvent_OnLeaveState : UUIEvent_State
{
}

public class UUIEvent_ProcessInput : UUIEvent
{
  public FMultiMap_Mirror ActionMap = new();
}

public class UUIEvent_Scene : UUIEvent
{
}

public class UUIEvent_SceneActivated : UUIEvent_Scene
{
  public bool bInitialActivation;
}

public class UUIEvent_SceneDeactivated : UUIEvent_Scene
{
}

public class UUIEvent_ValueChanged : UUIEvent
{
}

public class UUIEventContainer : UInterface
{
}

public class UUIFocusHint : UUILabel
{
}

public class UUIFrameBox : UUIContainer
{
  public class FCornerSizes
  {
    public float[] TopLeft = new float[2];
    public float[] TopRight = new float[2];
    public float[] BottomLeft = new float[2];
    public float[] BottomRight = new float[2];
    public float TopHeight;
    public float BottomHeight;
    public float CenterLeftWidth;
    public float CenterRightWidth;
  }

  public UUIComp_DrawImage[] BackgroundImageComponent = new UUIComp_DrawImage[9];
  public FCornerSizes BackgroundCornerSizes = new();
}

public class UUIGameInfoSummary : UUIResourceDataProvider
{
  public string ClassName;
  public string GameAcronym;
  public string MapPrefix;
  public bool bIsTeamGame;
  public bool bIsDisabled;
  public string GameSettingsClassName;
  public string GameName;
  public string Description;
}

public class UUIInputConfiguration : UUIRoot
{
  public List<FUIInputAliasClassMap> WidgetInputAliases;
  public List<FUIAxisEmulationDefinition> AxisEmulationDefinitions;
}

public class UUIInteraction : UInteraction
{
  public class FUIKeyRepeatData
  {
    public FName CurrentRepeatKey;
    public double NextRepeatTime = new();
  }

  public class FUIAxisEmulationData : FUIKeyRepeatData
  {
    public bool bEnabled;
  }

  public FPointer VfTable_FExec = new();
  public FPointer VfTable_FGlobalDataStoreClientManager = new();
  public FPointer VfTable_FCallbackEventDevice = new();
  public UClass SceneClientClass;
  public UGameUISceneClient SceneClient;
  public string UISkinName;
  public List<FName> UISoundCueNames;
  public List<FName> SupportedDoubleClickKeys;
  public UDataStoreClient DataStoreManager;
  public UUIInputConfiguration UIInputConfig;
  public Dictionary<byte, byte> WidgetInputAliasLookupTable;
  public bool bProcessInput;
  public bool bDisableToolTips;
  public bool bFocusOnActive;
  public bool bFocusedStateRules;
  public bool bIsUIPrimitiveSceneInitialized;
  public float UIJoystickDeadZone;
  public float UIAxisMultiplier;
  public float AxisRepeatDelay;
  public float MouseButtonRepeatDelay;
  public float DoubleClickTriggerSeconds;
  public int DoubleClickPixelTolerance;
  public float ToolTipInitialDelaySeconds;
  public float ToolTipExpirationSeconds;
  public FUIKeyRepeatData MouseButtonRepeatInfo = new();
  public List<FUIAxisEmulationDefinition> ConfiguredAxisEmulationDefinitions;
  public Dictionary<byte, byte> AxisEmulationDefinitions;
  public FUIAxisEmulationData[] AxisInputEmulation = new FUIAxisEmulationData[4];
  public FPointer CanvasScene = new();
}

public class UUILayerBase : UUIRoot
{
}

public class UUIListElementCellProvider : UInterface
{
}

public class UUIListElementProvider : UInterface
{
}

public class UUIListString : UUIString
{
}

public class UUIMapSummary : UUIResourceDataProvider
{
  public string MapName;
  public string ScreenshotPathName;
  public string DisplayName;
  public string Description;
}

public class UUIMeshWidget : UUIObject
{
  public UStaticMeshComponent Mesh;
}

public class UUIScene : UUIScreenObject
{
  public FName SceneTag;
  public UUISceneClient SceneClient;
  public USceneDataStore SceneData;
  public ULocalPlayer PlayerOwner;
  public UUIContextMenu ActiveContextMenu;
  public UUIContextMenu StandardContextMenu;
  public UClass DefaultContextMenuClass;
  public UUISkin SceneSkin;
  public UUISafeRegionPanel PrimarySafeRegionPanel;
  public List<FUIDockingNode> DockingStack;
  public List<UUIObject> RenderStack;
  public List<FScriptInterface> TickableObjects;
  public List<UUIScreenObject> AnimatingObjects;
  public FMap_Mirror[] InputSubscriptions = new FMap_Mirror[4];
  public int LastPlayerIndex;
  public bool bUpdateDockingStack;
  public bool bUpdateScenePositions;
  public bool bUpdateNavigationLinks;
  public bool bUpdatePrimitiveUsage;
  public bool bRefreshWidgetStyles;
  public bool bRefreshStringFormatting;
  public bool bRecalculateInputMask;
  public bool bPerformedInitialUpdate;
  public bool bResolvingScenePositions;
  public bool bUsesPrimitives;
  public bool bSupportsNavigation;
  public bool bReevaluateRotationSupport;
  public bool bSupportsRotation;
  public bool bDisplayCursor;
  public bool bRenderParentScenes;
  public bool bAlwaysRenderScene;
  public bool bPauseGameWhileActive;
  public bool bExemptFromAutoClose;
  public bool bCloseOnLevelChange;
  public bool bSaveSceneValuesOnClose;
  public bool bEnableScenePostProcessing;
  public bool bEnableSceneDepthTesting;
  public bool bRequiresNetwork;
  public bool bRequiresOnlineService;
  public bool bMenuLevelRestoresScene;
  public bool bFlushPlayerInput;
  public bool bCaptureMatchedInput;
  public bool bDisableWorldRendering;
  public bool bAnimationBlockingInput;
  public int UpdateSceneFeedbackLoopCount;
  public int SceneStackPriority;
  public UTexture2D ScenePreview;
  public byte PlayerInputMask;
  public EScreenInputMode SceneInputMode;
  public ESplitscreenRenderMode SceneRenderMode;
  public EUIPostProcessGroup ScenePostProcessGroup;
  public UPostProcessChain UIPostProcessForeground;
  public UPostProcessChain UIPostProcessBackground;
  public APostProcessVolume.FPostProcessSettings CurrentBackgroundSettings = new();
  public APostProcessVolume.FPostProcessSettings CurrentForegroundSettings = new();
  public FVector2D CurrentViewportSize = new();
  public FName SceneAnimation_Open;
  public FName SceneAnimation_Close;
  public FName SceneAnimation_LoseFocus;
  public FName SceneAnimation_RegainingFocus;
  public FName SceneAnimation_RegainedFocus;
  public FName SceneOpenedCue;
  public FName SceneClosedCue;
  public UUILayerBase SceneLayerRoot;
  public FScriptDelegate __GetSceneInputModeOverride__Delegate;
  public FScriptDelegate __OnInterceptRawInputKey__Delegate;
  public FScriptDelegate __OnSceneActivated__Delegate;
  public FScriptDelegate __OnSceneDeactivated__Delegate;
  public FScriptDelegate __OnQueryCloseSceneAllowed__Delegate;
  public FScriptDelegate __OnTopSceneChanged__Delegate;
  public FScriptDelegate __ShouldModulateBackgroundAlpha__Delegate;
  public FScriptDelegate __OnQueryBeginAnimation_DisableInput__Delegate;
  public FScriptDelegate __OnQueryEndAnimation_EnableInput__Delegate;
}

public class UUIMessageBoxBase : UUIScene
{
  public UUILabel lblTitle;
  public UUILabel lblMessage;
  public UUILabel lblQuestion;
  public UUIImage imgQuestion;
  public UUICalloutButtonPanel btnbarChoices;
  public FName TitleWidgetName;
  public FName MessageWidgetName;
  public FName QuestionWidgetName;
  public FName ChoicesWidgetName;
  public FName QuestionWidgetImageName;
  public FName ButtonBarButtonBGStyleName;
  public FName ButtonBarButtonTextStyleName;
  public bool bPerformAutomaticLayout;
  public FScriptDelegate __OnOptionSelected__Delegate;
}

public class UUIMessageBox : UUIMessageBoxBase
{
}

public class UUINavigationList : UUIList
{
}

public class UUINumericEditBox : UUIEditBox
{
  public FUIStyleReference IncrementStyle = new();
  public FUIStyleReference DecrementStyle = new();
  public UUINumericEditBoxButton IncrementButton;
  public UUINumericEditBoxButton DecrementButton;
  public FUIRangeData NumericValue = new();
  public int DecimalPlaces;
  public FUIScreenValue_Bounds IncButton_Position = new();
  public FUIScreenValue_Bounds DecButton_Position = new();
}

public class UUINumericEditBoxButton : UUIButton
{
}

public class UUIOptionListButton : UUIButton
{
}

public class UUIOptionListBase : UUIObject
{
  public FPointer VfTable_IUIDataStorePublisher = new();
  public FUIStyleReference DecrementStyle = new();
  public FUIStyleReference IncrementStyle = new();
  public UUIOptionListButton DecrementButton;
  public UUIOptionListButton IncrementButton;
  public UClass OptionListButtonClass;
  public FUIScreenValue_Extent ButtonSpacing = new();
  public UUIComp_DrawImage BackgroundImageComponent;
  public UUIComp_DrawString StringRenderComponent;
  public FName IncrementCue;
  public FName DecrementCue;
  public bool bWrapOptions;
  public FUIDataStoreBinding DataSource = new();
  public FScriptDelegate __CreateCustomDecrementButton__Delegate;
  public FScriptDelegate __CreateCustomIncrementButton__Delegate;
}

public class UUINumericOptionList : UUIOptionListBase
{
  public FUIRangeData RangeValue = new();
}

public class UUIObjectList : UUIList
{
}

public class UUIOptionList : UUIOptionListBase
{
  public int CurrentIndex;
  public FScriptInterface DataProvider;
  public FScriptDelegate __OnIsCurrValueValid__Delegate;
}

public class UUIPrefab : UUIObject
{
  public class FArchetypeInstancePair
  {
    public UUIObject WidgetArchetype;
    public UUIObject WidgetInstance;
    public float[] ArchetypeBounds = new float[4];
    public float[] InstanceBounds = new float[4];
  }

  public int PrefabVersion;
  public int InternalPrefabVersion;
  public UTexture2D PrefabPreview;
  public int ModificationCounter;
  public FUIScreenValue_Extent OriginalWidth = new();
  public FUIScreenValue_Extent OriginalHeight = new();
}

public class UUIPrefabInstance : UUIObject
{
  public UUIPrefab SourcePrefab;
  public int PrefabInstanceVersion;
  public Dictionary<byte, byte> ArchetypeToInstanceMap;
  public int PI_PackageVersion;
  public int PI_LicenseePackageVersion;
  public int PI_DataOffset;
  public List<byte> PI_Bytes;
  public List<UObject> PI_CompleteObjects;
  public List<UObject> PI_ReferencedObjects;
  public List<string> PI_SavedNames;
  public Dictionary<byte, byte> PI_ObjectMap;
}

public class UUIPrefabScene : UUIScene
{
  public FPointer VfTable_FCallbackEventDevice = new();
}

public class UUIProgressBar : UUIObject
{
  public FPointer VfTable_IUIDataStorePublisher = new();
  public UUIComp_DrawImage BackgroundImageComponent;
  public UUIComp_DrawImage FillImageComponent;
  public UUIComp_DrawImage OverlayImageComponent;
  public bool bDrawOverlay;
  public FUIDataStoreBinding DataSource = new();
  public FUIRangeData ProgressBarValue = new();
  public EUIOrientation ProgressBarOrientation;
}

public class UUIResourceCombinationProvider : UUIDataProvider
{
  public FPointer VfTable_IUIListElementProvider = new();
  public FPointer VfTable_IUIListElementCellProvider = new();
  public UUIResourceDataProvider StaticDataProvider;
  public UUIDataProvider_OnlineProfileSettings ProfileProvider;
}

public class UUISafeRegionPanel : UUIContainer
{
  public ESafeRegionType RegionType;
  public float[] RegionPercentages = new float[2];
  public bool bForce4x3AspectRatio;
  public bool bUseFullRegionIn4x3;
  public bool bPrimarySafeRegion;
}

public class UUIScriptConsoleScene : UUIScene
{
  public UUILabel BufferText;
  public UUIImage BufferBackground;
  public UScriptConsoleEntry CommandRegion;
}

public class UUIScrollbarButton : UUIButton
{
}

public class UUIScrollbarMarkerButton : UUIScrollbarButton
{
  public FScriptDelegate __OnButtonDragged__Delegate;
}

public class UUIScrollFrame : UUIContainer
{
  public UUIComp_DrawImage StaticBackgroundImage;
  public UUIScrollbar ScrollbarHorizontal;
  public UUIScrollbar ScrollbarVertical;
  public FUIScreenValue_Extent HorizontalClientRegion = new();
  public FUIScreenValue_Extent VerticalClientRegion = new();
  public FVector2D ClientRegionPosition = new();
  public float[] FrameBounds = new float[4];
  public bool bRefreshScrollbars;
  public bool bRecalculateClientRegion;
}

public class UUISequence : USequence
{
  public FPointer VfTable_IUIEventContainer = new();
  public List<UUIEvent> UIEvents;
}

public class UUISettingsClient : UInterface
{
}

public class UUISlider : UUIObject
{
  public FPointer VfTable_IUIDataStorePublisher = new();
  public UUIComp_DrawImage BackgroundImageComponent;
  public UUIComp_DrawImage SliderBarImageComponent;
  public UUIComp_DrawImage MarkerImageComponent;
  public FUIDataStoreBinding DataSource = new();
  public UUIComp_DrawStringSlider CaptionRenderComponent;
  public FUIRangeData SliderValue = new();
  public bool bRenderCaption;
  public EUIOrientation SliderOrientation;
  public FUIScreenValue_Extent BarSize = new();
  public FUIScreenValue_Extent MarkerHeight = new();
  public FUIScreenValue_Extent MarkerWidth = new();
  public FName IncrementCue;
  public FName DecrementCue;
}

public class UUISoundTheme : UObject
{
  public class FSoundEventMapping
  {
    public FName SoundEventName;
    public USoundCue SoundToPlay;
  }

  public List<FSoundEventMapping> SoundEventBindings;
}

public class UUIState : UUIRoot
{
  public FPointer VfTable_IUIEventContainer = new();
  public UUIStateSequence StateSequence;
  public List<FInputKeyAction> StateInputActions;
  public List<FInputKeyAction> DisabledInputActions;
  public FName MouseCursorName;
  public byte PlayerIndexMask;
  public byte StackPriority;
}

public class UUIState_Active : UUIState
{
}

public class UUIState_Disabled : UUIState
{
}

public class UUIState_Enabled : UUIState
{
}

public class UUIState_Focused : UUIState
{
}

public class UUIState_Pressed : UUIState
{
}

public class UUIState_TargetedTab : UUIState
{
}

public class UUIStateSequence : UUISequence
{
}

public class UUIStringRenderer : UInterface
{
}

public partial class UUIStyle : UUIRoot
{
  public FSTYLE_ID StyleID = new();
  public FName StyleTag;
  public string StyleName;
  public string StyleGroupName;
  public UClass StyleDataClass;
  public Dictionary<UUIState, int> StateDataMap;
}

public class UUIStyle_Data : UUIRoot
{
  public string UIEditorControlClass;
  public FLinearColor StyleColor = new();
  public float[] StylePadding = new float[2];
  public bool bEnabled;
  public bool bDirty;
  public FScriptDelegate __MatchesStyleData__Delegate;
}

public class UUIStyle_Combo : UUIStyle_Data
{
  public class FStyleDataReference
  {
    public UUIStyle OwnerStyle;
    public UUIRoot.FSTYLE_ID SourceStyleID = new();
    public UUIStyle SourceStyle;
    public UUIState SourceState;
    public UUIStyle_Data CustomStyleData;
  }

  public FStyleDataReference ImageStyle = new();
  public FStyleDataReference TextStyle = new();
}

public class UUIStyle_Image : UUIStyle_Data
{
  public USurface DefaultImage;
  public FTextureCoordinates Coordinates = new();
  public FUIImageAdjustmentData[] AdjustmentType = new FUIImageAdjustmentData[2];
}

public class UUIStyle_Text : UUIStyle_Data
{
  public UFont StyleFont;
  public FUITextAttributes Attributes = new();
  public EUIAlignment[] Alignment = new EUIAlignment[2];
  public ETextClipMode ClipMode;
  public EUIAlignment ClipAlignment;
  public FTextAutoScaleValue AutoScaling = new();
  public FVector2D Scale = new();
  public FVector2D SpacingAdjust = new();
}

public class UUIStyleResolver : UInterface
{
}

public class UUITabButton : UUILabelButton
{
  public UUITabPage TabPage;
  public FScriptDelegate __IsActivationAllowed__Delegate;
}

public class UUITabControl : UUIObject
{
  public List<UUITabPage> Pages;
  public UUITabPage ActivePage;
  public UUITabPage PendingPage;
  public EUIWidgetFace TabDockFace;
  public EUITabAutosizeType TabSizeMode;
  public FUIScreenValue_Extent TabButtonSize = new();
  public FUIScreenValue_Extent[] TabButtonPadding = new FUIScreenValue_Extent[2];
  public FUIStyleReference TabButtonBackgroundStyle = new();
  public FUIStyleReference TabButtonCaptionStyle = new();
  public bool bAllowPagePreviews;
  public bool bUpdateLayout;
  public FName ActivateTabCue;
  public FScriptDelegate __OnPageActivated__Delegate;
  public FScriptDelegate __OnPageInserted__Delegate;
  public FScriptDelegate __OnPageRemoved__Delegate;
}

public class UUITabPage : UUIContainer
{
  public FPointer VfTable_IUIDataStoreSubscriber = new();
  public UClass ButtonClass;
  public UUITabButton TabButton;
  public FUIDataStoreBinding ButtonCaption = new();
  public FUIDataStoreBinding ButtonToolTip = new();
  public FUIDataStoreBinding PageDescription = new();
}

public class UUITickableObject : UInterface
{
}

public class UUITickableObjectProxy : UUIRoot
{
  public FPointer VfTable_IUITickableObject = new();
  public FScriptDelegate __OnScriptTick__Delegate;
}

public class UUIToggleButton : UUILabelButton
{
  public FUIDataStoreBinding ValueDataSource = new();
  public bool bIsChecked;
  public UUIComp_DrawString CheckedStringRenderComponent;
  public UUIComp_DrawImage CheckedBackgroundImageComponent;
}

public class UUIWeaponSummary : UUIResourceDataProvider
{
  public string ClassPathName;
  public string FriendlyName;
  public string WeaponDescription;
  public bool bIsDisabled;
}

public class AVolumePathNode : APathNode
{
  public float StartingRadius;
  public float StartingHeight;
}

public class AVolumeTimer : AInfo
{
  public APhysicsVolume V;
}

public class UWallTransReachSpec : UForcedReachSpec
{
}

public class AWaterVolume : APhysicsVolume
{
  public USoundCue EntrySound;
  public UClass EntryActor;
  public USoundCue ExitSound;
  public UClass ExitActor;
}

public class UWaveFormBase : UObject
{
  public UForceFeedbackWaveform TheWaveForm;
}

public class AWeapon : AInventory
{
  public byte CurrentFireMode;
  public List<FName> FiringStatesArray;
  public List<EWeaponFireType> WeaponFireTypes;
  public List<UClass> WeaponProjectiles;
  public List<float> FireInterval;
  public List<float> Spread;
  public List<float> InstantHitDamage;
  public List<float> InstantHitMomentum;
  public List<UClass> InstantHitDamageTypes;
  public float EquipTime;
  public float PutDownTime;
  public FVector FireOffset = new();
  public bool bWeaponPutDown;
  public bool bCanThrow;
  public bool bWasOptionalSet;
  public bool bWasDoNotActivate;
  public bool bInstantHit;
  public bool bMeleeWeapon;
  public float WeaponRange;
  public UMeshComponent Mesh;
  public float DefaultAnimSpeed;
  public float Priority;
  public AAIController AIController;
  public List<byte> ShouldFireOnRelease;
  public float AIRating;
  public float CachedMaxRange;
}

public class UWindDirectionalSourceComponent : UActorComponent
{
  public FPointer SceneProxy = new();
  public float Strength;
  public float Phase;
  public float Frequency;
  public float Speed;
}

public class AWindDirectionalSource : AInfo
{
  public UWindDirectionalSourceComponent Component;
}

public class UWindPointSourceComponent : UWindDirectionalSourceComponent
{
  public UDrawSphereComponent PreviewRadiusComponent;
  public float Radius;
}

public class AWindPointSource : AInfo
{
  public UWindPointSourceComponent Component;
}

public class UZoneMeshComponent : UPrimitiveComponent
{
  public UObject Model;
  public FMap_Mirror ModelZoneElement = new();
}

public class UClient : UObject
{
}

public partial class UModel : UObject
{
  public class FBspNode
  {
    public int ComponentElementIndex;
    public ushort ComponentIndex;
    public ushort ComponentNodeIndex;
    public int iBackOrChild;
    public int iCollisionBound;
    public int iFront;
    public int[] iLeaf = new int[2];
    public int iPlane;
    public int iSurf;
    public int iVertexIndex;
    public int iVertPool;
    public byte[] iZone = new byte[2];
    public byte NodeFlags;
    public byte NumVertices;
    public UObject.FPlane Plane = new();
  }

  public class FVert
  {
    public UObject.FVector2D BackfaceShadowTexCoord = new();
    public int iSide;
    public int pVertex;
    public UObject.FVector2D ShadowTexCoord = new();
  }

  public class FBspSurf
  {
    public ABrush Actor;
    public bool bHiddenEdLevel;
    public bool bHiddenEdTemporary;
    public int iBrushPoly;
    public int iLightmassIndex;
    public ULightComponent.FLightingChannelContainer LightingChannels = new();
    public UMaterialInterface Material;
    public int pBase;
    public UObject.FPlane Plane = new();
    public uint PolyFlags;
    public float ShadowMapScale;
    public int vNormal;
    public int vTextureU;
    public int vTextureV;
  }

  public class FLeaf
  {
    public int iZone;
  }

  public class FModelVertex
  {
    public UObject.FVector Position = new();
    public UObject.FVector2D ShadowTexCoord = new();
    public UObject.FPackedNormal TangentX = new();
    public UObject.FPackedNormal TangentZ = new();
    public UObject.FVector2D TexCoord = new();
  }

  public class FZoneProperties
  {
    public ulong Connectivity = new();
    public float LastRenderTime;
    public ulong Visibility = new();
    public AZoneInfo ZoneActor;
  }

  public class FTwoVector4DArrays
  {
    public List<UObject.FVector4> First;
    public List<UObject.FVector4> Second;
  }

  public class FBoxAndThenSome
  {
    public UObject.FBox Box = new();
    public int[] Values = new int[10];
  }

  public FBoxSphereBounds Bounds = new();
  public List<int> LeafHulls;
  public List<FLeaf> Leaves;
  public FGuid LightingGuid = new();
  public List<UEngineTypes.FLightmassPrimitiveSettings> LightmassSettings;
  public bool Linked;
  public List<FBspNode> Nodes;
  public int NumSharedSides;
  public uint NumVertices;
  public int NumZones;
  public List<FVector> Points;
  public UPolys Polys;
  public List<int> PortalNodes;
  public bool RootOutside;
  public List<FBspSurf> Surfs;
  public UObject SurfsOwner;
  public List<List<FVector>> unknownA4C;
  public List<List<FVector>> unknownA58;
  public List<List<FVector>> unknownA64;
  public List<FBoxSphereBounds> unknownA70;
  public List<uint> unknownA7C;
  public List<uint> unknownA88;
  public List<FTwoVector4DArrays> unknownA94;
  public List<FBoxAndThenSome> unknownAA0;
  public List<byte> unknownAAC;
  public uint unknownAB8;
  public List<List<FVector>> unknownABC;
  public List<List<FVector2D>> unknownAC8;
  public List<uint> unknownAD4;
  public List<FVector> Vectors;
  public List<FModelVertex> VertexBuffer;
  public List<FVert> Verts;
  public FZoneProperties[] Zones = new FZoneProperties[64];
}

public partial class UPolys : UObject
{
  public class FPoly
  {
    public ABrush Actor;
    public UObject.FVector Base = new();
    public int iBrushPoly;
    public int iLink;
    public FName ItemName;
    public uint LightingChannels;
    public UEngineTypes.FLightmassPrimitiveSettings LightmassSettings = new();
    public UMaterialInterface Material;
    public UObject.FVector Normal = new();
    public uint PolyFlags;
    public FName RulesetVariation;
    public float ShadowMapScale;
    public uint SmoothingMask;
    public UObject.FVector TextureU = new();
    public UObject.FVector TextureV = new();
    public List<UObject.FVector> Vertices;
  }

  public List<FPoly> Element;
}

public partial class UShadowMap1D : UObject
{
  public FGuid LightGuid = new();
  public List<float> Samples;
}

public partial class ULevelBase : UObject
{
  public List<AActor> Actors;
  public UObject ActorsOwner;
  public FURL URL = new();
}

public partial class ULevel : ULevelBase
{
  public class FStreamableTextureInstance
  {
    public UObject.FSphere BoundingSphere = new();
    public float TexelFactor;
  }

  public class FCachedPhysSMData
  {
    public int CachedDataIndex;
    public UObject.FVector Scale3D = new();
  }

  public class FCachedPerTriPhysSMData
  {
    public int CachedDataIndex;
    public UObject.FVector Scale3D = new();
  }

  public partial class FCoverIndexPair : ISerialisable
  {
    public uint ActorRefItem;
    public byte SlotIdx;
  }

  public class FVolumeLightingSample
  {
    public UObject.FColor AmbientRadiance = new();
    public byte bShadowedFromDominantLights;
    public byte EnvironmentDirectionPhi;
    public byte EnvironmentDirectionTheta;
    public UObject.FColor EnvironmentRadiance = new();
    public byte IndirectDirectionPhi;
    public byte IndirectDirectionTheta;
    public UObject.FColor IndirectRadiance = new();
    public UObject.FVector Position = new();
    public float Radius;
  }

  public class FPrecomputedLightVolume
  {
    public bool bInitialized;
    public UObject.FBox Bounds = new();
    public int NumSamples;
    public List<ULevel.FVolumeLightingSample> Samples;
  }

  public List<byte> ApexSDKCachedData;
  public List<byte> CachedPhysBSPData;
  public int CachedPhysBSPDataVersion;
  public URB_BodySetup.FKCachedConvexData CachedPhysConvexBSPData = new();
  public int CachedPhysConvexBSPVersion;
  public Dictionary<UStaticMesh, FCachedPerTriPhysSMData> CachedPhysPerTriSMDataMap;
  public List<URB_BodySetup.FKCachedPerTriData> CachedPhysPerTriSMDataStore;
  public Dictionary<UStaticMesh, FCachedPhysSMData> CachedPhysSMDataMap;
  public List<URB_BodySetup.FKCachedConvexData> CachedPhysSMDataStore;
  public int CachedPhysSMDataVersion;
  public List<FCoverIndexPair> CoverIndexPairs;
  public List<ACoverLink> CoverLinkRefs;
  public ACoverLink CoverListEnd;
  public ACoverLink CoverListStart;
  public List<AActor> CrossLevelActors;
  public List<FGuidPair> CrossLevelCoverGuidRefs;
  public UDrawBSPTreeComponent DrawBSPTreeComponent;
  public Dictionary<UTexture2D, bool> ForceStreamTextures;
  public List<USequence> GameSequences;
  public float LightmapTotalSize;
  public UModel Model;
  public List<UModelComponent> ModelComponents;
  public ANavigationPoint NavListEnd;
  public ANavigationPoint NavListStart;
  public FPrecomputedLightVolume PrecomputedLightVolume = new();
  public APylon PylonListEnd;
  public APylon PylonListStart;
  public float ShadowmapTotalSize;
  public Dictionary<UTexture2D, List<FStreamableTextureInstance>> TextureToInstancesMap;
}

public partial class UPendingLevel : ULevelBase
{
}

public partial class UWorld : UObject
{
  public class FLevelViewportInfo
  {
    public float CamOrthoZoom;
    public UObject.FVector CamPosition = new();
    public UObject.FRotator CamRotation = new();
  }

  public FLevelViewportInfo[] EditorViews = new FLevelViewportInfo[4];
  public List<UObject> ExtraReferencedObjects;
  public UFaceFXAnimSet PersistentFaceFXAnimSet;
  public ULevel PersistentLevel;
  public USaveGameSummary SaveGameSummary;
}

public partial class UNetConnection : UPlayer
{
}

public class UChildConnection : UNetConnection
{
}

public partial class ULightMapTexture2D : UTexture2D
{
  public uint LightmapFlags;
}

public partial class UShaderCache : UObject
{
  public class FIndividualCompressedShaderInfo
  {
    public ushort ChunkIndex;
    public ushort UncompressedCodeLength;
    public int UncompressedCodeOffset;
  }

  public class FCompressedShaderCodeChunk
  {
    public List<byte> CompressedCode;
    public int UncompressedSize;
  }

  public class FTypeSpecificCompressedShaderCode
  {
    public List<UShaderCache.FCompressedShaderCodeChunk> CodeChunks;
    public Dictionary<UObject.FGuid, UShaderCache.FIndividualCompressedShaderInfo> CompressedShaderInfos;
  }

  public class FCompressedShaderCodeCache
  {
    public Dictionary<FName, UShaderCache.FTypeSpecificCompressedShaderCode> ShaderTypeCompressedShaderCode;
  }

  public class FShaderKey
  {
    public List<byte> Code;
    public uint ParameterMapCRC;
  }

  public class FShaderTarget
  {
    public byte Frequency;
    public byte Platform;
  }

  public class FShaderParameter
  {
    public ushort BaseIndex;
    public ushort BufferIndex;
    public ushort NumBytes;
  }

  public class FUniformShaderParameter
  {
    public int Index;
    public UShaderCache.FShaderParameter ShaderParameter = new();
    public byte Type;
  }

  public class FShaderResourceParameter
  {
    public ushort BaseIndex;
    public ushort NumResources;
    public ushort SamplerIndex;
  }

  public class FUniformShaderResourceParameter
  {
    public int Index;
    public UShaderCache.FShaderResourceParameter ShaderParameter = new();
    public byte Type;
  }

  public class FDOFShaderParameters
  {
    public UShaderCache.FShaderParameter PackedParameters0 = new();
    public UShaderCache.FShaderParameter PackedParameters1 = new();
  }

  public class FSceneTextureShaderParameters
  {
    public UShaderCache.FShaderResourceParameter NvStereoFixTextureParameter = new();
    public UShaderCache.FShaderResourceParameter SceneColorTextureParameter = new();
    public UShaderCache.FShaderParameter SceneDepthCalcParameter = new();
    public UShaderCache.FShaderResourceParameter SceneDepthTextureParameter = new();
    public UShaderCache.FShaderParameter ScreenPositionScaleBiasParameter = new();
  }

  public class FMaterialShaderParameters
  {
    public UShaderCache.FShaderParameter CameraWorldPosParameter = new();
    public UShaderCache.FShaderParameter FoliageImpParameter = new();
    public UShaderCache.FShaderParameter FoliageNormalizedRotationAxisAndAngleParameter = new();
    public UShaderCache.FShaderParameter InvViewProjectionParameter = new();
    public UShaderCache.FShaderParameter LocalToWorldParameter = new();
    public UShaderCache.FShaderParameter ObjectOrientationParameter = new();
    public UShaderCache.FShaderParameter ObjectWorldPositionAndRadiusParameter = new();
    public UShaderCache.FShaderParameter OcclusionPercentageParameter = new();
    public UShaderCache.FShaderParameter ViewProjectionParameter = new();
    public UShaderCache.FShaderParameter ViewToWorldParameter = new();
    public UShaderCache.FShaderParameter WindDirectionAndSpeedParameter = new();
    public UShaderCache.FShaderParameter WorldToLocalParameter = new();
    public UShaderCache.FShaderParameter WorldToViewParameter = new();
  }

  public class FMaterialPixelShaderParameters : FMaterialShaderParameters
  {
    public UShaderCache.FShaderResourceParameter BeckmannTextureParameter = new();
    public UShaderCache.FShaderParameter bEnableScreenDoorFadeParameter = new();
    public UShaderCache.FShaderParameter DecalFarPlaneDistanceParameter = new();
    public UShaderCache.FShaderParameter MatInverseGammaParameter = new();
    public UShaderCache.FShaderParameter ObjectMacroUVScalesParameter = new();
    public UShaderCache.FShaderParameter ObjectNDCPositionParameter = new();
    public UShaderCache.FShaderParameter ObjectPostProjectionPositionParameter = new();
    public UShaderCache.FSceneTextureShaderParameters SceneTextureParameters = new();
    public UShaderCache.FShaderParameter ScreenDoorFadeSettings2Parameter = new();
    public UShaderCache.FShaderParameter ScreenDoorFadeSettingsParameter = new();
    public UShaderCache.FShaderResourceParameter ScreenDoorNoiseTextureParameter = new();
    public UShaderCache.FShaderParameter TwoSidedSignParameter = new();
    public List<UShaderCache.FUniformShaderResourceParameter> Uniform2DShaderResourceParameters;
    public List<UShaderCache.FUniformShaderParameter> UniformPixelScalarParameters;
  }

  public class FMaterialVertexShaderParameters : FMaterialShaderParameters
  {
    public List<UShaderCache.FUniformShaderParameter> UniformPixelScalarParameters;
  }

  public class FVertexFactoryParameters
  {
    public List<FName> ParameterOrder;
    public Dictionary<FName, UShaderCache.FShaderParameter> ShaderParameters;
    public Dictionary<FName, UShaderCache.FShaderResourceParameter> ShaderResourceParameters;
    public FName Type;
  }

  public class FShader
  {
    public UShaderCache.FDOFShaderParameters DOFParameters = new();
    public UObject.FGuid Id = new();
    public UShaderCache.FShaderKey Key = new();
    public UShaderCache.FMaterialPixelShaderParameters MaterialPixelParameters = new();
    public UShaderCache.FMaterialVertexShaderParameters MaterialVertexParameters = new();
    public uint NumInstructions;
    public List<FName> ParameterOrder;
    public UShaderCache.FSceneTextureShaderParameters SceneTextureParameters = new();
    public Dictionary<FName, UShaderCache.FShaderParameter> ShaderParameters;
    public Dictionary<FName, UShaderCache.FShaderResourceParameter> ShaderResourceParameters;
    public UShaderCache.FShaderTarget Target = new();
    public FName Type;
    public UShaderCache.FVertexFactoryParameters VertexFactoryParameters = new();
  }

  public class FShaderRef
  {
    public UObject.FGuid Id = new();
    public FName Type;
  }

  public class FShaderMap
  {
    public Dictionary<FName, UShaderCache.FShaderRef> Shaders;
  }

  public class FMeshMaterialShaderMap : FShaderMap
  {
    public FName VertexFactoryType;
  }

  public class FMaterialShaderMap : FShaderMap
  {
    public string FriendlyName;
    public UObject.FGuid MaterialId = new();
    public List<UShaderCache.FMeshMaterialShaderMap> MeshShaderMaps;
    public int Platform;
    public UMaterialInterface.FStaticParameterSet StaticParameters = new();
    public UMaterialInterface.FUniformExpressionSet UniformExpressionSet = new();
  }

  public FCompressedShaderCodeCache CompressedCache = new();
  public Dictionary<UMaterialInterface.FStaticParameterSet, FMaterialShaderMap> MaterialShaderMap;
  public byte Platform;
  public Dictionary<FGuid, FShader> Shaders;
  public Dictionary<FName, uint> ShaderVersions;
  public Dictionary<FName, uint> VertexFactoryVersions;
}

public partial class UStaticMesh : UObject
{
  public class FStaticMeshVertex
  {
    public UObject.FColor Color = new();
    public ushort FragmentIndex;
    public UObject.FVector Position = new();
    public UObject.FPackedNormal TangentX = new();
    public UObject.FPackedNormal TangentY = new();
    public UObject.FPackedNormal TangentZ = new();
    public UObject.FVector2D[] UVs = new UObject.FVector2D[4];
  }

  public partial class FFragmentRange : ISerialisable
  {
    public int BaseIndex;
    public int NumPrimitives;
  }

  public partial class FStaticMeshElement : ISerialisable
  {
    public bool bEnableShadowCasting;
    public bool EnableCollision;
    public uint FirstIndex;
    public List<UStaticMesh.FFragmentRange> Fragments;
    public UMaterialInterface Material;
    public int MaterialIndex;
    public uint MaxVertexIndex;
    public uint MinVertexIndex;
    public string Name;
    public uint NumTriangles;
    public bool OldEnableCollision;
  }

  public partial class FStaticMeshTriangleBulkData : FUntypedBulkData_Mirror
  {
  }

  public partial class FStaticMeshVertexBuffer : ISerialisable
  {
    public bool bUseFullPrecisionUVs;
    public uint NumTexCoords;
    public uint NumVertices;
    public uint Stride;
    public List<byte> UntypedData;
  }

  public partial class FPositionVertexBuffer : ISerialisable
  {
    public List<UObject.FVector> Data;
    public uint NumVertices;
    public uint Stride;
  }

  public partial class FColorVertexBuffer : ISerialisable
  {
    public List<UObject.FColor> Data;
    public uint NumVertices;
    public uint Stride;
  }

  public class FStaticMeshRenderData
  {
    public UStaticMesh.FColorVertexBuffer ColorVertexBuffer = new();
    public List<UStaticMesh.FStaticMeshElement> Elements;
    public List<ushort> IndexBuffer;
    public uint NumVertices;
    public UStaticMesh.FPositionVertexBuffer PositionVertexBuffer = new();
    public UStaticMesh.FStaticMeshTriangleBulkData RawTriangles = new();
    public UStaticMesh.FStaticMeshVertexBuffer VertexBuffer = new();
    public List<ushort> WireframeIndexBuffer;
  }

  public class FkDOP
  {
    public float[] Max = new float[3];
    public float[] Min = new float[3];
  }

  public class FkDOPNode
  {
    public bool bIsLeaf;
    public UStaticMesh.FkDOP BoundingVolume = new();
    public ushort LeftNodeOrNumTriangles;
    public ushort RightNodeOrStartIndex;
  }

  public class FkDOPCollisionTriangle
  {
    public ushort MaterialIndex;
    public ushort v1;
    public ushort v2;
    public ushort v3;
  }

  public class FkDOPTree
  {
    public List<UStaticMesh.FkDOPNode> Nodes;
    public List<UStaticMesh.FkDOPCollisionTriangle> Triangles;
  }

  public bool bCanBecomeDynamic;
  public URB_BodySetup BodySetup;
  public FBoxSphereBounds Bounds = new();
  public bool bPartitionForEdgeGeometry;
  public bool bUsedForInstancing;
  public bool bUseMaximumStreamingTexelRatio;
  public uint HighResSourceMeshCRC;
  public string HighResSourceMeshName;
  public int InternalVersion;
  public FkDOPTree kDOPTree = new();
  public FGuid LightingGuid = new();
  public int LightMapCoordinateIndex;
  public int LightMapResolution;
  public float LODDistanceRatio;
  public uint LODInfoCount;
  public float LODMaxRange;
  public List<FStaticMeshRenderData> LODModels;
  public List<FVector> PhysMeshScale3D;
  public string SourceFilePath;
  public string SourceFileTimestamp;
  public float StreamingDistanceMultiplier;
  public FRotator ThumbnailAngle = new();
  public float ThumbnailDistance;
  public bool UseFullPrecisionUVs;
  public bool UseSimpleBoxCollision;
  public bool UseSimpleLineCollision;
  public bool UseSimpleRigidBodyCollision;
}

public partial class UFracturedStaticMesh : UStaticMesh
{
  public bool bAlwaysBreakOffIsolatedIslands;
  public bool bCompositeChunksExplodeOnImpact;
  public bool bFixIsolatedChunks;
  public bool bSliceUsingCoreCollision;
  public bool bSpawnPhysicsChunks;
  public bool bUniformFragmentHealth;
  public float ChanceOfPhysicsChunk;
  public float ChunkAngVel;
  public float ChunkLinHorizontalScale;
  public float ChunkLinVel;
  public float CoreMeshScale;
  public UMaterialInterface DynamicOutsideMaterial;
  public float ExplosionChanceOfPhysicsChunk;
  public float ExplosionPhysicsChunkScaleMax;
  public float ExplosionPhysicsChunkScaleMin;
  public float ExplosionVelScale;
  public UParticleSystem FragmentDestroyEffect;
  public List<UParticleSystem> FragmentDestroyEffects;
  public float FragmentDestroyEffectScale;
  public float FragmentHealthScale;
  public float FragmentMaxHealth;
  public float FragmentMinHealth;
  public UMaterialInterface LoseChunkOutsideMaterial;
  public float MinConnectionSupportArea;
  public float NormalPhysicsChunkScaleMax;
  public float NormalPhysicsChunkScaleMin;
  public int OutsideMaterialIndex;
  public UStaticMesh SourceCoreMesh;
}

public partial class UGuidCache : UObject
{
  public Dictionary<FName, FGuid> PackageGuidMap;
}

public partial class UPersistentCookerData : UObject
{
  public class FCookedBulkDataInfo
  {
    public uint SavedBulkDataFlags;
    public int SavedBulkDataOffsetInFile;
    public int SavedBulkDataSizeOnDisk;
    public int SavedElementCount;
    public FName TextureFileCacheName;
  }

  public class FCookedTextureFileCacheInfo
  {
    public double LastSaved = new();
    public UObject.FGuid TextureFileCacheGuid = new();
    public FName TextureFileCacheName;
  }

  public class FCookedTextureUsageInfo
  {
    public int DuplicatedMipSize;
    public byte Format;
    public byte LODGroup;
    public List<string> PackageNames;
    public int SizeX;
    public int SizeY;
    public int StoredOnceMipSize;
  }

  public List<string> ChildCookErrors;
  public List<string> ChildCookWarnings;
  public Dictionary<string, FCookedBulkDataInfo> CookedBulkDataInfoMap;
  public Dictionary<string, FCookedTextureFileCacheInfo> CookedTextureFileCacheInfoMap;
  public Dictionary<string, int> FilenameToCookedVersion;
  public Dictionary<string, double> FilenameToTimeMap;
  public ulong TextureFileCacheWaste = new();
  public Dictionary<string, FCookedTextureUsageInfo> TextureUsageInfos;
  public ulong Unknown = new();
}

public partial class UNavigationMeshBase : UObject
{
  public class FPolyReference
  {
    public AActor.FActorReference OwningPylon = new();
    public int PolyId;
  }

  public class FNavMeshEdgeBase
  {
    public float DropHeight;
    public UObject.FVector EdgeCenter = new();
    public UObject.FVector EdgeExtent = new();
    public byte EdgeGroupID;
    public byte EdgeType;
    public float EffectiveEdgeLength;
    public UEngineTypes.FBasedPosition MoveDest = new();
    public int MoveDir;
    public ushort ObstaclePolyID;
    public ushort OtherPylonVert0;
    public ushort OtherPylonVert1;
    public ushort Poly0;
    public UNavigationMeshBase.FPolyReference Poly0Ref = new();
    public ushort Poly1;
    public UNavigationMeshBase.FPolyReference Poly1Ref = new();
    public AActor.FActorReference RelActor = new();
    public int RelItem;
    public ushort Vert0;
    public ushort Vert1;
  }

  public partial class FMeshVertex : FVector
  {
    public List<ushort> PolyIndices;
  }

  public class FEdgeStorageDatum
  {
    public FName ClassName;
    public uint DataPtrOffset;
    public ushort DataSize;
  }

  public class FNavMeshPolyBase
  {
    public UObject.FBox BoxBounds = new();
    public ushort Item;
    public UObject.FVector PolyCenter = new();
    public List<ACoverLink.FCoverReference> PolyCover;
    public List<ushort> PolyEdges;
    public float PolyHeight;
    public UObject.FVector PolyNormal = new();
    public List<ushort> PolyVerts;
  }

  public class FBorderEdgeInfo
  {
    public ushort Poly;
    public ushort Vert0;
    public ushort Vert1;
  }

  public List<FBorderEdgeInfo> BorderEdgeSegments;
  public FBox BoxBounds = new();
  public List<FNavMeshEdgeBase> Edges;
  public List<FEdgeStorageDatum> EdgeStorageData;
  public FMatrix LocalToWorld = new();
  public uint NavMeshVersionNum;
  public List<FNavMeshPolyBase> Polys;
  public uint VersionAtGenerationTime;
  public List<FMeshVertex> Verts;
  public FMatrix WorldToLocal = new();
}

