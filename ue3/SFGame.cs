/*===========================================================================
 *  This file was automatically generated. DO NOT modify!
===========================================================================*/
namespace ue3;

public enum EHackType
{
  EHT_WALLHACK_HARDWARE_OCCLUSION_QUERY,
  EHT_GAMEPLAY_MOVEMENTPACKET_SUPPRESS,
  EHT_GAMEPLAY_WEAPON_INFINITYPROJECTILE,
  EHT_GAMEPLAY_PAUSE,
  EHT_GAMEPLAY_WEAPON_INFINITYMAGAZINE_INVALID_AMMO,
  EHT_GAMEPLAY_WEAPON_INFINITYMAGAZINE_INVALID_MAX_AMMO,
  EHT_GAMEPLAY_INVALID_ITEM,
  EHT_GAMEPLAY_INVALID_WEAPON,
  EHT_GAMEPLAY_INVALID_RECOIL,
  EHT_GAMEPLAY_INVALID_DAMAGE,
  EHT_GAMEPLAY_INVALID_ATTACKER_POSITION,
  EHT_WALLHACK_HARDWARE_OCCLUSION_QUERY_PLAYER,
  EHT_GAMEPLAY_INVALID_PACKET,
  EHT_GAMEPLAY_CHEAT_INGAMESTORE_ITEM,
  EHT_GAMEPLAY_INVALID_PHYSICALMATERIAL,
  EHT_GAMEPLAY_UNACCEPTABLE_SPECTATOR,
  EHT_MAX,
}

public enum EModeStatType
{
  EModeStatType_None,
  EModeStatType_Attack,
  EModeStatType_Defence,
  EModeStatType_Vitality,
  EModeStatType_Speed,
  EModeStatType_MAX,
}

public enum EMessengerGroupType
{
  EMessengerGroup_Clan,
  EMessengerGroup_Friends,
  EMessengerGroup_MAX,
}

public enum ENaviImageType
{
  ENaviImageType_BasicType,
  ENaviImageType_ClanLeagueChannelType,
  ENaviImageType_ClanLeaguePageType,
  ENaviImageType_MAX,
}

public enum EHUDWidgetHideType
{
  EHWH_Blind,
  EHWH_Stun,
  EHWH_Dead,
  EHWH_NotHuman,
  EHWH_NotCrustalyn,
  EHWH_MAX,
}

public enum ETwitchTVMsg
{
  ETwitchTVMsg_InitFail,
  ETwitchTVMsg_InvalidLogin,
  ETwitchTVMsg_AuthFail,
  ETwitchTVMsg_LoginFail,
  ETwitchTVMsg_FindIngestServerFail,
  ETwitchTVMsg_LoginOKMessage,
  ETwitchTVMsg_BroadcastStartFail,
  ETwitchTVMsg_SetTitleFail,
  ETwitchTVMsg_StopFail,
  ETwitchTVMsg_Description,
  ETwitchTVMsg_StartedMessage,
  ETwitchTVMsg_StopMessage,
  ETwitchTVMsg_NoBroadcastTitleMessage,
  ETwitchTVMsg_WaitMessage,
  ETwitchTVMsg_MAX,
}

public enum ETwtichTVStreamState
{
  TwtichTV_Uninitialized,
  TwtichTV_Initialized,
  TwtichTV_Authenticating,
  TwtichTV_Authenticated,
  TwtichTV_LoggingIn,
  TwtichTV_LoggedIn,
  TwtichTV_FindingIngestServer,
  TwtichTV_FoundIngestServer,
  TwtichTV_ReadyToStream,
  TwtichTV_Streaming,
  TwtichTV_Paused,
  TwtichTV_MAX,
}

public enum ESmokeEffectType
{
  ESmokeEffectType_Spread,
  ESmokeEffectType_Explosion,
  ESmokeEffectType_MAX,
}

public enum ESmokeEffectColor
{
  SmokeEffect_Spread_R,
  SmokeEffect_Spread_G,
  SmokeEffect_Spread_B,
  SmokeEffect_Explosion_R,
  SmokeEffect_Explosion_G,
  SmokeEffect_Explosion_B,
  SmokeEffect_MAX,
}

public enum EConvoyanceItemStatus
{
  EConvoyanceItem_OnTaken,
  EConvoyanceItem_OnDropped,
  EConvoyanceItem_OnReturned,
  EConvoyanceItem_OnCaptured,
  EConvoyanceItem_MAX,
}

public enum EConvoyanceMoveStatus
{
  EConvoyanceMove_OnMove,
  EConvoyanceMove_OnStop,
  EConvoyanceMove_MAX,
}

public enum EConvoyanceNotiRemainGold
{
  EConvoyanceNotiRemainGold_OnRemainThreeQuater,
  EConvoyanceNotiRemainGold_OnRemainHalf,
  EConvoyanceNotiRemainGold_OnRemainQuater,
  EConvoyanceNotiRemainGold_OnRemainZero,
  EConvoyanceNotiRemainGold_MAX,
}

public enum ETriggerType
{
  ETriggerType_Normal,
  ETriggerType_ConvoyanceSeizure,
  ETriggerType_ConvoyanceStore,
  ETriggerType_MAX,
}

public enum EConvoyancePathGroup
{
  EConvoyancePoint_A,
  EConvoyancePoint_B,
  EConvoyancePoint_C,
  EConvoyancePoint_MAX,
}

public enum EResultBoostType
{
  EResultBoost_PCRoom,
  EResultBoost_RealTimeEvent,
  EResultBoost_FunctionalItem,
  EResultBoost_Channel,
  EResultBoost_PMC,
  EResultBoost_VIP,
  EResultBoost_MonthlyReward,
  EResultBoost_MAX,
}

public enum EHideSeekFeverTime
{
  EHideSeekFeverTime_None,
  EHideSeekFeverTime_CountDown,
  EHideSeekFeverTime_Activate,
  EHideSeekFeverTime_MAX,
}

public enum EDomainType
{
  EDomain_NONE,
  EDomain_Facebook,
  EDomain_AID,
  EDomain_TCG,
  EDomain_Google,
  EDomain_MAX,
}

public enum ERocketJumpState
{
  ERocketJumpState_NONE,
  ERocketJumpState_FillFuel,
  ERocketJumpState_StandBy,
  ERocketJumpState_Jump,
  ERocketJumpState_Boost,
  ERocketJumpState_Hover,
  ERocketJumpState_SuperLanding,
  ERocketJumpState_LowFuel,
  ERocketJumpState_InfiniteFuel,
  ERocketJumpState_MAX,
}

public enum eCBRT
{
  CBRT_DAMAGE,
  CBRT_KILL,
  CBRT_ROUNDEND,
  CBRT_RESPAWN,
  CBRT_MAX,
}

public enum EOBSTACLE_RES
{
  OBSTACLE_SETOK,
  OBSTACLE_HPALREADYFULL,
  OBSTACLE_NEEDMORECOIN,
  OBSTACLE_OUTRANGE,
  OBSTACLE_SETERROR,
  OBSTACLE_MAX,
}

public enum ECameraAnim
{
  ECamAni_NORMALFIRE,
  ECamAni_CHARGEFIRE,
  ECamAni_NORMALHIT,
  ECamAni_CHARGEHIT,
  ECamAni_MAX,
}

public enum ESquadTargetType
{
  ESquadTarget_DEFAULT,
  ESquadTarget_PRIMARYTARGET,
  ESquadTarget_PAWN,
  ESquadTarget_MAX,
}

public enum ELevelOfDifficulty
{
  ELOD_EASY,
  ELOD_NORMAL,
  ELOD_HARD,
  ELOD_VERYHARD,
  ELOD_MAX,
}

public enum EPHYRESLINKTypes
{
  EPRLTypes_Small,
  EPRLTypes_MId,
  EPRLTypes_Big,
  EPRLTypes_MAX,
}

public enum EAITypes
{
  AIType_DEFAULT,
  AIType_Dummy,
  AIType_FlyingBug,
  AIType_WormHoleBug,
  AIType_MeleeBase,
  AIType_Libertine,
  AIType_Crawler,
  AIType_Ripper,
  AIType_Stunner,
  AIType_Tyrant,
  AIType_CloakingRipper,
  AIType_GasStunner,
  AIType_EliteCrawler,
  AIType_NamedCrawler,
  AIType_EliteRipper,
  AIType_NamedRipper,
  AIType_EliteLibertine,
  AIType_NamedLibertine,
  AIType_EliteStunner,
  AIType_NamedStunner,
  AIType_EliteTyrant,
  AIType_NamedTyrant,
  AIType_WarriorCrawler,
  AIType_WarriorRipper,
  AIType_WarriorLibertine,
  AIType_WarriorElderLibertine,
  AIType_WarriorStunner,
  AIType_WarriorTyrant,
  AIType_WarriorBaronTyrant,
  AIType_Turret,
  AIType_AlienController,
  AIType_BossCrawler,
  AIType_LightStunner,
  AIType_RifleMan,
  AIType_WalkSnatcher,
  AIType_ItemCarrier,
  AIType_ConvoyTarget,
  AIType_ZombieWalker,
  AIType_ZombieRunner,
  AIType_ZombieTanker,
  AIType_ZombieInvincible,
  AIType_ZombiePunisher,
  AIType_ZombiePuker,
  AIType_ZombieBoomer,
  AIType_ZombieStrongWalker,
  AIType_ZombieFastRunner,
  AIType_EliteZombieWalker,
  AIType_EliteZombieStrongWalker,
  AIType_EliteZombieRunner,
  AIType_EliteZombieFastRunner,
  AIType_EliteZombieBoomer,
  AIType_EliteZombiePuker,
  AIType_EliteZombieInvincible,
  AIType_EliteZombieTanker,
  AIType_ZombieHideSeekWalker,
  AIType_ZombieHound,
  AIType_ZombieGuard,
  AIType_ZombieLibertine,
  AIType_ZombieSpectre,
  AIType_ZombieRevenant,
  AIType_ZombieHanger,
  AIType_None,
  AIType_MAX,
}

public enum EAIGrade
{
  EAIGrade_None,
  EAIGrade_Mob,
  EAIGrade_Boss,
  EAIGrade_MAX,
}

public enum EAICombatType
{
  EAICombatType_None,
  EAICombatType_Melee,
  EAICombatType_Range,
  EAICombatType_Hide,
  EAICombatType_MAX,
}

public enum EAlienAttackType
{
  EEAlienAttackType_None,
  EEAlienAttackType_Ripper_Claw,
  EEAlienAttackType_Ripper_RecoverHealth,
  EEAlienAttackType_Stunner_Kamikaze,
  EEAlienAttackType_Stunner_Dash,
  EEAlienAttackType_Libertine_Split,
  EEAlienAttackType_Libertine_Adrenalin,
  EEAlienAttackType_MAX,
}

public enum EAlienPlayerDefaultSpawnSlot
{
  EAlienPlayerDefaultSpawnSlot_0,
  EAlienPlayerDefaultSpawnSlot_1,
  EAlienPlayerDefaultSpawnSlot_2,
  EAlienPlayerDefaultSpawnSlot_MAX,
}

public enum EExposureType
{
  ExposureNone,
  ExposureIn,
  ExposureOut,
  ExposureAlways,
  EExposureType_MAX,
}

public enum eDMGEFCTID
{
  DMGEFCTID_Death,
  DMGEFCTID_Weak,
  DMGEFCTID_Normal,
  DMGEFCTID_Strong,
  DMGEFCTID_MAX,
}

public enum eAITARGETTYPE
{
  TIS_NONE,
  TIS_PRIMARYOBJ,
  TIS_OBSTACLES,
  TIS_ENEMYS,
  TIS_Weak,
  TIS_Skillful,
  TIS_Nearst,
  TIS_MAX,
}

public enum EHitType
{
  EHitType_None,
  EHitType_Normal,
  EHitType_FlashBang,
  EHitType_Gas,
  EHitType_MAX,
}

public enum EBodyParts
{
  EBODY_None,
  EBODY_Head,
  EBODY_Chest,
  EBODY_Stomach,
  EBODY_Lower,
  EBODY_Upper,
  EBODY_HeadPoint,
  EBODY_AI_VeryStrong,
  EBODY_AI_Strong,
  EBODY_AI_Normal,
  EBODY_AI_Weak,
  EBODY_ExtraParts,
  EBODY_MAX,
}

public enum EPawnAnimSet
{
  EAnimSet_Death,
  EAnimSet_AIPawn,
  EAnimSet_Cover,
  EAnimSet_BlindCover,
  EAnimSet_Weapon,
  EAnimSet_WeaponProfile,
  EAnimSet_Emotion,
  EAnimSet_Revival,
  EAnimSet_Extra,
  EAnimSet_Extra2,
  EAnimSet_Vehicle,
  EAnimSet_MAX,
}

public enum EFallDirection
{
  FALLDIR_F,
  FALLDIR_B,
  FALLDIR_L,
  FALLDIR_R,
  FALLDIR_MAX,
}

public enum ESkelRotControl
{
  SRCTRL_Spine,
  SRCTRL_Pelvis,
  SRCTRL_MAX,
}

public enum EFaceMorph
{
  MorphFace_Zoom,
  MorphFace_Angry,
  MorphFace_Death,
  MorphFace_Breath,
  MorphFace_MAX,
}

public enum ESpeedDirection
{
  SPD_Forward,
  SPD_Backward,
  SPD_Sideward,
  SPD_BackOblique,
  SPD_None,
  SPD_MAX,
}

public enum EWeaponState
{
  EWS_Off,
  EWS_Idle,
  EWS_Sprint,
  EWS_SprintOff,
  EWS_EquipUp,
  EWS_PutDown,
  EWS_PutDownEx,
  EWS_EquipUpEx,
  EWS_PreFire,
  EWS_EmptyMagazine,
  EWS_Fire1,
  EWS_FireHit1,
  EWS_FireKill1,
  EWS_FireProj1,
  EWS_Fire2,
  EWS_FireHit2,
  EWS_FireKill2,
  EWS_FireProj2,
  EWS_PostFire,
  EWS_ChargeCancel,
  EWS_FlashOnOff,
  EWS_ZoomIn,
  EWS_Zoomed,
  EWS_ZoomOut,
  EWS_PreReload,
  EWS_Reload,
  EWS_PostReload,
  EWS_AccIdle,
  EWS_AccActive,
  EWS_AccDeActive,
  EWS_AccExigencyActive,
  EWS_AccZoomActive,
  EWS_AccReloadActive,
  EWS_AccSprintActive,
  EWS_SubWeaponExtension1,
  EWS_SubWeaponExtension2,
  EWS_SubWeaponExtension3,
  EWS_SubWeaponExtension4,
  EWS_SubWeaponExtension5,
  EWS_SubWeaponExtension6,
  EWS_LAST,
  EWS_MAX,
}

public enum EWEAPON_GROUP
{
  EWEAPON_GROUP_None,
  EWEAPON_GROUP_PRI,
  EWEAPON_GROUP_SEC,
  EWEAPON_GROUP_SPE,
  EWEAPON_GROUP_HG,
  EWEAPON_GROUP_MODE,
  EWEAPON_GROUP_MIS,
  EWEAPON_GROUP_EXG,
  EWEAPON_GROUP_GL,
  EWEAPON_GROUP_MAX,
}

public enum ECUSTOMMODE_WEAPONTYPE
{
  ECUSTOMMODE_WEAPONTYPE_NONE,
  ECUSTOMMODE_WEAPONTYPE_BASIC,
  ECUSTOMMODE_WEAPONTYPE_SNIPER,
  ECUSTOMMODE_WEAPONTYPE_SHOTGUN,
  ECUSTOMMODE_WEAPONTYPE_REVOLVER,
  ECUSTOMMODE_WEAPONTYPE_KNIFE,
  ECUSTOMMODE_WEAPONTYPE_SPECIALWEAPON,
  ECUSTOMMODE_WEAPONTYPE_1VS1BASIC,
  ECUSTOMMODE_WEAPONTYPE_1VS1SPECIALWEAPON,
  ECUSTOMMODE_WEAPONTYPE_1VS1RANDOM,
  ECUSTOMMODE_WEAPONTYPE_MAX,
}

public enum EWEAPON_SLOT
{
  EWEAPON_SLOT_PRIMARY,
  EWEAPON_SLOT_SECONDARY,
  EWEAPON_SLOT_THIRD_1,
  EWEAPON_SLOT_THIRD_2,
  EWEAPON_SLOT_THIRD_3,
  EWEAPON_SLOT_SPECIAL,
  EWEAPON_SLOT_EXIGENCY,
  EWEAPON_SLOT_MODSPECIAL,
  EWEAPON_SLOT_MAX,
}

public enum EWeapAimProfile
{
  EWAP_AR,
  EWAP_SR,
  EWAP_MG,
  EWAP_SMG,
  EWAP_PST,
  EWAP_SG,
  EWAP_HG,
  EWAP_KNIFE,
  EWAP_C4,
  EWAP_NUM,
  EWAP_MAX,
}

public enum EBuffType
{
  EBuffType_None,
  EBuffType_Ripper_Recovery,
  EBuffType_Ripper_Cloaking,
  EBuffType_Stunner_Dash,
  EBuffType_Libertine_Adrenalin,
  EBuffType_RecoverHealth,
  EBuffType_PurchaseAmmo,
  EBuffType_PowerUp,
  EBuffType_DefenceUp,
  EBuffType_AgilityUp,
  EBuffType_LevelUp,
  EBuffType_Recall_Red,
  EBuffType_Recall_Blue,
  EBuffType_Baron,
  EBuffType_Streak_Health,
  EBuffType_Streak_Power,
  EBuffType_Streak_Speed,
  EBuffType_Streak_Weapon,
  EBuffType_MAX,
}

public enum EBuffState
{
  EBuffState_Off,
  EBuffState_On,
  EBuffState_EffectOnly,
  EBuffState_Failed,
  EBuffState_MAX,
}

public enum ETeam
{
  ETEAM_RED,
  ETEAM_BLUE,
  ETEAM_Third,
  ETEAM_Fourth,
  ETEAM_Fifth,
  ETEAM_Sixth,
  ETEAM_Seventh,
  ETEAM_Eighth,
  ETEAM_EVERYONE,
  ETEAM_NONE,
  ETEAM_MAX,
}

public enum ELocationType
{
  LT_Known,
  LT_Exact,
  LT_InterpVisibility,
  LT_MAX,
}

public enum EPerceptionType
{
  PT_Sight,
  PT_Heard,
  PT_HurtBy,
  PT_Force,
  PT_SightPlayer,
  PT_MAX,
}

public enum ECombatZoneType
{
  CZT_Normal,
  CZT_Ambush,
  CZT_MAX,
}

public enum EMoveOverride
{
  EMO_None,
  EMO_Fast,
  EMO_MAX,
}

public enum EAIMoveStyle
{
  EMS_Normal,
  EMS_Slow,
  EMS_Fast,
  EMS_MAX,
}

public enum EHAITYPE
{
  EAIT_RIFLE,
  EAIT_SMG,
  EAIT_SHOTGUN,
  EAIT_MG,
  EAIT_SNIPER,
  EAIT_CIVILIAN,
  EAIT_NOSNIPER,
  EAIT_ALL,
  EAIT_MAX,
}

public enum EBreakableActorFlag
{
  EBreakableActorFlag_InstallBomb,
  EBreakableActorFlag_Opened,
  EBreakableActorFlag_Closed,
  EBreakableActorFlag_MAX,
}

public enum ESFStrongHoldArea
{
  ESFStrongHoldArea_1,
  ESFStrongHoldArea_2,
  ESFStrongHoldArea_3,
  ESFStrongHoldArea_4,
  ESFStrongHoldArea_Any,
  ESFStrongHoldArea_MAX,
}

public enum EGameMode
{
  EGameMode_EntryGame,
  EGameMode_TutorialGame,
  EGameMode_DeathGame,
  EGameMode_TeamDeathGame,
  EGameMode_BlastingGame,
  EGameMode_EscapeGame,
  EGameMode_SeizureGame,
  EGameMode_StrongHoldGame,
  EGameMode_RescueGame,
  EGameMode_ScenarioGame,
  EGameMode_CaptureGame,
  EGameMode_TestGame,
  EGameMode_Observer,
  EGameMode_ThunderRunGame,
  EGameMode_FrontLineGame,
  EGameMode_SnowballFightGame,
  EGameMode_TrainingGame,
  EGameMode_SurvivalGame,
  EGameMode_BeginnerGame,
  EGameMode_HardcoreTeamDeathGame,
  EGameMode_HardcoreEscapeGame,
  EGameMode_HardcoreBlastingGame,
  EGameMode_HardcoreSeizureGame,
  EGameMode_DuelGame,
  EGameMode_CoupleGame,
  EGameMode_BeastGame,
  EGameMode_BeastGame2,
  EGameMode_SniperGame,
  EGameMode_SniperTDMGame,
  EGameMode_ShooterGame,
  EGameMode_GlassGame,
  EGameMode_DefenceGame,
  EGameMode_ShooterCTFGame,
  EGameMode_ShooterDefenceGame,
  EGameMode_WarriorGame,
  EGameMode_ShooterThunderRunGame,
  EGameMode_AITeamDeathGame,
  EGameMode_None,
  EGameMode_GrenadeGame,
  EGameMode_ShotgunGame,
  EGameMode_GlowTDMGame,
  EGameMode_ShotgunTDMGame,
  EGameMode_AISniperTDMGame,
  EGameMode_SpecialWeaponGame,
  EGameMode_RevolverGame,
  EGameMode_RoundTDMGame,
  EGameMode_ConvoyanceGame,
  EGameMode_KnifeGame,
  EGameMode_DeathTestOneGame,
  EGameMode_DeathTestTwoGame,
  EGameMode_TeamTestOneGame,
  EGameMode_TeamTestTwoGame,
  EGameMode_TeamDeathTestOneGame,
  EGameMode_TeamDeathTestTwoGame,
  EGameMode_CTCTeamDeathGame,
  EGameMode_ZombieSurvivalGame,
  EGameMode_ZombieSurvivalGameTwo,
  EGameMode_ZombieHideSeekGame,
  EGameMode_AITeamDeathGameVs16,
  EGameMode_HorrorGame,
  EGameMode_CaptureTheFlagGame,
  EGameMode_BlastingGameSecond,
  EGameMode_OnetoOneGame,
  EGameMode_SeizureGameSpy,
  EGameMode_TeamDeathGameVs16,
  EGameMode_BlastingGameVs16,
  EGameMode_EscapeGameVs16,
  EGameMode_SeizureGameVs16,
  EGameMode_SoloLeagueGame,
  EGameMode_RocketJumpTDMGame,
  EGameMode_RocketJumpBlastingGame,
  EGameMode_RocketJumpSeizureGame,
  EGameMode_RocketJumpCaptureGame,
  EGameMode_ThirdPersonTDMGame,
  EGameMode_ThirdPersonBlastingGame,
  EGameMode_ThirdPersonSeizureGame,
  EGameMode_ThirdPersonEscapeGame,
  EGameMode_AITeamDeathThirdPersonGame,
  EGameMode_MAX,
}

public enum EMatchType
{
  EMatchType_None,
  EMatchType_Round,
  EMatchType_Point,
  EMatchType_Wave,
  EMatchType_TimeLimit,
  EMatchType_MAX,
}

public enum ETeamChangeType
{
  ETEAMCHANGE_HOLD,
  ETEAMCHANGE_HALF,
  ETEAMCHANGE_TUTORIAL,
  ETEAMCHANGE_NOTUSE0,
  ETEAMCHANGE_NOTUSE1,
  ETEAMCHANGE_NOTUSE2,
  ETEAMCHANGE_MAX,
}

public enum ESFPCState
{
  ESFPCState_Def,
  ESFPCState_Spectator,
  ESFPCState_Interlude,
  ESFPCState_MAX,
}

public enum ERadarType
{
  ERadar_FixedNone,
  ERadar_FixedRotation,
  ERadar_FixedLocationRotation,
  ERadar_MAX,
}

public enum EWeapMeshCompGroup
{
  WMC_GROUP_0,
  WMC_GROUP_1,
  WMC_GROUP_MAX,
}

public enum EDefensePriority
{
  DEFPRI_Low,
  DEFPRI_High,
  DEFPRI_MAX,
}

public enum EPostEffectDirection
{
  PED_Front,
  PED_Side,
  PED_Back,
  PED_None,
  PED_MAX,
}

public enum ECharItemType
{
  CIT_UNIT,
  CIT_FACE,
  CIT_MASK,
  CIT_EYE,
  CIT_JACKET,
  CIT_GLOVE,
  CIT_WRIST,
  CIT_PANTS,
  CIT_SHOES,
  CIT_BELT,
  CIT_CAP,
  CIT_SUIT,
  CIT_EFFECT,
  CIT_BACKPACK,
  CIT_MAX,
}

public enum EWeapItemType
{
  WIT_PRI_WEAPON,
  WIT_PRI_BODY,
  WIT_PRI_MAGAZINE,
  WIT_PRI_SCOPE,
  WIT_PRI_STOCK,
  WIT_PRI_BARREL,
  WIT_PRI_SILENCER,
  WIT_PRI_LASER,
  WIT_PRI_TRIGGER,
  WIT_PRI_GRIP,
  WIT_PRI_GLAUNCHER,
  WIT_PRI_WEAPONTAG,
  WIT_PRI_CAMO,
  WIT_PRI_MUZZLEFLASH,
  WIT_PRI_MUZZLEFLASH_COLOR,
  WIT_PRI_WEAPONEFFECT,
  WIT_SEC_WEAPON,
  WIT_SEC_BODY,
  WIT_SEC_MAGAZINE,
  WIT_SEC_SCOPE,
  WIT_SEC_STOCK,
  WIT_SEC_BARREL,
  WIT_SEC_SILENCER,
  WIT_SEC_LASER,
  WIT_SEC_TRIGGER,
  WIT_SEC_GRIP,
  WIT_SEC_CAMO,
  WIT_THIRD_1,
  WIT_THIRD_1_CAMO,
  WIT_THIRD_2,
  WIT_THIRD_2_CAMO,
  WIT_THIRD_3,
  WIT_THIRD_3_CAMO,
  WIT_KNIFE,
  WIT_KNIFE_CAMO,
  WIT_SPECIAL,
  WIT_SPECIAL_CAMO,
  WIT_MAX,
}

public enum EWeaponType
{
  EWeapType_WeapAR,
  EWeapType_WeapSMG,
  EWeapType_WeapSR,
  EWeapType_WeapMG,
  EWeapType_WeapSG,
  EWeapType_WeapPST,
  EWeapType_WeapThrow,
  EWeapType_WeapKnife,
  EWeapType_WeapSpecial,
  EWeapType_Arrow,
  EWeapType_ThrowingKnife,
  EWeapType_WeapMG_Turret,
  EWeapType_None,
  EWeapType_MAX,
}

public enum EWeapPartType
{
  EWeapPart_Body,
  EWeapPart_Magazine,
  EWeapPart_Scope,
  EWeapPart_Stock,
  EWeapPart_Barrel,
  EWeapPart_Silencer,
  EWeapPart_LaserPoint,
  EWeapPart_Trigger,
  EWeapPart_Grip,
  EWeapPart_WeaponTag,
  EWeapPart_Camo,
  EWeapPart_MuzzleFlash,
  EWeapPart_MuzzleFlashColor,
  EWeapPart_WeaponEffect,
  EWeapPart_BombSP,
  EWeapPart_GLauncher,
  EWeapPart_MAX,
}

public enum EFuncItemType
{
  EFuncItemType_Normal,
  EFuncItemType_ResetRecord,
  EFuncItemType_Camo,
  EFuncItemType_Spray,
  EFuncItemType_PMC,
  EFuncITemType_Coupon,
  EFuncITemType_CombinePart,
  EFuncITemType_Package,
  EFuncITemType_DeathParts,
  EFuncItemType_MAX,
}

public enum ECamoType
{
  ECAMOT_NONE,
  ECAMOT_TEXTURE,
  ECAMOT_MATERIAL,
  ECAMOT_REMOVAL,
  ECAMOT_MAX,
}

public enum EModeItemType
{
  EModeItemType_None,
  EModeItemType_Passive,
  EModeItemType_Active,
  EModeItemType_MAX,
}

public enum ENoticeBtnType
{
  ENoticeBtnType_none,
  ENoticeBtnType_Ok,
  ENoticeBtnType_Ok_NO,
  ENoticeBtnType_YesAndCancel,
  ENoticeBtnType_MAX,
}

public enum EClipDirection
{
  EClipDirection_None,
  EClipDirection_InScreen,
  EClipDirection_Left,
  EClipDirection_Right,
  EClipDirection_Top,
  EClipDirection_Bottom,
  EClipDirection_MAX,
}

public enum EARMSTYPE
{
  EARMSTYPE_A,
  EARMSTYPE_B,
  EARMSTYPE_C,
  EARMSTYPE_MAX,
}

public enum EGamePlayModeType
{
  GAMETYPE_NONE,
  GAMETYPE_TEAM,
  GAMETYPE_MISSION,
  GAMETYPE_MAX,
}

public enum ERoomUserState
{
  ERoomUserState_Normal,
  ERoomUserState_Ready,
  ERoomUserState_Setting,
  ERoomUserState_Playing,
  ERoomUserState_MAX,
}

public enum ENDGAME_STATE
{
  ENDGAME_STATE_End,
  ENDGAME_STATE_Stop,
  ENDGAME_STATE_MAX,
}

public enum EGameChannelType
{
  EGCT_Unknown,
  EGCT_Rookie,
  EGCT_Normal,
  EGCT_Clan,
  EGCT_MAX,
}

public enum EPossibleVideoSettings
{
  PVS_ScreenPercentage,
  PVS_TextureDetail,
  PVS_WorldDetail,
  PVS_FXDetail,
  PVS_DecalQuality,
  PVS_LightingQuality,
  PVS_ShadowQuality,
  PVS_MSAA,
  PVS_PostProcessQuality,
  PVS_VSyncValue,
  PVS_SmoothFramerate,
  PVS_PlayerFOV,
  PVS_Antialiasing,
  PVS_LightSpreadEffect,
  PVS_DynamicShadows,
  PVS_DepthOfField,
  PVS_ExploRadialBlur,
  PVS_EnemyDefaultUnit,
  PVS_MAX,
}

public enum EPawnEffectGroupType
{
  PEG_FOOTSTEP,
  PEG_FOOTSTEPDASH,
  PEG_LANDING,
  PEG_RUSTLE,
  PEG_RADIOMESSAGE,
  PEG_PAWNSOUND,
  PEG_MAX,
}

public enum ESpecialSoundType
{
  SST_FOOTSTEP,
  SST_FOOTSTEPDASH,
  SST_LANDING,
  SST_KILL,
  SST_MAX,
}

public enum EMagAnimType
{
  EMAT_None,
  EMAT_SPW,
  EMAT_P90,
  EMAT_MAX,
}

public enum EGender
{
  EG_MALE,
  EG_FEMALE,
  EG_MAIDEN,
  EG_COMMON,
  EG_MAX,
}

public enum EGenderGrip
{
  EGG_MALE_VERTICAL,
  EGG_FEMALE_VERTICAL,
  EGG_MAIDEN_VERTICAL,
  EGG_MALE_ANGLE,
  EGG_FEMALE_ANGLE,
  EGG_MAIDEN_ANGLE,
  EGG_MAX,
}

public enum ESkinTextureType
{
  SKIN_WHITE,
  SKIN_BLACK,
  SKIN_YELLOW,
  SKIN_MAX,
}

public enum ENameTag
{
  ENameTag_Spectator,
  ENameTag_KillCam,
  ENameTag_Die,
  ENameTag_MAX,
}

public enum EObjectIconTypes
{
  EOIT_TriggerTeam,
  EOIT_TriggerEnemy,
  EOIT_InstallSiteTeamA,
  EOIT_InstallSiteTeamB,
  EOIT_InstallSiteEnemyA,
  EOIT_InstallSiteEnemyB,
  EOIT_TakeItemRed,
  EOIT_TakeItemBlue,
  EOIT_GoalIcon,
  EOIT_ThunderRunA,
  EOIT_ThunderRunB,
  EOIT_ThunderRunC,
  EOIT_FrontLineA,
  EOIT_FrontLineB,
  EOIT_FrontLineC,
  EOIT_PvEShop,
  EOIT_PvEManDown,
  EOIT_PvESuppressor,
  EOIT_PvEBarricade,
  EOIT_HeroAlienCtrl_Friend,
  EOIT_HeroTurret_Friend,
  EOIT_HeroAlienCtrl_Enemy,
  EOIT_HeroTurret_Enemy,
  EOIT_HeroShop1,
  EOIT_HeroShop2,
  EOIT_CaptureTower,
  EOIT_MiniSpore,
  EOIT_ConvoyanceTarget,
  EOIT_ConvoyanceStore,
  EOIT_MAX,
}

public enum EAdditionalType
{
  EAdditionalType_EXPUP,
  EAdditionalType_SPGAGEUP,
  EAdditionalType_TPUP,
  EAdditionalType_COMBINECOUNT,
  EAdditionalType_LPUP,
  EAdditionalType_MAX,
}

public enum EFreeItemType
{
  EFreeItem_PCRoom,
  EFreeItem_VIP,
  EFreeItem_MonthlyReward,
  EFreeItem_MAX,
}

public enum EFeverItemType
{
  EFeverItem_LPReward,
  EFeverItem_Sale,
  EFeverItem_Reward,
  EFeverItem_MAX,
}

public enum EPingNotifyType
{
  EPing_Attack,
  EPing_Retreat,
  EPing_MAX,
}

public enum EAwardValueType
{
  EAwardValueType_Null,
  EAwardValueType_Number,
  EAwardValueType_String,
  EAwardValueType_Boolean,
  EAwardValueType_MAX,
}

public enum SFVoiceFoleyID
{
  SFVoiceFoley_None,
  SFVoiceFoley_DamagedNormal,
  SFVoiceFoley_DyingSound,
  SFVoiceFoley_DamageSnow,
  SFVoiceFoley_DamagedCritical,
  SFVoiceFoley_Breath_Left_1st,
  SFVoiceFoley_Breath_Right_1st,
  SFVoiceFoley_MAX,
}

public enum SFFoleyID
{
  SFFoley_None,
  SFFoley_RustleSound,
  SFFoley_RustleSoundDash,
  SFFoley_HitDead,
  SFFoley_HitHelmet,
  SFFoley_HitByNormal,
  SFFoley_HitByKnife,
  SFFoley_HitByArrow,
  SFFoley_Kill,
  SFFoley_KillHead,
  SFFoley_FallDeadBody,
  SFFoley_HitBySnow,
  SFFoley_HitBack,
  SFFoley_KillBack,
  SFFoley_HitByTomahawk,
  SFFoley_HitByStun,
  SFFoley_HitByBreath,
  SFFoley_HitByBreathDot,
  SFFoley_HitByZombieNormal,
  SFFoley_HitByFlame,
  SFFoley_MAX,
}

public enum EChallengeType
{
  EChallengeType_Weapon,
  EChallengeType_Mission,
  EChallengeType_SpecialKill,
  EChallengeType_ETC,
  EChallengeType_MAX,
}

public enum EKillFeedBackType
{
  EKillFeedBack_None,
  EKillFeedBack_Default,
  EKillFeedBack_Normal,
  EKillFeedBack_Special,
  EKillFeedBack_Rare,
  EKillFeedBack_Continuous,
  EKillFeedBack_MAX,
}

public enum eFullBodyAnimType
{
  eFBAT_Attack,
  eFBAT_AttackAlt,
  eFBAT_Roar,
  eFBAT_Hit,
  eFBAT_Spawn,
  eFBAT_Stun,
  eFBAT_Death,
  eFBAT_Idle,
  eFBAT_IdleToDash,
  eFBAT_DashToIdle,
  eFBAT_DashStun,
  eFBAT_PreAttack,
  eFBAT_PostAttack,
  eFBAT_MAX,
}

public enum EObserverViewMode
{
  EOVM_Everyone_1ST,
  EOVM_Everyone_3RD,
  EOVM_RED_1ST,
  EOVM_RED_3RD,
  EOVM_BLUE_1ST,
  EOVM_BLUE_3RD,
  EOVM_Free,
  EOVM_Translucent,
  EOVM_Top,
  EOVM_InGameSpectator,
  EOVM_MAX,
}

public enum EObserverShowArmBand
{
  EOSAB_Both,
  EOSAB_IFFBand,
  EOSAB_TeamBand,
  EOSAB_Neither,
  EOSAB_MAX,
}

public enum ERadioMessageType
{
  ERdo_Community,
  ERdo_Command,
  ERdo_Mission,
  ERdo_Auto,
  ERdo_MAX,
}

public enum EPaymentIndex
{
  EPayment_None,
  EPayment_SP,
  EPayment_CASH,
  EPayment_TP,
  EPayment_LP,
  EPayment_MAX,
}

public enum EEventProgressType
{
  EEventProgress_Percent,
  EEventProgress_Gage,
  EEventProgress_Collect,
  EEventProgress_Attendance,
  EEventProgress_MAX,
}

public enum EDBNOLEVEL
{
  EDBNO_ALIVE,
  EDBNO_DOWN,
  EDBNO_IDLE,
  EDBNO_REVIVAL,
  EDBNO_RIP,
  EDBNO_MAX,
}

public enum eSpawnAnimStat
{
  eSpawnAnimStat_Ready,
  eSpawnAnimStat_Playing,
  eSpawnAnimStat_Played,
  eSpawnAnimStat_MAX,
}

public enum eECONSUME_TEAMSCORE
{
  ECONSUME_REVIVAL,
  ECONSUME_SETUPBARRICADE,
  ECONSUME_USESHOP,
  ECONSUME_MAX,
}

public enum eClanMarkImageSize
{
  eClanMarkImageSize_32,
  eClanMarkImageSize_64,
  eClanMarkImageSize_128,
  eClanMarkImageSize_MAX,
}

public enum EDroneType
{
  EDroneType_Suicide,
  EDroneType_AR,
  EDroneType_GuideRocket,
  EDroneType_MAX,
}

public enum EHUDActionMsg
{
  EHUDActionMsg_TriggerUse,
  EHUDActionMsg_DroppedPicup,
  EHUDActionMsg_SelectWeapon,
  EHUDActionMsg_Sprint,
  EHUDActionMsg_MouseSensitivity,
  EHUDActionMsg_NoStrIconMsg,
  EHUDActionMsg_Stun,
  EHUDActionMsg_RevivalMsg,
  EHUDActionMsg_BarricadeMsg,
  EHUDActionMsg_KillingZombieAI,
  EHUDActionMsg_KillingZombiePlayer,
  EHUDActionMsg_None,
  EHUDActionMsg_Max,
}

public enum EObjectIconState
{
  EOIS_Hide,
  EOIS_Normal,
  EOIS_Ani,
  EOIS_Ani1,
  EOIS_Ani2,
  EOIS_Ani3,
  EOIS_Ani4,
  EOIS_MAX,
}

public enum EPawnOutlineType
{
  EPawnOutlineType_Killer,
  EPawnOutlineType_Enemy,
  EPawnOutlineType_OutlineVolume,
  EPawnOutlineType_NearestPawnForThunderRun,
  EPawnOutlineType_PVEDBNO,
  EPawnOutlineType_KillCam,
  EPawnOutlineType_ShowCloakingRipper,
  EPawnOutlineType_Comrade,
  EPawnOutLineType_TargetSeeker,
  EPawnOutlineType_SpectatorRed,
  EPawnOutlinetype_SpectatorBlue,
  EPawnOutlineType_MAX,
}

public enum ECodeNameState
{
  ECodeNameState_None,
  ECodeNameState_Normal,
  ECodeNameState_Dead,
  ECodeNameState_MAX,
}

public enum EChatCmds
{
  CCMD_NONE,
  CCMD_WHISP,
  CCMD_HELP,
  CCMD_NORMALCHAT,
  CCMD_CLANCHAT,
  CCMD_TEAMCHAT,
  CCMD_HUDTGL,
  CCMD_INVITE,
  CCMD_WHISPBLOCK,
  CCMD_BLOCKCLEAR,
  CCMD_TrainingTargetName,
  CCMD_VoteToKickStart,
  CCMD_Accept,
  CCMD_Refuse,
  CCMD_SHOWUSN,
  CCMD_HIDECHATLOG,
  CCMD_CHATBLOCK,
  CCMD_GMKICK,
  CCMD_NOTICE,
  CCMD_BAN,
  CCMD_MUTE,
  CCMD_MAX,
}

public enum EChatType
{
  EChat_Normal,
  EChat_Team,
  EChat_System,
  EChat_GameResult,
  EChat_ServerNotice,
  EChat_GM,
  EChat_Messenger,
  EChat_Clan,
  EChat_Whisper,
  EChat_RadioMsg,
  EChat_ServerNoticeCritical,
  EChat_ClanInvite,
  EChat_RoomCountDown,
  EChat_HandOverHost,
  EChat_MatchingDenied,
  EChat_HeroReward,
  EChat_MAX,
}

public enum EChatSendType
{
  EChatSend_Channel,
  EChatSend_WaitingRoom,
  EChatSend_InGameAll,
  EChatSend_InGameSpectator,
  EChatSend_InGameTeam,
  EChatSend_Clan,
  EChatSend_Whisper,
  EChatSend_MAX,
}

public enum ECustomPartType
{
  CP_CHAR_FACE,
  CP_CHAR_GLASS,
  CP_CHAR_SHEMAGH,
  CP_CHAR_ARM,
  CP_CHAR_WRIST,
  CP_CHAR_PANTS1,
  CP_CHAR_PANTS2,
  CP_CHAR_PANTS3,
  CP_CHAR_HAND,
  CP_CHAR_CLANMARK,
  CP_CHAR_LEVELMARK,
  CP_CHAR_SHOUL2,
  CP_CHAR_VEST1,
  CP_CHAR_VEST2,
  CP_CHAR_VEST3,
  CP_CHAR_VEST4,
  CP_CHAR_VEST5,
  CP_CHAR_FOOT,
  CP_CHAR_POUCH,
  CP_CHAR_CANTEEN,
  CP_CHAR_GASBAG,
  CP_CHAR_MAGAZINE,
  CP_CHAR_PANTS5,
  CP_CHAR_SHOUL1,
  CP_CHAR_HAIR,
  CP_HELMET_BODY,
  CP_HELMET_GOGGLE,
  CP_HELMET_NSCOPE,
  CP_HELMET_EARSET,
  CP_HELMET_STRAP,
  CP_1ST_ARM,
  CP_1ST_HAND,
  CP_1ST_WRIST,
  CP_WEAP_GROUP_0_BODY,
  CP_WEAP_GROUP_0_MAGAZINE,
  CP_WEAP_GROUP_0_LASER,
  CP_WEAP_GROUP_0_SILENCER,
  CP_WEAP_GROUP_0_SCOPE,
  CP_WEAP_GROUP_0_STOCK,
  CP_WEAP_GROUP_0_GLAUNCHER,
  CP_WEAP_GROUP_0_BARREL,
  CP_WEAP_GROUP_1_BODY,
  CP_WEAP_GROUP_1_MAGAZINE,
  CP_WEAP_GROUP_1_LASER,
  CP_WEAP_GROUP_1_SILENCER,
  CP_MAX,
}

public enum eHUDClockType
{
  eHUDClockType_LimitTimeGame,
  eHUDClockType_InfiniteTimeGame,
  eHUDClockType_MAX,
}

public enum ERecoilState
{
  ERecoilState_None,
  ERecoilState_Inc,
  ERecoilState_Dec,
  ERecoilState_MAX,
}

public enum EWeapSet
{
  EWS_TYPE_A,
  EWS_TYPE_B,
  EWS_TYPE_C,
  EWS_TYPE_MAX,
}

public enum EGFxHUDMessage
{
  EHUDMSG_None,
  EHUDMSG_SystemNotice,
  EHUDMSG_Kill,
  EHUDMSG_Promotion,
  EHUDMSG_ScoreUp,
  EHUDMSG_GameSystem,
  EHUDMSG_Action,
  EHUDMSG_KilledUserInfo,
  EHUDMSG_GameState,
  EHUDMSG_LuckyPoint,
  EHUDMSG_LastManStanding,
  EHUDMSG_MessageByKismet,
  EHUDMSG_KeyMessage,
  EHUDMSG_Warning,
  EHUDMSG_BeginnerTip,
  EHUDMSG_BonusScore,
  EHUDMSG_HeroKill,
  EHUDMSG_HeroLevelUp,
  EHUDMSG_HeroMoneyUp,
  EHUDMSG_HeroAlienControllerDestroy,
  EHUDMSG_HeroTurretDestroy,
  EHUDMSG_HeroDeathReward,
  EHUDMSG_KillDeathReward,
  EHUDMSG_LastStand,
  EHUDMSG_BombSP,
  EHUDMSG_Max,
}

public enum AttendanceEventBoxType
{
  AEBoxType_InProgress,
  AEBoxType_AchivedGoal,
  AEBoxType_AchivedReward,
  AEBoxType_MAX,
}

public enum ELobbyScreen
{
  ELobby_None,
  ELobby_LoginView,
  ELobby_WebLoginView,
  ELobby_CHNLoginView,
  ELobby_PMSLoginView,
  ELobby_OTPLoginView,
  ELobby_CreateCodeName,
  ELobby_CreateCharacter,
  ELobby_ChannelSelect,
  ELobby_RoomList,
  ELobby_CreateRoom,
  ELobby_QuickJoin,
  ELobby_Inventory,
  ELobby_Shop,
  ELobby_MyInfo,
  ELobby_BattlePass,
  ELobby_MiniGame,
  ELobby_WaitingRoom,
  ELobby_PartyRoom,
  ELobby_WaitingRoom_PVE,
  ELobby_WaitingRoom_Hero,
  ELobby_PartyRoomList,
  ELobby_GashaponList,
  ELobby_GashaOrgelBox,
  ELobby_ClanHome,
  ELobby_ClanList,
  ELobby_Album,
  ELobby_Navi,
  ELobby_MsgrBuddy,
  ELobby_GachaRoll,
  ELobby_MsgrChatting,
  ELobby_LeftNotice,
  ELobby_PurchaseGuide,
  ELobby_VideoPlayer,
  ELobby_SideBackground,
  ELobby_Community,
  ELobby_WaitingRoom_AITDM,
  ELobby_WaitingRoom_Zombie,
  ELobby_WaitingRoom_AITDMVS16,
  ELobby_WaitingRoom_1VS1,
  ELobby_WaitingRoom_16VS16,
  ELobby_Rank,
  ELobby_Enchant,
  ELobby_ClanLeague,
  ELobby_FeverTime,
  ELobby_Combine,
  ELobby_LeagueMatch,
  ELobby_SoloLeagueNotice,
  ELobby_GashaPercent,
  ELobby_WeaponParts,
  ELobby_MAX,
}

public enum ELobbyDialog
{
  EDialog_None,
  EDialog_Base,
  EDialog_CreateEvent,
  EDialog_CreateRoom,
  EDialog_BuyOne,
  EDialog_BuyAll,
  EDialog_BuyOk,
  EDialog_Following,
  EDialog_SysSetting,
  EDialog_WaitingAck,
  EDialog_GameResult,
  EDialog_GameResult_PVE,
  EDialog_GameResult_Hero,
  EDialog_GameResult_Zombie,
  EDialog_GameResult_16vs16,
  EDialog_Password,
  EDialog_ItemRepair,
  EDialog_AllItemRepair,
  EDialog_ItemResell,
  EDialog_SystemMessage,
  EDialog_ClanAreaSelect,
  EDialog_ClanMake,
  EDialog_ClanJoin,
  EDialog_RankLimitError,
  EDialog_Exit,
  EDialog_FullScrHelp,
  EDialog_FuncUseDefault,
  EDialog_FuncUseReset,
  EDialog_FuncChangeName,
  EDialog_FuncChangeSpecialName,
  EDialog_FuncChangeOneLetterName,
  EDialog_FuncChangeClanMark,
  EDialog_UseCamo,
  EDialog_UseColorCodeName,
  EDialog_UseColorCodeNameV2,
  EDialog_UseCarveWeaponTag,
  EDialog_UseMuzzleFlash,
  EDialog_UseStoredMaterial,
  EDialog_UseCoupon,
  EDialog_UseIMagazine,
  EDialog_QuickJoin,
  EDialog_MatchingFound,
  EDialog_ExtraReward,
  EDialog_RewardItem,
  EDialog_ClanWideAreaSelect,
  EDialog_ChangeTP,
  EDialog_ChallengeComplete,
  EDialog_EmblemDeck,
  EDialog_ExitInGame,
  EDialog_ExitConfirmDialog,
  EDialog_BeginnerComplete,
  EDialog_RookieChannel,
  EDialog_SelectGift,
  Edialog_IngameShop,
  EDialog_EventList,
  EDialog_TagSystem,
  EDialog_ChoicePackage,
  EDialog_CommunityNews,
  EDialog_ChangeCrossHair,
  EDialog_WebLogin,
  EDialog_SpectatorDeco,
  EDialog_ClanMarkAnimation,
  EDialog_WebBrowser,
  EDialog_ClanMakeLimit,
  EDialog_PackagePreview,
  EDialog_FacebookFriendList,
  EDialog_VoteOut,
  EDialog_WeeklyClanRank,
  EDialog_Declare,
  EDialog_ClanSearch,
  EDialog_BillingToken,
  EDialog_WaitingChangeObj,
  EDialog_TwitchTV,
  EDialog_InitWeaponKillDeath,
  EDialog_ChangeClassMark,
  EDialog_UseRandomBox,
  EDialog_UseFiringRangeScoreInitial,
  EDialog_UseBombSPCoupon,
  EDialog_Serial,
  EDialog_RecycleResult,
  EDialog_BPEventList,
  EDialog_UseWeaponParts,
  EDialog_CashChargeConfirm,
  EDialog_PartsApply,
  ELobbyDialog_MAX,
}

public enum eItemTypeDEF
{
  eItemType_CAMO,
  eItemType_WEAPON,
  eItemType_CHAR,
  eItemType_PMC,
  eItemType_MAX,
}

public enum EINVITERESULT
{
  EINVITERESULT_NONE,
  EINVITERESULT_SUCCESS,
  EINVITERESULT_NOTBUDDY,
  EINVITERESULT_BEGINNER,
  EINVITERESULT_SEX,
  EINVITERESULT_CLAN,
  EINVITERESULT_USERGRADE,
  EINVITERESULT_NOUSER,
  EINVITERESULT_INGAME,
  EINVITERESULT_NOTINROOM,
  EINVITERESULT_FULLCHANNEL,
  EINVITERESULT_FULLROOM,
  EINVITERESULT_OFFLINE,
  EINVITERESULT_REPEAT,
  EINVITERESULT_SELF,
  EINVITERESULT_INSAMELOC,
  EINVITERESULT_WAITINGINVITE,
  EINVITERESULT_INCOUNTDOWN,
  EINVITERESULT_INMINIGAME,
  EINVITERESULT_REFUSEINVITE,
  EINVITERESULT_NOINTRUSION,
  EINVITERESULT_NOHEROTEST,
  EINVITERESULT_SOLOLEAGUE,
  EINVITERESULT_NOROOM,
  EINVITERESULT_NOCHANNEL,
  EINVITERESULT_MAX,
}

public enum EHitMarkType
{
  EHITMARK_NONE,
  EHITMARK_CENTERCROSS,
  EHITMARK_MULTICROSS,
  EHITMARK_MAX,
}

public enum EObjectIconInterplateType
{
  EObjIconInterpType_Screen,
  EObjIconInterpType_Rect,
  EObjIconInterpType_RectToScreen,
  EObjIconInterpType_ScreenToRect,
  EObjIconInterpType_MAX,
}

public enum EObjectInterpDir
{
  EObjecInterpDir_Small,
  EObjecInterpDir_Large,
  EObjecInterpDir_None,
  EObjecInterpDir_MAX,
}

public enum EPawnIconState
{
  EPIS_None,
  EPIS_Normal,
  EPIS_Seizured,
  EPIS_MAX,
}

public enum eActionMessageType
{
  eActionMessageType_Normal,
  eActionMessageType_NotInputBiding,
  eActionMessageType_AniIcon,
  eActionMessageType_MAX,
}

public enum EHUD_KDACount_HideType
{
  EHUD_KDACount_HideNone,
  EHUD_KDACount_HideAll,
  EHUD_KDACount_HideDeath,
  EHUD_KDACount_MAX,
}

public enum EMissionItemType
{
  EMIT_None,
  EMIT_Blasting,
  EMIT_Semtex,
  EMIT_Radar,
  EMIT_LaserInductor,
  EMIT_ZombieInteraction,
  EMIT_MAX,
}

public enum EMCCharacter
{
  EMCC_INVALID,
  EMCC_USEMC,
  EMCC_NONMC,
  EMCC_MAX,
}

public enum ECountDownCount
{
  ECountDownCount_0,
  ECountDownCount_1,
  ECountDownCount_2,
  ECountDownCount_3,
  ECountDownCount_4,
  ECountDownCount_5,
  ECountDownCount_6,
  ECountDownCount_7,
  ECountDownCount_8,
  ECountDownCount_9,
  ECountDownCount_10,
  ECountDownCount_MAX,
}

public enum ERaidoMessagePriority
{
  ERadioMessagePriority_VeryLow,
  ERadioMessagePriority_Low,
  ERadioMessagePriority_Medium,
  ERadioMessagePriority_High,
  ERadioMessagePriority_VeryHigh,
  ERadioMessagePriority_MAX,
}

public enum ERoundStartType
{
  ERoundStart_Normal,
  ERoundStart_MatchPoint,
  ERoundStart_FinalRound,
  ERoundStart_Max,
}

public enum ERoundEndType
{
  ERoundEnd_Win,
  ERoundEnd_Lose,
  ERoundEnd_SaveRound,
  ERoundEnd_PerfectRound,
  ERoundEnd_AllKill,
  ERoundEnd_Max,
}

public enum EMatchEndType
{
  EMatchEnd_Win,
  EMatchEnd_Lose,
  EMatchEnd_Max,
}

public enum EMissionScoreType
{
  EMissionScore_TeamAndUser,
  EMissionScore_Team,
  EMissionScore_User,
  EMissionScore_MAX,
}

public enum ELogType
{
  ELT_None,
  ELT_PlayTime,
  ELT_Kill,
  ELT_Assist,
  ELT_Death,
  ELT_AimKill,
  ELT_HeadShot,
  ELT_ChestHit,
  ELT_StomachHit,
  ELT_LimbsHit,
  ELT_HeadPoint,
  ELT_AliveCount,
  ELT_MissionInfo_1,
  ELT_MissionInfo_2,
  ELT_MissionInfo_3,
  ELT_AttackRound,
  ELT_DefendRound,
  ELT_TotWinCount,
  ELT_TotLoseCount,
  ELT_WinGameCount,
  ELT_CSN,
  ELT_PlayerWithCount,
  ELT_EarnScore,
  ELT_EarnLuckyPointCount,
  ELT_AttackRoundWin,
  ELT_DefendRoundWin,
  ELT_TotalHitEnemyCount,
  ELT_HeadHitCount,
  ELT_TotalHitCount,
  ELT_LuckyPoint,
  ELT_HitEnemyCount,
  ELT_WeapSetUsedCount,
  ELT_GameScore,
  ELT_MAX,
}

public enum EPVELogType
{
  EPVELT_Kill,
  EPVELT_BossKill,
  EPVELT_CriticalKill,
  EPVELT_Assist,
  EPVELT_DeadCount,
  EPVELT_AccumulationMoney,
  EPVELT_SpendMoney,
  EPVELT_EliteCrawlerKill,
  EPVELT_NamedCrawlerKill,
  EPVELT_EliteRipperKill,
  EPVELT_NamedRipperKill,
  EPVELT_CloakingRipperKill,
  EPVELT_EliteLibertineKill,
  EPVELT_NamedLibertineKill,
  EPVELT_EliteStunnerKill,
  EPVELT_NamedStunnerKill,
  EPVELT_GasStunnerKill,
  EPVELT_EliteTyrantKill,
  EPVELT_NamedTyrantKill,
  EPVELT_MAX,
}

public enum EManHuntLogType
{
  EMHLT_PlayTimeByHuman,
  EMHLT_KillByHuman,
  EMHLT_AssistByHuman,
  EMHLT_DeadByHuman,
  EMHLT_PlayTimeByBeast,
  EMHLT_KillByBeastType,
  EMHLT_AssistByBeastType,
  EMHLT_DeadByBeastType,
  EMHLT_MAX,
}

public enum EManHuntKillType
{
  EMHKT_CloakingRipper,
  EMHKT_Stunner,
  EMHKT_Libertine,
  EMHKT_MAX,
}

public enum EZombieKillType
{
  EZBK_ZombieWalker,
  EZBK_ZombieInvincible,
  EZBK_ZombiePuker,
  EZBK_ZombieBoomer,
  EZBK_ZombieTanker,
  EZBK_ZombiePunisher,
  EZBK_MAX,
}

public enum EGFxPingType
{
  EGFxPingType_BAD,
  EGFxPingType_NORMAL,
  EGFxPingType_GOOD,
  EGFxPingType_VERYGOOD,
  EGFxPingType_MAX,
}

public enum EEmotionType
{
  EmotionRoundEnd,
  EmotionRadioMessage,
  EEmotionType_MAX,
}

public enum EHUDScoreType
{
  EHUDScoreType_Score,
  EHUDScoreType_Round,
  EHUDScoreType_WinArea,
  EHUDScoreType_Wave,
  EHUDScoreType_MAX,
}

public enum EOutFromRoom
{
  EOutFromRoom_WaitingRoomKick,
  EOutFromRoom_NoInput,
  EOutFromRoom_ClanKick,
  EOutFromRoom_ClanDestroy,
  EOutFromRoom_HeroModeExit,
  EOutFromRoom_InGameVoteKick,
  EOutFromRoom_GraduateRookie,
  EOutFromRoom_GameMasterKick,
  EOutFromRoom_None,
  EOutFromRoom_MAX,
}

public enum ECantStartGame
{
  ECantStartGame_None,
  ECantStartGame_PlayerNeed,
  ECantStartGame_ChangingMaster,
  ECantStartGame_IntrusionFailed,
  ECantStartGame_MisBalance,
  ECantStartGame_IntrusionDisabled,
  ECantStartGame_NoMainWeapon,
  ECantStartGame_OverPlayers,
  ECantStartGame_MercenaryExceeded,
  ECantStartGame_SameClanMatch,
  ECantStartGame_ClanPlayerNeed,
  ECantStartGame_MatchSearchPlayerNeed,
  ECantStartGame_12,
  ECantStartGame_13,
  ECantStartGame_14,
  ECantStartGame_PlayerNeedNoTeam,
  ECantStartGame_MatchIsOver,
  ECantStartGame_NeedMorePlayers,
  ECantStartGame_NeedAI,
  ECantStartGame_NeedOpenSlot,
  ECantStartGame_MAX,
}

public enum ECommunityEvent
{
  ECommunityEvent_Normal,
  ECommunityEvent_Ranking,
  ECommunityEvent_JoinClan,
  ECommunityEvent_Gasha,
  ECommunityEvent_MAX,
}

public enum EHackRespondType
{
  EHACKRESPOND_NONE,
  EHACKRESPOND_SENDREPORT,
  EHACKRESPOND_RETURNTOLOBBY,
  EHACKRESPOND_TERMINATEGAME,
  EHACKRESPOND_MAX,
}

public enum PolyType
{
  PolyType_UNKNOWN,
  PolyType_INPUT,
  PolyType_INSERT,
  PolyType_START,
  PolyType_END,
  PolyType_MERGE,
  PolyType_SPLIT,
  PolyType_REGULAR_UP,
  PolyType_REGULAR_DOWN,
  PolyType_MAX,
}

public enum eMuzzleSocketName
{
  MUZZLE_SOCKET_NORMAL,
  MUZZLE_SOCKET_SILENCER,
  MUZZLE_SOCKET_DUAL_LEFT,
  MUZZLE_SOCKET_DUAL_RIGHT,
  MUZZLE_SOCKET_MAX,
}

public enum eMOUSECLICK
{
  CLICK_NONE,
  CLICK_LEFT,
  CLICK_RIGHT,
  CLICK_MAX,
}

public enum eMOUSEMode
{
  MOUSEMODE_FULL_SCR,
  MOUSEMODE_ROUND_SCR,
  MOUSEMODE_MAX,
}

public enum eShooterPowerUpType
{
  ESPU_NONE,
  ESPU_ATT,
  ESPU_DEF,
  ESPU_AGL,
  ESPU_SPECL,
  ESPU_MAX,
}

public enum eCamoCopyType
{
  ECCT_None,
  ECCT_Copy,
  ECCT_ResetCopy,
  ECCT_SetOnly,
  ECCT_MAX,
}

public enum ECamoMaskType
{
  ECMT_NONE,
  ECMT_NORMAL,
  ECMT_METALIC,
  ECMT_SOLID,
  ECMT_MAX,
}

public enum EClanRankType
{
  EClanRankType_ThisWeek,
  EClanRankType_LastWeek,
  EClanRankType_MAX,
}

public enum EClanAreaDlgType
{
  EClanAreaDlg_Normal,
  EClanAreaDlg_ListSelect,
  EClanAreaDlg_Search,
  EClanAreaDlg_MAX,
}

public enum eSpecialAI
{
  eSAI_None,
  eSAI_ItemCarrier,
  eSAI_MAX,
}

public enum eExtraBodyPart
{
  eExtPart_None,
  eExtPart_Back,
  eExtPart_Front,
  eExtPart_MAX,
}

public enum eNAVPointType
{
  NAVPT_NORMAL,
  NAVPT_HOLD,
  NAVPT_SNIPER,
  NAVPT_MAX,
}

public enum eSPAWNPOINTSORTTYPE
{
  SPAWNPOINTSORTTYPE_BYDIST,
  SPAWNPOINTSORTTYPE_BYUSEDTIME,
  SPAWNPOINTSORTTYPE_MAX,
}

public enum eAGGROLEVEL
{
  AGGRO_PEACE,
  AGGRO_CAUTION,
  AGGRO_ATTACK,
  AGGRO_MAX,
}

public enum EAINOISE_TYPE
{
  EAINOISE_NONE,
  EAINOISE_RUN,
  EAINOISE_SPRINT,
  EAINOISE_SILENCEFIRE,
  EAINOISE_FIRE,
  EAINOISE_MAX,
}

public enum ESpawnPointSelectionMethod
{
  SPSM_Shuffle,
  SPSM_Linear,
  SPSM_MAX,
}

public enum EInventoryTypes
{
  WEAP_AK103,
  WEAP_AI_MELEE_CRAWLER,
  WEAP_AI_MELEE_RIPPER,
  WEAP_AI_RANGE_LIBERTINE,
  WEAP_AI_EXPLODE_STUNNER,
  WEAP_AI_MELEE_TYRANT,
  WEAP_AI_CHARGE_TYRANT,
  WEAP_AI_RANGE_RIPPER,
  WEAP_AI_EXPLODE_GASSTUNNER,
  WEAP_ST10,
  WEAP_AI_MELEE_ZOMBIE,
  WEAP_AI_RANGE_ZOMBIE,
  WEAP_AI_EXPLODE_ZOMBIE,
  WEAP_AI_BREATH_ZOMBIE,
  WEAP_MAX,
}

public enum EGameClanBuffType
{
  EGameClanBuffType_None,
  EGameClanBuffType_LPRatio,
  EGameClanBuffType_ExpRatio,
  EGameClanBuffType_Max,
}

public enum EAILevel
{
  EAIL_PROBIE,
  EAIL_SOLDIER,
  EAIL_PRO,
  EAIL_GURU,
  EAIL_ALL,
  EAIL_MAX,
}

public enum EGFxChatType
{
  EGFxChat_Team,
  EGFxChat_All,
  EGFxChat_Clan,
  EGFxChat_Whisper,
  EGFxChat_None,
  EGFxChat_MAX,
}

public enum EEmblemType
{
  EEmblemType_None,
  EEmblemType_Normal,
  EEmblemType_PCRoom,
  EEmblemType_Challenge,
  EEmblemType_Spray_Cash,
  EEmblemType_Spray_Cash_Infinite,
  EEmblemType_Spray_Event,
  EEmblemType_Spray_Event_Infinite,
  EEmblemType_VIP,
  EEmblemType_MAX,
}

public enum EWaitAction
{
  WA_None,
  WA_SwitchToBestWeapon,
  WA_MAX,
}

public enum EClanHomeViewType
{
  EClanHomeViewType_UserTab,
  EClanHomeViewType_ManagerTab,
  EClanHomeViewType_Main,
  EClanHomeViewType_Chat,
  EClanHomeViewType_MAX,
}

public enum EMemberOutType
{
  EMemberOutType_MemberSelfOut,
  EMemberOutType_WaitPeopleSelfOut,
  EMemberOutType_WaitPeopleOut,
  EMemberOutType_MasterUseOut,
  EMemberOutType_MAX,
}

public enum eCAMOUSEFAIL
{
  CAMOUSEFAIL_OK,
  CAMOUSEFAIL_NOTARGET,
  CAMOUSEFAIL_OUTRANGE,
  CAMOUSEFAIL_MAX,
}

public enum ELobbySeasonType
{
  ELobbySeasonType_None,
  ELobbySeasonType_Spring,
  ELobbySeasonType_Summer,
  ELobbySeasonType_Autumn,
  ELobbySeasonType_Winter,
  ELobbySeasonType_MAX,
}

public enum ELOBBYPROPACTION
{
  ELOBBYPROPACTION_IDLE,
  ELOBBYPROPACTION_INVENIDLE,
  ELOBBYPROPACTION_SHOPBUY,
  ELOBBYPROPACTION_MATCHLOSE,
  ELOBBYPROPACTION_MATCHWIN,
  ELOBBYPROPACTION_NOBUY,
  ELOBBYPROPACTION_RANKUP,
  ELOBBYPROPACTION_MAX,
}

public enum EBUYALLTYPE
{
  EBUYALL_None,
  EBUYALL_Normal,
  EBUYALL_PurchaseGuide,
  EBUYALL_FEVERTIMEPAGE,
  EBUYALL_MAX,
}

public enum ERankType
{
  ERankType_None,
  ERankType_AllExp,
  ERankType_WinRoundRank,
  ERankType_KillRank,
  ERankType_AssistRank,
  ERankType_HeadShotRank,
  ERankType_None1,
  ERankType_None2,
  ERankType_BlastingRank,
  ERankType_SeizureRank,
  ERankType_EscapeRank,
  ERankType_ClanRank,
  ERankType_MAX,
}

public enum ESFUIDataProviderType
{
  ESFUIDataProviderType_Tutorial,
  ESFUIDataProviderType_Training,
  ESFUIDataProviderType_Beginner,
  ESFUIDataProviderType_MAX,
}

public enum ERTEType
{
  ERTEType_All,
  ERTEType_Map,
  ERTEType_GameMode,
  ERTEType_MAX,
}

public enum EventDataType
{
  EventData_Saved,
  EventData_Invalid,
  EventData_SavedWeapType,
  EventData_InvalidWeapType,
  EventData_MAX,
}

public enum EWeaponEffectState
{
  EWES_Reload,
  EWES_Kill,
  EWES_Equip,
  EWES_MAX,
}

public enum eGAMERULE
{
  GRULE_CONTINUE,
  GRULE_END,
  GRULE_REDEXTERM,
  GRULE_BLUEEXTERM,
  GRULE_ALLEXTERM,
  GRULE_LASTMAN,
  GRULE_UNKOWN,
  GRULE_MAX,
}

public enum EIFF
{
  EFOE_NONE,
  EFOE_FRIEND,
  EFOE_ENEMY,
  EFOE_MAX,
}

public enum eCOMBATREPORT
{
  CBRPT_NONE,
  CBRPT_ROUNDSTANDBY,
  CBRPT_DEADSHORTTIME,
  CBRPT_MAX,
}

public enum BUDDYFILTTER
{
  BF_NONE,
  BF_CODENAMESAME,
  BF_CODENAMENOCASE,
  BF_CODENAMEINSTR,
  BF_MAX,
}

public enum MGRNOTISTR
{
  MGRNOTISTR_NONE,
  MGRNOTISTR_REQBUDDY,
  MGRNOTISTR_ALREADYBAN,
  MGRNOTISTR_ALREADYBUDDYNOCN,
  MGRNOTISTR_NONEUSERNOCN,
  MGRNOTISTR_INVITEBUDDYFAIL,
  MGRNOTISTR_ACCEPTBUDDY,
  MGRNOTISTR_MAXBUDDYCNT,
  MGRNOTISTR_ALREADYBUDDY,
  MGRNOTISTR_YETSUPPORT,
  MGRNOTISTR_GETINVITEBUDDY,
  MGRNOTISTR_Q_DEL,
  MGRNOTISTR_DISCONNECTED,
  MGRNOTISTR_NEEDBUYITEM,
  MGRNOTISTR_INVITEDGAME,
  MGRNOTISTR_TOOSHORT,
  MGRNOTISTR_SELFINVITED,
  MGRNOTISTR_TOOLONG,
  MGRNOTISTR_AFTERRETRY,
  MGRNOTISTR_QUESTION_BLOCK,
  MGRNOTISTR_QUESTION_REMOVE_BLOCK,
  MGRNOTISTR_MAX,
}

public enum EInGameKickRes
{
  EInGameKick_VoteStart,
  EInGameKick_KickSuccess,
  EInGameKick_KickFail,
  EInGameKick_Yes,
  EInGameKick_No,
  EInGameKick_VoteRating,
  EInGameKick_VoteResult,
  EInGameKick_Err_NoTarget,
  EInGameKick_Err_OverUse,
  EInGameKick_Err_inVote,
  EInGameKick_Err_SelfKick,
  EInGameKick_Err_VoteCooltime,
  EInGameKick_Err_DisableMode,
  EInGameKick_Err_DisableChannel,
  EInGameKick_Err_NoInGameKickState,
  EInGameKick_Err_NoGRI,
  EInGameKick_Err_Bot,
  EInGameKick_Err_Voted,
  EInGameKick_Err_Disable,
  EInGameKick_Err_DisableInGameState,
  EInGameKick_Err_TargetQuit,
  EInGameKick_Err_LowMemberCount,
  EInGameKick_Err_NoBallot,
  EInGameKick_Err_NotTargetTeam,
  EInGameKick_Err_NeedSP,
  EInGameKick_Err_ProposerQuit,
  EInGameKick_MAX,
}

public enum EGripType
{
  EGT_NONE,
  EGT_VERTICAL,
  EGT_ANGLED,
  EGT_BIPOD,
  EGT_MAX,
}

public enum ESpecificSightType
{
  ESPT_FOLLOW,
  ESPT_SELF,
  ESPT_NONE,
  ESPT_MAX,
}

public enum EDotSight
{
  EDS_ACOG,
  EDS_AIMPOINT,
  EDS_FR,
  EDS_EOTECH,
  EDS_REFLEX,
  EDS_RW,
  EDS_OPEN,
  EDS_ROSESKULL,
  EDS_TARGETSEEKER,
  EDS_MINIDOT,
  EDS_BARRET,
  EDS_CHEYTAC,
  EDS_BENDER,
  EDS_DRAGUNOV,
  EDS_K14_WINTER,
  EDS_KAR98K,
  EDS_PM2,
  EDS_PM50,
  EDS_ZEIESS,
  EDS_PSG1,
  EDS_SR25,
  EDS_AWP,
  EDS_MAX,
}

public enum EVerticalGrip
{
  EVG_N900,
  EVG_REG,
  EVG_RVG,
  EVG_MAX,
}

public enum ESilencer
{
  EST_AR,
  EST_SMG_A,
  EST_SMG_B,
  EST_MG,
  EST_SR,
  EST_SR_C,
  EST_PISTOL,
  EST_MAX,
}

public enum ELaserPointer
{
  ELP_AR,
  ELP_SMG,
  ELP_SG,
  ELP_PST,
  ELP_AIMPOINT,
  ELP_MAX,
}

public enum EWeaponSightType
{
  EWST_RAIL,
  EWST_NO_RAIL,
  EWST_AK,
  EWST_NO_SIGHT,
  EWST_MAX,
}

public enum EWeaponPartsStat
{
  EWPS_DAMAGE,
  EWPS_RECOIL,
  EWPS_FIREINTERVAL,
  EWPS_ACCURACY,
  EWPS_DAMAGERANGE,
  EWPS_MAX,
}

public enum EReturnLobby
{
  EReturnLobby_None,
  EReturnLobby_WaitingRoom,
  EReturnLobby_MiniGameRoomList,
  EReturnLobby_MiniGameChannelList,
  EReturnLobby_SoloLeague,
  EReturnLobby_MAX,
}

public enum EGuideItemType
{
  EGuideItem_None,
  EGuideItem_Expired,
  EGuideItem_WillExpire,
  EGuideItem_GameMode,
  EGuideItem_Recommend,
  EGuideItem_MAX,
}

public enum EInGameStoreItemLogType
{
  EIGSILT_ETC,
  EIGSILT_Healing,
  EIGSILT_Stat,
  EIGSILT_Summon,
  EIGSILT_Weapon,
  EIGSILT_MAX,
}

public enum EHeroKillingWeaponLogType
{
  EHKWLT_Default,
  EHKWLT_Rifle,
  EHKWLT_SpecialWeapon,
  EHKWLT_MAX,
}

public enum EHeroVersion
{
  EHeroVersion_Season1,
  EHeroVersion_Season2,
  EHeroVersion_MAX,
}

public enum EInGameVoteState
{
  EIGKS_Default,
  EIGKS_Waiting,
  EIGKS_Accept,
  EIGKS_Refuse,
  EIGKS_MAX,
}

public enum ERandomRespawnType
{
  ERandomRespawnType_Default,
  ERandomRespawnType_AvoidSameTeam,
  ERandomRespawnType_MAX,
}

public enum EItemTypeCheck
{
  ETYPECHECK_DefaultItem,
  ETYPECHECK_Weapon,
  ETYPECHECK_ChatItem,
  ETYPECHECK_ModeItem,
  ETYPECHECK_GashaItem,
  ETYPECHECK_ClanItem,
  ETYPECHECK_TPExchangeIte,
  ETYPECHECK_MAX,
}

public enum ESpawnPointTypeMethod
{
  SPTM_AllNavPoint,
  SPTM_AllNavPointInCombatZone,
  SPTM_MAX,
}

public enum EMultiKillLevel
{
  EKill_None,
  EKill_Double,
  EKill_Multi,
  EKill_SpecialForce,
  EKill_MAX,
}

public enum EColorationType
{
  EColorationType_Default,
  EColorationType_PreRound,
  EColorationType_RoundEnd,
  EColorationType_Dead,
  EColorationType_KillCam,
  EColorationType_Hostmig,
  EColorationType_Stun,
  EColorationType_Beast,
  EColorationType_HeroDead,
  EColorationType_DronControll,
  EColorationType_Max,
}

public enum EMaterialEffectData
{
  EMaterialEffect_Flashbang,
  EMaterialEffect_Coloration,
  EMaterialEffect_Reserved,
  EMaterialEffect_Distortion,
  EMaterialEffect_MAX,
}

public enum ELadderBasisIndex
{
  ELadderBasis_Kill,
  ELadderBasis_Assist,
  ELadderBasis_Death,
  ELadderBasis_SpecialForce,
  ELadderBasis_Suicide,
  ELadderBasis_LuckyPoint,
  ELadderBasis_Critical,
  ELadderBasis_MAX,
}

public enum EClanPointBasisIndex
{
  ECPB_KillRate,
  ECPB_AssistRate,
  ECPB_MissionRate,
  ECPB_RoundWinRate,
  ECPB_MatchingRate,
  ECPB_MAX,
}

public enum EDirection
{
  DIR_Forward,
  DIR_Right,
  DIR_Backward,
  DIR_Left,
  DIR_MAX,
}

public enum ESkelControlRotation
{
  SKELROT_Normal,
  SKELROT_ForwardRight,
  SKELROT_BackwardRight,
  SKELROT_BackwardLeft,
  SKELROT_ForwardLeft,
  SKELROT_MAX,
}

public enum EBlendFallTypes
{
  FBT_JumpUp,
  FBT_JumpDown,
  FBT_JumpLand,
  FBT_Falling,
  FBT_None,
  FBT_MAX,
}

public enum ELobbyWeapAnimStep
{
  ELobbyWeapAnimStep_Idle,
  ELobbyWeapAnimStep_UnequipIdle,
  ELobbyWeapAnimStep_Ready,
  ELobbyWeapAnimStep_Inventory,
  ELobbyWeapAnimStep_ReadyToIdle,
  ELobbyWeapAnimStep_IdleToReady,
  ELobbyWeapAnimStep_WeaponChanged,
  ELobbyWeapAnimStep_IdleFromInventory,
  ELobbyWeapAnimStep_MAX,
}

public enum EPawnPosture
{
  PAWN_Standing,
  PAWN_Crouched,
  PAWN_Stunned,
  PAWN_MAX,
}

public enum EGlassDir
{
  EGD_Front,
  EGD_Back,
  EGD_FrontAndBack,
  EGD_MAX,
}

public enum EGlassState
{
  EGlassState_Default,
  EGlassState_Crack,
  EGlassState_Broken,
  EGlassState_MAX,
}

public enum EBuffBonusType
{
  EBuffBonusType_None,
  EBuffBonusType_AttackPoint,
  EBuffBonusType_AttackPointRatio,
  EBuffBonusType_DefencePoint,
  EBuffBonusType_DefencePointRatio,
  EBuffBonusType_MovePoint,
  EBuffBonusType_MovePointRatio,
  EBuffBonusType_HealthPoint,
  EBuffBonusType_HealthPointRatio,
  EBuffBonusType_BonusDamage,
  EBuffBonusType_BonusDamageRatio,
  EBuffBonusType_ReduceDamage,
  EBuffBonusType_ReduceDamageRatio,
  EBuffBonusType_BonusHealth,
  EBuffBonusType_BonusHealthRatio,
  EBuffBonusType_MoveSpeedRatio,
  EBuffBonusType_MAX,
}

public enum EDamageShakeState
{
  EDmgShake_None,
  EDmgShake_Slide,
  EDmgShake_Return,
  EDmgShake_MAX,
}

public enum EChallengeMedalType
{
  EChallengeMedalType_None,
  EChallengeMedalType_Bronze,
  EChallengeMedalType_Silver,
  EChallengeMedalType_Gold,
  EChallengeMedalType_MAX,
}

public enum EMeshCompositionType
{
  MESHCOMPOSITIONTYPE_COMPONENT,
  MESHCOMPOSITIONTYPE_MERGE,
  MESHCOMPOSITIONTYPE_MERGE_ONLYMESH,
  MESHCOMPOSITIONTYPE_BLEND,
  MESHCOMPOSITIONTYPE_MAX,
}

public enum EMeshGroup
{
  MESHGROUP_NONE,
  MESHGROUP_CHARACTER_BODY1,
  MESHGROUP_CHARACTER_BODY2,
  MESHGROUP_CHARACTER_HELMET,
  MESHGROUP_CHARACTER_1STVIEWHAND,
  MESHGROUP_WEAPON_1STVIEW,
  MESHGROUP_WEAPON_3RDVIEW,
  MESHGROUP_EXTRA,
  MESHGROUP_MAX,
}

public enum EPartResourceIndex
{
  EPartResourceIndex_Mesh,
  EPartResourceIndex_Material,
  EPartResourceIndex_Diffuse,
  EPartResourceIndex_Normal,
  EPartResourceIndex_Specular,
  EPartResourceIndex_Mask,
  EPartResourceIndex_Symbol_Mask,
  EPartResourceIndex_Pattern_Mask,
  EPartResourceIndex_MAX,
}

public enum EPartType
{
  PARTTYPE_CHAR_FACE,
  PARTTYPE_CHAR_GLASS,
  PARTTYPE_CHAR_SHEMAGH,
  PARTTYPE_CHAR_ARM,
  PARTTYPE_CHAR_WRIST,
  PARTTYPE_CHAR_PANTS1,
  PARTTYPE_CHAR_PANTS2,
  PARTTYPE_CHAR_PANTS3,
  PARTTYPE_CHAR_HAND,
  PARTTYPE_CHAR_CLANMARK,
  PARTTYPE_CHAR_LEVELMARK,
  PARTTYPE_CHAR_SHOUL2,
  PARTTYPE_CHAR_VEST1,
  PARTTYPE_CHAR_VEST2,
  PARTTYPE_CHAR_VEST3,
  PARTTYPE_CHAR_VEST4,
  PARTTYPE_CHAR_VEST5,
  PARTTYPE_CHAR_FOOT,
  PARTTYPE_CHAR_POUCH,
  PARTTYPE_CHAR_CANTEEN,
  PARTTYPE_CHAR_GASBAG,
  PARTTYPE_CHAR_MAGAZINE,
  PARTTYPE_CHAR_PANTS5,
  PARTTYPE_CHAR_SHOUL1,
  PARTTYPE_CHAR_HAIR,
  PARTTYPE_HELMET_BODY,
  PARTTYPE_HELMET_GOGGLE,
  PARTTYPE_HELMET_NSCOPE,
  PARTTYPE_HELMET_EARSET,
  PARTTYPE_HELMET_STRAP,
  PARTTYPE_1ST_ARM,
  PARTTYPE_1ST_HAND,
  PARTTYPE_1ST_WRIST,
  PARTTYPE_WEAPON_1ST_BODY,
  PARTTYPE_WEAPON_1ST_MAGAZINE,
  PARTTYPE_WEAPON_1ST_LASER,
  PARTTYPE_WEAPON_1ST_LIGHT,
  PARTTYPE_WEAPON_1ST_SILENCER,
  PARTTYPE_WEAPON_1ST_SCOPE,
  PARTTYPE_WEAPON_1ST_STOCK,
  PARTTYPE_WEAPON_1ST_GLAUNCHER,
  PARTTYPE_WEAPON_1ST_BARREL,
  PARTTYPE_WEAPON_1ST_TRIGGER,
  PARTTYPE_WEAPON_1ST_GRIP,
  PARTTYPE_WEAPON_3RD_BODY,
  PARTTYPE_WEAPON_3RD_MAGAZINE,
  PARTTYPE_WEAPON_3RD_LASER,
  PARTTYPE_WEAPON_3RD_LIGHT,
  PARTTYPE_WEAPON_3RD_SILENCER,
  PARTTYPE_WEAPON_3RD_SCOPE,
  PARTTYPE_WEAPON_3RD_STOCK,
  PARTTYPE_WEAPON_3RD_GLAUNCHER,
  PARTTYPE_WEAPON_3RD_BARREL,
  PARTTYPE_WEAPON_3RD_TRIGGER,
  PARTTYPE_WEAPON_3RD_GRIP,
  PARTTYPE_HELMET_CLANMARK,
  PARTTYPE_HELMET_LEVELMARK,
  PARTTYPE_HELMET_HAIR,
  PARTTYPE_WEAPON_1ST_CODETAG,
  PARTTYPE_CHAR_VEST_CLANMARK1,
  PARTTYPE_CHAR_VEST_CLANMARK2,
  PARTTYPE_MAX,
}

public enum EPendingItemType
{
  PENDING_NONE,
  PENDING_CHARACTER,
  PENDING_WEAPON,
  PENDING_MAX,
}

public enum ECustomZoomState
{
  ZS_Stop,
  ZS_ZoomIn,
  ZS_ZoomOut,
  ZS_ZoomInStep,
  ZS_ZoomOutStep,
  ZS_MAX,
}

public enum EMoverType
{
  MT_CustomPreview,
  MT_Camera,
  MT_MAX,
}

public enum EMergedTextureType
{
  MERGEDTEXTURETYPE_DIFFUSE,
  MERGEDTEXTURETYPE_NORMAL,
  MERGEDTEXTURETYPE_SPECULAR,
  MERGEDTEXTURETYPE_MASK,
  MERGEDTEXTURETYPE_MAX,
}

public enum ETextureType
{
  TEX_DIFFUSE,
  TEX_NORMAL,
  TEX_SPECULAR,
  TEX_MASK,
  TEX_MAX,
}

public enum EPatternColorsType
{
  PATTERNCOLORSTYPE_EPAULET,
  PATTERNCOLORSTYPE_BACKGROUND,
  PATTERNCOLORSTYPE_NONE,
  PATTERNCOLORSTYPE_MAX,
}

public enum EWeaponStateDataPickUpType
{
  EWSDT_Random,
  EWSDT_InOrder,
  EWSDT_MAX,
}

public enum EWeaponHoldType
{
  EWHT_RIGHT,
  EWHT_LEFT,
  EWHT_BOTH,
  EWHT_MAX,
}

public enum EPreviewType
{
  PVT_FULL,
  PVT_MAX,
}

public enum EFacebookUploadEvent
{
  EFacebookUploadEvent_Interlock,
  EFacebookUploadEvent_CodeNameChange,
  EFacebookUploadEvent_Promote,
  EFacebookUploadEvent_RareGashaReward,
  EFacebookUploadEvent_ClanCreate,
  EFacebookUploadEvent_ClanMatchWin,
  EFacebookUploadEvent_MAX,
}

public enum LastFlagAction
{
  eNone,
  eDropped,
  eReturned,
  eTaken,
  eCaptured,
  LastFlagAction_MAX,
}

public enum EPenetrateType
{
  Penetrate_Normal,
  Penetrate_Always,
  Penetrate_Never,
  Penetrate_MAX,
}

public enum eGameStateMessageType
{
  eGameStateMessageType_Deffend,
  eGameStateMessageType_Attack,
  eGameStateMessageType_MAX,
}

public enum EBGTEXType
{
  EBGTEX_FILL,
  EBGTEX_ORG,
  EBGTEX_FULLAll,
  EBGTEX_FULLClip,
  EBGTEX_MAX,
}

public enum EChatComboType
{
  EChatCombo_Normal,
  EChatCombo_Clan,
  EChatCombo_MAX,
}

public enum EShopPart
{
  EShop_Weapon,
  EShop_Equip,
  EShop_FuncItem,
  EShop_ModeItem,
  EShop_HotAndNewItem,
  EShop_FeverItem,
  EShop_MAX,
}

public enum ERapairDialog_BtnType
{
  ERapairDialog_BtnType_OK,
  ERapairDialog_BtnType_Cancel,
  ERapairDialog_BtnType_Close,
  ERapairDialog_BtnType_Coupon_OK,
  ERapairDialog_BtnType_MAX,
}

public enum eEventPart
{
  eEventPart_EVENT,
  eEventPart_GIFT,
  eEventPart_MAX,
}

public enum ETabCategory
{
  ENUM_TAB_CLAN,
  ENUM_TAB_FRIEND,
  ENUM_TAB_MAX,
}

public enum ERewardMessage
{
  EReward_Challenge,
  EReward_Package,
  EReward_Coupon,
  EReward_GiftUse,
  EReward_PromoEvent,
  EReward_GashaBonus,
  EReward_ModeReward,
  EReward_SerialReward,
  EReward_MAX,
}

public enum EGashaGraphType
{
  EGashaGraphType_Normal,
  EGashaGraphType_ALLInOne,
  EGashaGraphType_PVE,
  EGashaGraphType_SP,
  EGashaGraphType_ALLInOnePVE,
  EGashaGraphType_Zombie,
  EGashaGraphType_Disable,
  EGashaGraphType_Hexa,
  EGashaGraphType_SpyMode,
  EGashaGraphType_16VS16,
  EGashaGraphType_MAX,
}

public enum EClanJoinDlgWidgetType
{
  EClanJoinDlgWidgetType_TextInput0,
  EClanJoinDlgWidgetType_TextInput1,
  EClanJoinDlgWidgetType_TextInput2,
  EClanJoinDlgWidgetType_TextInput3,
  EClanJoinDlgWidgetType_MAX,
}

public enum EClanMakeTextAni
{
  EClanMakeTextAni_Find,
  EClanMakeTextAni_Error,
  EClanMakeTextAni_Success,
  EClanMakeTextAni_MoreChar,
  EClanMakeTextAni_Filtering,
  EClanMakeTextAni_MAX,
}

public enum EClanMakeText
{
  EClanMakeText_Name,
  EClanMakeText_Address,
  EClanMakeText_Intro,
  EClanMakeText_MAX,
}

public enum ERoomType
{
  ERoom_Gaming,
  ERoom_Party,
  ERoom_Pending,
  ERoom_Matching,
  ERoom_NoType,
  ERoom_MAX,
}

public enum EGameReult
{
  EGameResult_All,
  EGameResult_Me,
  EGameResult_MAX,
}

public enum EHeroGameResultPage
{
  EHeroGameResultPage_All,
  EHeroGameResultPage_Statistics,
  EHeroGameResultPage_MAX,
}

public enum EInGameStoreSlotType
{
  EIGSSlotType_PVE,
  EIGSSlotType_Hero_Green,
  EIGSSlotType_Hero_Blue,
  EIGSSlotType_Hero_Brown,
  EIGSSlotType_MAX,
}

public enum EMagazinUpItemUsability
{
  EMUIUS_None,
  EMUIUS_UnUsable,
  EMUIUS_Usable,
  EMUIUS_MAX,
}

public enum EIngameShopItemDisplayType
{
  EIngameShopItemDisplayType_None,
  EIngameShopItemDisplayType_WeaponType,
  EIngameShopItemDisplayType_MAX,
}

public enum ECommentFilterMessage
{
  ECommentFilterMessage_Search,
  ECommentFilterMessage_Unusable,
  ECommentFilterMessage_Usable,
  ECommentFilterMessage_Limit,
  ECommentFilterMessage_MAX,
}

public enum ESysSettingPart
{
  ESysSetting_VIDEO,
  ESysSetting_CONTROLL,
  ESysSetting_AUDIO,
  ESysSetting_CAPTURE,
  ESysSetting_RECORD,
  ESysSetting_Whisper,
  ESysSetting_MAX,
}

public enum E_TAG_TYPE
{
  E_TAG_TYPE_NONE,
  E_TAG_TYPE_LOCAL,
  E_TAG_TYPE_HIGHSCHOOL,
  E_TAG_TYPE_FREETEXT,
  E_TAG_TYPE_MAX,
}

public enum ETagState
{
  ETagState_None,
  ETagState_Wrong,
  ETagState_AllRight,
  ETagState_MAX,
}

public enum ClanMakrLayerType
{
  ClanMakrLayerType_Layer1,
  ClanMakrLayerType_Layer2,
  ClanMakrLayerType_Layer3,
  ClanMakrLayerType_Max,
}

public enum eBoxType
{
  eBoxType_0,
  eBoxType_1,
  eBoxType_2,
  eBoxType_MAX,
}

public enum EItemType
{
  EIT_NONE,
  EIT_CHAR,
  EIT_WEAP,
  EIT_WEAP_OPTION,
  EIT_FUNCTIONAL,
  EIT_MAX,
}

public enum EGameModeDispType
{
  EGameModeDisp_None,
  EGameModeDisp_New,
  EGameModeDisp_Hot,
  EGameModeDisp_Easy,
  EGameModeDisp_Hard,
  EGameModeDisp_MAX,
}

public enum EForceExitType
{
  EForceExit_None,
  EForceExit_NoConnect,
  EForceExit_Disconnect,
  EForceExit_NoLogin,
  EForceExit_ByGM,
  EForceExit_NoPingPong,
  EForceExit_SameUser,
  EForceExit_ShutDownLaw,
  EForceExit_TCProtectError_LoadDLL,
  EForceExit_TCProtectError_CheckHack,
  EForceExit_WaitingTimeOut,
  EForceExit_MAX,
}

public enum EAspectRatioType
{
  EAspectRatio_0403,
  EAspectRatio_1610,
  EAspectRatio_1609,
  EAspectRatio_None,
  EAspectRatio_MAX,
}

public enum EClanMsgPacketType
{
  EClanMsgPacketType_JoinOk,
  EClanMsgPacketType_MyClanJoinOk,
  EClanMsgPacketType_JoinNo,
  EClanMsgPacketType_NotifyClanJoin,
  EClanMsgPacketType_MemberOut,
  EClanMsgPacketType_DestroyClan,
  EClanMsgPacketType_NotifyMemberLogin,
  EClanMsgPacketType_NotifyResultClanWar,
  EClanMsgPacketType_GiveMaster,
  EClanMsgPacketType_NotifyChangeClanName,
  EClanMsgPacketType_NotifyChangeCodeName,
  EClanMsgPacketType_SelfRefresh,
  EClanMsgPacketType_MakeClan,
  EClanMsgPacketType_LevelChange,
  EClanMsgPacketType_NotifyRemoveClan,
  EClanMsgPacketType_NotifyChangeClanMark,
  EClanMsgPacketType_MAX,
}

public enum ESFHUDHeadUpUIStats
{
  STAT_EnemyTeam,
  STAT_SameTeam,
  STAT_ShooterMine,
  STAT_ShooterSameTeam,
  STAT_ShooterAI,
  STAT_ShooterBossAI,
  STAT_MAX,
}

public enum ECombatMsgColor
{
  ECombatMsgColor_RED,
  ECombatMsgColor_BLUE,
  ECombatMsgColor_GRAY,
  ECombatMsgColor_MAX,
}

public enum EMessageDisplayType
{
  EMsgDispType_SystemNotice,
  EMsgDispType_Kill,
  EMsgDispType_ScoreUp,
  EMsgDispType_GameSystem,
  EMsgDispType_Action,
  EMsgDispType_GameState,
  EMsgDispType_Max,
}

public enum ETimerType
{
  ETimerType_SEC,
  ETimerType_CENTISEC,
  ETimerType_WHITESEC,
  ETimerType_MAX,
}

public enum EConditionIcon
{
  EConditionIcon_None,
  EConditionIcon_UP,
  EConditionIcon_Down,
  EConditionIcon_Normal,
  EConditionIcon_MAX,
}

public enum EQuestingType
{
  EQuestingType_LowSp,
  EQuestingType_Normal,
  EQuestingType_LowSpRepairFail,
  EQuestingType_RepairOk,
  EQuestingType_MaxDurability,
  EQuestingType_MaxDurabilityError,
  EQuestingType_MaxRepairOk,
  EQuestingType_LowSpRepairAllFail,
  EQuestingType_LowSpAndLowCoupon,
  EQuestingType_LogCouponFail,
  EQuestingType_MAX,
}

public enum EAlbumPart
{
  EAlbum_Screenshot,
  EAlbum_TwitchTV,
  EAlbum_MAX,
}

public enum ERBtnMenu
{
  ERBtnMenu_ChangeRoomMaster,
  ERBtnMenu_AddBuddy,
  ERBtnMenu_KickOut,
  ERBtnMenu_ClanHome,
  ERBtnMenu_ClanInvite,
  ERBtnMenu_ClanRecommend,
  ERBtnMenu_MAX,
}

public enum ERoomSort
{
  ERoomSort_Number,
  ERoomSort_Name,
  ERoomSort_Players,
  ERoomSort_State,
  ERoomSort_Mode,
  ERoomSort_Map,
  ERoomSort_Enable,
  ERoomSort_FastRun,
  ERoomSort_MAX,
}

public enum eCHNModuleState
{
  eCHNModuleState_None,
  eCHNModuleState_CodeImage,
  eCHNModuleState_MatrixImage,
  eCHNModuleState_Login,
  eCHNModuleState_MAX,
}

public enum EClanPart
{
  EClanPart_Home,
  EClanPart_List,
  EClanPart_Rank,
  EClanPart_MAX,
}

public enum EClanLeagueMainTab
{
  EClanLeagueMainTab_MyClan,
  EClanLeagueMainTab_ClanRank,
  EClanLeagueMainTab_PersonalRank,
  EClanLeagueMainTab_RewardGuide,
  EClanLeagueMainTab_LeagueGuide,
  EClanLeagueMainTab_MAX,
}

public enum EClanLeagueSubTab
{
  EClanLeagueSubTab_ClanInfo,
  EClanLeagueSubTab_PersonalInfo,
  EClanLeagueSubTab_MAX,
}

public enum EShowClanLeagueListType
{
  EShowClanLeagueListType_NONE,
  EShowClanLeagueListType_MyClanList,
  EShowClanLeagueListType_MyClanMemberList,
  EShowClanLeagueListType_ClanList,
  EShowClanLeagueListType_PersonalList,
  EShowClanLeagueListType_RewardGuide,
  EShowClanLeagueListType_LeagueGuide,
  EClanLeagueMainTab_PunishmentGuide,
  EShowClanLeagueListType_MAX,
}

public enum ECombineDialogState
{
  ECombineDialogState_None,
  ECombineDialogState_Open,
  ECombineDialogState_PacketSend,
  ECombineDialogState_AniStart,
  ECombineDialogState_AniEnd,
  ECombineDialogState_MAX,
}

public enum EModeItemSlot
{
  EModeItemSlot_Active_1,
  EModeItemSlot_Active_2,
  EModeItemSlot_Active_3,
  EModeItemSlot_Passive_1,
  EModeItemSlot_Passive_2,
  EModeItemSlot_Passive_3,
  EModeItemSlot_MAX,
}

public enum ECommunityNoBuddy
{
  ECommunityNoBuddy_NoTag,
  ECommunityNoBuddy_NoTagMatch,
  ECommunityNoBuddy_MaxBuddy,
  ECommunityNoBuddy_MAX,
}

public enum ECreateCodenameResultTYPE
{
  ECCRES_CHECKING,
  ECCRES_ALREADYUSING,
  ECCRES_REGISTBTN,
  ECCRES_MORECHAR,
  ECCRES_MAX,
}

public enum EFeverTimeMainTab
{
  EFeverTimeMainTab_FeverGuide,
  EFeverTimeMainTab_FeverProgress,
  EFeverTimeMainTab_FeverOrgel,
  EFeverTimeMainTab_FeverSale,
  EFeverTimeMainTab_MAX,
}

public enum EFeverTimeSubTab
{
  EFeverTimeSubTab_FeverProgress,
  EFeverTimeSubTab_FeverAdditionalReward,
  EFeverTimeSubTab_MAX,
}

public enum EShowFeverDisplayType
{
  EShowFeverDisplayType_NONE,
  EShowFeverDisplayType_FeverGuide,
  EShowFeverDisplayType_FeverProgress,
  EShowFeverDisplayType_FeverAdditionalReward,
  EShowFeverDisplayType_FeverOrgel,
  EShowFeverDisplayType_FeverSale,
  EShowFeverDisplayType_MAX,
}

public enum EFeverProgressInfoType
{
  EFeverProgressInfoType_Image,
  EFeverProgressInfoType_Text,
  EFeverProgressInfoType_MAX,
}

public enum EEnterEventType
{
  EEnterEventType_None,
  EEnterEventType_OpenBallPopup,
  EEnterEventType_CloseRewardPopup,
  EEnterEventType_SkipAnimation,
  EEnterEventType_OpenBallProgress,
  EEnterEventType_OpenCutscene,
  EEnterEventType_MAX,
}

public enum EClearListType
{
  AllList,
  ToolTipList,
  GachaList,
  EClearListType_MAX,
}

public enum EInvenPart
{
  EInven_Weapon,
  EInven_Equip,
  EInven_FuncItem,
  EInven_ModeItem,
  EInven_Recycle,
  EInven_PMCItem,
  EInven_MAX,
}

public enum eOpendBuddyNotice
{
  EOBN_None,
  EOBN_inputBuddyName,
  EOBN_AddBuddy,
  EOBN_invitedBuddy,
  EOBN_Error,
  EOBN_findProfile,
  EOBN_Disconnected,
  EOBN_DelBuddy,
  EOBN_NeedBuy,
  EOBN_BlockBuddy,
  EOBN_RemoveBlockBuddy,
  EOBN_DelBuddyWithBlock,
  EOBN_MAX,
}

public enum EMsgrNotice
{
  EMsgrNotice_Gift,
  EMsgrNotice_PlayTime,
  EMsgrNotice_InviteBuddy,
  EMsgrNotice_DeleteBuddy,
  EMsgrNotice_InviteGame,
  EMsgrNotice_BlockBuddy,
  EMsgrNotice_NoBlockBuddy,
  EMsgrNotice_WeeklyClanRank,
  EMsgrNotice_ClanRecommen,
  EMsgrNotice_NONE,
  EMsgrNotice_MAX,
}

public enum eFiringRangeScoreWeaponType
{
  eFiringRangeScoreWeaponType_AR,
  eFiringRangeScoreWeaponType_SR,
  eFiringRangeScoreWeaponType_SW,
  eFiringRangeScoreWeaponType_MAX,
}

public enum eFiringRangeSubTabType
{
  eFiringRangeSubTabType_Type,
  eFiringRangeSubTabType_Friend,
  eFiringRangeSubTabType_Clan,
  eFiringRangeSubTabType_MAX,
}

public enum eFiringRangeTabType
{
  eFiringRangeTabType_AR,
  eFiringRangeTabType_SR,
  eFiringRangeTabType_SW,
  eFiringRangeTabType_MAX,
}

public enum EMyInfoPart
{
  EMyInfo_Profile,
  EMyInfo_WeaponLog,
  EMyInfo_Challenge,
  EMyInfo_Vip,
  EMyInfo_VipMapRotation,
  EMyInfo_MonthlyReward,
  EMyInfo_MAX,
}

public enum HotNewShowDispType
{
  HotNewShowDispType_NONE,
  HotNewShowDispType_HOTNEW,
  HotNewShowDispType_FeverOn,
  HotNewShowDispType_FeverOff,
  HotNewShowDispType_MAX,
}

public enum ESoloLeagueMainTab
{
  ESoloLeagueMainTab_Notice,
  ESoloLeagueMainTab_Rank,
  ESoloLeagueMainTab_MAX,
}

public enum EShowSoloLeagueListType
{
  EShowSoloLeagueListType_None,
  EShowSoloLeagueListType_Notice,
  EShowSoloLeagueListType_Rank,
  EShowSoloLeagueListType_MAX,
}

public enum EIntroVideoType
{
  EIntroVideo_Video,
  EIntroVideo_Image,
  EIntroVideo_MAX,
}

public enum EUserListType
{
  EUserListType_UnLock,
  EUserListType_Lock,
  EUserListType_Observer,
  EUserListType_MAX,
}

public enum EPVEListType
{
  EPVEListType_None,
  EPVEListType_Lock,
  EPVEListType_UnLock,
  EPVEListType_MAX,
}

public enum EOnOff
{
  On,
  Off,
  CHECKBOX_COUNT,
  EOnOff_MAX,
}

public enum EAlbumState
{
  EAlbumState_None,
  EAlbumState_View,
  EAlbumState_Rename,
  EAlbumState_MAX,
}

public enum eEventType
{
  EventType_NONE,
  EventType_EVENT,
  EventType_MAX,
}

public enum EventState
{
  EventState_None,
  EventState_Clear,
  EventState_Waiting,
  EventState_Progress,
  EventState_MAX,
}

public enum EClanOptionType
{
  EClanOptionType_Age,
  EClanOptionType_Sex,
  EClanOptionType_Position,
  EClanOptionType_PlayType,
  EClanOptionType_ConnectTime,
  EClanOptionType_VoiceTalk,
  EClanOptionType_NickChange,
  EClanOptionType_MAX,
}

public enum EClanMemberSortType
{
  EClanMemberSortType_Check,
  EClanMemberSortType_Rank,
  EClanMemberSortType_UserImage,
  EClanMemberSortType_CodeName,
  EClanMemberSortType_GameCount,
  EClanMemberSortType_Level,
  EClanMemberSortType_RegDate,
  EClanMemberSortType_MAX,
}

public enum ClanBtnShowType
{
  ClanBtnShowType_Master,
  ClanBtnShowType_Manager,
  ClanBtnShowType_Normal,
  ClanBtnShowType_WaitMember,
  ClanBtnShowType_NotMember,
  ClanBtnShowType_CreateClan,
  ClanBtnShowType_MAX,
}

public enum EClanHomeListType
{
  EClanHomeListType_MemberList,
  EClanHomeListType_WaitPeopleLIst,
  EClanHomeListType_MAX,
}

public enum ESubTabType
{
  ESubTabType_Notice,
  ESubTabType_ClanInfo,
  ESubTabType_RecentRecord,
  ESubTabType_MonthlyRecord,
  ESubTabType_ClanMember,
  ESubTabType_JoinWaitMember,
  ESubTabType_MAX,
}

public enum EClanNotifyWarningMsg
{
  EClanNotifyWarningMsg_MemberOut,
  EClanNotifyWarningMsg_GiveMaster,
  EClanNotifyWarningMsg_MAX,
}

public enum EClanManagerTab
{
  EClanManagerTab_MemberList,
  EClanManagerTab_WaitPeopleLIst,
  EClanManagerTab_Destroy,
  EClanManagerTab_MAX,
}

public enum EClanManagerMsg
{
  EClanManagerMsg_Destroy,
  EClanManagerMsg_MemberOut,
  EClanManagerMsg_GiveMaster,
  EClanManagerMsg_MAX,
}

public enum EClanListType
{
  EClanListType_ClanPoint,
  EClanListType_Member,
  EClanListType_RegDate,
  EClanListType_Monthly,
  EClanListType_Search,
  EClanListType_Recommend,
  EClanListType_MAX,
}

public enum EListSubTabType
{
  EListSubTabType_ClanList,
  EListSubTabType_InviteList,
  EListSubTabType_MAX,
}

public enum ERankSubTabType
{
  ERankSubTabType_ThisWeek,
  ERankSubTabType_LastWeek,
  ERankSubTabType_MAX,
}

public enum EClanUserTab
{
  EClanUserTab_MemberList,
  EClanUserTab_WaitPeopleList,
  EClanUserTab_MAX,
}

public enum ELobbyRank
{
  ELobbyRank_WeeklyClanRank,
  ELobbyRank_PCRoomUserRank,
  ELobbyRank_MAX,
}

public enum EResultStatisticsType
{
  EResultST_Seperator,
  EResultST_Kill_ByRifle,
  EResultST_Kill_BySpecialWeapon,
  EResultST_Kill_ByDefaultWeapon,
  EResultST_Death,
  EResultST_Assist,
  EResultST_DamageToEnemy,
  EResultST_BackAttackToEnemy,
  EResultST_DamageByEnemy,
  EResultST_BackAttackByEnemy,
  EResultST_DamageToTower,
  EResultST_GainModeMoney,
  EResultST_SpendForWeapon,
  EResultST_SpendForStat,
  EResultST_SpendForHealing,
  EResultST_SpendForSummon,
  EResultST_SpendForEtc,
  EResultST_DestroyedTurrets,
  EResultST_DestroyedTowers,
  EResultST_CS,
  EResultST_NeutralCS,
  EResultST_CriticalCS,
  EResultST_MAX,
}

public enum EInvenPMCSubTab
{
  EInvenPMCSubTab_Equp,
  EInvenPMCSubTab_Character,
  EInvenPMCSubTab_MAX,
}

public enum EMyInfoChallengeSubTab
{
  EMyInfoChallengeSubTab_Progress,
  EMyInfoChallengeSubTab_Complete,
  EMyInfoChallengeSubTab_MAX,
}

public enum EGiftSubTab
{
  ENUM_SUBTAB_RECEIVED,
  ENUM_SUBTAB_SEND,
  ENUM_SUBTAB_MAX,
}

public enum EShopItemListSeperator
{
  EShopItemListSeperator_None,
  EShopItemListSeperator_AlreadyHave,
  EShopItemListSeperator_Special,
  EShopItemListSeperator_Normal,
  EShopItemListSeperator_MAX,
}

public enum EChkBlockWhisperType
{
  EChkBlockWhisperType_All,
  EChkBlockWhisperType_General,
  EChkBlockWhisperType_Friend,
  EChkBlockWhisperType_ClanMember,
  EChkBlockWhisperType_MAX,
}

public enum EOverTimeCheckType
{
  EOverTimeCheck_BlueWin,
  EOverTimeCheck_RedWin,
  EOverTimeCheck_CompareScore,
  EOverTimeCheck_MAX,
}

public enum ModeStatApplyType
{
  EModeStatApplyType_None,
  EModeStatApplyType_PlayerOnly,
  EModeStatApplyType_PlayerAndPetOnly,
  EModeStatApplyType_All,
  EModeStatApplyType_MAX,
}

public enum InGameStorePurchaseStat
{
  IGSPS_DEFAULT,
  IGSPS_CURRENT,
  IGSPS_MAX,
}

public enum eRandomBoxType
{
  A_TYPE,
  B_TYPE,
  C_TYPE,
  D_TYPE,
  E_TYPE,
  F_TYPE,
  G_TYPE,
  H_TYPE,
  I_TYPE,
  SPECIAL_TYPE,
  eRandomBoxType_MAX,
}

public enum ECookingVariableType
{
  COOKINGVARIABLETYPE_UnSet,
  COOKINGVARIABLETYPE_Include,
  COOKINGVARIABLETYPE_Exclude,
  COOKINGVARIABLETYPE_ExcludeCauseLightnessCheck,
  COOKINGVARIABLETYPE_MAX,
}

public enum EAILogCondition
{
  AILC_None,
  AILC_STATE,
  AILC_LOOP,
  AILC_COMBAT,
  AILC_COVER,
  AILC_MOVE,
  AILC_SCRIPTED,
  AILC_ROUTE,
  AILC_COMBATZONE,
  AILC_ENEMY,
  AILC_WEAPON,
  AILC_WARNING,
  AILC_MAX,
}

public enum ELogColor
{
  COLOR_BLACK,
  COLOR_DARK_RED,
  COLOR_DARK_GREEN,
  COLOR_DARK_BLUE,
  COLOR_DARK_YELLOW,
  COLOR_DARK_CYAN,
  COLOR_DARK_PURPLE,
  COLOR_DARK_WHITE,
  COLOR_RED,
  COLOR_GREEN,
  COLOR_BLUE,
  COLOR_YELLOW,
  COLOR_CYAN,
  COLOR_PURPLE,
  COLOR_WHITE,
  COLOR_MAX,
}

public enum ELogCondition
{
  LC_None,
  LC_MCSTEP,
  LC_MCWARN,
  LC_TUTORIAL,
  LC_Mission,
  LC_Halo8,
  LC_olo,
  LC_Junno1,
  LC_ssh,
  LC_MAX,
}

public enum ImpactEffect_Type
{
  Hit_BulletMicro,
  Hit_BulletMiddle,
  Hit_BulletBig,
  Hit_HandGrenade,
  Hit_KNife,
  Hit_Knife_Throw,
  Hit_Arrow,
  Hit_Snowball,
  Hit_ToyHammer,
  Hit_MetalHammer,
  Hit_Electronic,
  Hit_Flame,
  Hit_Breath,
  Explo_Smoke,
  Explo_Gas,
  Explo_Frag,
  Explo_FBang,
  Explo_Libertine_Sputum,
  Explo_Ripper_Sputum,
  AlienSpawnSmall,
  AlienSpawnMiddle,
  AlienSpawnBig,
  ImpactEffect_Type_MAX,
}

public enum EAsyncRequestType
{
  RequestType_Mesh,
  RequestType_Material,
  RequestType_Texture_SymbolCamo,
  RequestType_Texture_SymbolMask,
  RequestType_Texture_PatternCamo,
  RequestType_Texture_PatternMask,
  RequestType_Texture_WeaponCamo,
  RequestType_Texture_Diffuse,
  RequestType_Texture_Normal,
  RequestType_Texture_Specular,
  RequestType_Texture_Mask,
  RequestType_MAX,
}

public enum EMeshBlendingSchedulerState
{
  MESHBLENDINGSCHEDULER_NONE,
  MESHBLENDINGSCHEDULER_SLEEP,
  MESHBLENDINGSCHEDULER_WAKEUP,
  MESHBLENDINGSCHEDULER_WORKING,
  MESHBLENDINGSCHEDULER_MAX,
}

public enum ESF2InfoURL
{
  ESF2Info_GetClan,
  ESF2Info_ApplyClan,
  ESF2Info_CheckDuplication,
  ESF2Info_CreateClan,
  ESF2Info_UpdateClan,
  ESF2Info_GetClanList,
  ESF2Info_GetClanMember,
  ESF2Info_UpdateLevel,
  ESF2Info_SearchClan,
  ESF2Info_RemoveMember,
  ESF2Info_GiveMaster,
  ESF2Info_CloseClan,
  ESF2Info_InsertClanNote,
  ESF2Info_RemoveClanNote,
  ESF2Info_GetClanNoteList,
  ESF2Info_GetClanMemberList,
  ESF2Info_GetClanWarListList,
  ESF2Info_GetArmsPlayList,
  ESF2Info_AcceptMember,
  ESF2Info_CommunityBoardsNew,
  ESF2Info_CommunityBoardsDelete,
  ESF2Info_CommunityBoardsList,
  ESF2Info_CommunityBoardsFeedback,
  ESF2Info_CommunityRecommandFriend,
  ESF2Info_CommunityBoardsUnRead,
  ESF2Info_CommunityBoardsFeedbackFrom,
  ESF2Info_GetClanInventoryList,
  ESF2Info_GetClanRankTop60Monthly,
  ESF2Info_GetClanRankLast6Months,
  ESF2Info_GetClanRecommendList,
  ESF2Info_RemoveClanRecommend,
  ESF2Info_GetLeagueMyClanRank,
  ESF2Info_GetLeagueMyClanUserRank,
  ESF2Info_GetLeagueSeasonClanRank,
  ESF2Info_GetLeagueSeasonClanUserRank,
  ESF2Info_GetFiringRangeScoreRank,
  ESF2Info_Get1VS1ModeUserRank,
  ESF2Info_GetSoloLeagueRank,
  ESF2Info_MAX,
}

public enum sf2_m
{
  reqGet,
  reqPost,
  reqPut,
  reqDelete,
  sf2_m_MAX,
}

public enum EResistanceMethod
{
  EResistanceMethod_Velocity,
  EResistanceMethod_VelocitySqr,
  EResistanceMethod_MAX,
}

public enum EServePartEvents
{
  ESPE_None,
  ESPE_LimitedPeriod,
  ESPE_MAX,
}

public enum ERocketEffectType
{
  EEffectAllRemove,
  EJumpEffect,
  EBoostEffect,
  ELandingEffect,
  EHoverEffect,
  ERocketEffectType_MAX,
}

public enum EProtectiveEquipment
{
  PRCT_Distance,
  PRCT_Minimum,
  PRCT_Maximum,
  PRCT_MAX,
}

public enum EPawnHitType
{
  EPawnHitType_Normal,
  EPawnHitType_Head,
  EPawnHitType_Helmet,
  EPawnHitType_MAX,
}

public enum EDigitalButtonActions
{
  DBA_None,
  DBA_Fire,
  DBA_AltFire,
  DBA_Reload,
  DBA_ExigencyAttack,
  DBA_Jump,
  DBA_Use,
  DBA_ToggleMelee,
  DBA_ShowScores,
  DBA_ShowMap,
  DBA_FeignDeath,
  DBA_ToggleSpeaking,
  DBA_ToggleMinimap,
  DBA_WeaponPicker,
  DBA_NextWeapon,
  DBA_BestWeapon,
  DBA_PrevWeapon,
  DBA_LatestWeapon,
  DBA_Duck,
  DBA_MoveForward,
  DBA_MoveBackward,
  DBA_StrafeLeft,
  DBA_StrafeRight,
  DBA_Walk,
  DBA_Sprint,
  DBA_TurnLeft,
  DBA_TurnRight,
  DBA_SwitchWeapon1,
  DBA_SwitchWeapon2,
  DBA_SwitchWeapon3,
  DBA_SwitchWeapon4,
  DBA_SwitchWeapon5,
  DBA_SwitchWeapon6,
  DBA_SwitchWeapon7,
  DBA_SwitchWeapon8,
  DBA_SwitchWeapon9,
  DBA_SwitchWeapon10,
  DBA_ShrinkHUD,
  DBA_GrowHUD,
  DBA_Taunt,
  DBA_Taunt2,
  DBA_Talk,
  DBA_TeamTalk,
  DBA_ShowCommandMenu,
  DBA_ShowMenu,
  DBA_JumpPC,
  DBA_BestWeaponPC,
  DBA_Horn,
  DBA_InGameChat,
  DBA_ShowScoreBoard,
  DBA_ShowRadioMsgMission,
  DBA_ShowRadioMsgCommunity,
  DBA_ShowRadioMsgCommand,
  DBA_Spray,
  DBA_Recall,
  DBA_MissionPingAttack,
  DBA_MissionPingRetreat,
  DBA_TurnBack,
  DBA_HoldZoom,
  DBA_FreeCam,
  DBA_MAX,
}

public enum ESFBindableKeys
{
  SFBND_Unbound,
  SFBND_MouseX,
  SFBND_MouseY,
  SFBND_MouseScrollUp,
  SFBND_MouseScrollDown,
  SFBND_LeftMouseButton,
  SFBND_RightMouseButton,
  SFBND_MiddleMouseButton,
  SFBND_ThumbMouseButton,
  SFBND_ThumbMouseButton2,
  SFBND_BackSpace,
  SFBND_Tab,
  SFBND_Enter,
  SFBND_Pause,
  SFBND_CapsLock,
  SFBND_Escape,
  SFBND_SpaceBar,
  SFBND_PageUp,
  SFBND_PageDown,
  SFBND_End,
  SFBND_Home,
  SFBND_Left,
  SFBND_Up,
  SFBND_Right,
  SFBND_Down,
  SFBND_Insert,
  SFBND_Delete,
  SFBND_Zero,
  SFBND_One,
  SFBND_Two,
  SFBND_Three,
  SFBND_Four,
  SFBND_Five,
  SFBND_Six,
  SFBND_Seven,
  SFBND_Eight,
  SFBND_Nine,
  SFBND_A,
  SFBND_B,
  SFBND_C,
  SFBND_D,
  SFBND_E,
  SFBND_F,
  SFBND_G,
  SFBND_H,
  SFBND_I,
  SFBND_J,
  SFBND_K,
  SFBND_L,
  SFBND_M,
  SFBND_N,
  SFBND_O,
  SFBND_P,
  SFBND_Q,
  SFBND_R,
  SFBND_S,
  SFBND_T,
  SFBND_U,
  SFBND_V,
  SFBND_W,
  SFBND_X,
  SFBND_Y,
  SFBND_Z,
  SFBND_NumPadZero,
  SFBND_NumPadOne,
  SFBND_NumPadTwo,
  SFBND_NumPadThree,
  SFBND_NumPadFour,
  SFBND_NumPadFive,
  SFBND_NumPadSix,
  SFBND_NumPadSeven,
  SFBND_NumPadEight,
  SFBND_NumPadNine,
  SFBND_Multiply,
  SFBND_Add,
  SFBND_Subtract,
  SFBND_Decimal,
  SFBND_Divide,
  SFBND_F1,
  SFBND_F2,
  SFBND_F3,
  SFBND_F4,
  SFBND_F5,
  SFBND_F6,
  SFBND_F7,
  SFBND_F8,
  SFBND_F9,
  SFBND_F10,
  SFBND_F11,
  SFBND_F12,
  SFBND_NumLock,
  SFBND_ScrollLock,
  SFBND_LeftShift,
  SFBND_RightShift,
  SFBND_LeftControl,
  SFBND_RightControl,
  SFBND_LeftAlt,
  SFBND_RightAlt,
  SFBND_Semicolon,
  SFBND_Equals,
  SFBND_Comma,
  SFBND_Underscore,
  SFBND_Period,
  SFBND_Slash,
  SFBND_Tilde,
  SFBND_LeftBracket,
  SFBND_Backslash,
  SFBND_RightBracket,
  SFBND_Quote,
  SFBND_PrintScreen,
  SFBND_Hangul,
  SFBND_Junja,
  SFBND_Hanja,
  SFBND_Convert,
  SFBND_NonConvert,
  SFBND_LeftStickX,
  SFBND_LeftStickY,
  SFBND_LeftStick_Click,
  SFBND_RightStick_X,
  SFBND_RightStick_Y,
  SFBND_RightStick_Click,
  SFBND_ButtonA,
  SFBND_ButtonB,
  SFBND_ButtonX,
  SFBND_ButtonY,
  SFBND_LeftShoulder,
  SFBND_RightShoulder,
  SFBND_LeftTrigger,
  SFBND_RightTrigger,
  SFBND_Start,
  SFBND_Select,
  SFBND_DPad_Up,
  SFBND_DPad_Down,
  SFBND_DPad_Left,
  SFBND_DPad_Right,
  SFBND_SpecialX,
  SFBND_SpecialY,
  SFBND_SpecialZ,
  SFBND_SpecialW,
  SFBND_OEM_AX,
  SFBND_OEM_102,
  SFBND_MAX,
}

public enum ESFKeySetting
{
  KEYSET_Forward,
  KEYSET_Back,
  KEYSET_Left,
  KEYSET_Right,
  KEYSET_Jump,
  KEYSET_Dash,
  KEYSET_Down,
  KEYSET_Walk,
  KEYSET_Shot,
  KEYSET_Zoom,
  KEYSET_Attack,
  KEYSET_Charge,
  KEYSET_Behavior,
  KEYSET_PrevWeapon,
  KEYSET_PrevSlot,
  KEYSET_NextSlot,
  KEYSET_MainWeapon,
  KEYSET_ReserveWeapon,
  KEYSET_SpecialWapon,
  KEYSET_ThrowWeapon,
  KEYSET_ScoreBoard,
  KEYSET_MissionMsg,
  KEYSET_OrderMsg,
  KEYSET_RequireMsg,
  KEYSET_MAX,
}

public enum EIndicateType
{
  EIndicateType_All,
  EIndicateType_DamageTakerOnly,
  EIndicateType_SameTeamOnly,
  EIndicateType_OtherTeamOnly,
  EIndicateType_MAX,
}

public enum EModeState
{
  Active,
  Use,
  Reactive,
  Inactive,
  Neutrality,
  RedTryToOccupy,
  BlueTryToOccupy,
  RedOccupied,
  BlueOccupied,
  EModeState_MAX,
}

public enum GrowUpType
{
  GUT_Attack,
  GUT_Defence,
  GUT_Move,
  GUT_MAX,
}

public enum EHoleEmergeAnim
{
  EHEA_Random,
  EHEA_CrawlUp,
  EHEA_Jump,
  EHEA_MAX,
}

public enum EAutoFramingPawnTracePoint
{
  PawnTrace_Head,
  PawnTrace_Above,
  PawnTrace_Left,
  PawnTrace_Right,
  PawnTrace_MAX,
}

public enum ESpecPointCameraMode
{
  SPCAMERAMODE_Manual,
  SPCAMERAMODE_AutoTracking,
  SPCAMERAMODE_MAX,
}

public enum ESFSquadFormationType
{
  SFSF_None,
  SFSF_Column,
  SFSF_Line,
  SFSF_MAX,
}

public enum EMaterialType
{
  EMatType_Material,
  EMatType_MIC,
  EMatType_MITV,
  EMatType_MAX,
}

public enum EHelmetStatus
{
  EHMS_None,
  EHMS_Equipped,
  EHMS_DroppedAll,
  EHMS_DroppedOnlyEnemy,
  EHMS_MAX,
}

public enum eClanMarkType
{
  eClanMarkType_AllInOne,
  eClanMarkType_Set,
  eClanMarkType_MAX,
}

public enum EZoomType
{
  ZoomType_None,
  ZoomType_In,
  ZoomType_Out,
  ZoomType_MAX,
}

public enum EIconType
{
  ICONTYPE_Friend,
  ICONTYPE_Enemy,
  ICONTYPE_DeadBody,
  ICONTYPE_Object,
  ICONTYPE_Me,
  ICONTYPE_Compass,
  ICONTYPE_RedBase,
  ICONTYPE_BlueBase,
  ICONTYPE_Ping_Attack,
  ICONTYPE_Ping_Retreat,
  ICONTYPE_Cursor,
  ICONTYPE_FriendAI,
  ICONTYPE_EnemyAI,
  ICONTYPE_FriendTyrant,
  ICONTYPE_EnemyTyrant,
  ICONTYPE_MAX,
}

public enum EGunTrailMode
{
  EGunTrail_1st,
  EGunTrail_3rd,
  EGunTrail_TopView,
  EGunTrail_MAX,
}

public enum MeleeWeaponDetectType
{
  MWDT_LeftToRight,
  MWDT_RightToLeft,
  MWDT_LeftTopToRightBottom,
  MWDT_LeftBottomToRightTop,
  MWDT_RightTopToLeftBottom,
  MWDT_RightBottomToLeftTop,
  MWDT_TopToBottom,
  MWDT_BottomToTop,
  MWDT_Thrust,
  MWDT_MAX,
}

public enum EDroneControllState
{
  EDroneControllState_Connect,
  EDroneControllState_DistOut,
  EDroneControllState_Broken,
  EDroneControllState_NeedLanded,
  EDroneControllState_LeaveWall,
  EDroneControllState_MAX,
}

public enum EFlameType
{
  EFlameType_3rd,
  EFlameType_1st,
  EFlameType_Max,
}

public enum EGenericYesNo
{
  SFPID_VALUE_NO,
  SFPID_VALUE_YES,
  SFPID_VALUE_MAX,
}

public enum ELanguadge
{
  SFPID_LANGUAGE_KOREAN,
  SFPID_LANGUAGE_ENGLISH,
  SFPID_LANGUAGE_MAX,
}

public enum EFacebookUploadType
{
  EFacebookUpload_Message,
  EFacebookUpload_Link,
  EFacebookUpload_Image,
  EFacebookUpload_Movie,
  EFacebookDownload_FriendsList,
  EFacebookUploadType_MAX,
}

public enum ECombinePart
{
  ECombinePart_Class,
  ECombinePart_Badge,
  ECombinePart_Special,
  ECombinePart_Dogtag,
  ECombinePart_BluePrint,
  ECombinePart_CASH,
  ECombinePart_SP,
  ECombinePart_MAX,
}

public enum eMiniGameMainTabType
{
  eMiniGameMainTabType_MiniGame,
  eMiniGameMainTabType_Ranking,
  eMiniGameMainTabType_MAX,
}

public enum sf2_t
{
  http,
  sf2_t_MAX,
}

public enum BUDDYGROUPTYPE
{
  BGT_NONE,
  BGT_BUDDY,
  BGT_CLAN,
  BGT_BOTH,
  BGT_MAX,
}

public enum EAwardDispatchType
{
  EAwardDispatchType_Instantly,
  EAwardDispatchType_RoundOver,
  EAwardDispatchType_MatchOver,
  EAwardDispatchType_MAX,
}

public enum EOnetoOneUserType
{
  E1VS1_PLAYER_RED,
  E1VS1_PLAYER_BLUE,
  E1VS1_OBSERVER,
  E1VS1_TEAMTYPE,
  E1VS1_MAX,
}

public enum ERadarIconType
{
  ROIT_None,
  ROIT_Bomb_Normal,
  ROIT_Bomb_Ready,
  ROIT_Seizure_Normal,
  ROIT_Seizure_Ready,
  ROIT_Trigger_Normal,
  ROIT_Trigger_Ready,
  ROIT_Goal,
  ROIT_ThunderRun_Normal,
  ROIT_ThunderRun_Ready,
  ROIT_FrontLine_Normal,
  ROIT_FrontLine_RedOccupying,
  ROIT_FrontLine_RedOccupied,
  ROIT_FrontLine_BlueOccupying,
  ROIT_FrontLine_BlueOccupied,
  ROIT_PvEShop,
  ROIT_PvEManDown,
  ROIT_PvESuppressor,
  ROIT_PvEBarricade,
  ROIT_HeroAlienCtrl_Friend,
  ROIT_HeroTurret_Friend,
  ROIT_HeroAlienCtrl_Enemy,
  ROIT_HeroTurret_Enemy,
  ROIT_HeroShop1,
  ROIT_HeroShop2,
  ROIT_CaptureTowerNormal,
  ROIT_CaptureTowerRed,
  ROIT_CaptureTowerBlue,
  ROIT_ConvoyanceTarget,
  ROIT_ConvoyanceStore,
  ROIT_MAX,
}

public class UActorFactoryBarricade : UActorFactoryDynamicSM
{
  public bool bDamageEncroachedActor;
  public bool bSlowDownEncroachedActor;
}

public class UActorFactoryAlienSpore : UActorFactoryBarricade
{
}

public class UActorFactoryHelicopter : UActorFactoryMover
{
}

public class UActorFactoryPlayerStart_Area : UActorFactoryPlayerStart
{
}

public class UActorFactoryPlayerStart_DM : UActorFactoryPlayerStart
{
}

public class UActorFactoryPlayerStart_Mission : UActorFactoryPlayerStart
{
}

public class UActorFactoryPlayerStart_Mission_vs16 : UActorFactoryPlayerStart
{
}

public class UActorFactoryPlayerStart_SH : UActorFactoryPlayerStart
{
}

public class UActorFactoryPlayerStart_TDM : UActorFactoryPlayerStart
{
}

public class UActorFactoryPlayerStart_TDM_vs16 : UActorFactoryPlayerStart
{
}

public class UActorFactoryPlayerStart_Tut : UActorFactoryPlayerStart
{
}

public class UActorFactoryPlayerStartMovable_Area : UActorFactoryPlayerStart
{
}

public class UActorFactoryPlayerStartMovable_SH : UActorFactoryPlayerStart
{
}

public class UActorFactoryPrimaryTarget : UActorFactoryBarricade
{
}

public class UActorFactorySFBreakableActor : UActorFactory
{
  public UStaticMesh StaticMesh;
  public FVector DrawScale3D;
  public bool bNoEncroachCheck;
  public bool bNotifyRigidBodyCollision;
  public bool bBlockRigidBody;
  public bool bUseCompartment;
  public bool bCastDynamicShadow;
  public ECollisionType CollisionType;
}

public class UActorFactorySFBreakableActorByDamage : UActorFactorySFBreakableActor
{
}

public class UActorFactorySFBreakableCarPart : UActorFactory
{
  public UStaticMesh StaticMesh;
}

public class UActorFactorySFBreakableGlassActor : UActorFactoryMover
{
}

public class UActorFactorySFBreakableGlassSyncActor : UActorFactorySFBreakableGlassActor
{
}

public class UActorFactorySFConvoyTargetPathNode : UActorFactory
{
}

public class UActorFactorySFConvoyTargetStart : UActorFactoryPlayerStart
{
}

public class UActorFactorySFCustomPreview : UActorFactorySkeletalMeshCinematic
{
}

public class UActorFactorySFCustomWeaponPreview : UActorFactorySkeletalMeshCinematic
{
}

public class UActorFactorySFElevatorActor : UActorFactoryDynamicSM
{
}

public class UActorFactorySFEmitterNoSync : UActorFactoryEmitter
{
}

public class UActorFactorySFKActor : UActorFactoryDynamicSM
{
}

public class UActorFactorySFKActorNoSync : UActorFactoryDynamicSM
{
}

public class UActorFactorySFKAssetNoSync : UActorFactoryPhysicsAsset
{
}

public class UActorFactorySFPawnAI_Sentinel : UActorFactory
{
  public USkeletalMesh SkeletalMesh;
  public UAnimTree AnimTreeTemplate;
  public List<UAnimSet> AdditionalAnimSet;
}

public class UActorFactorySFSceneCaptureActor : UActorFactorySkeletalMeshCinematic
{
}

public class UActorFactorySFSpectatorEmitter : UActorFactoryEmitter
{
}

public class UActorFactorySFStaticMeshActor : UActorFactoryStaticMesh
{
}

public class UActorFactorySFTrigger_Use : UActorFactory
{
  public UStaticMesh StaticMesh;
}

public class UActorFactorySFTrigger_Bomb : UActorFactorySFTrigger_Use
{
}

public class UActorFactorySFTrigger_Capture : UActorFactorySFTrigger_Use
{
}

public class UActorFactorySFTrigger_Elevator : UActorFactorySFTrigger_Use
{
}

public class UActorFactorySFTrigger_Escape : UActorFactorySFTrigger_Use
{
}

public class UActorFactorySFTrigger_PlasticBomb : UActorFactorySFTrigger_Use
{
}

public class UActorFactorySFTrigger_PvENextWave : UActorFactorySFTrigger_Use
{
}

public class UActorFactorySFTrigger_PvEWaveInfo : UActorFactorySFTrigger_Use
{
}

public class UActorFactorySFTrigger_ReplaceMesh : UActorFactorySFTrigger_Use
{
}

public class UActorFactorySFTrigger_ReplaceMeshMovable : UActorFactorySFTrigger_ReplaceMesh
{
}

public class UActorFactorySFTrigger_Seizure : UActorFactorySFTrigger_ReplaceMesh
{
}

public class UActorFactorySFTrigger_StrongHold : UActorFactorySFTrigger_ReplaceMesh
{
}

public class UActorFactorySFTrigger_UseByWeaponGroup : UActorFactorySFTrigger_Use
{
}

public class UActorFactoryShop : UActorFactoryBarricade
{
}

public class UActorFactoryStaticMeshActorForBlastingGame : UActorFactoryStaticMesh
{
}

public class UActorFactoryStaticMeshByDamage : UActorFactoryStaticMesh
{
}

public class UActorFactoryTargetPaper : UActorFactoryMover
{
}

public class UActorFactoryWarriorAlienController : UActorFactoryPrimaryTarget
{
}

public class UActorFactoryWireEntanglement : UActorFactoryBarricade
{
}

public class USFTypes : UObject
{
  public class FSModeStatInfo
  {
    public EModeStatType Type;
    public int Value;
  }

  public class FSFacebookUserInfo
  {
    public ulong FacebookID;
    public string FacebookName;
    public int USN;
    public string CodeName;
  }

  public class FTwitchTVResolutionInfo
  {
    public string ResolutionText;
    public int Width;
    public int Height;
  }

  public class FSClanInfo
  {
    public string CSN;
    public string ClanName;
    public string WebURL;
    public string Area;
    public string MemeberCount;
    public string MasterUSN;
    public string MasterName;
    public string Description;
    public string Notice;
    public string Regdate;
    public string ClanPoint;
    public string GameCount;
    public string WinCount;
    public string PageCount;
    public string AreaText;
    public string RegularCount;
    public string MaxClanCount;
    public string ClanRank;
    public string ClanMark;
    public string ClanMarkEffect;
    public string Mode_No;
    public string Map_No;
    public List<string> OptionDataValue;
    public int nCSN;
    public string GFXClanPoint;
    public int nMemeberCount;
    public int nRegularCount;
    public int nGameCount;
    public int nWinCount;
    public int nMaxClanCount;
    public int nClanRank;
  }

  public class FSFiringRangeListInfo
  {
    public string Rank;
    public string USN;
    public string CodeName;
    public string CSN;
    public string ClanName;
    public string ClanMark;
    public string Score;
    public string Initial;
    public int nUSN;
    public int nCSN;
    public int nScore;
  }

  public class FS1VS1UserRankInfo
  {
    public string RankingStartDate;
    public string Ranking;
    public string Rank;
    public string USN;
    public string CodeName;
    public string Kill;
    public string Death;
    public string Win;
    public string Lose;
  }

  public class FSClanRecommend
  {
    public string ClanIndex;
    public string USN;
    public string CSN;
    public string ClanName;
    public string ClanMaster;
    public string ClanMark;
    public string RecommendUSN;
    public string RecommendNick;
    public string RecommendDate;
    public string Result;
  }

  public class FSClanModeMap
  {
    public int Id;
    public string Img;
    public string LocalName;
  }

  public class FSDetailOption
  {
    public string Tag;
    public string LocalName;
    public List<string> DropDownName;
    public int DefaultSelectedIndex;
  }

  public class FSDropDownMenu
  {
    public UGFxClikWidget DropDownMenuWidget;
    public string DropDownWidgetName;
    public int SelectedIndex;
    public string Tag;
    public int DefaultSelectedIndex;
  }

  public class FDistortionData
  {
    public float LifeSpan;
    public float Quantity;
  }

  public class FSRecvPacketHandler
  {
    public int ProtocolID;
    public List<FScriptDelegate> OKHandler;
    public List<FScriptDelegate> TransactionHandler;
    public List<FScriptDelegate> AutoHandler;
  }

  public class FGameCondition
  {
    public int Kill;
    public int Death;
    public int HeadShot;
  }

  public class FUserConditionData
  {
    public int PlayerID;
    public USFTypes.FGameCondition RecentCondition;
    public USFTypes.FGameCondition BaseCondition;
  }

  public class FSBombSPData
  {
    public int PlayerID;
    public int GiveSP;
    public ulong[] CouponSN = new ulong[3];
    public int[] RemainNumber = new int[3];
  }

  public class FsCombatReport
  {
    public eCBRT ReportType;
    public int AttackerID;
    public string AttackerName;
    public int AttackerRank;
    public int VictimID;
    public string VictimName;
    public int VictimRank;
    public int Weapon;
    public int Damage;
    public int KillMessage;
    public UClass DmgTypeClass;
  }

  public class FsBossSkill
  {
    public float UseRate;
    public UClass SkillClass;
  }

  public class FSFaceMorphNode
  {
    public UMorphNodeWeight FaceMorphNode;
    public bool bActive;
    public float FaceMorphTimeToGo;
  }

  public class FHumanAIClassNames
  {
    public EHAITYPE Type;
    public string ClassName;
  }

  public class FOriginMtrlData
  {
    public int Index;
    public UMaterialInterface Material;
  }

  public class FSAdditionalInfo
  {
    public EAdditionalType Type;
    public int Value;
  }

  public class FAwardValue
  {
    public EAwardValueType Type;
    public bool B;
    public float N;
    public string S;
  }

  public class FSFUITabList
  {
    public int Code;
    public string Label;
    public string Filter;
    public string IconID;
    public bool bVip;
  }

  public class FSRecvReward
  {
    public int reward;
    public string RewardText;
    public string RewardType;
    public ulong ItemSN;
    public ulong ItemNSN;
    public string EndDate;
    public int Durability;
    public byte SupplyItemType;
    public string IsInUse;
    public bool IsShow;
    public int ItemCount;
  }

  public class FSRecvChallengeReward
  {
    public FName SupplyCode;
    public int TaskIndex;
    public List<USFTypes.FSRecvReward> RewardArray;
  }

  public class FSRecvPromoEventReward
  {
    public int PromotionID;
    public USFTypes.FSRecvReward RecvReward;
  }

  public class FsRecvRandomBoxReward
  {
    public int BoxID;
    public int RewardID;
    public string RareType;
  }

  public class FsRandomBoxInfo
  {
    public int BoxID;
    public string EndDate;
    public int KeyID;
    public int KeyCount;
    public string IsShow;
  }

  public class FSPromotionEvent
  {
    public int PromotionID;
    public int PromotionParentID;
    public string PromotionName;
    public string PromotionTitle;
    public string PromotionDesc;
    public string SpecialText;
    public string UIType;
    public string PromotionStartDate;
    public string PromotionEndDate;
    public byte IsDailyEvent;
    public int DailyStartTime;
    public int DailyEndTime;
    public byte MaxStep;
    public List<string> StepArray;
    public List<USFTypes.FSRecvReward> RecvRewardArray;
    public string CurrentValue;
  }

  public class FSPromotionEventInfo
  {
    public List<int> GameModeIDArray;
    public int PromotionID;
    public bool bIsFinal;
    public string PromotionName;
    public string PromotionExplain;
    public string ColorInProgress;
  }

  public class FSCharRange
  {
    public int Start;
    public int End;
  }

  public class FPawnOutlineInfo
  {
    public EPawnOutlineType Type;
    public byte OutLineColorIndex;
    public float OutLineOverlapDistance;
    public float OutLineIntense;
    public float OutlineWidth;
  }

  public class FStateIconType
  {
    public FName StateName;
    public EObjectIconState IconState;
  }

  public class FNextStateInfo
  {
    public FName StateName;
    public FName NextStateName;
    public FName CallerName;
  }

  public class FMCExternalInfo
  {
    public int Priority;
    public int RenderDataIndex;
    public int MeshIndex;
    public int TextureIndex;
    public List<int> ItemList;
    public List<ECustomPartType> WithOutPartTypes;
    public UClass BuilderClass;
    public bool bShouldCheckAdditionalMesh;
    public bool bTPSWeapon;
  }

  public class FsWeaponState
  {
    public EWeaponState WeaponState;
    public bool Updated;
  }

  public class FS_RECOIL
  {
    public float incline;
    public float maxCrossVert;
    public float nextCrossVert;
    public float vertInc;
    public float vertDec;
    public bool bAllowMinusDom;
    public bool bIncreaseDomForFirstShot;
    public float crossDecreasInc;
    public float domMax;
    public float domMin;
    public float domZoomDefault;
    public float domDefault;
    public float domInc;
    public float domDec;
    public int forceCorrection;
    public float maxMovingValue;
    public float movingValueInc;
    public float movingValueDec;
    public float mulValueWalk;
    public float mulValueRun;
    public float mulValueJump;
    public float CrossHairSpreadRatio;
  }

  public class FWeaponStateData
  {
    public EWeaponState WeaponState;
    public FName AnimName;
    public float PlayRate;
    public float BlendInTime;
    public float BlendOutTime;
    public bool bLooping;
    public bool bAnimOverride;
  }

  public class FSKillCamProjectile
  {
    public float KillCamThrowTime;
    public int KillCamProjID;
    public UObject.FVector KillCamProjLoc;
    public UObject.FRotator KillCamProjRot;
    public UObject.FVector KillCamProjVel;
    public int KillCamProjItemID;
    public float KillCamProjLifeSpan;
    public UClass KillCamProjClass;
  }

  public class FKillCamExplosion
  {
    public float ExplosionTime;
    public UObject.FVector ExplosionLocation;
    public UObject.FRotator ExplosionRotation;
    public UGameExplosion ExplosionTemplate;
  }

  public class FAttendanceEventInfo
  {
    public USFTypes.FAttendanceBoxItemInfo[] BoxItems = new USFTypes.FAttendanceBoxItemInfo[2];
    public int BoxIndex;
    public int EventID;
    public int CurrScore;
    public AttendanceEventBoxType BoxAcquireType;
    public bool IsShowItem;
    public string TaskDate;
  }

  public class FsItemAdditionalEffect
  {
    public float LP;
    public float AP;
    public float Weight;
    public float ClanPoint;
    public float Jump;
    public float HP;
    public float Swap;
    public float Reload;
    public float BlastingSpeed;
  }

  public class FItemSetInfos
  {
    public byte bCachedPawnItemIDTable;
    public byte[] bCachedPriWeaponItemIDTable = new byte[3];
    public byte[] bCachedSecWeaponItemIDTable = new byte[3];
    public int[] PawnItemIDTable = new int[14];
    public int[] WeaponItemIDTable1Pri = new int[11];
    public int[] WeaponItemIDTable1Sec = new int[11];
    public int[] WeaponItemIDTable2Pri = new int[11];
    public int[] WeaponItemIDTable2Sec = new int[11];
    public int[] WeaponItemIDTable3Pri = new int[11];
    public int[] WeaponItemIDTable3Sec = new int[11];
  }

  public class FSGiftItem
  {
    public ulong GiftNSN;
    public int GiftValue;
    public int USN;
    public string CodeName;
    public string GiftType;
    public string Date;
    public bool bUsable;
    public string Message;
  }

  public class FSFindUserInfo
  {
    public int USN;
    public string CodeName;
    public int ServerNumber;
    public int ChannelNumber;
    public int channelType;
    public int RoomNumber;
  }

  public class FSEventItem
  {
    public string EventName;
    public string LinkURL;
    public string context;
  }

  public class FInt
  {
    public int Hi;
    public int Low;
  }

  public class FSObjectIcon
  {
    public AActor Actor;
    public UGFxObject MovieClip;
    public UGFxObject Arrow;
    public UGFxObject TextField1;
    public UGFxObject TextField2;
    public UGFxObject TextField3;
    public UGFxObject HPStat;
    public EObjectIconTypes Type;
    public EObjectIconState State;
    public int Width;
    public int Height;
    public ETeam ShowFlag;
    public bool bShowHP;
    public bool bIsArrowVisible;
    public bool bNoClampScreenPos;
    public bool bShowRecentlyRendered;
    public int PrevHP;
    public int PrevDist;
    public string PrevFrontBack;
    public float PrevArrowDegree;
    public bool bShowObjectBehind;
    public EObjectIconInterplateType nInterpolateType;
    public float LastInterpTypeChangedTime;
    public UObject.FVector vInterPolateTarget;
    public EObjectInterpDir InterpDirX;
    public EObjectInterpDir InterpDirY;
  }

  public class FSObjectIconBind
  {
    public UClass ClassToBind;
    public EObjectIconTypes IconType;
    public EObjectIconTypes IconTypeFriend;
    public EObjectIconTypes IconTypeEnemy;
    public bool bNoClampScreenPos;
    public bool bShowRecentlyRendered;
    public EObjectIconState DefaultState;
    public int MaxShowDist;
    public bool bShowSameTeamOnly;
    public bool bShowObjectBehind;
  }

  public class FSHUDActionMsg
  {
    public AActor ActionActor;
    public EHUDActionMsg ActionIndex;
    public string ActionMsg;
  }

  public class FSPacketError
  {
    public int ProtocolID;
    public int ErrorID;
    public string ResultMsg;
  }

  public class FSInternetError
  {
    public string ProtocolURL;
    public int ErrorID;
    public string ResultMsg;
  }

  public class FExtraRewardInfo
  {
    public string supply_code;
    public string reward_type;
    public int reward;
    public byte DisplayType;
  }

  public class FsClanMarkInfo
  {
    public int Layer;
    public string Tab;
    public int TabSort;
    public int ImageSort;
    public string UnigueId;
    public string ShopItemCode;
    public string Event;
    public bool IsShow;
    public string ToolTip;
  }

  public class FsChangeClanMarkTabInfo
  {
    public string Tab;
    public int TabSort;
  }

  public class FsDeadPawnObject
  {
    public UObject.FVector Loc;
    public int TeamNum;
    public string PlayerName;
    public float TimeofDeath;
  }

  public class FSCodeNameColor
  {
    public int Version;
    public string CodeNameColorValue;
  }

  public class FSPlayerInfo
  {
    public int USN;
    public string CodeName;
    public string UnitItemCode;
    public int UnitItemID;
    public int Rank;
    public string strGFxRank;
    public string strRankName;
    public int DisguiseRank;
    public string GFxDisguiseRank;
    public int AllPlayTime;
    public int SPGage;
    public int Op;
    public int SP;
    public int TP;
    public int CP;
    public int Cash;
    public int Exp;
    public int LuckyPoint;
    public int PrevLuckyPoint;
    public int WeaponSetIndex;
    public int LadderPoint;
    public int Kills;
    public int Assists;
    public int Deaths;
    public int AttackRound;
    public int AttackRoundWin;
    public int DefendRound;
    public int DefendRoundWin;
    public int RunAwayCount;
    public int AllHitCount;
    public int HeadShots;
    public int HeadHitCount;
    public int HeadPointHitCount;
    public int AllHitCharacter;
    public int AllPlayGameCount;
    public int AllWinGameCount;
    public string LongTimeMainWeaponItemCode;
    public int NametagImage;
    public string NametagShowType;
    public string NametagText;
    public int CSN;
    public int CSNToRequestClanJoin;
    public string ClanName;
    public int ClanLevel;
    public int DestroyCSN;
    public string ClanMark;
    public string ClanMarkEffect;
    public string ClanRecommendNick;
    public int LeagueTicketCount;
    public int Age;
    public byte Sex;
    public USFTypes.FSCodeNameColor CodeNameColor;
    public bool bIsColor;
    public int Coin;
    public int CoinGauge;
    public int CoinState;
    public string KeySet;
    public string CharacterBirthday;
    public string FaceItemCode;
    public string PmcCode;
    public ulong PmcItemSN;
    public string[] Tag = new string[3];
    public int[] TagID = new int[3];
    public int MiniGachaCoin;
  }

  public class FSMyRanking
  {
    public int RealRankingExp;
    public int RealRankingClan;
    public int PrevRealRankingExp;
    public int PrevRealRankingClan;
    public int RankingExp;
    public int RankingWinRound;
    public int RankingKill;
    public int RankingAssist;
    public int RankingHeadShot;
    public int RankingBlasting;
    public int RankingSeizure;
    public int RankingEscape;
    public int RankingClan;
    public int RankingExpCount;
    public int RankingWinRoundCount;
    public int RankingKillCount;
    public int RankingAssistCount;
    public int RankingHeadShotCount;
    public int RankingBlastingCount;
    public int RankingSeizureCount;
    public int RankingEscapeCount;
    public int RankingClanCount;
  }

  public class FSCommunityFeedback
  {
    public int FeedbackCount;
    public List<string> CodenameArray;
  }

  public class FSCommunityMessage
  {
    public int Index;
    public int USN;
    public int Rank;
    public int EmblemID;
    public int nType;
    public string CodeName;
    public string Title;
    public string Message;
    public string Regdate;
    public USFTypes.FSCommunityFeedback[] Feedback = new USFTypes.FSCommunityFeedback[3];
  }

  public class FSCommunityBuddy
  {
    public int USN;
    public int EmblemID;
    public string CodeName;
    public string[] Tag = new string[3];
    public int[] nIsMatchTag = new int[3];
    public int DisconnectedDays;
  }

  public class FSCommunityEvent
  {
    public int nType;
    public int EventInfoNumeric;
    public string EventInfoString;
  }

  public class FSCommunityEventMessage
  {
    public int nType;
    public string Title;
    public string Message;
  }

  public class FsPersonalAddInfo
  {
    public string strGFxRank;
    public int NametagImage;
    public byte isClanMember;
    public byte Sex;
    public byte Age;
    public float KDRate;
    public int Rank;
    public int PlayerGradeLV;
    public string LongTimeMainWeaponItemCode;
    public USFTypes.FSCodeNameColor CodeNameColor;
    public int CSN;
    public string ClanMark;
  }

  public class FSRoomSetting
  {
    public string RoomName;
    public int RoomNumber;
    public int RoomType;
    public int GameModeID;
    public int MapID;
    public int NumRound;
    public int NumPlayers;
    public int MatchPointIndex;
    public byte MatchTimeIndex;
    public byte AIDifficulty;
    public string Password;
    public bool bGameInProgress;
    public bool bSearchInProgress;
    public bool EnableSwitchSide;
    public bool EnableIntrusion;
    public bool EnableKillCam;
    public bool EnableThirdPerson;
    public bool EnableTeamBalance;
    public bool EnableTeamSwitch;
    public int PlayedGameCount;
    public bool ChangedSwitchSide;
    public bool ChangedThirdPerson;
    public bool ChangedIntrusion;
    public bool ChangedKillCam;
    public bool ChangedTeamBalance;
    public bool ChangedLastStand;
    public bool ChangedPickupWeapon;
    public byte VipGrade;
    public byte RedTeamPlayerCount;
    public byte RedTeamAICount;
    public byte BlueTeamPlayerCount;
    public byte BlueTeamAICount;
    public bool EnableLastStand;
    public byte CustomModeType;
    public byte EnablePickUpWeapon;
  }

  public class FSItemPriceInfo
  {
    public string Type;
    public int Value;
  }

  public class FsEmoticonData
  {
    public string Src;
    public string tgt;
  }

  public class FsDOT
  {
    public AController Inst;
    public AActor Causer;
    public UClass DamageType;
    public float RestTime;
    public float Lifetime;
    public float PeriodTime;
    public float BaseDamage;
    public float actualDamage;
  }

  public class FProjectileDot
  {
    public ASFProj_HG_Gas Instigator;
    public AActor Target;
    public UClass DamageType;
    public float Damage;
  }

  public class FsTeamScore
  {
    public int Kill;
    public int Death;
    public int Assist;
    public int AIKill;
    public int AIDeath;
    public int AIAssist;
  }

  public class FSPawnEffect
  {
    public FName SocketName;
    public UParticleSystem PSCTemplate;
    public USoundCue EffectSound;
    public EWeaponState PawnEffectState;
    public EWeaponState StopPawnEffectState;
    public float Scale;
    public UObject.FColor Color;
    public float Duration;
    public bool PSCLoops;
    public List<float> Timing;
    public float ElapsedTime;
  }

  public class FSGameClanBuffInfo
  {
    public EGameClanBuffType Type;
    public float Value;
    public int MinLevel;
    public int MaxLevel;
  }

  public class FAIUnit
  {
    public string Unit;
    public List<string> Items;
  }

  public class FPawnInventorySet
  {
    public int[] InventoryInfo = new int[14];
  }

  public class FWeaponItemIDSet
  {
    public EWEAPON_SLOT SlotIndex;
    public int WeaponID;
    public List<int> WeaponItemsID;
  }

  public class FWeaponInventorySet
  {
    public int[] WeaponInfo = new int[37];
  }

  public class FSEmblemInfo
  {
    public int Id;
    public EEmblemType Type;
    public int Condition;
    public bool Available;
  }

  public class FSMapCaption
  {
    public string MapName;
    public string ImageURL;
    public string Text;
  }

  public class FSPvEDifficultyUIInfo
  {
    public string MapName;
    public ELevelOfDifficulty LevelCode;
    public string LevelText;
  }

  public class FSShutDownLaw
  {
    public string ShutDownName;
    public int ShutDownCode;
  }

  public class FSShutDownNoti
  {
    public int NotiType;
    public int RemainTime;
    public string ShutDownName;
  }

  public class FSSupportMap
  {
    public int GameModeID;
    public string MapName;
    public bool VIPMapUnlock;
  }

  public class FCachedSupportMap
  {
    public int GameModeID;
    public List<USFTypes.FSSupportMap> Maps;
  }

  public class FAddtionalIdleMotion
  {
    public float MinDelay;
    public float MaxDelay;
    public FName IdleMotionName;
  }

  public class FAdditionalModeResult
  {
    public FName VarName;
    public int Value;
  }

  public class FEnemyInfo
  {
    public EAITypes EnemyType;
    public float EnemySpawnRate;
  }

  public class FsWaveInfo
  {
    public int WavePointsRemaining;
    public float MaxAliveRatio;
    public float EndOfRoundDelay;
    public bool UseSecondarySpawnPoint;
    public bool NextWaveWhenEliminateEnemy;
    public int ExplicitNextWaveIndex;
    public List<USFTypes.FEnemyInfo> EnemyInfoList;
    public bool bIgnorePlayerCounterOnThisWave;
    public bool bPauseWhenAllSpawn;
    public string EventExtermination;
  }

  public class FSSpawnableAlienInfo
  {
    public EAITypes Type;
    public string ClassName;
    public EAICombatType CombatType;
    public List<EAlienAttackType> AttackTypes;
  }

  public class FSResellDialogInfo
  {
    public int X;
    public int Y;
    public int ItemId;
    public ulong ItemSN;
    public int DialogType;
  }

  public class FSRepairDialogInfo
  {
    public int X;
    public int Y;
    public string MySp;
    public string NeedSp;
    public string msg;
    public string WeaponName;
    public string WeaponImg;
    public int RepairGauge;
    public ulong ItemSN;
  }

  public class FSRepairAllDialogInfo
  {
    public int X;
    public int Y;
    public string msg;
    public List<string> WeaponNames;
    public List<string> WeaponImgs;
    public List<int> RepairGauges;
    public List<int> NeedSps;
    public List<ulong> ItemSNs;
  }

  public class FWeaponAmmo
  {
    public EWEAPON_GROUP WeaponGroup;
    public int AddedAmmo;
    public int LimitAmmo;
    public int AddedMagazine;
    public int LimitMagazine;
  }

  public class FSFWeaponLog
  {
    public FName WeaponItemCode;
    public string ItemName;
    public string ImgName;
    public int PlayTime;
    public int KillCount;
    public int DeadCount;
    public int AssistCount;
    public int HitEnemyCount;
    public int HeadShotCount;
    public int TotalHitCount;
    public int HeadHitCount;
    public int HeadPointHitCount;
    public int ChestHitCount;
  }

  public class FSFWeaponLogMember
  {
    public string WeaponImgName;
    public string WeaponCI;
    public int KillPercent;
    public int AssistPercent;
    public int HeadShotPercent;
    public int EtcPercent;
    public int ValidAccuracy;
    public int HeadAccuracy;
    public int ChestAccuracy;
    public int EtcAccuracy;
    public float KADRatio;
    public string Name;
  }

  public class FChallengeData
  {
    public int Group;
    public int TaskIndex;
    public FName Contents;
    public int from_GoalPoint;
    public int to_GoalPoint;
    public FName SupplyCode;
    public int ChallengePoint;
    public string WeaponType;
    public int GameModeID;
    public int MissionID;
    public int MapID;
    public EAITypes AIType;
    public EAIGrade AIGrade;
    public int TotalPlayerCounter;
    public FName RewardType;
    public string RewardValue;
    public string ImageSet;
    public string SheetName;
    public int EmblemID;
  }

  public class FSWeaponEffect
  {
    public FName SocketName;
    public UParticleSystem PSCTemplate;
    public USoundCue EffectSound;
    public EWeaponEffectState WeaponEffectState;
    public float Scale;
    public UObject.FColor Color;
    public float Duration;
    public bool PSCLoops;
    public List<float> Timing;
    public float ElapsedTime;
  }

  public class FsBuddy
  {
    public int USN;
    public int CSN;
    public string CodeName;
    public byte BuddyType;
    public byte Status;
    public byte GroupSN;
    public byte ClanLevel;
    public USFTypes.FSCodeNameColor CodeNameColor;
    public int NoticeCount;
    public int channelType;
    public int channelNum;
    public int roomNo;
    public byte inGame;
    public byte PreSync;
    public string GfxRank;
    public int UserImage;
    public byte isClanMember;
    public byte Sex;
    public byte Year;
    public float KDRate;
    public int Rank;
    public int UserGrade;
    public bool bInvited;
    public byte BuddyTypeSet;
    public byte BuddyTypeClr;
    public byte BuddyTypeForReverse;
    public string ClanMark;
  }

  public class FsBuddyGroup
  {
    public byte GroupSN;
    public string GroupName;
    public int OnlineCount;
    public int ValideCount;
    public List<int> buddys;
  }

  public class FsBuddyFiltterCondition
  {
    public BUDDYFILTTER Type;
    public string filtterStr;
    public int filtterInt;
    public float filtterFlot;
  }

  public class FsBuddyPopup
  {
    public int popupExec;
    public string popupText;
  }

  public class FsMessengerNotice
  {
    public int Type;
    public int USN;
    public string CodeName;
    public string Message;
  }

  public class FSChatMsgInfo
  {
    public int ChatType;
    public int ChatSendType;
    public string CodeName;
    public string ChatMsg;
    public int UserGradeLV;
    public string ChatFinalMsg;
    public bool bFromMe;
    public string TimeStamp;
    public bool bSeen;
    public USFTypes.FSCodeNameColor CodeNameColor;
    public int WhisperUSN;
    public string WhisperCodeName;
    public int NametagImage;
    public int ContactUSN;
  }

  public class FSMsgrChattingInfo
  {
    public int ContactUSN;
    public string StartGameTime;
    public List<USFTypes.FSChatMsgInfo> MsgrChatMsgArray;
  }

  public class FSInputTextFilter
  {
    public FName Option;
    public int Min;
    public int Max;
  }

  public class FSChannelType
  {
    public int Group;
    public string GroupText;
    public int Type;
    public int RoomUserCount;
    public string LongName;
    public string ShortName;
    public string ToolTip;
    public bool bUseEnemyCharacter;
    public bool bDisableUseInGameKick;
    public bool bDisablePasswordRoom;
  }

  public class FSRecommendChannel
  {
    public int nType;
    public int nColor;
  }

  public class FSChannelEXP
  {
    public int nType;
    public int ExpAddRatio;
    public int SPGageAddRatio;
  }

  public class FSChannelSetting
  {
    public int nServerID;
    public int nChannelNum;
    public int nType;
    public int nPeopleNum;
    public int nMaxPeople;
    public int MaxVipCount;
    public byte nEnable;
    public int nFriendNum;
    public int nClanNum;
    public int nColor;
  }

  public class FSChannelFillInfo
  {
    public int MinPlayerRatio;
    public int FillType;
  }

  public class FsItemContext
  {
    public int Id;
    public string context;
  }

  public class FResourceInfo
  {
    public UObject Resource;
    public FName ResourceName;
  }

  public class FTime_t
  {
    public int Year;
    public int Month;
    public int Day;
    public int DayOfWeek;
    public int Hour;
    public int Min;
    public int Sec;
    public int MSec;
  }

  public class FSRealTimeEvent
  {
    public int EventNumber;
    public ulong EventStartDate;
    public ulong EventEndDate;
    public FName EventType;
    public int EventCondition1;
    public string EventCondition1Value;
    public string EventCondition2;
    public int EventCondition2Value;
    public USFTypes.FTime_t ParsedEventStartDate;
    public USFTypes.FTime_t ParsedEventEndDate;
    public List<int> ParsedEventValues1;
    public List<string> ParsedEventValues2;
    public int EXPValue;
    public int SPValue;
    public string BoxType;
    public int BoxCounter;
    public string EventName;
    public string EventDescription;
  }

  public class FSFeverValues
  {
    public int AddEXP;
    public int AddSP;
    public int AddLP;
  }

  public class FSFindMatchingRoom
  {
    public int RoomNumber;
    public string RoomName;
    public int GameModeID;
    public int MapID;
    public string ClanName;
    public int ClanRanking;
    public string ClanMark;
  }

  public class FSRoomUser
  {
    public int USN;
    public byte TeamIndex;
    public byte Unit;
    public string CodeName;
    public byte Ping;
    public byte UserStatus;
    public int Exp;
    public string strGFxRank;
    public int UnitItemID;
    public byte Sex;
    public int RunAwayCount;
    public int AllPlayTime;
    public int ExpRank;
    public int ClanRank;
    public USFTypes.FSCodeNameColor CodeNameColor;
    public bool bIsColor;
    public byte GradeLevel;
    public string ClanMark;
    public int NametagImage;
    public string NametagShowType;
    public string NametagText;
    public string Regdate;
    public int CSN;
    public string ClanName;
    public int PCRoomCareType;
    public int LadderPoint;
    public int Kills;
    public int Assists;
    public int Deaths;
    public int HeadShots;
    public int AllWinGameCount;
    public int AllPlayGameCount;
    public int MainWeaponID;
    public int MainWeapCamoID;
    public string strGFxRankInGame;
    public byte VipGrade;
    public byte ClanNameColorVersion;
    public string ClanNameColor;
    public string ClanMarkEffect;
    public string ClanRating;
    public string ClanLeague;
    public int DisguiseRank;
    public byte MonthlyRewardGrade;
  }

  public class FSRoomUserTeamArray
  {
    public List<int> DisplayUser;
  }

  public class FSRoomUserInfo
  {
    public int RoomNumber;
    public int MasterUSN;
    public int MasterUSNOld;
    public byte ExtraUserStatus;
    public byte VipGrade;
    public int RecvUserListCount;
    public int CurUserListCount;
    public List<USFTypes.FSRoomUser> RoomUserArray;
    public List<int> IntrusionUserArray;
    public List<USFTypes.FSRoomUserTeamArray> TeamArrays;
    public List<int> ObserverUserArrays;
    public List<int> WholeUserArray;
  }

  public class FInGameStoreItem
  {
    public int ItemId;
    public int MaxCount;
    public int UsableLevel;
    public int Price;
    public int ResellPrice;
    public float PriceRatio;
    public float UpgradePriceRate;
    public string TabName;
    public string TabImage;
    public int GroupIndex;
    public bool InstantBuy;
    public string strInstantMsg;
    public int LogData;
    public string ParticleName;
    public string SoundName;
    public bool bDisableInUseItem;
  }

  public class FDamageRatioByGameMode
  {
    public float DamageRatio;
    public FName DamageTypeName;
  }

  public class FAIPawnScore
  {
    public EAITypes PawnType;
    public bool bTeamReward;
    public EBuffType RewardBuff;
    public float BasisScore;
    public float BasisModeExp;
    public float BasisModeMoney;
    public float CriticalDistance;
  }

  public class FSGuideItem
  {
    public int ItemId;
    public string ModeItemCode;
    public bool bUnSelected;
  }

  public class FSRecommendItem
  {
    public int MaxRank;
    public int MaxSP;
    public List<string> KeyTypes;
    public List<string> BaseTypes;
  }

  public class FSRecommendItemType
  {
    public string Typename;
    public List<int> ItemArray;
  }

  public class FSPackageItem
  {
    public int pkg_itemid;
    public int sub_itemid;
    public int counts;
  }

  public class FSQuickJoin
  {
    public int GameModeID;
    public int MapID;
    public int CustomModeType;
    public int PickUpWeapon;
  }

  public class FSDamageResist
  {
    public UClass DamageTypeClass;
    public float ReduceRate;
  }

  public class FUsableInGameItemData
  {
    public string ItemType;
    public string ItemValue;
    public int Amount;
  }

  public class FSliceState
  {
    public UObject.FPlane SlicePlane;
    public int StaticMeshComponentID;
  }

  public class FMapRotationInfo
  {
    public int ModeID;
    public int MapID;
  }

  public class FSFTakeHitInfo
  {
    public int Damage;
    public UObject.FVector HitLocation;
    public UObject.FVector Momentum;
    public UClass DamageType;
    public FName HitBone;
    public int HitBoneIndex;
    public int WeaponID;
    public AActor DamagedBy;
    public int HitType;
  }

  public class FsAjdPawnProp
  {
    public EAITypes AIType;
    public int Health;
    public float DamageAdj;
    public float DamageAdjRadi;
    public float GroundSpeed;
    public float SprintingPct;
    public float WalkingPct;
    public float CustomScaleRate;
    public float IntenseMulByTime;
    public float BeginIntenseMulByTime;
    public float MaxIntenseMulByTime;
    public int DropItemCount;
    public int PawnAggroMultiplier;
  }

  public class FsWeaponInitInfo
  {
    public string WeaponClassString;
    public UClass WeaponClass;
    public float InstantHitDamage;
    public float ReloadTime;
    public float WeaponRange;
    public int AmmoInMgzCount;
    public int AmmoCount;
    public float KnockBack;
    public float StoppingPower;
    public int PenetrationCount;
    public float PenetrationPower;
    public int bForceAutomatic;
    public int bUseLoopReload;
    public int Spread;
    public int SGPelletCount;
    public float GrazeDamageRate;
    public float GrazeExtend;
    public List<int> RoundBurst;
  }

  public class FsWeaponTuneInfo
  {
    public string WeaponClassString;
    public UClass WeaponClass;
    public int Level;
    public float InstantHitDamage;
    public float Thickness;
    public UParticleSystem TracerTemplate;
    public UParticleSystem ExtraTracerTemplate;
  }

  public class FsPawnTuneInfo
  {
    public int Level;
    public float TakeDamageRatio;
    public float GroundSpeedRatio;
    public float DodgeSpeed;
  }

  public class FsPlayerVIPInfo
  {
    public string ItemCode;
    public int DailyVipPoint;
    public int TotalVipPoint;
    public byte VipGrade;
    public float Discount;
    public string ExpriedDate;
  }

  public class FsVipGradeInfo
  {
    public byte Grade;
    public int from_point;
    public int to_point;
    public float Discount;
    public float AddEXP;
    public float AddSpGauge;
    public float AddRoomOtherExpRate;
    public float AddRoomOtherSpGaugeRate;
    public float AddLuckyPoint;
  }

  public class FChallengeLocalized
  {
    public string ChallengeName;
    public string UI_Message;
  }

  public class FSWeaponProgressionTask
  {
    public FName SupplyCode;
    public int TaskIndex;
    public int ItemId;
    public bool bSPBuyable;
    public int LimitRank;
    public int CurProgress;
    public int MaxProgress;
    public string ChallengeName;
    public string ChallengeImage;
    public string ChallengeMessage;
  }

  public class FSFeverTimeEvent
  {
    public int Number;
    public string StartDate;
    public string FinishDate;
    public string StartTime;
    public string FinishTime;
    public string ApplyDay;
    public string Description;
    public USFTypes.FSFeverValues Values;
    public string RewardItemID;
    public string SaleItemID;
    public List<int> ParsedRewardItemID;
    public List<int> ParsedSaleItemID;
    public bool bFerverEventActive;
  }

  public class FMuzzleFlash
  {
    public FName SocketName;
    public UClass LightClass;
    public UParticleSystem PSCTemplate;
    public UParticleSystem PSCTemplateZoom;
    public float Scale;
    public UObject.FColor Color;
    public float Duration;
    public bool PSCLoops;
  }

  public class FGunTrailInfo
  {
    public float interval;
    public float SpeedMin;
    public float SpeedMax;
    public float Thickness;
    public float Length;
    public float StartX;
  }

  public class FAttendanceBoxItemInfo
  {
    public string RewardType;
    public int RewardValue;
  }

  public FScriptDelegate __OnPacketRecv__Delegate;
}

public class UAIAvoidanceCylinderComponent : UCylinderComponent
{
  public Dictionary<byte, byte> LinkedNavigationPoints;
  public Dictionary<byte, byte> LinkedReachSpecs;
  public FVector LastReLinkLocation;
  public float UpdateThreshold;
  public bool bEnabled;
  public ETeam TeamThatShouldFleeMe;
}

public class AAIAvoidanceCylinder : AActor
{
  public bool bEnabled;
  public UAIAvoidanceCylinderComponent AvoidanceComp;
  public ETeam TeamThatShouldFleeMe;
  public FName OwnerName;
}

public class USFAICommand : UGameAICommand
{
  public ASFAIController AIOwner;
  public USFAICommand CachedSFChildCommand;
  public float CommandStartTime;
  public AActor Target;
}

public class UAICmd_Attack_Base : USFAICommand
{
  public int FailAttack;
  public bool bNeedWeaponChange;
  public bool bForceAttack;
  public int PendingFiremode;
}

public class UAICmd_Attack_BossSkill : UAICmd_Attack_Base
{
  public FVector TargetLocation;
  public bool IsActive;
  public float SkillEndDelay;
}

public class UAICmd_Attack_Breath : UAICmd_Attack_Base
{
  public float AttackDelayTime;
}

public class UAICmd_Attack_Melee : UAICmd_Attack_Base
{
}

public class UAICmd_Attack_MeleeJump : UAICmd_Attack_Melee
{
  public FVector vMovingAttackPosition;
  public float fFireStatDuration;
  public float fFyingTime;
  public float fRestTime;
}

public class UAICmd_Attack_MeleeRange : UAICmd_Attack_Melee
{
}

public class UAICmd_Attack_Range : UAICmd_Attack_Base
{
}

public class UAICmd_Attack_RangeTurret : UAICmd_Attack_Range
{
}

public class UAICmd_Attack_RollingAttack : UAICmd_Attack_Range
{
  public FVector TargetLocation;
  public FVector LineCheckStartLocation;
  public bool IsRolling;
  public bool OldFreeze;
  public bool bHitEnemyPawn;
  public int FailedRollingCount;
  public float AttackEndDelay;
}

public class UAICmd_Attack_SelfDestruction : UAICmd_Attack_Melee
{
}

public class UAICmd_Attack_ThrowWeapon : UAICmd_Attack_Range
{
  public float ThrowPitch;
  public float DistStep;
  public ASFWeapon CurWeapon;
  public int LoopCount;
  public string ProjectileClassName;
  public UClass ProjClass;
}

public class UAICmd_Attack_ZombieMelee : UAICmd_Attack_Melee
{
  public float CombatStateDistance;
}

public class UAICmd_Base_UtilitySelectedCmd : USFAICommand
{
}

public class UAICmd_Base_UtilActionSelector : UAICmd_Base_UtilitySelectedCmd
{
  public List<UUtilBasedAICmdMetaDataPacket> PossibleCommands;
}

public class UAICmd_EvadeGrenade : USFAICommand
{
  public FVector MoveDir;
  public FVector TargetPosition;
  public float WaitTimeMin;
  public float WaitTimeMax;
  public ASFProjectile EvadeProj;
  public ASFPawn ProjInstigator;
}

public class UAICmd_FullBodyAnimation : USFAICommand
{
  public FVector AnimFocus;
  public int AnimIndex;
  public FName AnimName;
  public float StartTime;
  public float PlayingTimeLeft;
  public float fWanaPlayTime;
}

public class UAICmd_MoveToMesh : USFAICommand
{
  public bool bSavedIgnoreStepAside;
  public List<FVector> ValidPositionOnMesh;
  public FVector BestValidPosition;
  public float ValidSearchRadius;
}

public class UAICmd_MoveToDir : UAICmd_MoveToMesh
{
  public float MoveDist;
  public FVector MoveDir;
}

public class UAICmd_MoveToGoal_Jump : USFAICommand
{
  public FVector vTargetDir;
  public float fTargetDist;
  public int JumpMoveSpeed;
}

public class UAICmd_MoveToGoal_Mesh : USFAICommand
{
  public bool bValidRouteCache;
  public bool bCanPathfind;
  public bool bAllowPartialPath;
  public bool bFinalApproach;
  public bool bHastriedToEscapeFromAnchor;
  public bool bSavedIgnoreStepAside;
  public FVector IntermediatePoint;
  public FVector LastMovePoint;
  public int NumMovePointFails;
  public int MaxMovePointFails;
  public FVector InitialFinalDestination;
  public FVector FailSafeDestination;
  public AActor.FBasedPosition LastMoveTargetPathLocation;
  public float FinalApproachTime;
}

public class UAICmd_MoveToGoal_Roaming : UAICmd_MoveToGoal_Mesh
{
}

public class UAICmd_MoveToGoal_PointRoaming : UAICmd_MoveToGoal_Roaming
{
  public float StartTime;
  public float StayTime;
  public float RoamingTime;
  public float lapTime;
}

public class UAICmd_MoveToGoal_SuppressiveTarget : UAICmd_MoveToGoal_Roaming
{
  public float StartTime;
  public float StayTime;
  public float RoamingTime;
  public float lapTime;
  public FVector BaseLocation;
}

public class UAICmd_MoveToGoal_Tactic : UAICmd_MoveToGoal_Mesh
{
  public float NeedMoveDelay;
}

public class UAICmd_MoveToGoal_Wandering : USFAICommand
{
  public bool bValidRouteCache;
  public bool bNotifyBumped;
  public bool bWanderingSprint;
  public FVector IntermediatePoint;
  public FVector InitialFinalDestination;
  public int WanderDistance;
  public float WanderJitter;
  public FVector WanderTargetDir;
  public FVector WanderTarget;
  public float JitterThisTimeSlice;
  public float MoveDurationTime;
  public int NeedUpdateCount;
  public FVector BumpedDir;
}

public class UAICmd_StepAside : USFAICommand
{
  public AActor.FBasedPosition PreStepAsideLocation;
  public AActor.FBasedPosition StepAsideLocation;
  public bool bDelayStep;
}

public class UAIObjectAvoidanceInterface : UInterface
{
}

public class UAIReactChannel : UObject
{
  public FName ChannelName;
  public bool bNeedsPoll;
  public bool bChannelSuppressed;
  public List<UAIReactCondition_Base> Reactions;
}

public class UAIReactChan_Damage : UAIReactChannel
{
  public APawn DamageInstigator;
  public bool bDirectDamage;
  public UClass DamageType;
  public AActor.FTraceHitInfo HitInfo;
  public FVector LastInstigatorLoc;
  public int DamageAmt;
}

public class UAIReactChan_Timer : UAIReactChannel
{
}

public class UAIReactCondition_Base : UObject
{
  public List<FName> AutoSubscribeChannels;
  public List<FName> SubscribedChannels;
  public bool bSuppressed;
  public bool bAlwaysNotify;
  public bool bActivateWhenBasedOnInterpActor;
  public bool bActivateWhenBasedOnPawn;
  public bool bOneTimeOnly;
  public float TimerInterval;
  public float TimerLastActivationTime;
}

public class UAIReactCond_BombSupport : UAIReactCondition_Base
{
}

public class UAIReactCond_Conduit_Base : UAIReactCondition_Base
{
  public FName OutputChannelName;
  public float MinTimeBetweenActivations;
  public float LastActivationTime;
  public FScriptDelegate __OutputFunction__Delegate;
}

public class UAIReactCond_DmgFromOtherEnemy : UAIReactCond_Conduit_Base
{
}

public class UAIReactCond_DmgThreshold : UAIReactCond_Conduit_Base
{
  public int CurrentDamage;
  public int DamageThreshold;
}

public class UAIReactCond_EnemyAttack : UAIReactCondition_Base
{
  public float AttackNotifyThreshold;
}

public class UAIReactCond_EnemyCloseAndVisible : UAIReactCond_Conduit_Base
{
  public float DistanceThreshold;
}

public class UAIReactCond_EnemyCloseEnoughToMelee : UAIReactCond_EnemyCloseAndVisible
{
}

public class UAIReactCond_EnemyInsight : UAIReactCond_Conduit_Base
{
}

public class UAIReactCond_EnemyMoved : UAIReactCond_Conduit_Base
{
  public class FLastThreshPosPair
  {
    public APawn Enemy;
    public UObject.FVector Position;
  }

  public float DistanceThreshold;
  public List<FLastThreshPosPair> EnemyTreshList;
  public int RingBufIndex;
}

public class UAIReactCond_EnemyOutOfRange : UAIReactCond_Conduit_Base
{
  public float Range;
}

public class UAIReactCond_EnemyVisibleForThresh : UAIReactCond_Conduit_Base
{
  public float SeenThresh;
}

public class UAIReactCond_GenericCallDelegate : UAIReactCondition_Base
{
  public float MinTimeBetweenOutputsSeconds;
  public float LastOutputTime;
  public FScriptDelegate __OutputFunction__Delegate;
}

public class UAIReactCond_GenericPushCommand : UAIReactCondition_Base
{
  public UClass CommandClass;
  public float MinTimeBetweenOutputsSeconds;
  public float LastOutputTime;
}

public class UAIReactCond_Grenade : UAIReactCondition_Base
{
}

public class UAIReactCond_HealthThresh : UAIReactCond_Conduit_Base
{
  public int HealthThreshold;
  public bool bAutoSuppressAfterInitialTrigger;
}

public class UAIReactCond_NewEnemy : UAIReactCond_Conduit_Base
{
  public float TimeSinceSeenThresholdSeconds;
}

public class UAIReactCond_SurpriseEnemyLoc : UAIReactCond_Conduit_Base
{
}

public class UAIReactCond_Targeted : UAIReactCondition_Base
{
  public APawn shooter;
  public float ShooterRangeThreshold;
  public float LookToTargetThreshold;
  public bool bOnlyInstantHitWeapon;
}

public class ASFSquad : AInfo
{
  public class FDelayUpdateInfo
  {
    public EPerceptionType Type;
    public APawn Pawn;
    public float UpdateTime;
    public FName EventName;
  }

  public class FSquadMemberInfo
  {
    public AController Member;
    public float EnemyDist;
    public float LastUpdateTime;
  }

  public class FsEnemyInfo
  {
    public float LastUpdateTime;
    public AActor Target;
    public UObject.FVector KnownLocation;
    public AActor Base;
    public float InitialSeenTime;
    public float LastSeenTime;
    public float LastNotifyTime;
    public float MaxChargePoint;
    public float NowChargePoint;
  }

  public class FsSquadChargePoint
  {
    public ESquadTargetType TargetType;
    public float MaxChargePoint;
  }

  public FName SquadName;
  public ASFTeamInfo Team;
  public List<FSquadMemberInfo> SquadMembers;
  public AController SquadLeader;
  public ASFSquad NextSquad;
  public ASFSquadFormation Formation;
  public float FormationSize;
  public bool bPlayerSquad;
  public bool bFreelance;
  public bool bFreelanceAttack;
  public bool bFreelanceDefend;
  public bool bInterSquadCommunication;
  public ASFModeVolume SquadStrategicPoint;
  public ANavigationPoint RouteObjective;
  public List<ANavigationPoint> ObjectiveRouteCache;
  public List<ANavigationPoint> PreviousObjectiveRouteCache;
  public FName CurrentOrders;
  public float GoalDistance;
  public int MaxSquadSize;
  public int Size;
  public FsEnemyInfo EnemyInfo;
  public List<FsSquadChargePoint> SquadChargePoints;
  public List<FDelayUpdateInfo> DelayUpdateList;
  public float LastTimeUpdateTakeDamages;
  public float LastTimeUpdateMemberInfo;
  public int UpdateMemberIdx;
}

public class UAIReactionManager : UObject
{
  public class FIntrinsicChannel
  {
    public FName ChannelName;
    public UClass ChannelClass;
  }

  public List<FIntrinsicChannel> IntrinsicChannels;
  public Dictionary<byte, byte> ChannelMap;
  public UClass DefaultChannelClass;
  public List<UAIReactChannel> PollChannels;
  public bool bAllReactionsSuppressed;
  public List<UAIReactChannel> BasicPerceptionChannels;
}

public class UAIVisibilityManager : UObject
{
  public int ControllerIttStartPoint;
  public bool bDrawVisTests;
  public FPointer FreeLineCheckResList;
  public FPointer BusyLineCheckResList;
  public FPointer PendingLineCheckHead;
  public FPointer PendingLineCheckTail;
}

public class UCheckpoint : UObject
{
  public class FLevelRecord
  {
    public FName LevelName;
    public bool bShouldBeLoaded;
    public bool bShouldBeVisible;
    public bool bShouldBlockOnLoad;
  }

  public class FActorRecord
  {
    public string ActorName;
    public int ActorUniqueID;
    public string ActorClassPath;
    public List<byte> RecordData;
  }

  public class FInstigatorActorRecord
  {
    public string ActorName;
    public int ActorUniqueID;
    public string ActorClassPath;
    public int InstigatorPlayerID;
    public bool bStaticActor;
  }

  public List<FLevelRecord> LevelRecords;
  public List<byte> KismetData;
  public List<FActorRecord> ActorRecords;
  public List<FActorRecord> LoginActorRecords;
  public List<FInstigatorActorRecord> InstigatorActorRecords;
  public List<UClass> ActorClassesToDestroy;
  public List<UClass> LoginActorClasses;
  public List<UClass> PauseActorClasses;
  public List<UClass> ExcludeInstigatorClasses;
  public List<UClass> DontSpawnClasses;
}

public class ACombatZone : AVolume
{
  public string ZoneName;
  public int WavePointsRemaining;
  public FGuid ZoneGuid;
  public byte MaxOccupants;
  public byte MaxResidents;
  public byte DelayMovesForTeam;
  public ECombatZoneType ZoneType;
  public EMoveOverride MovementModeOverride;
  public List<APawn> PendingOccupants;
  public List<APawn> Occupants_RED;
  public List<APawn> Occupants_BLUE;
  public List<APawn> Residents_RED;
  public List<APawn> Residents_BLUE;
  public float Priority_RED;
  public float Priority_BLUE;
  public bool bEnabled;
  public bool bDelayMovesAtMaxOccupancy;
  public List<FActorReference> CoverSlotRefs;
  public List<FActorReference> MyNavRefs;
  public AFauxPathNode NetworkNode;
  public FVector ZoneCenter;
  public List<AActor> AmbushTargets;
}

public class UCombatZoneRenderingComponent : UPrimitiveComponent
{
}

public class UDrawSphereComponentWhenSelecting : UDrawSphereComponent
{
}

public class ADynamicSMActorNoSyncSpawnable : ADynamicSMActor_Spawnable
{
}

public class AFauxPathNode : ANavigationPoint
{
}

public class UGoal_SquadFormation : UPathGoalEvaluator
{
  public class FFormationEvalInfo
  {
    public int PosIdx;
    public AActor QueryActor;
    public Dictionary<byte, byte> ActorList;
  }

  public List<FFormationEvalInfo> PositionList;
  public ASFAIController SeekerAI;
  public int PositionIdx;
  public ASFSquadFormation Formation;
}

public class AHelicopter : AInterpActor
{
  public FName currState;
}

public class UInterface_AIAttackWarning : UInterface
{
}

public class UInterface_AIMoveFailed : UInterface
{
}

public class ULeapReachSpec : UAdvancedReachSpec
{
  public FVector CachedVelocity;
  public float RequiredJumpZ;
}

public class UMaterialExpressionSFTextureWorldCube : UMaterialExpressionTextureSampleParameterCube
{
}

public class UNavMeshPath_AvoidPoint : UNavMeshPathConstraint
{
  public List<FVector> AvoidPoints;
  public float AvoidDistance;
  public float MuxCost;
}

public class ARB_NailActor : ARB_ConstraintActorSpawnable
{
}

public class USeqAct_AIMove : USequenceAction
{
  public float TetherDistance;
  public ERouteDirection RouteDirection;
  public EAIMoveStyle MovementStyle;
  public List<AActor> MoveTargets;
  public List<AActor> FocusTarget;
  public bool bInterruptable;
  public bool bClearTetherOnArrival;
  public List<ASFAIController> AITargets;
  public List<ASFAIController> AIReachedGoal;
  public int DestinationSlotIndex;
  public List<AActor> AvailableTethers;
}

public class USeqAct_AISetTarget : USequenceAction
{
  public List<AActor> FocusTargets;
  public bool bOverwriteExisting;
  public bool bForceFireAtTarget;
  public bool bForceFireEvenWhenNoLos;
}

public class USFSeqAct_SFGameInfo : USequenceAction
{
  public FName FunctionName;
  public int InputLinkIndex;
}

public class USeqAct_ChangeStandardActorForCombatZone : USFSeqAct_SFGameInfo
{
}

public class USeqAct_SFExitVehicle : USequenceAction
{
  public AActor TargetVehicle;
}

public class USeqEvent_Interaction : USequenceEvent
{
  public bool bCheckInteractDistance;
  public bool bCheckInteractFOV;
  public float InteractDistance;
  public float InteractFOV;
}

public class USeqEvt_VehicleDriven : USequenceEvent
{
}

public class ASFHUD : AGameHUD
{
  public class FS_CROSSHAIR
  {
    public float InnerWidth;
    public float BarLength;
    public UObject.FColor Color;
  }

  public class FPawnInfo
  {
    public ASFPawn SFPawn;
    public ASFPlayerReplicationInfo SFPRI;
    public float Visibility;
    public bool bIsVisible;
  }

  public class FDamageInfo
  {
    public AActor Instigator;
    public float FadeTime;
    public float FadeValue;
    public UObject.FVector Direction;
    public UMaterialInstanceConstant MatConstant;
  }

  public class FMessageDispatchInfo
  {
    public UClass MessageClass;
    public bool bDisplayToSpecator;
    public bool bDisPalyToLocalPRI;
  }

  public class FHitMarkInfo
  {
    public UObject.FVector HitLocation;
    public UObject.FVector HitScreenLocation;
    public float DrawTime;
    public float MaxDrawTime;
  }

  public ASFPlayerController SFPlayerOwner;
  public ASFPawn ViewTargetPawn;
  public ASFPlayerReplicationInfo SFOwnerPRI;
  public ASFGameReplicationInfo SFGRI;
  public ASFUIMinimapRadar Radar;
  public int GFxMiniMapFrameSize;
  public int GFxWholeMapFrameSize;
  public bool bMSGSprintUsing;
  public bool bAdjustBlurEffect;
  public bool CheckCrosshairClassName;
  public bool bShowUSNScoreboard;
  public bool bShowDeadPersonCam;
  public bool IsTeamChange;
  public bool bShowHitMarkWhenZoom;
  public bool bLastShowHitMarkProjectionLocation;
  public bool bShowAttackBriefOnly;
  public bool bHideRadarTeamBase;
  public bool bIsSpectatingHUD;
  public bool bIsOldSpectatingHUD;
  public bool bObserverHUD;
  public bool bGameInProgressHUD;
  public bool bBlackOutInLeague;
  public bool bShowWeaponNameOfObserverMode;
  public bool bRadioMessageDisable;
  public bool bEnableKillHeadUpIcon;
  public bool bFirstScoreUpAnimation;
  public bool bShowKillFeedBack;
  public bool bShowStunIcon;
  public bool IsZombieHPBar;
  public bool bVoteKickPopUpOpened;
  public bool bShooterHeadUpUI;
  public bool bReportButtonDisableGameMode;
  public bool bDeclareButtonDisableGameMode;
  public bool bShowGlowModeScore;
  public bool bHideMiniMap;
  public bool bHideGrenadeIndicator;
  public float ScreenRatio;
  public float InverseClipXForFlash;
  public float InverseClipYForFlash;
  public UBlurEffect BlurEffect;
  public float GasEffectUpdateTime;
  public int GasEffectBaseKernelSize;
  public UClass CrossHairClass;
  public List<USFCrosshairBase> CrosshairBase;
  public int CrosshairIndex;
  public FS_CROSSHAIR Crosshair;
  public FS_CROSSHAIR CrosshairByHit;
  public FColor CrosshairDefaultColor;
  public FColor CrosshairByHitDefaultColor;
  public float SpreadRatio;
  public float DomRatio;
  public float DomLengthRatio;
  public float MovingRatio;
  public float CrosshairRatio;
  public float CrosshairThickness;
  public float HitCrosshairRunningTime;
  public float HitCrosshairColorRunningRatio;
  public float HitCrosshairInterpExp;
  public float OutlineWidth;
  public float OutlineExtLength;
  public FColor OutlineColor;
  public FColor OutlineColorEx;
  public FColor OutlineHitColor;
  public FColor AimedWeakpointColor;
  public FColor AimedWeakpointOutlineColor;
  public float StandardVerticalSize;
  public List<FPawnInfo> PawnList;
  public List<FPawnInfo> PawnListSnowStun;
  public List<FPawnInfo> PawnListKilled;
  public List<FPawnInfo> PawnListArrowIcon;
  public List<FPawnInfo> PawnListOpserverStun;
  public APlayerReplicationInfo KilledMePRI;
  public List<USFTypes.FSObjectIcon> ObjectIconList;
  public List<USFTypes.FSObjectIconBind> ObjectIconBindArray;
  public EPawnIconState PrevViewtargetIconState;
  public EHUDActionMsg CurrentActionMessage;
  public EHUDScoreType ScoreType;
  public AVolume PrevViewtargetLocationVolume;
  public string ASiteText;
  public string BSiteText;
  public string CSiteText;
  public string GoalSiteText;
  public float SelectWeaponSetMessageDelay;
  public string GameModeClassName;
  public string AttackText;
  public string DefendText;
  public List<FDamageInfo> DamageData;
  public int MaxNoOfIndicators;
  public float HitIndicatorSize;
  public float HitIndicatorFadeTime;
  public float HitIndicatorFadeValue;
  public FLinearColor HitIndicator_Color;
  public UMaterial DamageIndicatorMaterial;
  public FName PositionalParamName;
  public FName FadeParamName;
  public FName ColorParamName;
  public string SpectatorMessage;
  public string KillCamMessage;
  public string[] BriefMessage = new string[8];
  public string[] ObjectMessage = new string[8];
  public string[] WinCaseMessage = new string[8];
  public string[] RoundStart_ResultMessage = new string[3];
  public string[] RoundEnd_ResultMessage = new string[5];
  public string[] ObserverRoundEndMessage = new string[8];
  public string RoundEnd_NowScore;
  public string[] MatchEnd_ResultMessage = new string[2];
  public string[] ObserverMatchEndMessage = new string[8];
  public string UserGameInMessage;
  public string UserGameOutMessage;
  public string DisconnectedFromHost;
  public string ReconnectedFromHost;
  public string TakeScreenShot;
  public List<string> TeamChangeMessage;
  public string MouseSensitivityChangeMsg;
  public string Pending_WaitingForPlayer;
  public string MSG_InGameExitDialogTitle;
  public string strInGameExitMessage;
  public List<USFGFxHUDMoviePlayer> HUDMovieArray;
  public UClass GFxHUDWeaponChangeClass;
  public UClass GFxHUDScoreBoardClass;
  public UClass GFxHUDObserverScoreBoardClass;
  public List<UClass> GFxHUDAdditionalClassArray;
  public string RoundMessage;
  public string SFRevision;
  public int ResultWindowMessageIndex;
  public List<USFTypes.FSHUDActionMsg> ActionMessageArray;
  public List<int> ActionIndexOrderArray;
  public USFOnlineSubsystemPC OnlineSub;
  public int[] PrevTeamScore = new int[8];
  public int[] PrevSendTeamScore = new int[8];
  public float SystemMsgLimitTime;
  public float BaseHUDWidth;
  public float BaseHUDHeight;
  public USFWavePlayer[] MessageWavePlayer = new USFWavePlayer[25];
  public USFWavePlayer WavePlayer;
  public int nGoalRound;
  public FMessageDispatchInfo[] MessageDispatchInfos = new FMessageDispatchInfo[25];
  public float HitMarkStateInflectionTime;
  public float HitMarkStateMaxRatio;
  public float HitMarkStateMinRatio;
  public float HitMarkCenterCrossPlayTime;
  public float HitMarkMultiCrossPlayTime;
  public float HitMarkSingleEdgeSize;
  public float HitMarkInnerEdgeSize;
  public FColor HitMarkColor;
  public List<FHitMarkInfo> HitMarkInfos;
  public List<bool> ChatTypeSupportArray;
  public float fOldDeltaSeconds;
  public APlayerReplicationInfo UpdateSpectatingPRI;
  public APlayerReplicationInfo OldUpdateSpectatingPRI;
  public int UpdateInGameScoreTime;
  public List<EHUDActionMsg> ActionMessageNotVisibleArray;
  public float CloseChangingTeamAniDuration;
  public float CloseMatchEndedAniDuration;
  public int nHoldHUDImageSize;
  public List<int> ProtocolAtChatMsgArray;
  public USFGFxLobbyInGame InGameLobbyManager;
  public string ViewPawnCodeName;
  public List<int> ViewPawnKilledArray;
  public int CodeNameDisplayFlags;
  public List<int> TeamCodeNameDisplayFlags;
  public int MinimapDisplayFlags;
  public float MinimapShowEnemyTime;
  public float MinimapShowEnemyStartTime;
  public int HUD_KDACount_HideType;
  public USFRenderTextureManager RenderTextureManager;
  public int OpenedPingScoreboards;
  public List<EWeaponType> OnlyUsablePrimaryWeaponTypeArray;
  public USFUIDataStore_PlayerInfo PlayerInfoDataStore;
  public USFUIDataStore_RoomUserList RoomUserListDataStore;
  public USFUIDataStore_RoomSetting RoomSettingDataStore;
  public string GlowModeScoreText;
  public int BlinkAniHpCondition;
  public int BlinkAniInterval;
  public FScriptDelegate __RegisterObjectIcon__Delegate;
  public FScriptDelegate __ChangeObjectIconState__Delegate;
  public FScriptDelegate __UnRegisterObjectIconByType__Delegate;
  public FScriptDelegate __IsAlreadyObjectIconRegister__Delegate;
  public FScriptDelegate __RegisterObjectIconDirect__Delegate;
  public FScriptDelegate __OpenGameExitDialog__Delegate;
  public FScriptDelegate __OnTargetSeizuredDelegate__Delegate;
  public FScriptDelegate __OnSetKeyInfoMinimize__Delegate;
  public FScriptDelegate __ActionMessageSortDelegate__Delegate;
  public FScriptDelegate __AddCombatMessage__Delegate;
  public FScriptDelegate __AddCombatMessageWithMission__Delegate;
  public FScriptDelegate __AddCombatMessageWithMissionLogOutUser__Delegate;
  public FScriptDelegate __ResetMissionGauge__Delegate;
  public FScriptDelegate __ResetConvoyanceGauge__Delegate;
  public FScriptDelegate __AddMessage__Delegate;
  public FScriptDelegate __RemoveMessage__Delegate;
  public FScriptDelegate __ShowHUDChattingMessageList__Delegate;
  public FScriptDelegate __ASShowRemainTime__Delegate;
  public FScriptDelegate __ASHideReaminTime__Delegate;
  public FScriptDelegate __OpenWeaponSetChange__Delegate;
  public FScriptDelegate __HideRadioMessageMenu__Delegate;
  public FScriptDelegate __SetEnableChatSendType__Delegate;
  public FScriptDelegate __SetChatSendType__Delegate;
  public FScriptDelegate __AddHUdChatMessage__Delegate;
  public FScriptDelegate __NotifyChatMessageSended__Delegate;
  public FScriptDelegate __NotifyChatMessageReceived__Delegate;
  public FScriptDelegate __NotifyMsgrChatMessageSended__Delegate;
  public FScriptDelegate __NotifyMsgrChatMessageReceived__Delegate;
  public FScriptDelegate __ChangedLapTime__Delegate;
  public FScriptDelegate __InitKillFeedBackList__Delegate;
  public FScriptDelegate __OnSetFastWave__Delegate;
  public FScriptDelegate __OnSetSeeThroughTime__Delegate;
  public FScriptDelegate __NotifySetSelectEqipSlot__Delegate;
  public FScriptDelegate __UpdateEquipData__Delegate;
  public FScriptDelegate __UpdateEquipSlot__Delegate;
  public FScriptDelegate __UpdateAmmoCount__Delegate;
  public FScriptDelegate __ShowAimCursorShooterDefence__Delegate;
  public FScriptDelegate __HideAimCursorShooterDefence__Delegate;
  public FScriptDelegate __OpenPushCarGauge__Delegate;
  public FScriptDelegate __ClosePushCarGauge__Delegate;
  public FScriptDelegate __SetConvoyanceSeizureAmount__Delegate;
  public FScriptDelegate __OpenConvoyanceSeizureIcon__Delegate;
  public FScriptDelegate __CloseConvoyanceSeizureIcon__Delegate;
  public FScriptDelegate __SetForceModeInfo__Delegate;
  public FScriptDelegate __UpdateToZombieHideSeekKillCount__Delegate;
  public FScriptDelegate __OnVideoCaptureModeChanged__Delegate;
  public FScriptDelegate __OnTwitchTVModeChanged__Delegate;
}

public class ASFTeamHUD : ASFHUD
{
}

public class ASF16VS16ModeHUD : ASFTeamHUD
{
}

public class USFLocalMessage : ULocalMessage
{
  public int MessageArea;
  public int AnnouncementPriority;
  public float AnnouncementVolume;
  public FName SoundGroupName;
  public bool bRemoveSamePriorMessage;
}

public class USFActionMessage : USFLocalMessage
{
  public class FActionMessageData
  {
    public eActionMessageType Type;
    public List<string> strIconKeyArray;
    public string strMessage;
  }

  public List<FActionMessageData> ActionStrings;
  public List<string> ProhibitionStrings;
  public List<USFTypes.FsEmoticonData> EmoticonStrings;
}

public class ASFAddHealthMutator : AMutator
{
  public int AddedHealth;
  public bool bAllowBot;
  public ETeam AvailableTeam;
}

public class ASFAddBossHealthMutator : ASFAddHealthMutator
{
}

public class USFAggroSystem : UObject
{
  public class FsAggrDist
  {
    public float Waiting;
    public float UDist;
  }

  public class FsAWaitTime
  {
    public float FarWait;
    public float MidWait;
    public float NearWait;
    public List<USFAggroSystem.FsAggrDist> AggrDists;
  }

  public class FsAINoise
  {
    public EAINOISE_TYPE Type;
    public float Dist;
    public float UDist;
  }

  public class FsAggro
  {
    public APawn Target;
    public float Dist;
    public bool bSight;
    public bool bEngage;
    public EAINOISE_TYPE NoiseNow;
    public float LastUpdate;
  }

  public List<FsAWaitTime> AwaitDefList;
  public List<float> AINoiseLevelList;
  public List<FsAINoise> AINoiseDefList;
  public List<FsAINoise> AINoiseList;
  public List<float> AggroChaseTime;
  public List<FsAggro> AggroList;
  public FsAWaitTime AwaitTime;
  public ASFAIController Owner;
  public float LastUpdateTime;
  public float AggroDPS;
  public float RecommRange;
  public int MaxAggroMultiplier;
  public ASFGameReplicationInfo SFGRI;
}

public class USFSeqAct_AIFactory : USequenceAction
{
  public class FAISpawnInfo
  {
    public EAITypes AIType;
    public int SpawnTotal;
    public int MaxAlive;
    public int SpawnedCount;
    public List<APawn> WatchList;
    public float MaxSpawnDelay;
    public float MinSpawnDelay;
    public float CurrentDelay;
    public List<EInventoryTypes> WeaponLoadOut;
    public bool bGiveDefaultInventory;
    public List<string> VarLinkDescs;
    public List<string> OutLinkDescs;
    public List<APawn> CurrentSpawns;
    public UClass PawnClass;
    public UClass ControllerClass;
    public List<UClass> LoadoutClasses;
    public string PawnName;
    public ETeam TeamIndex;
    public FName SquadName;
    public bool bSquadLeader;
    public FName ActorTag;
    public string AutoDebugText;
    public bool bAllowDeleteWhenStale;
    public int DropItemCount;
  }

  public class FAITypeInfo
  {
    public EAITypes AIType;
    public FName ControllerClassName;
    public FName PawnClassName;
    public int TeamIdx;
    public bool bUnique;
  }

  public List<FName> InventoryTypeNames;
  public List<FAISpawnInfo> SpawnSets;
  public List<FAITypeInfo> SpawnInfo;
  public List<AActor> SpawnPoints;
  public bool bAllSpawned;
  public bool bAllDead;
  public bool bAbortSpawns;
  public bool bSuppressAllDead;
  public bool bActivatedDeadLink;
  public bool bResetDeadLinkCount;
  public int DeadCount;
  public int NumDead;
  public int ActivateDeadLinkCount;
  public ESpawnPointSelectionMethod SpawnPointSelectionMethod;
}

public class USFAI_Info : UObject
{
  public class FEnemyWeapon
  {
    public int Set;
    public int Slot;
    public EInventoryTypes WeaponType;
    public int WeaponID;
    public float AIRating;
  }

  public class FEnemySpawnInfo
  {
    public EAITypes AIType;
    public bool bIsBoss;
    public List<EInventoryTypes> WeaponTypes;
    public int MinWave;
    public int MaxWave;
    public int MinCount;
    public int MaxCount;
    public int WaveCost;
    public int SquadCharge;
  }

  public List<FEnemyWeapon> AIWeapons;
  public List<FEnemySpawnInfo> AIList;
  public List<int> BossWaves;
  public string AI_CombatType_Melee;
  public string AI_CombatType_Range;
  public string AI_CombatType_Hide;
  public string AI_AttackType_Claw;
  public string AI_AttackType_RecoverHealth;
  public string AI_AttackType_Kamikaze;
  public string AI_AttackType_Dash;
  public string AI_AttackType_Split;
  public string AI_AttackType_Adrenalin;
}

public class ASFAIController : AGameAIController
{
  public class FLocalEnemyInfo
  {
    public APawn Pawn;
    public float AcquireTime;
    public bool bSeenLastFrame;
    public bool bVisible;
    public float InitialVisibleTime;
    public float LastVisibleTime;
    public UObject.FVector LastSeenPos;
    public UObject.FVector LastSeeingPos;
    public float LastFailedPathTime;
    public UObject.FVector AsyncVisibleLocation;
    public bool bEnemyInfoValid;
  }

  public class FInvalidAnchorItem
  {
    public ANavigationPoint InvalidNav;
    public float InvalidTime;
  }

  public class FsCandidateTarget
  {
    public APawn Target;
    public float Dist;
    public int Score;
    public int Health;
  }

  public class FsTakeDamageTable
  {
    public AController Attacker;
    public int Damage;
  }

  public UAIReactionManager ReactionManager;
  public List<UAIReactCondition_Base> DefaultReactConditions;
  public List<UClass> DefaultReactConditionClasses;
  public USFAICommand CachedAICommand;
  public bool RelayAICommandWhenNotify;
  public bool bReachedMoveGoal;
  public bool bMoveGoalInterruptable;
  public bool bMovingToGoal;
  public bool bMovingToTether;
  public bool bReachedTether;
  public bool bWantsLedgeCheck;
  public bool bAlwaysSkipLedgeChecks;
  public bool bReevaluatePath;
  public bool bIgnoreStepAside;
  public bool bIgnoreSquadPosition;
  public bool bAllowCombatTransitions;
  public bool bShouldSprint;
  public bool EnemyFriendly;
  public bool Freeze;
  public bool bDoingMeleeAttack;
  public bool bCombatResult;
  public bool bAttacked;
  public bool bNeverDie;
  public bool bIgnoreInTeamMember;
  public bool bIsTargeting;
  public bool bDebugHeard;
  public bool bIgnoreFireRange;
  public bool bAdjustFlashBangEffect;
  public bool bTargetInsight;
  public UClass DefaultAttackClass;
  public USeqAct_AIMove MoveAction;
  public AActor StepAsideGoal;
  public float MaxStepAsideDist;
  public AActor MoveGoal;
  public FBasedPosition MovePosition;
  public AActor MoveFocus;
  public float MoveOffset;
  public float IntermediatePointArrivalDist;
  public FBasedPosition TetherPosition;
  public float LastObstructionTime;
  public float LastDetourCheckTime;
  public float LastMoveFinishTime;
  public float LastFailedToFindStepAsideLocation;
  public FRotator Debug_StepRot;
  public FBasedPosition Debug_StepLoc;
  public float EnemyAquisitionTime;
  public float LastShotAtTime;
  public float ChanceToEvade;
  public float ChanceToEvadeGrenade;
  public ASFSquad Squad;
  public FVector LastSquadLeaderPosition;
  public float LastActionTransitionTime;
  public float TargetAquisitionTime;
  public float DamageReceivedInAction;
  public float LastDamageReceivedTime;
  public UClass DefaultCommand;
  public float LastEnterIdleTime;
  public ELevelOfDifficulty Difficulty;
  public float SearchLaneMultiplier;
  public List<FLocalEnemyInfo> LocalEnemyList;
  public List<FInvalidAnchorItem> InvalidAnchorList;
  public float Response_MinEnemySeenTime;
  public float Response_MinEnemyHearTime;
  public float Response_MinEnemyHurtTime;
  public float Response_EnemyTooLongNoSeeTime;
  public AActor FireTarget;
  public AActor SavedTarget;
  public AActor BumpedActor;
  public AActor RoamingTarget;
  public FVector RoamingTargetLoc;
  public ASFPawn_AI MySFAIPawn;
  public float EnemyDistance_Short;
  public float EnemyDistance_Medium;
  public float EnemyDistance_Long;
  public float EnemyDistance_Melee;
  public USFSeqAct_AIFactory SpawnFactory;
  public float fGoalDistance;
  public float LastTimeCheckNearstEnemy;
  public float GrenadeEvadeAwayRatio;
  public APawn LastestOffendEnemy;
  public float LastUnderFire;
  public float RecognizeRadius;
  public List<FsCandidateTarget> CandidateTargets;
  public AActor PendingMovetoTarget;
  public AActor PendingAttacker;
  public float TargetMovedReactionDist;
  public List<AActor> UnreachableTargets;
  public int FailSetTarget;
  public float fCommandElapsedTime;
  public int AIID;
  public float LastEvadeTime;
  public float MinTimeBetweenEvades;
  public FName OldMessageType;
  public float OldMessageTime;
  public AActor ScriptedTarget;
  public AActor TemporaryFocus;
  public ACombatZone PendingCombatZone;
  public ACombatZone CurrentCombatZone;
  public FName NOISETYPE_FootStep;
  public FRotator GrenadeThrowDirection;
  public float SimProjectileExtraGravity;
  public float CoolTimeBombingSupport;
  public USFAggroSystem AggroSys;
  public UClass DefaultAggroSystemClass;
  public float LureProjectileAggroDist;
  public float LureProjectileAttackDist;
}

public class ASFAIController_Aliens : ASFAIController
{
  public List<USFTypes.FsBossSkill> BossSkills;
  public UClass PendedBossSkill;
  public float TotalBossSkillRate;
  public float SkillActiveCheckTerm;
  public float LastSkillActiveCheckTime;
  public float LastSkillFinishTime;
}

public class ASFAIController_Human : ASFAIController
{
  public class FsTacticMove
  {
    public float Base;
    public float Variation;
  }

  public bool bForAIBalance;
  public EAILevel RecklessLevel;
  public EAILevel BattleLevel;
  public EHAITYPE HumanAIType;
  public byte AILevelLast;
  public float RoamingStart;
  public List<int> CachedWeaponSet;
  public List<int> CachedPawnItemList;
  public USFTypes.FPawnInventorySet PawnInventoryInfo;
  public USFTypes.FWeaponInventorySet WeaponInventoryInfo;
  public List<FsTacticMove> TacticMoveDelays;
  public List<FsTacticMove> TacticMoveDirs;
  public List<float> SpreadAdjust;
  public List<float> PassSpecialBomb;
  public List<float> SpreadTargetMeter;
  public List<float> BackupChance;
  public List<float> BattleRotationRate;
  public List<float> SniperAvoidChance;
  public List<float> SpreadTargetDistSq;
  public APawn AimmingTarget;
  public float vsAIspread;
}

public class ASFAIController_Solider : ASFAIController_Human
{
  public FVector vDiedLocationLast;
  public float AloneRoamingLimit;
  public float AloneRoamingTime;
  public List<FsTacticMove> PointCampingStay;
  public List<FsTacticMove> PointCampingDist;
  public List<float> CampingRatio;
  public List<float> SniperCampingRatio;
  public List<float> EvadeChance;
  public float AvoidJumpCoolTime;
  public float LastAvoidJump;
  public List<AActor> PendingBombingSupportTarget;
  public bool bPendingFire;
  public float LastBomingSurportTime;
}

public class ASFAIController_Charger : ASFAIController_Solider
{
}

public class ASFAIController_TEST : ASFAIController
{
}

public class ASFAIController_Collssus : ASFAIController_TEST
{
}

public class ASFAIController_ConvoyTarget : ASFAIController
{
  public ASFConvoyTargetPathNode ConvoyMoveTarget;
}

public class ASFAIController_Melee : ASFAIController_Aliens
{
}

public class ASFAIController_Crawler : ASFAIController_Melee
{
}

public class ASFAIController_Dummy : ASFAIController_TEST
{
}

public class ASFAIController_FLYTEST : ASFAIController_TEST
{
  public float HoverHeight;
}

public class USFGameExplosion : UGameExplosion
{
  public FName EffectType;
  public UMaterialInterface ExplosionDecal;
  public FVector2D ExplosionDecalSize;
  public float ExplosionDecalThickness;
  public float ExplosionDecalLifeTime;
  public FName ExplosionDecalDissolveParamName;
  public FRotator ExplosionEmitterRotator;
  public float ExplosionSoundModeDuration;
  public bool bIgnoreMaterialbyLeaning;
  public bool IgnoreBehindExplosion;
  public bool bTraceDownardForDecal;
  public float fIgnoreMaterialLeaning;
  public List<FVector2D> ExplosionDecalDissolvePoints;
  public List<FVector> ExplosionColor;
}

public class ASFAIController_Tyrant : ASFAIController_Melee
{
  public FVector LineCheckStartLocation;
  public float ExtraRollingDistance;
  public float RollingDistance;
  public float LastRollingAttackTime;
  public float MinRollingAttackCheckTime;
  public bool bAngry;
  public bool bPengingRollingAttack;
  public float fLastAltAttackTime;
  public int NormalAttackCount;
  public USFGameExplosion ExplosionInfo;
}

public class ASFAIController_Hanger : ASFAIController_Tyrant
{
}

public class ASFAIController_Range : ASFAIController_Aliens
{
}

public class ASFAIController_Libertine : ASFAIController_Range
{
}

public class ASFAIController_Rifleman : ASFAIController_Solider
{
}

public class ASFAIController_Ripper : ASFAIController_Melee
{
}

public class ASFAIController_Sentinel : ASFAIController_TEST
{
  public ASFPawn MainTarget;
  public float ObservingRange;
  public float ObservingAngleDot;
  public FVector RealFocalPoint;
  public ASFPawnAI_Sentinel Sentinel;
}

public class ASFAIController_Vehicle : ASFAIController
{
}

public class ASFAIController_Turret : ASFAIController_Vehicle
{
  public float PeriodSearchEnemy;
  public float WarmingUpTime;
}

public class ASFAIController_ShooterTurret : ASFAIController_Turret
{
}

public class ASFAIController_Shotguner : ASFAIController_Solider
{
}

public class ASFAIController_Snatcher : ASFAIController_Melee
{
}

public class ASFAIController_Sniper : ASFAIController_Solider
{
}

public class ASFAIController_SPW : ASFAIController_Solider
{
}

public class ASFAIController_Stunner : ASFAIController_Melee
{
}

public class ASFAIController_TyrantByWarriorGame : ASFAIController_Tyrant
{
}

public class ASFAIController_Warrior_Libertine : ASFAIController_Range
{
}

public class ASFAIController_WarriorMode : ASFAIController_Melee
{
}

public class ASFAIController_WarriorCrawler : ASFAIController_WarriorMode
{
}

public class ASFAIController_WarriorRipper : ASFAIController_WarriorMode
{
}

public class ASFAIController_WormHoleBug : ASFAIController_TEST
{
  public APawn EnemyPawn;
}

public class ASFAIController_Zombie : ASFAIController_Aliens
{
  public float RoaringDistance;
  public float RoaringProbability;
  public int MinWanderingSoundInterval;
  public int MaxWanderingSoundInterval;
  public float LastWanderingSoundTime;
  public float SprintDisableDistance;
  public float MinJumpDistance;
  public float JumpIntervalTime;
  public float LastJumpTime;
}

public class ASFAIController_ZombieMelee : ASFAIController_Zombie
{
}

public class ASFAIController_ZombieDoubleWeapon : ASFAIController_ZombieMelee
{
}

public class ASFAIController_ZombieBoomer : ASFAIController_ZombieDoubleWeapon
{
}

public class ASFAIController_ZombieHideSeek : ASFAIController_Zombie
{
  public float WanderingSprintRatio;
  public float WanderingSprintDistanceRatio;
  public string ZombieName;
}

public class ASFAIController_ZombieInvincible : ASFAIController_ZombieMelee
{
}

public class ASFAIController_ZombiePuker : ASFAIController_ZombieDoubleWeapon
{
}

public class ASFAIController_ZombieTanker : ASFAIController_Tyrant
{
}

public class ASFInventoryManager : AInventoryManager
{
  public class FAmmoStore
  {
    public int Amount;
    public UClass WeaponClass;
  }

  public bool bInfiniteAmmo;
  public bool bInfiniteMagazine;
  public bool bDirtyWeaponAmmo;
  public List<FAmmoStore> AmmoStorage;
  public List<ASFWeapon> PreviousWeaponList;
  public ASFWeapon PendingSwitchWeapon;
  public float LastAdjustWeaponTime;
  public ASFWeap_Exigency ExigencyWeapon;
  public EWaitAction WaitAction;
  public EWEAPON_GROUP[] InfiniteAmmoWeaponGroup = new EWEAPON_GROUP[9];
  public EWEAPON_GROUP[] InfiniteMagazineWeaponGroup = new EWEAPON_GROUP[9];
  public float WeaponTossMaxSpeed;
  public float WeaponTossMinSpeed;
  public USFTypes.FWeaponAmmo[] WeaponAmmoInfo = new USFTypes.FWeaponAmmo[9];
  public int ShooterExigencySlot;
}

public class ASFAIInventoryManager : ASFInventoryManager
{
}

public class USFKillDeathMessage : USFLocalMessage
{
}

public class USFAIKillDeathMessage : USFKillDeathMessage
{
}

public class USFBaseEventData : UObject
{
  public FName EventType;
  public List<FName> SupportedEventsType;
  public Dictionary<byte, byte> SavedINTData;
  public Dictionary<byte, byte> InvalidINTData;
  public Dictionary<byte, byte> SavedStringData;
  public Dictionary<byte, byte> InvalidStringData;
}

public class USFWeaponEventData : USFBaseEventData
{
  public Dictionary<byte, byte> SavedINTDataByWeapType;
  public Dictionary<byte, byte> InvalidINTDataByWeapType;
  public USFChallengeListCondition ChallengeCondition;
}

public class USFSpecialKillEventData : USFWeaponEventData
{
  public int KM_Type;
  public int WeaponKM_Type;
}

public class USFAimKillCountEventData : USFSpecialKillEventData
{
}

public class ASFDroppedPickup : ADroppedPickup
{
  public UDynamicLightEnvironmentComponent MyLightEnvironment;
  public FRigidBodyState RBState;
  public float AngErrorAccumulator;
}

public class ASFDroppedPickup_Airdrop : ASFDroppedPickup
{
  public int UseCountMax;
  public float BeingTime;
  public float DropHeight;
  public float DropDelay;
  public float DropDamage;
  public float DamageRadius;
  public FVector StartVelocity;
  public int UsedCount;
  public bool bLanded;
  public UStaticMeshComponent Mesh;
  public USFGameExplosion ExplosionInfo;
  public ASFTrigger_Use LinkedTrigger;
}

public class ASFAirDrop_AmmoBox : ASFDroppedPickup_Airdrop
{
}

public class ASFAirDrop_HealthBox : ASFDroppedPickup_Airdrop
{
}

public class ASFAirPathNode : AVolumePathNode
{
}

public class ASFGameReplicationInfo : AGameReplicationInfo
{
  public class FReplicatedWeatherData
  {
    public UClass WeatherClass;
    public bool bOverrideEmitterHeight;
    public bool bUseCameraLensEffect;
    public float EmitterHeight;
    public int LODLevel;
  }

  public class FInstantBGM
  {
    public FName BGMName;
    public string BGMPath;
    public float FadeInTime;
    public float FadeOutTime;
    public float Duration;
  }

  public class FsScoreBoard
  {
    public APlayerController Player;
    public int Score;
    public int Rank;
  }

  public class FsGiveItemProbability
  {
    public int Index;
    public float fAdjProbability;
  }

  public class FProjectileEmitterData
  {
    public ASFProjectile Projectile;
    public ASFEmitterNoSyncSpawnable Emitter;
  }

  public List<USFTypes.FsDeadPawnObject> DeadPawnList;
  public bool bFirstKillAchieved;
  public bool bChangePlayerTeam;
  public bool bUseRandomRespawn;
  public bool bIsTutorialGame;
  public bool bRoundEnded;
  public bool bIsLobby;
  public bool bStartMatchInTournamentGame;
  public bool bTournamentGame;
  public bool bFreeTournamentGame;
  public bool bWakeRigidBody;
  public bool bIsMatchInProgress;
  public bool bNeedTeamScoreForShop;
  public bool bEnableGrenadeIndicator;
  public bool UseExtendDamageDepiction;
  public bool ForceAllWeaponPlayExtendDamageDepiction;
  public bool IsTopViewGame;
  public bool bVoteTargetIsMe;
  public bool PassAISpawnAnim;
  public bool UseAISpawnEffect;
  public bool bFirePitchFixed;
  public bool bDisablePrimaryMagazineUpItem;
  public bool bUsedPrimaryWeapon;
  public bool bUsedSecondaryWeapon;
  public bool bNeedRequestUserCondition;
  public bool DedicateLog;
  public bool bWaitingForGameExit;
  public byte nCurrRound;
  public byte bIsNeedToTeamChange;
  public byte bMatchEnded;
  public ETeam WinningTeam;
  public byte[] RoundWinType = new byte[8];
  public byte nWorldProjectileID;
  public EGameChannelType channelType;
  public byte UpdateInstantBGM;
  public byte IFFMode;
  public eCOMBATREPORT TypeCombatReport;
  public EWEAPON_GROUP[] CurrentInfiniteAmmoWeaponGroup = new EWEAPON_GROUP[9];
  public int RandomProvideWeapon;
  public int CustomModeType;
  public string HostPlayerName;
  public ASFPlayerController SFPCOwner;
  public FName GameInfoState;
  public FName PrevGameInfoState;
  public FName[] EndReason = new FName[8];
  public int[] RoundScore = new int[8];
  public AActor EndGameFocus;
  public USFOnlineSubsystemPC SFOnlineSub;
  public UClass AnnouncerMsgClass;
  public List<ASFProj_HG_Gas> EffectualityGasBombs;
  public List<ASFProj_HG_Function> FunctionalProj;
  public USFTemporaryObjectPool tempObjPool;
  public List<ASFSpectatorEmitter> arrSFSpectatorEmitters;
  public FReplicatedWeatherData ReplicatedWeather;
  public List<AActor> MissionActors;
  public int[] AliveMissionActors = new int[10];
  public List<FName> IgnoreInputGameInfoState;
  public ASFPlayerReplicationInfo WinningKillerPRI;
  public ASFPlayerReplicationInfo WinningKilledPRI;
  public string LogUniqueID;
  public List<string> UsageLimitItemClassList;
  public List<UClass> UsageLimitItemClassArray;
  public USFTournamentResultWriterBase TournamentResultWriter;
  public int UnPauserID;
  public ASFInGameStore InGameStore;
  public float DamageModifier;
  public float BackAttackDamageModifier;
  public int AIDifficulty;
  public float fUseFriendlyFireDamage;
  public float fAllowSelfInjury;
  public ASFBreakableGlassSyncState GlassSyncStateList;
  public List<FInstantBGM> InstantBGMList;
  public FName InstantBGMName;
  public int AreaIndex;
  public UClass HardcoreOption;
  public float ExtendDamageDepictionColorMax;
  public float ExtendDamageDepictionMeshMax;
  public float ExtendDamageDepictionTransMax;
  public int VoteProposerPID;
  public int VoteTargetPID;
  public int VoteStartTrigger;
  public int AIAutoBalanceMode;
  public int DefaultMeshUseAILevel;
  public FLinearColor defaultModePointedColor;
  public FRotator CameraBaseRotation;
  public int ChangePlayerStartGroupNumber;
  public int GameModeID;
  public int GameMapID;
  public string GameRule;
  public UParticleSystem ProjectilePS;
  public List<FProjectileEmitterData> ProjectileEmitterList;
  public List<FVector> ProjectileTeamColor;
  public List<USFTypes.FUserConditionData> UserConditionList;
  public int UserConditionMinPlaytime;
  public USFTypes.FSFeverValues FeverValues;
}

public class ASFTDGameReplicationInfo : ASFGameReplicationInfo
{
}

public class ASFAITDMGameReplicationInfo : ASFTDGameReplicationInfo
{
}

public class ASFAISniperTDMGameReplicationInfo : ASFAITDMGameReplicationInfo
{
}

public class ASFGameInfo : AGameInfo
{
  public class FSCustomModeWeapon
  {
    public List<int> CustomModePlayerProvideWeapon;
    public List<EWEAPON_GROUP> CustomModeNoUsableWeapon;
    public List<EWEAPON_GROUP> CustomModeInfiniteAmmoWeapon;
    public List<EWeaponType> CustomModeOnlyUsablePrimaryWeaponType;
    public bool RandomProvideWeapon;
  }

  public class FSTeamPlayerProvideWeapon
  {
    public List<int> PlayerProvideWeaponID;
    public ETeam Team;
  }

  public class FSKillDeathStreakBuffInfo
  {
    public int ContinualKillDeath;
    public EBuffType BuffType;
    public bool MaintainBuff;
    public float Duration;
    public float Value;
    public string WeaponItemClass;
  }

  public class FPendingKillInfo
  {
    public ASFPlayerReplicationInfo KillerPRI;
    public ASFPlayerReplicationInfo VictimPRI;
  }

  public class FsTrafficNode
  {
    public float UpdatedTime;
    public int AIID;
  }

  public class FsTrafficNav
  {
    public List<ASFGameInfo.FsTrafficNode> Traffices;
  }

  public List<FSCustomModeWeapon> CustomModeWeaponGroup;
  public int CustomModeType;
  public int EnablePickUpWeapon;
  public bool bUseRandomRespawn;
  public bool bRandomRespawnAtFirstSpawn;
  public bool bUseBaseWeaponDisappearTime;
  public bool bNotUsingInventoryInfo;
  public bool bDrawOutLineWhenGivePrimaryWeapon;
  public bool bDrawOutlineDroppedWeapon;
  public bool bUpdateTeamScoreFromKill;
  public bool bUseObserver;
  public bool bUseAI;
  public bool bUseInGameStore;
  public bool bDisablePlayerStoppingPower;
  public bool bDisableAIStoppingPower;
  public bool bDisableLandedStopping;
  public bool bAllowLoveShot;
  public bool bAllowWinningKill;
  public bool bEnableThirdPerson;
  public bool bUseAllyAI;
  public bool bSpectateOtherTeam;
  public bool bSpectatorAtInterlude;
  public bool bUseWarmupRound;
  public bool bUseWinningRoundForMatchEnd;
  public bool bIsSpawnProtectionVisible;
  public bool StartCountDownWhenMatchStart;
  public bool bPIEMode;
  public bool ShowMatchAnimation;
  public bool bUseDataStoreUserInfo;
  public bool bTestChattingMessage;
  public bool bIgnoreCheckMaxLives;
  public bool bDisplayKillMessage;
  public bool bUseKillCam;
  public bool bInfiniteAmmoMod;
  public bool bInfiniteMagazineMod;
  public bool bInfiniteAmmoFromKismet;
  public bool bInfiniteMagazineFromKismet;
  public bool bInfiniteGameTime;
  public bool bHardCoreMode;
  public bool bCheckDediValidation;
  public bool bUseDBNO;
  public bool bCanUseInstantRespawn;
  public bool bShowRespawnGauge;
  public bool bIgnoreChallengeList;
  public bool bCanUseInGameKick;
  public bool bEnableMassBoneScaling;
  public bool bExplicitPlayerStart;
  public bool bCanDropWeaponOnDeath;
  public bool bExceptAIMemberScore;
  public bool bCanUsePingNotice;
  public bool bHoldRotationInPingBoard;
  public bool IgnoreBombingSupport;
  public bool IsIngameChangeWeaponHUD;
  public ERandomRespawnType RandomRespawnType;
  public byte TimeOverWinningTeam;
  public ETeamChangeType TeamChangeType;
  public EGameMode GameModeType;
  public EGameMode SubGameModeType;
  public EWEAPON_GROUP[] InfiniteMagazineWeaponGroup = new EWEAPON_GROUP[9];
  public EIFF VoterTargetCond;
  public EGameChannelType RunningChannel;
  public USFRandomRespawn RandomRespawn;
  public float SpawnProtectionTime;
  public float WeaponDisappearTime;
  public List<EWEAPON_GROUP> NoUsableWeaponGroup;
  public List<EWeaponType> OnlyUsablePrimaryWeaponType;
  public List<string> OnlyUsableSpecialWeaponClassName;
  public List<int> ExtraUsableWeaponID;
  public List<int> PlayerProvideWeaponID;
  public List<FSTeamPlayerProvideWeapon> TeamPlayerProvideWeapon;
  public string EndGameReason;
  public float MultiKillCheckTime;
  public int NetWaitDelay;
  public int CurrentNetWaitDelay;
  public int CurrentCountDown;
  public int MatchOverDelay;
  public int RoundOverDelay;
  public int WinningKillDelay;
  public int PreRoundOverDelay;
  public int PostRoundOverDelay;
  public int MatchInProgressDelay;
  public int PreMatchInProgressDelay_Tournament;
  public int PreMatchInProgressDelay;
  public int PreMatchIntroDelay;
  public int CountDownDelay;
  public int PreCountDownDelay;
  public FColor FadeColor;
  public float DesaturationFadeInTime;
  public float MinRespawnDelay;
  public float MaxMissionScore;
  public List<FSKillDeathStreakBuffInfo> KillDeathStreakList;
  public List<EGameChannelType> ApplyKilldeathStreakChannelList;
  public UClass StreakMessageClass;
  public int MinimumCountForPerfectRound;
  public int MaximumDiffCountForPerfectRound;
  public int MinimumCountForAllKill;
  public AActor EndGameFocus;
  public ANavigationPoint[] LastStartSpot = new ANavigationPoint[8];
  public string DefaultTeamClassName;
  public USFGameMessage GameMessage;
  public string AnnouncerMessageClass;
  public string KillDeathMessageClass;
  public ASFAIVisibleControl AIVisibleControl;
  public UClass BotClass;
  public AActor DebuggingAIActor;
  public ASFAISpawnManager SpawnManager;
  public string AISpawnManagerClassName;
  public string AIVisibleControlClassName;
  public List<FPendingKillInfo> arrPendingKillInfo;
  public float LoveShotCheckDelay;
  public int nGoalRound;
  public ASFGameReplicationInfo SFGRI;
  public string DefaultPlayerStartClassName;
  public UClass DefaultPlayerStartClass;
  public int EnableSpectorModeMaxPlayingUser;
  public float GameStatDeltaTime;
  public UClass GameScoreClass;
  public string[] DefaultPawnClassName = new string[9];
  public string[] DefaultAIPawnClassName = new string[9];
  public UClass[] DefaultPawnClasses = new UClass[9];
  public UClass[] DefaultAIPawnClasses = new UClass[9];
  public string AutoBalancebyAIClassName;
  public UClass AutoBalancebyAIClass;
  public List<ACameraActor> CamActors;
  public float DropChance;
  public float MagazineCountChance;
  public string MagazineBoxName;
  public string PreMatchInProgressBGM_RED;
  public string PreMatchInProgressBGM_BLUE;
  public string MatchEndBGM_WIN;
  public string MatchEndBGM_LOSE;
  public string MatchInProgressBGM_RED;
  public string MatchInProgressBGM_BLUE;
  public string PostRoundOverBGM;
  public float PreMatchInProgress_FadeInTime;
  public float PreMatchInProgress_FadeOutTime;
  public float PreMatchInProgress_Duration;
  public float MatchEndBGM_FadeInTime;
  public float MatchEndBGM_FadeOutTime;
  public float MatchEndBGM_Duration;
  public float MatchInProgress_FadeInTime;
  public float MatchInProgress_FadeOutTime;
  public float MatchInProgress_Duration;
  public int ShareLivesPerUser;
  public int ShareLivesPerTeam;
  public int CountForSaveSituation;
  public float WaitingForNextMissionDelay;
  public float SelfShutDownWaitTime;
  public int StartingPlayers;
  public UClass ObserverPlayerControllerClass;
  public List<EWEAPON_GROUP> InfiniteAmmoWeaponGroup;
  public List<USFTypes.FWeaponAmmo> WeaponAmmoInfo;
  public int AIDifficulty;
  public float fUseFriendlyFireDamage;
  public float fAllowSelfInjury;
  public float fPauseSpawnTime;
  public float DamageModifier;
  public float BackAttackDamageModifier;
  public List<string> MutatorName;
  public List<UClass> AIHitableTargetClass;
  public int ExtraOption;
  public List<int> ModeExpTable;
  public List<int> InstantRespawnSP;
  public int InstantRespawnMinimumHoldingSP;
  public float InstantRespawnActiveDelay;
  public int InGameKickSP;
  public int InGameKickMinimumHoldingSP;
  public ASFInGameKickState InGameKickState;
  public int nUniqueAIID;
  public List<FsTrafficNav> TrafficNavs;
  public List<USFTypes.FsAjdPawnProp> AjdPawnProps;
  public int AISpawnBiasPlayerCount;
  public float ProjectileDOTPeriod;
  public float MinAgreeRateToKick;
  public float VotePeriod;
  public float VoteCoolTime;
  public float MaxProposerPerPlayer;
  public int MinVoteMemberCount;
  public float PingDelay;
  public float GlowTransitionTime;
  public List<USFUIDataProvider_MapInfo> MapDataProvider;
  public List<USFUIDataProvider_ModeInfo> ModeDataProvider;
  public List<EHackType> DefaultSuppressHackTypes;
  public ASFObstaclesActor ObstaclesActorList;
  public List<ASFProjectile> LureProjectileArray;
  public int channelType;
  public int ChannelId;
  public int ClanConnectBuffMinPlayer;
}

public class ASFTeamGameInfo : ASFGameInfo
{
}

public class ASFBaseTeamDeathGame : ASFTeamGameInfo
{
}

public class ASFAITeamDeathGame : ASFBaseTeamDeathGame
{
  public class FWeaponIDData
  {
    public List<int> WeaponIDList;
  }

  public class FsTeamMember
  {
    public List<EHAITYPE> Types;
  }

  public class FUsedBotNameInfo
  {
    public int BotPlayerID;
    public string BotPlayerName;
  }

  public int DefaultAIMemberCount;
  public List<byte> DefaultAICount;
  public List<byte> DefaultPlayerCount;
  public bool bUseRandomAIWeaponSystem;
  public bool bUseAutoAILevel;
  public bool SendedNearEndGameScore;
  public bool SendedTimelessChat;
  public List<int> UsableUnitIDList;
  public List<USFTypes.FHumanAIClassNames> AIClassNames;
  public List<string> DefaultWeaponClassList;
  public List<string> UnuseCharClassList;
  public List<string> UnuseWeaponClassList;
  public List<FWeaponIDData> WeaponList;
  public string DefaultAIWeapon;
  public string DefaultUnitClass;
  public List<byte> AICount;
  public List<byte> AITeamDifficulty;
  public List<int> KDCountCheckNext;
  public List<FsTeamMember> TeamMembers;
  public int CheeringEnableLevel;
  public float CheeringChatLimitKD;
  public int FirstCheeringCount;
  public int NextCheeringCount;
  public int JeetingEnableLevel;
  public float JeetingChatStartTime;
  public float JeetingChatUnLimitKD;
  public int FirstJeetingCount;
  public int NextJeetingCount;
  public float SendTimelessTiming;
  public float SendNearEndGameScoreRate;
  public int SendNearEndGameScore;
  public List<float> ExpRate;
  public int AINameCount;
  public List<FUsedBotNameInfo> UsedBotNames;
}

public class ASFAISniperTeamDeathGame : ASFAITeamDeathGame
{
}

public class ASFAISpawnManager : AActor
{
  public class FExtendedMutator
  {
    public string MutClassPath;
    public string RulesClassPath;
    public float Multiplier;
  }

  public class FDummyMemory
  {
    public AController Dummy;
    public UObject.FVector SpawnLocation;
    public UObject.FRotator SpawnRotation;
    public bool bCrouch;
    public bool bJump;
    public float KilledTime;
  }

  public class FAIClassInfo
  {
    public int AIType;
    public UClass PawnClass;
    public UClass ControllerClass;
    public List<UClass> arrWeaponClass;
  }

  public ESpawnPointTypeMethod SpawnPointType;
  public ELevelOfDifficulty Difficulty;
  public ETeam BeSpawnTeam;
  public ACombatZone CurrentCombatZone;
  public FVector StandardLocation;
  public int MaxWaves;
  public bool ArrivedMaxWaves;
  public bool bUseRandomRespawn;
  public bool bUseAllyAI;
  public bool InitializeWave;
  public bool Freeze;
  public bool bPauseWhenAllSpawn;
  public float DefaultEndOfRoundDelay;
  public float EndOfLastRoundDelay;
  public float EliminateAllEnemyTime;
  public int CurrentWave;
  public int WavePointsRemaining;
  public int OldWavePointsRemaining;
  public List<USFTypes.FsWaveInfo> WaveInfoList;
  public int VeryHardLevelMaxWave;
  public List<int> EnemyListAliveCount;
  public float WaveSpawningStartTime;
  public ANavigationPoint LastEnemyStartSpot;
  public FVector SpawningEnemySize;
  public float MinStartRating;
  public List<ANavigationPoint> EnemyStartSpots;
  public List<FDummyMemory> DummyRegister;
  public int DummyCountMax;
  public string DummyName;
  public int MaxAlive;
  public ASFTeamInfo[] SFTI = new ASFTeamInfo[8];
  public int MultipleProportions;
  public int ConcurrentMinAICount;
  public float PauseSpawnTime;
  public float PauseSpawnTimeNew;
  public int PassedWaveCounter;
  public float ForceMaxAliveRatio;
  public float ForceEndOfRoundDelay;
  public float MultiplyValueForAliveRatio;
  public List<FAIClassInfo> arrAIClass;
  public float AIPawnScaleRate;
  public FName EventExtermination;
  public List<APawn> WaveAIs;
  public FScriptDelegate __OnClearPassedWave__Delegate;
}

public class ASFPlayerReplicationInfo : APlayerReplicationInfo
{
  public class FSPingNotify
  {
    public int PlayerID;
    public int TargetTeam;
    public EPingNotifyType PingType;
    public UObject.FVector Location;
    public float Time;
  }

  public int RoundKills;
  public int MultiKillLevel;
  public float LastKillTime;
  public int Assists;
  public int DiebyAI;
  public int KillScore;
  public int DeathScore;
  public float MissionScore;
  public int BonusScore;
  public float PrevScore;
  public float PrevMissionScore;
  public float PrevLuckyPointScore;
  public int Exp;
  public int Rank;
  public int LadderPoint;
  public int CSN;
  public string[] FunctionalItemList = new string[5];
  public List<int> ApplicableFunctionalItemsForChar;
  public List<int> ApplicableFunctionalItemsForWeap;
  public List<int> AdjustOnceItems;
  public bool bAdjustItemProperty;
  public bool bSquadLeader;
  public bool LogInfoInitialized;
  public bool bLeaveNoTraceLog;
  public bool bNeedToUpdateKillFeedBackIcon;
  public bool bInitializedPlayerInfo;
  public bool SendPlayLog;
  public bool bPetBot;
  public bool bIsNCC;
  public bool bAllowSendPing;
  public bool IsHealth;
  public bool IsSpeed;
  public bool IsPower;
  public bool bUpdatedPlayInfoDS;
  public bool bFreeInstantRespawn;
  public bool bAlreadyRequestUserCondition;
  public bool IsRequestEndGameExit;
  public bool bUseAILuckyPointRatio;
  public List<string> SpectatorDecoInfo;
  public UClass CrossHairClass;
  public FColor CrossHairColor;
  public string ClanMarkEffect;
  public int ConsecutiveKills;
  public int ConsecutiveDeaths;
  public int CustomCharCacheIndex;
  public int CustomHandCacheIndex;
  public int[] CustomWeapCacheIndex = new int[6];
  public int CustomHelmetCacheIndex;
  public List<byte> arrPreLoadedWeapSlotIndex;
  public int LastUsingWeapSetIndex;
  public FColor DefaultHudColor;
  public float CurrentLuckyPointRatio;
  public float LastUpdatedLuckyPointRatio;
  public int CurrentLuckyPointCount;
  public int MaxLuckyPointCount;
  public int LuckyPointScore;
  public float CurrentClanPointRatio;
  public float GearWeight;
  public float WeaponWeight;
  public float PlayerWeight;
  public FName SquadName;
  public AVolume LocationVolume;
  public ASFPawn CachedPawn;
  public int OldWeapSetPlayTime;
  public int NotifyMissionLog1;
  public int NotifyMissionLog2;
  public int NotifyMissionLog3;
  public int PreNotifyMissionLog1;
  public int PreNotifyMissionLog2;
  public int PreNotifyMissionLog3;
  public float LastDeadTimeSeconds;
  public List<int> PawnItemIDCache;
  public USFGameDatabase.FSFTestLog_User TestLogUser;
  public USFGameDatabase.FSFTestLog_Room TestLogRoom;
  public USFGameDatabase.FSFTestLog_System TestLogSystem;
  public int SpecialKillBonus;
  public int ContinuousKillBonus;
  public int RareKillBonus;
  public int NormalKillBonus;
  public int DefaultKillBonus;
  public int[] KillFeedBackList = new int[12];
  public int KillFeedBackStartIndex;
  public int KillFeedBackCounter;
  public string RepWeaponTagString;
  public string[] WeaponTagString = new string[3];
  public byte RoleInfo;
  public byte TeamSlotIndexFromLobby;
  public EInGameVoteState InGameVoteState;
  public EGender Gender;
  public List<int> SprayImageIndex;
  public UTexture CachedSprayTexture;
  public FSPingNotify PingNotifyInfo;
  public int CountProposeInGameKick;
  public int Log_DamageToPlayer;
  public int Log_DamageByPlayer;
  public int Log_BackAttackToPlayer;
  public int Log_BackAttackByPlayer;
  public int Log_PrevDamageToPlayer;
  public int Log_PrevDamageByPlayer;
  public int ContinualKillDeath;
  public UClass ItemCrosshairClass;
  public FColor ItemCrosshairColor;
  public List<int> AIRankbyDifficulty;
  public string AIName;
  public int DisguiseRank;
  public string GFXPromotionRank;
  public float MaxApplyExpRatio;
  public float LocalValidPlayTime;
  public USFTypes.FUserConditionData UserGameConditionInfo;
  public int ClanBuffState;
  public USFTypes.FSBombSPData UserBombSPData;
}

public class ASFAITDMPlayerReplicationInfo : ASFPlayerReplicationInfo
{
}

public class ASFPlayerController : APlayerController
{
  public class FMaterialEffectData
  {
    public UMaterialEffect ME;
    public UMaterialInstanceConstant MIC;
    public FName PostProcessEffectName;
    public bool bAutoHideWhenResetRound;
  }

  public class FSPendingObjectIcon
  {
    public AActor IconActor;
    public bool bRegister;
    public bool bShowHP;
  }

  public class FColorationInfo
  {
    public float DesaturationAmount;
    public UObject.FLinearColor Color;
    public float Power;
    public float Priority;
  }

  public UAudioComponent PreviousAC;
  public string LoginOptions;
  public ESFPCState currSFPCState;
  public byte TeamIndex;
  public byte CurrentWeapSetIndex;
  public byte NextWeapSetIndex;
  public byte bLocalSprint;
  public byte bLocalRun;
  public byte AltFireModeNum;
  public EColorationType CurrentColorationType;
  public byte SprayResetType;
  public byte GradeLevel;
  public bool bInterludeAtCurrentRound;
  public bool bInterludeAtCurrentRoundReplication;
  public bool bCameraOutOfWorld;
  public bool bBehindView;
  public bool bForceBehindView;
  public bool bFreeCamera;
  public bool bPressingUsedKey;
  public bool bNonlinearZoomInterpolation;
  public bool bDebugFreeCam;
  public bool bForceHandHide;
  public bool bIgnoreInput;
  public bool bUsingFootPlacement;
  public bool bUsingSkelControlRot;
  public bool bRetrieveSettingsFromProfileOnNextTick;
  public bool bHideObjectivePaths;
  public bool bViewGiveDamage;
  public bool bViewAim;
  public bool bViewFBFullEffect;
  public bool bSprintIgnore;
  public bool bInfiniteAmmo;
  public bool bInfiniteMagazine;
  public bool bLagAnim;
  public bool bInvisible;
  public bool bCheckVehicles;
  public bool bEnableObserverinterpolation;
  public bool bMouseSpeedIncrease;
  public bool bMouseSpeedDecrease;
  public bool bIsWaitingForPawn;
  public bool bUseProjectileRotation;
  public bool bSuppressCameraEffect;
  public bool bSuppressHitEffect;
  public bool bUsingPickupWeapon;
  public bool bCompleteBackup;
  public bool bPawnInvSetSynced;
  public bool bWeapInvSetSynced;
  public bool bFuncItemSetSynced;
  public bool bWeapTagSetSynced;
  public bool bIsInLeagueChannel;
  public bool bBombSPItemSetSynced;
  public bool bReturnFirstPersonCameraForDead;
  public bool bPreventGarbageCollection;
  public bool bUseRenderTextureMessage;
  public bool bUseHoldZoomType;
  public bool bPrimaryWeapExigency;
  public bool bUsedControllDrone;
  public bool bHiddenComponentsByKillCam;
  public bool bAdjustFlashBangEffect;
  public bool bResetInProgress;
  public bool bAdjustDistortionEffect;
  public bool bLockForeFOVAngle;
  public bool bShowDebugDamage;
  public bool bUseWipeoutEffect;
  public bool bWipeoutEffectInitialized;
  public bool bPendingPerformGC;
  public bool bUseEnemyCharacter;
  public bool bUseArmBand;
  public bool bUseEnemyArmBand;
  public bool bMagazineDrop;
  public bool bUseBlendCameraPOV;
  public bool bBlendCameraPOVFirstTime;
  public bool EnemyFriendly;
  public bool bTestSuppressMovementPacket;
  public bool bHideCrosshair;
  public bool bHideHitIndicator;
  public bool bEnableFlashBangGuideEffect;
  public bool bIgnoreWeaponDurability;
  public bool bIsHackedUser;
  public bool bDisconnectHackUser;
  public bool bLeftKeyPressed;
  public bool bRightKeyPressed;
  public bool bInGameStoreSaveLastMousePosition;
  public bool bAppliedWeaponRecoilToCamera;
  public bool bPingRadarOpened;
  public bool bRequestedInstantRespawn;
  public bool bReportInvalidPhysicalMtrlProperty;
  public bool bDisplayUserGameCondition;
  public bool IsAllowChangeWeapon;
  public float AddVipLP;
  public UClass SFAnnounceGameClass;
  public UCameraAnimInst CameraAnimPlayer;
  public UCameraAnimInst currentCameraAnimInstant;
  public APostProcessVolume.FPostProcessSettings CamOverridePostProcess;
  public FVector ShakeOffset;
  public FRotator ShakeRot;
  public float LastCameraTimeStamp;
  public UClass MatineeCameraClass;
  public float FOVLinearZoomRate;
  public float FOVNonlinearZoomInterpSpeed;
  public float FOVChangingTime;
  public FRotator DebugFreeCamRot;
  public float LastShowPathTime;
  public FRotator rotInput;
  public ASFEmit_Weather WeatherEmitter;
  public string RespawnCameraAnimName;
  public UCameraAnim RespawnCameraAnim;
  public float MinCameraEffectDelay;
  public ASFCustomBuildHelper MCBuilder;
  public USFOnlineSubsystemPC OnlineSubPC;
  public UClass ActiveRadioMessageClass;
  public float RadioMessageAutoHideTime;
  public float ObvCameraVel;
  public float ObvCameraVelDecRate;
  public int ObvIPMin;
  public int ObvIPMMax;
  public float MinDeathAnimTime;
  public float MaxKillCamDuration;
  public float MaxEndGameKillCamDuration;
  public string AfterDurationSoundModeName;
  public APlayerReplicationInfo KillCamKillerPRI;
  public float fWhippingGapTime;
  public float fLastWhippingTime;
  public float MouseSensitivityDelta;
  public int nIFFType;
  public ASFPawn LastSceneCapturedPawn;
  public USoundCue FlashBangSoundCue;
  public UAudioComponent FlashBangAudioComponent;
  public int PrevTeamIndex;
  public float FlashBangSoundFadeOutTime;
  public UTextureRenderTarget2D FlashBangRenderTarget;
  public int PrevWeaponWeapGroupIndex;
  public int PrevWeaponWeapSlotIndex;
  public int PickupWeaponID;
  public int[] PickupWeaponItemIDTable = new int[16];
  public USFTypes.FPawnInventorySet PawnInventoryInfo;
  public USFTypes.FWeaponInventorySet[] WeaponInventoryInfo = new USFTypes.FWeaponInventorySet[3];
  public USFTypes.FWeaponInventorySet[] BackupInventoryInfo = new USFTypes.FWeaponInventorySet[3];
  public string MissionAttackWeaponClass;
  public string MissionDefendWeaponClass;
  public List<string> MissionAdditionalWeaponClasses;
  public string DyingWeaponClassName;
  public float GCCycleTime;
  public float LastGCCycleStamp;
  public FName CameraActorTag;
  public ACameraActor ReservedCameraActor;
  public APawn DroneControllPawn;
  public AActor DronePawn;
  public FColorationInfo[] ColorationInfos = new FColorationInfo[10];
  public FColorationInfo TargetColoration;
  public FColorationInfo StartColoration;
  public FColorationInfo CurrentColoration;
  public float ColorationDuration;
  public float ColorationAdjustTime;
  public List<USFTypes.FKillCamExplosion> KillCamExplosionArray;
  public FMaterialEffectData[] MaterialEffectDatas = new FMaterialEffectData[4];
  public FName MotionBlurEffectName;
  public UMotionBlurEffect MotionBlurEffect;
  public float KillCamMotionBlurMaxVelocity;
  public float KillCamMotionBlurAmount;
  public FLinearColor vFlashBangColor;
  public float NoInputExpireTime;
  public float LastDamageShakeAdjustTime;
  public float DamageShakeInterval;
  public ASFPawn KillCamVictimPawn;
  public float LastKillCamProjThrownTime;
  public float DesiredForeFOVAngle;
  public float ForeFOVAngleChangeTime;
  public int Last_HealthDamage;
  public int Last_ArmorDamage;
  public int Last_Health;
  public int Last_Armor;
  public int Last_PlayerID;
  public int Last_HitType;
  public FVector Last_HitLocation;
  public float Last_HitDist;
  public string Last_HitBone;
  public string LastDeath_HitDir;
  public int KillType_PiercingShot;
  public int KillType_WallShot;
  public float KillCamFadeTime;
  public USceneTransitionEffect SceneTransitionEffect;
  public float SpectatorTransitionWipeoutTime;
  public FName SceneTransitionEffectName;
  public AActor OldViewTargetForWipeout;
  public float DisconnectMaxTimeFromHost;
  public float DisconnectMaxTimeToReturnToLobby;
  public float DisconnectRealTimeFromHost;
  public float TotoalDisconnectTimeFromHost;
  public string HostLogOutMessages;
  public List<string> ForcedGameExitMessageArray;
  public string CapturingMessage;
  public string CapturingFailedMsg;
  public string CapturingFailedNoSpaceMsg;
  public float ServerNoticeTime;
  public List<string> ChatTypeColor;
  public List<string> ChatTextColor;
  public int SpeedHackDetectType;
  public float SpeedHackAccumTime;
  public float LastReceivedHeartBeatTime;
  public float LastSendHeartBeatTime;
  public float SpeedHackDetectMargin;
  public float SpeedHackDetectFrequency;
  public int SpeedHackDecideCount;
  public int ClientMinCountForHostDetectSpeedHack;
  public float SpraySpawnDelay;
  public float SprayFadeInDelay;
  public float SpraySpawnRange;
  public float SprayThickness;
  public float SpraySize;
  public float SprayEmissiveIntense;
  public int MaxSprayCounter;
  public float SprayWarningMessageDelay;
  public FName SprayTextureParamName;
  public FName SprayEmissiveIntenseParamName;
  public FName SpraySlotParamName;
  public float LastSpraySpawnTime;
  public float LastSprayKeyPressedTime;
  public string SprayDistanceNotice;
  public string SprayDelayTimeNotice;
  public string SprayWaitingForMatchNotice;
  public string SelectSprayEmblem;
  public string DontUseSprayAtThisActorMessage;
  public string HackDetectedMessage;
  public Dictionary<byte, byte> PlayerItemSetCache;
  public ASFPointOfInterest SFPOI;
  public USoundCue RespawnCameraSound;
  public ASFPawn PawnForKillerOutline;
  public List<USFTypes.FPawnOutlineInfo> arrPawnOutlineInfo;
  public int CurrentScaleLevel;
  public float LastFireTime;
  public List<EHackType> RequestedRPC;
  public List<USFSeqEvent_NotifyKeyInput> arrSeqEventNotifyKeyInput;
  public int StunKeyInputCounter;
  public FName SavedPreviousStateName;
  public FName DefaultSpectatorCameraMode;
  public float LastSendPingNotifyTime;
  public int LastShopGroupIndex;
  public float ReducedRespawnDelay;
  public List<FSPendingObjectIcon> PendingObjectIconArray;
  public float TotalDeadTime;
  public List<USFTypes.FUsableInGameItemData> InGameItemData;
  public int CurrentSP;
  public int InstantRespawnCount;
  public int VipGrade;
  public float LastDeadTime;
  public List<USFTypes.FsCombatReport> SummaryCombatReports;
  public int DbgGFxAniIndex;
  public int MaxHackDetectCount;
  public int HackDetectCount;
  public int ServerPackageCmd;
  public string ServerPackagesRAW;
  public List<string> LocalPackages;
  public List<string> ServerPackages;
  public int SendedPackageIdx;
  public int AltFiremode;
  public List<FName> SkipAutoMessageList;
  public int PurchasedRandomWeaponID;
  public List<string> DefaultFunctionalItemClassNames;
  public USFGameDatabase.FSFPlayerLog DedicatePlayerLog;
  public float AddtionalScore;
  public float AddtionalLuckyPoint;
  public float AntiFatigueReduceRatio;
  public int PlayerIsAdult;
  public int HealthItemID;
  public int CustomModeType;
  public List<int> PendingThrowWeaponSlotIndex;
  public FScriptDelegate __SetUserGameDataToDatabase__Delegate;
}

public class ASFTDPlayerController : ASFPlayerController
{
}

public class ASFAITDPlayerController : ASFTDPlayerController
{
  public int BotChatType;
  public int BotChatSenderID;
  public int BotChatUpdate;
}

public class ASFAITDThirdPersonPlayerController : ASFAITDPlayerController
{
  public bool CheckHoldZoom;
  public bool bEnableFreeCam;
  public bool bZoomCamModeChangeDelay;
  public float RightClickElapsedTime;
}

public class USFGameScore : UObject
{
  public class FSLadderPointBasis
  {
    public int BasisPlayerNum;
    public float BasisModeRate;
    public int BasisKill;
    public int BasisAssist;
    public int BasisDeath;
    public int BasisSpecial;
    public int BasisSuicide;
    public int BasisLuckyPoint;
    public int BasisHighLevelKill;
  }

  public class FSClanPointBasis
  {
    public float ClanPointKillRate;
    public float ClanPointAssistRate;
    public float ClanPointMissionRate;
    public float ClanPointRoundWinRate;
    public float ClanPointMatchingRate;
  }

  public class FSpawnBasis
  {
    public float BasisKill;
    public float BasisCritical;
    public float BasisAssist;
    public float BasisLuckyPoint;
    public float BasisHighLevelKill;
  }

  public List<FSLadderPointBasis> LadderPointBasisList;
  public FSClanPointBasis ClanPointBasis;
  public int DeductionClanPoint;
  public FSpawnBasis PawnBasis;
  public int SCORE_TimeOver;
  public int WinningTeamMemberScore;
  public int DefeatingTeamMemberScore;
  public float NormalKillScore;
  public float SpecialKillScore;
  public float ContinuousKillScore;
  public float RareKillScore;
  public float MaxNormalKillScore;
  public float MaxSpecialKillScore;
  public float MaxContinuousKillScore;
  public float MaxRareKillScore;
  public List<int> GlowKillScore;
  public List<int> GlowTeamKillScore;
  public int CompareValue;
  public float TeamRewardScorerBonusRatio;
}

public class USFTeamDeathGameScore : USFGameScore
{
}

public class USFAITeamDeathGameScore : USFTeamDeathGameScore
{
}

public class ASFAITeamDeathGameVs16 : ASFAITeamDeathGame
{
}

public class ASFTeamDeathHUD : ASFTeamHUD
{
}

public class ASFAITeamDeathHUD : ASFTeamDeathHUD
{
}

public class ASFAITeamDeathThirdPersonGame : ASFAITeamDeathGame
{
}

public class ASFAITeamDeathVs16HUD : ASFAITeamDeathHUD
{
}

public class USFThirdPersonCameraModeBase : UGameThirdPersonCameraMode
{
  public float InterpLocSpeed;
}

public class USFAIThirdPersonCameraMode : USFThirdPersonCameraModeBase
{
  public FVector EvadePawnRelativeOffset;
  public float WorstLocAimingZOffset;
  public bool bTemporaryOriginRotInterp;
  public float TemporaryOriginRotInterpSpeed;
}

public class ASFAIVisibleControl : AActor
{
  public UAIVisibilityManager AIVisMan;
}

public class USFAIWaveInfo_DataStoreBase : UObject
{
}

public class USFAIWaveInfo_Category : USFAIWaveInfo_DataStoreBase
{
  public string MapName;
  public List<USFTypes.FsWaveInfo> WaveInfos_EASY;
  public List<USFTypes.FsWaveInfo> WaveInfos_NORMAL;
  public List<USFTypes.FsWaveInfo> WaveInfos_HARD;
  public List<USFTypes.FsWaveInfo> WaveInfos_VERYHARD;
  public List<USFTypes.FsWaveInfo> WaveInfos_Default;
  public float EndOfRoundDelay;
  public int MultipleProportions;
  public int ConcurrentMinAICount;
}

public class ASFObstaclesActor : ADynamicSMActor
{
  public class FsMeshLevel
  {
    public float HPrate;
    public UStaticMesh StaticMesh;
    public List<UMaterialInstanceConstant> Materials;
    public FName Anim;
    public USoundCue Sound;
    public UParticleSystem ParticleTemplate;
    public UParticleSystem HitParticleTemplate;
    public int TeamScore;
    public int Score;
  }

  public FName currState;
  public List<FsMeshLevel> MeshLevels;
  public USkeletalMeshComponent SkeletalMeshComponent;
  public List<UMaterialInstanceConstant> PreviewMaterial;
  public UMaterialInstanceConstant TransparencyMaterial;
  public USoundCue DamagedSound;
  public float Health;
  public float Price;
  public List<float> HealthMaxList;
  public int DefaultHealth;
  public List<float> PriceList;
  public bool bIgnoreSameTeamDamage;
  public bool bReusableWhenUsing;
  public bool bBlockWhenDestroyed;
  public bool bHiddenBackupCollisionMesh;
  public bool bCollideActorsBackup;
  public bool bBlockActorsBackup;
  public bool bCollideBackup;
  public ETeam TeamIndex;
  public byte nForceUpdate;
  public ECollisionType BlockType;
  public int MaxUse;
  public float fMaxReusableRate;
  public float InstallingTime;
  public int LevelNow;
  public int PendingPreview;
  public int PreviewNow;
  public int nCollisionTypeBackup;
  public int UsedCound;
  public float HealthOld;
  public float CollideRadius;
  public UStaticMesh PreviewMesh;
  public float HealthDirty;
  public FVector IconLocationOffset;
  public ASFObstaclesActor nextObstaclesActor;
  public float ProjectileDOTExpireTime;
  public List<USFTypes.FsDOT> SteadyDOTs;
  public List<USFTypes.FsDOT> ActiveDOTs;
}

public class ASFAlienSporeActor : ASFObstaclesActor
{
}

public class USFAnimBlendBase : UAnimNodeBlendList
{
  public float BlendTime;
  public List<float> ChildBlendTimes;
  public float AnimStartTime;
  public byte nKeyAnimChild;
  public byte nReservedAnimChild;
  public bool bUseReservedAnimChild;
  public bool bIgnoreRootPlayChildAnim;
}

public class USFAnimBaseBlendNode : USFAnimBlendBase
{
  public ASFPawn_AI SFPawnOwner;
  public ASFPawn PawnOwner;
}

public class USFAnimBlendByAimState : USFAnimBlendBase
{
}

public class USFAnimBlendByAimStateThird : USFAnimBlendBase
{
}

public class USFAnimBlendByAttackEnable : USFAnimBlendBase
{
}

public class USFAnimBlendByCharging : USFAnimBlendBase
{
  public EWeaponState WeaponStateOld;
  public bool bChargingOld;
}

public class USFAnimBlendByCoverType : USFAnimBlendBase
{
  public ASFPawn_AI SFPawnOwner;
}

public class USFAnimBlendByDirection : USFAnimBlendBase
{
  public class FStandardAnimVelocityStruct
  {
    public float FrontVelocity;
    public float BackVelocity;
    public float LeftVelocity;
    public float RightVelocity;
  }

  public float DirDegreesPerSecond;
  public float DirAngle;
  public int SingleAnimAtOrAboveLOD;
  public float DirBlendPerc;
  public List<float> DirWeight;
  public List<float> SkelRotWeight;
  public bool bUseScaleRateBySpeed;
  public FStandardAnimVelocityStruct StandardAnimVelocity;
}

public class USFAnimBlendByFall : USFAnimBlendBase
{
  public EBlendFallTypes FallState;
}

public class USFAnimBlendByFireState : USFAnimBlendBase
{
  public EWeaponState WeaponStateOld;
}

public class USFAnimBlendByHasAmmo : USFAnimBlendBase
{
  public bool bCheckbyMag;
  public int nCondiAmmoCount;
  public int nOldActiveChild;
  public int nOldAmmo;
}

public class USFAnimBlendByHitState : USFAnimBlendBase
{
  public int HitStateOld;
}

public class USFAnimBlendByLadderDirection : USFAnimBlendBase
{
}

public class USFAnimBlendByLobbyPreview : USFAnimBlendBase
{
}

public class USFAnimBlendByLobbyWeapon : USFAnimBlendBase
{
  public class FLobbyStepInfo
  {
    public FName LobbyStep;
    public FName PrevLobbyStep;
    public int ChildNodeIndex;
  }

  public class FQueuingChildInfo
  {
    public ELobbyWeapAnimStep QueuingChildIndex;
    public UAnimNodeBlendBase.FAnimBlendChild ChildInfo;
  }

  public List<FLobbyStepInfo> LobbyStep;
  public List<ELobbyWeapAnimStep> MustPlayingLobbyStep;
  public int WeaponAnimsetIndex;
  public FName LobbyStepName;
  public FName PrevLobbyStepName;
  public int PrevWeaponID;
  public FQueuingChildInfo QueuingChild;
  public bool bIsFemale;
}

public class USFAnimBlendByPosture : USFAnimBlendBase
{
}

public class USFAnimBlendByRandom : UAnimNodeRandom
{
}

public class USFAnimBlendByRandomPlay : UAnimNodeBlendList
{
  public List<float> Chance;
}

public class USFAnimBlendByRocketJump : USFAnimBlendBase
{
}

public class USFAnimBlendByShellCount : USFAnimBlendBase
{
}

public class USFAnimBlendBySightMode : USFAnimBlendBase
{
  public ASFWeapon WeaponOwner;
}

public class USFAnimBlendBySprint : USFAnimBlendBase
{
  public ASFWeapon WeaponOwner;
}

public class USFAnimBlendBySprintFirst : USFAnimBlendBase
{
  public EWeaponState WeaponStateOld;
}

public class USFAnimBlendBySprintThird : USFAnimBlendBase
{
  public float DirDegreesPerSecond;
  public bool bUseTheMinimumSpeedFromPhysicsVolume;
}

public class USFAnimBlendBySteady : USFAnimBlendBase
{
}

public class USFAnimBlendByTransition : USFAnimBlendBase
{
  public ASFPawn_AI SFPawnOwner;
  public List<ECoverAction> PrevCoverActionBypassIntro;
  public List<ECoverAction> CoverActionByPassOutro;
  public bool bPlayingIntro;
  public bool bPlayingOutro;
  public bool bPlayedOutro;
  public bool bUpdatePawnActionFiringFlag;
}

public class USFAnimBlendByWeaponExtraMode : USFAnimBlendBase
{
  public int ModeStateNow;
}

public class USFAnimBlendByWeaponExtraModeChanging : USFAnimBlendBase
{
  public int ModeStateNow;
}

public class USFAnimBlendByWeaponState : USFAnimBlendBase
{
  public EWeaponState WeaponState;
}

public class USFAnimBlendByZoomState : USFAnimBlendBase
{
  public EWeaponState WeaponStateOld;
}

public class USFAnimBlendForGLauncher : USFAnimBlendBase
{
}

public class USFAnimBlendForPreAnim : USFAnimBlendBase
{
  public byte PlayingInputNodeIndex;
}

public class USFAnimBlendLinkage : USFAnimBlendBase
{
  public List<int> nLinkageSeq;
}

public class USFAnimCoverBlend : USFAnimBlendBase
{
  public ASFPawn_AI SFPawnOwner;
  public bool bUpdatePawnActionFiringFlag;
  public ECoverAction AnimCoverAction;
}

public class USFAnimNodeAimOffset : UAnimNodeAimOffset
{
  public float TurnInPlaceOffset;
  public ASFPawn_AI SFPawnOwner;
}

public class USFAnimNodeCopyBoneTranslation : UAnimNodeBlendBase
{
  public class FBoneCopyInfo
  {
    public FName SrcBoneName;
    public FName DstBoneName;
    public int SrcBoneIndex;
    public int DstBoneIndex;
  }

  public UAnimNodeAimOffset CachedAimNode;
  public FName OldAimProfileName;
  public List<FBoneCopyInfo> DefaultBoneCopyArray;
  public List<byte> RequiredBones;
}

public class USFAnimNodeRandomIdle : UAnimNodeRandom
{
  public int DefaultAnimIndex;
}

public class USFAnimNodeSequence : UAnimNodeSequence
{
  public bool bRestartWhenActivate;
}

public class USFAnimNodeSeq_Debug : USFAnimNodeSequence
{
}

public class USFAnimNodeSlot : UAnimNodeSlot
{
  public bool bForceResetWhenCeaseRelevant;
}

public class USFAnimNodeSlotAccessory : USFAnimNodeSlot
{
  public ASFWeapon WeaponOwner;
}

public class USFAnimNodeSlotByAdditive : USFAnimNodeSlot
{
  public bool bPassThroughWhenNotRendered;
}

public class USFAnimNodeSlotPerBone : USFAnimNodeSlot
{
  public bool bForceLocalSpaceBlend;
  public FName BranchStartBoneName;
  public List<float> Child2PerBoneWeight;
  public List<byte> LocalToCompReqBones;
}

public class USFAnimNodeSlotQueuing : USFAnimNodeSlot
{
  public class FQueuingAnimInfo
  {
    public FName AnimName;
    public float Rate;
    public float BlendInTime;
    public float BlendOutTime;
  }

  public List<FQueuingAnimInfo> arrQueuingAnimInfo;
}

public class USFAnimNodeTurnInPlace : UAnimNodeBlend
{
  public bool bInitialized;
  public int LastPawnYaw;
  public List<FName> RotTransitions;
  public float TransitionBlendTime;
  public float TurnInThresholdYaw;
  public List<USFAnimNodeTurnInPlacePlayer> TurnInPlayerNodes;
}

public class USFAnimNodeTurnInPlacePlayer : UAnimNodeSequence
{
  public class FTIP_Transition
  {
    public FName TransName;
    public FName AnimName;
  }

  public List<FTIP_Transition> TIP_Transitions;
}

public class USFAnimNofity_Weapon : UAnimNotify
{
  public string NotifyName;
}

public class USFAnimNotify_AttachParticle : UAnimNotify
{
  public UParticleSystem ParticleSystem;
  public FName BoneName;
  public bool bKillParticlesForce;
  public float ParticleScale;
  public UParticleSystemComponent GeneratedParticle;
}

public class USFAnimNotify_HideBone : UAnimNotify
{
  public FName BoneName;
  public bool bHidden;
}

public class USFAnimNotify_Magazine : UAnimNotify
{
}

public class USFAnimNotify_Ragdoll : UAnimNotify
{
}

public class USFAnimNotify_Sound : UAnimNotify_Sound
{
  public bool bIgnoreIfSkelHidden;
}

public class USFAnnounceGame : USFLocalMessage
{
  public USFSoundGroup_Voice GameAnnounce;
}

public class USFAntiFatigue : UObject
{
  public class FSAntiFatigueInfo
  {
    public float StartTime;
    public int MessageIndex;
    public float ReduceExpRatio;
  }

  public class FSAntiFatigueMessage
  {
    public string strColor;
    public string strMessage;
  }

  public int MessageDurationTime;
  public List<FSAntiFatigueInfo> AntiFatigueArray;
  public List<FSAntiFatigueMessage> AntiFatigueMessage;
}

public class USFBaseCondition : UObject
{
  public List<FName> AwardList;
}

public class USFAppraisalCondition : USFBaseCondition
{
  public class FMessageList
  {
    public string Message;
  }

  public class FAppraisalData
  {
    public FName EventType0;
    public FName EventType1;
    public int RealRank;
    public int GoalScoreMission0;
    public int GoalScoreMission1;
    public int GoalScoreRespawn0;
    public int GoalScoreRespawn1;
    public List<USFAppraisalCondition.FMessageList> MessageList;
  }

  public List<FAppraisalData> ARAppraisalInfo;
  public List<FAppraisalData> SNAppraisalInfo;
  public List<FAppraisalData> MGAppraisalInfo;
  public List<FAppraisalData> SMGAppraisalInfo;
  public List<FAppraisalData> SGAppraisalInfo;
  public List<FAppraisalData> KnifeAppraisalInfo;
  public List<FAppraisalData> ThrowingKnifeAppraisalInfo;
  public List<FAppraisalData> ArrowAppraisalInfo;
  public List<FAppraisalData> GrenadeAppraisalInfo;
  public List<FAppraisalData> ETCAppraisalInfo;
}

public class ASFModeVolume : AVolume
{
  public class FCheckpointRecord
  {
    public FName currState;
  }

  public ETeam TouchValidTeamIndex;
  public ETeam UnTouchValidTeamIndex;
  public EObjectIconTypes IconTypeRedTeam;
  public EObjectIconTypes IconTypeBlueTeam;
  public List<USFTypes.FStateIconType> StateIconTypes;
  public bool bNotifyTouchedSFTrigger;
  public bool bOutsideVolumeToReturnMissionWeapon;
  public FName InitialStateForEditor;
  public UClass NotifyTriggerClass;
  public FName currState;
  public USpriteComponent IconLocationForEditor;
  public FVector IconLocationOffset;
}

public class ASFArriveAtVolume : ASFModeVolume
{
}

public class USFAssistEventData : USFWeaponEventData
{
}

public class ASFAutoCrouchVolume : AVolume
{
}

public class USFBaseAward : UObject
{
  public FName AwardName;
}

public class USFAward_ChattingMessage : USFBaseAward
{
}

public class USFAward_GameSystemMessage : USFBaseAward
{
}

public class USFAwardManager : UObject
{
  public class FAwardInfo
  {
    public UClass AwardClass;
    public UGFxMoviePlayer.FASValue AwardValue;
  }

  public List<UClass> AwardClassList;
}

public class USFBackAttackByPlayerEventData : USFBaseEventData
{
}

public class USFBackAttackEventData : USFSpecialKillEventData
{
}

public class USFBackAttackToPlayerEventData : USFBaseEventData
{
}

public class ASFBarricadeActor : ASFObstaclesActor
{
}

public class ASFBeast2PlayerController : ASFPlayerController
{
  public bool bBoss;
  public bool bNeedChangeTeam;
}

public class ASFBeastGame : ASFTeamGameInfo
{
  public USFTypes.FSSpawnableAlienInfo[] SpawnableAlienInfoList = new USFTypes.FSSpawnableAlienInfo[3];
  public UClass[] AlienPawnClass = new UClass[3];
  public ETeam BeastTeam;
}

public class ASFBeastGame2 : ASFTeamGameInfo
{
  public string AlienPawnBossClassName;
  public UClass AlienPawnBossClass;
  public string AlienPawnWorkerClassName;
  public UClass AlienPawnWorkerClass;
  public int BossCountPerPlayer;
}

public class ASFBeastGameReplicationInfo : ASFGameReplicationInfo
{
  public byte BeastTeam;
}

public class USFBeastGameScore : USFGameScore
{
}

public class ASFBeastHUD : ASFHUD
{
  public List<USFTypes.FSSpawnableAlienInfo> SpawnablePawnInfoList;
}

public class ASFBeastPlayerController : ASFPlayerController
{
  public int OriginalWeaponSetIndex;
  public bool bCompleteBackupOriginalWeaponSetID;
  public int LastTeamIndex;
  public USFGameDatabase.FSFManHuntPlayerLog DedicateManHuntPlayerLog;
}

public class ASFTeamInfo : ATeamInfo
{
  public bool bLastManStanding;
  public bool bSaveSituation;
  public bool bMatchPoint;
  public bool bAccumulationScore;
  public bool bUseDeductionClanPoint;
  public byte SpawnedPawnCount;
  public byte DiedPawnCount;
  public byte nWinningRound;
  public byte AttackRoundWin;
  public byte DefendRoundWin;
  public byte TotalShareLives;
  public int ClanSerialNumber;
  public string ClanName;
  public List<AController> TeamMembers;
  public ASFHeadQuarters Headquarter;
  public int LobbyTeam;
}

public class ASFBeastTeamInfo : ASFTeamInfo
{
}

public class ASFTutorialGame : ASFGameInfo
{
  public class FTutorialSectionInfo
  {
    public int SectionID;
    public int BestScore;
    public int AdjustScore;
  }

  public List<FTutorialSectionInfo> TutorialSectionInfos;
  public float BonusRemainTime;
  public float PenaltyRemainTime;
  public bool bIsUpdateWhenBestScore;
}

public class ASFBeginnerGame : ASFTutorialGame
{
}

public class ASFTutorialGameReplicationInfo : ASFGameReplicationInfo
{
}

public class ASFBeginnerGameReplicationInfo : ASFTutorialGameReplicationInfo
{
}

public class ASFBeginnerHUD : ASFHUD
{
  public FScriptDelegate __RegisterBeginnerTipMessage__Delegate;
  public FScriptDelegate __UnRegisterBeginnerTipMessage__Delegate;
}

public class USFBeginnerTipMessage : USFLocalMessage
{
}

public class ASFBlastingGame : ASFTeamGameInfo
{
  public ASFBlastingGameReplicationInfo SFBlastingGRI;
}

public class ASFBlastingGameReplicationInfo : ASFGameReplicationInfo
{
}

public class USFBlastingGameScore : USFGameScore
{
  public float SCORE_Planted;
  public float SCORE_Defused;
  public float SCORE_ExplodedTeam;
  public float SCORE_DefusedTeam;
  public float SCORE_DefendExplosion;
}

public class ASFBlastingGameSecond : ASFBlastingGame
{
}

public class ASFBlastingGameSecondReplicationInfo : ASFGameReplicationInfo
{
}

public class USFBlastingGameSecondScore : USFBlastingGameScore
{
}

public class ASFBlastingGameVs16 : ASFBlastingGame
{
}

public class USFBlastingGameVs16Score : USFBlastingGameScore
{
}

public class ASFBlastingHUD : ASFTeamHUD
{
}

public class ASFBlastingPlayerController : ASFPlayerController
{
}

public class ASFBlastingRocketJumpGame : ASFBlastingGame
{
}

public class ASFBlastingRocketJumpHUD : ASFBlastingHUD
{
}

public class ASFBlastingSecondHUD : ASFBlastingHUD
{
}

public class ASFBlastingSecondPlayerController : ASFPlayerController
{
}

public class ASFBlastingVs16HUD : ASF16VS16ModeHUD
{
}

public class USFDecal : UDecalComponent
{
  public float LifeSpan;
}

public class USFBloodDecal : USFDecal
{
  public float fFadeTime;
}

public class USFBombSPMessage : USFLocalMessage
{
  public string BombSPMessage;
  public string BombSPDescription;
}

public class ASFBombVolume : ASFModeVolume
{
  public FVector TriggersLocationForIcon;
  public List<AStaticMeshActorForBlastingGame> BlastingMeshActor;
}

public class USFScoreUpMessage : USFLocalMessage
{
  public List<string> DisableAFColorArray;
}

public class USFBonusScoreUpMessage : USFScoreUpMessage
{
  public string ScoreText;
}

public class ASFGlowMutator : AMutator
{
  public int GlowBeginColor;
}

public class ASFBossGlowMutator : ASFGlowMutator
{
}

public class USFBPEventCondition : USFBaseCondition
{
  public List<FName> RealTimeScoreEventType;
}

public class ASFBreakableActor : AActor
{
  public class FSModeInfo
  {
    public EGameMode Mode;
    public EBreakableActorFlag EnableFlag;
    public byte nTemp0;
    public byte nTemp1;
  }

  public UDynamicLightEnvironmentComponent LightEnvironment;
  public UStaticMeshComponent DefaultMeshComponent;
  public UStaticMeshComponent BreakMeshComponent;
  public List<AEmitter> ExplosionEmitters;
  public UMaterialInterface ExplosionDecal;
  public USoundCue ExplosionSound;
  public URadialBlurComponent RadialBlur;
  public USFExplosionLight ExplosionLight;
  public USFGameExplosion ExplosionInfo;
  public bool bDirectionalExplosion;
  public UDrawSphereComponent DamageRadiusSphere;
  public FVector DamageRadiusSpherePosition;
  public FName currState;
  public List<ASFTrigger_PlasticBomb> arrPlasticBomb;
  public int PassedTime;
  public FVector vTriggerDmgLoc;
  public FVector vTriggerDmgDir;
  public List<FSModeInfo> FlagOfDefualtMode;
  public List<FSModeInfo> FlagOfMissionMode;
  public FVector InitialLocation;
  public FRotator InitialRotation;
  public int Step1DelayTime;
  public int Step2DelayTime;
  public int Step3DelayTime;
  public AController DamageCauser;
  public List<USFTypes.FOriginMtrlData> DefaultMeshOriginMtrlDatas;
  public List<USFTypes.FOriginMtrlData> BreakMeshOriginMtrlDatas;
}

public class USFFlickerLightByPeriod : UPointLightComponent
{
  public float LightPeriod;
  public float LightPeriodOffset;
  public float LightMinBrightness;
  public float FadeInTime;
  public float orgBrightness;
  public float FadePassedTime;
  public bool bFading;
}

public class ASFBreakableActorByDamage : ASFBreakableActor
{
  public class FSFBreakPartsInfo
  {
    public ASFBreakableCarPart BreakPartPosition;
    public UStaticMesh BreakPart;
    public float Lifetime;
  }

  public UClass IgnoredDamageType;
  public int BombDamageThreshold;
  public int FireDamageThreshold;
  public int CurrentDamage;
  public List<AEmitter> FireEmitters;
  public USFFlickerLightByPeriod FireLight;
  public FVector FireLightPosition;
  public float ExplodeTime;
  public float FirstDamageTime;
  public List<FSFBreakPartsInfo> arrBreakParts;
  public ETeam DamageIgnoreTeamIndex;
}

public class ASFBreakableActorWithMessage : ASFBreakableActor
{
}

public class ASFBreakableCarPart : ANote
{
  public UStaticMeshComponent MeshComponent;
}

public class ASFBreakableGlassActor : AInterpActor
{
  public ECollisionType NormalCollisionType;
  public ECollisionType BrokenCollisionType;
  public EGlassDir GlassDir;
  public UMaterialInterface NormalMaterial;
  public UStaticMesh NormalStaticMesh;
  public float AccumulatedDamage;
  public FName currState;
  public List<UStaticMesh> BrokenStaticMeshs;
  public List<UMaterialInterface> CrackedMaterials;
  public float MinCrackingDamage;
  public float MinBreakingDamage;
  public List<UParticleSystem> BreakingParticleTemplates;
  public List<USoundCue> BreakingSounds;
  public float BrokenTime;
  public FVector DamageDir;
}

public class ASFBreakableGlassSyncActor : ASFBreakableGlassActor
{
  public int GlassSyncActorIndex;
  public UMaterialInterface NormalTouchedMaterial;
  public UMaterialInterface CrackedTouchedMaterial;
  public USoundCue TouchedSoundCue;
  public UMaterialInterface CrackedMaterial;
  public bool bOnlyShowEnemyTouchedMaterial;
  public bool bPaidBrokenScore;
  public bool bNotBreakable;
  public bool bIsRespawn;
  public float bFlagBreakable;
  public float GlassRespawnTime;
}

public class ASFBreakableGlassSyncState : AReplicationInfo
{
  public class FGlassStateName
  {
    public EGlassState GlassState;
    public FName StateName;
  }

  public List<FGlassStateName> GlassStateTable;
  public EGlassState[] GlassState = new EGlassState[255];
  public byte bNetDirtyGlassState;
  public ASFBreakableGlassSyncActor[] GlassActors = new ASFBreakableGlassSyncActor[255];
  public ASFBreakableGlassSyncState NextGlassSyncState;
  public bool bRegisterGlassActor;
}

public class USFBuffInfo : UObject
{
  public class FSBuffBonusInfo
  {
    public EBuffBonusType Type;
    public float Value;
  }

  public class FSBuffInfo
  {
    public string Title;
    public string Description;
    public string StateMessage_Activated;
    public string StateMessage_Deactivated;
    public string StateMessage_Failed;
    public string IconImage;
    public float Duration;
    public List<USFBuffInfo.FSBuffBonusInfo> BuffBonusInfo;
    public bool IgnoreCullDistance;
    public FName EffectBoneName;
    public UParticleSystem EffectPS;
    public UParticleSystem CameraLensEffectPS;
    public UObject.FVector EffectRelativeLocation;
    public UObject.FRotator EffectRelativeRotation;
    public UObject.FVector EffectRelativeScale;
    public float EffectDurationTime;
    public USoundCue SoundEffect;
  }

  public FSBuffInfo[] BuffList = new FSBuffInfo[18];
  public List<USFTypes.FSGameClanBuffInfo> ClanBuffList;
  public string BuffStateMessage_Activated;
  public string BuffStateMessage_Deactivated;
  public string BuffStateMessage_Failed;
}

public class USFCalendar : UObject
{
  public List<int> DefaultMonthDaysArray;
}

public class USFCameraBase : UGameCameraBase
{
}

public class USFCameraModifier_ShakeByDamage : UCameraModifier
{
  public EDamageShakeState DmgShakeState;
  public FRotator DmgShakeRotation;
  public FRotator DamageShakeGoal;
  public float DamageShakeGoalTime;
  public float DamageShakeTransitTime;
}

public class ASFCaptureGame : ASFTeamGameInfo
{
  public int CompleteCaptureTime;
  public float DelayTimeToEnableCaptureVolume;
  public APlayerReplicationInfo LastCapturePRI;
  public ASFCaptureGameReplicationInfo SFCaptureGRI;
  public bool bCaptureSendMessage;
  public bool bWorkingTurret;
}

public class ASFCaptureGameReplicationInfo : ASFGameReplicationInfo
{
  public int CapturedPlayerID;
  public ETeam ECaptureTeam;
  public int PassedCaptureTime;
  public int CompleteCaptureTime;
}

public class USFCaptureGameScore : USFGameScore
{
}

public class ASFCaptureHUD : ASFTeamDeathHUD
{
}

public class ASFCapturePlayerController : ASFPlayerController
{
  public string MSG_CaptureWarning_OwnTeam;
  public string MSG_CaptureWarning_LostTeam;
  public float CaptureWarningTime;
}

public class ASFCaptureRocketJumpGame : ASFCaptureGame
{
}

public class ASFCaptureTheFlagGame : ASFBaseTeamDeathGame
{
}

public class ASFCaptureTheFlagGameReplicationInfo : ASFGameReplicationInfo
{
}

public class USFSeizureGameScore : USFGameScore
{
  public float SCORE_Seizured;
  public float SCORE_DefendSeizure;
  public float SCORE_SeizuredTeam;
  public float SCORE_DefendSeizureTeam;
}

public class USFCaptureTheFlagGameScore : USFSeizureGameScore
{
  public float SCORE_CaptureTheFlag;
  public float SCORE_CaptureTheFlagTeam;
}

public class ASFCaptureTheFlagHUD : ASFTeamHUD
{
}

public class ASFCaptureTheFlagPlayerController : ASFPlayerController
{
}

public class ASFCaptureTheFlagTeamInfo : ASFTeamInfo
{
}

public class ASFCaptureVolume : ASFModeVolume
{
}

public class ASFCarriedObject : AActor
{
}

public class USFCCTV : UObject
{
  public List<USFCCTV_MapInfo> AllCCTVInfos;
  public USFCCTV_MapInfo CCTVMapInfo;
  public FName CCTVCameraTag;
}

public class USFCCTV_DataStoreBase : UObject
{
  public class FCCTVInfo
  {
    public UObject.FVector FreeCamLocation;
    public UObject.FRotator FreeCamRotation;
    public UObject.FVector TranslucentCamLocation;
    public UObject.FRotator TranslucentCamRotation;
  }

}

public class USFCCTV_MapInfo : USFCCTV_DataStoreBase
{
  public string MapName;
  public FCCTVInfo[] CCTVInfos = new FCCTVInfo[10];
  public FVector TopViewCamLocation;
  public FRotator TopviewCamRotation;
  public List<AActor> ViewTargetActorList;
}

public class USFChallengeListCondition : USFBaseCondition
{
  public class FSChallengeMedalRange
  {
    public int Min;
    public int Max;
  }

  public class FChallengeProgressData
  {
    public USFTypes.FChallengeData TableData;
    public USFTypes.FChallengeLocalized TableLocalized;
    public int CurrScore;
    public USFTypes.FTime_t CompleteDate;
  }

  public List<FSChallengeMedalRange> MedalRangeList;
  public List<USFTypes.FChallengeData> AllChallengeDataList;
  public List<USFTypes.FChallengeLocalized> AllChallengeLocalizedList;
  public Dictionary<byte, byte> ChallengeListByEvent;
  public Dictionary<byte, byte> DefaultChallengeListByEvent;
  public Dictionary<byte, byte> EventNameBySupplyCode;
  public Dictionary<byte, byte> SavedScoreBySupplyCode;
  public List<FChallengeProgressData> CompleteChallengeTotalList;
  public List<FChallengeProgressData> InvalidateChallengeList;
  public List<USFTypes.FChallengeData> CompleteMessageList;
  public int GameModeID;
  public int MapID;
  public int TotalPlayerCounter;
  public int RecvWeaponProgressionTask;
  public List<USFTypes.FSWeaponProgressionTask> WeaponProgressionTaskArray;
}

public class USFChangePlayerTeamInterface : UInterface
{
}

public class USFChannelType : UObject
{
  public List<USFTypes.FSChannelType> ChannelTypes;
  public List<int> ChannelGroupAdModeFilter;
  public List<USFTypes.FSRecommendChannel> RecommendChannelTypes;
  public List<USFTypes.FSChannelEXP> ChannelEXPArray;
  public string AddEXPMessage;
  public string AddSPMessage;
}

public class ASFCheatManager : ACheatManager
{
  public class FLensFXData
  {
    public string FXName;
    public string PSName;
  }

  public FCylinder SpawningEnemySize;
  public ASFAIController SpawnedAI;
  public int SpawnedAIIndex;
  public float AIDeadTime;
  public USFQACheckMessage QAMessage;
  public bool bProgressOneFrame;
  public bool bReservePause;
  public bool bEnableOnScreenDebugMessagesDisplay;
  public bool IsForward;
  public List<string> WeatherType;
  public UClass DLOTestClass;
  public List<FLensFXData> LensFXList;
  public USFMapInfo SFMI;
  public List<ASFGamePlayerStart> arrRespawnPoint;
  public ASFPawn CurrViewTargetPawn;
  public string DevFacebookToken;
  public string DevFacebookSFLink;
}

public class USFChestHitByWeaponData : USFWeaponEventData
{
}

public class USFChestHitCountEventData : USFBaseEventData
{
}

public class USFClanMark : UObject
{
  public class FSTestClanMark
  {
    public string ClanName;
    public string ClanRank;
    public string ClanMark;
  }

  public string DefaultClanMark;
  public string DefaultClanRank;
  public List<FSTestClanMark> TestClanMarkArray;
}

public class USFClanMarkList : UObject
{
  public List<USFTypes.FsClanMarkInfo> ClanMarkListArray;
  public List<string> ClanMarkToolTipArray;
  public string NullClanmark;
  public string TabType_AllName;
  public int TabType_AllSortNumber;
}

public class USFConditionManager : UObject
{
  public List<USFBaseCondition> ConditionList;
}

public class USFConsoleCommandHandler : UObject
{
  public class FCommandTranslator
  {
    public string Command;
    public string TranslatedCommand;
    public string Postfix;
  }

  public List<FCommandTranslator> CommandTranslators;
}

public class USFContinualPlayerKillEventData : USFBaseEventData
{
}

public class ASFConvoyanceGame : ASFTeamGameInfo
{
  public class FSConvoyanceSpeedInfo
  {
    public int Min;
    public int Max;
    public float SpeedRate;
  }

  public List<FSConvoyanceSpeedInfo> SpeedInfo;
  public float MinRespawnDelayForRed;
  public float MinRespawnDelayForBlue;
  public string ConvoyanceItemClass;
  public List<APathNode> ConvoyPathNodeArray;
  public List<ASFTrigger_ConvoyanceItem> ConvoyanceItemArray;
  public List<ASFPlayerController> ControllerArrayNearCar;
  public ASFConvoyanceTargetVolume ConvoyanceTargetVolume;
  public ASFConvoyanceGameReplicationInfo SFConvoyanceGRI;
  public FVector ConvoyanceStartLocation;
  public int TotalMoney;
  public int RemainMoney;
  public int SeizureMoney;
  public int PathNodeOrderNumber;
  public float[] ConvoyanceDistance = new float[3];
  public float MovedDistance;
  public float ConvoyVehicleSpeedRate;
  public bool IsConvoyanceMoving;
  public bool IsNotiRemainRemainThreeQuater;
  public bool IsNotiRemainRemainHalf;
  public bool IsNotiRemainRemainQuater;
  public bool IsNotiRemainRemainZero;
  public FScriptDelegate __SortConvoyPathNodeArrayDelegate__Delegate;
}

public class ASFConvoyanceGameReplicationInfo : ASFGameReplicationInfo
{
  public int SeizureMoney;
  public int RemainMoney;
  public int TotalMoney;
  public int ClearMessagePlayerID;
  public float MovedDistance;
  public bool IsConvoyanceMoving;
  public AInterpActor MoveTarget;
}

public class USFConvoyanceGameScore : USFGameScore
{
  public class FConvoyancePointInfo
  {
    public int PlayerNum;
    public float Score;
  }

  public class FExpScoreBaseInfo
  {
    public int KillCount;
    public float BaseNumber;
  }

  public List<FConvoyancePointInfo> PushScore;
  public List<FConvoyancePointInfo> SeizureScore;
  public List<FExpScoreBaseInfo> ExpScoreInfo;
}

public class ASFConvoyanceGameTeamInfo : ASFTeamInfo
{
  public int TotalAccquireItemAmount;
  public int TotalPushScore;
}

public class ASFConvoyanceHUD : ASFHUD
{
  public class FConvoyanceSortPRIData
  {
    public List<ASFPlayerReplicationInfo> PRIArray;
  }

  public FConvoyanceSortPRIData[] SortPRIArray = new FConvoyanceSortPRIData[8];
  public string[] TopLeftPlayerText = new string[3];
  public string[] TopRightPlayerText = new string[3];
  public string TopPlayerTextOfMe;
  public string RoundStatusText;
}

public class ASFConvoyancePlayerController : ASFPlayerController
{
  public string MoneyReturnMessage;
  public string MoneySeizureMessage;
}

public class ASFConvoyancePlayerReplicationInfo : ASFPlayerReplicationInfo
{
  public bool IsAttachItem;
  public bool IsShowCarPushGauge;
  public int CurrentAccquireItemAmount;
  public int AccquireItemAmount;
  public int ReturnItemAmount;
  public int PushScore;
  public int SeizureScore;
  public int InVolumeStartTime;
  public int TotalPushTime;
}

public class ASFConvoyanceTargetVolume : AVolume
{
}

public class ASFConvoyTargetPathNode : APathNode
{
  public int OrderNumber;
  public EConvoyancePathGroup PathGroup;
  public float PrevPointDistance;
}

public class ASFCoupleGame : ASFTeamGameInfo
{
  public int MaxTeamMember;
}

public class ASFCouplePlayerController : ASFPlayerController
{
  public string HealthPackClassName;
  public int MaxHealthPackCounter;
  public int UsedHealthPackCounter;
  public UClass HealthPackClass;
}

public class USFCrosshairBase : UObject
{
  public float CrosshairThickness;
}

public class USFCrosshairCirclecross : USFCrosshairBase
{
}

public class USFCrosshairCirclePoint : USFCrosshairBase
{
}

public class USFCrosshairDiagonal : USFCrosshairBase
{
}

public class USFCrosshairFine : USFCrosshairBase
{
}

public class USFCrosshairPoint : USFCrosshairBase
{
}

public class USFCrosshairRectangle : USFCrosshairBase
{
}

public class USFCrosshairSharp : USFCrosshairBase
{
}

public class USFCrosshairStraightCross : USFCrosshairBase
{
}

public class ASFCTCGameReplicationInfo : ASFGameReplicationInfo
{
}

public class ASFCTCPlayerController : ASFPlayerController
{
}

public class ASFCTCTDMHUD : ASFTeamHUD
{
}

public class ASFRoundTDMGame : ASFTeamGameInfo
{
}

public class ASFCTCTeamDeathGame : ASFRoundTDMGame
{
  public int CaptainKiller;
  public int CaptainKillAssist;
}

public class ASFCTCTeaminfo : ASFTeamInfo
{
  public int CaptainIndex;
  public int CaptainTransferHealth;
  public AController CaptainKiller;
}

public class USFCTFGameScore : USFGameScore
{
  public float SCORE_Seizure;
  public float SCORE_Return;
  public float SCORE_Capture;
  public float SCORE_SeizureTeam;
  public float SCORE_ReturnTeam;
  public float SCORE_CaptureTeam;
}

public class ASFCTFPlayerReplicationInfo : ASFPlayerReplicationInfo
{
  public ASFFlagActor Flag;
}

public class USFCustomAsset : UObject
{
}

public class USFCustomAsset_Char : USFCustomAsset
{
}

public class USFCustomAsset_Weap : USFCustomAsset
{
}

public class USFCustomBuilder : UObject
{
}

public class USFCustomBuilder_Char : USFCustomBuilder
{
}

public class USFCustomBuilder_Hand : USFCustomBuilder
{
}

public class USFCustomBuilder_Helmet : USFCustomBuilder
{
}

public class USFCustomBuilder_Weap : USFCustomBuilder
{
}

public class ASFCustomBuildHelper : AActor
{
}

public class USFCustomCache : UObject
{
}

public class USFCustomCacheData : UObject
{
}

public class USFSkeletalMeshComponent : USkeletalMeshComponent
{
  public bool bForceLoadTextures;
  public bool bSuppressDuplicate;
  public float ClearStreamingTime;
}

public class USFMeshBuilder : UObject
{
  public class FPlayerMeshesInfo
  {
    public int PlayerID;
    public string PlayerName;
    public List<USFMeshBuilder.FMeshGroup> PlayerMeshGroups;
  }

  public class FMergedTextureInfo
  {
    public UTexture2DComposite.FSourceTexture2DRegion Region;
    public EPartType Type;
    public UObject.FVector2D UVOffset;
    public UObject.FVector2D UVScale;
  }

  public class FMergedTextureSize
  {
    public EMeshGroup Type;
    public UObject.FVector2D[] TextureSize = new UObject.FVector2D[4];
  }

  public class FPlayerItemArrayInfo
  {
    public int PlayerID;
    public List<int> PawnItemArray;
  }

  public class FAsyncMeshGroupInfo
  {
    public AActor Caller;
    public FScriptDelegate Callback;
  }

  public class FMeshPart
  {
    public EPartType PartLabel;
    public int PartID;
    public USkeletalMesh Mesh;
    public bool bIsMainMesh;
    public UMaterialInterface Material;
    public UTexture2D[] Textures = new UTexture2D[4];
    public string CamoTexturesName;
    public List<UMaterialInstanceConstant.FVectorParameterValue> VectorParameterValues;
    public List<UMaterialInstanceConstant.FScalarParameterValue> ScalarParameterValues;
    public List<UMaterialInstanceConstant.FTextureParameterValue> TextureParameterValues;
  }

  public class FMeshGroup
  {
    public EMeshGroup GroupLabel;
    public List<USFMeshBuilder.FMeshPart> MeshParts;
  }

  public EMeshCompositionType MeshCompositionType;
  public List<FPlayerMeshesInfo> PlayerMeshesInfos;
  public List<FMergedTextureInfo> CharacterMergedTextureInfos;
  public List<FMergedTextureInfo> BigWeaponMergedTextureInfos;
  public List<FMergedTextureInfo> SmallWeaponMergedTextureInfos;
  public List<FMergedTextureSize> CharacterMergedTextureSizes;
  public List<FMergedTextureSize> BigWeaponMergedTextureSizes;
  public List<FMergedTextureSize> SmallWeaponMergedTextureSizes;
  public USFMCResourceManager MCResourceManager;
  public List<FAsyncMeshGroupInfo> RequestMeshGroupInfos;
  public List<FPlayerItemArrayInfo> PlayerItemArrayInfos;
  public bool bWaitForStreaming;
  public float FirstViewWeaponDiffusePower;
  public float FirstViewWeaponReflectionIntensity;
  public float FirstViewWeaponRimLightPower;
  public float FirstViewWeaponSpecularIntensity;
  public float FirstViewWeaponSPPowerHigh;
  public float FirstViewWeaponSPPowerLow;
  public FLinearColor FirstViewWeaponRimLightColor;
  public FLinearColor FirstViewWeaponSpecularColor;
  public float ThirdViewWeaponDiffusePower;
  public float ThirdViewWeaponReflectionIntensity;
  public float ThirdViewWeaponRimLightPower;
  public float ThirdViewWeaponSpecularIntensity;
  public float ThirdViewWeaponSPPowerHigh;
  public float ThirdViewWeaponSPPowerLow;
  public FLinearColor ThirdViewWeaponRimLightColor;
  public FLinearColor ThirdViewWeaponSpecularColor;
  public FScriptDelegate __OnMeshGroupInfoSetted__Delegate;
  public FScriptDelegate __OnPrepareResources__Delegate;
}

public class USFMeshParts : UObject
{
  public class FPartResourceData
  {
    public UObject[] Objects = new UObject[8];
    public int[] Indexes = new int[8];
  }

  public class FSFEDMeshPart
  {
    public EPartType PartLabel;
    public int PartID;
    public List<USkeletalMesh> Mesh;
    public List<UMaterialInterface> Material;
    public List<UTexture2D> DiffuseTexture;
    public List<UTexture2D> NormalTexture;
    public List<UTexture2D> SpecularTexture;
    public List<UTexture2D> MaskTexture;
  }

  public class FSFMeshPart
  {
    public EPartType PartLabel;
    public int PartID;
    public List<string> Mesh;
    public List<string> Material;
    public List<string> DiffuseTexture;
    public List<string> NormalTexture;
    public List<string> SpecularTexture;
    public List<string> MaskTexture;
  }

  public FSFEDMeshPart MeshViewerPart;
  public bool bIsLoading;
  public int CurrentOpenedPropertyWindowCount;
  public FSFMeshPart MeshPart;
}

public class ASFCustomPreview : ASkeletalMeshCinematicActor
{
  public class FCustomPreviewAnimInfo
  {
    public FName AnimType;
    public List<FName> AnimSeqNames;
    public float Rate;
    public float BlendInTime;
    public float BlendOutTime;
  }

  public class FPendingMeshInfoTable
  {
    public string SkeletalmeshString;
    public string MaterialString;
    public string DiffuseTextureString;
    public string NormalTextureString;
    public string SpecularTextureString;
    public string MaskTextureString;
    public string CamoTextureString;
    public int GroupArrayIndex;
    public int PartArrayIndex;
    public UObject.FLinearColor EpauletPatternColors;
    public UObject.FLinearColor BackgroundPatternColors;
  }

  public class FDetachMeshGroupInfo
  {
    public EMeshGroup GroupLabel;
    public List<string> MeshPartsString;
  }

  public List<FCustomPreviewAnimInfo> FullBodyAnimTypes;
  public FRotator RollMin;
  public FRotator RollMax;
  public FName PlayingAnim;
  public bool bMatchresultAnimPlaying;
  public bool bSettedBoneLoc;
  public bool IsZoomingOut;
  public bool bForceHightQuality;
  public bool bMouseMove;
  public bool bEnableBreathMorphing;
  public bool bValidFaceMorphSet;
  public bool bIsFemale;
  public bool bForceOnlySceneCaptureSee;
  public string PreviewName;
  public float BlinkTime;
  public float BlinkInterval;
  public FVector TargetOrigLoc;
  public FVector MoverOrigLoc;
  public FVector ZoomVelocity;
  public ECustomZoomState ZoomState;
  public EMoverType MoverType;
  public EMeshGroup PreViewWeaponGroupLabel;
  public EGender Gender;
  public float MoveDistMax;
  public float MoveDistLimit;
  public AActor Mover;
  public AActor Target;
  public float DeltaAccum;
  public string TargetBoneName;
  public float ZoomLimit;
  public float ZoomSpeed;
  public float ZoomStepLength;
  public AActor Camera;
  public USFAnimNodeSlotQueuing FullBodyQueue;
  public USkeletalMeshComponent HelmetComp;
  public USkeletalMeshComponent WeaponComp;
  public USkeletalMeshComponent JetpackSkelComp;
  public FName WeaponSocketName;
  public USkeletalMeshSocket WeaponSocket;
  public FName HelmetSocketName;
  public USkeletalMeshSocket HelmetSocket;
  public FName WeaponRepairBaseSocketName;
  public FRotator PrevMousePos;
  public FRotator MouseDelta;
  public List<int> PendingCharItems;
  public List<int> PrevPendingCharItems;
  public List<int> PendingWeapItems;
  public List<int> PrevPendingWeapItems;
  public FPendingMeshInfoTable[] PendingCharacterMeshInfoTable = new FPendingMeshInfoTable[61];
  public FPendingMeshInfoTable[] NewCharacterMeshInfoTable = new FPendingMeshInfoTable[61];
  public FPendingMeshInfoTable[] PendingHelmetMeshInfoTable = new FPendingMeshInfoTable[61];
  public FPendingMeshInfoTable[] NewHelmetMeshInfoTable = new FPendingMeshInfoTable[61];
  public FPendingMeshInfoTable[] PendingWeaponMeshInfoTable = new FPendingMeshInfoTable[61];
  public FPendingMeshInfoTable[] NewWeaponMeshInfoTable = new FPendingMeshInfoTable[61];
  public UTextureRenderTarget2D MarkRenderTarget;
  public UTextureRenderTarget2D ClanRenderTarget;
  public int PreViewWeaponPartMeshindex;
  public float BreathMinPeriod;
  public float BreathMaxPeriod;
  public float BreathTime;
  public UParticleSystem BreathParticle;
  public FName BreathSocketName;
  public UMorphNodeWeight MorphBreathNode;
  public UParticleSystemComponent BreathPSC;
  public FRotator CameraDefaultRotation;
  public USkeletalMeshComponent DualWeaponComp;
  public FName DualWeaponSocketName;
  public USkeletalMeshComponent AccessoryComponent;
  public FName AccessorySocketName;
  public List<USkeletalMeshComponent> AdditionalDualWeaponComponents;
  public USkeletalMeshComponent HairComp;
  public UMaterialInstanceConstant MaterialInstance;
  public List<UAnimSet> AnimSets;
  public int PreviewWeaponID;
  public ulong PreviewWeaponSN;
  public UParticleSystemComponent EquipmentEffectPSC;
  public UParticleSystemComponent WeaponEffectPSC;
}

public class ASFCustomCharacterPreview : ASFCustomPreview
{
}

public class USFCustomCreateStatus : UObject
{
}

public class USFCustomPart : UObject
{
}

public class USFCustomPart_Char : USFCustomPart
{
}

public class USFCustomPart_Weap : USFCustomPart
{
}

public class ASFCustomWeaponPreview : ASFCustomPreview
{
  public class FsAttachedMesh
  {
    public USkeletalMesh Mesh;
    public USkeletalMeshComponent MeshComponent;
    public UMaterialInstance AttachedMaterial;
    public FName SocketName;
  }

  public List<USFParticleSystemComponent> MuzzleFlashPSCPreviewList;
  public List<USFParticleSystemComponent> WeaponEffectPSCPreviewList;
  public List<FsAttachedMesh> AttachedMeshs;
  public float WeaponRotationSpeed;
  public int CurrentMuzzleColorIndex;
  public string CurrentMuzzleStyleID;
  public string CurrentWeaponEffectStyleID;
  public bool bIsWeaponTag;
  public bool bIsMuzzleFlash;
  public bool bIsWeaponEffect;
  public bool bIsHiddenMuzzleFlash;
  public bool bIsHiddenWeaponEffect;
  public int ItemId;
  public FName HideBoneName;
  public int HideBoneIndex;
  public float PlayMuzzleFlashTime;
  public float PlayWeaponEffectTime;
  public float CurrentDeltaTime;
}

public class USFDailyEvent : UObject
{
  public class FSDailyEventMessage
  {
    public int Count;
    public string ChattingMessage;
    public string PopUpMessage;
  }

  public string DailyEventURL;
  public List<FSDailyEventMessage> DailyEventWinCountArray;
  public List<FSDailyEventMessage> DailyEventKDCountArray;
  public string DefaultKDCountMessage;
  public string DefaultEventMessage;
  public string strWinOKMessage;
  public string strKDOKMessage;
  public string strCancelMessage;
}

public class USFDamageByPlayerEventData : USFBaseEventData
{
}

public class USFDamageEventData : USFWeaponEventData
{
}

public class USFDamageToHeroAlienControllerEventData : USFBaseEventData
{
}

public class USFDamageToPlayerEventData : USFBaseEventData
{
}

public class USFDamageType : UDamageType
{
  public bool bDirectDamage;
  public bool bCausesBloodSplatterDecals;
  public bool bComplainFriendlyFire;
  public bool bElectricShock;
  public bool bKamiKaze;
  public bool bUseDamageBasedDeathEffects;
  public bool bIsNailImpact;
  public bool bBloodUseOnlyDistanceLOD;
  public bool bForceScreenBlood;
  public bool bPlayExtendDamageDepiction;
  public string DeathString;
  public float fIgnoreWhenOverlap;
  public float NailImpactMinDistance;
  public float NailImpactForce;
  public float DamageRatio;
  public float RespawnDelay;
  public EWeaponType WeaponType;
  public SFVoiceFoleyID VoiceFoleyID;
  public SFVoiceFoleyID VoiceFoleyIDCritical;
  public SFFoleyID FoleyID;
  public float fDamageToSameTeam;
  public float fAllowSelfInjury;
  public float TermAddHitEffect;
}

public class USFDBProperty : UObject
{
}

public class USFDeadCountEventData : USFWeaponEventData
{
}

public class USFDeadPersonCameraMode : USFThirdPersonCameraModeBase
{
  public FName DeathCamTargetBone;
  public float DeathCamDistance;
  public bool bShowWall;
  public bool bDrawDebug;
  public float DOF_Distance;
  public FVector DeathCamLocation;
  public FRotator DeathCamRotation;
  public float ActiveTime;
  public float DOFDistance;
  public float DOFFocusInnerRadius;
  public float DOFMaxFarBlurAmount;
  public float DOFMaxNearBlurAmount;
}

public class ASFDeathGame : ASFGameInfo
{
}

public class ASFDeathGameReplicationInfo : ASFGameReplicationInfo
{
}

public class USFDeathGameScore : USFGameScore
{
}

public class ASFDeathHUD : ASFHUD
{
  public int FirstPlayerScore;
  public int PlayerScore;
}

public class ASFDeathTestOneGame : ASFDeathGame
{
}

public class ASFDeathTestTwoGame : ASFDeathGame
{
}

public class ASFDebugCameraController : ADebugCameraController
{
}

public class ASFDecalActorSpawnable : ADecalActorMovable
{
}

public class ASFDecalManager : ADecalManager
{
}

public class USFDedicatedDataLog : UObject
{
}

public class USFDedicatedDataPlayerLog : USFDedicatedDataLog
{
}

public class USFDedicatedDataManHuntPlayerLog : USFDedicatedDataPlayerLog
{
}

public class USFDedicatedDataPVEPlayerLog : USFDedicatedDataPlayerLog
{
}

public class USFDedicatedDataZombiePlayerLog : USFDedicatedDataPVEPlayerLog
{
}

public class USFDefaultBotChat : UObject
{
  public List<string> MultiKill;
  public List<string> UltraKill;
  public List<string> Winning;
  public List<string> MultiDie;
  public List<string> UltraDie;
  public List<string> Losing;
}

public class USFDefaultBotName : UObject
{
  public class FModeAINameInfo
  {
    public int ModeID;
    public EAITypes AIType;
    public string AIName;
  }

  public string[] AIDefaultNames = new string[62];
  public List<string> AICodeNames;
  public List<FModeAINameInfo> AIModeDefaultNames;
}

public class USFDefaultRoomName : UObject
{
  public List<string> RoomNameArray;
}

public class ASFSurvivalGame : ASFTeamGameInfo
{
  public class FsReservedBeaconTarget
  {
    public float Time;
    public APawn Inst;
    public UObject.FVector Loc;
    public UClass TargetClass;
  }

  public List<FsReservedBeaconTarget> ReservedBeaconTargets;
  public int DBNOCount;
  public float RespawnDelayForRIP;
  public float RespawnPriceForRIP;
  public AActor PrimaryTargetNow;
  public ASFSurvivalGameReplicationInfo SFSurvivalGRI;
  public float AllowedTimeToUseNextWaveTrigger;
  public int MaxWaveCounterToPass;
}

public class ASFDefenceGame : ASFSurvivalGame
{
}

public class USFDefenceGameScore : USFGameScore
{
  public List<USFTypes.FAIPawnScore> PawnClassBasis;
  public float SCORE_WaveEnd;
  public float SCORE_BossClear;
  public float SCORE_WaveEndTeam;
  public float SCORE_BossClearTeam;
}

public class ASFSurvivalHUD : ASFHUD
{
  public int AllSupressorCount;
  public int CurSupressorCount;
}

public class ASFDefenceHUD : ASFSurvivalHUD
{
}

public class ASFPathNode : APathNode
{
  public ETeam TeamIndex;
  public eNAVPointType PointType;
}

public class ASFDefensePoint : ASFPathNode
{
  public bool bCrouched;
}

public class USFDesertionRatio : UObject
{
  public class FSDesertionInfo
  {
    public float Min;
    public float Max;
  }

  public List<FSDesertionInfo> DesertionArray;
  public int DesertionValue;
  public int BeginerExp;
  public int BeginerMsgIndex;
  public int ViewDesertionPerLevel;
  public List<string> DesertionMsgs;
  public string DesertionTooltip;
}

public class USFDmgType_Explosive : USFDamageType
{
  public bool bGasDamage;
  public bool bDamagetoArmor;
  public bool bFragDamage;
}

public class USFDmgType_AI_Explosion : USFDmgType_Explosive
{
}

public class USFDmgType_HandGrenade : USFDmgType_Explosive
{
}

public class USFDmgType_HG_Frag : USFDmgType_HandGrenade
{
}

public class USFDmgType_AlienAnnihilator : USFDmgType_HG_Frag
{
}

public class USFDmgType_Arrow : USFDmgType_Explosive
{
}

public class USFDmgType_CloseCombat : USFDamageType
{
}

public class USFDmgType_Knife : USFDmgType_CloseCombat
{
}

public class USFDmgType_Atropen : USFDmgType_Knife
{
}

public class USFDmgType_Enviroment : USFDamageType
{
}

public class USFDmgType_Barricade : USFDmgType_Enviroment
{
  public UParticleSystem DeathEffectParticleSystem;
  public FName BoneNameForDeathEffect;
}

public class USFDmgType_BreakableActor : USFDamageType
{
}

public class USFDmgType_BreakableActorByDamage : USFDmgType_BreakableActor
{
}

public class USFDmgType_Bullet : USFDamageType
{
}

public class USFDmgType_LongTime : USFDamageType
{
  public int HitEffectCount;
  public UParticleSystem HitParticleSystem;
  public UParticleSystem DeathEffectParticleSystem;
  public FName BoneNameForDeathEffect;
  public float DotEffectLifeTime;
  public float DotDamage;
  public float DotDamageRadius;
}

public class USFDmgType_Burn : USFDmgType_LongTime
{
}

public class USFDmgType_C4 : USFDmgType_Explosive
{
}

public class USFDmgType_Car : USFDmgType_Explosive
{
}

public class USFDmgType_Charge : USFDmgType_CloseCombat
{
}

public class USFDmgType_Claw : USFDmgType_CloseCombat
{
}

public class USFDmgType_CrapGas : USFDmgType_Enviroment
{
}

public class USFDmgType_CrashStep : USFDamageType
{
}

public class USFDmgType_CrushBoost : USFDamageType
{
}

public class USFDmgType_Drown : USFDamageType
{
}

public class USFDmgType_Drum : USFDmgType_Explosive
{
}

public class USFDmgType_ElectricShock : USFDmgType_LongTime
{
}

public class USFDmgType_ElectricBarricade : USFDmgType_ElectricShock
{
}

public class USFDmgType_Elevator : USFDamageType
{
}

public class USFDmgType_EnvCrash : USFDamageType
{
}

public class USFDmgType_Fell : UDmgType_Fell
{
}

public class USFDmgType_GrenadeLauncher : USFDmgType_Explosive
{
}

public class USFDmgType_HG_FBang : USFDmgType_HandGrenade
{
}

public class USFDmgType_HG_Gas : USFDmgType_HandGrenade
{
}

public class USFDmgType_HG_Smoke : USFDmgType_HandGrenade
{
}

public class USFDmgType_IncendiaryGrenade : USFDmgType_LongTime
{
}

public class USFDmgType_KillVolume : USFDmgType_Explosive
{
}

public class USFDmgType_MG : USFDmgType_Bullet
{
}

public class USFDmgType_MG_AutoTurret : USFDmgType_MG
{
}

public class USFDmgType_OxygenCylinder : USFDmgType_Explosive
{
}

public class USFDmgType_Pistol : USFDmgType_Bullet
{
}

public class USFDmgType_StunnerExplo : USFDmgType_Explosive
{
}

public class USFDmgType_PlayerStunnerExplo : USFDmgType_StunnerExplo
{
}

public class USFDmgType_Rifle : USFDmgType_Bullet
{
}

public class USFDmgType_RPG : USFDmgType_Explosive
{
}

public class USFDmgType_Shotgun : USFDmgType_Bullet
{
}

public class USFDmgType_ThrowingKnife : USFDmgType_Explosive
{
}

public class USFDmgType_Shuriken : USFDmgType_ThrowingKnife
{
}

public class USFDmgType_SMG : USFDmgType_Bullet
{
}

public class USFDmgType_Sniper : USFDmgType_Bullet
{
}

public class USFDmgType_Strike : USFDamageType
{
}

public class USFDmgType_StunGrenade : USFDmgType_Charge
{
}

public class USFDmgType_SuicideBomb : USFDmgType_HG_Frag
{
}

public class USFDmgType_TeslaCanon : USFDmgType_ElectricShock
{
}

public class USFDmgType_ThrowingTomahawk : USFDmgType_ThrowingKnife
{
}

public class USFDmgType_ThrowingToyHammer : USFDmgType_ThrowingKnife
{
}

public class USFDmgType_Tomahawk : USFDmgType_Knife
{
}

public class USFDmgType_ToyHammer : USFDmgType_CloseCombat
{
}

public class USFDmgType_ToyHammer_StunRecover : USFDmgType_ToyHammer
{
}

public class ASFWaterVolume : AWaterVolume
{
  public class FCalmeraLensParticleInfo
  {
    public UParticleSystem LensEffect;
    public float LifeSpan;
    public bool bPreventRemoveEffect;
  }

  public class FEntryParticleInfo
  {
    public UParticleSystem Effect;
    public float ScaleRatio;
    public UObject.FVector2D ScaleRange;
    public float NormalOffset;
  }

  public class FWaterSplashInfo
  {
    public UParticleSystem Effect;
    public UObject.FVector LocationOffset;
    public int Yaw;
  }

  public List<FCalmeraLensParticleInfo> PS_CameraLensEffects;
  public List<FCalmeraLensParticleInfo> PS_CameraLensUnderWaterEffects;
  public List<FCalmeraLensParticleInfo> PS_CameraLensOutSideWaterEffects;
  public List<FEntryParticleInfo> EntryEffects;
  public USoundCue PawnEntrySound;
  public List<FWaterSplashInfo> WaterSplashEffect;
  public List<ASFEmitterNoSync_WaterSplash> WaterSplashEmitter;
}

public class ASFDotDamageVolume : ASFWaterVolume
{
  public bool bFusRoDah;
}

public class USFDoubleKillEventData : USFSpecialKillEventData
{
}

public class ASFDropOnlyHelmet : AActor
{
  public USkeletalMeshComponent HelmetMesh;
  public UDynamicLightEnvironmentComponent LightEnvironment;
  public FVector DropOffImpulse;
  public FName HeadBoneName;
}

public class ASFDroppableParts : AActor
{
  public USkeletalMeshComponent DropMesh;
  public UDynamicLightEnvironmentComponent LightEnvironment;
  public FVector DropOffImpulse;
  public FName BoneName;
}

public class ASFDroppedPickupEx : ADroppedPickup
{
  public int MaxBounceCount;
  public int BounceCount;
  public float Bounciness;
  public float VelocityDampingFactor;
  public float StopSimulatingVelocityThreshhold;
  public bool bBegunPlay;
  public bool bPickUpState;
  public bool bRegisterIndicator;
  public float MaxFloatingValue;
  public float FloatingFreq;
  public float FloatingSeed;
  public UStaticMeshComponent PickupComp;
  public int Point;
  public ETeam Team;
  public EObjectIconTypes IconType;
  public EObjectIconState IconState;
}

public class ASFDroppedPickup_Health : ASFDroppedPickupEx
{
  public float InitialSpeed;
  public int OutLineIndex;
  public int PlayerID;
}

public class ASFDroppedPickup_Magazine : ASFDroppedPickup
{
}

public class ASFDroppedPickup_ShooterItem : ASFDroppedPickupEx
{
  public float ItemLifeTime;
  public float StatUpTime;
  public float BlinkTime;
  public float BlinkTerm;
  public UParticleSystem PickupEffect;
  public int SlotIdx;
  public List<string> InnerChildClasses;
  public string BlinkEffectString;
  public float BlinkEffectScale;
  public UParticleSystem BlinkEffectPS;
}

public class ASFDroppedPickup_ShooterHealth : ASFDroppedPickup_ShooterItem
{
}

public class ASFDroppedPickup_ShooterMoney : ASFDroppedPickup_ShooterItem
{
}

public class ASFDroppedPickup_ShooterPowerUp : ASFDroppedPickup_ShooterItem
{
}

public class ASFDroppedPickup_Weapon : ASFDroppedPickup
{
  public ASFWeapon InventoryHolder;
  public USkeletalMeshComponent PickUpMeshComponent;
  public UCylinderComponent CylinderForTouch;
  public float ValidTouchAngle;
  public float ValidTouchAngleConverted;
  public float CollisionRadius;
  public float CollisionHeight;
  public FVector SpawnLocation;
  public FRotator SpawnRotation;
  public FVector ThrowLinearVelocity;
  public FVector ThrowAngularVelocity;
  public byte PhysicsPropertyMask;
}

public class ASFDuelGame : ASFTeamGameInfo
{
  public FName PlayerSortType;
  public int SetOverDelay;
  public bool bReserveLastHP;
  public ASFDuelGameReplicationInfo SFDuelGRI;
}

public class ASFDuelGameReplicationInfo : ASFGameReplicationInfo
{
  public int DuelMatchCounter;
}

public class ASFDuelPlayerController : ASFPlayerController
{
}

public class ASFDuelPlayerReplicationInfo : ASFPlayerReplicationInfo
{
  public int PlayOrder;
}

public class ASFDuelTeamInfo : ASFTeamInfo
{
  public List<ASFDuelPlayerReplicationInfo> SortedTeamPRI;
  public int WinningSet;
  public int MatchingPlayerIndex;
  public int TotalPlayer;
}

public class ASFDynamicInterpActor : AInterpActor
{
}

public class ASFDynamicWaterVolume : ASFWaterVolume
{
}

public class USFEarnScoreEventData : USFWeaponEventData
{
}

public class USFWaveCompleteByMap : USFBaseEventData
{
}

public class USFEasyWaveCompleteByMap : USFWaveCompleteByMap
{
}

public class ASFElevatorActor : AInterpActor
{
  public FName RopeMICParam;
  public AStaticMeshActor RopeMeshActor;
  public int RopeMaterialIndex;
  public List<ASFTrigger_Elevator> arrElevatorTrigger;
  public UMaterialInstanceConstant RopeMIC;
  public FName currState;
  public bool bPeriodicRecordingForKillCam;
  public float RecordingPeriod;
  public float PerioicRecordingDeltaTime;
}

public class USFEmblemManager : UObject
{
  public string MSG_Emblem_NotEnough_PCRoom_Level;
  public string MSG_Emblem_Spray_Expired;
  public string MSG_Emblem_NotEnough_VIPGrade;
  public USFGFxLobby Lobby_Manager;
}

public class ASFEmitter : AEmitter
{
  public class FDistanceBasedParticleTemplate
  {
    public UParticleSystem Template;
    public float MinDistance;
  }

  public USoundCue Sound;
  public UParticleSystem ParticleSystem;
}

public class ASFEmit_HitEffect : ASFEmitter
{
}

public class ASFEmit_Weather : AEmitter
{
  public ASFPlayerController BasePC;
  public USoundCue WeatherLoopCue;
  public UAudioComponent WeatherLoopAC;
  public UParticleSystem WeatherDropsOnPawn;
  public UParticleSystem WeatherCameraPS;
  public bool bDoWeatherDropsOnCamera;
  public bool bDoWeatherdropsOnPawn;
  public bool CheckOverHead;
  public float WeatherDropsOnCameraInterval;
  public float WeatherDropsOnPawnInterval;
  public int NumWeatherDropsToFireAtOnceOnPawn;
  public float LastWeatherDropsOnCamera;
  public float LastWeatherDropsOnPawn;
  public float ZDistAbovePawn;
  public UParticleSystemComponent WeatherPSC;
  public List<FName> ParameterNames;
  public float PSCRadius;
  public byte CheckFlag;
  public int Index;
  public AEmitterCameraLensEffectBase WeatherCameraLensEffect;
  public FVector[] Direction = new FVector[8];
}

public class ASFEmit_Rain : ASFEmit_Weather
{
  public float RainDropPitchMin;
  public float RainDropPitchMax;
  public bool TurnedOff;
}

public class ASFEmit_Snow : ASFEmit_Weather
{
  public float ElapsedFrosty;
  public float LastUpdateTime;
  public float FrostyTime;
  public float ClearTime;
}

public class ASFEmitterCameraLensEffectBase : AEmitterCameraLensEffectBase
{
}

public class ASFEmitterNoSync : AEmitter
{
  public FScriptDelegate OnFinishedCallBack;
  public FScriptDelegate __OnFinished__Delegate;
}

public class ASFEmitterNoSync_WaterSplash : ASFEmitterNoSync
{
  public APawn BasePawn;
  public FVector2D LocationOffset;
}

public class ASFEmitterNoSyncSpawnable : ASFEmitterNoSync
{
}

public class ASFEmitterPool : AEmitterPool
{
  public class FAttachedExplosionLight
  {
    public USFExplosionLight Light;
    public AActor Base;
    public UObject.FVector RelativeLocation;
  }

  public List<FAttachedExplosionLight> RelativeExplosionLights;
}

public class ASFEmitterSpawnable : AEmitter
{
}

public class USFEnableSurvivalMapAward : USFBaseAward
{
  public ELevelOfDifficulty EnableDifficulty;
}

public class USFEnableSurvivalHardMapAward : USFEnableSurvivalMapAward
{
}

public class USFEnableSurvivalNormalMapAward : USFEnableSurvivalMapAward
{
}

public class USFEnableSurvivalVeryHardMapAward : USFEnableSurvivalMapAward
{
}

public class ASFEntryGame : ASFGameInfo
{
  public List<ASFCustomPreview> Previews;
  public List<string> PreviewNames;
  public int ShowingPreviewIdx;
  public ASFCustomWeaponPreview PreviewCamoWeapon;
  public string PreviewCamoWeaponName;
  public ASFCustomWeaponPreview PreviewCustomizeWeapon;
  public string PreviewCustomizeWeaponName;
  public int DbgPreviewCount;
}

public class ASFEntryHUD : ASFHUD
{
  public List<ASFCustomPreview> arrPreview;
  public FVector CameraWeaponRepireLoc3DOld;
  public FVector CameraWeaponRepireLoc3D;
  public FVector CameraWeaponRepireLoc2D;
}

public class ASFEntryPlayerController : ASFPlayerController
{
  public int PreviewWeaponID;
  public ulong PreviewWeaponSN;
  public bool bPreviewDefCharacter;
  public bool bEnableGFxUISystem;
  public FName LobbyStep;
  public List<UAudioComponent> LobbySoundComponent;
  public List<FScriptDelegate> ScreenshotNotiListeners;
  public FScriptDelegate __OnCodeNameCompleted__Delegate;
  public FScriptDelegate __OnReadyToInputCodeName__Delegate;
  public FScriptDelegate __OnScreenShotCaptured__Delegate;
  public FScriptDelegate __OnNotifyExpiredNoInputTime__Delegate;
}

public class ASFEntryPlayerReplicationInfo : ASFPlayerReplicationInfo
{
}

public class ASFEscapeGame : ASFTeamGameInfo
{
  public ASFEscapeGameReplicationInfo SFEscapeGRI;
}

public class ASFEscapeGameReplicationInfo : ASFGameReplicationInfo
{
}

public class USFEscapeGameScore : USFGameScore
{
  public float SCORE_Escaped;
  public float SCORE_EscapedTeam;
  public float SCORE_DefendEscapeTeam;
}

public class ASFEscapeGameVs16 : ASFEscapeGame
{
}

public class USFEscapeGameVs16Score : USFEscapeGameScore
{
}

public class ASFEscapeHUD : ASFTeamHUD
{
}

public class ASFEscapeVolume : ASFModeVolume
{
}

public class ASFEscapeVs16HUD : ASF16VS16ModeHUD
{
}

public class USFEventChallengeAward : USFBaseAward
{
}

public class USFEventDataManager : UObject
{
  public List<USFBaseEventData> EventDataList;
  public Dictionary<byte, byte> EventDataTable;
}

public class USFEventDataZombieAssist : USFBaseEventData
{
}

public class USFEventDataZombieDead : USFBaseEventData
{
}

public class USFEventDataZombieHeadShot : USFBaseEventData
{
}

public class USFEventDataZombieHeadShotByType : USFBaseEventData
{
}

public class USFEventDataZombieKill : USFBaseEventData
{
}

public class USFEventDataZombieKillByAIType : USFBaseEventData
{
}

public class USFEventDataZombieKillByCrossBow : USFBaseEventData
{
}

public class USFEventDataZombieKillByCrowBar : USFBaseEventData
{
}

public class USFEventDataZombieKillByFlamer : USFBaseEventData
{
}

public class USFEventDataZombieKillByRPG : USFBaseEventData
{
}

public class USFKillEventData : USFWeaponEventData
{
}

public class USFEventDataZombieKillByWPType : USFKillEventData
{
}

public class USFEventDataZombieLimitedWeapon : USFBaseEventData
{
}

public class USFEventDataZombieMultiKill : USFBaseEventData
{
}

public class USFEventDataZombieMultiKill1 : USFEventDataZombieMultiKill
{
}

public class USFEventDataZombieMultiKill2 : USFEventDataZombieMultiKill
{
}

public class USFEventDataZombieMultiKill3 : USFEventDataZombieMultiKill
{
}

public class USFEventDataZombieNoDie : USFBaseEventData
{
}

public class USFEventDataZombieNoUseShop : USFBaseEventData
{
}

public class USFEventDataZombiePlayTime : USFBaseEventData
{
}

public class USFEventDataZombieRevival : USFBaseEventData
{
}

public class USFExplosionLight : UPointLightComponent
{
  public class FLightValues
  {
    public float StartTime;
    public float Brightness;
    public UObject.FColor LightColor;
  }

  public bool bInitialized;
  public float Lifetime;
  public int TimeShiftIndex;
  public List<FLightValues> TimeShift;
  public FScriptDelegate __OnLightFinished__Delegate;
}

public class USFExtraBodyPartsManager : UObject
{
  public class FsExtraPart
  {
    public UClass PartsClass;
    public ASkeletalMeshActorSpawnable PartsMesh;
    public List<FName> HitableParts;
    public int DefencePoint;
    public float DefenceDir;
    public float DefenceRange;
    public ECollisionType SavedCollisionType;
    public eExtraBodyPart PartID;
  }

  public bool binited;
  public ASFPawn Owner;
  public List<FsExtraPart> ExtraParts;
  public USkeletalMeshComponent TargetMesh;
}

public class USFFacebookManager : UObject
{
  public USFOnlineSubsystemPC OnlineSubOwner;
  public string RequestAuthorityURL;
  public string FacebookClientID;
  public string FacebookClientSecretID;
  public string AuthorityResponseURL;
  public string AuthorityFailedResponseURL;
  public string FacebookURL;
  public string FacebookLogoutURL;
  public string TokenPrefix;
  public string CookieURL;
  public string CookieClearData;
  public int FrameWidth;
  public int FrameHeight;
  public string NoticeURL_CodenameChanged;
  public string NoticeURL_Interlocked;
  public string NoticeURL_RareItemReceived;
  public string NoticeURL_Promoted;
  public string NoticeURL_ClanCreated;
  public string NoticeURL_ClanMatchWon;
  public string NoticeMessage_CodenameChanged;
  public string NoticeMessage_Interlocked;
  public string NoticeMessage_RareItemReceived;
  public string NoticeMessage_Promoted;
  public string NoticeMessage_FacebookAuthTokenNullified;
  public string NoticeMessage_ClanCreated;
  public string NoticeMessage_ClanMatchWon;
  public float LastFriendsListUpdatedTime;
  public float FriendListUpdateDelay;
}

public class USFFastZoomEventData : USFSpecialKillEventData
{
}

public class USFFelloutFirstPersonCameraMode : USFThirdPersonCameraModeBase
{
  public bool bTrackLocationTargetBone;
  public bool bTrackRotationTargetBone;
  public bool bHiddePawnMesh;
  public bool bOwnerNoSeePawnMesh;
  public float CameraDistanceFromTargetBone;
  public FName TargetBoneName;
  public int MouseX;
  public int MouseY;
  public int MaxMouseX;
  public int MaxMouseY;
}

public class USFFelloutPersonCameraMode : USFThirdPersonCameraModeBase
{
  public FVector InitLocation;
}

public class ASFFFAPlayerController : ASFPlayerController
{
}

public class USFTextFilter : UObject
{
  public List<USFTypes.FSCharRange> CommonCharacterSet;
  public List<USFTypes.FSCharRange> KorConsonantCharacterSet;
  public List<USFTypes.FSCharRange> JapanHiraganaCharSet;
  public List<USFTypes.FSCharRange> JapanKatakanaCharSet;
}

public class USFFilterChatting : USFTextFilter
{
  public class FSFindPos
  {
    public int nPos;
    public string strReplace;
    public string strFind;
  }

  public List<string> ChatFilterStringSet;
  public List<USFTypes.FsEmoticonData> replacementEmoticonStringSet;
  public List<USFTypes.FsEmoticonData> HTMLFilterStringSet;
  public List<string> replacementCensoredStringSet;
  public List<string> ItemPropTextArray;
}

public class USFFilterCodeName : USFTextFilter
{
  public class FSpecialCharRange
  {
    public int Index;
    public int Start;
    public int End;
  }

  public List<USFTypes.FSCharRange> EnableLocalCharSet;
  public int JapanLongCharacter;
  public int JapanDotCharacter;
  public List<string> NameFilterStringSet;
  public List<string> NameforDebug;
  public List<FSpecialCharRange> EnableSpecialCharSet;
}

public class USFFirstKillEventData : USFSpecialKillEventData
{
}

public class ASFFlagActor : ASkeletalMeshActor
{
  public FVector OriginPosition;
  public FRotator OriginRotation;
  public FVector DroppedLocation;
  public ASFPawn Catcher;
  public ETeam FlagTeam;
  public LastFlagAction LastAction;
  public UCylinderComponent CylinderComponent;
  public UParticleSystem EatFlagPS;
  public USkeletalMeshComponent DuplicatedFlagMesh;
  public UParticleSystem TracerPS;
  public UParticleSystemComponent TracerPSC;
}

public class USFFlashBackCameraMode : USFThirdPersonCameraModeBase
{
  public UTexture ColorGrading_LookupTable;
  public UParticleSystem FlashBackScreenEffect;
  public UParticleSystem ProjectileFlashBackScreenEffect;
  public UParticleSystemComponent SpawnedFlashBackEffect;
  public UParticleSystemComponent SpawnedProjectileFlashBackEffect;
}

public class ASFFractureManager : AFractureManager
{
}

public class ASFFrictionVolume : APhysicsVolume
{
  public ETeam TargetTeamToFriction;
  public int SFGroundFriction;
  public int OldGroundFriction;
}

public class ASFFrontLineGame : ASFTeamGameInfo
{
  public List<ASFFrontLineVolume> arrFrontLineVolumes;
}

public class ASFFrontLineGameReplicationInfo : ASFGameReplicationInfo
{
}

public class USFFrontLineGameScore : USFGameScore
{
  public float TEAMSCORE_Occupying1VolumePerSec;
  public float TEAMSCORE_Occupying2VolumePerSec;
  public float TEAMSCORE_Occupying3VolumePerSec;
  public float KillAssistAndOccupyRateForTeamScore;
  public float SCORE_Occupy;
}

public class ASFFrontLineHUD : ASFTeamHUD
{
}

public class ASFFrontLineVolume : ASFModeVolume
{
  public class FOccupyRatioInfo
  {
    public int PawnCounter;
    public float Ratio;
  }

  public List<FOccupyRatioInfo> OccupyRatioSetting;
  public float TeamCheckPeriod;
  public float DelayTimeToNeutralization;
  public ETeam OccupiedTeam;
  public float OccupyRatio;
  public List<ASFPawn> arrSFPawns;
}

public class ASFGamePlayerStart : APlayerStart
{
  public bool bHumanStart;
  public bool bOnlyUseToRespawn;
  public float EnemyRadiusForRespawn;
  public FVector EnemeyRadiusCenterOffsetForRespawn;
  public float fLastReSpawnTime;
  public FVector FriendLocation;
  public FVector EnemeyRadiusCenterInWorldSpace;
  public List<UTexture2D> TeamSprites;
  public UTexture2D DefaultSprite;
  public UDrawSphereComponentWhenSelecting SphereComp;
  public List<UClass> ExceptionGameModes;
  public int GorupNumber;
}

public class ASFGameAIStart : ASFGamePlayerStart
{
  public List<EAITypes> SuppressAITypes;
}

public class ASFGameConvoyTargetAIStart : ASFGameAIStart
{
}

public class ASFGameCrowdAgentSkeletal : AGameCrowdAgentSkeletal
{
}

public class USFGameDatabase : UObject
{
  public class FSFPlayerLog
  {
    public string ForceItemCode;
    public int PlayTime;
    public int[] KillCntByType = new int[3];
    public int[] AssistCntByType = new int[3];
    public int[] DeadCntByType = new int[3];
    public int HeadShotCount;
    public int ChestHitCount;
    public int StomachHitCount;
    public int LimbsHitCount;
    public int HeadPointHitCount;
    public int AliveCount;
    public int AttackRound;
    public int DefendRound;
    public int TotalWinCount;
    public int TotalLoseCount;
    public int WinGameCount;
    public int CSN;
    public int PlayerWithCount;
    public int EarnScore;
    public int LuckyPoint;
    public int EarnLuckyPointCount;
    public int AttackRoundWin;
    public int DefendRoundWin;
    public int TotalHitEnemyCount;
    public int HeadHitCount;
    public string MainWeaponItemCode;
    public int TotalHitCount;
    public int Validation_Kill;
    public int Validation_Assist;
    public int Validation_Death;
    public int Validation_MissionInfo_1;
    public int Validation_MissionInfo_2;
    public int Validation_MissionInfo_3;
    public int Validation_LuckyPointCount;
    public int Validation_HeadShot;
    public int GameScore;
  }

  public class FSFPEVPlayerLog
  {
    public int KillCount;
    public int BossKill;
    public int CriticalKill;
    public int AssistCount;
    public int DeadCount;
    public int AccumulationMoney;
    public int SpendMoney;
    public int CurrentWave;
    public int EliteCrawlerKill;
    public int NamedCrawlerKill;
    public int EliteRipperKill;
    public int NamedRipperKill;
    public int CloakingRipperKill;
    public int EliteLibertineKill;
    public int NamedLibertineKill;
    public int EliteStunnerKill;
    public int NamedStunnerKill;
    public int GasStunnerKill;
    public int EliteTyrantKill;
    public int NamedTyrantKill;
  }

  public class FSFManHuntPlayerLog
  {
    public int PlayTimeByHuman;
    public int KillByHuman;
    public int AssistByHuman;
    public int DeadByHuman;
    public int[] PlayTimeByBeast = new int[3];
    public int[] KillByBeastType = new int[3];
    public int[] AssistByBeastType = new int[3];
    public int[] DeadByBeastType = new int[3];
  }

  public class FSFGameLog
  {
    public string GameRule;
    public string WinnerTeam;
    public int PlayTime;
    public byte ModeIndex;
    public byte MapIndex;
    public byte RoundCount;
    public byte[] AttackRoundWin = new byte[8];
    public byte[] DefendRoundWin = new byte[8];
    public int[] ClanPoint = new int[8];
    public int[] CSN = new int[8];
    public int WinnerCSN;
    public List<USFTypes.FAdditionalModeResult> AdditionalLog;
  }

  public class FSFTestLog_User
  {
    public string UniqueId;
    public byte IsHost;
    public string PlayerName;
    public int PlayerID;
    public float AvgFps;
    public float Above30Fps;
    public float AvgGpuTime;
    public int HitchTotal;
    public int HitGamBndCnt;
    public int HitRenBnbCnt;
    public int HitGpuBndCnt;
    public int Sec_100_150;
    public int Sec_150_200;
    public int Sec_200_300;
    public int Sec_300_500;
    public int Sec_500_INF;
    public string Desc;
    public int[] SectionHitch = new int[11];
    public float[] SectionFps = new float[13];
    public float BoundGameThreadPercent;
    public float BoundRenderThreadPercent;
    public float BoundGpuPercent;
    public float BoundGameThreadTime;
    public float BoundRenderThreadTime;
    public float BoundGpuTime;
  }

  public class FSFTestLog_Room
  {
    public string UniqueId;
    public byte IsHost;
    public string PlayerName;
    public int PlayerID;
    public int TotalPlayerCounter;
    public byte MapID;
    public byte ModeID;
    public float PingAvr;
    public int PktLoss;
    public int PktOutOrder;
    public float PktUploadAvr;
    public float PktDownAvr;
    public string Desc;
    public int[] SectionPing = new int[5];
    public int[] SectionUploadBandwidth = new int[6];
    public int[] SectionDownloadBandwidth = new int[6];
  }

  public class FSFTestLog_System
  {
    public string UniqueId;
    public byte IsHost;
    public string PlayerName;
    public int PlayerID;
    public string OS;
    public string Memory;
    public string CPU;
    public string GPU;
    public string Software;
    public int ScaleLevel;
  }

}

public class USFGameEngine : UGameEngine
{
  public class FSectionDebugInfo
  {
    public string SectionName;
    public double SectionStartTime;
    public int TabCount;
  }

  public class FDFUCrcInfo
  {
    public string Filename;
    public string Size;
  }

  public FPointer VfTable_FCallbackEventDevice;
  public string OggMusicFolder;
  public string PLAYMAP_OPTION;
  public string PCState_OPTION;
  public string INTERLUDE_OPTION;
  public string ViewTargetPawnPID_OPTION;
  public bool bUsePacketEncryption;
  public bool bCapturingVideo;
  public bool bTwitchTVBroadcast;
  public bool bIsLobbyTravel;
  public bool bUseOldMeshBuilder;
  public bool bPauseActors;
  public bool bLoadingToLobby;
  public bool bEnableIndependentMapLoading;
  public bool IsUsePackageVerification;
  public bool bUseDefaultUnitItems;
  public FLinearColor OverlayColorWhenDisconnected;
  public List<FSectionDebugInfo> arrSectionDebug;
  public float DeltaTime;
  public float DedicatedServerGarbageCollectionTime;
  public float DedicatedServerRaiseReadyEventPeriod;
  public float LastDedicatedServerGarbageCollectionTime;
  public float LastDedicatedServerRaiseReadyEventTime;
  public float MaxControlMessageDelay;
  public float PassedControlMessageDelay;
  public byte LastControlMessage;
  public List<UMICforSFCubeMap> arrMICForSFCubeMap;
  public List<UMITVforSFCubeMap> arrMITVForSFCubeMap;
  public FName SubDisplayLevelName;
  public List<string> AllowSubLanguage;
  public List<string> ValidLanguages;
  public string VerificationFileName;
  public int VerificationSize;
  public string GameUniqueKey;
  public int DediGameModeID;
  public int DediMapID;
  public int GameUniqueKeyByte;
  public string MapValue;
  public List<FDFUCrcInfo> DFUCrcInfoArray;
}

public class USFPhysicalMaterialProperty : UPhysicalMaterialPropertyBase
{
  public class FPhysicalSoundGroup
  {
    public FName GroupName;
    public USoundCue SoundCue;
  }

  public class FsResLink
  {
    public EPHYRESLINKTypes Linked_ID;
    public USoundCue FootStepSound;
    public USoundCue FootStepSoundDash;
    public USoundCue LandSound;
    public UParticleSystem FootStepParticle;
  }

  public class FMaterialImpactEffect
  {
    public FName EffectType;
    public USoundCue Sound;
    public List<UMaterialInterface> DecalMaterials;
    public List<UMaterialInterface> OutDecalMaterials;
    public float DurationOfDecal;
    public FName DecalDissolveParamName;
    public float DecalWidth;
    public float DecalHeight;
    public UParticleSystem ParticleTemplate;
    public UParticleSystem OutParticleTemplate;
    public UParticleSystem LensFXParticleTemplate;
    public bool bNotUseRotateDecal;
    public bool bAllowViewRotationDecal;
    public bool bPreventOutParticle;
  }

  public EPenetrateType PenetrateType;
  public FName MaterialType;
  public USoundCue FootStepSound;
  public USoundCue FootStepSoundDash;
  public USoundCue LandSound;
  public UParticleSystem FootStepParticle;
  public bool bBlockSight;
  public bool bBreakableGlassForProjectile;
  public bool bDeepWater;
  public bool bLightProvide;
  public bool bSliceMesh;
  public bool bSliceHollowMesh;
  public List<FMaterialImpactEffect> ImpactEffects;
  public float ReducePower;
  public FColor LightColor;
  public float LightRadius;
  public float LightBrightness;
  public float LightFallOffExponent;
  public int SupportedScaleLevel;
  public float ElasticModulusForProjectile;
  public float FrictionForProjectile;
  public float bAllowDecalDrawDistance;
  public List<FPhysicalSoundGroup> PhysicalSounds;
  public List<FsResLink> OtherFootStepResource;
  public float SliceUVScale;
  public UMaterialInterface SliceMaterial;
}

public class ASFGameExplosionActor : AGameExplosionActor
{
  public FVector[] DecalTraceDirections = new FVector[6];
  public FVector GoDirection;
  public UParticleSystemComponent ExplosionPSC;
  public List<FName> IgnoreDamageBlockActors;
  public FScriptDelegate __HurtRadiusExtraEffectTo__Delegate;
}

public class ASFGameExplosionActor_Color : ASFGameExplosionActor
{
}

public class ASFGameExplosionActor_Spawnable : ASFGameExplosionActor
{
  public UGameExplosion RepExplosionTemplate;
}

public class USFGameExplosionArtifire : USFGameExplosion
{
  public UParticleSystem ArtilleryPS;
  public int ArtilleryCounter;
  public float ArtilleryDelay;
  public float ArtilleryRandomDistance;
}

public class ASFGameExplosionArtifireActor : ASFGameExplosionActor_Spawnable
{
  public List<UParticleSystemComponent> ArtilleryPSC;
  public FVector ArtilleryRandomLocation;
  public USFGameExplosionArtifire ExplosionArtifireTemplate;
}

public class USFGameExplosionIncendiary : USFGameExplosion
{
  public float InnerDamage;
  public float OuterDamage;
  public float InnerDamageRadius;
  public float OuterDamageRadius;
  public float ParticleDensity;
  public float HurtDuration;
}

public class ASFGameExplosionIncendiaryActor : ASFGameExplosionActor_Spawnable
{
  public USFGameExplosionIncendiary IncendExplosionTemplate;
  public FVector AdjustExploLocation;
}

public class USFGameExplosionOutline : USFGameExplosion
{
  public UClass PawnClass;
  public ETeam TargetTeam;
  public int OutLineColorIndex;
  public float OutLineIntense;
  public float OutLineCullDistance;
  public float OutLineOverlapDistance;
  public float OutlineWidth;
  public float OutlineDuration;
}

public class ASFGameExplosionOutlineActor : ASFGameExplosionActor_Spawnable
{
  public USFGameExplosionOutline OutlineTemplate;
}

public class USFGameExplosionShockWave : USFGameExplosion
{
}

public class ASFGameExplosionShockWaveActor : ASFGameExplosionActor_Spawnable
{
  public class FCandidateEnemyInfo
  {
    public ASFPawn_AI Target;
    public float Distance;
  }

  public float EffectiveVelocity;
  public List<FCandidateEnemyInfo> CandidateEnemyList;
  public float ElapsedTime;
}

public class ASFGameExplosionShockWaveActorByKim : ASFGameExplosionActor_Spawnable
{
  public class FCandidateEnemyInfo
  {
    public ASFPawn_AI Target;
    public float Distance;
  }

  public float EffectiveVelocity;
  public List<FCandidateEnemyInfo> CandidateEnemyList;
  public float ElapsedTime;
  public int Team;
}

public class USFGameItem : UObject
{
  public class FSFItemData
  {
    public string ItemName;
    public int ItemId;
    public string ItemCode;
    public string ItemClassName;
    public string CamoClassName;
    public string ItemImgName;
    public string ItemRegDate;
    public string ItemUseType;
    public int ItemUseTime;
    public bool IsDefaultUseDay;
    public string IsResell;
    public string EquipClass;
    public int buy_limit;
    public int SP_Price;
    public int TP_Price;
    public int Cash_Price;
    public bool IsCooking;
    public bool IsSelling;
    public bool IsNotDropItem;
    public string SellType;
    public string AddSPType;
    public int AddSP;
    public int ExchangeTP;
    public string IsTestItem;
    public int ResellPrice;
    public int UseLimitRank;
    public string SupplyCode;
    public string Groups;
    public string merge_type;
    public string Tag;
    public bool IsCustomizeItem;
    public int discount_rate;
    public string sell_startdate;
    public string sell_enddate;
    public string Event;
  }

  public class FSFItemDataNew
  {
    public int ItemId;
    public int Price;
    public string SellType;
    public int discount_rate;
    public string sell_startdate;
    public string sell_enddate;
    public string Event;
    public int BuyableCount;
    public bool IsSelling;
  }

  public class FSItemCodeToID
  {
    public string ItemCode;
    public List<int> ItemIndexArray;
  }

  public class FSSupplyCodeToID
  {
    public string SupplyCode;
    public List<int> ItemIndexArray;
  }

  public class FSFirstBuySaleItem
  {
    public string ItemCode;
    public int ItemId;
    public int Original_Price;
    public bool bEnable;
  }

  public class FSRecvItemInfo
  {
    public int ItemId;
    public int ItemCount;
    public string ItemCode;
    public ulong ItemSN;
    public ulong ItemNSN;
    public string EndDate;
    public int Durability;
    public int MaxDurability;
    public List<string> ParsePropertys;
    public USFGameItem.FSFItemData ItemData;
  }

  public class FSRecvItemShortInfo
  {
    public int ItemId;
    public ulong ItemSN;
    public string ItemCode;
  }

  public class FSRecvPartsItemInfo
  {
    public ulong ParentsSN;
    public ulong PartsSN;
    public int partsID;
    public string Propertys;
  }

  public List<FSFItemData> GameItemInfo;
  public FScriptDelegate __OnItemClassLoaded__Delegate;
}

public class USFGameMessage : UObject
{
  public UClass AnnouncerMsgClass;
  public UClass KillDeathMsgClass;
}

public class ASFGameObjective : AObjective
{
}

public class ASFGameParticleEventManager : AGameParticleEventManager
{
}

public class ASFGamePlayerStart_Area : ASFGamePlayerStart
{
  public int AreaIndex;
}

public class ASFGamePlayerStart_DM : ASFGamePlayerStart
{
}

public class ASFGamePlayerStart_Mission : ASFGamePlayerStart
{
}

public class ASFGamePlayerStart_Mission_vs16 : ASFGamePlayerStart
{
}

public class ASFGamePlayerStart_SH : ASFGamePlayerStart
{
  public ESFStrongHoldArea StartingAreaIndex;
}

public class ASFGamePlayerStart_TDM : ASFGamePlayerStart
{
}

public class ASFGamePlayerStart_TDM_vs16 : ASFGamePlayerStart
{
}

public class ASFGamePlayerStart_Tut : ASFGamePlayerStart
{
}

public class ASFGamePlayerStartMovable_Area : ASFGamePlayerStart_Area
{
}

public class ASFGamePlayerStartMovable_SH : ASFGamePlayerStart_SH
{
}

public class USFGameplayEventsWriter : UGameplayEventsWriter
{
  public string UploadPath;
  public bool bUploadFile;
  public bool bActiveEventsWriter;
}

public class USFGameRuleBase : UObject
{
  public float RuleTime;
  public bool bIsRespawnable;
  public float MinRespawnDelayForPlayer;
}

public class USFGameRuleBlasting : USFGameRuleBase
{
}

public class USFGameStateMessage : USFLocalMessage
{
}

public class USFGameViewportClient : UGameViewportClient
{
  public class FLoadingTextureStruct
  {
    public string MapName;
    public string LoadingTextureString;
    public EBGTEXType DrawType;
  }

  public class FLobbyLoadingTexture
  {
    public UTexture2D LoadingTexture;
    public EBGTEXType BGDrawTypeNow;
  }

  public class FLoadingClanRanking
  {
    public string ClanName;
    public List<UTexture2D> ClanMarkTextures;
    public List<string> ClanMarkTextureNames;
  }

  public bool bSendGameExitMessage;
  public bool bEnableClanRankingWithLoading;
  public float DelayTimeToSendGameExitMessage;
  public FLoadingTextureStruct DefaultBackgroundTexture;
  public List<FLoadingTextureStruct> LoadingTextureArray;
  public List<FLoadingTextureStruct> LobbyLoadingTextureConfigArray;
  public FColor LoadingBGColor;
  public List<FLobbyLoadingTexture> LobbyLoadingTextureArray;
  public string LoadingTipMessage;
  public string LoadingMapLocalizedMapName;
  public string LoadingInternationalMapName;
  public FLoadingTextureStruct LoadingBackPannelTextureName;
  public UTexture2D LoadingBackPannelTexture;
  public UTexture2D LoadingBackGroundTexture;
  public int LoadingDotCount;
  public EBGTEXType BGDrawTypeNow;
  public float FadeTarget;
  public float FadeAmount;
  public FVector2D FadeAlpha;
  public float FadeTime;
  public float FadeTimeRemaining;
  public float FadeDelay;
  public float lastTickTime;
  public float LastDisconnectedTime;
  public List<FLoadingClanRanking> LoadingClanRankingArray;
  public int MyClanRankingIndex;
  public string ClanRankingTitleText;
  public int ClanRankingCount;
  public FColor MyClanColor;
  public USFOnlineSubsystemPC OnlineSubPC;
}

public class ASFGameWarriorAIStart : ASFGamePlayerStart
{
  public List<EAITypes> SpawnAITypes;
  public int SpawnGroup;
  public float StrengthenRate;
  public float StrengthenRateMax;
  public bool bFlexibleScale;
  public bool bIgnoreBase;
  public bool bAllowRespawnWhenAllChildPawnDead;
  public FName SquadName;
  public List<APawn> SpawnedPawns;
}

public class USFGashaItem : UObject
{
  public class FSFGashaItemData
  {
    public int ItemIndex;
    public string Description;
    public int GashaStep;
    public int SelectionNumber;
    public int ItemId;
    public string SupplyCode;
  }

  public List<FSFGashaItemData> GashaItemInfo;
}

public class USFGFxClickWidget_NumericOnly : UGFxClikWidget
{
  public string LastInputedText;
  public string strNumeric;
  public string strAlphabet;
  public bool bEnableAlphabet;
}

public class USFGFxUIView : UGFxObject
{
  public class FSEquipAttrib
  {
    public string Tag;
    public string HtmlColor;
    public string Contents;
    public bool bNeedAbs;
    public bool bNeedMinus;
  }

  public class FSClickSoundWidget
  {
    public FName WidgetName;
    public FName EventName;
  }

  public class FSGFxGameDataProvider
  {
    public string BindName;
    public UGFxObject Scope;
    public UGFxObject Rows;
    public List<UGFxObject> Items;
  }

  public class FSUIRenderToTextureInfo
  {
    public string WidgetName;
    public string Source;
  }

  public class FSDisplayItem
  {
    public int ItemId;
    public ulong ItemSN;
    public int ItemTag;
    public int ItemType;
    public string ItemCode;
    public USFGameItem.FSFItemData ItemData;
    public int Selected;
    public int ItemCount;
  }

  public class FWidgetEventListenerInfo
  {
    public FName ActionType;
    public FScriptDelegate DelegateHandler;
  }

  public class FClikWidgetInfo
  {
    public FName WidgetName;
    public int Type;
    public bool bIsGFxObj;
    public List<USFGFxUIView.FWidgetEventListenerInfo> DelegateList;
    public UGFxClikWidget MovieClip;
    public UGFxObject GfxObj;
  }

  public int WidgetIndex;
  public FName ViewName;
  public USFGFxLobby LobbyManager;
  public USFItemManager ItemManager;
  public USFOnlineSubsystemPC OnlineSub;
  public string TextBoxInputOld;
  public UGFxObject FocusedObject;
  public List<UGFxObject> FocusLinks;
  public int ActivatedTextInputBoxIndex;
  public UGFxClikWidget btnCashCharge;
  public int DefaultViewSystemMsgTime;
  public string PressOKToCashRefresh;
  public int InputNameValidCheckTime;
  public string LastFilteredName;
  public UGFxObject ChatTextMC;
  public UGFxClikWidget ChatInputText;
  public UGFxClikWidget ChatTypeCB;
  public UGFxClikWidget ChatTypeModeBtn;
  public UGFxClikWidget ChatTypeMinimumBtn;
  public EChatSendType ChatSendType;
  public EChatComboType ChatComboType;
  public ELobbyDialog UseDialogIndex;
  public List<EChatType> ChatNotVisibleList;
  public bool bExpandChatInput;
  public bool bIsChatMinimum;
  public bool bIsVisible;
  public bool bEnableCashChargeBtn;
  public bool bListenExternalInterface;
  public bool bClickChangeBtn;
  public int MaxIMECompositonTextLength;
  public string DatastoreBindingName;
  public List<bool> ChatComboTypeArray;
  public List<string> ChatComboNameArray;
  public List<string> ChatMinimumBtnNameArray;
  public List<FSEquipAttrib> EquipUIAttrib;
  public List<string> ItemInfoData_WeaponArray;
  public List<string> ItemInfoData_EquipArray;
  public List<FSClickSoundWidget> PlayClickSoundWidgets;
  public USFGFxUIView ParentView;
  public USFGFxUIView ChildView;
  public int PrevViewIndex;
  public int NextViewIndex;
  public List<int> WeaponMCItemArray;
  public List<int> CharacterMCItemArray;
  public List<USFGFxLobbyPart> LobbyPartArray;
  public List<UClass> DefaultLobbyPartArray;
  public int nTabPrimary;
  public int nTabSecondary;
  public int ForcedMainTabIndex;
  public int ForcedSubTabIndex;
  public UGFxClikWidget MainTabBtnMC;
  public List<FSGFxGameDataProvider> BindedGameDataProviders;
  public string FailedRank;
  public int FailedRankLimit;
  public List<FSUIRenderToTextureInfo> RenderToTextureSettings;
  public FScriptDelegate __OnChatBoxOutfocusDelegate__Delegate;
  public FScriptDelegate __OnClikWidgetEnvent__Delegate;
}

public class USFGFxDialog : USFGFxUIView
{
  public UGFxClikWidget btnOk;
  public UGFxClikWidget btnCancel;
  public UGFxClikWidget btnClose;
  public UGFxClikWidget btnOKCenter;
  public bool bPreview;
  public bool bIgnoreKeyInput;
  public bool bExitDialog;
  public bool bUseEnterToChatting;
  public bool bUseEnterKey;
  public float PreTickTime;
  public string DlgTitleText;
  public string DlgImageFileName;
  public string strOrigBtnOK;
  public string strOrigBtnCancel;
  public FScriptDelegate __OnOkProcesses__Delegate;
  public FScriptDelegate __OnCloseProcess__Delegate;
}

public class USFGFxDialog_Repair : USFGFxDialog
{
  public class FERapairDialogBtnInfo
  {
    public FName WidgetName;
    public ERapairDialog_BtnType Type;
    public FScriptDelegate DelegateHandler;
    public UGFxClikWidget MovieClip;
  }

  public FERapairDialogBtnInfo[] ERapairDialogBtnData = new FERapairDialogBtnInfo[4];
  public FScriptDelegate __OnBtn__Delegate;
  public FScriptDelegate __CouponOKButtonPress__Delegate;
}

public class USFGFxDialog_AllItemRepair : USFGFxDialog_Repair
{
  public class FsRepairItemList
  {
    public string WeaponName;
    public string WeaponImg;
    public int RepairGauge;
    public int NeedSp;
    public ulong ItemSN;
    public bool bSelected;
  }

  public UGFxClikWidget ItemObjList;
  public UGFxClikWidget btnCoupon;
  public List<FsRepairItemList> RepairItemLists;
  public int ReservedCouponCount;
  public int ReservedCouponID;
  public int NeedCoupon;
  public int UsedCoupon;
  public List<int> SelectedIndex;
  public string RepairMsg;
  public FScriptDelegate __OnClickItemSelectDelegate__Delegate;
}

public class USFGFxDialog_BaseAreaSelect : USFGFxDialog
{
  public string TitleText;
  public UGFxClikWidget GFx_ListArea;
  public UGFxClikWidget GFx_BtnAreaClose;
  public EClanAreaDlgType ClanAreaDlgType;
  public FScriptDelegate __OnClickCloseAreaSelectDlgDelegate__Delegate;
  public FScriptDelegate __OnSubmitAreaSelectDelegate__Delegate;
}

public class USFGFxDialog_BeginnerComplete : USFGFxDialog
{
  public ASFHUD myHUD;
}

public class USFGFxDialog_WebBrowser : USFGFxDialog
{
  public string TargetURL;
  public string BrowserTitle;
  public int BrowserWidth;
  public int BrowserHeight;
  public bool bWebBrowserInitialized;
}

public class USFGFxDialog_BillingToken : USFGFxDialog_WebBrowser
{
}

public class USFGFxDialog_BPEventList : USFGFxDialog
{
  public class FSCategorySet
  {
    public int Code;
    public UClass TabClass;
  }

  public class FSCategoryLocalized
  {
    public int Code;
    public string TabString;
  }

  public List<FSCategoryLocalized> CategoryString;
  public List<FSCategorySet> PreCategorySet;
  public List<string> TabCategoryValue;
  public UGFxClikWidget btnMainTab;
}

public class USFGFxDialog_Buy : USFGFxDialog
{
  public class FSRegulationURL
  {
    public string ServiceCode;
    public string URL;
  }

  public class FSItemLIst
  {
    public List<USFGameItem.FSFItemData> AllItemArray;
    public List<USFGameItem.FSFItemData> SPItemArray;
    public List<USFGameItem.FSFItemData> CASHItemArray;
    public List<USFGameItem.FSFItemData> TPItemArray;
    public List<USFGameItem.FSFItemData> LPItemArray;
    public string UseRank;
    public bool bLocked;
    public bool Checked;
    public int SelectedIndex;
    public float RestDays;
    public int BGColorIdx;
    public string logType;
  }

  public string PermanentSellInfo;
  public string PermanentUseSellInfo;
  public string PermanentBuySellInfo;
  public string CouponSellInfo;
  public string PayMoneyMessage;
  public string HaveMoneyMessage;
  public string AfterPayMoneyMessage;
  public string BuyNoticeWithCASH;
  public string BuyNoticeWithSP;
  public string BuyNoticeWithNoReturn;
  public string NoticeTpExchange;
  public string BuyNoticeWithFeverLPItem;
  public string BuyableCountFailedMessage;
  public UGFxClikWidget btnRegulation;
  public string strRegulationURL;
  public List<string> DisableGiftUsedCashArray;
  public List<string> VipBonusType;
  public List<FSRegulationURL> ChannelingRegulationArray;
  public FScriptDelegate __BuyProcessDelegate__Delegate;
}

public class USFGFxDialog_BuyAll : USFGFxDialog_Buy
{
  public UGFxClikWidget ItemObjList;
  public string NotyRestDaysSrc;
  public string Noty1RestDaysSrc;
  public int NeedSp;
  public int NeedCASH;
  public int NeedTP;
  public int NeedLP;
  public List<FSItemLIst> BuyItemList;
  public FScriptDelegate __OnItemPriceSelectedDelegate__Delegate;
  public FScriptDelegate __OnItemCheckDelegate__Delegate;
}

public class USFGFxDialog_BuyOk : USFGFxDialog
{
  public string strNoticeThankYou;
  public string strNoticeToConfirm;
  public string strNoticeToConfirmModeItem;
  public string strNoticeToUse;
  public string strNoticeToEquip;
  public string strOKUse;
  public string strOKEquip;
  public string strCancelUse;
  public string strCancelEquip;
  public FScriptDelegate __OnBuyAfterDelegate__Delegate;
}

public class USFGFxDialog_BuyOne : USFGFxDialog_Buy
{
  public UGFxClikWidget ComboBoxMC;
  public UGFxClikWidget CouponListBoxMC;
  public UGFxClikWidget FriendListMC;
  public UGFxClikWidget TabBarMC;
  public UGFxClikWidget CodeNameEditBoxMC;
  public UGFxClikWidget CodeNameSearchButtonMC;
  public UGFxClikWidget GiftMessageTextBoxMC;
  public int CurrentMoney;
  public int RestMoney;
  public int SelectedItemID;
  public int SelectedItemPrice;
  public USFGameItem.FSFItemData SelectedItemData;
  public int SelectedPaymentType;
  public List<string> PaymentTypeArray;
  public bool bBuyCanceled;
  public bool IsGiftDialog;
  public bool IsFocusCodeNameEdit;
  public FSItemLIst BuyItem;
  public string CouponSalePrecentText;
  public string CouponRemainDateText;
  public string NotUseCouponText;
  public string GiftMessageBoxDefaultText;
  public string[] GiftItemMessage = new string[3];
  public string InvalidInputCodeName;
  public string NoSearchCodeName;
  public string BtnGiftText;
  public string BuyBtnText;
  public string[] GiftConfirmMessage = new string[4];
  public string GiftItemAllUnit;
  public int ApplyCouponIndex;
  public string InputedCodename;
  public string GiftReceiverCodeName;
  public int GiftReceiverUSN;
  public int SelectTabNumber;
  public List<USFTypes.FsBuddy> DisplayBuddys;
  public int GfitMessageLimitByte;
  public List<string> strGiftTab;
  public FScriptDelegate __OnPaymentTypeSelectedDelegate__Delegate;
  public FScriptDelegate __OnItemDurationSelectedDelegate__Delegate;
  public FScriptDelegate __OnCouponTypeSelectedDelegate__Delegate;
}

public class USFGFxDialog_CashCharge : USFGFxDialog
{
}

public class USFGFxDialog_CashChargeConfirm : USFGFxDialog
{
  public bool IsCashCharge;
}

public class USFUIDataStoreBase : UUIDataStore_Remote
{
  public USFOnlineSubsystemPC OnlineSub;
  public USFItemManager ItemManager;
  public FScriptDelegate __OnPacketRecv__Delegate;
}

public class USFUIDataStore_GashaList : USFUIDataStoreBase
{
  public class FsGashaModeGraphInfo
  {
    public EGashaGraphType Type;
    public string SupplyCode;
    public string SelectSceneType;
    public string SelectIconType;
    public string OrgelSceneType;
  }

  public class FRewardCapsuleInfo
  {
    public int Id;
    public string SupplyCode;
    public int CurGachaBonusGauge;
    public int MaxGachaBonusGauge;
  }

  public class FRewardCapsuleCountInfo
  {
    public string SupplyCode;
    public int Count;
  }

  public class FRewardLogInfo
  {
    public string SupplyCode;
    public string Today;
    public int TodayAllCount;
    public int TodayProbabilityObtain;
    public int TodayRareCount;
    public string Yesterday;
    public int YesterdayAllCount;
    public int YesterdayProbabilityObtain;
    public int YesterdayRareCount;
    public int NowItemCount;
    public int NowUseItemCount;
    public int MaxProbability;
    public string ItemTag;
    public int TagType;
  }

  public class FGetRareUserInfo
  {
    public string CodeName;
    public string Regdate;
    public int ItemId;
  }

  public class FGashaListInfo
  {
    public int reward;
    public List<USFGameItem.FSFItemData> ItemDataArray;
    public List<string> SupplyCodeArray;
    public List<int> DisplayRankArray;
    public int RewardLogInfoIndex;
    public string SupplyCode;
    public string reward_type;
    public int GashaCouponCount;
    public List<string> ToolTipList;
    public bool bIsAllInOne;
    public bool bIsPVE;
    public EGashaGraphType GashaType;
    public int TagType;
    public int DisplayRank;
    public List<USFUIDataStore_GashaList.FGetRareUserInfo> GetRareUserArray;
    public float DiscountRatio;
    public bool bIsShow;
  }

  public class FSPBoomGahsaInfo
  {
    public int reward;
    public string ItemType;
    public int ImageType;
    public string ItemName;
    public string ItemImgName;
    public string Event;
    public string MoneyIconType;
    public List<string> ToolTipList;
  }

  public class FToolTipRewardInfo
  {
    public string SupplyCode;
    public List<USFUIDataStore_GashaList.FRewardInfo> RewardItemArray;
  }

  public class FsGachaRollUser
  {
    public int ItemId;
    public string UserName;
    public string ItemName;
  }

  public class FsGashaModeGraphMessage
  {
    public EGashaGraphType Type;
    public string Title;
    public string Content;
  }

  public class FsAllInOneTooltipInfo
  {
    public string SupplyCode;
    public string ToolTip;
  }

  public class FRewardInfo
  {
    public string supply_code;
    public string reward_type;
    public int reward;
    public int DisplayRank;
    public string RareType;
    public bool IsRare;
    public int Percenct;
    public int GroupIndex;
    public bool IsGachaBonusGauge;
    public bool IsShow;
  }

  public int SelectGashaIndex;
  public int SelectGashaID;
  public int MaxGashaCount;
  public int RemaintGashaCount;
  public int RewardCapsuleListCount;
  public int RewardLogListCount;
  public int GashaRewardListCount;
  public int AllInoneGashaGroupCount;
  public int RewardPercentMAX;
  public int RecvedPVECapsuleCount;
  public string PVETYPE;
  public List<FRewardInfo> RecvRewardListArray;
  public List<FToolTipRewardInfo> ToolTipRewardArray;
  public List<FRewardLogInfo> RewardLogArray;
  public List<FRewardLogInfo> OldRewardLogArray;
  public List<FGashaListInfo> ViewGashaListArray;
  public List<FRewardCapsuleInfo> RewardCapsuleArray;
  public List<FRewardCapsuleInfo> AllInOneGashaGroupArray;
  public List<FRewardCapsuleCountInfo> RewardCapsuleCountArray;
  public float fGahsaInfoSendTime;
  public int DefaultProbability;
  public bool bShowProbability;
  public bool bIsSortTagType;
  public bool bShowGachaTag;
  public bool bSPGashaNeedRank;
  public bool IsGashaIshowOption;
  public bool IsGashaInvenActivated;
  public bool bChangeGachaRollList;
  public bool bGachaListSendPacket;
  public bool bSetGachaRollList;
  public int AllInOneListRollingTime;
  public int SPGashaUsedRank;
  public int AllInOneItemNameCount;
  public List<FsGashaModeGraphInfo> GashaModeGraphArray;
  public List<FsGashaModeGraphMessage> GashaModeGraphMsgArray;
  public int AllInoneToolTipLineViewItemNameCount;
  public string strTodayGashaInfoMessage;
  public string strSPGashaNeedRankMsg;
  public string DeleteAllInOneItemNameText;
  public string CouponNameError;
  public List<FsAllInOneTooltipInfo> AllInOneItemGashaToolTipList;
  public List<FSPBoomGahsaInfo> SPBoomGashaList;
  public List<FsGachaRollUser> GachaRollUserList;
  public List<int> GashaRareWeaponItems;
  public int GachaItemCount;
  public int GashaRewardUserCount;
  public string LastBuyGachaSupplyCode;
  public FScriptDelegate __GahsaListSortByDisplayRankDelegate__Delegate;
  public FScriptDelegate __ViewGashaListSortByTagTypeDelegate__Delegate;
  public FScriptDelegate __ViewGashaListSortByDisplayRankDelegate__Delegate;
}

public class USFGFxDialog_RewardItem : USFGFxDialog
{
  public List<string> RewardItemListMessage;
  public List<USFTypes.FSRecvReward> RewardItemArray;
  public List<USFTypes.FSRecvReward> DisplayRewardItemArray;
  public List<int> PromotionIDArray;
  public ERewardMessage RewardMessageType;
}

public class USFGFxDialog_ChallengeComplete : USFGFxDialog_RewardItem
{
  public FName CurChallengeSupplyCode;
  public int CurChallengeTask;
  public string RewardReceivedMessage;
  public string RewardUnlockMessage;
}

public class USFGFxDialog_FuncUseDefault : USFGFxDialog
{
  public int UseItemId;
  public ulong GiftNSN;
  public UClass ItemClass;
  public string strUseFailDefault;
  public List<string> strUseFail;
  public string strUseGiftItemMessage;
  public string strUseGiftSPMessage;
  public string strUseGiftTPMessage;
  public string strConfirmMessage;
  public string strUseItemReConfirmMessage;
  public string WebCouponURL;
}

public class USFGFxDialog_ChangeClassMark : USFGFxDialog_FuncUseDefault
{
  public UGFxClikWidget DisguiseRankList;
  public string SelectDisguiseRankIndex;
  public bool IsChangeDisguiseRank;
}

public class USFGFxDialog_ChangeTP : USFGFxDialog
{
  public class FExchangeInfo
  {
    public int TargetAmount;
    public string TargetCurrency;
    public int SourceAmount;
    public string SourceCurrency;
  }

  public List<int> ChangeTPItemArray;
  public int nSelectedIndex;
  public string strChangeTPNoticeMessage;
  public string ExchangeConfirmMessage;
  public List<FExchangeInfo> ExchangeList;
  public bool bUseExchangeList;
  public int SelectedItemID;
  public FScriptDelegate __OnChangeTPSelectedDelegate__Delegate;
}

public class USFGFxDialog_ChoicePackage : USFGFxDialog_FuncUseDefault
{
  public UGFxClikWidget[] ChoiceItemList = new UGFxClikWidget[2];
  public string DefaultTopText;
  public int DisplayCount;
  public int ChoiceItemID;
  public List<int> SubItemArray;
}

public class USFGFxDialog_Clan : USFGFxDialog
{
  public class FSDropDownMenu
  {
    public UGFxClikWidget DropDownMenuWidget;
    public string DropDownWidgetName;
    public int SelectedIndex;
    public string Tag;
    public int DefaultSelectedIndex;
  }

  public UGFxClikWidget ModeList;
  public UGFxClikWidget MapList;
  public UGFxClikWidget AreaBtn;
  public UGFxClikWidget ClanMainAreaBtn;
  public UGFxClikWidget ClanSubAreaBtn;
  public List<USFTypes.FSClanModeMap> ModeData;
  public List<USFTypes.FSClanModeMap> MapData;
  public int SelectedModeIndex;
  public int SelectedMapIndex;
  public List<FSDropDownMenu> ClanDropDownMenuWidget;
  public List<string> ClanTagStart;
  public List<string> ClanTagEnd;
  public List<string> OptionDataValue;
  public List<string> OptionDataTag;
}

public class USFGFxDialog_ClanAreaSelect : USFGFxDialog_BaseAreaSelect
{
}

public class USFGFxDialog_ClanJoin : USFGFxDialog
{
  public UGFxClikWidget[] InputBoxs = new UGFxClikWidget[4];
  public UGFxObject[] InputFields = new UGFxObject[4];
  public EClanJoinDlgWidgetType FocusInputText;
  public bool bIsClanJoinOK;
  public string CSN;
  public string LastInputText;
  public string ClanJoinDlg_Text;
  public List<string> ClanJoinQuestion;
  public List<USFTypes.FSInputTextFilter> ClanJoinInputTextLimits;
  public string SelectClanRecommendNick;
}

public class USFGFxDialog_ClanMake : USFGFxDialog_Clan
{
  public class FSClanMakeInput
  {
    public UGFxClikWidget InputInfos;
    public UGFxClikWidget InputBoxs;
    public UGFxObject InputFields;
    public string LastFilteredName;
    public string InputWidgetName;
    public int bIsClanMakeTerms;
  }

  public class FSClanTextInputStateMsg
  {
    public string[] msg = new string[5];
    public bool bIsVisible;
  }

  public FSClanMakeInput[] ClanMakeInput = new FSClanMakeInput[3];
  public int SelectTextInputType;
  public UGFxClikWidget ClanMakeWndWidget;
  public List<USFTypes.FSInputTextFilter> InputTextLimits;
  public List<FSClanTextInputStateMsg> InputTextStateMsgs;
  public string ClanMakeChkNotice;
  public List<string> DefaultInputFieldText;
  public string ClanInputAttachment;
  public string ClanMakeNoticeMsg;
  public string ClanMakeAlert;
  public bool bUpdateClanDialog;
}

public class USFGFxDialog_ClanMakeLimit : USFGFxDialog
{
  public string PopupTitle;
  public string RankLimitMsg;
}

public class USFGFxDialog_ClanMarkAnimation : USFGFxDialog_FuncUseDefault
{
  public List<string> ClanAniImg;
  public UGFxClikWidget EffectList;
  public string ClanAniCode;
  public string DefaultAniCode;
}

public class USFGFxDialog_ClanSearch : USFGFxDialog_Clan
{
  public UGFxClikWidget ClanSearchWndWidget;
  public UGFxClikWidget ResetBtn;
  public UGFxClikWidget ClanSearchPopupTitleWidget;
  public UGFxClikWidget ClanSearchInputWidget;
  public string ClanSearchPopupTitle;
  public string SearchBtnText;
  public string NeedSearchOptionMessage;
}

public class USFGFxDialog_ClanWideAreaSelect : USFGFxDialog_BaseAreaSelect
{
  public UGFxClikWidget GFx_ListSubArea;
}

public class USFGFxDialog_CommunityNews : USFGFxDialog
{
  public string NewsTitle;
  public string DefaultCommunityMessage;
  public List<USFTypes.FSCommunityEventMessage> CommunityEventMessageArray;
}

public class USFGFxDialog_CreatedCharacter : USFGFxDialog
{
  public class FSWelcomeItem
  {
    public string RewardType;
    public int reward;
    public int Rare;
  }

  public string TitleMessage;
  public string MainMessage1;
  public string MainMessage2;
  public UGFxClikWidget[] ItemListMcs = new UGFxClikWidget[2];
  public int nNowPage;
  public int DisplayWidgetIndex;
  public int DisplayCount;
  public List<FSWelcomeItem> WelcomeItemArray;
}

public class USFGFxDialog_GameModeBase : USFGFxDialog
{
  public UGFxClikWidget ModeListMC;
  public int SelectedModeIndex;
  public List<int> GameModeIDArray;
  public UGFxObject _global;
  public int WeaponTypeMode;
  public int PickUpWeapon;
  public string CustomModeName;
}

public class USFGFxDialog_CreateRoom : USFGFxDialog_GameModeBase
{
  public UGFxClikWidget inputRoomTitle;
  public USFGFxClickWidget_NumericOnly inputPassword;
  public UGFxObject inputRoomText;
  public UGFxObject inputPasswordText;
  public UGFxClikWidget NewModeListMC;
  public UGFxClikWidget VIPModeListMC;
  public int SelectedNewModeIndex;
  public int SelectedVIPModeIndex;
  public List<int> NewGameModeIDArray;
  public List<int> RotationGameModeIDArray;
}

public class USFGFxDialog_CreateRoomEX : USFGFxDialog_GameModeBase
{
  public UGFxClikWidget inputRoomTitle;
  public USFGFxClickWidget_NumericOnly inputPassword;
  public UGFxObject inputRoomText;
  public UGFxObject inputPasswordText;
  public UGFxClikWidget NewModeListMC;
  public UGFxClikWidget VIPModeListMC;
  public UGFxClikWidget CustomModeApplyBtn;
  public UGFxClikWidget CustomModeCancelBtn;
  public int SelectedNewModeIndex;
  public int SelectedVIPModeIndex;
  public int PreWeaponTypeMode;
  public int PrePickUpWeapon;
  public List<int> NewGameModeIDArray;
  public List<int> RotationGameModeIDArray;
  public List<string> DisableCustomModeApplyBtnModeName;
  public FScriptDelegate __SelectedModeUI__Delegate;
  public FScriptDelegate __DoubleClickSelectedModeUI__Delegate;
  public FScriptDelegate __CustomModeBtn__Delegate;
  public FScriptDelegate __OnCustomCbOpen__Delegate;
  public FScriptDelegate __ModeOptionData__Delegate;
  public FScriptDelegate __PickUpWeaponOptionData__Delegate;
}

public class USFGFxDialog_CrossHair : USFGFxDialog_FuncUseDefault
{
  public UGFxClikWidget CrossHairList;
  public UGFxClikWidget CrossHairColorList;
  public List<string> CrossHairImage;
  public List<string> CrossHairColor;
  public bool bChangeCrossHair;
  public string SelectCrossHairIndex;
  public string SelectCrossHairColorIndex;
}

public class USFGFxDialog_Declare : USFGFxDialog
{
  public string SuccessDeclareMsg;
  public int DeclareType;
  public UGFxClikWidget MemberList;
  public List<int> DeclareUserList;
}

public class USFGFxDialog_EmblemDeck : USFGFxDialog
{
  public class FSEmblemTabData
  {
    public string Code;
    public List<EEmblemType> Types;
    public int FlashIndex;
  }

  public class FSEmblemTooltipData
  {
    public string Unavailable;
    public string Unused;
    public string Used;
  }

  public int Display_Row_Size;
  public int Default_Display_Rows;
  public UGFxObject _global;
  public List<USFTypes.FSEmblemInfo> EmblemInfoList;
  public List<FSEmblemTabData> EmblemTypeTabList;
  public string Msg_Need_PCRoom_Care_Service;
  public string Msg_Not_Completed_Challenge;
  public string Msg_Need_VIP_Grade;
  public string Msg_Invalid_Emblem;
  public string Msg_Invalid_Item;
  public List<FSEmblemTooltipData> EmblemTooltipList;
  public string Default_Msg_Unavailable_Spray_Emblem;
  public USFConditionManager ConditionMgr;
  public USFChallengeListCondition ChallengeListCondition;
  public string DataBindingName_Normal;
  public string DataBindingName_PCRoom;
  public string DataBindingName_Challenge;
  public string DataBindingName_Spray;
  public string DataBindingName_VIP;
  public List<USFTypes.FSEmblemInfo> EmblemList_Normal;
  public List<USFTypes.FSEmblemInfo> EmblemList_PCRoom;
  public List<USFTypes.FSEmblemInfo> EmblemList_Challenge;
  public List<USFTypes.FSEmblemInfo> EmblemList_Spray;
  public List<USFTypes.FSEmblemInfo> EmblemList_VIP;
  public string Selected_Emblem_ID;
  public EEmblemType Selected_Tab_ID;
  public EEmblemType InitalizeSelected_Tab_ID;
  public int LastBoughtItemID;
  public int SelectedItemID;
  public FScriptDelegate __OnChangedEmblemTabDelegate__Delegate;
  public FScriptDelegate __OnListItemDelegate__Delegate;
  public FScriptDelegate __EmblemSort__Delegate;
  public FScriptDelegate __EmblemSortWithCondition__Delegate;
}

public class USFGFxDialog_Error : USFGFxDialog
{
  public UGFxObject MsgTxt;
}

public class USFGFxDialog_EventList : USFGFxDialog
{
  public class FSCategorySet
  {
    public int Code;
    public UClass TabClass;
  }

  public class FSCategoryLocalized
  {
    public int Code;
    public string TabString;
  }

  public List<FSCategoryLocalized> CategoryString;
  public List<FSCategorySet> PreCategorySet;
  public List<string> TabCategoryValue;
  public UGFxClikWidget btnMainTab;
}

public class USFGFxDialog_ExitConfirm : USFGFxDialog
{
  public string DialogTitle;
  public string DialogCenterTitle;
  public ASFHUD myHUD;
}

public class USFGFxDialog_ExitInGame : USFGFxDialog
{
  public ASFHUD myHUD;
  public UGFxClikWidget ContinueButton;
  public UGFxClikWidget ExitButton;
  public UGFxClikWidget OptionButton;
  public UGFxClikWidget RetryButton;
  public UGFxClikWidget ReportButton;
  public UGFxClikWidget DeclareButton;
  public UGFxClikWidget TwitchTVButton;
  public bool bReportButton;
  public bool IsUseTwitchTV;
}

public class USFGFxDialog_ExtraReward : USFGFxDialog
{
  public int MAX_REWARD_CARD;
  public string ShareRewardResult;
  public float ExtraRewardChoiceDelay;
  public string RequestedSupplyCode;
  public List<USFTypes.FExtraRewardInfo> RewardItemList;
  public bool bCanClosedialog;
  public bool bAllowWidgetSound;
  public bool bViewActivated;
  public bool bNoticeRewardWhenChoosed;
  public bool bMiniGachaEnableFlag;
  public string CurrentRewardDataType;
  public int LastCountDown;
  public USoundCue Cue_ExtraRewardGain_SP;
  public USoundCue Cue_ExtraRewardGain_Item;
  public string CachedRealRewardName;
  public int SelectedCardIndex;
  public string MiniGachaTitle;
  public string MiniGachaButtonText;
  public string MiniGachaCountText;
  public UGFxClikWidget MiniGachaCancelBtn;
  public int MinusSP;
}

public class USFGFxDialog_FacebookFriendList : USFGFxDialog_WebBrowser
{
  public string FriendListDataBindingName;
  public List<USFTypes.FSFacebookUserInfo> FacebookFriendsList;
}

public class USFGFxDialog_Following : USFGFxDialog
{
}

public class USFGFxDialog_FullScrHelp : USFGFxDialog
{
  public float fAutoCloseTime;
}

public class USFGFxDialog_FuncChangeName : USFGFxDialog_FuncUseDefault
{
  public UGFxClikWidget TextNameLength;
  public string strChangeNameConfirmMessage;
}

public class USFGFxDialog_FuncChangeOneLetterName : USFGFxDialog_FuncChangeName
{
}

public class USFGFxDialog_FuncChangeSpecialName : USFGFxDialog_FuncChangeName
{
  public UGFxClikWidget SpecialCharListWidget;
  public bool bNewCodeNameChanged;
  public UGFxObject _gfxSelection;
  public List<string> SpecialCharSetList;
}

public class USFGFxDialog_FuncUseReset : USFGFxDialog_FuncUseDefault
{
}

public class USFGFxDialog_GameClose : USFGFxDialog
{
  public string GameEndContext;
  public string MainContext;
}

public class USFGFxDialog_GameCloseOfSelectGift : USFGFxDialog
{
  public class FsWelcomeTextType
  {
    public int Group;
    public string Icon;
    public string IconName;
    public string DisplayText;
  }

  public class FsItemGroup
  {
    public string SupplyCode;
    public int SupplyStep;
  }

  public class FsGiftItemList
  {
    public string Type;
    public int ItemId;
  }

  public List<FsWelcomeTextType> WelcomeText;
  public List<FsItemGroup> BaseItemGroup;
  public int SelectGiftNumber;
  public int RecvItemCount;
}

public class USFGFxDialog_GameResultBase : USFGFxDialog
{
  public int ViewPrevEXP;
  public int ViewRemainExp;
  public int ViewRemainKillBonus;
  public string PrevGFxRank;
  public int ExpNoKillFeedBack;
  public int ViewRemainSPGage;
  public int ViewCurSPGage;
  public bool bShowMatchAnimation;
  public bool bDisableClose;
  public bool bUseMiniGacha;
  public bool IsDisableMyResultFlag;
  public int LevelUpCount;
  public int SPUpCount;
  public USFUIDataStore_GameResult.FSUserResult MyResult;
  public int SPImmediatelyLimit;
  public float SPImmediatelyRatio;
  public FScriptDelegate __SortByGameScore__Delegate;
}

public class USFGFxDialog_GameResult : USFGFxDialog_GameResultBase
{
  public int AutoPageChangeTime;
  public EGameReult StartPage;
  public int nRankingRiseCount;
  public List<int> ScreenShotPartArray;
  public List<string> VisibleMyResultGameModeArray;
}

public class USFGFxDialog_GameResult_16vs16 : USFGFxDialog_GameResult
{
}

public class USFGFxDialog_GameResult_Hero : USFGFxDialog_GameResult
{
}

public class USFGFxDialog_GameResult_PVE : USFGFxDialog_GameResultBase
{
  public int PrevPveLevelCount;
  public bool bTPReward;
}

public class USFGFxDialog_GameResult_Zombie : USFGFxDialog_GameResult_PVE
{
}

public class USFGFxDialog_InGameEvent : USFGFxDialog
{
}

public class USFGFxDialog_InGameShop : USFGFxDialog
{
  public class FSInGameShopItemUIData
  {
    public bool bIsSubMenu;
    public EWeaponType ItemType;
    public bool ItemAvailable;
    public int ItemPVEShopID;
    public string ItemUIImageSetIndex;
    public string ItemUIImageSetName;
    public string ItemUIName;
    public string ItemUIPrice;
    public string ItemUIShortcut;
    public int SlotType;
  }

  public class FSInGameShopWeaponModeRistrict
  {
    public EGameMode gamemode;
    public List<EWeaponType> WeaponType;
  }

  public int MAX_DISPLAY_ROW_ITEM;
  public List<FSInGameShopItemUIData> DisplayShopItemList;
  public int SelectedItemSoltIndex;
  public EIngameShopItemDisplayType ItemDisplayType;
  public int CurrentMenuTab;
  public int ActiveGroupIndex;
  public float LastCursorPosX;
  public float LastCursorPosY;
  public List<FSInGameShopWeaponModeRistrict> ModeRistrictList;
  public UGFxObject TitleMsg;
  public FScriptDelegate __DisplayShopItemSort__Delegate;
}

public class USFGFxDialog_ItemRepair : USFGFxDialog_Repair
{
  public class FsReservedData
  {
    public string WeaponName;
    public ulong ISN;
    public int CouponID;
    public int CouponCount;
    public int MySp;
  }

  public FsReservedData ReservedData;
}

public class USFGFxDialog_ItemResell : USFGFxDialog
{
  public float ResellPriceRatio;
  public string ResellPriceErrorMessage;
  public ulong ResellItemSN;
  public string ResellItemType;
  public string ResellItemCount;
  public bool bOpenReconfirmDialog;
  public bool bDeleteItemServerSetting;
  public UGFxClikWidget btnConfirmOK;
  public UGFxClikWidget btnConfirmCancel;
  public UGFxClikWidget btnConfirmClose;
  public UGFxClikWidget ResellNumbericMC;
  public FScriptDelegate __OnRequestResellItemDelegate__Delegate;
}

public class USFGFxDialog_MatchingFound : USFGFxDialog
{
}

public class USFGFxDialog_MsgrChat : USFGFxDialog
{
  public UGFxObject ChatCreatedMC;
  public UGFxObject ChatDlgMC;
  public UGFxClikWidget ChattingList;
  public UGFxObject TxtTitle;
  public UGFxObject TxtIsOff;
  public UGFxClikWidget BtnMinimize;
  public UGFxClikWidget BtnTaskBar;
  public UGFxObject BtnTaskBarAni;
  public bool bIsMinimized;
  public bool bIsOpenedByRecv;
  public bool bButtonFlashOn;
  public bool bUse24Hour;
  public int ChatDlgIndex;
  public int ContactUSN;
  public string ContactCodeName;
  public int ContactNametagImage;
  public string strBuddyOffline;
  public string strBuddyOnline;
  public string ChattingTitleMessage;
  public string str24Time;
  public string strTimePM;
  public string strTimeAM;
  public float PrevChatSendTime;
}

public class USFGFxDialog_PackagePreview : USFGFxDialog_FuncUseDefault
{
}

public class USFGFxDialog_PartsApply : USFGFxDialog
{
  public string PartsApplyDlgTitle;
  public string PartsBuyText;
  public string PartsApplyText;
  public string PartsApplyNotice;
  public List<USFGameItem.FSFItemData> BuyItemList;
  public List<USFGameItem.FSFItemData> UseItemList;
  public string TargetSocketName;
  public int TargetItemID;
  public ulong TargetItemSN;
  public bool IsApplyItem;
}

public class USFGFxDialog_Password : USFGFxDialog
{
  public USFGFxClickWidget_NumericOnly PWTextInput;
  public UGFxObject PWMsg;
  public UGFxObject PWTitle;
  public UGFxObject inputPasswordText;
  public string strPW;
}

public class USFGFxDialog_RankLimitError : USFGFxDialog
{
  public string RankLimitBuyErrorText;
  public string RankLimitBuyErrorTextNoImg;
  public string RankLimitUseErrorText;
}

public class USFGFxDialog_RecycleResult : USFGFxDialog
{
}

public class USFGFxDialog_RookieChannel : USFGFxDialog
{
  public string strMessage1;
  public string strMessage2;
  public UGFxClikWidget btnChkLater;
  public int nRookieChannelNoticeDays;
}

public class USFGFxDialog_Serial : USFGFxDialog
{
  public UGFxClikWidget ImageAreaBtn;
  public string SerialPopupTitle;
  public string SerialExcess;
  public string SerialSendTimeExcess;
  public int btnSendTimeDelay;
  public int CurrentIndex;
  public int registBtnCount;
  public float PrevSerialSendTime;
  public FScriptDelegate __OnbtnAreaIndexDelegate__Delegate;
  public FScriptDelegate __OnDialogSerialRegistButtonClickDelegate__Delegate;
}

public class USFGFxDialog_SpectatorDeco : USFGFxDialog_FuncUseDefault
{
  public class FsSpectatorSettingData
  {
    public string Comment;
    public int StyleNum;
    public int CommentColor;
    public bool bFlicker;
  }

  public UGFxClikWidget InputCommentWidget;
  public UGFxObject InputCommentTextField;
  public string DefaultMessage;
  public List<string> CommentFilterMessage;
  public int CommentLengthMin;
  public string SendProperty;
  public FsSpectatorSettingData SpectatorSettingData;
}

public class USFGFxDialog_SysSetting : USFGFxDialog
{
  public class FSCategoryLocalized
  {
    public int Code;
    public string TabString;
  }

  public class FSCategorySet
  {
    public int Code;
    public UClass TabClass;
  }

  public USFProfileSettings SFProfile;
  public ASFPlayerController SFPC;
  public UGFxObject TitleBar;
  public UGFxClikWidget btnApply;
  public UGFxClikWidget btnReset;
  public UGFxClikWidget btnMainTab;
  public UGFxObject FocusedComboBox;
  public List<FSCategoryLocalized> MainTabsStrings;
  public List<FSCategoryLocalized> MainTabsStringsInGame;
  public List<FSCategoryLocalized> CategotyString;
  public string CaptureBottomNoticeText;
  public List<FSCategorySet> PreCategorySet;
  public string SpecialKeyMissionToolTip;
  public string SpecialKeyHeroToolTip;
}

public class USFGFxDialog_SystemMessage : USFGFxDialog
{
  public class FSSystemMessage
  {
    public string strMessage;
    public int nTime;
  }

  public List<FSSystemMessage> SystemMessageArray;
}

public class USFGFxDialog_TagSystem : USFGFxDialog
{
  public class FsAutoCompleteList
  {
    public int TagID;
    public int TagType;
    public string TagName;
    public int TagUserCount;
  }

  public string DialogTitle;
  public string CenterText;
  public string BottomText;
  public List<string> QuestionText;
  public List<string> SelectText;
  public string CheckingText;
  public string RightText;
  public string WrongText;
  public string AgreeText;
  public List<FsAutoCompleteList> AutoCompleteList;
  public FsAutoCompleteList[] SelectData = new FsAutoCompleteList[3];
  public UGFxClikWidget[] AnswerEditBoxWidget = new UGFxClikWidget[3];
  public UGFxClikWidget ListBoxScrollWidget;
  public UGFxClikWidget[] DropDownButtonWidget = new UGFxClikWidget[3];
  public UGFxClikWidget AgreeCheckBtn;
  public UGFxObject[] TextMC = new UGFxObject[3];
  public int SelectType;
  public int TotalRecvCount;
  public int KeySelectNumber;
  public int TextLimitCount;
  public string SearchKeyword;
  public string CodeName;
  public bool IsListBoxShow;
  public int TagCount;
}

public class USFGFxDialog_TwitchTV : USFGFxDialog
{
  public UGFxClikWidget InputIDBox;
  public UGFxClikWidget InputPasswordBox;
  public UGFxClikWidget SaveIDCheckBox;
  public UGFxClikWidget LoginButton;
  public UGFxClikWidget LogOutButton;
  public UGFxClikWidget JoinButton;
  public UGFxClikWidget FindPasswordButton;
  public UGFxClikWidget ModifyButton;
  public UGFxClikWidget BroadCastTtileEditBox;
  public UGFxClikWidget StartButton;
  public UGFxClikWidget ResolutionComboBox;
  public UGFxClikWidget FrameRateTextBox;
  public UGFxClikWidget BroadcastServerComboBox;
  public List<string> TwitchTVMessage;
  public string TwitchTVGameTitle;
  public string TwitchTVClientID;
  public string TwitchTVClientSecretKey;
  public string TwitchTVJoinURL;
  public string TwitchTVFindPasswordURL;
  public string TwitchTVModifyURL;
  public string RememberIDFilePath;
  public int TwitchTVFps;
  public List<USFTypes.FTwitchTVResolutionInfo> ResolutionInfo;
  public bool IsTwitchTVLogining;
  public bool IsVolumeMute;
  public bool IsBroadcastButtonEnable;
  public bool bCheckRememberID;
  public bool IsViewActivated;
  public bool IsProcessLogin;
  public string TwitchTVLoginID;
  public int VolumeValue;
  public ASFHUD myHUD;
}

public class USFGFxDialog_UseCamo : USFGFxDialog_FuncUseDefault
{
  public class FsCamouseWeaponList
  {
    public ulong ISN;
    public int ItemId;
    public int CamoID;
    public string Icon;
    public string Name;
    public string CamoIcon;
  }

  public int RowSize;
  public int SelectedItemIdx;
  public int SelectedWeaponID;
  public ulong SelectedWeaponISN;
  public List<int> WeaponCamoMCItemArray;
  public FRotator rRotLast;
  public string GFxName;
  public string strWaringMessage;
  public string strPrecautionMessage;
  public string strRemovalPrecautionMessage;
  public bool bShouldRemove;
  public List<FsCamouseWeaponList> DisplayWeapons;
  public ASceneCapture2DActor ViwingCamera;
  public FScriptDelegate __OnItemClickedDelegate__Delegate;
  public FScriptDelegate __OnItemDblClickedDelegate__Delegate;
  public FScriptDelegate __OnPreviewRotationStartDelegate__Delegate;
  public FScriptDelegate __OnPreviewRotationDelegate__Delegate;
  public FScriptDelegate __OnPreviewRotationEndDelegate__Delegate;
  public FScriptDelegate __OnPreviewZoomDeltaDelegate__Delegate;
  public FScriptDelegate __ItemListSortByItemIDDelegate__Delegate;
  public FScriptDelegate __ItemListSortByItemTypeDelegate__Delegate;
}

public class USFGFxDialog_UseBombSPCoupon : USFGFxDialog_UseCamo
{
}

public class USFGFxDialog_UseCarveWeaponTag : USFGFxDialog_UseCamo
{
  public USFTypes.FSInputTextFilter InputTextLimit;
  public List<USFGFxDialog_ClanMake.FSClanTextInputStateMsg> InputTextStateMsgs;
  public List<string> SystemMsgColorArray;
  public USFGFxMoviePlayer_WeaponNameTag WeaponTagMoviePlayer;
}

public class USFGFxDialog_UseChangeClanmark : USFGFxDialog_FuncUseDefault
{
  public class FLayerInfo
  {
    public int MaxPage;
    public int NowPage;
    public int SelectTabIndex;
    public int SelectClanMarklistIndex;
    public int SelectIndexPage;
    public List<USFTypes.FsClanMarkInfo> ClanMarkInfoArray;
    public List<USFTypes.FsChangeClanMarkTabInfo> TabInfoArray;
  }

  public UGFxClikWidget RandomBtn;
  public UGFxClikWidget ResetBtn;
  public FLayerInfo[] LayerInfos = new FLayerInfo[3];
  public string UseItemCode;
  public int SelectLayerIndex;
  public List<string> ClanMarkArray;
  public int ViewClanMarkListCount;
  public string HtmlTypeFront;
  public string HtmlTypeEnd;
  public string SameClanMarkMessage;
  public string ErrorNullClanMarkMessage;
  public string strOrigBtnOKMessage;
  public string FormatToolTipText;
  public string FormatToolTipLayerFront;
  public string FormatToolTipLayerEnd;
  public FScriptDelegate __TabListSortByTabSortDelegate__Delegate;
  public FScriptDelegate __ClanMarkListSortByImageSortDelegate__Delegate;
}

public class USFGFxDialog_UseColorCodeName : USFGFxDialog_FuncUseDefault
{
  public UGFxClikWidget ColorList;
  public List<string> ColorTableArray;
  public string DefaultColor;
  public string DefaultClanName;
  public int nSelectColorIndex;
  public bool bChangeClanColorName;
}

public class USFGFxDialog_UseColorCodeNameV2 : USFGFxDialog_FuncUseDefault
{
  public UGFxClikWidget ColorList;
  public int nSelectColorIndex;
  public string ConvertColorIndex;
  public string DefaultColor;
  public bool IsChange;
}

public class USFGFxDialog_UseCoupon : USFGFxDialog
{
  public string UseCouponTitleMessage;
  public string UseCouponNoticeMessage;
  public string CodeLengthWrongMessage;
  public int CouponCodeLength;
  public USFGFxClickWidget_NumericOnly InputCoupon;
  public UGFxObject InputCouponText;
}

public class USFGFxDialog_UseFiringRangeScoreInitial : USFGFxDialog_FuncUseDefault
{
  public int WeaponType;
  public string Inputinitial;
  public string Message;
  public string strBtnOK;
  public string strUseMessage;
  public UGFxClikWidget[] InitialBox = new UGFxClikWidget[3];
  public UGFxObject[] InitialTestField = new UGFxObject[3];
}

public class USFGFxDialog_UseInfiniteMagazine : USFGFxDialog_FuncUseDefault
{
  public class FsCamouseWeaponList
  {
    public ulong ISN;
    public int ItemId;
    public int CamoID;
    public string Icon;
    public string Name;
    public string CamoIcon;
  }

  public int RowSize;
  public int SelectedItemIdx;
  public int SelectedWeaponID;
  public ulong SelectedWeaponISN;
  public List<int> WeaponCamoMCItemArray;
  public FRotator rRotLast;
  public string GFxName;
  public string strItemDuplicate;
  public string strWaringMessage;
  public string strPrecautionMessage;
  public string strRemovalPrecautionMessage;
  public bool bShouldRemove;
  public List<FsCamouseWeaponList> DisplayWeapons;
  public ASceneCapture2DActor ViwingCamera;
  public FScriptDelegate __OnItemClickedDelegate__Delegate;
  public FScriptDelegate __OnItemDblClickedDelegate__Delegate;
  public FScriptDelegate __ItemListSortByItemIDDelegate__Delegate;
  public FScriptDelegate __ItemListSortByItemTypeDelegate__Delegate;
}

public class USFGFxDialog_UseInitWeaponKillDeath : USFGFxDialog_FuncUseDefault
{
  public class FsCamouseWeaponList
  {
    public ulong ISN;
    public int ItemId;
    public int CamoID;
    public string Icon;
    public string Name;
    public string CamoIcon;
    public string Groups;
    public string ItemCode;
    public int WeaponLogIndex;
    public USFTypes.FSFWeaponLogMember LogMember;
  }

  public int RowSize;
  public int SelectedItemIdx;
  public int SelectedWeaponID;
  public ulong SelectedWeaponISN;
  public string GFxName;
  public string strWaringMessage;
  public string strKADRatioMessage;
  public List<USFTypes.FSFWeaponLog> AllWeaponLogArray;
  public List<FsCamouseWeaponList> DisplayWeapons;
  public ASceneCapture2DActor ViwingCamera;
  public FScriptDelegate __OnItemClickedDelegate__Delegate;
  public FScriptDelegate __OnPreviewZoomDeltaDelegate__Delegate;
  public FScriptDelegate __ItemListSortByItemIDDelegate__Delegate;
  public FScriptDelegate __ItemListSortByItemTypeDelegate__Delegate;
}

public class USFGFxDialog_UseMuzzleFlash : USFGFxDialog_UseCamo
{
  public UGFxClikWidget ColorList;
  public List<string> MuzzleColorTableArray;
  public string DefaultMuzzleColor;
  public int SelectedColorIndex;
  public bool IsCanSilencerMuzzle;
  public bool IsCanSilencerMuzzleFlash;
}

public class USFGFxDialog_UseRandomBox : USFGFxDialog_FuncUseDefault
{
  public class FsRandomBoxItemInfo
  {
    public string Index;
    public string ItemName;
    public string ItemImg;
  }

  public string strRandomBoxPotupTitle;
  public UGFxClikWidget RandomboxPopupTitleWidget;
  public string strWaringMessage;
  public List<FsRandomBoxItemInfo> RollingDataList;
  public UGFxClikWidget RandomBoxRewardItemWidget;
  public UGFxClikWidget RewardOKbtnWidget;
  public UGFxClikWidget KeyBuybtnWidget;
  public int RandomBoxRewardItemID;
  public bool bUseRewardOkBtn;
}

public class USFItem_Base : UObject
{
  public class FItemColorVariationValue
  {
    public EPartType PartType;
    public int MaterialIdx;
    public int PatternMaskIdx;
    public List<UObject.FLinearColor> PatternColors;
    public string PatternCamoTextureName;
    public int SymbolMaskIdx;
    public List<UObject.FLinearColor> SymbolColors;
    public string SymbolCamoTextureName;
  }

  public class FsUIItemStat
  {
    public string Tag;
    public string Adv;
  }

  public List<FsUIItemStat> UIItemStats;
  public List<FItemColorVariationValue> ColorVariationVelues;
  public int OptionSlot;
  public EItemType ItemType;
  public EGender UsableGender;
  public ELobbyDialog DialogIndex;
  public string SpecificClassName;
  public string SpecificTargetClassName;
  public bool CommonItem;
  public bool SingleUse;
  public bool bSingleUseButNeedPawn;
  public bool bUsePreviewDialog;
  public bool bUseDefaultMaterial;
  public bool bIsInGameStoreItem;
  public int ItemTableIndex;
  public USFItemMesh MeshData;
  public USFItemMesh LobbyMeshData;
  public List<string> DefaultItemClassNames;
  public List<int> AbsolutelyRemovableType;
  public List<int> NotAllowOverlapType;
  public int MyType;
  public int ResourceIndex;
  public int TextureCoordIndex;
  public int OverlapCheckFlag;
  public int AbsoluteCheckFlag;
  public string ItemName;
  public string OverlapLimitText;
  public string ItemContext;
  public string ItemBuyDlgNotice;
  public List<string> GashaToolTipList;
  public string WeaponEffect;
  public string WeaponEffectShort;
  public string strItemInfo;
  public string strItemNotice;
  public string strItemText1;
  public string strItemText2;
  public string strUseSuccessMsg;
  public string strUseMessagePeriod;
  public string strUseMessagePermanent;
}

public class USFGFxDialog_UseStoredMaterial : USFGFxDialog_FuncUseDefault
{
  public class FStoredMaterialInfo
  {
    public int ItemId;
    public int RewardItemID;
  }

  public class FDisplayedItemInfo
  {
    public ulong ISN;
    public int ItemId;
    public string Icon;
    public string Name;
    public int Type;
  }

  public List<FStoredMaterialInfo> StoredMaterialInfoArray;
  public List<FDisplayedItemInfo> DisplayItems;
  public string strWaringMessage;
  public int RowSize;
  public int SelectedItemIdx;
  public FScriptDelegate __ItemListSortByItemIDDelegate__Delegate;
  public FScriptDelegate __ItemListSortByItemTypeDelegate__Delegate;
  public FScriptDelegate __OnItemClickedDelegate__Delegate;
}

public class USFGFxDialog_UseWeaponParts : USFGFxDialog_UseCamo
{
  public USFTypes.FSInputTextFilter InputTextLimit;
  public List<USFGFxDialog_ClanMake.FSClanTextInputStateMsg> InputTextStateMsgs;
  public List<string> SystemMsgColorArray;
  public USFGFxMoviePlayer_WeaponNameTag WeaponTagMoviePlayer;
}

public class USFGFxDialog_VoteOut : USFGFxDialog
{
  public string VoteOutTitle;
  public string VoutOutContentText;
  public string VoteOutContent;
  public UGFxClikWidget MemberList;
  public List<string> MemberListArray;
  public int SelectedIndex;
}

public class USFGFxDialog_WaitingAck : USFGFxDialog
{
}

public class USFGFxDialog_WebLogin : USFGFxDialog
{
}

public class USFGFxDialog_WeeklyClanRank : USFGFxDialog
{
  public int TopRankingCount;
  public string WeeklyClanRankDialogTitle;
  public string WeeklyClanRankAttendText;
  public UGFxClikWidget TopRankList;
  public UGFxClikWidget BottomRankList;
}

public class USFGFxMoviePlayer : UGFxMoviePlayer
{
  public USFOnlineSubsystemPC OnlineSub;
  public string DefaultRecommendScreenRes;
  public int RecommandOtherRatio;
  public List<string> DisableIMEArray;
  public List<string> DefaultIMENameArray;
  public bool bEnterKeyWithIMECandidate;
  public USFSoundGroup_UX UXSoundGroup;
  public APlayerController PlayerOwner;
  public FScriptDelegate __OnGFxKeyPressDelegate__Delegate;
}

public class USFGFxHUDMoviePlayer : USFGFxMoviePlayer
{
  public ASFHUD myHUD;
  public List<USFGFxHUDWidget> HUDWidgetArray;
  public int WidgetInitializedCount;
  public int WidgetBindingCount;
  public int MoviePlayerIndex;
  public List<string> MovieNameArray;
  public UGFxObject StagePanelMC;
}

public class USFSoundGroup : UObject
{
  public int ClassVersion;
  public int ObjVersion;
}

public class USFSoundGroup_UX : USFSoundGroup
{
  public class FSUXSound
  {
    public FName EventName;
    public USoundCue EventSoundCue;
  }

  public List<FSUXSound> UXSounds;
}

public class USFGFxHUD : USFGFxHUDMoviePlayer
{
  public int PrevPRILength;
  public UGFxObject ActionMsgMC;
  public List<UGFxObject> TestCombatMsgMC;
}

public class USFGFXHUD_Beast : USFGFxHUDMoviePlayer
{
}

public class USFGFxHUD_Beginner : USFGFxHUDMoviePlayer
{
  public UGFxClikWidget BeginnerMsgMC;
}

public class USFGFXHUD_Capture : USFGFxHUDMoviePlayer
{
}

public class USFGFXHUD_Convoyance : USFGFxHUDMoviePlayer
{
}

public class USFGFxHUD_Death : USFGFxHUDMoviePlayer
{
  public class FSortPRIDataDeath
  {
    public List<ASFPlayerReplicationInfo> PRIArray;
  }

  public class FRankBoardStruct
  {
    public int[] PlayerID = new int[16];
    public int[] IsRefresh = new int[16];
  }

  public UGFxObject FirstRankMC;
  public UGFxObject MyTopRankMC;
  public UGFxObject RankBoardMC;
  public FRankBoardStruct RankBoardArray;
  public FSortPRIDataDeath SortPRIArray;
  public ASFPlayerReplicationInfo FirstPRI;
  public int MyRank;
  public int WholePlayerNum;
  public string RankText;
}

public class USFGFXHUD_PvEBase : USFGFxHUDMoviePlayer
{
}

public class USFGFXHUD_Defence : USFGFXHUD_PvEBase
{
}

public class USFGFxHUD_FrontLine : USFGFxHUDMoviePlayer
{
  public UGFxObject FrontLineMC;
  public List<ASFFrontLineVolume> FrontLIneVolumArray;
  public List<string> FrontLIneStatusArray;
}

public class USFGFxHUD_ModeExclusive : USFGFxHUDMoviePlayer
{
}

public class USFGFxHUD_Observer : USFGFxHUDMoviePlayer
{
}

public class USFGFXHUD_RocketJump : USFGFxHUDMoviePlayer
{
}

public class USFGFxHUD_RocketJumpCapture : USFGFxHUDMoviePlayer
{
}

public class USFGFxHUD_ScoreBoardBase : USFGFxHUDMoviePlayer
{
  public class FSortPRIData
  {
    public List<ASFPlayerReplicationInfo> PRIArray;
  }

  public FSortPRIData[] SortPRIArray = new FSortPRIData[8];
  public bool bIsShowScoreBoard;
  public bool bIgnore;
  public bool bVisibleAIName;
  public bool bViewPingNumber;
  public bool bHideRadar;
  public bool bIgnoreAI;
  public ETeam RedTeamIndex;
  public ERadarType ScoreBoardRadarType;
  public UGFxObject ScoreBoardMC;
  public UGFxClikWidget[] UserListMC = new UGFxClikWidget[8];
  public UGFxClikWidget DeathGameListMC;
  public List<int> PingValueArray;
  public UGFxClikWidget MinimapMC;
  public ASFUIMinimapRadar Radar;
  public int CurRedScore;
  public int CurBlueScore;
  public string PingMsg_Attack;
  public string PingMsg_Retreat;
  public USoundCue[] PingSound = new USoundCue[2];
  public string AIMode;
  public FName ScoreBoardMCName;
}

public class USFGFxHUD_ScoreBoardNormal : USFGFxHUD_ScoreBoardBase
{
  public bool bInitScore;
  public string RoundFootString;
  public string PointFootString;
  public string MatchConditionText;
}

public class USFGFxHUD_ScoreBoard16vs16 : USFGFxHUD_ScoreBoardNormal
{
}

public class USFGFxHUD_ScoreBoardAITDMVs16 : USFGFxHUD_ScoreBoardNormal
{
}

public class USFGFxHUD_ScoreBoardBeast : USFGFxHUD_ScoreBoardNormal
{
}

public class USFGFxHUD_ScoreBoardCaptureTheFlag : USFGFxHUD_ScoreBoardNormal
{
}

public class USFGFxHUD_ScoreBoardConvoyance : USFGFxHUD_ScoreBoardNormal
{
  public string ConvoyanceRedText;
  public string ConvoyanceBlueText;
}

public class USFGFxHUD_ScoreBoardHardCore : USFGFxHUD_ScoreBoardNormal
{
}

public class USFGFxHUD_ScoreBoardObserver : USFGFxHUD_ScoreBoardBase
{
}

public class USFGFxHUD_ScoreBoardSurvival : USFGFxHUD_ScoreBoardBase
{
  public bool bHideCriticalKillCount;
}

public class USFGFxHUD_ScoreBoardShooter : USFGFxHUD_ScoreBoardSurvival
{
}

public class USFGFxHUD_ScoreBoardThunderRun : USFGFxHUD_ScoreBoardNormal
{
  public int PreviousTime;
  public int nCurrRound;
  public ASFThunderRunTeamInfo[] SFTI = new ASFThunderRunTeamInfo[8];
}

public class USFGFxHUD_ScoreBoardTraining : USFGFxHUD_ScoreBoardBase
{
}

public class USFGFxHUD_ScoreBoardWarrior : USFGFxHUD_ScoreBoardNormal
{
  public string RespawnDelayMessage;
}

public class USFGFxHUD_ScoreBoardZombie : USFGFxHUD_ScoreBoardSurvival
{
}

public class USFGFxHUD_ScoreBoardZombieHideSeek : USFGFxHUD_ScoreBoardNormal
{
}

public class USFGFXHUD_Shooter : USFGFxHUDMoviePlayer
{
}

public class USFGFxHUD_Sniper : USFGFxHUDMoviePlayer
{
  public UGFxObject HitFromMeMC;
  public UGFxObject HitFromEnemyMC;
  public float fShowDuration;
}

public class USFGFxHUD_Spy : USFGFxHUDMoviePlayer
{
}

public class USFGFXHUD_Survival : USFGFXHUD_PvEBase
{
}

public class USFGFxHUD_ThunderRun : USFGFxHUDMoviePlayer
{
  public UGFxObject _global;
  public UGFxObject ProgressGaugeMC;
  public UGFxObject ProgressNoticeMC;
  public UGFxObject RoundEndMsgMC;
  public List<UGFxObject> RotationMC;
  public List<string> strAttackMessage;
  public List<string> strDefendMessage;
  public string LocalizedFastWin;
  public string LocalizedAreaWin;
  public string LocalizedScoreWin;
  public string LocalizedFirstWin;
  public string LocalizedFastAreaWin;
  public string LocalizedScore;
  public ESFStrongHoldArea nAreaIndex;
  public ASFThunderRunVolume[] ThunderrunVol = new ASFThunderRunVolume[4];
  public float PassedTime;
  public float UpdatePeriodTime;
  public int AttackProgress;
  public int PlayerProgress;
  public int OldArrowRotaion;
  public FVector vPointLoc;
  public FVector2D StartAreaLocation;
  public FVector2D EndAreaLocation;
  public FVector2D AreaDirection;
  public float AreaDist;
  public int WarningBlinkDistance;
  public int WarningTime;
  public string CurPosition;
  public bool bIsWarningBlink;
}

public class USFGFxHUD_Training : USFGFxHUDMoviePlayer
{
  public UGFxClikWidget StopWatchMC;
  public UGFxClikWidget TargetCountMC;
  public UGFxClikWidget KeyInfoMC;
  public bool bKeyInfoShow;
  public bool bKeyInfoMinimized;
  public bool bHideFromLeftNotice;
  public bool bStartedStopWatch;
  public bool bPausedStopWatch;
  public bool bPlayStopWatchAni;
  public List<string> strKeyInfoMessage;
  public string strNameChangeNotifyMessage;
  public string strCurTargetMessage;
  public string strMaxTargetMessage;
  public int MaxTargetCount;
  public int nCurSeconds;
  public float fCurCentiSeconds;
}

public class USFGFxHUD_Tutorial : USFGFxHUDMoviePlayer
{
  public FScriptDelegate __OnsetHitTargetEndMotionDelegate__Delegate;
}

public class USFGFxHUD_TutorialResults : USFGFxHUDMoviePlayer
{
  public UGFxObject ResultBoardMC;
  public UGFxObject sealAttachMC;
  public bool bIsShowTutorialResults;
  public UGFxClikWidget btnOk;
  public UGFxClikWidget btnCancel;
  public string EndTime;
  public string ValidScore;
  public string InvalidScore;
  public int TimeScore;
  public int PlusScore;
  public int MinusScore;
  public int TotalScore;
  public int Seal;
  public string ResultRank;
  public int ViewRemainExp;
  public string ViewBeforeGFxRank;
  public int LevelUpCount;
  public string TutohudCount;
}

public class USFGFXHUD_Warrior : USFGFxHUDMoviePlayer
{
}

public class USFGFxHUD_WeaponChange : USFGFxHUDMoviePlayer
{
  public UGFxClikWidget WeaponSetMC;
  public List<int> MainWeapons;
  public List<string> WeaponSetName;
  public string WeaponSetChangedMsg;
  public string WeaponSetChangedMsgForTraining;
  public bool bShowWeaponSetChange;
  public float fDurationTime;
  public int WeaponSetCount;
}

public class USFGFxHUD_Zombie : USFGFXHUD_PvEBase
{
}

public class USFGFxHUD_ZombieHideSeek : USFGFxHUDMoviePlayer
{
  public UGFxObject ZombieToopTipMC;
  public bool bShowZombieToolTip;
  public int ShowZombieToolTipCount;
}

public class USFGFxHUDWidget : UGFxObject
{
  public ASFHUD myHUD;
  public FName ViewName;
  public USFGFxHUDMoviePlayer ParentMovie;
  public USFItemManager ItemManager;
  public USFOnlineSubsystemPC OnlineSub;
  public bool bUseScriptUpdate;
  public bool bReceiveExternalCall;
  public bool bWidgetOpened;
  public bool bNoAutoOpenAtRoundStart;
  public List<string> WidgetDisableModeNameArray;
  public List<string> WidgetDisableControllerNameArray;
  public int PreviousTime;
  public int WidgetVisibleCounter;
  public List<EHUDWidgetHideType> WidgetHideType;
}

public class USFGFxHUDWidget_Ammo : USFGFxHUDWidget
{
  public class FSWeaponName
  {
    public string WeaponClassName;
    public string WeaponName;
    public string WeaponImgName;
  }

  public int PrevAmmoCount;
  public int PrevAmmoCountinMgz;
  public int PrevAmmoCountMaxAndInMgz;
  public bool bIsUpdateAmmoInfo;
  public bool bTargetSeizured;
  public ASFWeapon PrevWeapon;
  public int[] PrevBombSPRemainNum = new int[3];
}

public class USFGFxHUDWidget_BeastBuffInfo : USFGFxHUDWidget
{
  public EBuffState[] PrevBuffList = new EBuffState[18];
}

public class USFGFxHUDWidget_BeastChangeBeastType : USFGFxHUDWidget
{
  public int NewBeastSet;
  public List<string> BeastChangedMsgArray;
}

public class USFGFxHUDWidget_BeastHealthInfo : USFGFxHUDWidget
{
  public int PrevHealth;
}

public class USFGFxHUDWidget_BeastModeInfo : USFGFxHUDWidget
{
  public int PrevMyScore;
  public int PrevOtherScore;
}

public class USFGFxHUDWidget_BeastWeaponInfo : USFGFxHUDWidget
{
  public float PrevCooltime;
}

public class USFGFxHUDWidget_BlackOut : USFGFxHUDWidget
{
  public bool bBlackOut;
}

public class USFGFxHUDWidget_BuffInfo : USFGFxHUDWidget
{
  public List<EBuffType> DisplayBuffList;
  public List<ASFGameInfo.FSKillDeathStreakBuffInfo> KillDeathStreakList;
  public bool InitializedStreakBuff;
}

public class USFGFxHUDWidget_CaptureModeInfo : USFGFxHUDWidget
{
  public ETeam PrevCapturedTeam;
  public string PrevCapturedPlayer;
  public bool bFinishCaptureWaitTime;
  public bool bUpdateCaptureInfoBySecond;
}

public class USFGFxHUDWidget_CaptureResult : USFGFxHUDWidget
{
  public string MSG_Capture_Success;
  public string MSG_Capture_Failure;
}

public class USFGFxHUDWidget_CaptureTimer : USFGFxHUDWidget
{
  public List<float> WarningLevelTime;
  public float LastUpdatedTime;
  public float TotalTime;
  public ETeam CaptureTeamIndex;
}

public class USFGFxHUDWidget_ChallengeMsg : USFGFxHUDWidget
{
  public USFChallengeListCondition SFChallengeInfoCondition;
  public int ChallengeUIFloatingTime;
  public List<USFTypes.FChallengeData> ChallengeOverlapData;
}

public class USFGFxHUDWidget_Chat : USFGFxHUDWidget
{
  public UGFxClikWidget ChatInputText;
  public int InGameChatListShowTimeLimit;
  public List<USFTypes.FSChatMsgInfo> MergedChatMsgArray;
  public bool bOpenChattingLog;
  public bool bHideChatLog;
  public int PrevIMEConversion;
  public int PrevIMEOpenStatus;
  public List<string> DisableChatMessageArray;
  public int nKickUserIndex;
  public int nPrevKickUserNameLength;
  public List<string> KickCodeNameArray;
  public string KickUserCodename;
}

public class USFGFxHUDWidget_PawnHeadUpBase : USFGFxHUDWidget
{
  public class FGFxPawnHeadUpInfo
  {
    public UGFxObject MovieClip;
    public UGFxObject TxtCodeName;
    public UGFxObject TxtNumber;
    public UGFxObject TxtRadio;
    public UGFxObject TxtOverWall;
    public UGFxObject TxtOption;
    public UGFxObject TxtOptionBlue;
    public UGFxObject TxtOptionRed;
    public UGFxObject TxtZombieBlue;
    public UGFxObject TxtZombieRed;
    public string PrevCodeNameDist;
    public string PrevCodeName;
    public string PrevNumber;
    public string PrevRadio;
    public string PrevHP;
    public int nIsPrevRendered;
    public bool bKillCam;
    public bool bIsStun;
    public bool bIsKilled;
    public bool bIsConvoyanceAttachItem;
  }

  public List<FGFxPawnHeadUpInfo> GFxHeadUpInfoArray;
  public int GFxHeadUpInfoUsedIndex;
  public List<FGFxPawnHeadUpInfo> GFxEnemyHeadUpInfoArray;
  public int GFxEnemyHeadUpInfoUsedIndex;
  public int BillSizeMax;
  public int BillSizeMin;
  public int BillMinDist;
  public int BillMaxDist;
  public float fFadeOutTime;
  public bool IsObserverView;
  public FScriptDelegate __OncreateHeadUpUIMovieClipDelegate__Delegate;
}

public class USFGFxHUDWidget_CodeName : USFGFxHUDWidget_PawnHeadUpBase
{
  public EObserverViewMode CurrentViewMode;
  public int CodeNameOffset;
  public float TeamCodeNameVisibleMaxDistance;
  public string DefaultHPText;
  public bool bEnemyIsTeamForObserver;
  public bool bHideSameTeamCodeWhenDead;
  public int ObserverEnemyViewMaxDist;
}

public class USFGFxHUDWidget_CodenameAim : USFGFxHUDWidget
{
  public string strCodeName;
}

public class USFGFxHUDWidget_CombatMsg : USFGFxHUDWidget
{
  public class FSCombatMsg
  {
    public string Killer;
    public string Victim;
    public string Assist;
    public string Option;
    public string Weapon;
    public string Camo;
    public EWeaponType WeaponType;
    public bool bIsMe;
    public float ShowTime;
    public float HideTime;
  }

  public class FSGFxCombatMsg
  {
    public string Killer;
    public string Victim;
    public string Assist;
    public string Option;
    public string Weapon;
    public string Camo;
    public float ShowTime;
    public float HideTime;
    public bool bShow;
    public float fHeight;
    public UGFxObject MC;
  }

  public class FSMissionCombatMsg
  {
    public string EventName;
    public string ImgName;
    public string LocalizedEvent;
  }

  public string AssistMsgTxt;
  public string[] TeamColor = new string[3];
  public string TeamColorForDeathGame;
  public List<FSGFxCombatMsg> GFxCombatMsgArray;
  public UGFxObject LogMC;
  public UGFxObject LogMaskMC;
  public int NumMessages;
  public float TargetLineHeight;
  public float CurLineHeight;
  public float MessageDownSpeed;
  public float MessageHeight;
  public int MaxShowMsgCount;
  public float DurationTime;
  public int StartLineHeight;
  public int StartLineHeightForObserver;
  public float HideDurationTime;
  public bool bShowCodeNameObserver;
  public int PrevShowMsgCount;
  public List<FSMissionCombatMsg> MissionGFxCombatMsgArray;
}

public class USFGFxHUDWidget_CombatReport : USFGFxHUDWidget
{
  public float fShowDuration;
  public int MaxDamageUserCount;
  public int CombatReportEnableType;
  public string KillText;
  public string AssistText;
  public string DeathText;
  public int PrevKill;
  public int PrevAssist;
  public int PrevDeath;
}

public class USFGFxHUDWidget_Common_ModeExclusive_ItemSlot : USFGFxHUDWidget
{
  public List<int> ActiveItems;
  public List<int> PassiveItems;
  public int LastActiveItemSlotNotice;
  public int ActiveItemSlotCount;
}

public class USFGFxHUDWidget_ConvoyanceGauge : USFGFxHUDWidget
{
  public bool IsDrawingConvoyanceGauge;
  public int nPrevGaugePercent;
  public float DisplayRate;
}

public class USFGFxHUDWidget_ConvoyanceHeadUp : USFGFxHUDWidget_PawnHeadUpBase
{
  public FVector ConvoyanceHeadUpOffset;
}

public class USFGFxHUDWidget_ConvoyanceMatchResult : USFGFxHUDWidget
{
  public string WinMessage;
  public string LoseMessage;
}

public class USFGFxHUDWidget_ConvoyanceMove : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_ConvoyancePush : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_ConvoyanceSeizureIcon : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_DronController : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_FeverTimeIcon : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_GlowModeGauge : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_HeadUpArrowIcon : USFGFxHUDWidget_PawnHeadUpBase
{
}

public class USFGFxHUDWidget_Health : USFGFxHUDWidget
{
  public int PrevHP;
  public int PrevHPGage;
  public int PrevAP;
  public UGFxObject Ani_Blink;
  public ASFPawn PrevSFPawn;
  public float fOldTime;
  public float fNowTime;
}

public class USFGFxHUDWidget_Help : USFGFxHUDWidget
{
  public List<string> HelpPage;
}

public class USFGFxHUDWidget_HeroPlayerInfo : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_HeroTimer : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_InGameQuest : USFGFxHUDWidget
{
  public class FSSimpleChallengeData
  {
    public string TaskCode;
    public int TaskIndex;
  }

  public class FSInGameQuestData
  {
    public EGameMode gamemode;
    public List<USFGFxHUDWidget_InGameQuest.FSSimpleChallengeData> QuestInfo;
  }

  public USFChallengeListCondition ChallengeListCondition;
  public List<FSInGameQuestData> InGameQuests;
  public List<USFChallengeListCondition.FChallengeProgressData> DisplayQuestList;
  public int CompletedDisplayQuestCount;
}

public class USFGFxHUDWidget_InstantRespawn : USFGFxHUDWidget
{
  public bool bShowInstantRespawn;
  public string InstantRespawnMessage;
  public string InstantRespawnNoSPMessage;
  public float StartTime;
  public float CurTime;
  public float TotalTime;
}

public class USFGFxHUDWidget_KillCam : USFGFxHUDWidget
{
  public bool bShowKillCam;
}

public class USFGFxHUDWidget_KillHeadUpIcon : USFGFxHUDWidget_PawnHeadUpBase
{
}

public class USFGFxHUDWidget_LeftNotice : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_Linebottom : USFGFxHUDWidget
{
  public UGFxObject Txt_Time;
  public int LimitTimeGameChangeColorTime;
  public string LimitTimeGameColorOn;
  public string LimitTimeGameColorOff;
  public string TagTail;
}

public class USFGFxHUDWidget_Message : USFGFxHUDWidget
{
  public class FMessageTypeInfo
  {
    public string GfxOpenCommand;
    public string GfxCloseCommand;
    public EMessageDisplayType DisplayType;
    public USoundNodeWave DefaultSound;
  }

  public class FMessageRawData
  {
    public EGFxHUDMessage Type;
    public string Message;
    public float ActiveTime;
    public float Lifetime;
    public float RegisterTime;
    public USoundNodeWave Sound;
    public int Priority;
    public int MessageIndex;
  }

  public class FMessageInfo
  {
    public List<USFGFxHUDWidget_Message.FMessageRawData> MessageRawDatas;
  }

  public List<string> HostLogOutMessages;
  public List<string> NewHostMessages;
  public int NewHostMessageIndex;
  public FMessageTypeInfo[] MessageTypeData = new FMessageTypeInfo[25];
  public FMessageInfo[] PendingMessage = new FMessageInfo[6];
  public float NewHostMessageRealTimeSecond;
  public float KillMessageShortTime;
  public float KillIconDurationTime;
  public int KillFeedBackCount;
  public List<string> KillFeedBackIconArray;
  public int nScoreUpCount;
}

public class USFGFxHUDWidget_Minimap : USFGFxHUDWidget
{
  public bool bUseWidgetDisableController;
}

public class USFGFxHUDWidget_ModeInfo : USFGFxHUDWidget
{
  public int PrevMyScore;
  public int PrevOtherScore;
}

public class USFGFxHUDWidget_NameTagBase : USFGFxHUDWidget
{
  public ASFPlayerReplicationInfo PrevPRI;
  public ASFPlayerReplicationInfo SpectatingPRI;
  public string CurGFxRank;
  public string CurCodeName;
  public string CurLeagueNumber;
  public string CurClanMark;
  public string CurVipImg;
  public string CurClanMarkEffect;
  public int CurNametagImage;
  public int CurKill;
  public int CurAssist;
  public int CurDeath;
  public int CurHealth;
  public int CurVipGrade;
  public int CurMonthlyRewardGrade;
}

public class USFGFxHUDWidget_NameTag : USFGFxHUDWidget_NameTagBase
{
  public ASFPlayerReplicationInfo KillCamPRI;
}

public class USFGFxHUDWidget_ObjectIcon : USFGFxHUDWidget
{
  public float IconAlphaMax;
  public float IconAlphaMin;
  public float IconAlphaRadius;
  public float CircleRadiusX;
  public float CircleRadiusY;
  public int ObjectIconDefaultPosX;
  public int ObjectIconDefaultPosY;
  public bool IsCircleClippedMode;
  public bool bDrawMissionGauge;
  public bool bIsIndicator;
  public float ObjIconInterTime_RectToScreen;
  public float ObjIconInterTime_ScreenToRect;
  public float ObjIconInterSpeed;
  public float IconScale;
  public float IconScaleMax;
  public float ArrowMinDegree;
  public int RectSizeX;
  public int RectSizeY;
  public int RoundRadius;
  public List<AActor> FilteredIconArray;
  public string[] StateToFrameString = new string[7];
  public int nPrevGaugePercent;
  public string IconBackText;
  public string FastTriggerMessage;
  public string UsingTriggerByWeaponGroupMessage;
  public List<string> NeedlessGaugeModeName;
  public FScriptDelegate __OnCreateObjectIconDelegate__Delegate;
}

public class USFGFxHUDWidget_ObserverStunIcon : USFGFxHUDWidget_PawnHeadUpBase
{
  public int FirstViewMaxDist;
}

public class USFGFxHUDWidget_ObsrBriefing : USFGFxHUDWidget
{
  public bool bShowRoundBrief;
  public int PrevPlayedRound;
  public int[] RoundScore = new int[8];
}

public class USFGFxHUDWidget_ObsrFunKeyGuide : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_ObsrHPBarBase : USFGFxHUDWidget
{
  public class FSObsrUserInfo
  {
    public string CodeName;
    public string UserNumber;
    public int Health;
    public int nIsDead;
    public string WeaponName;
    public string ShowWeaponNameText;
    public ASFPlayerReplicationInfo SFPRI;
  }

  public class FSObsrUserInfos
  {
    public USFGFxHUDWidget_ObsrHPBarBase.FSObsrUserInfo[] TeamUsers = new USFGFxHUDWidget_ObsrHPBarBase.FSObsrUserInfo[8];
  }

  public FSObsrUserInfos[] UserInfoArray = new FSObsrUserInfos[8];
  public int TeamIndex;
  public int MaxTeamPlayer;
  public bool bShowHPBar;
  public bool bWeaponName;
}

public class USFGFxHUDWidget_ObsrHPBarL : USFGFxHUDWidget_ObsrHPBarBase
{
}

public class USFGFxHUDWidget_ObsrHPBarR : USFGFxHUDWidget_ObsrHPBarBase
{
}

public class USFGFxHUDWidget_ObsrModeInfo : USFGFxHUDWidget
{
  public int[] PrevScore = new int[8];
  public bool bShowModeInfo;
}

public class USFGFxHUDWidget_ObsrNameTag : USFGFxHUDWidget_NameTagBase
{
}

public class USFGFxHUDWidget_Pause : USFGFxHUDWidget
{
  public bool bPaused;
  public string strPausedUserMessage;
}

public class USFGFxHUDWidget_RadioMsg : USFGFxHUDWidget
{
  public bool bShowRadioMsg;
  public bool bShowRadioMsgFlashBang;
  public UClass CurrentRadioClass;
}

public class USFGFxHudWidget_RocketHelp : USFGFxHUDWidget
{
  public List<string> RocketHelpPage;
}

public class USFGFxHudWidget_RocketHoverTimer : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_ShooterDefenceCursor : USFGFxHUDWidget
{
  public UGFxObject AimCursor;
}

public class USFGFxHUDWidget_SurvivalMoneyInfo : USFGFxHUDWidget
{
  public int PrevModeMoney;
}

public class USFGFxHUDWidget_ShooterDefenceDashBoard : USFGFxHUDWidget_SurvivalMoneyInfo
{
  public string strStatUseMsg;
}

public class USFGFxHUDWidget_ShooterDefenceEquip : USFGFxHUDWidget
{
  public List<string> SlotName;
}

public class USFGFxHUDWidget_ShooterDefenceMinimap : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_ShooterDefenceModeInfo : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_ShooterDefencePlayerInfo : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_ShooterDefenceProgress : USFGFxHUDWidget
{
  public int MaxHealth;
  public int PrevHealth;
  public ASFPawn CurrentPawn;
  public string strProgressName;
}

public class USFGFxHUDWidget_ShooterDefenceResult : USFGFxHUDWidget
{
  public string MissionClearMsg;
  public string MissionFailureMsg;
}

public class USFGFxHUDWidget_SurvivalUserList : USFGFxHUDWidget
{
  public class FSSurvivalUser
  {
    public string CodeName;
    public int NametagImg;
    public int Health;
    public bool bHelp;
    public bool bDead;
    public float RemainingRespawnTime;
    public ASFPlayerReplicationInfo SFPRI;
    public ASFPawn Pawn;
  }

  public FSSurvivalUser[] SurvivalUsers = new FSSurvivalUser[4];
  public int MaxPlayerCount;
  public bool bShowAllTeam;
  public bool bShowMyPawn;
  public int PlayerUSN;
}

public class USFGFxHUDWidget_ShooterDefenceUserList : USFGFxHUDWidget_SurvivalUserList
{
  public class FSUIModePlayerInfo
  {
    public int PlayerID;
    public string Emblem;
    public string CodeName;
    public int ModeLevel;
    public int Health;
    public int MaxHealth;
    public int AttackPoint;
    public int DefencePoint;
    public int MovePoint;
    public int Exp;
    public int TotalExp;
    public float ElapsedRespawnDelay;
    public float TotalRespawnDelay;
    public int ModeItemStatChanged;
    public float LastCheckedTime;
  }

  public List<FSUIModePlayerInfo> ModePlayerInfoList;
}

public class USFGFxHUDWidget_SnowballStunIcon : USFGFxHUDWidget_PawnHeadUpBase
{
}

public class USFGFxHUDWidget_Spectator : USFGFxHUDWidget
{
  public bool bShowSpectating;
}

public class USFGFxHudWidget_SpyHelp : USFGFxHUDWidget
{
  public bool bExplainUsed;
}

public class USFGFxHUDWidget_StagePanel : USFGFxHUDWidget
{
  public float PendingBriefTime;
  public int PrevPlayedRound;
  public int CountDownTime;
  public bool bShowRoundEnd;
  public bool bShowTeamChanging;
  public bool bShowRoundBrief;
  public List<string> IgnoreShowEndRoundGameMode;
}

public class USFGFxHUDWidget_SuperLandingDelay : USFGFxHUDWidget
{
  public bool bShowSuperLandingDelay;
  public string SuperLandingDelayMessage;
}

public class USFGFxHUDWidget_SurvivalBuffInfo : USFGFxHUDWidget
{
  public int SeeThroughID;
  public string SeeThroughImgSet;
  public string SeeThroughName;
  public float fCurSeeThroughTime;
  public float fFininshSeeThroughTime;
}

public class USFGFxHUDWidget_SurvivalModeInfo : USFGFxHUDWidget
{
  public int LastWave;
}

public class USFGFxHUDWidget_SurvivalResult : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_SurvivalSupressor : USFGFxHUDWidget
{
  public int MaxHealth;
  public int PrevHealth;
  public ASFPrimaryTargetActor CurrentSupressor;
  public string strSupressorName;
}

public class USFGFxHUDWidget_SurvivalSupressorProgress : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_SurvivalWaveSpeed : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_TargetScore : USFGFxHUDWidget
{
  public class FGFxTargetScoreInfo
  {
    public UGFxObject MovieClip;
    public int Index;
    public UObject.FVector Location;
    public bool bUse;
    public int Score;
    public float CallTime;
  }

  public int PlusHeight;
  public List<FGFxTargetScoreInfo> GFxTargetScoreList;
  public int GFxTargetScoreUsedIndex;
  public int UniqueIndex;
  public int ArrayPosition;
  public int AniIndex;
  public int TargetScore;
  public FScriptDelegate __OnCreateTargetScoreDelegate__Delegate;
}

public class USFGFxHUDWidget_ThrIndicator : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_Timer : USFGFxHUDWidget
{
  public class FTimerTypeInfo
  {
    public string ObjectName;
    public string TextFiled;
    public UGFxObject MovieClip;
  }

  public class FTimerInfo
  {
    public string Color;
    public int LowTime;
    public int HighTime;
    public string GameModeClassName;
  }

  public FTimerTypeInfo[] TimerTypeData = new FTimerTypeInfo[3];
  public bool bIsCountUpdate;
  public bool bIsCentisecond;
  public float fNowTime;
  public float fTimeLimit;
  public float fReverceCentisecond;
  public float fUpdateCentiLimit;
  public int nCount;
  public int nOldCount;
  public string strCentisecond;
  public string CountColor;
  public float fCentisecondTimeLimit;
  public List<FTimerInfo> TimerInfoArray;
}

public class USFGFxHUDWidget_TwichTV : USFGFxHUDWidget
{
  public string TwitchTVOnMessage;
}

public class USFGFxHUDWidget_UserCondition : USFGFxHUDWidget
{
  public bool bShowUserCondition;
  public float ConditionIconRange;
}

public class USFGFxHUDWidget_UserCount : USFGFxHUDWidget
{
  public int[] UserCount = new int[8];
}

public class USFGFxHUDWidget_VideoRec : USFGFxHUDWidget
{
}

public class USFGFxHUDWidget_VoteKick : USFGFxHUDWidget
{
  public string CoolTimeMessage;
  public string VoteAcceptMessage;
  public string VoteDenyMessage;
  public string VoteKickResultMessage;
  public string VoteKickResultYesMessage;
  public string VoteKickResultNoMessage;
  public string VoteKickResultIgnoreMessage;
}

public class USFGFxHUDWidget_WarriorModeInfo : USFGFxHUDWidget
{
  public int PrevMyScore;
  public int PrevOtherScore;
}

public class USFGFxHUDWidget_WarriorMoneyInfo : USFGFxHUDWidget_SurvivalMoneyInfo
{
}

public class USFGFxHUDWidget_WarriorUserList : USFGFxHUDWidget_SurvivalUserList
{
  public class FSUIModePlayerInfo
  {
    public int PlayerID;
    public string Emblem;
    public string CodeName;
    public int ModeLevel;
    public int Health;
    public int MaxHealth;
    public int AttackPoint;
    public int DefencePoint;
    public int MovePoint;
    public int Exp;
    public int TotalExp;
    public float ElapsedRespawnDelay;
    public float TotalRespawnDelay;
    public float LastCheckedTime;
  }

  public List<FSUIModePlayerInfo> ModePlayerInfoList;
}

public class USFGFxHUDWidget_ZombieHideSeekCount : USFGFxHUDWidget
{
  public int BlueCount;
  public int RedCount;
  public int RedAICount;
}

public class USFGFxHudWidget_ZombieHideSeekHelp : USFGFxHUDWidget
{
  public bool bExplainUsed;
  public List<string> ExplainPage;
}

public class USFGFxHUDWidget_ZombieHideSeekModeInfo : USFGFxHUDWidget
{
  public int PrevMyScore;
  public int PrevOtherScore;
  public int FeverTimeGauge;
  public ASFZombieHideSeekGameReplicationInfo ZombieHideSeekGRI;
}

public class USFGFxLobby : USFGFxMoviePlayer
{
  public class FSFViewInfo
  {
    public FName ViewName;
    public string SWFName;
    public int Depth;
  }

  public class FSPendingView
  {
    public FName ViewName;
    public USFGFxUIView View;
    public int OtherViewIndex;
    public bool bIsASOpened;
    public bool bIsScreen;
  }

  public class FsRepairReserved
  {
    public ulong ItemSN;
    public float Dur;
    public float DurMax;
    public int NeedSp;
  }

  public List<FSFViewInfo> ViewData;
  public UGFxObject RootMC;
  public UGFxObject ManagerMC;
  public bool bInitialized;
  public bool UseLowGoreForGameMaster;
  public bool bEnableLanguageBar;
  public bool bShowLanguageBarWithFocus;
  public bool bShowUSNWaitingRoom;
  public bool bEnablePersonalGameExit;
  public bool UseNetmarbleCoupon;
  public bool bSeasonDecoAni;
  public bool bChannelRelogin;
  public bool bChannelReloginInitGift;
  public bool bPendingCashCharge;
  public bool bTPNoticeActivate;
  public bool bPlayingIntroVideo;
  public bool bIsFolderSelectClicked;
  public bool bOnOKGameClosed;
  public bool IsFiringRangeVisible;
  public bool IsBattlePassVisible;
  public List<USFGFxLobbyScreen> LobbyScreenArray;
  public USFGFxLobbyScreen ActiveLobbyScreen;
  public int PrevWidgetIndex;
  public int WidgetInitializedCount;
  public USFGFxLobby_Login LoginManager;
  public USFGFxLobby_Navi NaviManager;
  public USFGFxLobby_MessengerBuddyList MsgrBuddyList;
  public USFGFxLobby_MsgrChatting MsgrChatting;
  public USFGFxLobby_NotifyWindow NotifyWindow;
  public USFGFxLobby_PurchaseGuide PurchaseGuide;
  public USFGFxLobbyScreenEx SideBackground;
  public USFGFxLobby_GachaRoll GachaRoll;
  public List<USFGFxDialog> LobbyDialogArray;
  public List<USFGFxDialog> OpenDialogArray;
  public USFGFxDialog_SystemMessage SystemNoticeDlg;
  public USFGFxDialog_Following FollowingDlg;
  public USFGFxDialog_WaitingAck WaitingAckDialog;
  public USFGFxDialog_WaitingAck WaitingChangeObjDialog;
  public ELobbyScreen LoginViewType;
  public ELobbyScreen ForceScreenIndex;
  public List<FSPendingView> PendingOpenScreenArray;
  public List<FSPendingView> PendingCloseScreenArray;
  public List<FSPendingView> PendingOpenDialogArray;
  public List<FSPendingView> PendingCloseDialogArray;
  public List<FSPendingView> PendingScreenExArray;
  public int SeasonIndex;
  public ASFPawn_Lobby statPawnOriginal;
  public ASFPawn_Lobby statPawnResult;
  public USceneCapture2DComponent CharCaptureComponent;
  public ACameraActor CharCameraActor;
  public int ItemTag_NEW;
  public int ItemTag_Best;
  public int ItemTag_HOT;
  public int ItemTag_EVENT;
  public int ItemTag_PC;
  public int ItemTag_CASH;
  public int ItemTag_VIP;
  public int ItemTag_MonthlyReward;
  public int ItemTag_Discount;
  public int ItemTag_GashaRareWeapon;
  public int ItemTag_FEVER;
  public FsRepairReserved RepairReserved;
  public List<FsRepairReserved> RepairReserveds;
  public string UnablebuyCauseCashString;
  public string[] RepairQuestings = new string[10];
  public string SuccessSendGiftMessage;
  public string SuccessAllApplyPartsMessage;
  public List<int> ProtocolAtChatMsgArray;
  public USFGFxMoviePlayer_RankMark RankMark;
  public USFGFxMoviePlayer_ClanMark ClanMark;
  public UGFxObject _global;
  public List<USFGFxLobbyScreenEx> LobbyScreenExArray;
  public USFItemManager ItemManager;
  public USFEmblemManager EmblemManager;
  public string DefaultScreenShotsPath;
  public string DefaultRecordPath;
  public USFTypes.FSRepairDialogInfo RepairDialogInfo;
  public USFTypes.FSRepairAllDialogInfo RepairAllDialogInfo;
  public int ForcedMainTabIndex;
  public string Message_FacebookInterlocked;
  public string Message_FacebookInterlockedWithSP;
  public List<int> CacheWeaponItemArray;
  public FName LobbyBGM;
  public FVector OriginalCameraLoc;
  public FVector CameraOffset;
  public List<USFTypes.FSRecvPacketHandler> RecvPacketHandlerArray;
  public FScriptDelegate __OnPacketRecv__Delegate;
  public FScriptDelegate __ViewDataSortByDepth__Delegate;
  public FScriptDelegate __OnAnimEndDelegate__Delegate;
  public FScriptDelegate __OnClickUserSlotDelegate__Delegate;
  public FScriptDelegate __OnClickUserPopUpMenuDelegate__Delegate;
  public FScriptDelegate __OnPlayerRowRollOverDelegate__Delegate;
  public FScriptDelegate __OnPlayerRowRollOutDelegate__Delegate;
  public FScriptDelegate __OnADImageBtnClickDelegate__Delegate;
  public FScriptDelegate __OnCloseChangeRoomNameDelegate__Delegate;
  public FScriptDelegate __OnRoomListClickHeaderBtnDelegate__Delegate;
  public FScriptDelegate __OnClickTPNoticeDelegate__Delegate;
  public FScriptDelegate __OnClickTPNoticeAtNaviDelegate__Delegate;
  public FScriptDelegate __OnClickBtnUseExtraRewardCoinDelegate__Delegate;
  public FScriptDelegate __OnClickExtraRewardCardDelegate__Delegate;
  public FScriptDelegate __OnClickMiniGachaDelegate__Delegate;
  public FScriptDelegate __OnFinishChoiceExtraRewardAnimationDelegate__Delegate;
  public FScriptDelegate __OnSubmitAreaSelectDelegate__Delegate;
  public FScriptDelegate __OnHelpGuidesDoubleClickDelegate__Delegate;
  public FScriptDelegate __OnClickBtnChangeEmblemDelegate__Delegate;
  public FScriptDelegate __OnClickAddtoBuddyDelegate__Delegate;
}

public class USFGFxLobbyScreen : USFGFxUIView
{
  public int BackStepPriority;
  public int FixedBackStepWidgetIndex;
  public bool bGFxPopUpOpened;
  public bool bDisableInGameEvent;
  public bool bEnableChangeTPBtn;
  public bool bShowTPNoticeMessage;
  public bool bFocusInImageArea;
  public bool bProcessNewItemTable;
  public bool bShowingWeaponPerformGraph;
  public bool bIsIgnoreEventClicked;
  public string AmmoDispString;
  public string SnowModeAmmoDispString;
  public string AmmoMagazineUpDispString;
  public string ItemOutDateMsg;
  public string ItemDurabilityOutMsg;
  public string[] OutFromRoomMessage = new string[9];
  public string QuestionMiniGameStart;
  public string strQuickJoinFailedMessage;
  public string strOpenSoloLeagueFailedmessage;
  public UGFxClikWidget PartyBoardWaitingMC;
  public UGFxClikWidget PartyBoardPlayingMC;
  public UGFxClikWidget btnChangeTP;
  public UGFxClikWidget ImageAreaBtn;
  public int nTPNoticeDays;
  public float fTPNoticeDurationTime;
  public string strTPNoticeMessage;
  public List<int> GameModeIDArray;
  public string LobbyBackGroundImageName;
  public UTexture2D LobbyBackGroundTexture;
  public int RollingImageTime;
  public string PendingOpenURL;
  public string OpenURLMessage;
  public List<int> CacheCharacterItemArray;
  public int SHOP_ITEM_SUBTAB_NORMAL;
  public int SHOP_ITEM_SUBTAB_STANDARD;
  public int SHOP_ITEM_SUBTAB_CAMO;
  public int SHOP_ITEM_SUBTAB_SPRAY;
  public int SHOP_ITEM_SUBTAB_PMC;
  public string strTopTile;
  public FScriptDelegate __OnMainTapClickedDelegate__Delegate;
  public FScriptDelegate __OnSubTapClickedDelegate__Delegate;
}

public class USFGFxLobby_Album : USFGFxLobbyScreen
{
  public List<USFTypes.FSFUITabList> DefaultMainTabList;
}

public class USFGFxLobby_BaseRoom : USFGFxLobbyScreen
{
  public UGFxClikWidget StartBtn;
  public UGFxClikWidget ReadyBtn;
  public UGFxClikWidget ReadyCompleteBtn;
  public UGFxClikWidget MemberList;
  public UGFxClikWidget MemberListNoTeam;
  public UGFxClikWidget CustomModeApplyBtn;
  public UGFxClikWidget CustomModeCancelBtn;
  public UGFxClikWidget modeTileList;
  public UGFxClikWidget mapTileList;
  public UGFxClikWidget roundTileList;
  public UGFxClikWidget pointTileList;
  public UGFxClikWidget playerTileList;
  public UGFxClikWidget playerTileListDeathGame;
  public UGFxClikWidget CustomTileList;
  public UGFxClikWidget ModeListCB;
  public UGFxClikWidget MapListCB;
  public UGFxClikWidget WinRoundCB;
  public UGFxClikWidget PlayerCountCB;
  public UGFxClikWidget optionSelectCB;
  public UGFxClikWidget RoomCB;
  public UGFxClikWidget CustomCB;
  public UGFxClikWidget TeamBalanceTxt;
  public UGFxClikWidget TeamSwitchBtn;
  public UGFxClikWidget TitleChangedCheckBtn;
  public UGFxClikWidget TopTitle;
  public UGFxClikWidget inputRoomTitle;
  public USFGFxClickWidget_NumericOnly inputPassword;
  public UGFxObject _globalEX;
  public int UserSelectedPopupIndex;
  public bool bComboBoxItemSelect;
  public bool InitRoomOption;
  public bool StartGameButtonOld;
  public bool bInCountDown;
  public bool StartButtonEnableStat;
  public bool bStartButtonBlurLast;
  public bool bBtnStartPressed;
  public bool bClientSideTeamBalance;
  public int PreWeaponTypeMode;
  public int WeaponTypeMode;
  public int PickUpWeapon;
  public int PrePickUpWeapon;
  public string CustomModeName;
  public int CountDownMax;
  public string RoundString;
  public string PointString;
  public string TimeString;
  public string MatchConditionString;
  public string MatchRoundString;
  public string MatchPointString;
  public string MatchTimeLimitString;
  public string strIntrusionGoal;
  public string Versus;
  public string VersusDeathGame;
  public string ModeChangeFailWithNumPlayers;
  public List<string> RoomUserStatusMessage;
  public string TeamBalanceOnMessage;
  public string TeamSwitchString;
  public string NoChangeRoomSettingInProgress;
  public string AutoHandoverHostbyNoInputMessage;
  public string AutoHandoverHostbyNoInputChat;
  public string MapListVipNone;
  public int CountDown;
  public int SelectedUserSN;
  public int SelectedClanSN;
  public int PrevSelectedGameModeID;
  public ERoomType RoomType;
  public ELobbyDialog ResultDialogType;
  public List<USFTypes.FsBuddyPopup> UserPopups;
  public List<int> UserPopupExec;
  public string ApplicationMessage;
  public string CountDownAborted;
  public string CountDownEndGameStart;
  public string IntrusionCheckByScoreMessage;
  public List<string> CannotStartgameMsg;
  public List<string> CannotStartgameMsgtoGuest;
  public string NoticeAllReadyHandOverMsg;
  public string NoticeAllReadyNoHandOverMsg;
  public string TakeoverHostMessage;
  public string AutoHandoverHostbyTimeoutMessage;
  public string AutoHandoverHostbyTimeoutChat;
  public int WantViewIDCardIdx;
  public int RolloverSlotIdx;
  public float ViewIDCardTimer;
  public float TimeHandOverbyAllReady;
  public List<string> PlayClickSoundEvents;
  public string StartButtonLabel;
  public int WeaponIDSnowBall;
  public List<int> DisplayGameModeList;
  public List<USFUIDataStore_RoomSetting.FSCustomModeButton> CustomModeListBT;
  public FScriptDelegate __SelectedModeUI__Delegate;
  public FScriptDelegate __CustomModeDialogClose__Delegate;
  public FScriptDelegate __CustomModeBtn__Delegate;
  public FScriptDelegate __DoubleClickSelectedModeUI__Delegate;
  public FScriptDelegate __OnPlayClickSoundDelegate__Delegate;
  public FScriptDelegate __ModeOptionData__Delegate;
  public FScriptDelegate __PickUpWeaponOptionData__Delegate;
}

public class USFUIDataStore_RoomList : USFUIDataStoreBase
{
  public class FSRoomListInfo
  {
    public byte nIsLocked;
    public string strDiff;
    public int nNumber;
    public byte RoomType;
    public string strRoomName;
    public byte nGameModeID;
    public byte nMapId;
    public byte nNowPlayers;
    public byte nMaxPlayers;
    public byte nPing;
    public byte nRoomState;
    public byte nAllowIntrude;
    public byte nRoundCount;
    public byte AIDifficulty;
    public int TimeLimit;
    public byte VipGrade;
    public byte MonthlyRewardGrade;
    public bool bIsDisableGame;
    public bool bQuckPlayEnable;
    public byte CustomWeaponType;
    public byte PickUpWeapon;
  }

  public class FSMatchingRoom
  {
    public byte GameModeID;
    public int WaitingRoomCount;
    public int PlayingRoomCount;
  }

  public List<FSRoomListInfo> RoomListInfoArray;
  public int RecvRoomListCount;
  public int CurRoomListCount;
  public int RecvMatchingRoomCount;
  public int CurMatchingRoomCount;
  public List<FSMatchingRoom> MatchingRoomArray;
  public List<USFUIDataProvider_MapInfo> SupportMapList;
  public List<int> CustomMapOrderList;
  public bool bAscending_Number;
  public bool bAscending_Name;
  public bool bAscending_State;
  public bool bAscending_Players;
  public bool RecvRoomRemove;
  public int PlayedRoomNumber;
  public int RecvRoomIndex;
  public FScriptDelegate __RoomListSortByModeIDDelegate__Delegate;
  public FScriptDelegate __SortByModeIDDelegate__Delegate;
  public FScriptDelegate __RoomListSortByMapIDDelegate__Delegate;
  public FScriptDelegate __SortByMapIDDelegate__Delegate;
}

public class USFGFxLobby_BaseRoomList : USFGFxLobbyScreen
{
  public UGFxClikWidget RoomListMC;
  public UGFxClikWidget btnQuick;
  public UGFxClikWidget btnRoomMake;
  public UGFxClikWidget btnJoin;
  public UGFxClikWidget headMode;
  public UGFxClikWidget headMap;
  public UGFxClikWidget TopTitle;
  public USFGFxDialog_Password PasswordDialog;
  public int SelectedRoomIndex;
  public bool bComboListEditing;
  public bool bListTestSw;
  public bool bOpenWebConfirm;
  public ERoomSort CurrentSortType;
  public int CurrentSortKey;
  public int nMaxListforDebug;
  public int nADImageIndex;
  public string ADImageURL;
  public string RoomPasswordMessage;
  public string strRoomStateWaiting;
  public string strRoomStatePlaying;
  public string LocalCustomModeText;
  public List<string> RoomFrontName;
  public string RoomListBingingName;
  public string ConnectPassword;
  public List<USFTypes.FSQuickJoin> CurQuickJoinConditionArray;
}

public class USFGFxLobby_BattlePass : USFGFxLobbyScreen
{
  public UGFxClikWidget TrainingMapList;
  public UGFxObject _global;
  public UGFxClikWidget btnBPEvent;
  public bool bStartClick;
  public FScriptDelegate __OnClickBPMapDubbleClickDelegate__Delegate;
  public FScriptDelegate __OnClickBPSelectMapDelegate__Delegate;
}

public class USFGFxLobby_ChannelList : USFGFxLobbyScreen
{
  public class FSUIChannelInfo
  {
    public string Flag;
    public string No;
    public string ChannelName;
    public string StatBarNo;
    public string ToolTip;
    public string GradeColor;
    public string IsFull;
    public int FriendNum;
    public int ClanNum;
  }

  public UGFxClikWidget QuickStart;
  public List<UGFxClikWidget> ChannelBtn;
  public UGFxClikWidget ChannelList;
  public UGFxClikWidget ChannelList_Ad;
  public USFTypes.FSChannelSetting SelectedChannel;
  public int SelectedChannelIndex;
  public int MaxChannelIndex;
  public string SeparationBaseString;
  public List<string> CannotConnecttoChannel;
  public string BuddyFriendNumMessage;
  public string BuddyClanNumMessage;
  public List<USFTypes.FSChannelFillInfo> ChannelFillInfoArray;
  public bool IsForceUsingTutorial;
  public bool bRequestLogOut;
  public bool bChannelGraduate;
  public bool bUseADMode;
  public bool bOpenWebConfirm;
  public ESFUIDataProviderType StartTutorialType;
  public string PendingServerIP;
  public int PendingServerPort;
  public int ChannelListADImageIndex;
  public FScriptDelegate __OnClickADTabBtnDelegate__Delegate;
}

public class USFGFxLobby_ChannelRenweal : USFGFxLobbyScreen
{
  public class FSUIChannelInfo
  {
    public string Flag;
    public string No;
    public string ChannelName;
    public string StatBarNo;
    public string ToolTip;
    public string GradeColor;
    public string IsFull;
    public int FriendNum;
    public int ClanNum;
  }

  public UGFxClikWidget QuickStart;
  public UGFxClikWidget ChannelList;
  public UGFxClikWidget ChannelList_Ad;
  public USFTypes.FSChannelSetting SelectedChannel;
  public int SelectedChannelIndex;
  public int MaxChannelIndex;
  public string SeparationBaseString;
  public List<string> CannotConnecttoChannel;
  public string BuddyFriendNumMessage;
  public string BuddyClanNumMessage;
  public List<USFTypes.FSChannelFillInfo> ChannelFillInfoArray;
  public bool IsForceUsingTutorial;
  public bool bRequestLogOut;
  public bool bChannelGraduate;
  public bool bUseADMode;
  public bool bOpenWebConfirm;
  public ESFUIDataProviderType StartTutorialType;
  public string PendingServerIP;
  public int PendingServerPort;
  public int ChannelListADImageIndex;
  public UGFxClikWidget ChannelLeftTabList;
  public UGFxClikWidget ChannelMainTabList;
  public FScriptDelegate __OnClickADTabBtnDelegate__Delegate;
}

public class USFGFxLobby_LoginView : USFGFxLobbyScreen
{
  public UGFxClikWidget IDTextInput;
  public UGFxClikWidget PWTextInput;
  public UGFxObject IDTextField;
  public UGFxObject PWTextField;
  public UGFxClikWidget btnOk;
  public UGFxClikWidget btnCancel;
  public UGFxClikWidget btnWebJoin;
  public string InputIDMessage;
  public string InputPWMessage;
  public string strBIPath;
  public bool IsWebLogin;
  public bool IsFirstInputTextENG;
  public bool bRememberID;
  public bool bCheckRememberID;
  public bool bCheckShowPW;
  public bool bShowPW;
  public string WebAddressURL;
  public string RememberIDFilePath;
  public UGFxClikWidget chkRememberID;
  public UGFxClikWidget chkShowPW;
}

public class USFGFxLobby_CHNLoginView : USFGFxLobby_LoginView
{
  public eCHNModuleState ModuleState;
  public bool IsFirstCheck;
}

public class USFGFxLobby_Clan : USFGFxLobbyScreen
{
  public UGFxClikWidget SubTabBtnMC;
  public List<USFTypes.FSFUITabList> DefaultMainTabList;
  public bool bUITabInitialized;
}

public class USFGFxLobby_ClanBase : USFGFxLobbyScreen
{
  public string YearLocalized;
  public string MonthLocalized;
  public string DayLocalized;
  public List<string> JoinDlgQuestion;
  public string strJoinCSN;
  public string strJoinClanName;
}

public class USFGFxLobby_ClanLeague : USFGFxLobby_ClanBase
{
  public UGFxClikWidget[] MainBtn = new UGFxClikWidget[5];
  public UGFxClikWidget[] SubBtn = new UGFxClikWidget[2];
  public UGFxClikWidget ClanJoinBtn;
  public UGFxClikWidget ListMoreBtn;
  public UGFxClikWidget MemberInfoListMoreBtn;
  public UGFxClikWidget SeasonComboBox;
  public UGFxClikWidget ClanRankList;
  public UGFxObject ClanMemberRankList;
  public UGFxObject PersonalRankList;
  public UGFxClikWidget ClanLeagueSearchBtn;
  public UGFxClikWidget SearchInputWidget;
  public UGFxClikWidget ClanLeagueCloseBtn;
  public EClanLeagueMainTab SelectMainTabType;
  public EClanLeagueSubTab SelectSubTabType;
  public int NowShowListType;
  public int BottomADImageIndex;
  public string TopADImgPath;
  public string SelectedSeasonDate;
  public string SearchText;
  public string PreSearchText;
  public string ClanJoinMsg;
  public string HaveNoLeagueDataMsg;
  public string SeasonComboBoxLabel;
  public string SearchResultNoDataMsg;
  public string ClanJoinBtnLabel;
  public string SearchResultNoDataBtnLabel;
  public float PreTickTime;
  public FScriptDelegate __OnClickADTabBtnDelegate__Delegate;
}

public class USFGFXLobby_Combine : USFGFxLobbyScreen
{
  public class FCombineData
  {
    public string Name;
    public string Count;
    public string Icon;
    public string Check;
    public string ToolTip;
  }

  public class FCombineIconData
  {
    public int Type;
    public string Name;
    public string Icon;
  }

  public int CombineCheckOK;
  public int CombineCheckNO;
  public int CombineResult;
  public int PartsTypeCount;
  public List<FCombineIconData> CombineIconArray;
  public List<USFTypes.FSFUITabList> DefaultMainTabList;
  public List<USFUIDataStore_ItemList.FCombineDesignInfo> TempCombineDesignList;
  public string CountTextOK;
  public string CountTextNO;
  public string ContentTextBlank;
  public bool IsCombineActivate;
  public bool IsOpenDialog;
  public ECombineDialogState DialogState;
  public FScriptDelegate __OnCombineMainTabClickedDelegate__Delegate;
  public FScriptDelegate __OnCombineWeaponListClickedDelegate__Delegate;
  public FScriptDelegate __OnCombineStartDelegate__Delegate;
  public FScriptDelegate __OnCombineOpenPopupDelegate__Delegate;
  public FScriptDelegate __OnCombineClosePopupDelegate__Delegate;
  public FScriptDelegate __OnCombineCompleteDelegate__Delegate;
}

public class USFGFxLobby_Community : USFGFxLobbyScreen
{
  public List<string> NoBuddyMessageArray;
}

public class USFGFxLobby_CreateCharacter : USFGFxLobbyScreen
{
  public class FsCreateableItemList
  {
    public int Id;
    public bool Lock;
  }

  public UGFxClikWidget charUnitList;
  public UGFxClikWidget charWeaponList;
  public UGFxClikWidget btnMakeChar;
  public List<FsCreateableItemList> UnitArray;
  public List<int> WeaponArray;
  public int DefaultUnitItemID;
  public string QuestionCharacterCreate;
  public string CreatedEventBottom;
  public int UnitNum;
  public int WeaponNum;
  public bool UnitSelected;
  public bool WeaponSelected;
  public bool bWatingCreateEnd;
  public bool UseTagSystem;
  public string NoneUnitString;
  public string RecvCodeName;
}

public class USFGFxLobby_CreateCodeName : USFGFxLobbyScreen
{
  public UGFxClikWidget txtCreateNo;
  public UGFxObject makeCodeWidget;
  public string QuestionCodeNameRegist;
  public string CheckingCodename;
  public string ReservedCodename;
  public int RegistButtonTypeNow;
  public int nCreateCodenameStep;
  public USFGFxMoviePlayer_Dogtag DogtagMoviePlayer;
  public USwfMovie DogtagMovie;
  public UTextureRenderTarget2D DogtagRenderTexture;
  public FScriptDelegate __SetCodeName__Delegate;
  public FScriptDelegate __OnCodeNameBtnRegist__Delegate;
}

public class USFGFxLobby_GameModeBase : USFGFxLobbyScreen
{
  public UGFxClikWidget ModeListMC;
  public UGFxClikWidget TopTitle;
  public int SelectedModeIndex;
  public UGFxObject _global;
  public int WeaponTypeMode;
  public string CustomModeName;
}

public class USFGFxLobby_CreateRoom : USFGFxLobby_GameModeBase
{
  public UGFxClikWidget inputRoomTitle;
  public USFGFxClickWidget_NumericOnly inputPassword;
  public UGFxObject inputRoomText;
  public UGFxObject inputPasswordText;
  public string strInputPassword;
  public int PreWeaponTypeMode;
  public UGFxClikWidget LeftModeTab;
  public UGFxClikWidget CustomModeDropBox;
  public UGFxClikWidget CreateRoomModeList;
  public UGFxClikWidget CreateRoomBtn;
  public List<string> ModeNameListArray;
  public int PrevLeftSelectedTab;
  public List<string> DisableCustomModeApplyBtnModeName;
  public List<int> RotationGameModeIDArray;
  public FScriptDelegate __OnClickLeftTabDelegate__Delegate;
  public FScriptDelegate __OnClickModeListDelegate__Delegate;
}

public class USFGFXLobby_Enchant : USFGFxLobbyScreen
{
  public UGFxClikWidget btnItemSearch;
  public UGFxClikWidget ItemSearchInputWidget;
  public UGFxClikWidget btnExtractOK;
  public UGFxClikWidget btnPartOk;
  public UGFxClikWidget BuySPPartsBtn;
  public UGFxClikWidget BuyCashPartsBtn;
  public UGFxClikWidget UpgradeBtn;
  public UGFxClikWidget PageWeapoonList;
  public UGFxClikWidget EnchantDesignTree;
  public UGFxClikWidget BaseItemPage;
  public List<FSDisplayItem> DisplayItems;
  public UGFxObject ItemProvider;
  public int PageItemDisplayCount;
  public int CurrentPageIndex;
  public int MaxPageCount;
  public int PositionalNum;
  public int CurrentDesignID;
  public ulong SelectedItemSN;
  public int SelectedBaseItemID;
  public List<FSDisplayItem> SelectedItemList;
  public int MaxMultiSelectItemCount;
  public bool bShowBaseItemInInventory;
  public bool bCurrentExtractState;
  public bool bNowAnimationPlay;
  public bool bVisibleEnchantWeaponInfo;
  public USFGFxDialog_BuyOne BuyOneDlg;
  public int CurrentPurchasePartsID;
  public List<USFUIDataStore_Enchant.FDetailItem> ExtractInfoList;
  public float PartsWarningRate;
  public string MaxPartsEarnWarning;
  public string MaxPartsPurchaseWarning;
  public string ItemExtractWarning;
  public string ImportantItemExtractWarning;
  public string MainItemExtractWarning;
  public string EquipNoticeString;
  public string EnchanttipString;
  public string DesignNoticeString;
  public string DisableEnchantNeedsMorePartsString;
  public string DisableEnchantNeedsBaseItemString;
  public FScriptDelegate __delegatePressFunc__Delegate;
}

public class USFGFxLobby_FeverTime : USFGFxLobbyScreen
{
  public class FSFeverDisplayItem
  {
    public List<int> FeverItemIDArray;
    public int Group;
  }

  public List<FSFeverDisplayItem> FeverDisplayItem;
  public UGFxClikWidget[] MainBtn = new UGFxClikWidget[4];
  public UGFxClikWidget[] SubBtn = new UGFxClikWidget[2];
  public UGFxClikWidget FeverOrgelBtn;
  public UGFxClikWidget FeverSaleBtn;
  public UGFxClikWidget FeverRewardList;
  public UGFxClikWidget FeverCloseBtn;
  public EFeverTimeMainTab SelectMainTabType;
  public EFeverTimeSubTab SelectSubTabType;
  public int CrrentDisplayType;
  public bool bEnableFeverSystem;
  public List<string> strFeverRewardGrade;
  public string AcquireTooltipMsg;
  public FScriptDelegate __OnClickFeverRewardAcceptBtnDelegate__Delegate;
  public FScriptDelegate __FeverLpRewardItemSortByGroup__Delegate;
}

public class USFGFxLobbyScreenEx : USFGFxLobbyScreen
{
}

public class USFGFxLobby_GachaRoll : USFGFxLobbyScreenEx
{
  public string GachaRollText;
  public bool bUseGachaRoll;
  public int GachaRollTimeInterval;
  public string GachaRollItemTextFormat;
  public string GachaRollFeverActiveTextFormat;
}

public class USFGFxLobby_GashaBase : USFGFxLobbyScreen
{
  public bool bUseGachaBonusGauge;
  public string GachaBonusGaugeBtnText;
  public string GachaBonusGaugeCountText;
  public UGFxClikWidget btnBonusReward;
}

public class USFGFxLobby_GashaOrgelBox : USFGFxLobby_GashaBase
{
  public class FsOrgelBtnInfo
  {
    public List<USFGameItem.FSFItemData> ItemDataArray;
    public List<int> CouponCountArray;
    public List<int> BonusCouponCountArray;
  }

  public class FsCapsuleCommenctInfo
  {
    public bool bIsBlink;
    public int Percent;
    public string Message;
  }

  public int SelectBtnIndex;
  public int GashaVipListMax;
  public int SendCapsuleID;
  public string SendCapsuleSupplyCode;
  public int EnterEventType;
  public bool bIsDisableExit;
  public bool bIsOpeningAniEnd;
  public bool bIsPushCloseBtn;
  public bool bAllBtnDisable;
  public bool bVIPListViewGashaName;
  public bool bVIPListNonConvertUserName;
  public bool bIsDisableCapsuleComment;
  public bool bUseRareWeaponCutscene;
  public bool bUseRarePMCCutscene;
  public UGFxClikWidget RewardItemList;
  public UGFxClikWidget GashaVipList;
  public UGFxClikWidget GashaPVEVipList;
  public UGFxClikWidget GetRewardOkBtn;
  public UGFxClikWidget BtnCutOK;
  public int JoinLimitSP;
  public float UnderSpMsgTime;
  public int PlayForceGarbageMax;
  public string ConvertDirection;
  public int ConvertByteCount;
  public string ConvertBtnCouponCountType;
  public string ConvertText;
  public string LimitUnderSpMsg;
  public List<string> DevelopToolTipArray;
  public List<FsCapsuleCommenctInfo> OpneCapsuleCommnetArray;
  public string NoRewardItemErrorMsg;
  public FsOrgelBtnInfo BtnInfoArray;
  public USFGFxDialog_BuyOne BuyOneDlg;
  public FName SoundEventName;
  public int ExitCount;
  public int PlayForceGarbageCount;
  public int SelectedItemID;
  public int CutScenePMCID;
  public int CutSceneWeaponID;
  public FScriptDelegate __OnClickBtnsDelegate__Delegate;
  public FScriptDelegate __OnClickCloseBtnDelegate__Delegate;
  public FScriptDelegate __OnClickGashaOpenBtnDelegate__Delegate;
  public FScriptDelegate __OnBoxCloseDelegate__Delegate;
  public FScriptDelegate __OnRefreshBtnInfoDelegate__Delegate;
  public FScriptDelegate __OnOpeningAnimationEndDelegate__Delegate;
  public FScriptDelegate __OnGashaBallAnimationEndDelegate__Delegate;
  public FScriptDelegate __OnEvnetCapsuleOpenBtnViewDelegate__Delegate;
  public FScriptDelegate __OnOverGashaBtnsDelegate__Delegate;
  public FScriptDelegate __OnOutGashaBtnsDelegate__Delegate;
  public FScriptDelegate __OnClickSaveGashaCapsuleDelegate__Delegate;
  public FScriptDelegate __OnClickSaveGashaCapsuleAnimationEndDelegate__Delegate;
  public FScriptDelegate __OnSkipBtnShowDelegate__Delegate;
  public FScriptDelegate __OnSound_Ball_startDelegate__Delegate;
  public FScriptDelegate __OnSound_Ball_railDelegate__Delegate;
  public FScriptDelegate __OnSound_Ball_bigDelegate__Delegate;
  public FScriptDelegate __OnSound_StopPlaySoundDelegate__Delegate;
}

public class USFGFxLobby_GashaPercent : USFGFxLobbyScreen
{
  public class FGashaCouponSubTabInfo
  {
    public string Label;
    public string Code;
  }

  public UGFxObject GashaPercentList;
  public UGFxClikWidget SeasonComboBox;
  public UGFxClikWidget GashaPercentCloseBtn;
  public UGFxClikWidget CWGashaPercentList;
  public string PermanentSellInfo;
  public List<FGashaCouponSubTabInfo> GashaCouponList;
}

public class USFGFxLobby_GashaSelect : USFGFxLobby_GashaBase
{
  public UGFxClikWidget JoinBtn;
  public UGFxClikWidget CashBtn;
  public UGFxClikWidget GashaItemList;
  public UGFxClikWidget GashaItemList_CHN;
  public UGFxClikWidget ToolTipItemLIst;
  public UGFxClikWidget AllInOneList;
  public UGFxClikWidget GiftBtn;
  public UGFxClikWidget ProbabilityNoticeBtn;
  public string ProbabilityNoticeURL;
  public bool bIsFirstActivated;
  public bool bIsSendGiveCapSuleItemPacket;
  public bool IsBigImageList;
  public int SelectedWeaponID;
  public int SelectedGashaIndex;
  public List<int> WeaponCamoMCItemArray;
  public int SelectGashaCouponItemID;
  public string ToolTipBonusGaugeMessage;
  public int PrevWidgetIndex;
  public int DisplayColSize;
  public int DisplayMinRowSize;
  public List<USFUIDataStore_GashaList.FGashaListInfo> DisplayViewGashaListArray;
  public List<UGFxObject> GachaListObjectArray;
  public FScriptDelegate __OnWeaponViewDelegate__Delegate;
  public FScriptDelegate __OnClickedGachaListDelegate__Delegate;
}

public class USFGFxLobby_Inventory : USFGFxLobbyScreen
{
  public UGFxClikWidget btnResell;
  public UGFxClikWidget btnItemSearch;
  public UGFxClikWidget ItemSearchInputWidget;
  public int SPperDuration;
  public bool IsResellBtnDisable;
  public bool bIsItemResellMode;
  public bool bUITabInitialized;
  public string ClanMasterItemUseFailedMessage;
  public string ClanManagerItemUseFailedMessage;
  public string ClanMemberItemUseFailedMessage;
  public List<USFTypes.FSFUITabList> DefaultMainTabList;
  public ulong GiftNSN;
  public FScriptDelegate __MainCategoryButtonDelegate__Delegate;
  public FScriptDelegate __OnItemRollOverDelegate__Delegate;
  public FScriptDelegate __OnItemRollOutDelegate__Delegate;
  public FScriptDelegate __OnInvenListClickedDelegate__Delegate;
  public FScriptDelegate __OnInvenWeaponListDblClickedDelegate__Delegate;
  public FScriptDelegate __OnInvenEquipListDblClickedDelegate__Delegate;
  public FScriptDelegate __OnInvenFuncListDblClickedDelegate__Delegate;
  public FScriptDelegate __UnitListButtonDelegate__Delegate;
  public FScriptDelegate __WeaponSetTypeDelegate__Delegate;
  public FScriptDelegate __WeaponSetButtonDelegate__Delegate;
  public FScriptDelegate __OnClickedEquipedThrowweaponDelegate__Delegate;
  public FScriptDelegate __OnClickedResellButtonDelegate__Delegate;
  public FScriptDelegate __OnClickedDeleteButtonDelegate__Delegate;
  public FScriptDelegate __WeaponListRepairButtonDelegate__Delegate;
  public FScriptDelegate __WeaponPartsButtonDelegate__Delegate;
  public FScriptDelegate __WeaponSetRepairButtonDelegate__Delegate;
  public FScriptDelegate __OnClickWeaponSetAllRepairDelegate__Delegate;
  public FScriptDelegate __OnInvenClickedItemUseDelegate__Delegate;
}

public class USFGFxLobby_LeagueMatch : USFGFxLobby_BaseRoomList
{
  public string strNeedLeagueMatchingTicket;
  public string strStartCountDownMessage;
  public List<string> CannotStartLeagueGameMsg;
  public int LeagueMatchingModeID;
  public int LeagueMatchingStartMaxCountDown;
  public int LeagueMatchingStartMesseageMaxCountDown;
  public int LeagueMatchingStartMinUserCount;
  public string LeagueMatchTimer;
  public bool bShowMatchingPopUp;
  public bool bStartMessageCountDown;
  public bool bStartMatching;
  public int LeagueTicketCount;
  public int LeagueMatchingStartMesseageCountDown;
  public int LeagueMatchingStartCountDown;
  public int LeagueMatchingTime;
  public UGFxClikWidget btnLeagueMatchingStart;
  public UGFxClikWidget btnLeagueMatchingStop;
  public UGFxClikWidget btnSoloLeagueNotice;
  public UGFxClikWidget btnSoloLeagueRank;
}

public class USFGFxLobby_Login : USFGFxLobbyScreen
{
  public class FExtraErrorCodeInfo
  {
    public int ErrorCode;
    public string msg;
  }

  public bool bDisableNewAccount;
  public bool bAuthLoginFromLoginView;
  public bool bVipInfoRequest;
  public bool bUseFirstBuySale;
  public bool IsMonthlyReward;
  public bool bEnableEnchantSystem;
  public bool bEnableRandomBox;
  public bool bEnableCombineSystem;
  public bool bEnableRecycleSystem;
  public bool bClanLeagueInfoRequest;
  public bool bSoloLeagueInfoRequest;
  public int DefaultScaleLevel;
  public List<string> LoginErrorCodeArray;
  public List<FExtraErrorCodeInfo> ExtraErrorCodeArray;
}

public class USFGFxLobby_LoginCHN : USFGFxLobby_Login
{
  public class FSAuthError
  {
    public string ErrorCode;
    public string ErrorMessage;
  }

  public bool NewModuleTest;
  public List<FSAuthError> AuthErrorCodeArray;
}

public class USFGFxLobby_LoginIDN : USFGFxLobby_Login
{
}

public class USFGFxLobby_LoginTHA : USFGFxLobby_Login
{
  public string LocalLoginParam;
}

public class USFGFxLobby_LoginTWN : USFGFxLobby_Login
{
}

public class USFGFxLobby_MessengerBuddyList : USFGFxLobbyScreenEx
{
  public class FsDebugCNList
  {
    public string Str;
    public int Ref;
  }

  public UGFxClikWidget btnPopSearch;
  public UGFxClikWidget listUsers;
  public UGFxClikWidget btnMini;
  public UGFxClikWidget btnMsnFriend;
  public UGFxClikWidget btnMsnAlert;
  public UGFxClikWidget btnMsnClan;
  public UGFxClikWidget btnBoxBuddyname;
  public UGFxClikWidget btnBoxUsername;
  public List<USFTypes.FsBuddyPopup> BuddyPopups;
  public List<string> MessengerNotice;
  public string NoticeInviteGameTitle;
  public string CounterOnlineBuddySrc;
  public string CounterOnlineClanSrc;
  public string MessengerBuddyCount;
  public string MessengerBuddyFacebookNameForm;
  public string EndWeeklyClanRankMessageTitle;
  public string EndWeeklyClanRankMessage;
  public string ClanRecommendMessage;
  public string ClanRecommendReceiveMessage;
  public int ErrorDlgDisplayTime;
  public bool bBuddyListActive;
  public bool bBuddyListAnim;
  public bool bBuddyAltPopShow;
  public bool bForceUpdatedBuddyLocation;
  public bool bForceUpdatedBuddyList;
  public bool IsWithBlock;
  public bool bShowMsgrNotice;
  public eOpendBuddyNotice nOpenedBuddyInputBox;
  public int DisplayingGroupSN;
  public int SelectedBuddyUSN;
  public List<int> BuddyPopupExecs;
  public List<FsDebugCNList> DebugCNLists;
  public string InputedCodename;
  public float fUpdateTimeBuddyLocationList;
  public int UseBuddyWithGameFunc;
  public FScriptDelegate __OnClickViewFriendsListDelegate__Delegate;
  public FScriptDelegate __OnClickViewClanMamberListDelegate__Delegate;
  public FScriptDelegate __OnAddFriendDelegate__Delegate;
  public FScriptDelegate __OnClickFindUserDelegate__Delegate;
  public FScriptDelegate __OnViewProfileDelegate__Delegate;
  public FScriptDelegate __OnOnCommonOkDelegate__Delegate;
  public FScriptDelegate __OnClickNoticeDelegate__Delegate;
  public FScriptDelegate __OnMessengerPopupAcceptDelegate__Delegate;
  public FScriptDelegate __OnMessengerPopupRefuseDelegate__Delegate;
  public FScriptDelegate __OnMessengerPopupMinDelegate__Delegate;
  public FScriptDelegate __OnClickFriendDelegate__Delegate;
  public FScriptDelegate __OnDoubleClickFriendDelegate__Delegate;
  public FScriptDelegate __OnClickPopupDelegate__Delegate;
  public FScriptDelegate __OnClickMinPopupDelegate__Delegate;
  public FScriptDelegate __OnRollOverFriendsListDelegate__Delegate;
  public FScriptDelegate __OnBuddylistOpenAnimEndDelegate__Delegate;
  public FScriptDelegate __OnBuddylistCloseAnimEndDelegate__Delegate;
  public FScriptDelegate __OnReciveInputCodenameDelegate__Delegate;
  public FScriptDelegate __OnFriendBlockCheckDelegate__Delegate;
  public FScriptDelegate __OnClickedDeleteDelegate__Delegate;
  public FScriptDelegate __OnClickedBlockDelegate__Delegate;
  public FScriptDelegate __OnClickedTalkDelegate__Delegate;
  public FScriptDelegate __OnClickedInviteGameDelegate__Delegate;
  public FScriptDelegate __OnAddedBuddyDelegate__Delegate;
  public FScriptDelegate __OnClickFollowDelegate__Delegate;
  public FScriptDelegate __OnClosedBuddyAltPopupDelegate__Delegate;
}

public class USFGFxLobby_MiniGame : USFGFxLobbyScreen
{
  public class FsMiniGameInfo
  {
    public ESFUIDataProviderType Type;
    public int ScoreGameModeID;
    public int BgType;
    public string strTitle;
    public string strContextTitle;
    public string strContext;
  }

  public class FsMapSelectInfo
  {
    public ESFUIDataProviderType Type;
    public int SelectMapIndex;
  }

  public class FSTutoBestScore
  {
    public byte MapID;
    public byte GameModeID;
    public int PlayingTime;
    public int ScorePoint;
    public string RecTime;
    public string MiniGameForMatRecTime;
  }

  public class FsFiringRangeScoreTabInfo
  {
    public byte WeaponType;
    public byte Code;
    public string Label;
    public string IconImg;
  }

  public UGFxClikWidget StartBtn;
  public UGFxClikWidget MiniGameMainTabList;
  public UGFxClikWidget MiniGameSubTabList;
  public UGFxClikWidget TrainingMapList;
  public int CurrentMainTabIndex;
  public int CurrentSubTabIndex;
  public int CurrentRankingTypeIndex;
  public List<USFTypes.FSFUITabList> DefaultMainTabList;
  public List<USFTypes.FSFUITabList> DefaultMiniGameSubTabList;
  public List<USFTypes.FSFUITabList> DefaultRankingSubTabList;
  public List<USFTypes.FSFUITabList> DefaultRankingTypeList;
  public UGFxObject _global;
  public UGFxClikWidget MiniGameList;
  public UGFxClikWidget FiringRangeScoreList;
  public UGFxClikWidget[] FiringRangeScoreBtn = new UGFxClikWidget[3];
  public UGFxClikWidget RegisterFiringRangeInitial;
  public int SelectMapIndex;
  public bool bStartClick;
  public string TutorialRecTime;
  public ESFUIDataProviderType MiniGameType;
  public List<FsMapSelectInfo> SelectMapIndexArray;
  public string LocalizedDefaultScore;
  public string LocalizedScore;
  public string LocalizedTraininContext;
  public string LocalizedMinute;
  public string LocalizedSecond;
  public List<FsMiniGameInfo> MiniGameInfoArray;
  public List<FSTutoBestScore> TutoBestScoreArray;
  public int RecvScoreCount;
  public string StartGameModeClassName;
  public string StartGameMapName;
  public List<FsFiringRangeScoreTabInfo> FiringRangeScoreTabInfoList;
  public int SelectFiringRangeScoreIndex;
  public int SelectFiringRangeTabCode;
  public int FiringRangeScorePageNumber;
  public int FiringRangeScorePageIndex;
  public int FiringRangePageMax;
  public int FiringRangePageViewCount;
  public int FiringRangeListInfoMax;
  public int UseInitialItemID;
  public USFGFxDialog_UseFiringRangeScoreInitial DlgInitial;
  public FScriptDelegate __OnMinigameMainTapClickedDelegate__Delegate;
  public FScriptDelegate __OnMinigameSubTapClickedDelegate__Delegate;
  public FScriptDelegate __OnClickMiniGameMapDubbleClickDelegate__Delegate;
  public FScriptDelegate __OnClickMiniGameSelectMapDelegate__Delegate;
  public FScriptDelegate __OnClickFiringRangeListTabDelegate__Delegate;
}

public class USFGFxLobby_MsgrChatting : USFGFxLobbyScreenEx
{
  public int MaxChatDlgCount;
  public int ActiveDlgIndex;
  public List<USFGFxDialog_MsgrChat> MsgrChatDlgArray;
  public string MaxChattingListMessage;
  public FScriptDelegate __OnChatDlgCreatedDelegate__Delegate;
}

public class USFGFxLobby_MyInfo : USFGFxLobbyScreen
{
  public List<USFTypes.FSFUITabList> DefaultMainTabList;
  public int DefaultMainTabIndex;
}

public class USFGFxLobby_Navi : USFGFxLobbyScreenEx
{
  public class FsUnitList
  {
    public int Id;
    public string Code;
    public string UnitImgName;
  }

  public class FsNaviBtnInfo
  {
    public ELobbyScreen ScreenType;
    public bool bNewMark;
  }

  public class FsWatingInviteRespond
  {
    public int FromUSN;
    public string InvitedStr;
  }

  public UGFxClikWidget btnTopEnv;
  public UGFxClikWidget btnTopExit;
  public UGFxClikWidget btnTopEvent;
  public UGFxClikWidget btnGasha;
  public UGFxClikWidget btnShop;
  public UGFxClikWidget btnInven;
  public UGFxClikWidget btnClan;
  public UGFxClikWidget btnMyInfo;
  public UGFxClikWidget btnBP;
  public UGFxClikWidget btnBack;
  public UGFxClikWidget btnMiniGame;
  public UGFxClikWidget btnCombine;
  public UGFxClikWidget btnTopSerial;
  public UGFxClikWidget btnLP;
  public UGFxClikWidget btnTopDeclare;
  public UGFxClikWidget btnTDPEvent;
  public UGFxClikWidget mcReward;
  public UGFxClikWidget btnEnchant;
  public UGFxClikWidget btnClanLeague;
  public UGFxClikWidget btnFeverTime;
  public UGFxClikWidget RewardItemList;
  public UGFxClikWidget RewardItembtnOk;
  public UGFxClikWidget btnSelected;
  public UGFxClikWidget btnFaceBook;
  public UGFxClikWidget btnAllModify;
  public int LastLobbyViewIndex;
  public bool bPlayerInfoReceived;
  public bool bRollOverUnitSelectArea;
  public bool bRollOverPreviewArea;
  public bool bShowUnitSelectUI;
  public bool bShowWeaponRepaitUI;
  public bool bShowWeaponRepaitRate;
  public bool bShowWeaponSetSelectUI;
  public bool bShowWeaponPerformGraph;
  public bool bShowWeaponPerformGraphForce;
  public bool bForceSendedtoServerInven;
  public bool bClickedCustomView;
  public bool bCustomViewDisableLobbyScreen;
  public bool bClickedOpenEventList;
  public bool bUseShopDiffWidget;
  public bool bUseGachaDiffWidget;
  public bool bIsSerialBtnEnable;
  public bool bIsClanBtnDisable;
  public bool bIsGashaBtnDisable;
  public bool bIsCouponBtnDisable;
  public bool bIsAlbumBtnDisable;
  public bool bIsCommunityBtnDisable;
  public bool bIsCustomViewBtnDisable;
  public bool bIsModifyAllBtnVisible;
  public bool bIsTopEventDisable;
  public bool IsTDPEventBtnDisable;
  public bool bEnableGashaInRoom;
  public bool bClanMarkToolTip;
  public bool bShowCoinBonusBtn;
  public bool bAutoMoving;
  public bool bEnableNow;
  public bool bBackbtnNow;
  public bool bEnvbtnNow;
  public bool bSerialbtnNow;
  public FRotator LastCharRot;
  public FVector WeaponSocketLoc3DOld;
  public string ChannelInfoSrc;
  public string PlayerRankText;
  public string AutoMovingNoticeStr;
  public string LuckyPointMessage;
  public List<string> CannotJoinRoomBecause;
  public List<string> CannotEnterChannelBecause;
  public string TwitchTVOnMessage;
  public ulong ViewingRepairItemSN;
  public int ViewingWeaponID;
  public ulong ViewingWeaponISN;
  public float SendInvenChangedtoServerTime;
  public int MaxMovetoChannelRetrycount;
  public float DelayTimeMovetoChannel;
  public float ExtraRewardTooltipFloatingTime;
  public string LuckyPointURL;
  public string TDPEventURL;
  public List<ELobbyScreen> CustomViewDisableLobbyScreenList;
  public List<string> DevTestMsg;
  public int DevTestMsgCount;
  public int MaxClanLeagueTicketCount;
  public List<FsUnitList> HasUnits;
  public List<FsNaviBtnInfo> BtnInfoArray;
  public string MovetoCallUserCodename;
  public int nMovetoChanType;
  public int nMovetoChanNum;
  public int nMovetoRoomNo;
  public string MovetoPassWord;
  public int MovetoChannelTrycount;
  public int nTryingChannelType;
  public string AutoMoveCallUserCodenameResv;
  public int AutoMoveServerTypeResv;
  public int AutoMoveServerNumResv;
  public int AutoMoveRoomNumResv;
  public string AutoMovePassWordResv;
  public int AdditionalStatusIdx;
  public List<FsWatingInviteRespond> WatingInviteResponds;
  public int WeaponRepaitRate;
  public FVector2D RepairAllPos;
  public USFTypes.FTime_t ClanLeagueRemainTime;
  public USFTypes.FTime_t FeverRemainTime;
  public FScriptDelegate __OnCharRotStartDelegate__Delegate;
  public FScriptDelegate __OnCharRotDelegate__Delegate;
  public FScriptDelegate __OnCharRotEndDelegate__Delegate;
  public FScriptDelegate __OnClickUnitChangeDelegate__Delegate;
  public FScriptDelegate __OnClickPreWeponSetChangeDelegate__Delegate;
  public FScriptDelegate __OnClickNextWeponSetChangeDelegate__Delegate;
  public FScriptDelegate __OnClickWeaponRepairDelegate__Delegate;
  public FScriptDelegate __OnRollOverPreviewAreaDelegate__Delegate;
  public FScriptDelegate __OnRollOutPreviewAreaDelegate__Delegate;
  public FScriptDelegate __OnRollOverEmblemDeckDelegate__Delegate;
}

public class USFGFxLobby_NotifyWindow : USFGFxLobbyScreenEx
{
  public UGFxClikWidget OpenBtn;
  public UGFxClikWidget CloseBtn;
  public int nCurrentIndex;
  public bool bIsOpenWindow;
  public bool bOpenWebConfirm;
  public int TargeShopPart;
  public ELobbyScreen UpdateTartgetScreenIndex;
  public FScriptDelegate __OnClickTabBtnDelegate__Delegate;
}

public class USFGFxLobby_OTPLoginView : USFGFxLobby_LoginView
{
  public UGFxClikWidget OTPTextInput;
  public UGFxObject OTPTextField;
  public UGFxClikWidget bOtpBtn;
  public bool EnterOTPType;
}

public class USFGFxLobby_PartyRoom : USFGFxLobby_BaseRoom
{
  public class FErrorCodeInfo
  {
    public int ErrorCode;
    public string msg;
  }

  public string SearchingStartMessage;
  public string SearchingStopMessage;
  public string SearchingStartFailedMessage;
  public string SearchingPopUpMessage;
  public string WaitingAcceptMessage;
  public string WaitingDeniedByTimeMessage;
  public string ClanMatchingNoticeMessage;
  public string DisconnectedMactingMessage;
  public string AcceptedFromMasterMessage;
  public string DeniedFromMasterMessage;
  public string AcceptedFromOtherMessage;
  public string DeniedFromOtherMessage;
  public bool bFoundMatching;
  public bool bDisableCancel;
  public UGFxClikWidget PartyMemberList;
  public UGFxClikWidget OtherPartyMemberList;
  public List<FErrorCodeInfo> StartSearchingErrorCodeArray;
}

public class USFGFxLobby_PartyRoomList : USFGFxLobby_BaseRoomList
{
  public int SelectedModeIndex;
  public UGFxClikWidget ModeListMC;
  public UGFxClikWidget inputRoomTitle;
  public UGFxObject inputRoomText;
  public USFGFxClickWidget_NumericOnly inputPassword;
  public UGFxObject inputPasswordText;
}

public class USFGFxLobby_PMSLoginView : USFGFxLobby_LoginView
{
  public UGFxClikWidget OTPTextInput;
  public UGFxObject OTPTextField;
  public UGFxClikWidget bOtpBtn;
  public UGFxClikWidget GoogleLoginBtn;
  public UGFxClikWidget FacebookLoginBtn;
  public bool EnterOTPType;
}

public class USFGFxLobby_PurchaseGuide : USFGFxLobbyScreenEx
{
  public UGFxClikWidget btnExpand;
  public UGFxClikWidget BtnMinimize;
  public UGFxClikWidget btnOk;
  public UGFxClikWidget btnCancel;
  public UGFxClikWidget ItemListMC;
  public UGFxClikWidget btnChkLater;
  public UGFxClikWidget btnToolTip;
  public bool bExpanded;
  public bool bOpenedTooltip;
  public List<USFGameItem.FSFItemData> BuyAllItemArray;
  public List<string> PurchaseGuideTitles;
  public List<string> PurchaseGuideMessages;
  public List<USFTypes.FSGuideItem> PurchaseGuideItemArray;
  public int nDisableDays;
  public float fAutoHideTime;
}

public class USFGFxLobby_QuickJoin : USFGFxLobby_GameModeBase
{
  public UGFxClikWidget MapListMC;
  public int SelectedMapIndex;
  public string SelectedMapName;
  public UGFxClikWidget RoomJoinBtn;
  public int DisplayMapListColSize;
  public FScriptDelegate __OnClickMapListDelegate__Delegate;
}

public class USFGFxLobby_Rank : USFGFxLobbyScreen
{
  public List<USFTypes.FSFUITabList> DefaultMainTabList;
  public bool bUITabInitialized;
  public UGFxClikWidget ClanRankList;
  public UGFxClikWidget PCRoomUserRankList;
}

public class USFGFxLobby_RoomList : USFGFxLobby_BaseRoomList
{
}

public class USFGFxLobby_Shop : USFGFxLobbyScreen
{
  public class FSLastBuyItem
  {
    public int ItemId;
    public ulong ItemSN;
  }

  public class FsItemAttrib
  {
    public string Tag;
    public string res;
  }

  public List<FSLastBuyItem> LastBuyItemArray;
  public UGFxClikWidget UnitListMC;
  public UGFxClikWidget btnAllBuy;
  public UGFxClikWidget btnAllReset;
  public UGFxClikWidget btnCloseItemInfo;
  public UGFxClikWidget btnPreview;
  public UGFxClikWidget btnItemSearch;
  public UGFxClikWidget ItemSearchInputWidget;
  public string BuyBtnText;
  public string BuyBtnTextForWP;
  public string BuyBtnTextForEvent;
  public string BuyBtnTextForPCRoom;
  public string BuyBtnTextForVIP;
  public string BuyBtnTextForMonthlyReward;
  public string BuyBtnTextForGashaRareWeapon;
  public string ClanMasterItemBuyFailedMessage;
  public string ClanManagerItemBuyFailedMessage;
  public string ClanMemberItemBuyFailedMessage;
  public string strPCRoomItemCannotBuyMessage;
  public string strVipItemCannotBuyMessage;
  public string strMonthlyRewardConnotBuyMessage;
  public string strGashaRareWeaponCannotBuyMessage;
  public string strBuyAllOKInvenUseMessage;
  public string strDuplicateCannotBuyMessage;
  public string strEmptyGiftMessage;
  public int SelectedItemID;
  public string SelectedPaymentType;
  public int SelectedUnitID;
  public List<USFGameItem.FSFItemData> BuyAllItemArray;
  public List<FsItemAttrib> ItemAttribStr;
  public string strTPExchangeOKMessage;
  public string LinkedURL;
  public string WarningIconName;
  public List<USFTypes.FSFUITabList> DefaultMainTabList;
  public bool bPackageItemPreview;
  public bool bUITabInitialized;
  public bool BuyOKItemIsInUse;
  public bool IsGiftDialog;
  public bool bOpenWeaponProgresson;
  public int BuyOKItemID;
  public int LastSelectedItemWP;
  public string VipPopupOkBtnStr;
  public string GashaRarePopupOkBtnStr;
  public FScriptDelegate __OnListItemClickedDelegate__Delegate;
  public FScriptDelegate __OnBuyClickedDelegate__Delegate;
  public FScriptDelegate __OnPreviewClickedDelegate__Delegate;
  public FScriptDelegate __OnBuyUnitClickedDelegate__Delegate;
  public FScriptDelegate __OnItemInfoCloseDelegate__Delegate;
  public FScriptDelegate __OnItemRollOverDelegate__Delegate;
  public FScriptDelegate __OnHotNewItemOverData__Delegate;
  public FScriptDelegate __OnItemRollOutDelegate__Delegate;
  public FScriptDelegate __OnHotNewItemOutDataDelegate__Delegate;
  public FScriptDelegate __OnClickOpenedEquipInfoUnitDelegate__Delegate;
}

public class USFGFxLobby_SoloLeagueNotice : USFGFxLobbyScreen
{
  public UGFxClikWidget[] MainBtn = new UGFxClikWidget[2];
  public UGFxClikWidget SeasonComboBox;
  public UGFxObject SoloRankList;
  public UGFxClikWidget SoloLeagueCloseBtn;
  public ESoloLeagueMainTab SelectMainTabType;
  public int NowShowListType;
  public int PendingTabType;
  public string SelectedSeasonDate;
  public string SearchText;
  public string PreSearchText;
  public string SeasonComboBoxLabel;
  public float PreTickTime;
  public FScriptDelegate __DisplaySeasonSort__Delegate;
}

public class USFGFxLobby_VideoPlayer : USFGFxLobbyScreen
{
  public class FSChannelngIntroVideo
  {
    public string ServiceCode;
    public List<string> VideoArray;
    public List<string> ExtensionArray;
  }

  public class FSIntroVideo
  {
    public string Video;
    public string extension;
  }

  public List<string> CurIntroVideoArray;
  public List<string> CurIntroVideoExtension;
  public int IntroVideoIndex;
  public string RatingVideoName;
  public string NoRespondLoginMessage;
  public int CurrentIntroType;
  public List<FSChannelngIntroVideo> ChannelingIntroVideoArray;
  public List<FSIntroVideo> IntroVideoArray;
  public List<FSIntroVideo> RatingVideoArray;
  public float ImagePlaySecs;
  public float ImagePlayIntervalSecs;
}

public class USFGFxLobby_WaitingRoom : USFGFxLobby_BaseRoom
{
  public string SecondHalfMatchingMessage;
  public string EmptySlotName;
  public int SecondHalfCounter;
  public FScriptDelegate __OnMovetoRedDelegate__Delegate;
  public FScriptDelegate __OnMovetoBlueDelegate__Delegate;
  public FScriptDelegate __OnRolloverTeamBtnDelegate__Delegate;
  public FScriptDelegate __OnClickEmptySlotDelegate__Delegate;
  public FScriptDelegate __OnChangedExtraOptionDelegate__Delegate;
}

public class USFGFxLobby_WaitingRoom_NewSWF : USFGFxLobby_WaitingRoom
{
  public List<int> AvailableGameModeArray;
}

public class USFGFxLobby_WaitingRoom_16VS16 : USFGFxLobby_WaitingRoom_NewSWF
{
}

public class USFGFxLobby_WaitingRoom_1VS1 : USFGFxLobby_WaitingRoom_NewSWF
{
  public UGFxClikWidget ObserverList;
  public UGFxClikWidget RankList;
  public UGFxClikWidget AddObserverBtn;
  public UGFxClikWidget SubObserverBtn;
  public UGFxClikWidget RankTabBtn;
  public byte MaxPlayerCount;
  public byte MaxSlotCount;
  public byte DefaultObserverSlotCnt;
  public byte DefaultRankPeriodDays;
  public string AddUserListImpossible;
  public string PlayerLimitText;
  public string WarningRankingNotify;
  public int CustomModeType;
  public int MapID;
  public FScriptDelegate __OnRankTapClickedDelegate__Delegate;
}

public class USFGFxLobby_WaitingRoom_AITDM : USFGFxLobby_WaitingRoom_NewSWF
{
  public string MSG_Selected_AIDifficutly_html;
  public string MSG_Selected_AIDifficutly;
  public string AddUserListImpossible;
  public string AISlotName;
  public UGFxClikWidget WaitAIList;
  public UGFxClikWidget AddRedAIBtn;
  public UGFxClikWidget AddRedPlayerBtn;
  public UGFxClikWidget AddBlueAIBtn;
  public UGFxClikWidget AddBluePlayerBtn;
  public UGFxClikWidget SubRedAIBtn;
  public UGFxClikWidget SubRedPlayerBtn;
  public UGFxClikWidget SubBlueAIBtn;
  public UGFxClikWidget SubBluePlayerBtn;
  public int DisplaySlotMax;
  public List<int> DisplaySlotStates;
  public int AIModeSlotType;
  public int RedPlayerUserCnt;
  public int BluePlayerUserCnt;
}

public class USFGFxLobby_WaitingRoom_AITDMVS16 : USFGFxLobby_WaitingRoom_AITDM
{
}

public class USFGFxLobby_WaitingRoom_Hero : USFGFxLobby_WaitingRoom_NewSWF
{
}

public class USFGFxLobby_WaitingRoom_PVE : USFGFxLobby_WaitingRoom_NewSWF
{
  public string MSG_Selected_Difficutly;
  public string MSG_Rank_Date;
  public string MSG_Rank_Title;
  public string DisableRoundCB_Text;
  public int LastMapID;
  public int LastGameModeID;
  public int CurrentDesctiptionPage;
}

public class USFGFxLobby_WaitingRoom_Zombie : USFGFxLobby_WaitingRoom_PVE
{
}

public class USFGFxLobby_WeaponParts : USFGFxLobbyScreen
{
  public class FPartsClassInfo
  {
    public UClass ItemClass;
    public int ItemId;
  }

  public class FWeaponPartsInfo
  {
    public string PartsType;
    public string StatName;
    public EWeaponPartsStat StatType;
    public List<USFGFxLobby_WeaponParts.FPartsClassInfo> PartsArray;
  }

  public UGFxClikWidget btnReturnParts;
  public UGFxClikWidget btnTopEnv;
  public UGFxClikWidget btnTopExit;
  public UGFxClikWidget btnBack;
  public string NoMoreSocketErrorText;
  public string SuccessBuyPartsMessage;
  public string SuccessApplyPartsMessage;
  public string ApplyPartsFailMessage;
  public string AlreadyApplyPartsMessage;
  public string AlreadyDeathPartsMessage;
  public string NoBuyRarePartsMessage;
  public string NoPartsYet;
  public string PartsBefore;
  public string PartsAfter;
  public List<string> PartsStatName;
  public List<string> CustomizeDownToolTip;
  public bool ReturnAfterRotate;
  public bool bAllowAllParts;
  public FRotator rRotLast;
  public List<FWeaponPartsInfo> WeaponPartsInfoArray;
  public USkeletalMeshComponent WeaponMeshComp;
  public List<int> WeapStatArray;
  public List<int> SumStatArray;
  public string OriginMagStr;
  public string ChangeMagStr;
  public int SelectedWeaponID;
  public ulong SelectedWeaponSN;
  public int ApplyPartsID;
  public ulong ApplyPartsSN;
  public string OriginSelectedParts;
  public int BuyPartsCnt;
  public int BuyPartsMaxCnt;
  public int AllPartsCnt;
  public int AllPartsMaxCnt;
  public string SelectedPartsClass;
  public List<FPartsClassInfo> PartsClassArray;
  public List<int> SelectedItemArray;
  public List<int> OriginalItemArray;
  public List<int> ShoppingItemArray;
  public FVector GripWorldLoc;
  public FVector SightWorldLoc;
  public FVector SilencerWorldLoc;
  public FVector LaserPointerWorldLoc;
  public FVector EffectWorldLoc;
  public float DisplaySizeX;
  public float DisplaySizeY;
  public FVector DisplayLoc;
  public FScriptDelegate __OnPreviewRotationStartDelegate__Delegate;
  public FScriptDelegate __OnPreviewRotationDelegate__Delegate;
  public FScriptDelegate __OnPreviewRotationEndDelegate__Delegate;
  public FScriptDelegate __OnPreviewZoomDeltaDelegate__Delegate;
  public FScriptDelegate __OnClickPartsFrameDelegate__Delegate;
  public FScriptDelegate __OnClickPartsItemDelegate__Delegate;
  public FScriptDelegate __OnLogImgLoaderDelegate__Delegate;
  public FScriptDelegate __OnClickBuyOrApplyParts__Delegate;
  public FScriptDelegate __SortPartsByRare__Delegate;
}

public class USFGFxLobby_WebLoginView : USFGFxLobby_LoginView
{
  public UGFxClikWidget StartLoginButton;
  public bool ShowLoginButton;
  public string WebControlCreateFailMsg;
}

public class USFGFxLobbyInGame : USFGFxLobby
{
  public List<FSFViewInfo> ViewDataWithHUD;
}

public class USFGFxLobbyPart : USFGFxUIView
{
  public class FSUnitedTabList
  {
    public int MainCode;
    public List<int> SubCodeArray;
  }

  public int SortItemTagVIP;
  public int SortItemTagPC;
  public int SortItemTagMonthlyReward;
  public int LobbyPartIndex;
  public USFGFxUIView LobbyPartParent;
  public List<FSUnitedTabList> SubUnitedTabList;
}

public class USFGFxLobbyPart_Album : USFGFxLobbyPart
{
}

public class USFGFxLobbyPart_SysSetting : USFGFxLobbyPart
{
  public int ChangedOption;
  public FScriptDelegate __SliderValueChangedDelegate__Delegate;
}

public class USFGFxLobbyPart_SysSetting_Capture : USFGFxLobbyPart_SysSetting
{
  public class FSScreenRecResType
  {
    public int PresetNum;
    public string DisplayText;
  }

  public class FSCaptureSetting
  {
    public string CapturePath;
    public string RecordPath;
    public int RecordScrResPresetNum;
  }

  public UGFxClikWidget ScreenCaptureSetBtn;
  public UGFxClikWidget ScreenCapturePath;
  public UGFxClikWidget ScreenRecSetBtn;
  public UGFxClikWidget ScreenRecPath;
  public UGFxClikWidget ScreenRecResolution;
  public UGFxClikWidget ScreenRecodePathShorcut;
  public UGFxClikWidget ScreenCapturePathShorcut;
  public USFProfileSettings Profile_Settings;
  public string SelecteScreenCapturePath;
  public string SelecteScreenRecordPath;
  public int SelecteScreenRecordPresetNum;
  public List<FSScreenRecResType> ScreenRecResList;
  public FSCaptureSetting OldSetting;
  public FSCaptureSetting NewSetting;
}

public class USFGFxLobbyPart_AlbumScreenShot : USFGFxLobbyPart_SysSetting_Capture
{
  public class FSAlbumInfo
  {
    public string FilePath;
    public string ThumbFilePath;
    public string Filename;
    public string Ext;
  }

  public string RequestRenameAlbumItemText;
  public string RequestDeleteAlbumItemText;
  public string FailedRenameAlbumItemText;
  public string FailedDeleteAlbumItemText;
  public string ErrorCode_ALREADY_EXISTS;
  public string ErrorCode_ACCESS_DENY;
  public string ErrorCode_INVALID_FILE_NAME;
  public string ErrorCode_NO_FILE;
  public string ErrorCode_FACEBOOK_NOT_INTERLOCKED;
  public List<FSAlbumInfo> AlbumInfoList;
  public EAlbumState CurrentAlbumState;
  public string GameDirString;
  public List<string> AvailableExtList;
  public int LastSelectedFileIndex;
  public string NewFileName;
  public string LastErrorCode;
  public ASFEntryPlayerController SFPC;
  public UGFxClikWidget TileList_Picture;
}

public class USFGFxLobbyPart_AlbumTwitchTV : USFGFxLobbyPart_Album
{
  public UGFxClikWidget InputIDBox;
  public UGFxClikWidget InputPasswordBox;
  public UGFxClikWidget SaveIDCheckBox;
  public UGFxClikWidget LoginButton;
  public UGFxClikWidget LogOutButton;
  public UGFxClikWidget JoinButton;
  public UGFxClikWidget FindPasswordButton;
  public UGFxClikWidget ModifyButton;
  public UGFxClikWidget BroadCastTtileEditBox;
  public UGFxClikWidget StartButton;
  public UGFxClikWidget ResolutionComboBox;
  public UGFxClikWidget FrameRateTextBox;
  public UGFxClikWidget BroadcastServerComboBox;
  public List<string> TwitchTVMessage;
  public string TwitchTVGameTitle;
  public string TwitchTVClientID;
  public string TwitchTVClientSecretKey;
  public string TwitchTVJoinURL;
  public string TwitchTVFindPasswordURL;
  public string TwitchTVModifyURL;
  public string RememberIDFilePath;
  public int TwitchTVFps;
  public List<USFTypes.FTwitchTVResolutionInfo> ResolutionInfo;
  public bool IsTwitchTVLogining;
  public bool IsVolumeMute;
  public bool IsBroadcastButtonEnable;
  public bool bCheckRememberID;
  public bool IsViewActivated;
  public bool IsProcessLogin;
  public string TwitchTVLoginID;
  public int VolumeValue;
}

public class USFGFxLobbyPart_BattlePass : USFGFxLobbyPart
{
}

public class USFGFxLobbyPart_BattlePass_Event : USFGFxLobbyPart_BattlePass
{
  public class FSPromoIDInfo
  {
    public int MainID;
    public List<int> SubIDArray;
  }

  public int SelectPromoID;
  public string strEventProgress;
  public List<FSPromoIDInfo> PromoIDInfoArray;
}

public class USFGFxLobbyPart_Clan : USFGFxLobbyPart
{
}

public class USFGFxLobbyPart_ClanRenewal : USFGFxLobbyPart
{
  public int DefaultMakeClanRank;
  public int ClanMakeCost;
  public string ClanMakeCostType;
  public string strJoinCSN;
  public string strJoinClanName;
  public List<USFTypes.FSFUITabList> SubTabList;
  public List<USFTypes.FSFUITabList> HomeSubTabList;
  public string YearLocalized;
  public string MonthLocalized;
  public string DayLocalized;
  public List<string> JoinDlgQuestion;
}

public class USFUIDataStore_ClanBase : USFUIDataStoreBase
{
  public class FSClanInventoryList
  {
    public string Inven_No;
    public string ItemCode;
    public string Expired_Date;
    public string ItemProperty;
  }

  public bool DisabledWebPageOpenDialog;
}

public class USFUIDataStore_ClanHome : USFUIDataStore_ClanBase
{
  public class FSClanRankInfo
  {
    public int Ranking;
    public string calcdate;
  }

  public class FClanHomeData
  {
    public List<USFUIDataStore_ClanHome.FSClanMemberInfo> MemberArray;
    public List<USFUIDataStore_ClanHome.FSMessageInfo> MessageBoardArray;
    public List<USFUIDataStore_ClanHome.FSClanRecordInfo> RecordArray;
    public USFTypes.FSClanInfo ClanInfo;
    public List<USFUIDataStore_ClanHome.FSClanRankInfo> ClanRankInfo;
  }

  public class FSClanRecordInfo
  {
    public string Index;
    public string CSN;
    public string With_CSN;
    public string With_ClanName;
    public string MapID;
    public string Rounds;
    public string Round_Win;
    public string Logdate;
    public string Mode;
    public string channelType;
    public string outCome;
    public int nCSN;
    public int nWith_CSN;
    public int nRounds;
    public int nRound_Win;
    public int nMode;
    public int nMapId;
    public int nChannelType;
    public int nOutCome;
    public bool IsDestroyClan;
    public string MapResourceName;
    public string ModeName;
    public string MapLocalizedName;
  }

  public class FSMessageInfo
  {
    public string Index;
    public string CSN;
    public string WriterUSN;
    public string WriterName;
    public string strMsg;
    public string Regdate;
    public int nCSN;
    public int nWriterUSN;
    public int nIndex;
    public int nNametagImage;
  }

  public class FSClanMemberInfo
  {
    public string USN;
    public string CSN;
    public string ClanName;
    public string Level;
    public string Apply_desc1;
    public string Apply_desc2;
    public string Apply_desc3;
    public string Apply_desc4;
    public string Regdate;
    public string Kills;
    public string Assist;
    public string Death;
    public string GameCount;
    public string HeadShot;
    public string CodeName;
    public string PlayerInfo;
    public string RecommendNick;
    public int nUSN;
    public int nCSN;
    public int nLevel;
    public int nRegDate;
    public int nGameCount;
    public string GfxRank;
    public int nNametagImage;
    public byte CheckMember;
    public int UserRank;
    public string LongTimeMainWeaponItemCode;
  }

  public FClanHomeData ViewHomeData;
  public FClanHomeData MyHomeData;
  public bool bAscending_Check;
  public bool bAscending_Level;
  public bool bAscending_CodeName;
  public bool bAscending_RegDate;
  public bool bAscending_GameCount;
  public bool bAscending_UserImage;
  public bool bAscending_Rank;
  public bool UseClanRecordInfoChannelType;
  public string LocalizedWinAverageText;
  public string LocalizedNotAverageText;
  public string LocalizedAllGameText;
  public string LocalizedWinGameText;
  public string LocalizedLoseGameText;
  public string LocalizedClanRecordRoundText;
  public string Recommender;
}

public class USFGFxLobbyPart_ClanHome : USFGFxLobbyPart_ClanRenewal
{
  public class FsRankColorInfo
  {
    public int Max;
    public string strColor;
  }

  public class FSMemberListPopupInfo
  {
    public List<string> msg;
  }

  public UGFxClikWidget ClanListBtn;
  public UGFxClikWidget JoinBtn;
  public UGFxClikWidget ChatOpenBtn;
  public UGFxClikWidget ChatCloseBtn;
  public UGFxClikWidget InputTextComment;
  public UGFxClikWidget RemoveClanBtn;
  public UGFxClikWidget RemoveJoinBtn;
  public UGFxClikWidget ManagerBtn;
  public UGFxClikWidget UserTabBtn;
  public UGFxClikWidget InputClanNotice;
  public UGFxClikWidget btnClanNotice;
  public UGFxClikWidget btnModify;
  public UGFxClikWidget LevelSettingApplyBtn;
  public UGFxClikWidget LevelSettingComboBox;
  public UGFxClikWidget ClanBottomLeftBtn;
  public UGFxClikWidget ClanBottomRightBtn;
  public UGFxClikWidget DestroyDialogOkBtn;
  public UGFxClikWidget DestroyDialogCancelBtn;
  public UGFxClikWidget ClanCreateBtn;
  public UGFxObject _global;
  public UGFxObject CommentList;
  public UGFxObject RecordList;
  public UGFxObject InputClanNoticeText;
  public UGFxObject ClanMemberList;
  public UGFxObject ClanWaitMemberList;
  public bool bShowSignPopup;
  public bool bShowRemoveClanPopup;
  public bool bShowRClickPopupMenu;
  public bool bIsVisibleRecord;
  public string LastInputText;
  public EClanHomeViewType ClanHomeViewType;
  public EClanMemberSortType CurrentSortType;
  public EMemberOutType OutType_Clan;
  public int LevelSettingType;
  public int BtnShowType;
  public int RClickSlotIndex;
  public int SelectPopupMemberUSN;
  public List<USFTypes.FSInputTextFilter> ClanHomeInputTextLimits;
  public List<FsRankColorInfo> RankColorArray;
  public string EndFont;
  public string ClanHomeFormatCommentNameBegin;
  public string ClanHomeFormatCommentMsgBegin;
  public List<string> ViewCommentLanguageArray;
  public string ClanHomeFormatDefault;
  public string ClanHomeFormatEqualRank;
  public string ErrorChangeClanMemberLevelMsg;
  public string CommentMsg;
  public string NoClanCommentMsg;
  public string DisableCommentMsg;
  public string NotifyJoinNoMsg;
  public string RemoveClanMsg;
  public string CancelJoinClanMsg;
  public string ClanHomeFormatWebURL;
  public string ClanHomeFormatWaitPeopleCount;
  public string OpenWebURL;
  public string NoticeGiveMasterMsg;
  public string LocalizedClanRankText;
  public string LocalizedNotRank;
  public List<string> ClanHomeManagerTabCountInfo;
  public List<string> ClanHomeMemberCountInfo;
  public List<string> DestroyClanMsg;
  public List<USFGFxLobbyPart_ClanManagerTab.FSWidgetBoxInfoData> ClanDestroyInfoArray;
  public string ClanDestroyMsg;
  public List<FSMemberListPopupInfo> MemberListPopupData;
  public List<string> NotifyWarningMsgs;
  public List<string> ClanHomeFormatLevel;
  public List<USFGFxLobbyPart_ClanManagerTab.FSWidgetBoxInfoData> ComboBoxArray;
  public List<string> ClanTagStart;
  public List<string> ClanTagEnd;
  public string ClanBotBtnJoinTitle;
  public string ClanBotBtnDestroyTitle;
  public string ClanBotBtnModifyTitle;
  public string ClanBotBtnSecessionTitle;
  public string ClanBotBtnJoinCancelTitle;
  public string MemberOutErrorMsg;
  public string GiveMasterUnderLevelError;
  public string GiveMasterSelfError;
  public string USN_Clan;
  public string CSN_Clan;
  public string CodeName_Clan;
  public string PInfo_Clan;
  public string OldUSN_Clan;
  public string NewUSN_Clan;
  public string Level_Clan;
  public string NewNotice_Clan;
  public FScriptDelegate __OnClickCommentDeleteBtnDelegate__Delegate;
  public FScriptDelegate __OnClickClanHomeTabBtnDelegate__Delegate;
  public FScriptDelegate __OnCloseSingupPopupDelegate__Delegate;
  public FScriptDelegate __OnClickWebURLDelegate__Delegate;
  public FScriptDelegate __OnClickRecordListClanDelegate__Delegate;
  public FScriptDelegate __OnClickManagerTabMemberListCheckBoxDelegate__Delegate;
  public FScriptDelegate __OnClickWaitPeoplePaperFormDelegate__Delegate;
  public FScriptDelegate __OnClickWaitPeopleRecommendPaperFormDelegate__Delegate;
  public FScriptDelegate __OnClickWaitMemberJoinOkDelegate__Delegate;
  public FScriptDelegate __OnClickWaitMemberJoinNoDelegate__Delegate;
  public FScriptDelegate __OnClickMemberListPopupDelegate__Delegate;
  public FScriptDelegate __OnRollOverMemberListDelegate__Delegate;
  public FScriptDelegate __OnClickedMemberListSortBtnDelegate__Delegate;
  public FScriptDelegate __OnClickManagerTabWaitPeopleListSortBtnDelegate__Delegate;
  public FScriptDelegate __OnClickDestroyClanCheckDelegate__Delegate;
  public FScriptDelegate __OnRClickMemberListDelegate__Delegate;
  public FScriptDelegate __OnClickUserTabBtnsDelegate__Delegate;
  public FScriptDelegate __OnOverUserTabMemberListDelegate__Delegate;
  public FScriptDelegate __OnClickUserTabMemberListDelegate__Delegate;
  public FScriptDelegate __OnRClickUserTabMemberSlotDelegate__Delegate;
  public FScriptDelegate __OnRClickUserTabWaitPeopleSlotDelegate__Delegate;
  public FScriptDelegate __OnClickClanHomeMemberPopupMenuDelegate__Delegate;
  public FScriptDelegate __OnClickClanHomeWaitPeoplePopupMenuDelegate__Delegate;
  public FScriptDelegate __OnClickUserTabWaitPeoplePaperDelegate__Delegate;
  public FScriptDelegate __OnClickUserTabMemberListSortBtnDelegate__Delegate;
  public FScriptDelegate __OnClickUserTabWaitPeopleListSortBtnDelegate__Delegate;
}

public class USFUIDataStore_ClanList : USFUIDataStore_ClanBase
{
  public class FClanAreaInfo
  {
    public string DB_Code;
    public string AreaName;
    public bool bSearchOnly;
    public string ParentDBCode;
  }

  public class FSClanListInfo
  {
    public List<USFTypes.FSClanInfo> ClanPagedArray;
    public bool bIsNextPage;
  }

  public class FFiringLIstTabInfo
  {
    public int WeaponType;
    public int SortType;
    public int MyRankIndex;
    public List<USFTypes.FSFiringRangeListInfo> FiringRangeList;
  }

  public string DefaultAreaDbCode;
  public List<FClanAreaInfo> MainAreaInfoList;
  public List<FClanAreaInfo> SubAreaInfoList;
  public int CurrentMainAreaListIndex;
  public int CurrentSubAreaListIndex;
  public string SelectClanListCSN;
  public int InvitedClanCSN;
  public string SelectDBCode;
  public string SearchAreaDBCode;
  public int ListPage;
  public int nClanListMorePage;
  public EClanListType SelectSortType;
  public int SearchCount;
  public FSClanListInfo ClanLists;
  public int MaxPageCount;
  public int nPrevRequestPage;
  public List<string> ResultClanList;
  public List<USFTypes.FSDetailOption> ClanAreaOption;
  public List<USFTypes.FSDetailOption> ClanDetailOption;
  public List<USFTypes.FSDetailOption> ClanSearchDetailOption;
  public List<USFTypes.FSClanModeMap> ClanModeArray;
  public List<USFTypes.FSClanModeMap> ClanMapArray;
  public int ClanDatabaseDataNumber;
  public string SearchAreaCode;
  public string ClanListSelectAreaCode;
  public List<USFTypes.FSClanRecommend> ClanRecommendList;
  public int SelectClanRecommendIndex;
  public bool bClanRecommend;
  public bool bIsListBtnPush;
  public int FiringRangeMaxCount;
  public List<FFiringLIstTabInfo> FiringRangeTabList;
}

public class USFGFxLobbyPart_ClanList : USFGFxLobbyPart_ClanRenewal
{
  public UGFxClikWidget SearchBtn;
  public UGFxClikWidget AreaDropBox;
  public UGFxClikWidget MainAreaDropBox;
  public UGFxClikWidget SubAreaDropBox;
  public UGFxClikWidget ClanMakeBtn;
  public UGFxClikWidget ClanHomeBtn;
  public UGFxClikWidget ListMoreBtn;
  public UGFxClikWidget SearchTabCloseBtn;
  public UGFxClikWidget RecommendListBtn;
  public UGFxObject ClanList;
  public UGFxObject ClanInviteList;
  public EClanListType SortBtnType;
  public string[] SortBtnInfo = new string[6];
  public int nClanListMorePage;
  public int nRequestPage;
  public bool IsClanRecommendMsgrNotice;
  public string LastSearchText;
  public int bClanListPageVisibleCount;
  public string ClanListFormatMasterName;
  public string ClanListFormatRegularCount;
  public string ClanListFormatWaitPeopleCount;
  public string ClanListFindClanNameFailedMsg;
  public string ClanListMakeClanUnderRank;
  public string ClanListSearchText;
  public string ClanListFormatClanPoint;
  public string ClanListNoClanMsg;
  public string ClanListDataNoneText;
  public List<string> ClanListTabButtonText;
  public FScriptDelegate __OnClanListHeaderBarClickedDelegate__Delegate;
  public FScriptDelegate __OnClickedClanListGoHomeDelegate__Delegate;
  public FScriptDelegate __OnClickedClanListDelegate__Delegate;
}

public class USFGFxLobbyPart_ClanManagerTab : USFGFxLobbyPart_Clan
{
  public class FSManagetTabMemberListPopupInfo
  {
    public List<string> msg;
  }

  public class FSWidgetBoxInfoData
  {
    public string msg;
    public int Type;
  }

  public UGFxObject[] ManagerTabList = new UGFxObject[3];
  public UGFxObject MemberSlotPopup;
  public UGFxObject LevelSettingComboBox;
  public UGFxClikWidget LevelSettingApplyBtn;
  public int LevelSettingType;
  public int SelectPopupMemberUSN;
  public int RClickSlotIndex;
  public List<FSWidgetBoxInfoData> ComboBoxArray;
  public UGFxClikWidget DestroyClanBtn;
  public UGFxClikWidget btnModify;
  public EClanMemberSortType CurrentSortType;
  public EClanManagerTab SelectManagerTabType;
  public UGFxClikWidget[] DestroyClanCheckBoxs = new UGFxClikWidget[4];
  public List<string> ClanHomeManagerTabMsgs;
  public List<FSManagetTabMemberListPopupInfo> ManagerTabMemberListPopupData;
  public string GiveMasterUnderLevelError;
  public string MemberOutErrorMsg;
  public string DestroyComboBoxMsg;
  public string ErrorChangeClanMemberLevelMsg;
}

public class USFGFxLobbyPart_ClanRank : USFGFxLobbyPart_ClanRenewal
{
  public int BlindTime;
  public int ENoticeBgColor_Blind;
  public int ENoticeBgColor_Ready;
  public string WeeklyClanRankTitle;
  public string WeeklyClanRankNoticeText_Normal;
  public string WeeklyClanRankNoticeText_Blind;
  public string WeeklyClanRankNoticeText_Ready;
  public string WeeklyClanRankRemainTime_Day;
  public string WeeklyClanRankRemainTime_DayText;
  public string WeeklyClanRankRemainTime_Hour;
  public string WeeklyClanRankRemainTime_HourText;
  public string WeeklyClanRankRemainTime_Minute;
  public string WeeklyClanRankRemainTime_MinuteText;
  public string WeeklyClanRankBlindText_Blind;
  public string WeeklyClanRankBlindText_BlindTime;
  public string WeeklyClanRankBlindText_Ready;
  public string WeeklyClanRankBlindText_ReadyTime;
  public string WeeklyClanRankUnit;
  public string WeeklyClanRankNone;
  public string WeeklyClanRankBlind;
  public UGFxClikWidget LastWeekRankBtn;
  public UGFxClikWidget ClanRankList;
  public UGFxClikWidget PCRoomUserRankList;
  public int EClanRankState_Normal;
  public int EClanRankState_Blind;
  public int EClanRankState_Ready;
  public int ResultDay;
  public int ResultHour;
  public int ResultMinute;
  public string BlindDayString;
  public string BlindHourString;
  public string BlindMinuteString;
  public string StartBlindAniStat;
  public string ClosedStat;
  public string EndBlindAniStat;
}

public class USFGFxLobbyPart_ClanUserTab : USFGFxLobbyPart_Clan
{
  public class FSPopupInfo
  {
    public string msg;
    public int Type;
    public bool bIsVisible;
  }

  public EClanUserTab SelectUserTabType;
  public EClanMemberSortType CurrentSortType;
  public UGFxObject[] UserTabList = new UGFxObject[2];
  public bool bIsPopupClickMasterSlot;
  public List<FSPopupInfo> ClanHomeUserTabPopupMenuInfo;
  public int WantViewIDCardIdx;
  public float ViewIDCardTimer;
}

public class USFGFxLobbyPart_Rank : USFGFxLobbyPart
{
}

public class USFGFxLobbyPart_ClanWeeklyRank : USFGFxLobbyPart_Rank
{
  public int BlindTime;
  public int ENoticeBgColor_Blind;
  public int ENoticeBgColor_Ready;
  public string WeeklyClanRankTitle;
  public string WeeklyClanRankNoticeText_Normal;
  public string WeeklyClanRankNoticeText_Blind;
  public string WeeklyClanRankNoticeText_Ready;
  public string WeeklyClanRankRemainTime_Day;
  public string WeeklyClanRankRemainTime_DayText;
  public string WeeklyClanRankRemainTime_Hour;
  public string WeeklyClanRankRemainTime_HourText;
  public string WeeklyClanRankRemainTime_Minute;
  public string WeeklyClanRankRemainTime_MinuteText;
  public string WeeklyClanRankBlindText_Blind;
  public string WeeklyClanRankBlindText_BlindTime;
  public string WeeklyClanRankBlindText_Ready;
  public string WeeklyClanRankBlindText_ReadyTime;
  public string WeeklyClanRankUnit;
  public string WeeklyClanRankNone;
  public string WeeklyClanRankBlind;
  public UGFxClikWidget LastWeekRankBtn;
  public int EClanRankState_Normal;
  public int EClanRankState_Blind;
  public int EClanRankState_Ready;
  public int ResultDay;
  public int ResultHour;
  public int ResultMinute;
  public string BlindDayString;
  public string BlindHourString;
  public string BlindMinuteString;
  public string StartBlindAniStat;
  public string ClosedStat;
  public string EndBlindAniStat;
}

public class USFGFxLobbyPart_GameResult : USFGFxLobbyPart
{
}

public class USFGFxLobbyPart_GameResult_All : USFGFxLobbyPart_GameResult
{
  public UGFxClikWidget topList;
  public UGFxClikWidget bottomList;
  public UGFxClikWidget PersonalList;
}

public class USFGFxLobbyPart_GameResult_HeroAll : USFGFxLobbyPart_GameResult_All
{
}

public class USFGFxLobbyPart_GameResult_HeroStatistics : USFGFxLobbyPart_GameResult
{
  public class FSUIResultStatisticsTypes
  {
    public EResultStatisticsType Type;
    public string Title;
    public bool bIgnoreRankSort;
  }

  public class FSPlayerStatisticsScoreData
  {
    public int USN;
    public int Score;
  }

  public class FSStatisticsRankData
  {
    public EResultStatisticsType Type;
    public int Rank;
  }

  public List<FSUIResultStatisticsTypes> StatisticsData;
  public EResultStatisticsType CurrentType;
  public FScriptDelegate __StatisticsRankSort__Delegate;
  public FScriptDelegate __UserResultStatisticsScoreSort__Delegate;
}

public class USFGFxLobbyPart_GameResult_Me : USFGFxLobbyPart_GameResult
{
  public string strRankingUpMessage;
  public string strRankingDownMessage;
  public int MaxShowKillIcon;
  public List<string> KillFeedBackArray;
}

public class USFGFxLobbyPart_Inven : USFGFxLobbyPart
{
  public List<FSDisplayItem> DisplayItems;
  public List<USFTypes.FSFUITabList> SubTabList;
  public USFTypes.FSResellDialogInfo ResellDialogInfo;
  public List<bool> InvenTabResellButtonVisible;
  public int DisplayItemCount;
  public int DisplayRowSize;
  public int DisplayColumnSize;
  public int PositionalNum;
  public int PageIndex;
  public int TotalPageIndex;
  public int PageGroupCount;
}

public class USFGFxLobbyPart_InvenEquip : USFGFxLobbyPart_Inven
{
  public class FSUnitInvenItem
  {
    public USFGameItem.FSRecvItemInfo UnitItem;
    public int UnitItemID;
    public List<USFGameItem.FSRecvItemInfo> AllItemArray;
    public List<USFGameItem.FSRecvItemInfo> HeadItemArray;
    public List<USFGameItem.FSRecvItemInfo> UpperItemArray;
    public List<USFGameItem.FSRecvItemInfo> LowerItemArray;
    public List<USFGameItem.FSRecvItemInfo> FaceItemArray;
  }

  public List<FSUnitInvenItem> UnitItemArray;
}

public class USFGFxLobbyPart_InvenFuncItem : USFGFxLobbyPart_Inven
{
  public string NewCodename;
  public string NewClanName;
  public string PCRoomString;
  public List<USFGameItem.FSRecvItemShortInfo> UsingFunctionalItemArray;
  public bool bDisablePMCItem;
  public int ClickedChangeBtnItemID;
}

public class USFGFxLobbyPart_InvenGift : USFGFxLobbyPart_Inven
{
}

public class USFGFxLobbyPart_InvenModeItem : USFGFxLobbyPart_Inven
{
  public int RecievedModeItemCount;
  public string ModeItemOverlapMsg;
  public FScriptDelegate __SubTabSort__Delegate;
}

public class USFGFxLobbyPart_InvenPMCItem : USFGFxLobbyPart_InvenEquip
{
  public UGFxClikWidget btnCustomView;
}

public class USFGFxLobbyPart_InvenRecycle : USFGFxLobbyPart_Inven
{
  public class FsRecycleInfo
  {
    public string RecycleRank;
    public int RecycleScore;
    public int RecyclePrice;
  }

  public List<FSDisplayItem> RecycleDisplayItems;
  public UGFxClikWidget btnRecycleListClear;
  public UGFxClikWidget btnRecycleListSend;
  public int RecycleTotalScore;
  public int MinimumRecycleItemCount;
  public int MaximumRecycleItemCount;
  public string strRecycleCountShort;
  public List<FsRecycleInfo> RecycleInfoArray;
}

public class USFGFxLobbyPart_InvenWeapon : USFGFxLobbyPart_Inven
{
  public UGFxClikWidget GrenadeList;
  public UGFxObject WeaponSetList;
  public int GrenadeSetCount;
  public bool bUseWeaponPartsUI;
}

public class USFGFxLobbyPart_MiniGame : USFGFxLobbyPart
{
}

public class USFGFxLobbyPart_MiniGame_Game : USFGFxLobbyPart_MiniGame
{
}

public class USFGFxLobbyPart_MiniGame_Ranking : USFGFxLobbyPart_MiniGame
{
}

public class USFGFxLobbyPart_MyInfo : USFGFxLobbyPart
{
  public UGFxClikWidget MyInfoModeListMC;
}

public class USFGFxLobbyPart_MyInfoChallenge : USFGFxLobbyPart_MyInfo
{
  public string MSG_Challenge_Achieved_Date;
  public string MSG_No_Challenge_Achieved_Date;
  public List<USFTypes.FSFUITabList> DefaultSubTabList;
  public List<USFTypes.FSFUITabList> DefaultChallengeTypeTabList;
  public string BindingName_ChallengingList;
  public string BindingName_AchievementList;
  public USFChallengeListCondition ChallengeListCondition;
  public List<USFChallengeListCondition.FChallengeProgressData> ProgressList;
  public List<USFChallengeListCondition.FChallengeProgressData> CompleteList;
  public int Current_SubTab_Index;
  public int Current_ChallengeTypeTab_Index;
  public int RecvChallengeListCount;
}

public class USFGFxLobbyPart_MyInfoMonthlyReward : USFGFxLobbyPart_MyInfo
{
  public class FsInfoData
  {
    public string Title;
    public string context;
  }

  public class FsVIPLevelInfo
  {
    public int VipGrade;
    public int Exp;
    public string VipLabel;
    public string Title;
    public string context;
  }

  public UGFxClikWidget RenewalBtn;
  public UGFxClikWidget VipItemBuyBtn;
  public int ImageIndex;
  public bool IsVipLevelTypeBG;
  public bool IsHighLevelVip;
  public float RollingTime;
  public int MaxVIpPoint;
  public List<string> VipInfoImgs;
  public string TopContenImage;
  public List<FsInfoData> RegisterRequestCardInfoList;
  public List<FsInfoData> RegisterCardInfoList;
  public List<FsVIPLevelInfo> LevelInfoList;
  public List<string> LevelInfoContextList;
  public string LocalizedToolTipMsg;
  public string LocalizedNexxExpToolTipMsg;
  public string VIPDiscountCouponMsg;
  public string PeriodOfGrace;
  public UGFxClikWidget GradeDropDown;
  public FScriptDelegate __OnClickLevelBtnDelegate__Delegate;
  public FScriptDelegate __OnOverLevelBtnDelegate__Delegate;
}

public class USFGFxLobbyPart_MyInfoProfile : USFGFxLobbyPart_MyInfo
{
  public class FSNoRankingMsg
  {
    public int MaxRank;
    public string msg;
  }

  public int RankingMinimumRank;
  public string KADRateTab;
  public string HKRateTab;
  public string WINRateTab;
  public string KDCountTab;
  public string NoRankingMessage;
  public string BattleTab;
}

public class USFGFxLobbyPart_MyInfoVIp : USFGFxLobbyPart_MyInfo
{
  public class FsInfoData
  {
    public string Title;
    public string context;
  }

  public class FsVIPLevelInfo
  {
    public int VipGrade;
    public int Exp;
    public string VipLabel;
    public string Title;
    public string context;
  }

  public UGFxClikWidget GradeDropDown;
  public UGFxClikWidget RenewalBtn;
  public UGFxClikWidget VipItemBuyBtn;
  public int ImageIndex;
  public bool IsVipLevelTypeBG;
  public bool IsHighLevelVip;
  public float RollingTime;
  public int MaxVIpPoint;
  public List<string> VipInfoImgs;
  public List<FsInfoData> RegisterRequestCardInfoList;
  public List<FsInfoData> RegisterCardInfoList;
  public List<FsVIPLevelInfo> LevelInfoList;
  public List<string> LevelInfoContextList;
  public string LocalizedToolTipMsg;
  public string LocalizedNexxExpToolTipMsg;
  public string VIPDiscountCouponMsg;
  public string PeriodOfGrace;
  public FScriptDelegate __OnClickLevelBtnDelegate__Delegate;
  public FScriptDelegate __OnOverLevelBtnDelegate__Delegate;
}

public class USFGFxLobbyPart_MyInfoVIPMapRotation : USFGFxLobbyPart_MyInfo
{
  public UGFxClikWidget ModeMapListMC;
  public UGFxClikWidget SaveMapListMC;
  public UGFxClikWidget btnSave;
  public UGFxClikWidget btnCancel;
  public UGFxObject SaveDataProvider;
  public USFUIDataProvider_ModeInfo SelectedGameModeData;
  public List<USFTypes.FSSupportMap> SupportMapList;
  public List<USFTypes.FMapRotationInfo> TempSaveMapList;
  public int MapSelectedIndex;
  public int SaveSelectedIndex;
  public bool IsSuccessMapData;
  public List<bool> IsSaveData;
  public List<string> RotationGameModeNameList;
  public List<string> CurGRotationGameModeNameList;
  public string SuccessMapDataMessage;
  public string InitializationMapDataMessage;
  public string ImpossibleMapDataMessage;
  public string NormalUserMessage;
  public string NothingSaveDataMessage;
  public string BlindMessage;
  public string ChannelMessage;
}

public class USFGFxLobbyPart_MyInfoWeaponLog : USFGFxLobbyPart_MyInfo
{
  public int DefWeaponLogIndex;
  public int WeaponLogIndex;
  public bool bReceivedWeaponLog;
  public UGFxClikWidget WeaponListMC;
  public string KillRatioMsg;
  public string HeadShotRatioMsg;
  public string AssistRatioMsg;
  public string EtcRatioMsg;
  public string WeaponPlayedTimeMsg;
  public List<USFTypes.FSFWeaponLog> AllWeaponLogArray;
}

public class USFGFxLobbyPart_Notice : USFGFxLobbyPart
{
}

public class USFGFxLobbyPart_Notice_Event : USFGFxLobbyPart_Notice
{
  public class FSPromoIDInfo
  {
    public int MainID;
    public List<int> SubIDArray;
  }

  public int SelectPromoID;
  public string strEventProgress;
  public List<FSPromoIDInfo> PromoIDInfoArray;
}

public class USFGFxLobbyPart_Notice_Gift : USFGFxLobbyPart_Notice
{
  public UGFxClikWidget[] DisplayItemList = new UGFxClikWidget[2];
  public UGFxClikWidget SubTab;
  public UGFxClikWidget btn_useall;
  public List<USFTypes.FSGiftItem> DisplayGiftItems;
  public string strFromGMMessage;
  public string[] strDlgMessage = new string[3];
  public string[] strGiftSubTab = new string[2];
  public string strSuccessSendedGiftListMessage;
  public int CurrentSubTab;
  public int SelectGiftListNumber;
  public bool bDisableFirstGiftPopUp;
}

public class USFGFxLobbyPart_PCRoomRank : USFGFxLobbyPart_Rank
{
  public class FSPCRoomRankData
  {
    public string GFxGrade;
    public int PrevRank;
    public int USN;
    public int Rank;
    public string CodeName;
    public int Exp;
    public string ClanName;
  }

  public string PCRoomName;
  public string PCRoomID;
  public int SavedCurrentTime;
  public int PCRoomUserRankCount;
  public List<FSPCRoomRankData> PCRoomRankUserData;
  public string PCRoomRankTitle;
  public string PCRoomRankMyInfoContents;
  public string PCRoomMyRankDataNone;
  public string PCRoomMyPrevRankDataNone;
  public string PCRoomMyRankEqualPrevRank;
  public FSPCRoomRankData TestMyRankInfo;
}

public class USFGFxLobbyPart_Shop : USFGFxLobbyPart
{
  public int DisplayItemCount;
  public int PageIndex;
  public int DisplayRowSize;
  public int DisplayColumnSize;
  public int PositionalNum;
  public int TotalPageIndex;
  public List<FSDisplayItem> DisplayItems;
  public int LastSelectedItem;
  public List<USFGameItem.FSFItemData> SelectedItemArray;
  public List<USFTypes.FSFUITabList> SubTabList;
  public bool bDisableReturnVipTP;
  public bool bViewVisibleCash;
}

public class USFGFxLobbyPart_ShopEquip : USFGFxLobbyPart_Shop
{
  public class FSUnitShopItem
  {
    public USFGameItem.FSFItemData UnitItemData;
    public int UnitItemID;
    public List<USFGameItem.FSFItemData> AllItemArray;
    public List<USFGameItem.FSFItemData> FaceItemArray;
    public List<USFGameItem.FSFItemData> HeadItemArray;
    public List<USFGameItem.FSFItemData> UpperItemArray;
    public List<USFGameItem.FSFItemData> LowerItemArray;
  }

  public List<int> DisplayUnitItemArray;
  public bool UnitListInited;
  public List<FSUnitShopItem> UnitItemArray;
  public int Test;
}

public class USFGFxLobbyPart_ShopEventItem : USFGFxLobbyPart_Shop
{
  public ulong LastSelectedItemSN;
  public int PrevLastSelectedItem;
  public int HotNewInfoIndex;
  public int UpdateTime;
  public string DataProvide_BindingName;
}

public class USFGFxLobbyPart_ShopFeverItem : USFGFxLobbyPart_Shop
{
  public ulong LastSelectedItemSN;
  public int PrevLastSelectedItem;
  public string DataProvide_BindingName;
  public int FeverItemInfoIndex;
  public int UpdateTime;
}

public class USFGFxLobbyPart_ShopFuncItem : USFGFxLobbyPart_Shop
{
}

public class USFGFxLobbyPart_ShopModeItem : USFGFxLobbyPart_Shop
{
  public string DataProvider_BindingName;
  public FScriptDelegate __SubTabSort__Delegate;
}

public class USFGFxLobbyPart_ShopWeapon : USFGFxLobbyPart_Shop
{
  public ulong LastSelectedItemSN;
  public int SelectedWeaponProgItemID;
  public List<USFTypes.FSWeaponProgressionTask> SelectedWeaponProgressionArray;
}

public class USFGFxLobbyPart_SysSetting_Audio : USFGFxLobbyPart_SysSetting
{
  public class FsSoundSetting
  {
    public float VolumeMaster;
    public float VolumeBGM;
    public float VolumeEnviroment;
    public float VolumeEffect;
    public float VolumeVoice;
    public int MuteBGM;
    public int MuteEnviroment;
    public int MuteEffect;
    public int MuteVoice;
    public int VoiceLanguage;
  }

  public UGFxClikWidget MuteBGM;
  public UGFxClikWidget MuteEffect;
  public UGFxClikWidget MuteEnv;
  public UGFxClikWidget MuteVoice;
  public USFGFxClickWidget_NumericOnly VolumeMasterValue;
  public USFGFxClickWidget_NumericOnly VolumeBGMValue;
  public USFGFxClickWidget_NumericOnly VolumeEffectValue;
  public USFGFxClickWidget_NumericOnly VolumeEnvValue;
  public USFGFxClickWidget_NumericOnly VolumeVoiceValue;
  public UGFxClikWidget VolumeMasterSliderThumb;
  public UGFxClikWidget VolumeBGMSliderThumb;
  public UGFxClikWidget VolumeEffectSliderThumb;
  public UGFxClikWidget VolumeEnvSliderThumb;
  public UGFxClikWidget VolumeVoiceSliderThumb;
  public UGFxClikWidget VolumeMasterSlider;
  public UGFxClikWidget VolumeBGMSlider;
  public UGFxClikWidget VolumeEffectSlider;
  public UGFxClikWidget VolumeEnvSlider;
  public UGFxClikWidget VolumeVoiceSlider;
  public USFSoundGroup_UX AudioSampleSoundGroup;
  public FsSoundSetting SoundSettingNow;
  public FsSoundSetting SoundSettingNew;
  public FsSoundSetting SoundSettingOld;
}

public class USFGFxLobbyPart_SysSetting_Controll : USFGFxLobbyPart_SysSetting
{
  public class FsConrollSetting
  {
    public int MouseSensitivityGame;
    public int UseMouseSensitivityZoom;
    public int MouseSensitivityZoom;
    public int MouseInvertY;
    public List<string> KeySetting;
    public int SprintKeySet;
    public int HoldZoomKeySet;
  }

  public USFGFxClickWidget_NumericOnly MouseSensitivityValue;
  public USFGFxClickWidget_NumericOnly MouseExSensitivityValue;
  public UGFxClikWidget MouseSensitivitySlider;
  public UGFxClikWidget MouseSensitivitySliderThumb;
  public UGFxClikWidget MouseExSensitivitySlider;
  public UGFxClikWidget MouseExSensitivitySliderThumb;
  public UGFxClikWidget UseExSensitivitycb;
  public UGFxClikWidget[] MouseInvertYcb = new UGFxClikWidget[2];
  public UGFxClikWidget btnExOk;
  public UGFxClikWidget btnExClose;
  public UGFxClikWidget btnExCancel;
  public UGFxClikWidget SprintKeyCheckBox;
  public UGFxClikWidget HoldZoomKeyCheckBox;
  public UGFxClikWidget btnSpecialOk;
  public UGFxClikWidget btnSpecialClose;
  public UGFxClikWidget btnSpecialCancel;
  public FsConrollSetting ConrollSettingNow;
  public FsConrollSetting ConrollSettingNew;
  public int UseMouseSensitivityZoom;
  public int MouseSensitivityZoom;
  public int MouseInvertY;
  public bool bExtraMouseSettingDialogActive;
  public bool bSpecialKeyDialogActive;
  public bool bDisableSprayKey;
  public bool bDisableModeWeaponKey;
  public bool bUseHoldZoomType;
  public string SprintKeyText;
  public FScriptDelegate __OnMoreMouseSettingDelegate__Delegate;
  public FScriptDelegate __OnKeyChangeDelegate__Delegate;
  public FScriptDelegate __OnSpecialKeyPopUpOpenDlegate__Delegate;
}

public class USFGFxLobbyPart_SysSetting_Facebook : USFGFxLobbyPart_SysSetting
{
  public class FSFacebookSettingInfo
  {
    public bool bAutoUpdate_Event;
    public bool bAutoUpdate_Screenshot;
    public bool bAutoUpdate_Movie;
    public bool bMaintainCookie;
  }

  public UGFxClikWidget ChkAutoUpdate_Event;
  public UGFxClikWidget ChkAutoUpdate_Screenshot;
  public UGFxClikWidget ChkAutoUpdate_Movie;
  public UGFxClikWidget ChkMaintainCookie;
  public FSFacebookSettingInfo DefaultSetting;
  public FSFacebookSettingInfo CurrentSetting;
}

public class USFGFxLobbyPart_SysSetting_Video : USFGFxLobbyPart_SysSetting
{
  public class FsGraphicSetting
  {
    public int FullScreen;
    public string ScrRes;
    public int ScrType;
    public float Gamma;
    public int RadarRotation;
    public int ResultAutoSave;
    public int LobbyFullScreen;
    public int ScaleLevel;
    public int VSyncmode;
    public int FrameStability;
    public int Antialiasing;
    public int bIgnoreWindowSwitching;
    public int LightSpreadEffect;
    public int DynamicShadows;
    public int Gore;
    public int UISize;
    public int DepthOfField;
    public int ExploRadialBlur;
    public int EnemyDefaultUnit;
  }

  public UGFxClikWidget ScreenResCB;
  public UGFxClikWidget ScreenTypeCB;
  public UGFxClikWidget ScreenGraphicCB;
  public UGFxClikWidget ScreenGammaSlider;
  public UGFxClikWidget ScreenGammaSliderThumb;
  public USFGFxClickWidget_NumericOnly ScreenGammaValue;
  public UGFxClikWidget[] InGameWindowChk = new UGFxClikWidget[2];
  public UGFxClikWidget[] LobbyWindowChk = new UGFxClikWidget[2];
  public UGFxClikWidget[] ResultAutoSave = new UGFxClikWidget[2];
  public UGFxClikWidget[] EnemyDefaultUnitChk = new UGFxClikWidget[2];
  public UGFxClikWidget[] VerticalSync = new UGFxClikWidget[2];
  public UGFxClikWidget[] FrameStability = new UGFxClikWidget[2];
  public UGFxClikWidget[] Antialiasing = new UGFxClikWidget[2];
  public UGFxClikWidget[] LightSpreadEffectChk = new UGFxClikWidget[2];
  public UGFxClikWidget[] DynamicShadowsChk = new UGFxClikWidget[2];
  public UGFxClikWidget[] DepthOfFieldChk = new UGFxClikWidget[2];
  public UGFxClikWidget[] ExploRadialBlurChk = new UGFxClikWidget[2];
  public UGFxClikWidget[] IgnoreWindowSwitchingChk = new UGFxClikWidget[2];
  public UGFxClikWidget[] UISizeChk = new UGFxClikWidget[2];
  public UGFxClikWidget[] GoreChk = new UGFxClikWidget[2];
  public UGFxClikWidget RadarRotation;
  public FsGraphicSetting GraphicSettingNew;
  public FsGraphicSetting GraphicSettingNow;
  public string DefaultScreenResolution;
  public List<string> ScreenResList;
  public List<int> ScreenType;
  public bool bExtraVideoSettingDialogActive;
  public bool bDisableWindowModeInLobby;
  public bool bDisableWindowModeInGame;
  public bool bDisableChangeWindow;
  public bool bDisableEnemyDefaultUnit;
  public List<string> ScreenTypeStr;
  public List<EAspectRatioType> ScreenTypeList;
  public List<string> ScreenGraphicStr;
  public int EnableLightEffectLevel;
}

public class USFGFxLobbyPart_SysSetting_Whisper : USFGFxLobbyPart_SysSetting
{
  public class FSWhisperSettingInfo
  {
    public bool bAllBlock;
    public bool bGeneralBlock;
    public bool bFriendBlock;
    public bool bClanMemberBlock;
  }

  public UGFxClikWidget[] ChkTotalBlockWhisper = new UGFxClikWidget[2];
  public UGFxClikWidget[] ChkNormalBlockWhisper = new UGFxClikWidget[2];
  public UGFxClikWidget[] ChkFriendBlockWhisper = new UGFxClikWidget[2];
  public UGFxClikWidget[] ChkClanBlockWhisper = new UGFxClikWidget[2];
  public FSWhisperSettingInfo DefaultSetting;
  public FSWhisperSettingInfo CurrentSetting;
}

public class USFGFxMoviePlayer_ClanMark : USFGFxMoviePlayer
{
  public string LobbyRankMarkString;
  public bool bInit;
  public string UvLoaderFilePath;
  public FScriptDelegate __UVimgLoader_InitDelegate__Delegate;
}

public class USFGFxMoviePlayer_Dogtag : USFGFxMoviePlayer
{
  public UGFxObject CodeNameTextField;
  public UGFxObject DateTextField;
}

public class USFGFxMoviePlayer_RankMark : USFGFxMoviePlayer
{
  public string LobbyRankMarkString;
}

public class USFGFxMoviePlayer_Spray : USFGFxMoviePlayer
{
  public string UvLoaderFilePath;
  public bool bInit;
  public FScriptDelegate __UVimgLoader_InitDelegate__Delegate;
}

public class USFGFxMoviePlayer_WeaponNameTag : USFGFxMoviePlayer
{
  public string TagString;
}

public class ASFGlassBGMMutator : AMutator
{
  public FName GlassBGMName;
  public ETeam EnemyTeam;
}

public class ASFGlassGame : ASFTeamGameInfo
{
  public string PreNewMatchInProgressBGM_RED;
  public string PreNewMatchInProgressBGM_BLUE;
}

public class USFGlassGameKillDeathMessage : USFKillDeathMessage
{
}

public class ASFGlassGameReplicationInfo : ASFGameReplicationInfo
{
  public List<string> NoDrawTeamBaseMap;
  public List<string> UnUseBGMSoundMapName;
}

public class USFGlassGameScore : USFGameScore
{
  public float SCORE_BreakEnemyGlass;
  public float SCORE_EnemyKillForGlassMode;
}

public class ASFGlassHUD : ASFHUD
{
}

public class ASFGlassPlayerController : ASFPlayerController
{
}

public class ASFGlowModeHUD : ASFTeamHUD
{
  public string GlowModeScoreTextColor;
}

public class ASFGlowTDMGame : ASFBaseTeamDeathGame
{
}

public class USFGlowTDMGameScore : USFTeamDeathGameScore
{
}

public class ASFGoldDiggerGame : ASFBaseTeamDeathGame
{
  public string DroppedPickupMoneyClassName;
  public FVector MoneySpawnRandomVel;
  public int BaseMoney;
  public bool bOnlySameTeamCanPickUpMoney;
  public EOverTimeCheckType OverTimeCheckType;
}

public class ASFStealOffPlayerReplicationInfo : ASFPlayerReplicationInfo
{
  public int Money;
  public int DefaultMoney;
}

public class ASFGoldDiggerPlayerReplicationInfo : ASFStealOffPlayerReplicationInfo
{
  public int MaxMoney;
  public int MoneyWeight;
}

public class ASFGoldSafeVolume : AVolume
{
  public ETeam CheckTeam;
}

public class USFGrenadeFlashLight : USFExplosionLight
{
}

public class USFGrenadeFlashLight_FBang : USFGrenadeFlashLight
{
}

public class USFGrenadeFlashLight_Frag : USFGrenadeFlashLight
{
}

public class USFGrenadeFlashLight_Smoke : USFGrenadeFlashLight
{
}

public class USFGrenadeFlashLight_VXGas : USFGrenadeFlashLight
{
}

public class ASFGrenadeGame : ASFTeamGameInfo
{
}

public class ASFGrenadeGameReplicationInfo : ASFGameReplicationInfo
{
}

public class USFGrenadeGameScore : USFGameScore
{
}

public class ASFGrenadeHUD : ASFHUD
{
}

public class USFGrenadeKillEventData : USFSpecialKillEventData
{
}

public class ASFGrenadePlayerController : ASFPlayerController
{
}

public class ASFGrowUpPlayerReplicationInfo : ASFPlayerReplicationInfo
{
  public int ModeLevel;
  public int ModeExp;
  public int ModeMoney;
  public int ModeAttackPoint;
  public int ModeDefencePoint;
  public int ModeMovePoint;
  public int ModeHealthPoint;
  public int BaseMaxHealth;
  public int ModeExtraHealth;
  public int ModeExpPercentage;
  public int PrevModeMoney;
  public int ModeMaxMoney;
  public int ModeMaxAttackPoint;
  public int ModeMaxDefencePoint;
  public int ModeMaxMovePoint;
  public int ModeMaxHealthPoint;
  public int HealthPerModePoint;
  public List<int> ModeLevelTable;
  public int Log_TotalGainModeMoney;
  public ModeStatApplyType ApplyType;
}

public class USFHammerEventData : USFSpecialKillEventData
{
}

public class ASFHandActor : AActor
{
  public USFSkeletalMeshComponent HandMeshComponent;
  public ASFPawn PawnOwner;
  public UPhysicsAsset HandPhysicsAsset;
  public ASFWeapon AttachedWeapon;
  public USFSkeletalMeshComponent AttachedWeaponMeshComponent;
  public USFSkeletalMeshComponent OldAttachedMeshComp;
  public USFSkeletalMeshComponent WeaponHolderMesh;
  public bool bIsShowed;
  public bool bSteadyWeaponRun;
  public bool bUpdateParticlDynamicData;
  public FVector LagLocation;
  public FVector LagMax;
  public FVector LagMaxWhenZoomed;
  public FVector LagResult;
  public FRotator LastViewDirForLag;
  public FVector MeshTranslation;
  public FRotator MeshRotation;
  public float MeshFOV;
  public float WeaponSteadyLengthRate;
  public float WeaponSteadyWalkFrame;
  public float WeaponSteadyRunFrame;
  public float WeaponSteadyRate;
  public float PawnSpeed2DSq;
  public FVector CurrentPlayerViewLocation;
  public FRotator CurrentPlayerViewRotation;
}

public class ASFHardcoreBlastingGame : ASFBlastingGame
{
}

public class USFHardcoreBlastingGameScore : USFBlastingGameScore
{
}

public class ASFHardCoreTeamHUD : ASFTeamHUD
{
}

public class ASFHardCoreBlastingHUD : ASFHardCoreTeamHUD
{
}

public class ASFHardcoreEscapeGame : ASFEscapeGame
{
}

public class USFHardcoreEscapeGameScore : USFEscapeGameScore
{
}

public class ASFHardCoreEscapeHUD : ASFHardCoreTeamHUD
{
}

public class USFHardcoreOption : UObject
{
  public bool bUseEnemyCharacter;
  public bool bUseArmBand;
  public bool bHideCrosshair;
  public bool bHideHitIndicator;
  public float DamageModifier;
  public List<USFTypes.FPawnOutlineInfo> arrPawnOutlineInfo;
}

public class ASFSeizureGame : ASFTeamGameInfo
{
  public ASFSeizureGameReplicationInfo SFSeizureGRI;
}

public class ASFHardcoreSeizureGame : ASFSeizureGame
{
}

public class USFHardcoreSeizureGameScore : USFSeizureGameScore
{
}

public class ASFHardCoreSeizureHUD : ASFHardCoreTeamHUD
{
}

public class ASFHardcoreTDMGame : ASFBaseTeamDeathGame
{
}

public class USFHardcoreTDMGameScore : USFGameScore
{
}

public class ASFHardcoreTDMGRI : ASFGameReplicationInfo
{
}

public class ASFHardCoreTDMHUD : ASFHardCoreTeamHUD
{
}

public class ASFHardcoreTDMPC : ASFPlayerController
{
}

public class USFHardWaveCompleteByMap : USFWaveCompleteByMap
{
}

public class USFHeadHitCountEventData : USFWeaponEventData
{
}

public class USFHeadPointHitCountEventData : USFWeaponEventData
{
}

public class ASFHeadQuarters : AInfo
{
  public class FsRecommendNavPoint
  {
    public ASFPathNode NavPoint;
    public List<APawn> Targetting;
  }

  public class FsEnemyReport
  {
    public AActor Target;
    public UObject.FVector Loc;
    public float LastReport;
  }

  public class FsAvoidActor
  {
    public AActor TargetActor;
    public float Dist;
  }

  public class FsKillingChain
  {
    public int PID;
    public int Killing;
    public int Dying;
  }

  public class FsBombingSupport
  {
    public int TargetID;
    public float LastTime;
  }

  public class FsKillerPlaceRecord
  {
    public AController Controller;
    public List<UObject.FVector> Location;
  }

  public ASFTeamInfo myTeam;
  public ASFTeamInfo EnemyTeam;
  public List<ASFModeVolume> StrategicPoints;
  public List<ASFSquad> Squads;
  public int OrderOffset;
  public FName[] OrderList = new FName[8];
  public bool bUseSquadBalence;
  public bool bSpawnBalence;
  public List<ASFGamePlayerStart> SpawnPointsAlly;
  public List<ASFGamePlayerStart> SpawnPointsEnemy;
  public List<FsRecommendNavPoint> RecommendNavPoints;
  public List<FsEnemyReport> EnemyReports;
  public List<FsAvoidActor> AvoidActors;
  public List<FsKillingChain> KillingChains;
  public List<FsBombingSupport> BombingSupportList;
  public List<FsKillerPlaceRecord> KillerPlaceRecords;
  public float CamperMagicNumber;
  public float CoolTimeBombingSupport;
  public List<ASFPathNode> ValidPathNode;
}

public class USFHeadShotCountEventData : USFSpecialKillEventData
{
}

public class ASFHealthUpTDMGame : ASFBaseTeamDeathGame
{
}

public class USFHeroAICriticalKillEventData : USFBaseEventData
{
}

public class USFHeroAIKillEventData : USFBaseEventData
{
}

public class USFHeroAlienControllerDestroyedMessage : USFLocalMessage
{
  public string MSG_Enemy_Tower_Destroyed;
  public string MSG_Our_Tower_Destroyed;
}

public class USFHeroDeathRewardMessage : USFLocalMessage
{
  public string MSG_DeathRewardApplied;
}

public class USFHeroDestroyAlienControllerEventData : USFBaseEventData
{
}

public class USFHeroDestroyTurretEventData : USFBaseEventData
{
}

public class USFHeroKillWeaponEventData : USFBaseEventData
{
}

public class USFHeroMoneyUpMessage : USFBonusScoreUpMessage
{
}

public class USFHeroTurretDestroyedMessage : USFLocalMessage
{
  public string MSG_Enemy_Turret_Destroyed;
  public string MSG_Our_Turret_Destroyed;
}

public class ASFHideAndSeekHUD : ASFBeastHUD
{
}

public class USFHitEnemyCountEventData : USFWeaponEventData
{
}

public class ASFHoldSpot : ASFDefensePoint
{
}

public class ASFHorrorGame : ASFRoundTDMGame
{
  public string DefaultHorrorPlayerClassName;
}

public class ASFRoundTDMReplicationInfo : ASFGameReplicationInfo
{
}

public class ASFHorrorGameReplicationInfo : ASFRoundTDMReplicationInfo
{
}

public class ASFRoundTDMHUD : ASFTeamHUD
{
}

public class ASFHorrorHUD : ASFRoundTDMHUD
{
}

public class ASFHorrorPlayerController : ASFPlayerController
{
}

public class USFHudControler_interface : UInterface
{
}

public class USFImpactLight_Metal : USFExplosionLight
{
}

public class USFImportFontCharSet : UObject
{
  public class FSModeLoadingTip
  {
    public List<int> ModeIDArray;
    public string LoadingTipMode;
  }

  public FVector2D BaseScreenRes;
  public FVector2D LoadingRatePos;
  public FVector2D LoadingTipPos;
  public FVector2D LocalizedMapNamePos;
  public FVector2D InternationalMapNamePos;
  public FVector2D ClanRankingPos;
  public FVector2D ClanRankingTitlePos;
  public string LoadingTip;
  public List<string> LoadingTipCommon;
  public List<string> LoadingTipBase;
  public List<string> LoadingTipSpecial;
  public List<string> LoadingTipFun;
  public List<FSModeLoadingTip> ModeLoadingTipArray;
}

public class USFIncreaseModeMoneyEventData : USFBaseEventData
{
}

public class ASFInGameKickState : AInfo
{
  public class FsVoter
  {
    public int PlayerID;
    public EInGameVoteState VoteState;
  }

  public int Assentient;
  public int Objection;
  public int BlankBallot;
  public int TotalBallot;
  public int ValideBallot;
  public List<string> ResultStrig;
  public string DefaultResultString;
  public string VoteWithYouMessage;
  public List<FsVoter> Voters;
}

public class ASFInGameStore : AActor
{
  public class FPurchaseItem
  {
    public int ItemId;
    public int Count;
    public int UsableLevel;
    public int[] Price = new int[2];
    public int[] ResellPrice = new int[2];
    public float PriceRatio;
    public float UpgradePriceRate;
    public int GroupIndex;
    public int LogData;
    public bool InstantBuy;
    public bool bDisableInUseItem;
    public UParticleSystem Particle;
    public USoundCue SoundLink;
  }

  public class FPurchaseItemListData
  {
    public string TabName;
    public string TabImage;
    public List<ASFInGameStore.FPurchaseItem> ItemList;
  }

  public class FPurchaseInfo
  {
    public int PurchasePlayerID;
    public int PurchaseItemID;
    public int PurchaseItemDirty;
  }

  public class FSAccountBook
  {
    public int PlayerID;
    public int ItemId;
    public int Count;
  }

  public List<FPurchaseItemListData> OnSaleItemList;
  public USFUIDataProvider_InGameStore InGameStoreItemList;
  public bool bEnabled;
  public bool bOnlyPurchaseUsableLevel;
  public FPurchaseInfo PurchaseItemInfo;
  public int RepCurrentLevel;
  public int[] CurrentItemCount = new int[60];
  public List<FSAccountBook> AccountBook;
  public string CurrentMapName;
  public int CurrentShopLevel;
}

public class USFItem_Char : USFItem_Base
{
  public class FSpecialSound
  {
    public ESpecialSoundType Type;
    public USoundCue Sound;
    public float SoundPlayTime;
  }

  public ECharItemType CharItemType;
  public FName UsableUnit;
  public float LuckyPointProbability;
  public float ClanPointIncrease;
  public float ReloadSpeed;
  public float EquipSpeed;
  public float HealthIncrease;
  public int JumpIncrease;
  public float ThrowSpeed;
  public float BlastingSpeed;
  public List<FName> DisableSocketNames;
  public List<FSpecialSound> SpecialSounds;
}

public class USFItem_Char_BackPack : USFItem_Char
{
  public UParticleSystem FireEffect;
  public List<FName> FireSocketName;
  public List<UAnimSet> AnimSets;
  public UAnimTree AnimTreeTemplate;
}

public class USFItem_Char_Belt : USFItem_Char
{
}

public class USFItem_Char_Cap : USFItem_Char
{
  public bool IsDroppableHelmet;
  public bool IsExplosionHelmet;
  public UParticleSystem ExplosionEffect;
}

public class USFItem_Char_Effect : USFItem_Char
{
  public string SFPawnFXClassName;
}

public class USFItem_Char_Eye : USFItem_Char
{
}

public class USFItem_Char_Face : USFItem_Char
{
  public ESkinTextureType SkinType;
  public int FaceIndex;
  public string MorphSetName;
  public string[] RadioMsgClassName = new string[4];
  public string KillVoiceClassName;
  public string SoundEffectName;
  public string HairPhysAssetName;
  public string OverridePhysAssetName;
  public List<UAnimSet> AnimSets;
}

public class USFItem_Char_Face_Female : USFItem_Char_Face
{
}

public class USFItem_Char_Face_Male : USFItem_Char_Face
{
}

public class USFItem_Char_Glove : USFItem_Char
{
}

public class USFItem_Char_Jacket : USFItem_Char
{
}

public class USFItem_Char_Mask : USFItem_Char
{
  public bool bUseMorph;
}

public class USFItem_Char_Pants : USFItem_Char
{
}

public class USFItem_Char_Shoes : USFItem_Char
{
}

public class USFItem_Char_Suit : USFItem_Char
{
}

public class USFItem_Char_Unit : USFItem_Char
{
}

public class USFItem_Char_Wrist : USFItem_Char
{
  public FName CustomAnimName;
  public float MinDelay;
  public float MaxDelay;
}

public class USFItem_WeapOption : USFItem_Base
{
  public EWeapPartType WeapPartType;
  public EWeaponType ParentWeaponType;
  public int AdditionalDamage;
  public int AdditionalRecoil;
  public int AdditionalAccuracy;
  public int AdditionalWeaponDamageRange;
  public int AdditionalFireInterval;
  public bool IsRare;
  public bool IsBuyable;
  public bool IsWeaponParts;
}

public class USFItem_WeapOption_Sight : USFItem_WeapOption
{
  public class FWeaponAlignment
  {
    public FName WeaponClassName;
    public UObject.FVector vLocZoomIN;
    public UObject.FVector vLocZoomOut;
    public float fZoomedMeshFOV;
    public int SpecificSightType;
  }

  public FName SightCrosshair;
  public string SightRISClassName;
  public float DOFBlurStartDistance;
  public float DOFBlurEndDistance;
  public int SightRailType;
  public int SightType;
  public List<FWeaponAlignment> AlignmentInfo;
}

public class USFItem_WeapOption_DotSight : USFItem_WeapOption_Sight
{
}

public class USFItem_Common_DotSight_Reflex : USFItem_WeapOption_DotSight
{
  public List<UMaterialInstanceConstant> NewScopeMaterial;
}

public class USFItem_Functional : USFItem_Base
{
  public List<USFTypes.FSAdditionalInfo> AdditionalValueList;
  public EFuncItemType FuncItemType;
  public bool bFunctionalItemSettingChangeButton;
  public bool bHideInShop;
  public bool bHideInUsingInven;
  public bool bUseItemReconfirmMessageBox;
}

public class USFItem_Functional_Char : USFItem_Functional
{
}

public class USFItem_Func_ProvideItem : USFItem_Functional_Char
{
  public class FProvideItemData
  {
    public EGameMode UsableGameMode;
    public string ProvideItemName;
    public int ProvideItemID;
  }

  public List<FProvideItemData> ProvideItems;
  public bool ModeLimitation;
}

public class USFItem_Func_AddHealth : USFItem_Func_ProvideItem
{
  public int AddHP;
  public int MaxHP;
}

public class USFItem_Functional_Weap : USFItem_Functional
{
}

public class USFItem_Func_BombSP : USFItem_Functional_Weap
{
}

public class USFItem_Functional_ETC : USFItem_Functional
{
  public int ModeItemTargetSlot;
}

public class USFItem_Func_ChangeClanMark : USFItem_Functional_ETC
{
}

public class USFItem_Func_ChangeName : USFItem_Functional_ETC
{
  public string strSwearWordWarningMsg;
}

public class USFItem_Func_ChangeClanName : USFItem_Func_ChangeName
{
}

public class USFItem_Func_ChangeClassMark : USFItem_Functional_ETC
{
}

public class USFItem_Func_ChangeCodeName : USFItem_Func_ChangeName
{
}

public class USFItem_Func_ChangeOneLetterCodename : USFItem_Func_ChangeName
{
}

public class USFItem_Func_ChangeSpecialCodeName : USFItem_Func_ChangeCodeName
{
  public int SpecialCharSetIndex;
}

public class USFItem_Func_ChangeWeaponSet : USFItem_Functional_Weap
{
  public int WeaponSetIndex;
}

public class USFItem_Func_ChoicePackage : USFItem_Functional_ETC
{
}

public class USFItem_Functional_Clan : USFItem_Functional
{
}

public class USFItem_Func_ClanLeague : USFItem_Functional_Clan
{
}

public class USFItem_Func_ClanMarkEffect : USFItem_Functional_Clan
{
}

public class USFItem_Func_ColorClanName : USFItem_Functional_Clan
{
}

public class USFItem_Func_ColorCodeName : USFItem_Functional_ETC
{
}

public class USFItem_Func_ColorCodeNameV2 : USFItem_Func_ColorCodeName
{
}

public class USFItem_Func_CombatReport : USFItem_Functional_ETC
{
}

public class USFItem_Functional_UI : USFItem_Functional
{
}

public class USFItem_Func_Combine : USFItem_Functional_UI
{
}

public class USFItem_Func_EditCarveWeaponTag : USFItem_Functional_Weap
{
}

public class USFItem_Func_EmotionEffect : USFItem_Functional_Char
{
  public FName EmotionAnimName;
}

public class USFItem_Func_Enchant : USFItem_Functional_UI
{
  public int PartsType;
  public int PartsIndex;
}

public class USFItem_Func_Enchant_Extract : USFItem_Func_Enchant
{
}

public class USFItem_Func_EnhancedCrosshair : USFItem_Functional_UI
{
  public class FsCrossHairType
  {
    public string CrossHairImg;
    public UClass CrossHairClass;
  }

  public class FsCrossHairColor
  {
    public string CrossHairUIColor;
    public UObject.FColor CrossHairRGBColor;
  }

  public List<FsCrossHairType> CrossHairType;
  public List<FsCrossHairColor> CrossHairColor;
}

public class USFItem_Func_ExpUp : USFItem_Functional_UI
{
}

public class USFItem_Func_ExtraArmor : USFItem_Functional_Char
{
  public string DropClassName;
  public int DefencePoint;
  public bool Dropable;
  public FName SocketName;
  public FVector Translation;
  public FRotator Rotation;
  public float DefenceDir;
  public float DefenceRange;
  public List<FName> BoneNames;
  public eExtraBodyPart PartID;
  public USkeletalMesh Mesh;
  public UPhysicsAsset PhysAsset;
  public List<FName> CoverdSockets;
}

public class USFItem_Func_GashaCoupon : USFItem_Functional_UI
{
  public int nCouponCount;
  public int nBonusCouponCount;
}

public class USFItem_Func_GlowEffect : USFItem_Functional_Char
{
}

public class USFItem_Func_InfiniteMagazine : USFItem_Functional_Weap
{
}

public class USFItem_Func_InitClanWinLoseRecord : USFItem_Functional_ETC
{
}

public class USFItem_Func_InitDesertion : USFItem_Functional
{
}

public class USFItem_Func_InitKillDeath : USFItem_Functional_ETC
{
}

public class USFItem_Func_InitWeaponKillDeath : USFItem_Functional_ETC
{
}

public class USFItem_Func_InitWinLose : USFItem_Functional_ETC
{
}

public class USFItem_Func_LPGageUp : USFItem_Functional_UI
{
}

public class USFItem_Func_MagazineUp : USFItem_Functional_Weap
{
  public int TargetWeaponGroup;
  public List<EWEAPON_GROUP> TargetWeaponGroups;
  public List<string> TargetWeaponName;
  public int AddedMagazine;
  public int ConstantMagazine;
  public int MaxMagazine;
  public bool bFillAllAmmo;
}

public class USFItem_Func_MagazineUpAndGiveWeapon : USFItem_Func_MagazineUp
{
}

public class USFItem_Func_ModeStatUp : USFItem_Functional_Char
{
  public EModeStatType TargetStat;
  public EBuffType BuffEffect;
  public int IncreaseAmount;
  public int MaxAmount;
}

public class USFItem_Func_Package : USFItem_Functional_ETC
{
  public List<int> ProvideWeaponIDs;
  public string PackagePreviewMessage;
}

public class USFItem_Func_PKG_SololeagueTikcet : USFItem_Func_Package
{
  public int nTicketCount;
}

public class USFItem_Func_PKG_VIP_Capsule : USFItem_Func_Package
{
}

public class USFItem_Func_ProvideCharacter : USFItem_Func_ProvideItem
{
}

public class USFItem_Func_ProvideHealth : USFItem_Func_ProvideItem
{
}

public class USFItem_Func_ProvideWeapon : USFItem_Func_ProvideItem
{
}

public class USFItem_Func_ProvideMissionWeapon : USFItem_Func_ProvideWeapon
{
  public string DeleteWeapon;
}

public class USFItem_Func_ProvideShooterDefence : USFItem_Func_ProvideItem
{
}

public class USFItem_Func_RandomBox : USFItem_Functional_ETC
{
  public int RandomBoxType;
}

public class USFItem_Func_RandomBox_Box : USFItem_Func_RandomBox
{
  public string strRandomBoxItemName;
  public int RequiredKeyCount;
  public bool bKeyBuyDisable;
}

public class USFItem_Func_RandomBox_Key : USFItem_Func_RandomBox
{
  public string strNoticeToUseRandomBoxKey;
}

public class USFItem_Func_RandomWeaponSetAmmo : USFItem_Functional_Weap
{
  public class FSRandomWeaponAmmo
  {
    public int WeaponID;
    public int AmmoCount;
    public int AmmoCountMax;
  }

  public List<FSRandomWeaponAmmo> RandomWeaponAmmoArray;
}

public class USFItem_Func_ReduceRespawnDelay : USFItem_Functional_ETC
{
  public float ReducedRespawnDelay;
}

public class USFItem_Func_SoloLeague : USFItem_Functional_ETC
{
  public string strNoticeToUseSoloLeagueTicket;
}

public class USFItem_Func_SpectatorEnhance : USFItem_Functional_UI
{
  public int SpectatorItemVersion;
  public int SpectatorItemVersionCount;
  public List<string> SpectatorDecoImageName;
}

public class USFItem_Func_SPGageUp : USFItem_Functional_UI
{
}

public class USFItem_Func_SPImmediatelyProvide : USFItem_Func_SPGageUp
{
}

public class USFItem_Func_StoredMaterial : USFItem_Functional_ETC
{
}

public class USFItem_Functional_Camo : USFItem_Functional
{
  public List<string> Material;
  public List<string> DiffuseTexture;
  public List<string> NormalTexture;
  public List<string> SpecularTexture;
  public List<string> MaskTexture;
  public eCamoCopyType MaterialCopyType;
  public eCamoCopyType DiffuseTextureCopyType;
  public eCamoCopyType NormalTextureCopyType;
  public eCamoCopyType SpecularTextureCopyType;
  public eCamoCopyType MaskTextureCopyType;
  public List<EPartType> IgnoreParts;
  public List<EPartType> AcceptParts;
}

public class USFItem_Func_SuitCamo : USFItem_Functional_Camo
{
}

public class USFItem_Func_TpExchange : USFItem_Functional_UI
{
}

public class USFItem_Func_TPUp : USFItem_Functional_UI
{
}

public class USFItem_Func_UseFiringRangeScoreInitial : USFItem_Functional_ETC
{
}

public class USFItem_Func_VIPSystem_Coupon : USFItem_Functional_ETC
{
}

public class USFItem_Func_WeaponCamo : USFItem_Functional_Weap
{
  public ECamoType CamoType;
  public ECamoMaskType CamoMaskType;
  public string CamoTextureName;
  public List<string> CamoMaterialNames;
  public List<UClass> CamoRISClassList;
  public float ActionCamoKillTime;
}

public class USFItem_Func_WeaponParts_Removal : USFItem_Functional_Weap
{
}

public class USFItem_Func_WeaponRepairCoupon : USFItem_Functional_UI
{
  public string strNoticeToUseRepairCoupon;
}

public class USFItem_Func_WebCoupon : USFItem_Functional_UI
{
}

public class USFItem_Functional_RandomWeapon : USFItem_Functional_Weap
{
  public class FSRandomWeapon
  {
    public int WeaponID;
    public float Ratio;
  }

  public List<FSRandomWeapon> RandomWeaponArray;
  public List<FSRandomWeapon> RandomWeaponProbabilityUpArray;
}

public class USFItem_Functional_RandomWeaponProbabilityUp : USFItem_Func_ProvideItem
{
}

public class USFItem_Functional_Spray : USFItem_Functional_ETC
{
  public List<int> SprayImageIndex;
  public string Emblem_Tooltip_Not_Used;
  public string Emblem_Tooltip_Used;
  public string Emblem_Tooltip_Unavailable;
  public string Emblem_Tooltip_Not_Used_UseTypeR;
  public string Emblem_Tooltip_Used_UseTypeR;
  public bool bClanRelatedItem;
  public string DefaultTextureName;
}

public class USFItem_Functional_UserCondition : USFItem_Functional_ETC
{
}

public class USFItem_Weap : USFItem_Base
{
  public EWeaponType WeapItemType;
  public bool bNormalCamo;
  public bool bNotApplyWeaponTag;
  public bool bNotApplyWeaponCamo;
  public bool IsHaveGripAnim;
  public int UIDamege;
  public int UIFireInterval;
  public int UIRecoil;
  public int UIAccuracy;
  public int UIAmmoCount;
  public int UIAmmoCountInMgz;
  public int UIGroup;
  public int UISlot;
  public string UIMaker;
  public FVector vLocation;
  public FVector vLocationZoom;
  public FVector vStepLocation;
  public FRotator rOrgRotation;
  public FRotator rStepRotation;
  public float fScale;
  public float fFieldOfView;
  public float fZoomOutMaxFOV;
  public FVector vLocationMuzzleFlash;
  public FRotator rRotationMuzzleFlash;
  public int ReplaceAmmoCount;
  public int ReplaceAmmoCountInMgz;
  public string[] LobbyWeaponAnimSet = new string[4];
  public string[] LobbyWeaponGripAnimSet = new string[6];
  public FName LobbyWeaponSocketName;
  public string[] LobbyThirdWeaponAnimTree = new string[4];
  public string[] LobbyThirdWeapAnimSet = new string[4];
  public string AdditionalWeaponClassName;
  public int WeaponRailType;
  public List<int> NotAllowSightType;
  public List<int> NotAllowGripType;
  public List<int> NotAllowSilencerType;
  public List<int> NotAllowLaserType;
}

public class USFItem_Weap_AI : USFItem_Weap
{
  public class FsClassbyAIType
  {
    public EAITypes AIType;
    public string SpecificClassName;
  }

  public List<FsClassbyAIType> ClassbyAIType;
}

public class USFItem_Weap_AI_Charge : USFItem_Weap_AI
{
}

public class USFItem_Weap_AI_Explode : USFItem_Weap_AI
{
}

public class USFItem_Weap_AI_Melee : USFItem_Weap_AI
{
}

public class USFItem_Weap_AI_Range : USFItem_Weap_AI
{
}

public class USFItem_Weap_AR : USFItem_Weap
{
}

public class USFItem_Weap_Throw : USFItem_Weap
{
}

public class USFItem_Weap_Beacon : USFItem_Weap_Throw
{
}

public class USFItem_Weap_Flashbang : USFItem_Weap_Throw
{
}

public class USFItem_WeapOption_Sample : USFItem_WeapOption
{
}

public class USFItem_Weap_GLauncher : USFItem_WeapOption_Sample
{
}

public class USFItem_Weap_Grenade : USFItem_Weap_Throw
{
}

public class USFItem_Weap_Knife : USFItem_Weap
{
}

public class USFItem_Weap_Magazine : USFItem_WeapOption_Sample
{
}

public class USFItem_Weap_MG : USFItem_Weap
{
}

public class USFItem_Weap_PST : USFItem_Weap
{
}

public class USFItem_Weap_SG : USFItem_Weap
{
}

public class USFItem_Weap_Sight : USFItem_WeapOption_Sample
{
  public USkeletalMesh SightCrosshairSM;
}

public class USFItem_Weap_Silencer : USFItem_WeapOption_Sample
{
}

public class USFItem_Weap_SMG : USFItem_Weap
{
}

public class USFItem_Weap_Smoke : USFItem_Weap_Throw
{
  public float[] SmokeColor = new float[6];
}

public class USFItem_Weap_Special : USFItem_Weap
{
}

public class USFItem_Weap_SR : USFItem_Weap
{
}

public class USFItem_WeapOption_Barrel : USFItem_WeapOption
{
}

public class USFItem_WeapOption_Body : USFItem_WeapOption
{
  public USkeletalMesh[] WeaponTagSkeletalMesh = new USkeletalMesh[2];
}

public class USFItem_WeapOption_GLauncher : USFItem_WeapOption
{
  public UClass SubWeaponRISClass;
}

public class USFItem_WeapOption_Grip : USFItem_WeapOption
{
  public int WeapGripType;
  public int GripType;
}

public class USFItem_WeapOption_KeyRing : USFItem_WeapOption
{
  public string KeyRingPhysicsAssetName;
  public USkeletalMesh KeyRingSkelMesh;
  public USkeletalMeshComponent KeyRingSkelComp;
}

public class USFItem_WeapOption_LaserPointer : USFItem_WeapOption
{
  public string SightRISClassName;
  public int LaserType;
}

public class USFItem_WeapOption_Magazine : USFItem_WeapOption
{
}

public class USFItem_WeapOption_TacticalLight : USFItem_WeapOption
{
  public string SightRISClassName;
}

public class USFItem_WeapOption_Melee_LightFlash : USFItem_WeapOption_TacticalLight
{
}

public class USFItem_WeapOption_MuzzleFlash : USFItem_WeapOption
{
  public string MuzzleFlashStyle;
  public string MuzzleFlashColor;
  public bool bSpecialMuzzle;
}

public class USFItem_WeapOption_Scope : USFItem_WeapOption_Sight
{
  public USkeletalMesh ScopeMesh;
}

public class USFItem_WeapOption_Silencer : USFItem_WeapOption
{
  public UClass SilencerRISClass;
  public int SilencerType;
}

public class USFItem_WeapOption_Stock : USFItem_WeapOption
{
}

public class USFItem_WeapOption_Trigger : USFItem_WeapOption
{
}

public class USFItem_WeapOption_WeaponEffect : USFItem_WeapOption
{
  public string WeaponEffectStyle;
  public string SFWeaponEffectClassName;
  public List<USFTypes.FSWeaponEffect> WeaponEffect1stView;
  public List<USFTypes.FSWeaponEffect> WeaponEffect3rdView;
  public USFTypes.FSWeaponEffect WeaponEffectlobby;
}

public class USFItem_WeapOption_WeaponTag : USFItem_WeapOption
{
  public UClass WeaponTagRISClass;
  public UMaterialInstanceConstant WeaponTagMIC;
  public UTexture2D DiffuseTexture;
  public UTexture2D NormalTexture;
  public UTexture2D SpecularTexture;
  public int WeaponTagMeshIndex;
}

public class USFItemManager : UObject
{
  public class FItemElement
  {
    public int ItemId;
    public FName ItemCode;
    public EItemType ItemType;
    public string ItemClassName;
    public int ItemDataIndex;
  }

  public class FMeshPartsPackageInfo
  {
    public string PackageName;
    public ECookingVariableType CookingType;
  }

  public class FAsyncLoadSpecificClassByID
  {
    public string RequestedObjectName;
    public int RequestedItemID;
    public FScriptDelegate Callback;
  }

  public class FAsyncLoadDefaultItems
  {
    public int RequestedCount;
    public AActor Caller;
    public FScriptDelegate CallbackLoaded;
    public FScriptDelegate CallbackAllLoaded;
  }

  public class FItemClassToClassName
  {
    public string ClassName;
    public UClass ItemClass;
  }

  public class FWeaponObjectToClassName
  {
    public string ClassName;
    public UObject WeaponObject;
  }

  public class FModeItem
  {
    public string ItemCode;
    public EModeItemType ItemExclusiveModeType;
    public int ItemExclusiveModeID;
  }

  public class FSprayItem
  {
    public int EmblemID;
    public List<int> SprayItemIDArray;
  }

  public List<USFTypes.FSEventItem> LocalizedEventItems;
  public string[] LocalizedWeaponSlotName = new string[8];
  public List<FItemClassToClassName> ItemClassArray;
  public List<FWeaponObjectToClassName> WeaponObjectArray;
  public List<FItemElement> CharacterItems;
  public List<FItemElement> WeaponItems;
  public List<FItemElement> WeaponOptionItems;
  public List<FItemElement> FunctionalItems;
  public List<FModeItem> ModeItems;
  public List<int> TPExchangeItems;
  public List<int> ShopEventItems;
  public List<int> PCRoomItems;
  public List<int> VIPProvideItems;
  public List<int> VIPWeaponItems;
  public List<int> VIPCouponItems;
  public List<int> MonthlyRewardItems;
  public List<int> MonthlyRewardWeaponItems;
  public List<int> EnchantItems;
  public List<int> FeverTimeRewardItems;
  public List<int> FeverTimeSaleItems;
  public List<int> FeverTimeLpItems;
  public List<FSprayItem> SprayItems;
  public List<string> NewItems;
  public List<string> HotItems;
  public List<string> BestItems;
  public List<string> EventItems;
  public Dictionary<byte, byte> SFItemNewMappingTable;
  public List<USFGameItem.FSFItemDataNew> NewItemDataArray;
  public Dictionary<byte, byte> SFItemDailyDiscountMappingTable;
  public List<USFGameItem.FSFItemDataNew> DailyDiscountItemDataArray;
  public List<int> DiscountItemArray;
  public bool bUseItemNameFromClass;
  public List<string> ItemNameFromClassArray;
  public int ItemDefaultUseTime;
  public List<USFGameItem.FSItemCodeToID> ItemCodeToIDArray;
  public List<USFGameItem.FSSupplyCodeToID> SupplyCodeToIDArray;
  public USFUIDataStore_GashaList GashaListDataStore;
  public USFOnlineSubsystemPC OnlineSub;
  public List<FAsyncLoadSpecificClassByID> RequestedSpecificClassInfosByID;
  public List<FAsyncLoadDefaultItems> RequestedDefaultItemInfos;
  public FScriptDelegate __OnDefaultItemClassLoaded__Delegate;
  public FScriptDelegate __OnDefaultItemClassAllLoaded__Delegate;
  public FScriptDelegate __SortItemListByCASHPriceDelegate__Delegate;
  public FScriptDelegate __SortItemListBySPPriceDelegate__Delegate;
  public FScriptDelegate __SortItemListByTPPriceDelegate__Delegate;
  public FScriptDelegate __SortItemListByPriceDelegate__Delegate;
  public FScriptDelegate __SortItemListByDiscountDelegate__Delegate;
}

public class USFItemMesh : UObject
{
  public List<USFMeshParts> ItemMesh;
}

public class ASFJumpPoint : APathNode
{
  public List<ANavigationPoint> JumpDest;
}

public class ASFKActor : AKActor
{
  public class FCheckpointRecord
  {
    public UObject.FVector Location;
    public UObject.FRotator Rotation;
    public ECollisionType CollisionType;
    public bool bHidden;
    public EPhysics Physics;
  }

  public List<USFTypes.FOriginMtrlData> OriginMtrlDatas;
  public int ReplicatedMaterialIndex;
  public bool bAllowDecalsToReattach;
  public bool InitialBlockRigidBody;
  public bool InitialCollideActors;
  public bool InitialBlockActors;
  public bool bOldCollideActors;
  public UStaticMesh OriginMesh;
  public EPhysics InitialPhysics;
  public byte InitialCollisionType;
  public List<UClass> AttachPossibleClasses;
  public List<ASFProjectile> AttachedProjectilesByDamage;
  public float MeshChangeTime;
}

public class ASFKActorFromStatic : AKActorFromStatic
{
  public int MaxSliceDepth;
  public int nKDOP;
  public float LifeSpanForSlicedActor;
  public int MaxCountToSpawnAtOnce;
  public int currSliceDepth;
}

public class ASFKActorNoSync : ASFKActor
{
  public bool bCollideProjectile;
}

public class ASFKActorNoSyncSpawnable : ASFKActorNoSync
{
}

public class ASFKAsset : AKAsset
{
  public FRigidBodyState RBState;
  public float AngErrorAccumulator;
  public FVector InitialLocation;
  public FRotator InitialRotation;
  public EPhysics InitialPhysics;
  public float InitialPhysicsWeight;
  public bool InitialBlockRigidBody;
  public bool InitialCollideActors;
  public bool InitialBlockActors;
  public bool bInitialHasPhysicsAssetInstance;
  public float PhysicsWeight;
}

public class ASFKAssetNoSync : ASFKAsset
{
  public bool bCollideProjectile;
}

public class ASFKAssetMagazine : ASFKAssetNoSync
{
  public FName RootBoneName;
  public FName MagazineBoneName;
  public UPhysicsAsset MagazinePhysicsAsset;
  public float DefaultLifeTime;
  public bool bLateWakeup;
}

public class USFKeyMessage : USFLocalMessage
{
  public class FKeyMessageData
  {
    public List<string> Keys;
    public string strMessage;
  }

  public List<FKeyMessageData> KeyStrings;
}

public class USFKillByGrenadeWeapEventData : USFBaseEventData
{
}

public class USFKillBySecondWeapEventData : USFBaseEventData
{
}

public class USFKillBySpecialWeapEventData : USFBaseEventData
{
}

public class USFKillDeathRewardMessage : USFLocalMessage
{
  public string MSG_KillDeathRewardApplied;
}

public class USFKilledUserInfoMessage : USFLocalMessage
{
  public string KilledUserMessage;
}

public class USFKillMessage : USFLocalMessage
{
  public class FSKillMessage
  {
    public int AnimationType;
    public string KillMessage;
  }

  public List<FSKillMessage> KillMsgStringArray;
  public List<string> KillLocalMsgStringArray;
  public List<FSKillMessage> WeaponKillMsgStringArray;
  public List<string> WeaponKillLocalMsgStringArray;
  public USFSoundGroup_Voice KillVoice;
  public USoundNodeWave DefaultKillSound;
  public USoundNodeWave NormalKillSound;
  public USoundNodeWave SpecialKillSound;
  public USoundNodeWave RareKillSound;
  public USoundNodeWave ContinuousKillSound;
}

public class USFKillVoice : UObject
{
  public USFSoundGroup_Voice KillVoice;
}

public class ASFKillVolume : APhysicsVolume
{
  public ETeam TargetTeamToKill;
}

public class USFKillZDamageType_Fell : UKillZDamageType
{
  public float RespawnDelay;
}

public class USFKillZDamageType_FirstPersonFell : UKillZDamageType
{
}

public class ASFKnifeGame : ASFTeamGameInfo
{
}

public class USFLastManStandingMessage : USFLocalMessage
{
  public string LastManStandingSelf;
  public string LastManStandingTeam;
}

public class USFLastOneShotEventData : USFSpecialKillEventData
{
}

public class USFLastStandMessage : USFLocalMessage
{
  public string LastStandEffectON;
  public string LastStandEffectOFF;
}

public class ASFLastStandMutator : AMutator
{
  public AController LastController;
  public float[] DamageMutationRatio = new float[2];
  public float CurrentDamageRatio;
  public float ActivationTime;
  public int PlayerGapCondition;
  public int PlayerHealthCondition;
  public ETeam EnemyTeam;
}

public class ASFUnitTestCase_Base : AActor
{
  public int numFailures;
}

public class ASFUnitTestCase_LocalDB : ASFUnitTestCase_Base
{
  public List<USFLocalDB.FDataEntry> Tables;
}

public class ASFLDBTestCase_SampleTableData1 : ASFUnitTestCase_LocalDB
{
}

public class ASFLDBTestCase_SampleTableData2 : ASFUnitTestCase_LocalDB
{
}

public class ASFUnitTestRunner_Unit : AActor
{
  public bool bAutoTest;
  public bool bExitWithError;
  public bool bTotalUnitTestMode;
  public int testsRunCount;
  public int failuresCount;
  public UClass UnitTestCaseClass;
  public ASFUnitTestCase_Base UnitTestCase;
  public string LogFilename;
}

public class ASFUnitTestRunner_LocalDB : ASFUnitTestRunner_Unit
{
}

public class ASFLDBTestRunner_SampleTableData1 : ASFUnitTestRunner_LocalDB
{
}

public class ASFLDBTestRunner_SampleTableData2 : ASFUnitTestRunner_LocalDB
{
}

public class USFLimbsHitCountEventData : USFWeaponEventData
{
}

public class USFLoadingTip : UObject
{
  public float LoadingTipX;
  public float LoadingTipY;
  public float MapLocalizedNameX;
  public float MapLocalizedNameY;
  public float InternationalNameX;
  public float InternationalNameY;
  public string LoadingTip;
  public List<string> LoadingTipCommon;
  public List<string> LoadingTipBase;
  public List<string> LoadingTipSpecial;
  public List<string> LoadingTipFun;
}

public class USFLocalDB : UObject
{
  public class FDataEntry
  {
    public int DataID;
    public FName DataName;
    public USFLocalDBTableData TableData;
  }

  public UClass TableClass;
  public List<FDataEntry> Tables;
  public bool SortByIDWhenClose;
  public bool SortByNameWhenClose;
  public bool CheckDataErrWhenClose;
  public bool CheckDuplicateDataWhenClose;
  public Dictionary<byte, byte> TableIDMap;
  public Dictionary<byte, byte> TableNameMap;
  public ASFUnitTestRunner_LocalDB TestRunner;
}

public class USFLocalDBTableData : UObject
{
  public int Index;
  public UClass UnitTestRunnerClass;
}

public class USFLogCondition : UObject
{
  public int[] Condition = new int[9];
  public int[] AICondition = new int[12];
}

public class USFLogoutInterface : UInterface
{
}

public class USFLongShotEventData : USFSpecialKillEventData
{
}

public class USFLoveShotEventData : USFSpecialKillEventData
{
}

public class USFLuckyPointMessage : USFLocalMessage
{
  public string LuckyPointMessage;
  public string LuckyPointDescription;
}

public class USFManHuntBeastAssistEventData : USFBaseEventData
{
}

public class USFManHuntBeastDeadEventData : USFBaseEventData
{
}

public class USFManHuntBeastKillEventData : USFBaseEventData
{
}

public class USFManHuntBeastPlayTimeEventData : USFBaseEventData
{
}

public class USFManHuntHumanAssistEventData : USFBaseEventData
{
}

public class USFManHuntHumanDeadEventData : USFBaseEventData
{
}

public class USFManHuntHumanKillEventData : USFBaseEventData
{
}

public class USFManHuntHumanPlayTimeEventData : USFBaseEventData
{
}

public class USFManHuntKillDeathMessage : USFKillDeathMessage
{
}

public class USFManOnAStickEventData : USFSpecialKillEventData
{
}

public class USFMapBrief : UObject
{
  public class FNoChallengeLevel
  {
    public string MapName;
    public int DefaultLevel;
  }

  public List<USFTypes.FSMapCaption> Captions;
  public List<USFTypes.FSPvEDifficultyUIInfo> PVELevelList;
  public List<FNoChallengeLevel> NoChallengeLevelList;
}

public class USFMapInfo : UMapInfo
{
  public class FSFStreamLevelInfo
  {
    public EGameMode SFStreamLevel;
    public FName LevelName;
  }

  public class FCubeMapInfo
  {
    public FName CubeMapActorName;
    public UTextureCube CubeMap;
    public UObject.FVector Location;
  }

  public class FVectorParamForEffect
  {
    public FName ParamName;
    public UObject.FVector Value;
  }

  public UDynamicLightEnvironmentComponent MapLightEnvironment;
  public FVector RoundEnd_MidTones;
  public FVector RoundEnd_Shadows;
  public float RoundEnd_Desaturation;
  public FVector LensFlarePosition;
  public List<ACombatZone> CombatZones;
  public float VisibilityModifier;
  public List<FSFStreamLevelInfo> arrSFStreamLevel;
  public bool bCubeMapTextureLoaded;
  public List<FCubeMapInfo> arrWorldCubeMaps;
  public int DefaultCubeMapIndex;
  public List<ASFCustomPreview> CustomPreviews;
  public UMaterialInstanceConstant UpperMIC;
  public UMaterialInstanceConstant LowerMIC;
  public UMaterialInstanceConstant FirstHandMIC;
  public UMaterialInstanceConstant HelmetMIC;
  public UMaterialInstanceConstant RankMIC;
  public UMaterialInstanceConstant PriWeaponDiffuse;
  public UMaterialInstanceConstant PriWeaponMask;
  public UMaterialInstanceConstant SecWeaponDiffuse;
  public UMaterialInstanceConstant SecWeaponMask;
  public List<UMICforSFCubeMap> arrMICForSFCubeMap;
  public float MinDistanceFromFriendForRespawn;
  public float FriendRadiusForRespawn;
  public float EnemyRadiusForRespawn;
  public float HeightWeightForRespawn;
  public float LastRespawnDelay;
  public int CheckColleagueForRespawn;
  public float EnemyDistanceScore;
  public float WalkableFloorDegree;
  public float CustomGravityScalingForRagdollPawn;
  public List<FVectorParamForEffect> VectorParametersForEffect;
}

public class USFPlayerLogEventData : USFBaseEventData
{
}

public class USFMatchOverCounterEventData : USFPlayerLogEventData
{
}

public class USFMatchOverPlayerCounterEventData : USFPlayerLogEventData
{
}

public class USFMaterialImpactEffect : USFPhysicalMaterialProperty
{
  public List<FMaterialImpactEffect> ImpactEffectStore;
  public FName PhysicalMaterialType;
}

public class USFMCResourceManager : UObject
{
  public class FAsyncItemResourceInfo
  {
    public AActor Caller;
    public int RequestCount;
    public List<USFMeshBuilder.FMeshGroup> OwnerMeshGroups;
    public List<USFMeshBuilder.FMeshPart> MeshParts;
    public UTexture2D CamoTexture;
    public UMorphTargetSet FaceMorphSet;
    public FScriptDelegate Callback;
  }

  public class FRequestedResource
  {
    public string ObjectName;
    public int MeshPartIndex;
    public EAsyncRequestType Type;
    public AActor Caller;
  }

  public List<FAsyncItemResourceInfo> RequestedItemResourceInfos;
  public List<FRequestedResource> RequestedResourceInfos;
  public USFItemManager ItemManager;
}

public class USFMeshBlendingScheduler : UObject
{
  public EMeshBlendingSchedulerState SchedulerState;
}

public class USFMessageByKismet : USFLocalMessage
{
}

public class ASFMinimapActor : AActor
{
  public class FMiniMapImageAdjustmentData
  {
    public UUIRoot.FUIImageAdjustmentData Horizontal;
    public UUIRoot.FUIImageAdjustmentData Vertical;
  }

  public class FsMiniMapLayer
  {
    public float HeightMax;
    public float HeightMin;
    public UTexture2D LayerTexture;
    public UTexture2D ChallengerNavigationLayerTexture;
    public UTexture2D DefenderNavigationLayerTexture;
    public float HeightAverage;
    public int nLayer;
  }

  public UTexture2D MiniMapTexture;
  public float OpacityRatio;
  public bool ShowEditorWidget;
  public bool PrimaryMinimap;
  public float WholeMapScaleVaule;
  public float WholeMapRedTeamRotationVaule;
  public float WholeMapBlueTeamRotationVaule;
  public float WholeMapRotationVaule;
  public FVector ObserverTopViewLocation;
  public FRotator ObserverTopViewRotation;
  public int WorldSizeX;
  public int WorldSizeY;
  public UStaticMeshComponent StaticMeshComponent;
  public UMaterialInstanceConstant OverayMaterial;
  public List<FsMiniMapLayer> MiniMapLayers;
}

public class USFMissionEventData : USFBaseEventData
{
}

public class USFMission1EventData : USFMissionEventData
{
}

public class USFMission2EventData : USFMissionEventData
{
}

public class USFMission3EventData : USFMissionEventData
{
}

public class USFMissionScoreEventData : USFBaseEventData
{
}

public class USFTotalPlayGameCountEventData : USFBaseEventData
{
}

public class USFModePlayGameCountEventData : USFTotalPlayGameCountEventData
{
}

public class USFMultiKillEventData : USFSpecialKillEventData
{
}

public class USFMuzzleFlashLight_GL : USFExplosionLight
{
}

public class USFMuzzleFlashLight_Pistol : USFExplosionLight
{
}

public class USFMuzzleFlashLight_Rifle : USFExplosionLight
{
}

public class USFMuzzleFlashLight_SilencerRifle : USFMuzzleFlashLight_Rifle
{
}

public class USFMuzzleFlashLight_TeslaCanon : USFExplosionLight
{
}

public class USFNormalWaveCompleteByMap : USFWaveCompleteByMap
{
}

public class USFObjectPool : UObject
{
  public class FMoviePlayerInfo
  {
    public FName MoviePlayerClassName;
    public UGFxMoviePlayer MoviePlayer;
  }

  public class FMergedMeshCacheDatum
  {
    public EMeshGroup MeshGroupLabel;
    public string IDString;
    public USkeletalMesh MergedMesh;
    public double LastAccessTime;
  }

  public List<UObject> arrNewObjList;
  public USFEventDataManager EventDataManager;
  public USFConditionManager ConditionManager;
  public USFAwardManager AwardManager;
  public USFItemManager ItemManager;
  public USFMCResourceManager MCResourceManager;
  public USFMeshBuilder MeshBuilder;
  public USFSprayTextureManager SprayTextureManager;
  public USFRenderTextureManager RenderTextureManager;
  public List<FMoviePlayerInfo> arrMoviePlayer;
  public List<string> DisableLogModeNameArray;
  public int MergedDataCacheMax;
  public float MergedDataCacheCheckTime;
  public List<FMergedMeshCacheDatum> MergedMeshCache;
  public ASFSpawnedEmitter[] RainDropSelfEmitterList = new ASFSpawnedEmitter[20];
  public int RainDropSelfEmitterListIdx;
}

public class ASFObserverController : ASFPlayerController
{
  public bool IsTranslucentView;
  public bool bShowIFFParticle;
  public bool bSetRenderOptions;
  public bool bIsDrawModeInfo;
  public bool bShowHUDCodeName;
  public bool bShowMinimap;
  public bool bShowLinebottom;
  public bool bShowCombatMsg;
  public bool bUseShowMinimap;
  public bool bUseShowCombatMsg;
  public bool bUseShowLineBottom;
  public USFCCTV CCTV;
  public EObserverViewMode OldViewMode;
  public EObserverViewMode CurrentViewMode;
  public ETeam OldViewTeam;
  public ETeam CurrentViewTeam;
  public EObserverShowArmBand ShowArmBandMode;
  public EObserverShowArmBand PrevArmBandMode;
  public FVector OldLocation;
  public FRotator OldRotation;
  public UMaterialInterface TranslucentRedMaterial;
  public UMaterialInterface TranslucentBlueMaterial;
  public UMaterialInterface TranslucentDefaultMaterial;
  public List<ETeam> DrawOutlineTeamList;
  public int CurrentDrawOutlineIdx;
  public string ProjectileTrailName;
}

public class USFObserverInput : UPlayerInput
{
}

public class ASFPrimaryTargetActor : ASFObstaclesActor
{
  public FVector OriginStep;
  public FRotator OriginRot;
  public bool bIconState;
}

public class ASFObstaclesActor_AlienController_Warrior : ASFPrimaryTargetActor
{
  public List<USFTypes.FSDamageResist> DamageResistList;
  public float OutLineOverlapDistance;
}

public class ASFOnetoOneGame : ASFRoundTDMGame
{
  public byte DefaultObserverCount;
  public List<byte> DefaultPlayerCount;
}

public class ASFOnetoOneGameReplicationInfo : ASFGameReplicationInfo
{
}

public class ASFOnetoOneHUD : ASFRoundTDMHUD
{
}

public class ASFOnetoOneObserverController : ASFObserverController
{
}

public class USFOnetoOneObserverInput : USFObserverInput
{
}

public class ASFOnetoOnePlayerController : ASFPlayerController
{
}

public class USFOnlineSubsystemInternet : UObject
{
  public class FHTTP_ARG
  {
    public string strArgName;
    public string strArgValue;
  }

  public FPointer _hOpen;
  public FPointer _hConnection;
  public FPointer _hRequest;
  public string[] BaseUrl = new string[38];
  public int ClanServerPort;
  public string strPlayerUSN;
  public List<string> ResponseResultArray;
  public List<FHTTP_ARG> ArgsArray;
  public FScriptDelegate __OnHandlingErrorDelegate__Delegate;
  public FScriptDelegate __OnRequestChangedDelegate__Delegate;
}

public class USFOnlineSubsystemPCBase : UOnlineSubsystemPC
{
  public class FConnectionPolling
  {
    public float ConnectionStartTime;
    public USFServerConnection Connection;
  }

  public List<FConnectionPolling> ConnectionPollings;
  public UPacket g_packet;
  public string PlayerIP;
  public string PlayerLoginViewID;
  public string ProfileFileName;
  public List<FPointer> AsyncTasks;
  public List<USFServerConnection> ServerConnectionArray;
}

public class USFOnlineSubsystemPC : USFOnlineSubsystemPCBase
{
  public bool UseMessenger;
  public bool bEnableHackReport;
  public bool bUseEventSubLanguage;
  public bool bHackReportSended;
  public bool PlayerIsLogined;
  public bool bLoginFromLoginView;
  public bool PlayerIsGhostMode;
  public bool bChangeLoginEUR;
  public bool bCollectMacAddress;
  public bool bInitSSOWebBrowser;
  public bool bSuccessAuthCode;
  public bool bEncryptLoginPacket;
  public bool bOriginBrowser;
  public bool bForceAdult;
  public bool bCashChargeWeb;
  public bool bIsMiniGacha;
  public bool bUseFacebook;
  public bool bSteamActivated;
  public USFOnlineSubsystemInternet Internet;
  public USFFacebookManager FacebookManager;
  public string PlayerLoginViewPW;
  public string PlayerConnectID;
  public string PlayerConnectPW;
  public string PlayerLoginOKID;
  public string PlayerCodeName;
  public string PlayerTicket;
  public int PlayerUSN;
  public byte PlayerGradeLV;
  public byte PlayerIDIsFirst;
  public string PlayerUniID;
  public int PlayerCreateLV;
  public int PlayerIsAdult;
  public string PlayerAddInfos;
  public int ClanSN;
  public string SpareCookie;
  public ulong PlayerFacebookID;
  public string PlayerFacebookToken;
  public string BlockExpirationDate;
  public int LoginedServerYear;
  public int LoginedServerMonth;
  public int LoginedServerDay;
  public int LoginedServerHour;
  public int LoginedServerMinute;
  public int LoginedServerTimeM;
  public int LoginOKCount;
  public string QueryAuthorizationCode;
  public float DelayTime;
  public float fPingSendTime;
  public int nPingTime;
  public string BillingPageBase;
  public string BillingPageWebPage;
  public int AppID;
  public int PamentGroup;
  public string AppSecret;
  public string ContentType;
  public float ElapsedTimeFromLoginS;
  public float ElapsedLoginTimeForTest;
  public float LoginedLocalTimeS;
  public int PrevNotifyTimeM;
  public string LastRequestItemTableTime;
  public USFPacketCryptHelper CryptHelper;
  public string InGameForceExitMessage;
  public string CashChargeURL;
  public string CashChargeURL_EUR;
  public string CashChargeURL_USA;
  public List<int> WaitingAckProtocolArray;
  public float LastSendTime;
  public float WaitingTimeOutTime;
  public string RequestSupplyCode;
  public List<FName> AdditionalGoreSuppress;
  public FPointer WebBrowserControl;
  public FPointer WebBrowserEvent;
  public FPointer SteamManager;
  public int WebControlLastError;
  public string OpenWebTargetFrameName;
  public string OpenWebHeaders;
  public string OpenWebPostData;
  public int OpenWebPostDataLen;
  public List<USFOnlineSubsystemInternet.FHTTP_ARG> ArgsArray;
  public List<USFTypes.FSRecvPacketHandler> RecvPacketHandlerArray;
  public FScriptDelegate __OnPacketRecv__Delegate;
  public FScriptDelegate __OnChangedWaitingAckSize__Delegate;
  public FScriptDelegate __OnNotifyMinuteHasPassedDelegate__Delegate;
  public FScriptDelegate __OnOpenForceExitDialog__Delegate;
  public FScriptDelegate __OnHandlingPacketErrorDelegate__Delegate;
  public FScriptDelegate __OnCashChargePageClosedDelegate__Delegate;
  public FScriptDelegate __OnProcessTwitchTVCallback__Delegate;
  public FScriptDelegate __OnProcessTwitchTVCallbackInGame__Delegate;
  public FScriptDelegate __DisconnectedMessengerserverDelegate__Delegate;
}

public class USFOnlineSubsystemPCCHN : USFOnlineSubsystemPC
{
  public List<USFTypes.FSPacketError> LoginPacketErrorArray;
  public string SaveVerifyCodeImagePath;
  public string ModuleCodeImage;
  public string ModuleMatrixImage;
  public bool bIsVerifyNeedCheck;
  public bool bIsMatrixNeedCheck;
  public bool bIsForceVerifyCapthcha;
}

public class USFOnlineSubsystemPCDedi : USFOnlineSubsystemPCBase
{
  public FScriptDelegate __ProcessDediRecvPacketDelegate__Delegate;
}

public class USFOnlineSubsystemPCESP : USFOnlineSubsystemPC
{
  public int FrameWidth;
  public int FrameHeight;
  public string CmdParam;
  public List<string> GGOParamArray;
  public string GGOLoginParam;
  public string GGOParserParam;
  public bool IsLoginAuthorizationCode;
}

public class USFOnlineSubsystemPCEUR : USFOnlineSubsystemPC
{
}

public class USFOnlineSubsystemPCIDN : USFOnlineSubsystemPC
{
  public class FSNMAuthError
  {
    public int ErrorID;
    public string ResultMsg;
  }

  public string GameCode;
  public string RedirectUrl;
  public string Domain;
  public string XmlURL;
  public string OSSWebDomain;
  public string OSSWebactCookieURL;
  public string OSSWebrefCookieURL;
  public string OSSWebpathValueName;
  public int QueryInfoStatusCode;
  public bool IsLoginSuccess;
  public bool IsLoginProcessExecution;
  public string UserToken;
  public string AuthErrorMsg;
  public string AuthErrorCode;
  public int QueryInfoStatesCode;
  public List<FSNMAuthError> NMAuthErrorArray;
}

public class USFOnlineSubsystemPCJPN : USFOnlineSubsystemPC
{
}

public class USFOnlineSubsystemPCKOR : USFOnlineSubsystemPC
{
}

public class USFOnlineSubsystemPCPMS : USFOnlineSubsystemPC
{
  public List<string> ContactDomain;
  public int FrameWidth;
  public int FrameHeight;
  public string ConnectFacebookURL;
  public string ConnectGoogleURL;
  public string AuthenticURL;
  public int LoginDomain;
}

public class USFOnlineSubsystemPCTHA : USFOnlineSubsystemPC
{
  public int FrameWidth;
  public int FrameHeight;
  public string CmdParam;
  public List<string> GGOParamArray;
  public string GGOLoginParam;
  public string GGOParserParam;
  public bool IsLoginAuthorizationCode;
}

public class USFOnlineSubsystemPCTWN : USFOnlineSubsystemPC
{
}

public class USFOnlineSubsystemPCWeb : USFOnlineSubsystemPC
{
  public string AuthURL;
  public string TestAuthURL;
  public string AuthCodeWord;
  public string ValidateURL;
  public string TestValidateURL;
  public int WebControlWidth;
  public int WebControlHeight;
  public int WebControlPosXRatio;
  public int WebControlPosYRatio;
  public string PublisherSteamAuthURL;
  public string PublisherSteamInterlockURL;
  public string PublisherSteamInterlockResponseURL;
  public string TestPublisherSteamAuthURL;
  public string TestPublisherSteamInterlockURL;
  public string TestPublisherSteamInterlockResponseURL;
  public string TestLoginURL;
  public FScriptDelegate WebLoginOKdelegate;
  public FScriptDelegate WebLoadingCompletedelegate;
  public FScriptDelegate SetWebLoginAutoSizedelegate;
  public FScriptDelegate __NotiWebLoginOK__Delegate;
  public FScriptDelegate __NotiWebLoadingComplete__Delegate;
  public FScriptDelegate __SetWebLoginDialogSize__Delegate;
  public FScriptDelegate __SetWebLoginAutoSize__Delegate;
}

public class USFOnlineSubsystemPCUSA : USFOnlineSubsystemPCWeb
{
}

public class ASFOutLineVolume : AVolume
{
  public class FOutlineColor
  {
    public ETeam AllowToSeeTeamIndex;
    public byte OutLineColorIndex;
  }

  public ETeam TargetTeam;
  public float OutLineIntense;
  public float OutLineCullDistance;
  public float OutLineOverlapDistance;
  public float OutLineFadeTime;
  public float OutlineWidth;
  public List<FOutlineColor> OutlineColorInfo;
}

public class ASFOutlineVolumeDynamic : ASFOutLineVolume
{
  public bool bIsSuppressInCovertActivities;
  public List<ASFPawn> PawnsInVolume;
}

public class USFPackageItem : UObject
{
  public List<USFTypes.FSPackageItem> PackageItemArray;
}

public class USFPacketError : UObject
{
  public List<USFTypes.FSPacketError> PacketErrorArray;
  public List<USFTypes.FSInternetError> InternetErrorArray;
}

public class USFPacketProcessor : UObject
{
  public USFOnlineSubsystemPC SFOSPC;
  public USFOnlineSubsystemPCDedi SFOSPCDedi;
  public string DediGSIP;
  public int DediGSPort;
  public int PIDForTransactionInGameItemData;
  public int nInGameItemData;
}

public class USFParticleModuleEventSendToGame : UParticleModuleEventSendToGame
{
}

public class USFParticleModuleResistance : UParticleModuleAcceleration
{
  public EResistanceMethod ResistMethod;
  public float ResistanceRatio;
}

public class USFParticleSystemComponent : UParticleSystemComponent
{
  public bool bHasSavedScale3D;
  public FVector SavedScale3D;
}

public class USFWorldCubeMapComponent : UActorComponent
{
  public class FSMaterialInfo
  {
    public UMeshComponent Mesh;
    public List<UMaterialInstanceConstant> arrMIC;
  }

  public List<FSMaterialInfo> arrMaterialInfo;
  public USFMapInfo SFMI;
  public int nCubeMapInfoIndex;
}

public class ASFPawn : AGamePawn
{
  public class FEventServePart
  {
    public EServePartEvents EventName;
    public ECharItemType PartIndex;
    public int ServeItem;
  }

  public class FSAimProfileInfo
  {
    public EWeapAimProfile AimProfile;
    public FName ProfileName;
  }

  public class FFlashBangPostEffect
  {
    public float AlphaPower;
    public float WhiteOutPower;
    public float Lifetime;
    public float RemainTime;
    public bool SceneCaptured;
    public float BlendOutStartTimeRate;
    public float BlendOutEndTimeRate;
    public float WhiteOutStartTimeRate;
    public float WhiteOutEndTimeRate;
    public float SoundDuration;
    public float SoundFadeOutDuration;
  }

  public class FDistortionPostEffect
  {
    public float RatioTime;
    public float RatioTimeRate;
    public float Lifetime;
    public float RemainTime;
  }

  public class FSKillAssist
  {
    public byte Damage;
    public int AttackerPlayerID;
    public int LadderDiff;
    public int WeaponID;
    public float LastDamagedTime;
    public UClass DamageType;
  }

  public class FSAimingInfo
  {
    public int HitDistance;
    public UObject.FVector HitLocation;
    public AActor HitActor;
    public FName HitBone;
  }

  public class FRequestDamageInfo
  {
    public APawn Attacker;
    public APawn Victim;
    public USFTypes.FSFTakeHitInfo HitInfo;
    public AActor DamageCauser;
    public UObject.FVector AttackerLocation;
    public EBodyParts bodyParts;
    public byte FiringMode;
    public int RecoilCRC;
  }

  public class FsIgnoreDamageTypeList
  {
    public UClass DamageType;
    public float EndTime;
  }

  public class FBonePartsTable
  {
    public FName BoneName;
    public EBodyParts BodyPart;
  }

  public bool bWasCrouched;
  public bool bLeangingStarted;
  public bool bComponentDebug;
  public bool bFixedView;
  public bool UseDefaultMesh;
  public bool bWearingDroppableHelmet;
  public bool bWearingExplosionHelmet;
  public bool bIsZoomedThird;
  public bool bNoClampLastTakeHitDamage;
  public bool bUseMorph;
  public bool bUsingFootPlacement;
  public bool bUsingFootPlacementWhenCrouch;
  public bool bEnableLookAt;
  public bool bPlayPawnLanded;
  public bool bKillCamPlayedDeath;
  public bool bKillCamRestore;
  public bool bDeathAnimBlendToMotors;
  public bool bEnableSkelControlRot;
  public bool bUseSkelControlRot;
  public bool bWalkingRotationAimStop;
  public bool bIgnoreBlockedByPawn;
  public bool bCheckedJumpOffInLadder;
  public bool bDamaged;
  public bool bMaim;
  public bool bWarnAimed;
  public bool bNotifyFiring;
  public bool bInBlockSightArea;
  public bool bInBlurSightArea;
  public bool bInitSavedLocation;
  public bool bGodMode;
  public bool HEBlendOut;
  public bool bAdjustStoppingPower;
  public bool bIgnoreStoppingPowerWhenRecover;
  public bool bPeriodicRecordingForKillCam;
  public bool bFullRagDollApplied;
  public bool bItemListUpdated;
  public bool bLocalPawn;
  public bool bZoomWalking;
  public bool bSprintIgnore;
  public bool bExposed;
  public bool bNoticed;
  public bool bNotifiedFallDeadBody;
  public bool bStun;
  public bool IsObserverViewStun;
  public bool bCanDropWeaponOnDeath;
  public bool bAllowRagdoll;
  public bool bUseLeaning;
  public bool bEnableBackSlash;
  public bool bHideDeadbody;
  public bool bShowAimedCodename;
  public bool bEnableTopView;
  public bool bUseNotifyBumpLevel;
  public bool bCanInfluenceKnockBack;
  public bool bNeedToAdjustMeshTranslation;
  public bool IgnoreItemEffects;
  public bool bUpdateLastDiscoveredTime;
  public bool bDiscovered;
  public bool bUseKillVoice;
  public bool bAllowFirstPersonCamera;
  public bool bDisplayCodeNameOn3rdCam;
  public bool IsBoss;
  public bool bUseSpawnAnim;
  public bool bIsAsyncLoading;
  public bool bComposePawnMeshByFGC;
  public bool IsExigencyKill;
  public bool bForceCriticalHeadshot;
  public bool bUseImpactEffect;
  public bool bUseThirdPersonCamPlay;
  public float SprintingPct;
  public float SlowDownPct;
  public float ForwardVelocity;
  public float LeftwardVelocity;
  public float TargetDirection;
  public int LeaningTargetRoll;
  public int PrevPawnYaw;
  public int MaxLeaningRoll;
  public UDynamicLightEnvironmentComponent LightEnvironment;
  public USFWorldCubeMapComponent WorldCubeComp;
  public FName PostProcessVolumeName;
  public float fLastUpdateCharacterLightEnv;
  public FVector FixedViewLoc;
  public FRotator FixedViewRot;
  public float CameraScale;
  public float CurrentCameraScale;
  public float CameraZOffset;
  public float DefaultCameraZOffset;
  public USkeletalMesh DefaultCharMesh;
  public UCylinderComponent RigidBodyCollisionCylinder;
  public float CollisionRadiusForPawn;
  public string EditorDefaultCharMeshPath;
  public ASFDropOnlyHelmet HelmetActor;
  public UPhysicsAsset HelmetPhysAsset;
  public USkeletalMesh DefaultHelmetMesh;
  public USkeletalMesh MCHairMesh;
  public USkeletalMesh HelmetHairMesh;
  public EHelmetStatus HelmetStatus;
  public byte CurrentInventoryGroup;
  public EGender Gender;
  public byte LastTakeHitInfo_HitBoneIndex;
  public byte LastTakeHitInfo_Mask;
  public ESpeedDirection SpeedDir;
  public EWeaponState WeaponStateOld;
  public byte ImpactInfos;
  public byte bIsSpawnProtection;
  public ETeam PawnTeamNum;
  public EBuffState[] BuffList = new EBuffState[18];
  public EBuffState[] PrevBuffList = new EBuffState[18];
  public EAINOISE_TYPE NoiseState;
  public int HelmetPoint;
  public List<FBonePartsTable> BoneNameToBodyParts;
  public float ExplosionAPRatio;
  public int ArmorPoint;
  public int LastKillType;
  public float RagdollLifespan;
  public float CustomGravityScaling;
  public float SlopeBoostFriction;
  public List<FName> NoBlockZeroExtentBodyArray;
  public FName HeadBoneName;
  public FName HelmetBoneName;
  public float ReflexScopeDistance;
  public List<FSAimProfileInfo> AimProfileInfo;
  public USFTypes.FSFTakeHitInfo LastTakeHitInfo;
  public int LastTakeHitInfo_Damage;
  public FVector LastTakeHitInfo_HitLocation;
  public FVector LastTakeHitInfo_Momentum;
  public UClass LastTakeHitInfo_DamageType;
  public int LastTakeHitInfo_WeaponID;
  public AActor LastTakeHitInfo_DamagedBy;
  public int LastTakeHitInfo_DamagedByPID;
  public int LastTakeHitInfo_HitType;
  public FVector FreeCamStartPos;
  public int RootYaw;
  public float RootYawSpeed;
  public int MaxYawAim;
  public FVector2D CurrentSkelAim;
  public UAnimNodeAimOffset AimNode;
  public List<USFTypes.FSFaceMorphNode> FaceMorphNodeArray;
  public USkelControlFootPlacement LeftLegControl;
  public USkelControlFootPlacement RightLegControl;
  public float OverrideFootOffset;
  public USkelControlLookAt LookAtControl;
  public float CrouchTranslationOffset;
  public FVector MeshTranslationOffset;
  public float MeshYawOffset;
  public float MeshFloorZOffset;
  public float MeshFloorConformTranslation;
  public float MaxConformToFloorMeshTranslation;
  public float MeshFloorConformTransSpeed;
  public float LookAtMinDistance;
  public float LookAtMaxDot;
  public USFAnimNodeSlot FullBodyNode;
  public USFAnimNodeSlotPerBone UpperBodyNode;
  public FName PawnLandedAnim;
  public FName PawnActionAnim;
  public USFAnimBaseBlendNode BaseBlendNode;
  public FName HeadSocketName;
  public USkeletalMeshSocket HeadSocket;
  public USkeletalMeshComponent HeadMeshComp;
  public USkeletalMeshComponent HelmetHairMeshComp;
  public float CrouchJumpZ;
  public float CrouchChangeLength;
  public float CrouchChangeStartTime;
  public float KillCamDiedTime;
  public List<USFTypes.FSKillCamProjectile> KillCamProjectileArray;
  public int KilledProjectileID;
  public UClass DeathAnimDamageType;
  public FVector DeathAnimHitLoc;
  public List<FName> SpringBonesName;
  public float DeathDamageRadius;
  public float PlayDeathTime;
  public UClass ThirdAnimNameClass;
  public List<USkelControlSingleBone> SkelRotationCtrlList;
  public float WalkingRotationAim;
  public List<float> SpeedDirPct;
  public FVector ActorSpaceAccel;
  public float MaxSpeed;
  public float MinSpeed;
  public float MaxSpeedWeight;
  public float MinSpeedWeight;
  public float MaxSpeedRatio;
  public float ReloadSpeed;
  public float EquipSpeed;
  public float HealthIncrease;
  public int JumpIncrease;
  public float ThrowSpeed;
  public float BlastingSpeed;
  public float GearWeight;
  public float LuckyPointProbability;
  public float FollingDamageDecrement;
  public float ClanPointIncrease;
  public float AdditionalThrowVelocity;
  public List<FName> DisableSocketNames;
  public List<USFItem_Char.FSpecialSound> SpecialSounds;
  public int PostEffectRefInfo;
  public FFlashBangPostEffect FlashBangEffect;
  public FDistortionPostEffect DistortionEffect;
  public UClass SFPostEffectClass;
  public float ShockDamage;
  public int ShockDamageRep;
  public float MinElectricShockInterval;
  public float MaxElectricShockInterval;
  public float MaxElectricShockDuration;
  public FVector MinElectricShockImpulse;
  public FVector MaxElectricShockImpulse;
  public float ElectricShockDuration;
  public float JumpOffPawnTime;
  public int JumpOffPawnCount;
  public int MaxJumpOffPawnCountForDamage;
  public ALadderVolume JumpOffVolume;
  public int KillAssistMinDmg;
  public FSKillAssist[] KillAssistArray = new FSKillAssist[4];
  public List<USFTypes.FWeaponItemIDSet> CachedCurrentWeaponItems;
  public FSAimingInfo AimingInfo;
  public float fLastUpdateAimInfo;
  public float DamagedTime;
  public float MaimTime;
  public float LastUpdateBlockSightArea;
  public float LastUpdateBlurSightArea;
  public List<USFTypes.FsDOT> SteadyDOTs;
  public List<USFTypes.FsDOT> ActiveDOTs;
  public float ProjectileDOTExpireTime;
  public float fSpeedNow;
  public float RemoteViewPitchBlendSpeed;
  public int BlendedRemoteViewPitch;
  public FVector SFSavedLocation;
  public FRotator SFSavedRotation;
  public int SavedZoomState;
  public int CachedHitType;
  public FVector[] ImpactLocation = new FVector[32];
  public USFPawnFX SFPawnFX;
  public string SFPawnFXClassName;
  public float HEStartPhysicsWeight;
  public float HEMomentumMultiplier;
  public float HEBlendOutTime;
  public List<FName> HEFixedBones;
  public FName BoneNameToDisplayDelta;
  public float ModifyIndirectLightIntense;
  public float ModifyIndirectLightIntenseDuration;
  public float ModifyIndirectLightIntenseSinPeriod;
  public float IndirectLightIntenseWhenHit;
  public float IndirectLightIntenseWhenHitDuration;
  public float SpawnProtectionIndirectLightIntense;
  public float SpawnProtectionIndirectLightSinPeriod;
  public float AppliedStoppingPower;
  public float AppliedStoppingPowerDuration;
  public float AppliedAccelRatePctWhenStoppingPowerDuration;
  public List<FName> BoneNameToStoppingPower;
  public float LastHitTime;
  public int CurrentWeaponSet;
  public ASFPlayerReplicationInfo CachedPRI;
  public FVector CodeNameOffset;
  public float ThirdPersonCameraScale;
  public float ThirdPersonCameraScaleAtMatchIsOver;
  public float ThirdPersonCameraScaleInterpSpeed;
  public ASFDroppedPickup CurrentValidDroppedPickUp;
  public ASFProj_Arrow NailProj;
  public float FallingDownDamagePct;
  public FVector DyingLocation;
  public FVector DyingMomentum;
  public FRotator DyingRotation;
  public FName DyingAnimationName;
  public float DyingTime;
  public float RecordingPeriod;
  public float PerioicRecordingDeltaTime;
  public List<UMeshComponent> TempAttaedMeshes;
  public float FBReduceWhiteOutRatio;
  public float FBReduceAlphaRatio;
  public float DistanceFromLocalView;
  public float DotFromLocalView;
  public float DotToLocalView;
  public ASFWeapon OldWeapon;
  public UClass DefaultAnimSetWeaponClass;
  public int[] PawnItemIDTable = new int[14];
  public int PlayerID;
  public List<int> PawnItemList;
  public List<int> PendingHandItemList;
  public float AutoMessageHearingDistance;
  public USFPhysicalMaterialProperty LastFootStepPhysicalMaterialProperty;
  public List<FName> NotifyFallDeadBodyBones;
  public float DiedTime;
  public float HelmetDropTime;
  public int BodyLevelMarkMaterialIndex;
  public int BodyLevelClanMaterialIndex;
  public int HelmetLevelMarkMaterialIndex;
  public float ChangedGroundSpeedRate;
  public float StunRemainingTime;
  public float StunLookInputSpeed;
  public float StunDurationTime;
  public int StunInputCounterToReduceOneSec;
  public FName HeadPointSocketName;
  public USkelControlLimb IKCtrl_RightHand;
  public USkelControlLimb IKCtrl_LeftHand;
  public USkelControlLimb IKBoneCtrl_RightHand;
  public USkelControlLimb IKBoneCtrl_LeftHand;
  public USkelControlSingleBone IKRotCtrl_RightHand;
  public USkelControlSingleBone IKRotCtrl_LeftHand;
  public List<AActor> EnteredBarricades;
  public List<FRequestDamageInfo> arrRequestDamage;
  public float WeaponBaseDamage;
  public float ForceLocationPeriod;
  public float ForceLocationTime;
  public List<string> DefaultProvideWeaponNames;
  public float ReduceDamageAmountRatio;
  public int LinkedPhysicResourceIndex;
  public float TimeStampEnteredRevivingState;
  public List<FsIgnoreDamageTypeList> IgnoreDamageTypeList;
  public int KamikazeKillCount;
  public float[] BuffActivatedTime = new float[18];
  public int BuffListChangeCount;
  public float[] PrevBuffActivatedTime = new float[18];
  public float[] LocalBuffActivatedTime = new float[18];
  public float[] BuffTimeList = new float[18];
  public float DamageRatio;
  public List<USFTypes.FPawnOutlineInfo> arrPawnOutlineInfo;
  public USFAnimBlendBase UsingVehicle;
  public float DefaultGroundFriction;
  public FName EmotionAnimName;
  public List<FEventServePart> EventServeParts;
  public float ExtendDamageDepictionColor;
  public float ExtendDamageDepictionMesh;
  public FVector OriginalTrans;
  public List<int> PurchacedWeaponIDsAtInGameStore;
  public float SearchDelay;
  public float LastSearchedTime;
  public float LastDiscoveredTime;
  public UMaterialInstanceConstant ClanMarkMaterial;
  public List<UMaterialInstanceConstant> SprayMaterialList;
  public string[] RadioMsgClassName = new string[4];
  public UClass[] RadioMessageClass = new UClass[4];
  public string KillVoiceClassName;
  public UClass KillVoiceClass;
  public List<ASFWeapon> GivenWeaponList;
  public float BloodStrewRadius;
  public USkeletalMesh Override1stMesh;
  public USkeletalMesh Override3rdMesh;
  public UPhysicsAsset OverridePhysicsAsset;
  public USFExtraBodyPartsManager ExtraBodyParts;
  public int[] DroppedExtraParts = new int[3];
  public int LastDroppedExtraPart;
  public int DirtyDroppedExtraPart;
  public string SpawnEffectTypeName;
  public float ControllerDetachDelayTime;
  public float InsightCheckDistance;
  public List<UClass> DefaultItemClasses;
  public USoundCue WeaponDischargingSound;
  public APawn DronePawn;
}

public class ASFPawn_AI : ASFPawn
{
  public class FWeaponStartTraceLocationCacheStruct
  {
    public bool bUpToDate;
    public UObject.FVector StartLoc;
    public AWeapon WeaponCacheIsValidFor;
  }

  public class FDelayedDamageInfoStruct
  {
    public int Damage;
    public AController EventInstigator;
    public UObject.FVector HitLocation;
    public UObject.FVector Momentum;
    public UClass DamageType;
  }

  public class FFullBodyAnimation
  {
    public eFullBodyAnimType AnimType;
    public FName AnimName;
    public float PlayLen;
    public float BlendInTime;
    public float BlendOutTime;
    public bool bCauseActorAnimEnd;
    public bool bLooping;
  }

  public bool bLockRotation;
  public bool bSpawning;
  public bool bakUpdateSkelWhenNotRendered;
  public bool bDoNotSprintWhenMove;
  public bool bDebugTrigger;
  public bool bIsWanderingOnly;
  public ASFWeapon MySFWeapon;
  public int AIEnemyIndex;
  public EInventoryTypes CustomAIWeapon;
  public eSpecialAI SpecialMarked;
  public FName SightBoneName;
  public FWeaponStartTraceLocationCacheStruct WeaponStartTraceLocationCache;
  public FDelayedDamageInfoStruct DelayedDamageInfo;
  public List<FFullBodyAnimation> DefaultFullBodyAnimations;
  public int AIFullBodyAnimCount;
  public int AIFullBodyAnimIndex;
  public int SpawnAnimPlayStat;
  public float SpawnAnimLength;
  public float DefaultSpawnAnimLength;
  public float DamageAdjMin;
  public float DamageAdjMax;
  public float SprintAttackPreferRate;
  public float AggressiveDistance;
  public string DisplayedName;
  public float DamageAdj;
  public float DamageAdjRadi;
  public float CustomScaleRate;
  public float ApplyedScaleRate;
  public float DelaySuicideTime;
  public float CollisionRadiusRep;
  public float CollisionHeightRep;
  public int AIID;
  public float TotalAIRating;
  public int DropItemCount;
  public int PawnAggroMultiplier;
  public USoundCue WanderingSound;
  public int WanderingSoundCount;
}

public class ASFPawn_AI_Aliens : ASFPawn_AI
{
  public class FsReplaceMaterialSet
  {
    public List<string> Materials;
  }

  public int nDyingShoot;
  public List<int> AnimList_attack;
  public List<int> AnimList_attackAlt;
  public List<int> AnimList_death;
  public List<int> AnimList_preAttack;
  public List<int> AnimList_postAttack;
  public UMaterialInstanceConstant DamagedMIC;
  public EExposureType ExposureType;
  public float ExposureRate;
  public float ExposureInRate;
  public float ExposureOutRate;
  public int MaxNormalAttackCount;
  public int MaxNormalAttackCountAngry;
  public bool bIgnoreSameTeamBlock;
  public bool bUseTeamColor;
  public float InteractionAngle;
  public List<FsReplaceMaterialSet> ReplaceMaterialSets;
  public int RepBossMaterialIdx;
  public string RepBossMaterial;
  public float LastFiredTime;
}

public class ASFPawn_AI_Aliens_Base : ASFPawn_AI_Aliens
{
  public bool bReactionToFlashbang;
  public bool bApplyDefaultStunDurationTime;
}

public class ASFPawn_AI_Human : ASFPawn_AI
{
  public FRotator SightDegree;
  public float SightRatioWalk;
  public float SightRatioStop;
  public float fInsightDot;
  public float fInsightDotWalk;
  public float fInsightDotStop;
}

public class ASFPawn_AI_Turret : ASFPawn_AI
{
}

public class ASFPawn_Player : ASFPawn
{
  public class FSFAutoMessageWeaponType
  {
    public int Damage;
    public EWeaponType WeaponType;
    public FName SoundName;
  }

  public class FS_RECOIL_RESULT
  {
    public int recoilState;
    public float currentCrossVert;
    public float expectCrossVert;
    public float crossDecreasValue;
    public float oldrCrossVert;
    public float crossIncline;
    public float decline;
    public int forceDir;
    public float impactIncreaseEye;
    public float impactDecline;
    public float impactSpinY;
    public float impactSpinZ;
    public float currentDomValue;
    public float movingValue;
    public float movingValueForCrossHair;
    public float spiny;
    public float spinz;
  }

  public UClass HandActorClass;
  public ASFHandActor HandActor;
  public USFSkeletalMeshComponent ArmsMesh;
  public USFSkeletalMeshComponent WeaponHolderMesh;
  public bool bUpdateEyeHeight;
  public bool bJustLanded;
  public bool bLandRecovery;
  public bool DoingExigencyAttack;
  public bool RecoilUpDown;
  public bool bIsInTranslucentView;
  public bool bRecoilMovingValueFromVelocity;
  public bool bUseRetargeting;
  public bool IsFeverTimeAction;
  public float LandEyeHeightDamping;
  public float BobValue;
  public float LandBob;
  public float JumpBob;
  public float AppliedBob;
  public float bobtime;
  public FVector WalkBob;
  public FVector IdleBob;
  public FVector WeaponBobValue;
  public float OldWeaponBobValueZ;
  public int BobValueDir;
  public float fBobSpeed;
  public int CameraShakeMax;
  public float CameraShakeRollRatio;
  public float CameraShakeYawRatio;
  public float CameraRestoreRate;
  public float CameraShakeApplyTime;
  public USceneCapture2DComponent SceneCaptureForFB;
  public UClass WeaponClassNow;
  public UClass WeaponClassPrev;
  public UClass WeaponClassExigencyPrev;
  public USkeletalMeshComponent OldWeaponSkelComponent;
  public EPawnIconState IconState;
  public ETriggerType TriggerType;
  public float GaugeRatio;
  public float GaugeRatioVelocity;
  public float GaugePassedTime;
  public FName LeftArmBandSocketName;
  public FName RightArmBandSocketName;
  public UStaticMesh LeftArmBandMesh;
  public UStaticMesh RightArmBandMesh;
  public UStaticMesh ClanMarkMesh;
  public UStaticMeshComponent LeftArmBandMeshComponent;
  public UStaticMeshComponent RightArmBandMeshComponent;
  public UStaticMeshComponent ClanMarkMeshComponent;
  public UMaterialInterface RedArmBandMaterial;
  public UMaterialInterface BlueArmBandMaterial;
  public List<ASFProjectile> GrenadeIndicators;
  public List<FSFAutoMessageWeaponType> AutoMessageWeaponTypeList;
  public FS_RECOIL_RESULT RecoilResult;
  public float StartFireSecondsForRecoil;
  public float LastCrossVertForRecoil;
  public float InterpSpeedForRecoilMovingValue;
  public float InterpSpeedForRecoilStopValue;
  public FRotator rotRecoil;
  public UParticleSystem ObserverFlashBangEffect;
  public AEmitter ObserverFlashBangEmitter;
  public FVector ObserverFlashBangEffectRelLocation;
  public UStaticMeshComponent ObserverLookAtConeComponent;
  public FVector ObserverLookAtConeRelLocation;
  public FRotator ObserverLookAtConeRelRotation;
  public List<float> ShakeChanceByBodyParts;
  public List<USFTypes.FAddtionalIdleMotion> AddedIdleMotions;
  public int SettedIdleMotions;
  public FName RetargetingControlName;
  public USFSkelControl_Retargeting RetargetingControl;
}

public class ASFPawn_AlienPlayer : ASFPawn_Player
{
  public EAITypes AlienType;
  public List<FName> AttackAnimName;
  public List<FName> AltAttackAnimName;
  public float InteractionAngle;
}

public class ASFPawn_Aliens : ASFPawn
{
}

public class ASFPawn_GlowPlayer : ASFPawn_Player
{
  public int GlowModeEffectType;
  public int GlowModeIndex;
  public FVector CurrentGlowModeColor;
  public FVector CurrentGlowModeScalar;
  public FVector StartGlowModeColor;
  public FVector NextGlowModeColor;
  public FVector StartGlowModeScalar;
  public FVector NextGlowModeScalar;
  public float CurrentGlowTransitionTime;
  public float GlowTransitionTime;
  public int GlowModeEffectMax;
  public int GlowModeKillScore;
  public int PrevGlowModeKillScore;
}

public class ASFPawn_CaptainPlayer : ASFPawn_GlowPlayer
{
  public class FAdvantage
  {
    public int Damage;
    public int HealthMin;
    public float Time;
    public float TimeRate;
  }

  public int DamageMax;
  public bool IsCaptainPoint;
  public int DamageAdvantage;
  public int AdvantageTime;
  public FAdvantage CaptainAdvantage;
}

public class ASFPawn_Drone : ASFPawn_Player
{
  public ASFWeap_DroneBase DroneControllerWeapon;
  public List<UClass> DefaultInventory;
  public float CamLocX;
  public float CamLocY;
  public float CamLocZ;
  public float MaxConnetDistance;
  public float orgCamLocZ;
  public float CamInterpScale;
  public float DronChangeViewDelayTime;
  public bool bTouchPawn;
  public bool bNoSeeMesh;
  public bool bDoNotUp;
  public bool bStartSuicide;
  public bool bGiveWeapon;
  public UAudioComponent DroneLoopAudioComponent;
  public ASFPlayerController OwnerController;
  public string DroneControllDistOutMSG;
  public USFSkeletalMeshComponent WeaponMeshComponent;
  public USkeletalMesh WeaponMesh;
  public FName WeaponAttachSocketName;
  public FName DualWeaponAttachSocketName;
  public UParticleSystemComponent DroneMuzzlePSC;
}

public class ASFPawn_Human : ASFPawn
{
}

public class ASFPawn_Lobby : ASFPawn_Player
{
  public int DisplayingUnitID;
}

public class ASFPawn_PvEPlayer : ASFPawn_Player
{
  public EDBNOLEVEL DBNOLevel;
  public EDBNOLEVEL DBNOLevelRep;
  public float DBNOEnterLen;
  public float DBNOLimit;
  public float RevivalAnimLen;
  public int DBNOOutLineColor;
  public float WarningDBNOTime;
  public FName RevivalSideBoneName;
  public FName RevivalDirBoneName;
  public FName RevivalAnimFront;
  public FName RevivalAnimBack;
  public FName DBNONodeName;
  public FName DBNOIdleNodeName;
  public float DBNOAnimBlendRate;
  public USFAnimBlendBase DBNONode;
  public USFAnimBlendBase DBNOIdleNode;
  public UAnimNodeSequence DBNODeathSeq;
  public float DBNOAnimLen;
  public bool bDBNOFrontDown;
  public AController DBNOInstigator;
  public AController RevivalInstigator;
  public float CONSUMESCORE_REVIVAL;
}

public class ASFPawn_ThirdPersonPlayer : ASFPawn_Player
{
  public float CamLocX;
  public float CamLocY;
  public float CamLocZ;
  public float CamLocZoomInX;
  public float CamLocZoomInY;
  public float CamLocZoomInZ;
  public float CamFOVZoomIn;
  public float CamFOVSniperZoomIn;
  public float CamFOVSniperZoomIn2nd;
  public float CamLocJumpX;
  public float CamLocJumpY;
  public float CamLocJumpZ;
  public float orgCamLocZ;
  public float CamInterpScale;
  public bool bNoSeeMesh;
  public bool bRightAngleView;
}

public class ASFPawn_RocketPlayer : ASFPawn_ThirdPersonPlayer
{
  public ERocketEffectType RocketEffectType;
  public bool bPossibleDoubleJump;
  public bool bCheckJumping;
  public bool bUsedSuperLanding;
  public bool bUsedDoubleJumping;
  public bool bUsedSafetyLanding;
  public bool bNeedSafeLanding;
  public bool bInfiniteFuel;
  public int HoveringStartCount;
  public int HoveringStartCountMaxCount;
  public float LandingElapsedTime;
  public float LandingDelayTime;
  public float LandingStartHeight;
  public float RocketJumpHeight;
  public float RocketJumpSpeed;
  public float CurrentRocketFuel;
  public float MaxRocketFuel;
  public float RocketJumpCustomGravityScaling;
  public float RocketJumpAirControl;
  public UCameraShake CameraShakeSuperLanding;
}

public class ASFPawnAI_Revenant : ASFPawn_AI_Aliens_Base
{
}

public class ASFPawnAI_Sentinel : ASFPawn_AI
{
  public ETeam Team;
  public FName SentinelName;
  public float ObservingRange;
  public float ObservingAngle;
  public UClass WeaponClass;
  public FVector FiringPosition;
  public float PreFireDelayTime;
  public FName WeaponBoneName;
  public bool bTrackingEnemyWhenFire;
  public int DefaultHealth;
  public USkelControlLookAt AimSkelControlYaw;
  public USkelControlLookAt AimSkelControlPitch;
  public URadialBlurComponent RadialBlur;
  public USFGameExplosion ExplosionInfo;
  public UCameraShake ExplosionShake;
  public UPointLightComponent ExplosionLight;
  public float HurtRadiusExtraEffectTo;
}

public class ASFPawnAI_Spectre : ASFPawn_AI_Aliens_Base
{
  public float HeadShotDamageRate;
  public float NotHeadShotDamageRate;
  public List<UAnimSet> ZombiePawnRandomAnimset;
  public List<UMaterialInterface> ZombiePawnRandomMaterial;
}

public class ASFPawnAI_Zombie : ASFPawn_AI_Aliens_Base
{
  public List<UAnimSet> ZombiePawnRandomAnimset;
  public List<UMaterialInterface> ZombiePawnRandomMaterial;
}

public class ASFPawnAI_ZombieWalker : ASFPawnAI_Zombie
{
}

public class ASFPawnAI_ZombieHideSeekWalker : ASFPawnAI_ZombieWalker
{
}

public class ASFPawnAI_ZombiePunisher : ASFPawnAI_ZombieWalker
{
}

public class ASFPawnBlockingVolume : ABlockingVolume
{
  public List<UClass> IgnoreBlockedPawnClass;
}

public class ASFPawnBlockingVolumeDynamic : ASFPawnBlockingVolume
{
}

public class ASFPawnBlockingVolumeStatic : ASFPawnBlockingVolume
{
}

public class USFPawnEffectManager : UObject
{
}

public class USFPawnEquipment : UObject
{
  public float[] ProtectiveHead = new float[2];
  public float[] ProtectiveUpper = new float[3];
  public float[] ProtectiveLower = new float[3];
  public float DurableWeapon;
  public float DurableEquip;
  public float DefensiveSmoke;
  public float DefensiveFragment;
  public float DecreaseNoise;
  public float IncreaseMagazine;
  public float IncreaseRadarRange;
}

public class USFTemporaryObjectPool : UObject
{
  public class FSFBloodDecalInfo
  {
    public USFDecal Decal;
    public UMaterialInstanceConstant MIC;
  }

  public class FSFBloodDecalPool
  {
    public int MaxDecalCounter;
    public float SpawnAreaDist;
    public float OverlapDist;
    public float Width;
    public float Height;
    public float Thickness;
    public float DepthBias;
    public float Lifetime;
    public UObject.FVector2D DecalBlendRange;
    public bool bNoClip;
    public bool bProjectOnSkeletalMeshes;
    public int DecalsIndex;
    public List<USFTemporaryObjectPool.FSFBloodDecalInfo> DecalInfos;
  }

  public class FSprayInfo
  {
    public int PlayerID;
    public ASFSprayActor SprayActor;
  }

  public class FStaticMeshComonentForRestore
  {
    public AActor StaticMeshCompOwner;
    public UStaticMeshComponent StaticMeshComp;
    public bool CollideActors;
    public bool BlockActors;
  }

  public class FarrPSCInfo
  {
    public List<UParticleSystemComponent> arrPSC;
    public UParticleSystem PS;
    public int nCurrentIndex;
  }

  public ASFGameReplicationInfo SFGRI;
  public List<USFTypes.FResourceInfo> arrSmokeEffectPS;
  public List<USFTypes.FResourceInfo> arrCrossHairMI;
  public List<USFTypes.FResourceInfo> arrGFxMoviePlayer;
  public List<USFTypes.FResourceInfo> arrCameraAnim;
  public List<USFTypes.FResourceInfo> arrRadioMessage;
  public int NumberOfSFWeapHitPSC;
  public List<FarrPSCInfo> arrSFWeaponHitPSCInfo;
  public int NumberOfSFWeapTracePSC;
  public List<FarrPSCInfo> arrSFWeaponTracePSCInfo;
  public int NumberOfSFWeapExtraTracePSC;
  public List<FarrPSCInfo> arrSFWeaponExtraTracePSCInfo;
  public int[] HitEffectCacheCount = new int[3];
  public string[] HitEffectPSName = new string[3];
  public UParticleSystem[] HitEffectPS = new UParticleSystem[3];
  public FarrPSCInfo[] CachedHitEffect = new FarrPSCInfo[3];
  public UParticleSystem DamageCameraBlood;
  public UParticleSystem DeathCameraBlood;
  public FSFBloodDecalPool WallBloodDecals;
  public UMaterialInstanceConstant WallBloodDecalMIC;
  public List<FSprayInfo> arrSprayInfo;
  public int SpraySpawnCounterForDepth;
  public ASFSliceSyncState SliceSyncStateList;
  public List<FStaticMeshComonentForRestore> arrStaticMeshCompForRestore;
  public int StaticMeshComponentID;
  public List<UClass> MaterialImpactEffectClassList;
  public List<string> MaterialImpactEffectClassNameList;
  public FScriptDelegate __InitNewInstance__Delegate;
}

public class USFPawnFX : UObject
{
  public class FSAppliedBuffEffectPSCData
  {
    public EBuffType Type;
    public float ElapsedTime;
    public UParticleSystemComponent EffectPSC;
  }

  public class FDamageTypeLensEffect
  {
    public UClass DamageType;
    public UParticleSystem CameraLensEffect;
  }

  public class FsCameraShake
  {
    public UCameraShake CamShake;
    public float CamShakeInnerRadius;
    public float CamShakeOuterRadius;
    public float CamShakeFalloff;
  }

  public ASFPawn PawnOwner;
  public float MaxFootstepDistSq;
  public float MaxFootstepParticleDist;
  public float MaxJumpSoundDistSq;
  public UParticleSystem IFFParticleBLUE;
  public UParticleSystemComponent IFFParticlePSC;
  public FName IFFParticleBone;
  public FName GodModeEffectBone;
  public UParticleSystem GodModeEffect;
  public UParticleSystemComponent GodModeEffectPSC;
  public bool bIsBoosting;
  public bool bIgnoreFaceSoundGroup;
  public bool bBreathLeft;
  public bool bWasSprint;
  public List<FSAppliedBuffEffectPSCData> AppliedBuffEffectPSCList;
  public USFSoundGroup_Pawn EffectGroup;
  public string SoundEffectName;
  public USoundCue VoiceSoundCue;
  public UAudioComponent VoiceAudioComp;
  public UParticleSystem DefaultDeathEffect;
  public float DefaultDeathEffectScale;
  public UParticleSystem DefaultHitEffect;
  public float DefaultHitEffectScale;
  public UClass PlayingMessageClass;
  public float SprintStartTime;
  public USoundCue[] Breath = new USoundCue[2];
  public UAudioComponent BreathAudioComponent;
  public List<UParticleSystem> CameraBloodLensEffect_Damaged;
  public UParticleSystem CameraBloodLensEffect_Death;
  public UParticleSystem CameraBloodLensEffect_Kill;
  public UParticleSystem DefaultCameraLensEffect;
  public List<FDamageTypeLensEffect> DamageTypeLensEffectArray;
  public USoundCue SpraySound;
  public USoundCue SergedSound;
  public float DelayTimeForFootStepPhysMaterial;
  public float LastCheckTimeForFootStepPhysMaterial;
  public float LastCheckTimeForSpecialFootSound;
  public float LastCheckTimeForSpecialKillSound;
  public float MaxRustleSoundDist;
  public USFParticleSystemComponent InGameShopPurchasePSC;
  public UAudioComponent InGameShopPurchaseSND;
  public List<UMaterialInstanceConstant> TeamMaterials;
  public float LastAddHitEffect;
  public List<UParticleSystemComponent> DynamicHitPSCList;
  public UPhysicalMaterial DefaultPhysicalMaterial;
}

public class USFSoundGroup_Pawn : USFSoundGroup
{
  public class FSFFoleyEntry
  {
    public SFFoleyID Id;
    public List<USoundCue> Sounds;
  }

  public class FSFVoiceFoleyEntry
  {
    public SFVoiceFoleyID Id;
    public List<USoundCue> Sounds;
  }

  public class FsDamageEffectEntry
  {
    public eDMGEFCTID Id;
    public UParticleSystem Effect;
    public float Scale;
  }

  public List<FSFFoleyEntry> FoleySoundFX;
  public List<FSFVoiceFoleyEntry> VoiceFoleys;
  public List<int> LastVoiceFoleyIdx;
  public List<FsDamageEffectEntry> DamageEffectFXs;
  public USFSoundGroup_Pawn Parent;
  public float LastPainSound;
  public float LastHitSound;
  public float DamageSoundMaxDistance;
  public float LastFallDeadBodyTime;
  public UAudioComponent VoiceAudioComp;
}

public class USFPawnFX_Aliens : USFPawnFX
{
  public UMaterialInterface BloodMarkBaseMateiral;
  public float fRateHideDeadbody;
  public float BloodMarkBaseSize;
  public USoundCue FootStepSound;
  public List<UTexture2D> BloodMarkTextureArray;
}

public class USFPawnFX_Human : USFPawnFX
{
}

public class USFPawnFX_Human_EquipmentEffect : USFPawnFX_Human
{
  public FName EquipmentEffectBoneName;
  public UParticleSystem EquipmentEffectPS;
  public UParticleSystemComponent EquipmentEffectPSC;
  public FVector EquipmentEffectColor;
  public FVector EquipmentEffectScalar;
  public FRotator EquipmentEffectRotator;
}

public class USFPawnFX_Zombie : USFPawnFX_Aliens
{
}

public class USFPawnFX_Revenant : USFPawnFX_Zombie
{
  public List<USFTypes.FSPawnEffect> PawnEffect1stView;
  public List<USFTypes.FSPawnEffect> PawnEffect3rdView;
  public List<USFTypes.FSPawnEffect> PendingPawnEffect3rdView;
  public List<USFParticleSystemComponent> PawnEffectPSC;
}

public class ASFPawnZombiePlayer_Walker : ASFPawn_AlienPlayer
{
  public List<UAnimSet> ZombiePawnRandomAnimset;
  public List<UMaterialInterface> ZombiePawnRandomMaterial;
}

public class USFPCRoomCare : UObject
{
  public class FSPCRoomCare
  {
    public int PCRoomType;
    public int ExpAddRatio;
    public int SPGageAddRatio;
    public float ClanPointRatio;
    public string ItemType;
    public string IconImage;
  }

  public List<FSPCRoomCare> PCRoomCareArray;
  public float PCRoomCareSaleRatio;
  public string PCRoomCareNotificationURL;
}

public class ASFPendingPlayerController : APlayerController
{
  public FVector Scene_MidTones;
  public FVector Scene_Shadows;
  public float Scene_Desaturation;
  public ACameraActor WorldCamera;
}

public class USFPiercingShotEventData : USFSpecialKillEventData
{
}

public class ASFPlayerCamera : AGamePlayerCamera
{
  public USFSpectatorCamera SpectatorCam;
  public float LastBloodEffect;
  public bool bUseInterpCamera;
  public bool PunchAngle_bIsPlaying;
  public bool bInsideWaterVolume;
  public float InterpCameraTime;
  public int PunchAngle_Pitch;
  public int PunchAngle_Yaw;
  public float PunchAngle_Exp;
  public float PunchAngle_RecoveryTime;
  public float PunchAngle_StartTimeSeconds;
  public USFCameraModifier_ShakeByDamage CameraDamageShakeMod;
  public UClass CameraDamageShakeModClass;
  public List<UParticleSystem> InsideWaterEffects;
  public List<UParticleSystem> OutsideWaterEffects;
  public float WaterVolumeExtent;
}

public class USFPlayerInput : UPlayerInput
{
  public float LastDuckTime;
  public bool bHoldDuck;
  public bool bUseMouseSensitivityinZoom;
  public bool bTestForward;
  public bool bTestBackward;
  public float MouseSensitivityinZoom;
  public float NoInputElapsedTime;
  public List<FScriptDelegate> OnInputAxisDelegateList;
  public FScriptDelegate __OnInputAxis__Delegate;
}

public class USFPlayTimeByMode : USFBaseEventData
{
}

public class USFPlayTimeByWeapSetEventData : USFBaseEventData
{
}

public class USFPlayTimeEventData : USFWeaponEventData
{
}

public class ASFPointOfInterest : AKeypoint
{
  public bool bClientSideOnly;
  public bool bCheckLineOfSight;
  public bool bCheckLineOfSightAtFirstTime;
  public bool bHideFirstHand;
  public bool bBlockTheKeyInput;
  public bool bEnabled;
  public List<ACameraActor> CameraActorsForBlockingtheSight;
  public AActor OriginalViewTarget;
  public float RotationInterpSpeed;
  public UCameraAnim POICameraAnim;
  public float EnableTime;
}

public class USFPostEffect : UObject
{
  public float Lifetime;
  public float RatioTime;
}

public class USFPostEffect_FlashBang : USFPostEffect
{
  public float SoundDuration;
  public float SoundFadeOutDuration;
  public float BlendOutStartTimeRate;
  public float BlendOutEndTimeRate;
  public float WhiteOutStartTimeRate;
  public float WhiteOutEndTimeRate;
  public float AlphaPowerFront;
  public float AlphaPowerSide;
  public float AlphaPowerBack;
  public float WhiteOutPowerFront;
  public float WhiteOutPowerSide;
  public float WhiteOutPowerBack;
}

public class USFPostEffect_TearGas : USFPostEffect
{
}

public class ASFPrimaryTargetActor_Movable : ASFPrimaryTargetActor
{
}

public class USFProfileSettings : UOnlineProfileSettings
{
  public class FKeymapData
  {
    public FName FlashKeyname;
    public FName UnrealKeyName;
    public int FlashKeyCode;
  }

  public class FSLocalizedKeyName
  {
    public string Src;
    public string tgt;
  }

  public class FNotKeyMapData
  {
    public int KeyIndex;
    public string NotMapKeyName;
  }

  public List<string> DigitalButtonActionsToCommandMapping;
  public List<FName> KeyMappingArray;
  public List<EDigitalButtonActions> SettingUIKeyActionOrder;
  public List<FKeymapData> KeyMappingforFlash;
  public List<string> IgnoreKeys;
  public List<FSLocalizedKeyName> NewKeyNameArray;
  public List<FSLocalizedKeyName> BaseLocalizedKeyNameArray;
  public List<FSLocalizedKeyName> LocalizedKeyNameArray;
  public List<FNotKeyMapData> NotKeyMappingData;
  public List<int> default_WeaponData_m4a1;
  public List<int> default_WeaponData_ak103;
  public List<int> default_WeaponData_m4a1gl;
  public List<int> default_WeaponData_infi;
  public List<int> default_WeaponData_M92FS;
  public List<int> default_WeaponData_cz700;
  public List<int> default_WeaponData_m870;
  public List<int> default_WeaponData_hk23;
  public List<int> default_WeaponData_p90;
  public List<int> default_WeaponData_m67;
  public List<int> default_WeaponData_m84;
  public List<int> default_WeaponData_m18;
  public List<int> default_WeaponData_vxgas;
  public List<int> default_WeaponData_c4;
  public List<int> default_WeaponData_v10;
  public List<int> default_WeaponData_st10;
  public List<int> default_WeaponData_v11;
  public List<int> default_WeaponData_Crossbow;
  public List<int> default_WeaponData_Kukri;
  public List<int> default_WeaponData_GPM30A1;
  public List<int> default_WeaponData_Tomahawk;
  public List<int> default_WeaponData_ToyHammer;
  public int default_Delta;
  public int default_Spetz;
  public List<int> default_HandData_Delta;
  public List<int> default_CharData_Spetz;
  public List<int> default_HelmData_Spetz;
  public List<int> default_HandData_Spetz;
}

public class ASFProjectile : AProjectile
{
  public bool bSuppressSounds;
  public bool bSuppressExplosionFX;
  public bool bSuppressWarnProjExplodeToAI;
  public bool bWaitForEffects;
  public bool bShuttingDown;
  public bool bCheckProjectileLight;
  public bool bAutoRegisterIndicator;
  public bool UseCamo;
  public bool bInWater;
  public bool bInWaterExplode;
  public bool bChangeRotationByVelocity;
  public bool bCheckPawnCylinder;
  public bool bBoundedFromPawn;
  public bool bDesiredAccelSetted;
  public bool bExposed;
  public bool bNoticed;
  public bool bStopped;
  public bool bBlockedByDeepWaterSurface;
  public bool bPassThroughSameTeam;
  public bool bIndicatorDistanceExplosionRadius;
  public UParticleSystemComponent ProjEffects;
  public UParticleSystem ProjFlightTemplate;
  public float ProjFlightTemplateScale;
  public float AccelRate;
  public float TossZ;
  public UClass ProjectileLightClass;
  public UPointLightComponent ProjectileLight;
  public float TerminalVelocity;
  public float Buoyancy;
  public float CustomGravityScaling;
  public float fShockDamage;
  public float ShockDamageRateToSameTeam;
  public UMeshComponent SFProjMesh;
  public UDynamicLightEnvironmentComponent LightEnvironment;
  public int nProjectileID;
  public int nDBIndex;
  public float fRemainLife;
  public float AutoRegisterIndicatorDelay;
  public EIndicateType IndicateType;
  public byte InstigatorTeamIndex;
  public float IndicatorPriority;
  public UClass ExplosionLightClass;
  public USFGameExplosion ExplosionInfo;
  public UClass GameExplosionActorClass;
  public FVector vWaterSurface;
  public FVector vWaterSurfaceNormal;
  public int nStrikeDamage;
  public int UseWeaponEffectGroupIndex;
  public float StrikeDamageReduceRatioWhenHitWall;
  public float PhysicTickCurrentTime;
  public float PhysicTickPeriod;
  public int PhysicTickCounter;
  public int PhysicTickMaxCounter;
  public int InstigatorUniqueID;
  public ASFPlayerReplicationInfo InstigatorPRI;
  public FVector NewDesiredAcceleration;
  public float WarnProjectileTimer;
  public float NoticeDistance;
  public float ExposedDistance;
  public AActor VictimActor;
  public FVector OwnerInertiaApplyRatio;
  public float KillCamCameraInterpSpeed;
  public FVector KillCamRelativeLocation;
  public float KillCamCameraFadding;
  public FVector SpawnLocation;
  public FRotator SpawnRotation;
  public FVector InitialVelocity;
  public UParticleSystemComponent ProjectileFlashBackScreenEffect;
  public float SpeedToStop;
  public List<float> StrikeDmgScaleBodyParts;
  public float IndicatorDistance;
}

public class ASFProj_Throw : ASFProjectile
{
  public float fDampingValue;
  public float DampingMultiflyFactor;
  public FName ImpactEffectName;
  public int AdditionalImpactDecalAngle;
  public UClass MyStrikeDamageType;
  public UPhysicalMaterial DefaultImpactPMaterial;
  public bool bTakeDamageToPawn;
  public bool bIsTrajectorySimulating;
  public bool ActiveTrajectoryEndPoint;
  public bool IsBounded;
  public bool bCheckExtend;
  public List<UParticleSystemComponent> ProjRotateEffects;
  public List<UParticleSystem> ProjRotateTemplate;
  public List<FName> ProjRotateSocketName;
  public FName ProjFlightEffectsSocketName;
  public FVector ProjFlightEffectsAttachOffset;
  public float fLastTimeToSpawnImpact;
  public float fLastMaxTimeToSpawnImpact;
  public float MaxTrajectorySimulationTime;
  public float SimTrajectoryFixedTimeStep;
  public AEmitter EM_TrajectoryEndPoint;
  public UParticleSystem PS_TrajectoryEndPoint;
}

public class ASFProj_Explosive : ASFProj_Throw
{
}

public class ASFProj_HandGrenade : ASFProj_Explosive
{
  public float SimFixedTimeStep;
  public float SimInternalGravityAdvanceTime;
  public float MaxSimulationTime;
  public bool bFlowRotate;
  public bool bExplodeWhenHitWall;
  public bool bExplodeAfterHitGround;
  public float fRotSpeed;
  public FVector StartLoc;
  public float ExtraExplodeTimeAfterHitGround;
  public string SFPostEffectClassName;
}

public class ASFProj_HG_Frag : ASFProj_HandGrenade
{
  public USoundCue ProjectileImpactSound;
}

public class ASFProj_AI_CallPawn : ASFProj_HG_Frag
{
  public EAITypes SpawnPawn;
}

public class ASFProj_AI_Kidnaping : ASFProj_HG_Frag
{
  public float KidnapingPower;
}

public class ASFProj_HG_Gas : ASFProj_HandGrenade
{
  public float fSmokeLifeTime;
  public float fExploTime;
  public float fSmokeMaxTime;
  public float fGasDamageMax;
  public float fGasDamageMin;
  public float fGasDamageRadiusRadius;
  public float fMaxGasDamageRadiusRadius;
  public USFParticleSystemComponent SmokeEffect;
  public float ParticleDensity;
  public bool bBlockSight;
  public bool bBlurSight;
  public bool bExploded;
  public float fMaxEffectRadiusSq;
  public float fEffectRadiusSq;
  public float fSmokeDuringTime;
  public List<AActor> BombEffectiveActors;
  public float[] SmokeColor = new float[6];
  public FVector[] SmokeColorType = new FVector[2];
}

public class ASFProjectileM18 : ASFProj_HG_Gas
{
}

public class ASFProj_AILureGrenade : ASFProjectileM18
{
}

public class ASFProj_Arrow : ASFProj_Explosive
{
  public float ExplodeTime;
  public float BounceAngle;
  public float StopSpeed;
  public float BounceCheck;
  public float MomentumToDeadBody;
  public float EffectiveFixDistance;
  public float DisappearLifeSpan;
  public bool bStucked;
  public bool bIsStuckable;
  public bool bBeginStuckProcess;
  public bool bRequestDamageRPC;
  public bool bUseStuck;
  public AActor AttachedTo;
  public List<URB_Handle> GrabHandles;
  public USoundCue WhippingSound;
  public USoundCue StuckSound;
  public UAudioComponent ArrowAudioComponent;
  public float StuckCameraSpeedRatio;
  public UDynamicLightEnvironmentComponent SelfLightEnvironment;
  public FRotator MeshRotationRateBySpeed;
  public FRotator DefaultMeshRotation;
}

public class ASFProj_GrenadeLauncher : ASFProj_Explosive
{
  public bool bSafe;
  public float BlindSpeed;
  public float fSafeDist;
  public float fSafeTime;
}

public class ASFProj_HandGrenadeAimingArc : ASFProj_HandGrenade
{
}

public class ASFProj_HG_BabyStunner : ASFProj_HandGrenade
{
  public FVector ThrowDirection;
  public float GroundSpeed;
  public float GroundMaxSpeed;
  public float GroundWaitTime;
  public bool bSprintExplodeWhenHitWall;
  public bool bSprintExplodeWhenHitPawn;
  public bool IsPassableObject;
  public bool bIsThrowing;
  public bool bIsToStop;
  public bool bCheckFirstReadyToSprint;
  public bool bReadyToSprint;
  public bool bIsFollowingTrailEffect;
  public float CylinderRadious;
  public float CylinderHeight;
  public float BabyStunnerMaxStepHeight;
  public float SprintAbleFloorZ;
  public USoundCue FootStepSound;
  public USoundCue ProjectileImpactSound;
  public float SprintStepSoundInterval;
  public UParticleSystem ProjSprintTemplate;
  public float ProjSprintTemplateScale;
  public float ReadyToSprintTime;
  public USoundCue ReadyToSprintSound;
  public float MovementRadius;
  public float MovementSpeed;
  public float ZAxisDig;
  public float ZAxisEclipseValue;
  public float StunnerRadian;
  public float RadianDirection;
  public float LastTimeToSprintStepSound;
}

public class ASFProj_HG_FlashBang : ASFProj_HandGrenade
{
  public float fFlashTime;
  public float FrontDot;
  public float BackDot;
}

public class ASFProj_HG_Function : ASFProj_HandGrenade
{
  public float RegisterDelay;
}

public class ASFProj_HG_Impact : ASFProj_HandGrenade
{
}

public class ASFProj_HG_Slow : ASFProj_HG_Gas
{
}

public class ASFProj_IncendiaryGrenade : ASFProj_HandGrenade
{
}

public class ASFProj_Knife : ASFProj_Throw
{
  public bool bStucked;
  public bool bIsStuckable;
  public bool bBeginStuckProcess;
  public bool bAltFire;
  public bool bRequestDamageRPC;
  public AActor AttachedTo;
  public float MomentumToDeadBody;
  public FVector AddedAccel;
  public USoundCue WhippingSound;
  public USoundCue StuckSound;
  public UAudioComponent KnifeAudioComponent;
  public UDynamicLightEnvironmentComponent SelfLightEnvironment;
  public float StuckCameraSpeedRatio;
}

public class ASFProj_Kukri : ASFProj_Knife
{
  public float IncreaseValue;
  public float DecreaseValue;
  public float DecreaseRate;
  public float OriginVelocityZ;
  public float StartTime;
}

public class ASFProj_Shuriken : ASFProj_Knife
{
  public float CurveValueMax;
  public float CurveValueMin;
  public float curveValue;
}

public class ASFProj_Snowball : ASFProj_HandGrenade
{
}

public class ASFProjectile_AI_StunnerExplo : ASFProj_HG_Frag
{
}

public class ASFProjectile_Flare : ASFProj_HG_Frag
{
  public UParticleSystemComponent SmokePSC;
  public UParticleSystem SmokePS;
  public FName SocketName;
}

public class ASFProjectileBeacon : ASFProj_HG_Gas
{
  public UClass BeaconTargetClass;
}

public class ASFProjectileDOTGas : ASFProj_HG_Gas
{
}

public class ASFProjectileIncendiaryBomb : ASFProjectileDOTGas
{
}

public class ASFProjectileSlowBomb : ASFProjectileDOTGas
{
}

public class ASFProjectileTearGas : ASFProjectileDOTGas
{
}

public class USFPromotionEvent : UObject
{
}

public class USFPromotionMessage : USFLocalMessage
{
  public string YouPromoted;
}

public class USFPurchaseInGameStoreItemEventData : USFBaseEventData
{
}

public class USFPvEMapInfo : USFMapInfo
{
  public List<AActor> PvEPrimaryTargets;
}

public class ASFPvEPlayerController : ASFPlayerController
{
  public int OldCurrentWave;
  public USFGameDatabase.FSFPEVPlayerLog DedicatePEVPlayerLog;
}

public class USFPVEPlayTimeEventData : USFBaseEventData
{
}

public class USFPVPPlayTimeEventData : USFBaseEventData
{
}

public class USFQACheckMessage : UObject
{
  public class FSFQAMessage
  {
    public float TimeToDisplay;
    public UObject.FColor DisplayColor;
    public string QAMessage;
  }

  public List<FSFQAMessage> SFQAMessages;
  public float DefaultDisplayTime;
  public float UpdateDuration;
}

public class USFRadioMessage : USFLocalMessage
{
  public class FMenuString
  {
    public string[] menu = new string[10];
  }

  public USFSoundGroup_Voice RadioVoice;
  public ERaidoMessagePriority RadioMsgPriority;
  public List<FMenuString> MenuStrings;
}

public class USFRadioMsgAuto : USFRadioMessage
{
}

public class USFRadioMsgCommand : USFRadioMessage
{
}

public class USFRadioMsgCommunity : USFRadioMessage
{
}

public class USFRadioMsgMission : USFRadioMessage
{
}

public class USFRandomRespawn : UObject
{
  public class FSRespawnPointInfo
  {
    public float fDistRatio;
    public ASFGamePlayerStart PS_Respawn;
    public UObject.FVector TargetLocation;
  }

  public class FPlayerStartRating
  {
    public int Number;
    public int DistanceRating;
    public float Distance;
  }

  public List<ASFGamePlayerStart> arrRespawnPoint;
  public UClass PlayerStartClass;
  public float MinDistanceFromFriendForRespawn;
  public float FriendRadiusForRespawn;
  public float HeightWeightForRespawn;
  public float LastRespawnDelay;
  public int CheckColleagueForRespawn;
  public float EnemyDistanceScore;
  public bool bIsTeamGame;
  public bool bRandomRespawnAtFirstSpawn;
  public ERandomRespawnType RandomRespawnType;
}

public class USFRankEventData : USFBaseEventData
{
}

public class USFRankPoint : UObject
{
  public class FSRankPoint
  {
    public int Rank;
    public int RealRank;
    public int RankExp;
  }

  public class FSSPGage
  {
    public int Rank;
    public int SPGage;
    public int AddSP;
  }

  public List<FSRankPoint> RankPointArray;
  public List<FSSPGage> SPGageArray;
  public List<string> RankName;
}

public class USFRealTimeEventCondition : USFBaseCondition
{
  public List<FName> RealTimeScoreEventType;
}

public class USFRecommendItem : UObject
{
  public List<USFTypes.FSRecommendItemType> RecommendItemTypeArray;
  public List<USFTypes.FSRecommendItem> RecommendItemArray;
}

public class USFRenderTextureManager : UObject
{
  public ULevelStreaming SceneCaptureLevel;
  public List<ASFSceneCaptureActor> SceneCaptureActors;
  public int NextPrepareIndex;
}

public class ASFReplicatedEmitter : ASFEmitter
{
  public UParticleSystem EmitterTemplate;
  public float ServerLifeSpan;
}

public class ASFRescueGame : ASFTeamGameInfo
{
}

public class ASFRescueHUD : ASFTeamHUD
{
}

public class ASFRescueVolume : ASFModeVolume
{
  public int OccupiedTime;
  public int RemainTime;
}

public class USFRespawnCameraMode : USFThirdPersonCameraModeBase
{
  public FVector StartLocTangent;
  public FRotator StartRotTangent;
  public FVector EndLocTangent;
  public FRotator EndRotTangent;
  public FVector StartLocationOffset;
  public FRotator StartRotationOffset;
  public float RespawnCameraDelay;
  public float fPassedTime;
}

public class USFRevengeEventData : USFSpecialKillEventData
{
}

public class ASFReverbVolume : AReverbVolume
{
}

public class ASFRevolverGame : ASFTeamGameInfo
{
}

public class ASFRevolverGameReplicationInfo : ASFGameReplicationInfo
{
}

public class USFRevolverGameScore : USFGameScore
{
}

public class ASFRevolverHUD : ASFTeamHUD
{
}

public class USFRewardItemList : UObject
{
  public List<USFTypes.FExtraRewardInfo> ExtraRewardListArray;
  public string GashaSupplyCode;
  public string PveGachaSupplyCode;
  public string ExtraCareSupplyCode;
  public string HeroSupplyCode;
  public string SerialSupplyCode;
  public string MiniGachaSupplyCode;
}

public class ASFRocketJumpCpatureHUD : ASFCaptureHUD
{
}

public class ASFRocketJumpHUD : ASFHUD
{
}

public class ASFThirdPersonPlayerController : ASFPlayerController
{
  public bool CheckHoldZoom;
  public bool bEnableFreeCam;
  public bool bZoomCamModeChangeDelay;
  public float RightClickElapsedTime;
}

public class ASFRocketJumpPlayerController : ASFThirdPersonPlayerController
{
  public float CaptureWarningTime;
  public string FillBarMessageFillFuel;
  public string FillBarMessageNotEnoughFuel;
  public string FillBarMessageJumping;
  public string FillBarMessageBoosting;
  public string FillBarMessageHovering;
  public string FillBarMessageSuperLanding;
  public string FillBarMessageStandBy;
  public string FillBarMessageInfiniteFuel;
}

public class ASFTeamDeathGame : ASFBaseTeamDeathGame
{
}

public class ASFRocketJumpTDMGame : ASFTeamDeathGame
{
}

public class ASFRocketJumpTDM2Game : ASFRocketJumpTDMGame
{
}

public class USFRoundOverCounterEventData : USFPlayerLogEventData
{
}

public class USFRoundTDMGameScore : USFGameScore
{
}

public class USFSampleTableData : USFLocalDBTableData
{
  public int IntValue;
  public FName LocalName;
  public UTexture2D Texture;
}

public class USFSampleTableData2 : USFLocalDBTableData
{
  public string LocalString;
  public List<int> intArray;
  public UStaticMesh StaticMesh;
}

public class ASFScenarioGame : ASFTeamGameInfo
{
  public ASFScenarioGameReplicationInfo SFScenarioGRI;
  public bool OnlyOne;
}

public class ASFScenarioGameReplicationInfo : ASFGameReplicationInfo
{
  public List<ASFPawn> DBNOPawns;
  public int TotalLives;
  public int CurrentServerArea;
  public AHelicopter hel;
  public ASFTrigger_Seizure BlackBox;
  public int InitialRevivalTime;
}

public class ASFScenarioHUD : ASFHUD
{
  public ASFScenarioGameReplicationInfo SFSGRI;
  public List<UTexture2D> DBNOIcon;
}

public class ASFSceneCaptureActor : ASkeletalMeshCinematicActor
{
  public ASceneCapture2DActor Camera;
  public UDrawBoxComponent TestDrawBox;
}

public class ASFSceneCubeMapActor : ASceneCaptureCubeMapActor
{
  public int TextureSize;
}

public class ASFScout : AScout
{
}

public class ASFSeizureGameReplicationInfo : ASFGameReplicationInfo
{
}

public class ASFSeizureGameSpy : ASFSeizureGame
{
}

public class USFSeizureGameSpyScore : USFGameScore
{
  public float SCORE_ObjectDefusedTeam;
}

public class ASFSeizureGameVs16 : ASFSeizureGame
{
}

public class USFSeizureGameVs16Score : USFSeizureGameScore
{
}

public class ASFSeizureHUD : ASFTeamHUD
{
  public ASFSeizureGameReplicationInfo SFSzGRI;
}

public class ASFSeizureRocketJumpGame : ASFSeizureGame
{
}

public class ASFSeizureRocketJumpHUD : ASFSeizureHUD
{
}

public class ASFSeizureVolume : ASFModeVolume
{
}

public class ASFSeizureVs16HUD : ASF16VS16ModeHUD
{
}

public class USFSeqAct_AddHealth : USequenceAction
{
  public int HealthForAdd;
  public bool bClampByMaxHealth;
}

public class USFSeqAct_AddImpulse : USequenceAction
{
  public FVector Impulse;
  public FVector Position;
  public FName BoneName;
  public bool bVelChange;
}

public class USFSeqAct_AddMagazine : USequenceAction
{
  public class FAddWeaponMagazine
  {
    public EWEAPON_GROUP WeaponGroup;
    public int Magazine;
  }

  public List<FAddWeaponMagazine> AddMagazineList;
}

public class USFSeqAct_AddMoney : USequenceAction
{
  public int Money;
}

public class USFSeqAct_AddMoneyToAllPlayer : USFSeqAct_SFGameInfo
{
  public int Money;
}

public class USFSeqAct_AddRadialImpulse : USequenceAction
{
  public float Impulse;
  public FVector Position;
  public AActor SpawnPoint;
  public bool bVelChange;
}

public class USFSeqAct_AddRemainingTime : USFSeqAct_SFGameInfo
{
  public float AddTime;
  public float RemainingTime;
}

public class USFSeqAct_AdjustAIPawnProperties : USequenceAction
{
  public List<USFTypes.FsAjdPawnProp> AjdPawnProps;
}

public class USFSeqAct_AIFactorySetTeam : USFSeqAct_AIFactory
{
}

public class USFSeqAct_AIFreeze : USequenceAction
{
  public bool bAllowWeaponFiring;
}

public class USFSeqAct_AIKillAll : USequenceAction
{
}

public class USFSeqAct_AILookAt : USequenceAction
{
  public AActor FocusTarget;
}

public class USFSeqAct_AIStartFireAt : USequenceAction
{
  public byte ForcedFireMode;
}

public class USFSeqAct_AIStopFire : USequenceAction
{
}

public class USFSeqAct_AllowVictimType : USFSeqAct_SFGameInfo
{
  public float fUseFriendlyFireDamage;
  public float fAllowSelfInjury;
}

public class USFSeqAct_AreaIndex : USFSeqAct_SFGameInfo
{
  public int AreaIndex;
  public AActor Instigator;
}

public class USFSeqAct_BroadcastAnnouncer : USFSeqAct_SFGameInfo
{
  public FName MissionName;
  public bool bCheckMatchInProgressMessage;
  public ETeam ActiveTeamIndex;
}

public class USFSeqAct_BroadcastMessage : USFSeqAct_SFGameInfo
{
  public string LocalizedMessage;
}

public class USFSeqAct_BroadcastMessageByType : USFSeqAct_SFGameInfo
{
  public class FReplaceMessageInfo
  {
    public string LinkDesc;
    public USequenceVariable SeqVar;
  }

  public EGFxHUDMessage MessageType;
  public ETeam ActiveTeamIndex;
  public float MessageLifeTime;
  public string LocalizedMessage;
  public int KeyMessageIndex;
  public string ResultMessage;
  public List<FReplaceMessageInfo> arrDescMessageInfo;
}

public class USFSeqAct_CameraScore : USFSeqAct_SFGameInfo
{
  public ACameraActor Cam;
  public float CameraScore;
}

public class USFSeqAct_Captured : USFSeqAct_SFGameInfo
{
}

public class USFSeqAct_ChangeAIWave : USFSeqAct_SFGameInfo
{
  public int ExplicitWaveIndex;
}

public class USFSeqAct_ChangeBackgroundImage : USequenceAction
{
  public UTexture2D NewBackGroundImage;
}

public class USFSeqAct_ChangeMatineeSkel : USequenceAction
{
  public class FAttachedActorInfo
  {
    public AActor AttachedActor;
    public UObject.FVector RelativeLocation;
    public UObject.FRotator RelativeRotation;
    public bool bHardAttach;
  }

  public List<APlayerReplicationInfo> SameTeamPRI;
}

public class USFSeqAct_ChangeCutSkel : USFSeqAct_ChangeMatineeSkel
{
  public int ChangePMCID;
}

public class USFSeqAct_Clock : USeqAct_Latent
{
  public int Year;
  public int Month;
  public int DayOfWeek;
  public int Day;
  public int Hour;
  public int Minute;
  public int Sec;
  public int MSec;
  public float ElapsedTime;
  public List<AStaticMeshActor> HourHands;
  public List<AStaticMeshActor> MinuteHands;
  public float UpdateInterval;
  public bool bNotifyOnTime;
  public bool bTimeMarchesOn;
}

public class USFSeqAct_DrawBarricadePreview : USequenceAction
{
  public bool bShowPreview;
}

public class USFSeqAct_EndCodeName : USequenceAction
{
}

public class USFSeqAct_EndGame : USFSeqAct_SFGameInfo
{
  public string MissionName;
  public bool bCanUseInTrainingGame;
}

public class USFSeqAct_Explode : USequenceAction
{
  public UClass ExplosionActorClass;
  public UGameExplosion ExplosionTemplate;
  public AActor TargetActor;
  public AActor Instigator;
  public bool bUseTargetLocationNRotation;
  public AActor SpawnPoint;
  public FVector SpawnLocation;
  public FVector SpawnOrientation;
  public UClass DefaultDamageType;
}

public class USFSeqAct_GetElevatorActorState : USequenceAction
{
}

public class USFSeqAct_GetTouchingTeamCounter : USequenceAction
{
}

public class USFSeqAct_GetTutorialSectionScore : USequenceAction
{
  public int SectionID;
  public int BestScore;
  public int AdjustScore;
  public float ScoreRate;
}

public class USFSeqAct_GiveItem : USequenceAction
{
  public List<int> Items;
  public List<string> ItemNames;
  public EWEAPON_GROUP TargetWeaponGroup;
  public bool bEnableInRound;
}

public class USFSeqAct_GiveWeapon : USequenceAction
{
  public class FWeaponDataForSeqAct
  {
    public int WeaponItemID;
    public UClass WeaponClass;
  }

  public List<UClass> WeaponClass;
  public List<FWeaponDataForSeqAct> LoadedWeaponData;
}

public class USFSeqAct_GiveWeaponbyCondition : USequenceAction
{
  public class FWeaponClassDataForSeqAct
  {
    public UClass ItemClass;
    public float fProbability;
    public bool bTeamRare;
    public bool bGameRare;
    public bool bImproperRareUser;
    public bool bOnlyRareUser;
    public int nImproperTeamTopRanker;
    public int nOnlyTeamTopRanker;
  }

  public class FsWeaponDataForSeqAct
  {
    public int WeaponItemID;
    public UClass WeaponClass;
  }

  public List<FWeaponClassDataForSeqAct> WeaponDatum;
  public List<FsWeaponDataForSeqAct> LoadedWeaponData;
  public List<UClass> RareWeapons;
}

public class USFSeqAct_GiveWeaponList : USFSeqAct_GiveWeapon
{
}

public class USFSeqAct_InitCodeName : USequenceAction
{
  public ASkeletalMeshActor CodeNameActor;
  public int MaterialIndex;
  public USwfMovie GFxMovie;
  public UTextureRenderTarget2D RT_CodeNameTag;
  public USFGFxMoviePlayer MoviePlayer;
  public UMaterialInstanceConstant CodeNameMIC;
}

public class USFSeqAct_ModeState : USequenceAction
{
  public EModeState NewModeState;
  public bool bClientSideOnly;
}

public class USFSeqAct_MoveToActor : USeqAct_Latent
{
  public bool bInterruptable;
  public List<ASFAIController> TargetControllers;
}

public class USFSeqAct_MovingInterpActor : USFSeqAct_SFGameInfo
{
  public bool bIsMoveEnded;
  public AActor MovingSubject;
  public ETeam TeamNumber;
}

public class USFSeqAct_NotiChangePlayerStart : USFSeqAct_SFGameInfo
{
  public int GroupNumber;
}

public class USFSeqAct_PickEventOriginator : USequenceAction
{
}

public class USFSeqAct_PlayerInput : USequenceAction
{
  public List<FName> IgnoreKeyName;
  public bool bIgnoreAllInput;
}

public class USFSeqAct_PlayWave : USequenceAction
{
  public USoundNodeWave Sound;
}

public class USFSeqAct_PvEWaveInfo : USFSeqAct_SFGameInfo
{
  public float MaxAliveRatio;
  public float EndOfRoundDelay;
  public float MultiplyValueForAliveRatio;
}

public class USFSeqAct_Record : USequenceAction
{
  public class FInterpActorCollisionInfo
  {
    public string PathName;
    public bool bCollideActors;
    public bool bBlockActors;
    public bool bIgnoreEncroachers;
    public bool bBlockRigidBody;
    public bool bDisableTickWhenStop;
    public int InterpolatingStartCounter;
  }

  public float RecordTime;
  public float RecordRate;
  public UInterpData MatineeData;
  public bool bCollideActors;
  public bool bClearOldData;
  public bool bRecordActivated;
  public float RecordElapseTime;
  public float RecordAdvancedTime;
  public Dictionary<byte, byte> MatchingMap;
  public List<FInterpActorCollisionInfo> InterpActorCollisionInfos;
}

public class USFSeqAct_Reset : USequenceAction
{
}

public class USFSeqAct_ScoreInit : USFSeqAct_SFGameInfo
{
  public string PacketIndex;
  public bool IsUpdatePacket;
}

public class USFSeqAct_ScoreUp : USFSeqAct_SFGameInfo
{
  public float Score;
  public List<UObject> HitTargets;
  public List<FVector> HitLocations;
}

public class USFSeqAct_SendRareItemName : USequenceAction
{
}

public class USFSeqAct_SetActivatedPawn : USequenceAction
{
  public APawn ActivatedPawn;
}

public class USFSeqAct_SetBarricade : USequenceAction
{
  public float HealthRate;
  public bool bNoEffect;
  public bool bIgnoreWallet;
  public AActor Instigator;
}

public class USFSeqAct_SetBOSS : USequenceAction
{
  public string ReplaceMaterial;
  public List<USFTypes.FsBossSkill> Skills;
  public bool ClearInventory;
  public int ReplaceMaterialSet;
  public int DropItemCount;
}

public class USFSeqAct_SetConvoyanceStoreIcon : USequenceAction
{
}

public class USFSeqAct_SetCustomMaxWaveIndex : USequenceAction
{
  public int CustomMaxWave;
}

public class USFSeqAct_SetCustomWaveIndex : USequenceAction
{
  public int CustomWave;
}

public class USFSeqAct_SetEnableSeqEvent : USequenceAction
{
  public bool bEnabled;
}

public class USFSeqAct_SetHideAllPawn : USequenceAction
{
  public bool bHide;
}

public class USFSeqAct_SetInfiniteAmmo : USFSeqAct_SFGameInfo
{
  public bool bInfiniteAmmo;
  public bool bInfiniteMagazine;
  public List<EWEAPON_GROUP> InfiniteAmmoWeaponGroup;
  public List<EWEAPON_GROUP> InfiniteMagazineWeaponGroup;
}

public class USFSeqAct_SetInGameShopLevel : USequenceAction
{
  public int NewShopLevel;
}

public class USFSeqAct_SetIntermissionCutScene : USFSeqAct_SFGameInfo
{
  public int Index;
}

public class USFSeqAct_SetObjectIcon : USequenceAction
{
  public bool IsRegisterObjectIcon;
  public bool bClientSideOnly;
  public EObjectIconTypes ObjectIconType;
  public EObjectIconState IconState;
  public ETeam ShowingIconTeamIndex;
}

public class USFSeqAct_SetPawnGroundSpeed : USequenceAction
{
  public float SpeedRate;
}

public class USFSeqAct_SetPhysicsWeight : USequenceAction
{
  public float NewPhysicsWeight;
}

public class USFSeqAct_SetPrimaryTarget : USequenceAction
{
  public AActor PrimaryActor;
}

public class USFSeqAct_SetPrimaryTargetIcon : USequenceAction
{
}

public class USFSeqAct_SetStrongHoldRoundTime : USequenceAction
{
  public float RoundTime;
}

public class USFSeqAct_SetTeam : USequenceAction
{
  public ETeam newTeamNum;
}

public class USFSeqAct_SetViewTarget : USFSeqAct_SFGameInfo
{
  public ACameraActor Cam;
  public float ChangeViewTargetDelay;
}

public class USFSeqAct_SetWeaponAmmo : USFSeqAct_SFGameInfo
{
  public List<USFTypes.FWeaponAmmo> AmmoInfo;
}

public class USFSeqAct_SetWeather : USequenceAction
{
  public bool bOverrideEmitterHeight;
  public bool bUseCameraLensEffect;
  public float EmitterHeight;
  public UClass WeatherEmitter;
}

public class USFSeqAct_SetWeatherLOD : USequenceAction
{
  public bool bSetLOD;
  public int LODLevel;
}

public class USFSeqAct_SHAreaIndex : USFSeqAct_SFGameInfo
{
  public ESFStrongHoldArea AreaIndex;
  public AActor Instigator;
}

public class USFSeqAct_SnatchWeaponGroup : USequenceAction
{
  public List<EWEAPON_GROUP> WeaponGroup;
}

public class USFSeqAct_SpectatorCameraPath : USeqAct_Interp
{
  public float TravelTimeBetweenStops;
  public bool bSwapForwardAndReverse;
  public bool bAutomaticFraming;
  public bool bCachedInterpData;
  public ACameraActor CachedCameraActor;
  public UInterpTrackMove CachedMoveTrack;
  public UInterpTrackInstMove CachedMoveTrackInst;
  public UInterpTrackEvent CachedEventTrack;
  public UInterpTrackInstEvent CachedEventTrackInst;
  public int LastStopIdx;
  public int DestinationStopIdx;
  public float InterpTimeToNextStop;
}

public class USFSeqAct_StartCountDown : USequenceAction
{
}

public class USFSeqAct_SyncPawnLocation : USequenceAction
{
}

public class USFSeqAct_ToggleAIWave : USeqAct_Toggle
{
}

public class USFSeqAct_ToggleNotifyKeyInput : USeqAct_Toggle
{
  public FName KeyName;
}

public class USFSeqAct_UpdateItemCarrierPathNode : USFSeqAct_SFGameInfo
{
}

public class USFSeqAct_WakeRigidBody : USFSeqAct_SFGameInfo
{
}

public class USFSeqAct_WaveFactory : USeqAct_Latent
{
  public int MinWave;
  public int MaxWave;
  public int MaxWaves;
  public float WaveSpawningStartTime;
  public float EndOfRoundDelay;
  public int CurrentWave;
  public bool bDelayActive;
  public float LastUpdateTime;
  public float RemainingTime;
}

public class USFSeqCond_AIDifficulty : USequenceCondition
{
}

public class USFSeqCond_IsSameState : USequenceCondition
{
  public FName StateName;
}

public class USFSeqCond_LocalPlayerTeam : USequenceCondition
{
}

public class USFSeqEvent_Base : USequenceEvent
{
}

public class USFSeqEvent_AIWaveChanged : USFSeqEvent_Base
{
  public int WaveIndex;
}

public class USFSeqEvent_BombTrigger : USFSeqEvent_Base
{
}

public class USFSeqEvent_BombVolume : USFSeqEvent_Base
{
}

public class USFSeqEvent_byScript : USFSeqEvent_Base
{
  public FName MyName;
}

public class USFSeqEvent_CaptureTeamChanged : USFSeqEvent_Base
{
}

public class USFSeqEvent_CaptureVolume : USFSeqEvent_Base
{
}

public class USFSeqEvent_CheckTargetTouch : USeqEvent_Touch
{
}

public class USFSeqEvent_CodeNameNeeded : USFSeqEvent_Base
{
}

public class USFSeqEvent_Complete : USequenceEvent
{
  public bool bAimToInteract;
  public float InteractDistance;
  public string InteractText;
  public UTexture2D InteractIcon;
  public List<UClass> ClassProximityTypes;
  public List<UClass> IgnoredClassProximityTypes;
}

public class USFSeqEvent_ConvoyanceItem : USequenceEvent
{
}

public class USFSeqEvent_ConvoyanceMove : USFSeqEvent_Base
{
}

public class USFSeqEvent_ConvoyanceNotiRemainGold : USFSeqEvent_Base
{
}

public class USFSeqEvent_SeizureTrigger : USFSeqEvent_Base
{
}

public class USFSeqEvent_CTFFlag : USFSeqEvent_SeizureTrigger
{
}

public class USFSeqEvent_DroppedWeapon : USFSeqEvent_Base
{
}

public class USFSeqEvent_ElevatorActor : USFSeqEvent_Base
{
}

public class USFSeqEvent_ElevatorActorOperationComplete : USFSeqEvent_Base
{
}

public class USFSeqEvent_EndCodeName : USFSeqEvent_Base
{
}

public class USFSeqEvent_EndRound : USFSeqEvent_Base
{
}

public class USFSeqEvent_FastWave : USFSeqEvent_Base
{
}

public class USFSeqEvent_FrontLineVolume : USFSeqEvent_Base
{
}

public class USFSeqEvent_Helicopter : USFSeqEvent_Base
{
}

public class USFSeqEvent_HostMigration : USFSeqEvent_Base
{
}

public class USFSeqEvent_IntermissionCutScene : USFSeqEvent_Base
{
}

public class USFSeqEvent_Intro : USFSeqEvent_Base
{
}

public class USFSeqEvent_Killed : USequenceEvent
{
}

public class USFSeqEvent_Mission : USFSeqEvent_Base
{
}

public class USFSeqEvent_ModeVolume : USFSeqEvent_Base
{
}

public class USFSeqEvent_NotifyKeyInput : USFSeqEvent_Base
{
  public FName KeyName;
}

public class USFSeqEvent_ObstacleLevelChanged : USFSeqEvent_Base
{
}

public class USFSeqEvent_ParticleModuleEvent : USFSeqEvent_byScript
{
}

public class USFSeqEvent_ProgressComplete : USFSeqEvent_Base
{
}

public class USFSeqEvent_PvEShop : USFSeqEvent_Base
{
}

public class USFSeqEvent_RescueVolume : USFSeqEvent_Base
{
}

public class USFSeqEvent_RespawnCamera : USFSeqEvent_Base
{
  public ETeam TargetTeam;
}

public class USFSeqEvent_SFBreakableActor : USFSeqEvent_Base
{
  public float DamageThreshold;
  public float CurrentDamage;
  public bool bResetDamageOnToggle;
}

public class USFSeqEvent_SFBreakableActorByDamage : USFSeqEvent_SFBreakableActor
{
}

public class USFSeqEvent_SFTriggerState : USFSeqEvent_Base
{
}

public class USFSeqEvent_StrongHoldMatchEnd : USFSeqEvent_Base
{
}

public class USFSeqEvent_StrongHoldRoundEnd : USFSeqEvent_Base
{
  public ESFStrongHoldArea AreaIndex;
}

public class USFSeqEvent_ThunderRunState : USFSeqEvent_Base
{
}

public class USFSeqEvent_Touch : USeqEvent_Touch
{
  public ETeam TargetTeam;
  public bool bCanTouchInTrainingGame;
  public List<AActor> FilterdList;
}

public class USFSeqEvent_Turret : USFSeqEvent_Base
{
}

public class USFSeqEvent_TutCourseSelected : USFSeqEvent_Base
{
}

public class USFSeqVar_GameInfo : USeqVar_Object
{
}

public class USFSeqVar_LocalPlayerPawn : USeqVar_Object
{
}

public class USFSeqVar_NavPointNearbyPlayer : USeqVar_Object
{
  public ETeam PlayerTeamIndex;
  public float MinDistanceFromPlayer;
  public float MaxDistanceFromPlayer;
  public int PlayerIndex;
  public List<ANavigationPoint> NavPoints;
}

public class USFSeqVar_PlayerCounter : USeqVar_Int
{
  public bool bOnlyUser;
  public ETeam PlayerTeamIndex;
  public int PlayerCounter;
}

public class USFSeqVar_PlayerSelectTeam : USeqVar_Object
{
  public List<UObject> Players;
  public ETeam PlayerTeamIndex;
}

public class USFSeqVar_RandomVector : USeqVar_Vector
{
  public FVector Min;
  public FVector Max;
}

public class USFServerConnection : UObject
{
  public class FSFSocket
  {
    public UObject.FPointer Socket;
    public UObject.FPointer netBuf;
    public UObject.FPointer CriticalSection;
    public UObject.FPointer RecvRunnable;
    public UObject.FPointer RecvThread;
    public List<UPacket> PacketArray;
    public int PacketArraySize;
    public int nRead;
    public bool IsConnect;
    public int DisconnectCount;
  }

  public string Tag;
  public string IP;
  public int Port;
  public float nowtime;
  public bool bIsPolling;
  public bool bForceExitWhenDisconnect;
  public int PollingCount;
  public FSFSocket SocketInfo;
  public int ConnectTryCount;
}

public class ASFShooterGame : ASFTeamGameInfo
{
  public List<string> DroppedPickupList;
  public FVector PickupSpawnRandomVel;
}

public class ASFShooterCTFGame : ASFShooterGame
{
}

public class ASFShooterHUD : ASFHardCoreTeamHUD
{
}

public class ASFShooterCTFHUD : ASFShooterHUD
{
}

public class ASFShooterDefenceGame : ASFSurvivalGame
{
  public class FsDroppedPickupInfo
  {
    public ELevelOfDifficulty Diff;
    public float Rate;
    public string ClassName;
    public float ExtraVal;
    public UClass Class;
  }

  public float MinSpectateDelay;
  public List<float> BonusPawnRating;
  public float ExpRatePerKill;
  public float ExpRatePerAssist;
  public List<FsDroppedPickupInfo> DroppedPickupInfos;
  public List<FsDroppedPickupInfo> DroppedHealthPickupInfos;
  public List<FsDroppedPickupInfo> DroppedMoneyPickupInfos;
  public List<FsDroppedPickupInfo> DroppedPowUpPickupInfos;
  public float DroppedHealthRateTotal;
  public float DroppedMoneyRateTotal;
  public float DroppedPowUpRateTotal;
  public int ItemCarrierAICount;
  public float ItemCarrierSpawnRate;
  public int ItemCarrierSpawnAdd;
  public float OverStockItemExcepRate;
  public List<float> DifficultyHealthRate;
  public int NextZoneLimitTime;
  public bool bUseMoveZoneTimeLimit;
  public bool bNextZoneOpen;
  public int CountDownSeconds;
  public List<ASFPlayerController> AllPlayerControllers;
  public List<AActor> TouchedPawnList;
  public int TotalPlayerCount;
}

public class ASFSurvivalGameReplicationInfo : ASFGameReplicationInfo
{
  public int CurrentWave;
  public int MaxWaves;
  public List<USFSeqAct_Explode> ShockWaveSeqs;
  public int VeryHardMaxWave;
  public bool bFastWave;
  public float ShowCloakingRipperTime;
  public int AIKillExp;
  public int RevivalExp;
  public int WaveClearExp;
  public List<float> DifficultyExpRatioArray;
}

public class ASFShooterDefenceGameReplicationInfo : ASFSurvivalGameReplicationInfo
{
  public float EnemyMarkOutlineWidth;
  public float EnemyMarkOutLineIntense;
  public FLinearColor ItemCarrierPointedColor;
}

public class USFSurvivalGameScore : USFGameScore
{
  public List<USFTypes.FAIPawnScore> PawnClassBasis;
  public float SCORE_WaveEnd;
  public float SCORE_BossClear;
  public float SCORE_WaveEndTeam;
  public float SCORE_BossClearTeam;
}

public class USFShooterDefenceGameScore : USFSurvivalGameScore
{
}

public class ASFShooterDefenceHUD : ASFDefenceHUD
{
  public int PrevModeMoney;
  public int PrevKillCount;
  public int PrevMyDeathCount;
  public bool bDraw2dHitTestBox;
}

public class ASFShooterPlayerController : ASFPvEPlayerController
{
  public string ReloadEffectString;
  public float ReloadEffectScale;
  public UParticleSystem ReloadEffectPS;
  public ASFEmitterNoSync ReloadEmitter;
  public string HitEffectString;
  public float HitEffectScale;
  public UParticleSystem HitEffectPS;
  public ASFEmitterNoSync HitEmitter;
  public string PlayerMarkString;
  public float PlayerMarkScale;
  public UDecalMaterial PlayerMarkMaterial;
  public ADecalActorMovable PlayerMarkDecal;
  public string SpeedUpMarkString;
  public float SpeedUpMarkScale;
  public UDecalMaterial SpeedUpMarkMaterial;
  public ADynamicSMActor_Spawnable LookAtConeComponent;
  public string LookAtConeMeshString;
  public UStaticMesh LookAtConeMesh;
  public USpotLightComponent LookAtLight;
  public FRotator LookAtConeRelRotation;
  public FVector LastFocusOrigin;
  public float CameraIsolateViewDistance;
  public float CameraMaxHeight;
  public float CameraApplyRatio;
  public float CameraExtentViewRatio;
  public float CameraInterpSpeed;
  public float CameraFOV;
  public bool bEnableCameraExtentViewX;
  public bool bEnableCameraExtentViewY;
  public bool bEnableCameraExtentViewZ;
  public bool bSetDesiredCamera;
  public bool bEnableTargeting;
  public bool ShooterMouseLocInited;
  public int StatStoreIndex;
  public float DesiredCameraIsolateViewDistance;
  public float DesiredCameraMaxHeight;
  public float DesiredCameraApplyRatio;
  public float DesiredCameraExtentViewRatio;
  public float DesiredCameraApplyInterpTime;
  public float DesiredAlpha;
  public FRotator CameraBaseRotation;
  public FVector CameraBaseDirection;
  public FRotator ViewRotationLimit;
  public float PlaneConstantOld;
  public FVector2D StartTrace2d;
  public FVector2D EndTrace2d;
  public float ShooterMouseSensitivity;
  public float ShooterMouseCalibration;
  public FVector2D ShooterMouseLoc;
  public FVector2D HalfScreenRes;
  public eMOUSEMode MouseModecurrent;
}

public class ASFShooterDefencePlayerController : ASFShooterPlayerController
{
  public USFTypes.FWeaponInventorySet[] OldWeaponInventoryInfo = new USFTypes.FWeaponInventorySet[3];
  public int NextZoneProcessTime;
}

public class ASFSurvivalPlayerReplicationInfo : ASFGrowUpPlayerReplicationInfo
{
  public float RespawnDelay;
  public float RespawningStartTime;
  public int DBNOCount;
  public int RevivalCount;
  public int CriticalKill;
  public int AcquiredMoney;
  public int AcquiredBonusMoney;
  public int SpendMoney;
  public int PrevAcquiredMoney;
  public int PrevAcquiredBonusMoney;
  public int AccmulationMoney;
  public FName RevivalEventDataName;
}

public class ASFShooterDefencePlayerReplicationInfo : ASFSurvivalPlayerReplicationInfo
{
  public class FsPowerUp
  {
    public UClass PowerUpClass;
    public float StockedTime;
    public int Count;
  }

  public float GroundSpeedRatio;
  public float DodgeSpeedRatio;
  public float LastMaxHealth;
  public float LastUpdateStatUp;
  public List<FsPowerUp> StockedPowerUp;
  public List<UClass> StockedModeItems;
  public int PowerUpStockLimit;
  public List<USFTypes.FsWeaponInitInfo> WeaponInitInfos;
  public List<USFTypes.FsWeaponTuneInfo> WeaponATTTuneInfos;
  public List<USFTypes.FsPawnTuneInfo> PawnTuneInfos;
  public int MaxAttUp;
  public int MaxDefUp;
  public int MaxAglUp;
  public List<UClass> RecursiveClasses;
  public byte RepStatChanged;
}

public class ASFShooterGameReplicationInfo : ASFSurvivalGameReplicationInfo
{
}

public class ASFShooterPlayerReplicationInfo : ASFPlayerReplicationInfo
{
  public class FInGameLevelData
  {
    public int Level;
    public int Health;
    public float DamagePct;
    public float SpeedPct;
  }

  public class FInGameLevelInfo
  {
    public int Kills;
    public int Level;
  }

  public List<FInGameLevelInfo> Levels;
  public List<FInGameLevelData> ARLevelData;
  public List<FInGameLevelData> SRLevelData;
  public List<FInGameLevelData> SMGLevelData;
  public List<FInGameLevelData> MGLevelData;
  public List<FInGameLevelData> SGLevelData;
  public int InGameLevel;
  public float CurrentDamagePct;
  public float CurrentSpeedPct;
  public UParticleSystem LevelUpEffect;
  public ASFEmitterNoSync LevelUpEffectEmiiter;
  public float LevelUpEffectPlayTime;
  public USoundCue LevelUpSound;
}

public class ASFThunderRunGame : ASFTeamGameInfo
{
  public ASFThunderRunGameReplicationInfo SFThunderRunGRI;
  public ASFThunderRunState GameStateInfo;
  public int ReduceRespawnTimeTeam;
  public float ReduceRespawnTimePerMinute;
  public float MaxReduceRespawnTime;
  public float RespawnTimeByKillVolume;
  public float FadeDurationOnPostRoundOver;
}

public class ASFShooterThunderRunGame : ASFThunderRunGame
{
}

public class ASFShopActor : ASFObstaclesActor
{
}

public class ASFShotgunGame : ASFTeamGameInfo
{
}

public class ASFShotgunGameReplicationInfo : ASFGameReplicationInfo
{
}

public class ASFShotgunTDMGame : ASFBaseTeamDeathGame
{
}

public class USFShotgunTDMGameScore : USFGameScore
{
}

public class ASFShotgunTDMHUD : ASFTeamHUD
{
}

public class ASFSHPlayerController : ASFPlayerController
{
}

public class ASFSHTeamInfo : ASFTeamInfo
{
  public int WinningArea;
}

public class USFShutDownLaw : UObject
{
  public class FSShutDownCloseMsg
  {
    public int ShutDownCode;
    public string ShutDownName;
    public string Message;
  }

  public class FSShutDownRemainMsg
  {
    public string ShutDownName;
    public string Message;
  }

  public class FSForcedShutDownLaw
  {
    public int Step;
    public int StartTime;
    public bool bPerMinute;
  }

  public List<FSShutDownCloseMsg> ShutDownCloseMsgArray;
  public List<FSShutDownRemainMsg> ShutDownRemainMsgArray;
  public List<FSForcedShutDownLaw> ShutDownLawArray;
  public int ShutDownStartTime;
  public int ShutDownFinishTime;
  public string ShutDownCommonMessage;
  public List<string> ShutDownLawMessage;
  public bool bShutDownLawUse;
  public int ShutDownMaxAge;
}

public class USFSkelControl_CantileverBeam : USkelControlLookAt
{
  public FVector WorldSpaceGoal;
  public FVector InitialWorldSpaceGoalOffset;
  public FVector Velocity;
  public float SpringStiffness;
  public float SpringDamping;
  public float PercentBeamVelocityTransfer;
  public FScriptDelegate __EntireBeamVelocity__Delegate;
}

public class USFSkelControl_MassBoneScaling : USkelControlBase
{
  public class FBoneScaleInfo
  {
    public FName BoneName;
    public float BoneScale;
    public int BoneIndex;
  }

  public List<FBoneScaleInfo> BoneScales;
}

public class USFSkelControl_CharacterDiffScaling : USFSkelControl_MassBoneScaling
{
}

public class USFSkelControl_Retargeting : USkelControlBase
{
  public class FIKMatching
  {
    public FName EffectorBoneName;
    public FName LimbBoneName;
    public FName JointBoneName;
    public EAxis BoneAxis;
    public EAxis JointAxis;
    public bool bInvertBoneAxis;
    public bool bInvertJointAxis;
    public int EffectorBoneIndex;
    public int LimbBoneIndex;
    public int JointBoneIndex;
  }

  public class FIKMaptchInfo
  {
    public bool bNeedIK;
    public int MatchingIndex;
  }

  public USkeletalMesh SourceMesh;
  public USkeletalMesh TargetMesh;
  public List<FVector> BoneDimensions;
  public List<FName> IgnoreBoneMap;
  public List<bool> BoneIgnoreTable;
  public List<FIKMatching> IKMatchingMap;
  public List<FIKMaptchInfo> IKMatchingTable;
  public List<FVector> LocalDimensions;
}

public class USFSkelControlFullBodyIK : USkelControlBase
{
}

public class ASFSkeletalMeshActor : ASkeletalMeshActor
{
}

public class USFSlashEventData : USFSpecialKillEventData
{
}

public class ASFSliceSyncState : AReplicationInfo
{
  public USFTypes.FSliceState[] arrSliceState = new USFTypes.FSliceState[22];
  public int LastArrayIndex;
  public int SavedLastArrayIndex;
  public ASFSliceSyncState NextSyncState;
  public int MaxCountToSpawnAtOnce;
}

public class ASFSniperGame : ASFTeamGameInfo
{
}

public class ASFSniperGameReplicationInfo : ASFGameReplicationInfo
{
}

public class USFSniperGameScore : USFGameScore
{
}

public class ASFSniperHUDBase : ASFHUD
{
}

public class ASFSniperHUD : ASFSniperHUDBase
{
}

public class ASFSniperSpot : ASFDefensePoint
{
}

public class ASFSniperTDMGame : ASFBaseTeamDeathGame
{
}

public class USFSniperTDMGameScore : USFGameScore
{
}

public class ASFSniperTDMHUD : ASFSniperHUDBase
{
}

public class ASFSnowballFightGame : ASFBaseTeamDeathGame
{
}

public class ASFSnowballFightGameReplicationInfo : ASFGameReplicationInfo
{
}

public class ASFSnowBallFightHud : ASFTeamHUD
{
}

public class ASFSnowBallPlayerController : ASFPlayerController
{
}

public class ASFSoloLeagueGame : ASFDeathGame
{
}

public class USFSoloLeagueGameScore : USFGameScore
{
}

public class ASFSoloLeagueHUD : ASFDeathHUD
{
}

public class USFSoundGroup_Item : USFSoundGroup
{
}

public class USFSoundGroup_Voice : USFSoundGroup
{
  public class FVoiceWave
  {
    public List<USoundNodeWave> Waves;
    public string Caption;
    public float CaptionLifeTime;
  }

  public class FBGMInfo
  {
    public USoundCue Cue;
    public float FadeInTime;
    public float FadeOutTime;
    public float Duration;
  }

  public class FVoiceMessage
  {
    public FName EventName;
    public USFSoundGroup_Voice.FBGMInfo BGMToPlay;
    public USFSoundGroup_Voice.FVoiceWave[] Sounds = new USFSoundGroup_Voice.FVoiceWave[10];
  }

  public List<FVoiceMessage> VoiceMessages;
  public USFSoundGroup_Voice Parent;
}

public class USFSoundGroup_Weapon : USFSoundGroup
{
}

public class ASFSpawnedEmitter : ASFEmitter
{
}

public class ASFSpawner : AActor
{
  public class FSpawnerSlot
  {
    public bool bEnabled;
    public ASFPawn_AI SpawningPawn;
    public UObject.FVector LocationOffset;
    public UObject.FRotator RotationOffset;
    public EHoleEmergeAnim EmergeAnim;
  }

  public bool bActive;
  public bool bAutoDeActivate;
  public List<USFSeqAct_AIFactory> Factories;
  public List<FSpawnerSlot> SpawnSlots;
  public AActor Killer;
}

public class ASFSpawner_EHole : ASFSpawner
{
  public FName currState;
}

public class ASFSpawner_EHoldSpawnable : ASFSpawner_EHole
{
}

public class ASFSpawner_EholeSpawnLocation : AActor
{
  public bool bEnabled;
  public EHoleEmergeAnim EmergeAnim;
}

public class USFSpecialforceEventData : USFSpecialKillEventData
{
}

public class USFSpecialistEventData : USFSpecialKillEventData
{
}

public class ASFSpecialWeaponGame : ASFTeamGameInfo
{
  public int CurrentRoundWeaponID;
  public bool EachCheckStartRoundForGiveWeapon;
}

public class ASFSpecialWeaponGameReplicationInfo : ASFGameReplicationInfo
{
}

public class USFSpecialWeaponGameScore : USFGameScore
{
}

public class ASFSpecialWeaponHUD : ASFHUD
{
}

public class USFSpecialWeaponKillDeathMessage : USFKillDeathMessage
{
}

public class ASFSpecialWeaponPlayerController : ASFPlayerController
{
}

public class USFSpectatorCam_AutoFraming : UObject
{
  public class FAutoframingWatchedPawn
  {
    public ASFPawn SFP;
    public UObject.FVector LookatLoc;
    public float LastRelevantTime;
    public EAutoFramingPawnTracePoint LastTracePoint;
    public float NormalizedWeight;
    public bool bNoRelevanceLag;
  }

  public USFSpectatorCamera SpectatorCam;
  public float LastFOV;
  public float FOVInterpSpeed;
  public float FOVInterpSpeed_MovingCamera;
  public FRotator LastDeltaRot;
  public float RotInterpSpeed;
  public float RotInterpSpeed_MovingCamera;
  public bool bLastLookatIsValid;
  public bool bDebugSkipFOVAdj;
  public bool bDebugShowWatchedPawns;
  public bool bWasInterpolating;
  public FVector LastLookat;
  public float LookatInterpSpeed;
  public float LookatInterpSpeed_MovingCamera;
  public FVector2D WorldPitchRange;
  public FVector2D RelativeYawRange;
  public FVector2D AcceptableFOVRange;
  public float BorderBufferPercentage_Horizontal;
  public float BorderBufferPercentage_Vertical;
  public float ZoomFOVAdjustmentMag;
  public float ZoomBufferAdjustmentMag;
  public float DirSelectionWeightMultiplier_Good;
  public float DirSelectionWeightMultiplier_Bad;
  public FVector LastCamActorLoc;
  public List<FAutoframingWatchedPawn> RelevantPawnList;
  public float RelevanceLagTime;
  public float RelevanceFadeTime;
  public float PawnTraceRadius;
  public float VelBiasFactor;
}

public class USFSpectatorCamera : USFCameraBase
{
  public USFSpectatorCam_AutoFraming AutoFramingCam;
  public float DefaultFOV;
  public float ControlInfo_LookRight;
  public float ControlInfo_LookUp;
  public float ControlInfo_Zoom;
}

public class ASFSpectatorEmitter : AEmitter
{
  public bool bSpectatorOnly;
}

public class ASFSpectatorPoint : ACameraActor
{
  public class FZoomPropertyStruct
  {
    public float FOVMax;
    public float FOVMin;
    public float FOVDelta;
  }

  public class FFOVInterpSpeedPropertyStruct
  {
    public float FOVInterpSpeed;
    public float FOVInterpSpeed_MovingCamera;
  }

  public class FRotInterpSpeedPropertyStruct
  {
    public float RotInterpSpeed;
    public float RotInterpSpeed_MovingCamera;
  }

  public class FLookatInterpSpeedPropertyStruct
  {
    public float LookatInterpSpeed;
    public float LookatInterpSpeed_MovingCamera;
  }

  public string DisplayText;
  public int OrderIndex;
  public FRotator UserRotationRange;
  public float MaxRotationRate;
  public FZoomPropertyStruct ZoomProperty;
  public ESpecPointCameraMode CameraMode;
  public FFOVInterpSpeedPropertyStruct FOVInterpSpeedProperty;
  public FRotInterpSpeedPropertyStruct RotInterpSpeedProperty;
  public FLookatInterpSpeedPropertyStruct LookatInterpSpeedProperty;
}

public class USFSplashEventData : USFSpecialKillEventData
{
}

public class ASFSprayActor : ADecalActor
{
  public float DecalSize;
  public float Thickness;
  public int PlayerID;
  public int SlotIndex;
  public int EmblemID;
  public string EmblemFileName;
  public FRotator ViewRotation;
  public USFSprayDecal SprayDecal;
  public UMaterial SprayBaseMaterial;
  public string SprayMaterialName;
  public bool bBackFace;
}

public class USFSprayDecal : USFDecal
{
  public float fFadeTime;
  public List<UClass> IgnoreActorClass;
}

public class USFSprayTextureManager : UObject
{
  public class FSprayTextureFile
  {
    public string Filename;
    public UTexture2D Texture;
  }

  public string SprayTexturePath;
  public List<FSprayTextureFile> arrSprayTexturFile;
}

public class ASFSpyHUD : ASFTeamHUD
{
}

public class ASFSpyPlayerController : ASFPlayerController
{
}

public class ASFSquadFormation : AInfo
{
  public class FFormationPosition
  {
    public FName PosName;
    public int RelIdx;
    public int YawOffset;
    public float Distance;
    public float LastUpdateTime;
    public UObject.FVector LastUpdatePosition;
    public UObject.FVector IdealPosition;
    public ANavigationPoint Nav;
    public ASFAIController AI;
    public UObject.FColor DebugColor;
  }

  public ASFSquad Squad;
  public List<FFormationPosition> Positions;
  public FVector LastSquadPosition;
  public FVector CurrentSquadPosition;
}

public class ASFSquadFormation_Line : ASFSquadFormation
{
}

public class ASFSquadFormation_Wedged : ASFSquadFormation
{
}

public class ASFStairVolume : APhysicsVolume
{
}

public class ASFStaticMeshActor : AStaticMeshActor
{
  public List<USFTypes.FOriginMtrlData> OriginMtrlDatas;
  public UStaticMesh BreakedMesh;
  public ADynamicSMActorNoSyncSpawnable BreakedMeshActor;
}

public class ASFStealOffGame : ASFBaseTeamDeathGame
{
  public string DroppedPickupMoneyClassName;
  public bool bFixedMoneyDrop;
  public bool bReduceMoneyWhenDrop;
  public bool bDropMoneyEvenIfTeamKill;
  public int DropMoneyWhenDead;
  public int GiveMoneyWhenSpawn;
  public FVector MoneySpawnRandomVel;
  public int DropMoneyMaxBunch;
  public int DropMoneyMinBunch;
}

public class USFStomachHitCountEventData : USFWeaponEventData
{
}

public class USFStrikeEventData : USFSpecialKillEventData
{
}

public class ASFStrongHold2Game : ASFTeamGameInfo
{
}

public class ASFStrongHold2HUD : ASFTeamHUD
{
}

public class ASFStrongHold3Game : ASFTeamGameInfo
{
}

public class ASFStrongHoldGame : ASFTeamGameInfo
{
  public int RespawnPeriod;
  public bool bForceRespawnNextArea;
  public bool bCanRespawn;
  public int MaxMissionWinCount;
  public ASFStrongHoldGameReplicationInfo SFSHGRI;
}

public class ASFStrongHoldGameReplicationInfo : ASFGameReplicationInfo
{
  public ESFStrongHoldArea nCurrentAreaIndex;
  public byte RespawnTime;
}

public class USFStrongHoldGameScore : USFGameScore
{
  public float SCORE_Escaped;
  public float SCORE_EscapedTeam;
  public float SCORE_Planted;
  public float SCORE_PlantedTeam;
  public float SCORE_Exploded;
  public float SCORE_ExplodedTeam;
  public float SCORE_Defused;
  public float SCORE_DefusedTeam;
  public float SCORE_Seizured;
  public float SCORE_SeizuredTeam;
  public float SCORE_SH_Trigger;
  public float SCORE_SH_TriggerTeam;
}

public class ASFStrongHoldHUD : ASFTeamHUD
{
  public ASFStrongHoldGameReplicationInfo SFSHGRI;
  public string[] ObjectMessageArea2_A = new string[2];
  public string[] ObjectMessageArea2_B = new string[2];
  public string[] ObjectMessageArea3_A = new string[2];
  public string[] ObjectMessageArea3_B = new string[2];
  public string[] ObjectMessageArea4_A = new string[2];
  public string[] ObjectMessageArea4_B = new string[2];
  public string[] WaitingForNextMission = new string[2];
}

public class USFSuperMarioEventData : USFSpecialKillEventData
{
}

public class USFSurvivalAssistEventData : USFBaseEventData
{
}

public class USFSurvivalBossKillEventData : USFBaseEventData
{
}

public class USFSurvivalCloakingRipperKillEventData : USFBaseEventData
{
}

public class USFSurvivalCriticalKillEventData : USFBaseEventData
{
}

public class USFSurvivalCurrentWaveEventData : USFBaseEventData
{
}

public class USFSurvivalEliteCrawlerKillEventData : USFBaseEventData
{
}

public class USFSurvivalEliteLibertineKillEventData : USFBaseEventData
{
}

public class USFSurvivalEliteRipperKillEventData : USFBaseEventData
{
}

public class USFSurvivalEliteStunnerKillEventData : USFBaseEventData
{
}

public class USFSurvivalEliteTyrantKillEventData : USFBaseEventData
{
}

public class USFSurvivalGasStunnerKillEventData : USFBaseEventData
{
}

public class USFSurvivalKillByAIType : USFBaseEventData
{
}

public class USFSurvivalKillDeathMessage : USFLocalMessage
{
}

public class USFSurvivalKillEventData : USFBaseEventData
{
}

public class USFSurvivalMatchClearEventData : USFBaseEventData
{
}

public class USFSurvivalNamedCrawlerKillEventData : USFBaseEventData
{
}

public class USFSurvivalNamedLibertineKillEventData : USFBaseEventData
{
}

public class USFSurvivalNamedRipperKillEventData : USFBaseEventData
{
}

public class USFSurvivalNamedStunnerKillEventData : USFBaseEventData
{
}

public class USFSurvivalNamedTyrantKillEventData : USFBaseEventData
{
}

public class ASFSurvivalPlayerController : ASFPvEPlayerController
{
  public float RespawningDeltaTime;
  public int RevivalTargetPawnID;
  public float RevivalTargetDist;
  public float EnableInteractionDist;
  public ASFObstaclesActor InstallableTargetObstacle;
  public ASFObstaclesActor TargetObstacleActor;
  public string MSG_Possible_To_Build_Obstacles;
  public string MSG_Impossible_To_Build_Obstacles;
  public float InstallObstacleStartTime;
}

public class USFSurvivalRevivalCountEventData : USFBaseEventData
{
}

public class USFSurvivalScoreEventData : USFBaseEventData
{
}

public class USFSurvivalSpendScoreEventData : USFBaseEventData
{
}

public class ASFTargetPaper : AInterpActor
{
  public class FTargetInfo
  {
    public UStaticMesh StaticMesh;
    public List<int> ScoreForPerMaterial;
  }

  public class FRandomTargetInfo
  {
    public ASFTargetPaper.FTargetInfo Target;
    public float RandomRate;
  }

  public List<FRandomTargetInfo> RandomTargetInfos;
  public int SelectedIndex;
  public bool bHitOnce;
  public bool bHitted;
  public bool bEnabled;
  public bool bSpatializeTargetHitSound;
  public bool bOnlyDamagedByExigency;
  public int SectionID;
  public USoundCue PositiveTargetHitSound;
  public USoundCue NegativeTargetHitSound;
  public List<UClass> DamageTypeAllows;
  public ECollisionType DefaultCollisionForReset;
}

public class ASFTeamDeathGameVs16 : ASFBaseTeamDeathGame
{
}

public class USFTeamDeathGameVs16Score : USFTeamDeathGameScore
{
}

public class ASFTeamDeathRocketHUD : ASFTeamDeathHUD
{
}

public class ASFTeamDeathTestOneGame : ASFBaseTeamDeathGame
{
}

public class ASFTeamDeathTestTwoGame : ASFBaseTeamDeathGame
{
}

public class ASFTeamDeathVs16HUD : ASF16VS16ModeHUD
{
}

public class ASFTeamTestOneGame : ASFTeamGameInfo
{
  public USFTypes.FSSpawnableAlienInfo[] SpawnableAlienInfoList = new USFTypes.FSSpawnableAlienInfo[3];
  public UClass[] AlienPawnClass = new UClass[3];
  public ETeam BeastTeam;
}

public class ASFTeamTestTwoGame : ASFTeamGameInfo
{
}

public class USFThirdAnimName : UObject
{
  public List<FName> VT_DeathHeadF;
  public List<FName> VT_DeathHeadB;
  public List<FName> VT_DeathHeadL;
  public List<FName> VT_DeathHeadR;
  public List<FName> VT_DeathUpperF;
  public List<FName> VT_DeathUpperB;
  public List<FName> VT_DeathUpperL;
  public List<FName> VT_DeathUpperR;
  public List<FName> VT_DeathLowerF;
  public List<FName> VT_DeathLowerB;
  public List<FName> VT_DeathLowerL;
  public List<FName> VT_DeathLowerR;
  public List<FName> VT_DeathCrouchF;
  public List<FName> VT_DeathCrouchB;
  public List<FName> VT_DeathCrouchL;
  public List<FName> VT_DeathCrouchR;
  public List<FName> VT_DeathCrouchExplosiveF;
  public List<FName> VT_DeathCrouchExplosiveB;
  public List<FName> VT_DeathCrouchExplosiveL;
  public List<FName> VT_DeathCrouchExplosiveR;
  public List<FName> VT_DeathExplosiveF;
  public List<FName> VT_DeathExplosiveB;
  public List<FName> VT_DeathExplosiveL;
  public List<FName> VT_DeathExplosiveR;
  public List<FName> VT_DeathJumpF;
  public List<FName> VT_DeathJumpB;
  public List<FName> VT_DeathJumpL;
  public List<FName> VT_DeathJumpR;
  public List<FName> DeathHeadF;
  public List<FName> DeathHeadB;
  public List<FName> DeathHeadL;
  public List<FName> DeathHeadR;
  public List<FName> DeathUpperF;
  public List<FName> DeathUpperB;
  public List<FName> DeathUpperL;
  public List<FName> DeathUpperR;
  public List<FName> DeathLowerF;
  public List<FName> DeathLowerB;
  public List<FName> DeathLowerL;
  public List<FName> DeathLowerR;
  public List<FName> DeathCrouchF;
  public List<FName> DeathCrouchB;
  public List<FName> DeathCrouchL;
  public List<FName> DeathCrouchR;
  public List<FName> DeathCrouchExplosiveF;
  public List<FName> DeathCrouchExplosiveB;
  public List<FName> DeathCrouchExplosiveL;
  public List<FName> DeathCrouchExplosiveR;
  public List<FName> DeathExplosiveF;
  public List<FName> DeathExplosiveB;
  public List<FName> DeathExplosiveL;
  public List<FName> DeathExplosiveR;
  public List<FName> DeathJumpF;
  public List<FName> DeathJumpB;
  public List<FName> DeathJumpL;
  public List<FName> DeathJumpR;
  public List<FName> TakeHitAnimF;
  public List<FName> TakeHitAnimB;
  public List<FName> TakeHitAnimL;
  public List<FName> TakeHitAnimR;
  public List<FName> TakeHitAnimFlashBang;
  public List<FName> TakeHitAnimGas;
  public List<FName> EmotionWinAnims;
  public List<FName> EmotionLoseAnims;
  public List<FName> DBNO_DeathHeadF;
  public List<FName> DBNO_DeathHeadB;
  public List<FName> DBNO_DeathHeadL;
  public List<FName> DBNO_DeathHeadR;
  public List<FName> DBNO_DeathUpperF;
  public List<FName> DBNO_DeathUpperB;
  public List<FName> DBNO_DeathUpperL;
  public List<FName> DBNO_DeathUpperR;
  public List<FName> DBNO_DeathLowerF;
  public List<FName> DBNO_DeathLowerB;
  public List<FName> DBNO_DeathLowerL;
  public List<FName> DBNO_DeathLowerR;
  public List<FName> DBNO_DeathCrouchF;
  public List<FName> DBNO_DeathCrouchB;
  public List<FName> DBNO_DeathCrouchL;
  public List<FName> DBNO_DeathCrouchR;
  public List<FName> DBNO_DeathCrouchExplosiveF;
  public List<FName> DBNO_DeathCrouchExplosiveB;
  public List<FName> DBNO_DeathCrouchExplosiveL;
  public List<FName> DBNO_DeathCrouchExplosiveR;
  public List<FName> DBNO_DeathExplosiveF;
  public List<FName> DBNO_DeathExplosiveB;
  public List<FName> DBNO_DeathExplosiveL;
  public List<FName> DBNO_DeathExplosiveR;
  public List<FName> DBNO_DeathJumpF;
  public List<FName> DBNO_DeathJumpB;
  public List<FName> DBNO_DeathJumpL;
  public List<FName> DBNO_DeathJumpR;
  public FName DefaultDeathAnimName;
}

public class ASFThirdPersonBlastingGame : ASFBlastingGame
{
}

public class USFThirdPersonCamera : UGameThirdPersonCamera
{
  public UGameThirdPersonCameraMode DeadPersonCamDefault;
  public UClass DeadPersonCamDefaultClass;
  public UGameThirdPersonCameraMode FelloutPersonCamDefault;
  public UClass FelloutPersonCamDefaultClass;
  public UGameThirdPersonCameraMode FlashBackCamDefault;
  public UClass FlashBackCamDefaultClass;
  public UGameThirdPersonCameraMode FelloutFirstPersonCamDefault;
  public UClass FelloutFirstPersonCamDefaultClass;
  public UGameThirdPersonCameraMode RespawnCamDefault;
  public UClass RespawnCamDefaultClass;
  public UGameThirdPersonCameraMode TurretCamDefault;
  public UClass TurretCamDefaultClass;
  public UGameThirdPersonCameraMode TurretTargetCamDefault;
  public UClass TurretTargetCamDefaultClass;
  public UGameThirdPersonCameraMode AlienCamDefault;
  public UClass AlienCamDefaultClass;
  public UGameThirdPersonCameraMode TopViewDeadPersonCamDefault;
  public UClass TopViewDeadPersonCamDefaultClass;
}

public class ASFThirdPersonEscapeGame : ASFEscapeGame
{
}

public class ASFThirdPersonSeizureGame : ASFSeizureGame
{
}

public class ASFThirdPersonTDMGame : ASFTeamDeathGame
{
}

public class USFThrowingKnifeEventData : USFSpecialKillEventData
{
}

public class ASFThunderRunGameReplicationInfo : ASFGameReplicationInfo
{
  public ASFPawn NearestPawn;
  public int NearestPawnOutlineIndex;
}

public class ASFThunderRunHUD : ASFTeamHUD
{
  public string[] WaitingForNextMission = new string[2];
  public List<string> LocalizedAreaInfo;
  public string LocalizedGoal;
  public string LocalizedArea;
  public ASFThunderRunGameReplicationInfo SFThGRI;
  public float fDistanceToGoal;
}

public class USFThunderrunKillDeathMessage : USFKillDeathMessage
{
}

public class ASFThunderRunPlayerController : ASFPlayerController
{
}

public class ASFThunderRunPlayerReplicationInfo : ASFPlayerReplicationInfo
{
}

public class USFThunderRunScore : USFGameScore
{
  public float SCORE_TouchDown;
  public float SCORE_TouchDownTeam;
}

public class ASFThunderRunState : AReplicationInfo
{
  public class FPawnLocation
  {
    public UObject.FVector Location;
    public UObject.FVector RelativeLocation;
    public int PlayerID;
  }

  public float AllowableDiffSecondsFromHost;
  public float UpdateTimeForPassedArea;
  public float AreaChangedTimeSeconds;
  public int currAreaIndex;
  public int SavedCurrAreaIndex;
  public List<FPawnLocation> arrPawnLocation;
}

public class ASFThunderRunTeamInfo : ASFTeamInfo
{
  public int[] AreaLapTime = new int[3];
  public ESFStrongHoldArea PassedArea;
}

public class ASFThunderRunVolume : ASFModeVolume
{
  public ESFStrongHoldArea AreaIndex;
}

public class USFTomahawkEventData : USFSpecialKillEventData
{
}

public class USFTopViewDeadPersonCameraMode : USFThirdPersonCameraModeBase
{
  public FVector InitLocation;
  public float DOF_Distance;
  public float ActiveTime;
  public float DOFDistance;
  public float DOFFocusInnerRadius;
  public float DOFMaxFarBlurAmount;
  public float DOFMaxNearBlurAmount;
}

public class USFTotalDeadTime : USFBaseEventData
{
}

public class USFTotalHitCountEventData : USFWeaponEventData
{
}

public class USFTournamentResultWriterBase : USFGameplayEventsWriter
{
  public string ResultDirectory;
  public string SavedString;
}

public class USFTournamentResultWriter : USFTournamentResultWriterBase
{
  public List<string> PlayerKillDeathLog;
  public List<string> PlayerStringLog;
}

public class USFTPCM_Libertine : USFThirdPersonCameraModeBase
{
  public FVector EvadePawnRelativeOffset;
  public float WorstLocAimingZOffset;
  public bool bTemporaryOriginRotInterp;
  public float TemporaryOriginRotInterpSpeed;
}

public class ASFTrafficCheckVolume : AVolume
{
  public float TrafficMax;
  public float CollisionBase;
  public float TrafficNow;
}

public class ASFTrainingGame : ASFTeamGameInfo
{
  public ASFTrainingGameReplicationInfo SFTrainingGRI;
  public List<ASFAISpawnManager.FDummyMemory> RespawnDummyArray;
  public float RespawnDuration;
  public int DummyCountMax;
  public string DummyName;
}

public class ASFTrainingGameReplicationInfo : ASFGameReplicationInfo
{
  public class FSubLevelInfo
  {
    public string MapName;
    public byte SubLevelMode;
  }

  public List<FSubLevelInfo> SubLevelModes;
  public List<byte> DefaultSubLevelModes;
  public string ProjectileTrailName;
  public int PerformGCPeriod;
  public float LastPerformGCTime;
  public ASFEmitterNoSyncSpawnable ProjectileEmitter;
  public int CurrentDummyCount;
  public bool bShowProjectileTrail;
  public bool bFollowProjectile;
}

public class USFTrainingGameScore : USFGameScore
{
}

public class ASFTrainingHUD : ASFTeamHUD
{
  public FScriptDelegate __OnTargetSpawned__Delegate;
  public FScriptDelegate __OnToggleTimer__Delegate;
  public FScriptDelegate __OnClearTimer__Delegate;
}

public class ASFTrainingPlayerController : ASFPlayerController
{
  public ASFProjectile FiredProjectile;
  public FRotator SavedRotation;
}

public class ASFTrigger_Use : ATrigger
{
  public class FCheckpointRecordEx
  {
    public FName currState;
    public bool bCanUse;
    public bool bBlockUse;
  }

  public class FAimValueToInteractive
  {
    public float Degree;
    public float Dist;
  }

  public class FUserInfo
  {
    public APawn User;
    public float UsingTime;
    public float StartTime;
  }

  public bool bAimToInteract;
  public bool bAlwaysReplicateMovement;
  public bool DrawOutLine;
  public bool bDrawIconGauge;
  public bool bBlockWhenComplete;
  public bool bTraceObstacleObject;
  public bool bTraceUsingMesh;
  public bool bCanUse;
  public bool bBlockUse;
  public bool bUseVolumeLocationForIcon;
  public bool bMaintainUsingTime;
  public bool bCanUseInTrainingGame;
  public List<FAimValueToInteractive> AimValues;
  public UStaticMeshComponent MeshComponent;
  public FVector MeshOffset;
  public FName currState;
  public ETeam ValidTeamIndex;
  public ETeam ValidTeamIndexForReactive;
  public EObjectIconTypes IconTypeRedTeam;
  public EObjectIconTypes IconTypeBlueTeam;
  public EMissionItemType MissionItemType;
  public ETriggerType TriggerType;
  public float GaugeTime;
  public float GaugeTimeForReactive;
  public float ReTriggerDelay;
  public float LastActivationTime;
  public string[] InstanceUseMessage = new string[9];
  public string[] GaugeUseMessage = new string[9];
  public List<USFTypes.FStateIconType> StateIconTypes;
  public FVector IconLocationOffset;
  public List<USFTypes.FNextStateInfo> arrNextStateInfo;
  public AActor UsingActor;
  public int MaxUserCount;
  public FName InitialStateForEditor;
  public List<FUserInfo> UserList;
  public List<APawn> TouchingPawns;
  public List<ASFModeVolume> ModeVolumes;
  public USpriteComponent IconLocationForEditor;
  public float LastUsingTime;
  public AController LastUser;
  public FName ModeVolumeState;
}

public class ASFTrigger_PvE : ASFTrigger_Use
{
  public int Price;
}

public class ASFTrigger_Airdrop : ASFTrigger_PvE
{
}

public class ASFTrigger_ReplaceMesh : ASFTrigger_Use
{
  public UStaticMesh SwitchFirstMesh;
  public UStaticMesh SwitchSecondMesh;
  public UMaterialInterface Material_First;
  public UMaterialInterface Material_Second;
  public USFFlickerLightByPeriod FlickerLight;
  public FColor FlickerLightFirstColor;
  public FColor FlickerLightSecondColor;
  public FVector FlickerLightOffset;
  public bool bUseFlickerLight;
  public UDynamicLightEnvironmentComponent LightEnvironment;
  public UDrawSphereComponent FlickerLightSphere;
}

public class ASFTrigger_Bomb : ASFTrigger_ReplaceMesh
{
  public class FLEDInfo
  {
    public float RemainTime;
    public float CycleTime;
    public UObject.FLinearColor UVOffset;
  }

  public USFGameExplosion ExplosionInfo;
  public int MITV_Index;
  public float MITV_StartTimeOffset;
  public List<FLEDInfo> arrLEDInfo;
  public int nCurrentLEDInfoIndex;
  public UMaterialInstanceTimeVarying MITV_LED;
  public int InstallerUID;
  public int PassedTimeForInstall;
  public float WaitingTime;
  public AStaticMeshActorForBlastingGame InstallTargetActor;
  public AWeapon InstigateWeapon;
}

public class ASFTrigger_Capture : ASFTrigger_ReplaceMesh
{
}

public class ASFTrigger_ConvoyanceItem : ASFTrigger_Use
{
  public int nPlayerID;
  public byte nTryAttachToPawn;
  public ADynamicSMActor MeshActor;
  public AActor ItemActor;
  public int MoneyAmount;
  public bool IsCompleteAttach;
  public AController ReturnController;
  public float CheckRadius;
}

public class ASFTrigger_ConvoyanceSeizure : ASFTrigger_Use
{
  public class FItemSeizureInfoStruct
  {
    public float Second;
    public int ItemAmount;
  }

  public List<FItemSeizureInfoStruct> ItemSeizureInfo;
}

public class ASFTrigger_ConvoyanceStoreHouse : ASFTrigger_Use
{
}

public class ASFTrigger_Elevator : ASFTrigger_Use
{
  public FLinearColor UpButtonColor;
  public FName UpButtonParamName;
  public FLinearColor DownButtonColor;
  public FName DownButtonParamName;
  public ASFElevatorActor ElevatorActor;
  public UMaterialInstanceConstant MIC;
  public FName AllowElevatorState;
  public FScriptDelegate __OnInterpolationFinished__Delegate;
}

public class ASFTrigger_Escape : ASFTrigger_ReplaceMesh
{
  public float TimeOfArrival;
  public float WaitingTime;
  public float ReturnTime;
  public float HelicopterPassedTime;
  public float HelicopterTimerPeriod;
  public AActor HelicopterActor;
  public string HelicopterWaitingMessage;
  public string HelicopterComeBackMessage;
}

public class ASFTrigger_PlasticBomb : ASFTrigger_ReplaceMesh
{
  public ASFBreakableActor BaseBreakableActor;
  public FVector DamageDir;
  public UArrowComponent DamageDirArrow;
  public AController Installer;
  public USkeletalMeshComponent SkelMeshComp;
  public UParticleSystem InstallParticle;
  public UMaterialInstanceConstant LED_MIC;
  public int LED_MIC_Offset;
}

public class ASFTrigger_PvENextWave : ASFTrigger_PvE
{
}

public class ASFTrigger_PvEShop : ASFTrigger_PvE
{
  public byte OutLineIndex;
  public int ShopGroupIndex;
}

public class ASFTrigger_PvEWaveInfo : ASFTrigger_Use
{
  public float MaxAliveRatio;
  public float EndOfRoundDelay;
  public float MultiplyValueForAliveRatio;
}

public class ASFTrigger_ReplaceMeshMovable : ASFTrigger_ReplaceMesh
{
}

public class ASFTrigger_Seizure : ASFTrigger_ReplaceMesh
{
  public FName GameObjBone3P;
  public int nPlayerID;
  public FVector InitialLocation;
  public FRotator InitialRotation;
  public byte nTryAttachToPawn;
  public ADynamicSMActor MeshActor;
}

public class ASFTrigger_ShooterInteract : ASFTrigger_PvE
{
}

public class ASFTrigger_ShooterTurret : ASFTrigger_PvE
{
  public ASFTurret_AutoBase Turret;
}

public class ASFTrigger_StrongHold : ASFTrigger_ReplaceMesh
{
  public ESFStrongHoldArea EnableAreaIndex;
}

public class ASFTrigger_UseByWeaponGroup : ASFTrigger_ReplaceMesh
{
  public class FSGaugeTimeByWeaponTypeInfo
  {
    public EWEAPON_GROUP WeaponGroup;
    public float GaugeTime;
  }

  public List<FSGaugeTimeByWeaponTypeInfo> GaugeTimeInfoArray;
  public bool bUseUpdateMesh;
  public bool bCheckCompleteScore;
  public bool bUsingActor;
}

public class ASFTurret : AVehicle
{
  public class FsPointOfView
  {
    public UObject.FVector DirOffset;
    public float Distance;
    public float fZAdjust;
  }

  public class FCheckpointRecord
  {
    public bool bHidden;
  }

  public AController Claim;
  public List<UClass> DefaultInventory;
  public FRotator AimDir;
  public FRotator DesiredAimDir;
  public FVector2D YawLimit;
  public float TurretTurnRateScale;
  public float AimingTurretTurnRateScale;
  public FVector CannonFireOffset;
  public FName PitchBone;
  public FName BaseBone;
  public FVector EntryPosition;
  public bool bRelativeExitPos;
  public bool bUnableToLeave;
  public bool bSpottedSomething;
  public bool bDebugTurret;
  public bool bAllowTargetingCamera;
  public bool bRotationalMomentum;
  public bool bEnforceHardAttach;
  public bool bMovingToEnforceHardAttach;
  public bool bUseLimitRot;
  public bool bNotTarget;
  public bool bNeedResetIdleDesiredAimDir;
  public FsPointOfView POV;
  public AWeapon myWeapon;
  public FName LeftHandBoneHandleName;
  public FName RightHandBoneHandleName;
  public FName LeftHandleSocketName;
  public FName RightHandleSocketName;
  public float InitialEntryZOffset;
  public APawn ReservedDriver;
  public AWeapon LastWeapon;
  public FVector CameraViewOffsetHigh;
  public FVector CameraViewOffsetMid;
  public FVector CameraViewOffsetLow;
  public FVector CameraTargetingViewOffsetHigh;
  public FVector CameraTargetingViewOffsetMid;
  public FVector CameraTargetingViewOffsetLow;
  public float CameraFOV;
  public float CameraTargetingFOV;
  public FName WorstCamLocSocketName;
  public FVector ViewRotVel;
  public float ViewRotInterpSpeed;
  public FMatrix LastBaseTM;
  public UDynamicLightEnvironmentComponent MyLightEnvironment;
  public float CameraScale;
  public float CurrentCameraScale;
  public FName currState;
  public USFGameExplosion DestroyEffectInfo;
  public float ExtendDamageDepictionColor;
  public List<UMaterialInstanceConstant> DamagedMICs;
  public List<ASFPawn.FBonePartsTable> BoneNameToBodyParts;
  public FVector IconLocationOffset;
  public byte LastTakeHitInfo_Mask;
  public AActor LastTakeHitInfo_DamagedBy;
  public UClass LastTakeHitInfo_DamageType;
}

public class ASFTurret_MiniGunBase : ASFTurret
{
  public class FMuzzle
  {
    public FName MuzzleSocketName;
    public FName ShellOutSocket;
    public USFParticleSystemComponent MuzzleFlashPSC;
    public USFParticleSystemComponent ShellOutPSC;
    public USFExplosionLight MuzzleFlashLight;
  }

  public float TraceSpeed;
  public float SearchSpeed;
  public float TooCloseDist;
  public FRotator TurretControlRot;
  public FVector SpottedLoc;
  public FVector DesiredSpottedLoc;
  public USkelControlLookAt Pivot_Latitude;
  public USkelControlLookAt Pivot_Longitude;
  public FName Pivot_Latitude_BoneName;
  public FName PlayerRefSocketName;
  public List<FMuzzle> Muzzles;
  public UAnimNodeSequence FireSeqNode;
  public float EntryRadius;
  public UParticleSystem IFFEnemy;
  public UParticleSystemComponent IFFPSC;
  public FName IFFBone;
  public AActor FocusEnemy;
  public float fFocusStartTime;
  public float fFireSimulating;
  public float RandomRotdir;
  public USkeletalMesh DestroyedMesh;
}

public class ASFTurret_AutoBase : ASFTurret_MiniGunBase
{
  public bool bOverrideReactionTimes;
  public bool bUseAimDir;
  public bool bUseAmmoLimit;
  public bool bUseHealthLimit;
  public bool bDestroyWhenUseless;
  public bool bUseRandomIdleDir;
  public bool bStopWhenInactive;
  public bool bPlayingCueRot;
  public bool bReserveCueRot;
  public bool bPlayingCueRotNew;
  public float PeriodSearchEnemy;
  public float ReactionDelay;
  public float fWaitingDelay;
  public float fUseTimeLimit;
  public float fDetectRange;
  public float fNearRange;
  public float fAdjustDamage;
  public float fAdjustFiringInterval;
  public float fAdjustSpread;
  public ETeam StartupTeam;
  public USoundCue cueRotate;
  public USoundCue cueStop;
  public UAudioComponent AudioComponent;
  public UClass DriverClass;
  public APawn AutoDriver;
  public AController ActivateController;
}

public class USFTurretCameraMode : USFThirdPersonCameraModeBase
{
}

public class USFTurretTargetingCameraMode : USFThirdPersonCameraModeBase
{
}

public class USFTutorialGameScore : USFGameScore
{
  public float score_timeBasis;
  public float score_bonusScorePerSec;
}

public class ASFTutorialHUD : ASFHUD
{
  public int Pending_Score;
  public FVector Pending_TargetPosition;
}

public class ASFTutorialPlayerController : ASFPlayerController
{
  public class FTutRankTable
  {
    public int RequireScore;
    public int Rank;
    public int Exp;
    public string RankString;
    public int RankCount;
  }

  public List<FTutRankTable> RankTable;
  public float PerSecondMulValue;
}

public class ASFTutorialPlayerReplicationInfo : ASFPlayerReplicationInfo
{
  public int HitCounter_EnemyTarget;
  public int HitCounter_GuardianTarget;
  public int Score_EnemyTarget;
  public int PrevScore_EnemyTarget;
  public int Score_GuardianTarget;
  public int PrevScore_GuardianTarget;
  public FVector TargetHitLocation;
  public int TutorialResultRank;
  public int Score_RemainingTime;
  public int EarnExp;
  public string RankString;
  public int RankCount;
}

public class USFUIResourceDataProvider : UUIResourceDataProvider
{
  public string IniName;
}

public class USFUIDataProvider_ModeInfo : USFUIResourceDataProvider
{
  public class FSupportMapInfo
  {
    public string MapName;
    public int Order;
    public bool bRookieAllow;
    public bool bVIPOnly;
  }

  public class FDefaultRoundDataByChannel
  {
    public int channelType;
    public int DefaultRoundByChannel;
  }

  public string GameModeName;
  public int GameModeID;
  public EGameMode GameModeType;
  public ELobbyScreen WaitingRoomType;
  public EMatchType GameEndType;
  public string GameModeClass;
  public float RoundTime;
  public List<float> RoundTimeList;
  public List<int> MatchPoint;
  public int DefaultMatchPoint;
  public int DefaultRound;
  public List<int> WinRound;
  public int DefaultPlayer;
  public List<int> PlayerCount;
  public bool IsCheckMinPlayer;
  public bool CompulsionNotChangeTeamSlot;
  public bool LockUI_SwitchSide;
  public bool EnableSwitchSide;
  public bool LockUI_Intrusion;
  public bool EnableIntrusion;
  public bool LockUI_KillCam;
  public bool EnableKillCam;
  public bool LockUI_ThirdPerson;
  public bool EnableThirdPerson;
  public bool LockUI_TeamBalance;
  public bool EnableTeamBalance;
  public bool LockUI_TeamSwitch;
  public bool EnableTeamSwitch;
  public bool LockUI_LastStand;
  public bool EnableLastStand;
  public bool LockUI_PickUpWeapon;
  public bool DisablePickUpWeapon;
  public bool TwoSideTeam;
  public bool PlayerCountNoBalance;
  public bool EnableSpector;
  public bool IsPvEGame;
  public bool EnableMode;
  public bool bRemoveGachaCapsuleResultBoard;
  public bool IsMapRotationMode;
  public List<FSupportMapInfo> SupportMaps;
  public List<ECUSTOMMODE_WEAPONTYPE> SupportCustomMode;
  public List<string> SupportModeNames;
  public string DisplayType;
  public string RookieDisplayType;
  public string VIPDisplayType;
  public int RoomFrontNameIndex;
  public int RedPlayerMaxCount;
  public int BluePlayerMaxCount;
  public List<FDefaultRoundDataByChannel> ChannelDefaultRoundArray;
  public FScriptDelegate __SupportMapSort__Delegate;
}

public class USFUIDataProvider_BeginnerModeInfo : USFUIDataProvider_ModeInfo
{
}

public class USFUIDataProvider_InGameStore : UUIResourceDataProvider
{
  public List<USFTypes.FInGameStoreItem> TotalInGameStoreItemList;
  public string ShopTitleMsg;
}

public class USFUIDataProvider_MapInfo : USFUIResourceDataProvider
{
  public string MapName;
  public int MapID;
  public float AdditionalRadarMapScale;
  public string RoomBackGroundImage;
  public float SpawnProtectionTime;
}

public class USFUIDataProvider_TrainingModeInfo : USFUIDataProvider_ModeInfo
{
}

public class USFUIDataProvider_TutorialModeInfo : USFUIDataProvider_ModeInfo
{
}

public class USFUIDataStore : UUIDataStore_Remote
{
}

public class USFUIDataStore_BPEvent : USFUIDataStoreBase
{
  public List<USFTypes.FSRealTimeEvent> RealTimeEventArray;
  public USFTypes.FSFeverTimeEvent FeverTimeEvent;
  public int RecvPromoEventCount;
  public int RecvMyPromoEventCount;
  public List<USFTypes.FSPromotionEvent> PromotionEventArray;
  public List<USFTypes.FSPromotionEvent> MyPromotionEventArray;
  public List<USFTypes.FSPromotionEvent> PrevMyPromotionEventArray;
  public int CurBPassScore;
  public int GoalBPScore;
}

public class USFUIDataStore_ChannelList : USFUIDataStoreBase
{
  public int SeparationCounter;
  public string LocChannelNameMessage;
  public string LocChannelNumberMessage;
  public string LocRoomNumberMessage;
  public string LocRoomNumNameMessage;
  public string ConnectToVipToolTip;
  public string CannotConnectToVipToolTip;
  public string ConnectToNormalToolTip;
  public List<USFTypes.FSChannelSetting> ChannelSettingsArray;
  public List<USFTypes.FSChannelSetting> FilteredChannelSettingsArray;
  public int RecvChannelListCount;
  public int CurChannelListCount;
  public int SelectedGroupIndex;
  public int SelectedChannelIndex;
  public USFTypes.FSChannelSetting JoinedChannel;
  public int ChannelListRefreshCount;
  public bool bRequestQuickJoin;
  public bool bEnableRookiePopUp;
  public bool IsVipToolTipVisible;
  public List<USFTypes.FSQuickJoin> QuickJoinConditionArray;
  public int QuickJoinCurTryCount;
  public int QuickJoinMaxTryCount;
  public List<USFTypes.FSQuickJoin> PrevQuickJoinConditionArray;
  public int QuickJoinMaxPlayerRatio;
  public List<USFTypes.FSChannelSetting> QuickJoinChannelArray;
  public List<USFTypes.FSChannelSetting> QuickJoinFailedChannelArray;
  public List<USFTypes.FSChannelSetting> QuickJoinPrevChannelArray;
  public int nRookiePopUpShowCount;
  public FScriptDelegate __ChannelSortByChannelNumberDelegate__Delegate;
  public FScriptDelegate __ChannelSortByTypeDelegate__Delegate;
}

public class USFUIDataStore_Chatting : USFUIDataStoreBase
{
  public class FsChatCommand
  {
    public string cmdstr;
    public EChatCmds Cmd;
  }

  public class FSBlockWhisperUserInfo
  {
    public int USN;
    public int UserState;
  }

  public List<USFTypes.FSChatMsgInfo> ChattingMessageList;
  public USFTypes.FSChatMsgInfo SendPendingChatMsg;
  public EChatSendType ChatSendType;
  public byte[] CencoredChat = new byte[16];
  public int MaxChattingLength;
  public int MassiveChatCheckTime;
  public int MassiveChatCount;
  public int MassiveChatPenaltyTime;
  public int MassiveChatSameTextCount;
  public int ChatRestrictRank;
  public int MassiveChatPenaltyStartTime;
  public List<float> MassiveChatTimeArray;
  public List<string> MassiveChatMsgArray;
  public string MassiveChatPenaltyMessage;
  public string strChattingFrom;
  public string strChattingto;
  public string NotChannelConnect;
  public string NoticeGaChaPercentage;
  public string RTEAllEXPStartMessage;
  public string RTEAllEXPFinishMessage;
  public string RTEAllSPStartMessage;
  public string RTEAllSPFinishMessage;
  public string FeverTimeEventStartMessage;
  public string FeverTimeEventEndMessage;
  public string FeverTimeAddEXPMessage;
  public string FeverTimeAddSPMessage;
  public string FeverTimeAddLPMessage;
  public string FeverTimeAddBenefitMessage;
  public string RTEGameModeEXPStartMessage;
  public string RTEGameModeEXPFinishMessage;
  public string RTEGameModeSPStartMessage;
  public string RTEGameModeSPFinishMessage;
  public string RTEMapEXPStartMessage;
  public string RTEMapEXPFinishMessage;
  public string RTEMapSPStartMessage;
  public string RTEMapSPFinishMessage;
  public List<string> LastTalkMeUserCodeName;
  public List<string> LastTalkMeUserCodeNameInverse;
  public List<string> LastChatUserCodeName;
  public List<string> WhisperErrors;
  public int RemindTalkUserNum;
  public int RemindTalkUserPos;
  public List<FsChatCommand> ChatCommands;
  public List<FsChatCommand> LocalizedChatCmds;
  public List<string> ChattingHelpMessage;
  public string InviteClanHomeMessage;
  public string InviteClanHomeMessageToMe;
  public string InviteClanHomeToInGame;
  public string InviteClanHomeAlready;
  public List<int> InviteClanUserArray;
  public string strCaptureStartMsg;
  public string strCaptureFinishMsg;
  public string strCapturingMsg;
  public List<string> strGetRareRewardItemMsgArray;
  public List<string> strGetRareRewardSPMsgArray;
  public List<string> strGetCombineRareRewardArray;
  public string strSP;
  public string strTP;
  public string strLP;
  public string strBombSP;
  public List<string> BlockUserNameArray;
  public List<string> ChatBloakMessage;
  public List<FSBlockWhisperUserInfo> BlockWhisperUserArray;
  public int BlockWhisperState;
  public bool bUseBlockWhisper;
  public bool IsWhisperListPopup;
  public List<EChatSendType> SendBlockChatTypeList;
}

public class USFUIDataStore_ClanLeague : USFUIDataStore_ClanBase
{
  public class FSClanLeagueRankInfo
  {
    public string SeasonDate;
    public string Ranking;
    public string Ranking_Old;
    public string CSN;
    public string USN;
    public string CodeName;
    public string Rank;
    public string ClanMark;
    public string ClanName;
    public string ClanGrade;
    public string GamePlayCount;
    public string GameWinCount;
    public string GameLoseCount;
    public string KillCount;
    public string AssistCount;
    public string DeathCount;
    public string Score;
    public string Regdate;
  }

  public List<FSClanLeagueRankInfo> MyClanRankData;
  public List<FSClanLeagueRankInfo> MyClanMemberRankData;
  public List<FSClanLeagueRankInfo> SeasonClanRankData;
  public List<FSClanLeagueRankInfo> SeasonPersonalRankData;
  public List<int> SeasonDateArray;
}

public class USFUIDataStore_ClanRank : USFUIDataStoreBase
{
  public class FSWeeklyClanRankInfo
  {
    public int CSN;
    public string OrigClanMark;
    public string ClanMark;
    public string ClanName;
    public int ClanPoint;
  }

  public int WeeklyClanRankPeriod;
  public List<FSWeeklyClanRankInfo> ThisWeekClanRankClanInfo;
  public List<FSWeeklyClanRankInfo> LastWeekClanRankClanInfo;
  public string LocalYear;
  public string LocalMonth;
  public int WeeklyClanRankInfoCount;
  public int WeeklyRankStatType;
  public string ThisWeekStartDate;
  public string ThisWeekEndDate;
  public string LastWeekStartDate;
  public string LastWeekEndDate;
  public int RankUpdateTimeLimit;
  public int RankCount;
  public int MyClanRank;
  public int MyClanPoint;
  public int RankType;
  public int UpdateTimeDelay;
  public int ThisWeekRankCurrentTime;
  public int LastWeekCurrentTime;
  public bool bRequestWeeklyClanRank;
}

public class USFUIDataStore_CombatReport : USFUIDataStoreBase
{
  public class FsSumDamage
  {
    public int Id;
    public int Damage;
  }

  public List<USFTypes.FsCombatReport> CombatReports;
  public int LastSummaryIdx;
  public List<FsSumDamage> SumDamages;
}

public class USFUIDataStore_Community : USFUIDataStoreBase
{
  public USFTypes.FSCommunityEvent CommunityEvent;
  public List<USFTypes.FSCommunityMessage> CommunityMessageArray;
  public List<USFTypes.FSCommunityBuddy> CommunityBuddyArray;
  public float fPrevNotReadReqTime;
  public int MessageBuddyReqDelayTime;
  public int NotReadReqDelayTime;
  public int NotYetReadCount;
  public int FeedbackReqIndex;
  public float fPrevReqMessageTime;
  public float fPrevReqBuddyTime;
}

public class USFUIDataStore_Enchant : USFUIDataStoreBase
{
  public class FDetailItem
  {
    public int ItemId;
    public ulong UnusedItemSN;
    public ulong UsedItemSN;
  }

  public class FItemExtractInfo
  {
    public USFUIDataStore_Enchant.FDetailItem ItemInfo;
    public USFUIDataStore_Enchant.FEnchantParts PartsInfo;
  }

  public class FEnchantParts
  {
    public List<int> Parts;
  }

  public class FEnchantDesignInfo
  {
    public int EnchantDesignID;
    public string GroupName;
    public string EnchantDesignName;
    public int ResultItemID;
    public int BaseItemCount;
    public List<int> RequirePartsCount;
    public int GroupIndex;
    public List<int> BaseItemIDList;
  }

  public List<FEnchantDesignInfo> EnchantDesignList;
  public int EnchantDesignCount;
  public bool bWaitPacketBaseItem;
  public bool bWaitDestroyItemPacket;
  public int ServerGetBaseItemCount;
  public int CurrentWaitEnchantDesignIndex;
  public int UISelectedEnchantDesignIdx;
  public List<int> AllBaseItemIDList;
  public List<UClass> ExtractableItemClassList;
  public List<FItemExtractInfo> ExtractResultList;
  public FEnchantParts MaxEnchantParts;
  public FEnchantParts CurrentEnchantParts;
  public int PartsTypeCount;
  public List<UClass> WeapEnchantDesignClassList;
}

public class USFUIDataStore_GameResult : USFUIDataStoreBase
{
  public class FSUserResult
  {
    public int USN;
    public string CodeName;
    public string GfxRank;
    public string ClanMark;
    public USFTypes.FSCodeNameColor CodeNameColor;
    public int Kill;
    public int Death;
    public int Assist;
    public int AllScore;
    public int AllExp;
    public int Score;
    public int MissionScore;
    public int LuckyPointScore;
    public int BonusScore;
    public int PCRoomCareType;
    public int PCRoomCareExpValue;
    public int PCRoomCareSPValue;
    public int VipCareType;
    public int VipRoomCareExpValue;
    public int VipRoomCareSpValue;
    public int RTEEXPValue;
    public int RTESPValue;
    public int FuncItemEXPValue;
    public int FuncItemSPValue;
    public int FuncItemSPImmediatelyValue;
    public int FuncItemTPValue;
    public int FuncItemLPValue;
    public int ChannelEXPValue;
    public int ChannelSPValue;
    public int PMCItemID;
    public int PMCItemEXPValue;
    public int PMCItemSPValue;
    public float LuckyPointRatio;
    public float AntiFatigueRatio;
    public int SpecialKillBonus;
    public int ContinuousKillBonus;
    public int RareKillBonus;
    public int NormalKillBonus;
    public int DefaultKillBonus;
    public int SpecialKillBonusScore;
    public int ContinuousKillBonusScore;
    public int RareKillBonusScore;
    public int NormalKillBonusScore;
    public int DefaultKillBonusScore;
    public int TotalKillFeedbackScore;
    public float ExpRatio;
    public bool bIsMyBuddy;
    public List<string> FunctionalItemList;
    public string LeagueNumber;
    public byte VipGrade;
    public string ClanMarkEffect;
    public int ClanBuffState;
    public List<USFTypes.FAdditionalModeResult> AdditionalResultArray;
    public byte MonthlyRewardGrade;
    public int FeverEXPValue;
    public int FeverSPValue;
    public int FeverLPValue;
  }

  public class FSModeNotice
  {
    public string GameModeName;
    public List<string> NoticeArray;
  }

  public List<FSUserResult> RedUserResultArray;
  public List<FSUserResult> BlueUserResultArray;
  public ETeam WinningTeamIndex;
  public ETeam MyTeamIndex;
  public EMatchEndType MatchEndType;
  public int RedTeamScore;
  public int BlueTeamScore;
  public int GoalScore;
  public int RemainingTime;
  public bool bOnlySpectator;
  public bool bTeamChanged;
  public bool ShowMatchAnimation;
  public bool bShowResultDialog;
  public bool bReservedSendUpdateTaskList;
  public int MyBeforeMaxSPGage;
  public UClass GameScoreClass;
  public int GameModeID;
  public int MapID;
  public string MapLocalizedName;
  public string GameModeLocalizedName;
  public string RedClanName;
  public string BlueClanName;
  public string RedClanMark;
  public string BlueClanMark;
  public int RedClanCSN;
  public int BlueClanCSN;
  public string AppraisalMessage;
  public int KillFeedBackStartIndex;
  public int KillFeedBackCounter;
  public List<int> KillFeedBackList;
  public List<string> KillFeedBackDefault;
  public List<string> KillFeedBackNormal;
  public List<string> KillFeedBackSpecial;
  public List<string> KillFeedBackRare;
  public List<string> KillFeedBackContinuous;
  public List<USFChallengeListCondition.FChallengeProgressData> InvalidateChallengeList;
  public string FirstScoreMessage;
  public string FirstKillMessage;
  public string FirstAssistMessage;
  public string FirstLuckyPointMessage;
  public string strMyVIPMessage;
  public string strMasterVIPMessage;
  public string strMyMonthlyRewardMessage;
  public string strFeverTimeResultMessage;
  public string PCRoomBenefitMessage;
  public string RTEBenefitMessage;
  public string EXPFuncItemBenefitMessage;
  public string SPFuncItemBenefitMessage;
  public string TPFuncItemBenefitMessage;
  public string PMCBenefitMessage;
  public string ChannelBenefitMessage;
  public string VIPBenefitMessage;
  public string MonthlyRewardBenefitMessage;
  public string SPImmediatelyFuncItemBenefitMessage;
  public string ClanCooperationBuffBenefitMessage;
  public string ClanConnectBuffBenefitMessage;
  public string strMySPImmediatelyMessage;
  public string FeverTimeBenefitMessage;
  public int ClearedSurvivalWave;
  public float CustomModeExpRatio;
  public float CustomModeSpRatio;
  public List<FSModeNotice> ModeNoticeArray;
}

public class USFUIDataStore_InGame : USFUIDataStoreBase
{
  public bool bUsingPickupWeapon;
  public bool bPickupWeaponUsePenalty;
  public bool bMapLoaded;
  public int PickupWeaponID;
  public int[] PickupWeaponItemIDTable = new int[16];
  public int WeaponSetIndexInGame;
  public int NextWeaponSetIndexInGame;
  public string NewHostPlayerName;
  public string OldHostPlayerName;
}

public class USFUIDataStore_InGameScore : USFUIDataStoreBase
{
  public class FHitPawnInfo
  {
    public int PlayerID;
    public FName HitPawnName;
  }

  public USFGameDatabase.FSFPlayerLog PlayerLog;
  public List<FHitPawnInfo> HitPawnListForPlayerLog;
  public List<FHitPawnInfo> HitPawnListForWeaponLog;
}

public class USFUIDataStore_InvenChar : USFUIDataStoreBase
{
  public class FSCharUnit
  {
    public int UnitItemID;
    public USFGameItem.FSFItemData UnitItemData;
    public List<ulong> ItemSNArray;
  }

  public List<FSCharUnit> InvenCharUnitArray;
  public List<int> CharacterMCItemArray;
  public int RecvUnitCount;
  public int CurUnitCount;
  public int DefaultJetPackID;
  public float LuckyPointProbability;
  public List<int> NeedServerUpdateUnitArray;
}

public class USFUIDataStore_InvenWeap : USFUIDataStoreBase
{
  public class FSInvenWeaponSet
  {
    public int ArmorySN;
    public int SetIndex;
    public string SetName;
    public ulong MainItemSN;
    public USFGameItem.FSFItemData MainItemData;
    public ulong SubItemSN;
    public USFGameItem.FSFItemData SubItemData;
    public List<ulong> ThrowItemSNArray;
    public List<USFGameItem.FSFItemData> ThrowItemDataArray;
    public ulong SpecialItemSN;
    public USFGameItem.FSFItemData SpecialItemData;
  }

  public class FsMuzzleColorUpgrade
  {
    public string StyleID;
    public string ColorID;
    public UObject.FVector MuzzleColor_01;
    public UObject.FVector MuzzleColor_02;
    public UObject.FVector MuzzleColor_03;
  }

  public class FsMuzzleStyleUpgrade
  {
    public string StyleID;
    public UParticleSystem MuzzleStyle;
    public UParticleSystem MuzzleStyleZoom;
    public UParticleSystem MuzzleStyle3rd;
  }

  public class FsMuzzleInfo
  {
    public List<USFUIDataStore_InvenWeap.FsMuzzleStyleUpgrade> StyleNameList;
    public List<string> ColorNameList;
    public List<USFUIDataStore_InvenWeap.FsMuzzleColorUpgrade> DetailColorList;
  }

  public class FsWeaponEffectStyleUpgrade
  {
    public string StyleID;
    public UParticleSystem WeaponEffectStyle1st;
    public UParticleSystem WeaponEffectStyle3rd;
  }

  public class FsWeaponEffectInfo
  {
    public List<USFUIDataStore_InvenWeap.FsWeaponEffectStyleUpgrade> StyleNameList;
  }

  public class FSWeaponMCData
  {
    public int SetIndex;
    public List<int> ItemArray;
  }

  public List<FsWeaponEffectStyleUpgrade> WeaponEffectUpgrade;
  public FsWeaponEffectInfo WeaponEffectInfo;
  public List<FsMuzzleColorUpgrade> MuzzleColorUpgrade;
  public List<FsMuzzleStyleUpgrade> MuzzleStyleUpgrade;
  public List<string> MuzzleColorNameList;
  public int temp1;
  public int temp2;
  public FsMuzzleInfo MuzzleInfo;
  public int RecvWeaponSetCount;
  public int CurWeaponSetCount;
  public List<FSInvenWeaponSet> InvenWeaponSetArray;
  public List<USFGameItem.FSRecvPartsItemInfo> PartsItemArray;
  public int PartsItemCount;
  public List<FSWeaponMCData> WeaponMCDataArray;
  public List<int> WeaponMCItemArray;
  public int reserveCheckArmoryIdx;
  public bool bNeedServerUpdateMainWPSet;
  public List<int> NeedServerUpdateWPSetArray;
  public int PartsItemID;
  public ulong PartsParentItemSN;
  public ulong PartsItemSN;
  public string PartsProperty;
  public ulong DeathPartsItemSN;
}

public class USFUIDataStore_ItemList : USFUIDataStoreBase
{
  public class FCombineParts
  {
    public List<int> Parts;
  }

  public class FSModeItemData
  {
    public int GameModeID;
    public ulong[] ItemSN = new ulong[6];
  }

  public class FsVipItemListInfo
  {
    public int ItemId;
    public int AddPoint;
  }

  public class FSFirstBuySaleItemInfo
  {
    public string ItemCode;
    public List<USFGameItem.FSFirstBuySaleItem> SaleItemArray;
  }

  public class FSToBuyItem
  {
    public int ItemId;
    public int PaymentIndex;
    public string CouponID;
    public int CouponDiscountPrice;
    public int GiftReceiverUSN;
    public string GiftReceiverCodeName;
    public string GiftMessage;
    public string logType;
    public bool IsGift;
  }

  public class FSCashIcon
  {
    public string ServiceCode;
    public string CashIcon;
  }

  public class FsNetmarbleCoupon
  {
    public string CouponID;
    public string CouponName;
    public int DiscountPercent;
    public string ExpireDate;
    public int Count;
  }

  public class FCombineDesignInfo
  {
    public int DBIndex;
    public string GroupName;
    public int RewardItemID;
    public List<int> RequirePartsCount;
    public string RewardName;
    public string RewardGroup;
    public int HiddenItemID;
    public int Probability;
  }

  public List<USFGameItem.FSRecvItemInfo> UsedItemArray;
  public List<USFGameItem.FSRecvItemInfo> NotUsedItemArray;
  public List<USFGameItem.FSRecvItemInfo> RemoveVipFreeItemArray;
  public List<USFGameItem.FSRecvItemShortInfo> WeaponItems;
  public List<USFGameItem.FSRecvItemShortInfo> CharacterItems;
  public List<USFGameItem.FSRecvItemShortInfo> WeaponOptionItems;
  public List<USFGameItem.FSRecvItemShortInfo> FunctionalItems;
  public List<USFGameItem.FSRecvItemShortInfo> GashaItems;
  public List<FSModeItemData> ModeItems;
  public List<FSModeItemData> PendingModeItem;
  public List<ulong> RemoveVipFreeItems;
  public bool bIsSearching;
  public bool bReceiveAll;
  public bool bIgnoreRecommendItem;
  public bool bFailedCashBuy;
  public bool RecvNewItemIsInUse;
  public bool bProcessNewItemTableWithError;
  public bool IsUseItemName;
  public bool IsOpenItemDialog;
  public bool bIsOptimizeInventory;
  public string SearchedText;
  public string ItemSearchFailMessage;
  public string ItemSearchLackCharacters;
  public int ItemSearchLimitCharacters;
  public int UsedItemCount;
  public int NotUsedItemCount;
  public string ItemPriceNotMatchSrc;
  public string strNoSellMessage;
  public string strCountText;
  public int nItemWarningDay;
  public int nRepurchaseCheckDay;
  public int UsedPropItemID;
  public List<string> UsedParsePropertys;
  public int RepairSPMAX;
  public string ItemAdditionalValueIncreseFontColor;
  public string ItemAdditionalValueDecreseFontColor;
  public string ItemAdditionalValueZeroFontColor;
  public List<FSToBuyItem> ToBuyItemArray;
  public EBUYALLTYPE BuyAllType;
  public int PurchaseGuideItemType;
  public List<USFTypes.FSRecvReward> RecvRewardArray;
  public int RecvRewardCount;
  public int RecvPackageItemCount;
  public List<USFTypes.FSRecvReward> RecvPackageItemArray;
  public int RecvNewItemID;
  public int RecvNewItemPrice;
  public string RecvNewItemEndDate;
  public ulong RecvNewItemSN;
  public string RecvRewardType;
  public int ModeRewardCount;
  public List<USFTypes.FSRecvReward> ModeRewardArray;
  public int RecvChallengeRewardCount;
  public int CurChallengeRewardCount;
  public List<USFTypes.FSRecvChallengeReward> RecvChallengeRewardArray;
  public int NewUsedItemID;
  public int NewUsedItemModeID;
  public int NewUsedItemCount;
  public ulong NewUseGiftNSN;
  public int GiftReceivedCount;
  public int GiftSendedCount;
  public int GiftReceivedTotalCount;
  public int GiftSendedTotalCount;
  public List<USFTypes.FSGiftItem> GiftReceivedItemArray;
  public List<USFTypes.FSGiftItem> GiftSendedItemArray;
  public string GiftReceiverCodeName;
  public int GiftRecvLimitSize;
  public int GiftNoticeType;
  public ulong UsedGiftNSN;
  public int RecvItemTableInfoCount;
  public int CurItemTableInfoCount;
  public int RecvDailyDiscountInfoCount;
  public int CurNetmarbleDailyDiscount;
  public string CashIconImg;
  public string SPIconImg;
  public string TPIconImg;
  public string LPIconImg;
  public List<FSCashIcon> CashIconImgArray;
  public List<string> VipItemCodeArray;
  public List<USFTypes.FSRecvPromoEventReward> RecvPromoEventRewardArray;
  public int RecvModeItemShopListCount;
  public List<USFTypes.FSGuideItem> PurchaseGuideExpiredItems;
  public List<USFTypes.FSGuideItem> PurchaseGuideWillExpireItems;
  public List<USFTypes.FSGuideItem> PurchaseGuideModeItems;
  public List<USFTypes.FSGuideItem> PurchaseGuideRecommendItems;
  public List<int> PurchaseGuideIgnoreItems;
  public List<int> PurchaseGuideIgnoreTypes;
  public List<FsNetmarbleCoupon> RecvNetmarbleCouponList;
  public int RecvFirstBuySaleItemCount;
  public List<USFGameItem.FSFirstBuySaleItem> FirstBuySaleItemArray;
  public List<FSFirstBuySaleItemInfo> SaleItemInfoArray;
  public List<FsVipItemListInfo> RecvVipItemArray;
  public List<USFTypes.FsVipGradeInfo> RecvVipGradeInfoArray;
  public int RecvVipMapRotationCount;
  public int RecvSaveVipMapRotationCount;
  public int RepairCouponCount;
  public int RepairCouponID;
  public List<string> PlayAniStatTagName;
  public List<USFTypes.FMapRotationInfo> VipMapRotationInfoList;
  public int VIPMapMaxSlotCount;
  public int StoredMaterialRewardItemID;
  public List<USFTypes.FsRecvRandomBoxReward> RecvRandomBoxRewardArray;
  public List<USFTypes.FsRandomBoxInfo> RandomBoxInfoArray;
  public int CombineDesignCount;
  public List<FCombineDesignInfo> CombineDesignList;
  public FCombineParts CurrentCombineParts;
  public FScriptDelegate __CodeNameColorSortByVersionNumberDelegate__Delegate;
  public FScriptDelegate __DiscountCouponListSortDelegate__Delegate;
  public FScriptDelegate __SortByDBIndex__Delegate;
}

public class USFUIDataStore_Messenger : USFUIDataStoreBase
{
  public class FSMsgrNotice
  {
    public int nType;
    public int DurationTime;
    public string strTitle;
    public string strMessage;
    public string strOK;
    public string strCancel;
  }

  public int MaxBuddyFLCount;
  public bool bNotifyBuddyLogout;
  public bool bNeedUpdateNoticeCount;
  public bool bNeedUpdateTitle;
  public bool bDoubleLogin;
  public bool InitedBuddyList;
  public bool RecvIsNew;
  public int TotalBuddyCount;
  public int TotalBuddyFLCount;
  public int TotalBuddyGroupCount;
  public int TotalBuddyStatusCount;
  public int ActiveGroupSN;
  public List<USFTypes.FsBuddy> buddys;
  public List<int> DisplayBuddys;
  public List<USFTypes.FsBuddyGroup> BuddyGroups;
  public List<USFTypes.FsMessengerNotice> Notices;
  public List<int> NeedUpdateFriendList;
  public List<int> LocUpdatedList;
  public USFTypes.FsMessengerNotice DisplayingNotice;
  public List<USFTypes.FSMsgrChattingInfo> MsgrChattingInfoArray;
  public USFTypes.FSChatMsgInfo SendPendingChatMsg;
  public int statusNow;
  public int inGameNow;
  public USFTypes.FsBuddyFiltterCondition FiltterCondition;
  public string RecvCodeName;
  public List<FSMsgrNotice> PendingMsgrNoticeArray;
  public List<FSMsgrNotice> MsgrNoticeInfo;
  public string strBuddyLogin;
  public string strBuddyLogout;
  public string strAddBuddyFLWaiting;
  public string strAddBuddyFLAccept;
  public List<string> GameInviteStrSource;
  public List<string> GameFollowStrSource;
  public string RecvInviteRespondMessage;
  public int SelectedBuddyUSN;
}

public class USFUIDataStore_PlayerInfo : USFUIDataStoreBase
{
  public class FsClanMsgInfo
  {
    public string msg;
    public EClanMsgPacketType Type;
  }

  public class FSRecvRanking
  {
    public int Type;
    public int Ranking;
    public int AllCount;
  }

  public class FsNotifyInfo
  {
    public string LinkType;
    public string Path;
    public string WebURL;
  }

  public class FsFiringrangeInfo
  {
    public string WeaponType;
    public int Rank;
    public int Score;
    public string Initial;
  }

  public class FsExitItemData
  {
    public string SupplyCode;
    public int SupplyStep;
    public string Type;
    public int ItemId;
  }

  public class FMyMonthlyRewardInfo
  {
    public int Grade;
    public int AccumulationCash;
    public float SalePercent;
    public float AddEXP;
    public float AddSP;
    public List<int> RewardList;
    public List<int> RewardBuytypeList;
    public bool IsMonthlyReward;
  }

  public class FMonthlyRewardInfo
  {
    public int CashSectionBegin;
    public int CashSectionEnd;
    public float SalePercent;
    public float AddEXP;
    public float AddSP;
    public List<int> RewardList;
    public List<int> RewardBuytypeList;
  }

  public class FSMapID
  {
    public List<int> MapID;
  }

  public class FS1VS1UserRankListInfo
  {
    public int CustomModeType;
    public List<USFTypes.FS1VS1UserRankInfo> Info1VS1UserList;
  }

  public class FsScreenResList
  {
    public EAspectRatioType ScreenRateType;
    public List<string> ScreenRes;
  }

  public int CustomModeIndex;
  public byte CPULevel;
  public byte GPULevel;
  public byte CPUNumPhysicalProcessor;
  public byte CPUNumCorePerProcessor;
  public byte CPUCompanyType;
  public byte CompositeLevel;
  public byte CompositeLevelOriginal;
  public EOutFromRoom OutFromRoomReason;
  public EReturnLobby ReturnLobbyType;
  public byte LastClanMsgType;
  public List<string> VideoResolutions;
  public List<FsScreenResList> ScreenResLists;
  public bool bCapturingVideo;
  public bool bTwitchTVBroadcast;
  public bool bRecvGetUserInfo;
  public bool bNeedServerUpdateMainUnit;
  public bool bIsClanLoginMsg;
  public bool bAutoNotifyWindow;
  public bool bReloadInventory;
  public bool bEnableRequestGift;
  public bool bEnableGiftSendButton;
  public bool bRequestLuckyPoint;
  public bool bEnableNewMonthlyReward;
  public bool bEnableDiscountItemGift;
  public bool bCharacterCreate;
  public bool IsUpdateMonthlyReward;
  public bool bCheckFreeItemForMRFlag;
  public bool ShouldRequestHeroRewardCoin;
  public bool bOpenMiniGachaPopup;
  public bool bRankUpFlagForLobby;
  public bool bUseKADRatio;
  public bool IsShopPMCItem;
  public bool bClanBuff;
  public USFTypes.FSPlayerInfo MyInfo;
  public USFTypes.FSPlayerInfo OldMyInfo;
  public USFTypes.FSPlayerInfo NewMyInfo;
  public USFTypes.FSMyRanking MyRanking;
  public List<FSRecvRanking> MyRankingArray;
  public List<string> LastClanMsgUSNArray;
  public List<string> LastClanMsgCodeNameArray;
  public List<string> LastClanMsgClanNameArray;
  public string LastNotifyClanMsg;
  public List<FsClanMsgInfo> ClanMsgInfoArray;
  public List<string> ClanWarResultText;
  public List<USFTypes.FSFWeaponLog> WeaponLogArray;
  public int JoinSeverID;
  public int AntiFatigueAccumTimeS;
  public int AntiFatigueIntervalM;
  public int AntiFatiguePrevTimeM;
  public int ShutDownLawStep;
  public List<USFTypes.FSShutDownLaw> ShutDownArray;
  public List<USFTypes.FSShutDownNoti> ShutDownNotiArray;
  public float GameStartAppSeconds;
  public int RankingListCount;
  public int LobbyLoadedCount;
  public List<string> WeaponLogResults;
  public List<FName> KillInfoPacketNames;
  public int TotalAccomplishedChallengeList;
  public float fPrevRequestGiftTime;
  public float PlayerInfoReqDelayTime;
  public List<FsNotifyInfo> NotifyInfoArray;
  public List<FsNotifyInfo> ADInfoArray;
  public List<FsNotifyInfo> ChannelListADInfoArray;
  public List<FsNotifyInfo> ClanLeagueADInfoArray;
  public List<FsNotifyInfo> ClanLeagueTermsInfoArray;
  public List<FsNotifyInfo> FeverTimeInfoArray;
  public List<FsNotifyInfo> SerialADInfoArray;
  public List<FsNotifyInfo> SoloLeagueInfoArray;
  public string UseInitWeaponLogItemCode;
  public List<FsFiringrangeInfo> MyFiringrangeArray;
  public int ExitItemCount;
  public int ExitUserGroupNumber;
  public int ExitCheckResult;
  public string ExitCheckGroup;
  public List<FsExitItemData> ExitItemArray;
  public USFTypes.FsPlayerVIPInfo VipInfo;
  public List<FMonthlyRewardInfo> MonthlyRewardList;
  public FMyMonthlyRewardInfo MyMonthlyReward;
  public int MonthlyRewardStartDay;
  public FSMapID[] ActivePvEMapID = new FSMapID[4];
  public List<string> ColorCodeNameV2Array;
  public string ColorCodeNameV2Default;
  public int FacebookFriendTransactionCount;
  public int FacebookUserInfoTransactionCount;
  public List<USFTypes.FSFacebookUserInfo> FacebookFriendsList;
  public List<USFTypes.FSFacebookUserInfo> FacebookInterlockedFriendList;
  public int MonthlyRewardListCount;
  public int PCRoomCareType;
  public List<string> DisguiseRankSettingList;
  public int ClanConnectBenefitLimitCount;
  public int FiringRangeArrayCount;
  public string SendFiringRangeWeaponType;
  public int SendFiringRangeScore;
  public List<string> Result1VS1RankList;
  public List<FS1VS1UserRankListInfo> Rank1VS1UserList;
  public int RankUserCount;
  public FScriptDelegate __SortWeaponLogByNameDelegate__Delegate;
}

public class USFUIDataStore_Rank : USFUIDataStoreBase
{
  public class FPVERankPlayerInfo
  {
    public string CodeName;
    public int Rank;
  }

  public class FPVERankTeamInfo
  {
    public ulong Rank;
    public int TeamScore;
    public int Level;
    public List<USFUIDataStore_Rank.FPVERankPlayerInfo> Members;
  }

  public class FModeRankInfo
  {
    public int GameModeID;
    public List<USFUIDataStore_Rank.FPVERankTeamInfo> RankTeamList;
  }

  public class FSoloLeagueRankInfo
  {
    public string Season;
    public string Ranking;
    public string Rank;
    public string CodeName;
    public string Match;
    public string LeaguePoint;
  }

  public class FRankUpdateDateInfo
  {
    public int Year;
    public int Month;
    public int Day;
  }

  public class FModeRankProtocol
  {
    public int ModeID;
    public int ProtocolID;
  }

  public List<FSoloLeagueRankInfo> SoloLeagueRankList;
  public List<FModeRankInfo> ModeRankTeamList;
  public List<FPVERankTeamInfo> CurrentRankTeamList;
  public FRankUpdateDateInfo LastRankUpdatedDate;
  public int ReceivedRankSize;
  public int LastRequestedModeID;
  public int CurrentGameModeID;
  public List<FModeRankProtocol> ModeRankProtocolList;
}

public class USFUIDataStore_RealTimeEvent : USFUIDataStoreBase
{
  public List<USFTypes.FSRealTimeEvent> RealTimeEventArray;
  public USFTypes.FSFeverTimeEvent FeverTimeEvent;
  public int RecvPromoEventCount;
  public int RecvMyPromoEventCount;
  public List<USFTypes.FSPromotionEvent> PromotionEventArray;
  public List<USFTypes.FSPromotionEvent> MyPromotionEventArray;
  public List<USFTypes.FSPromotionEvent> PrevMyPromotionEventArray;
}

public class USFUIDataStore_RoomSetting : USFUIDataStoreBase
{
  public class FSGameModeByChannel
  {
    public List<string> GameModeArray;
    public List<int> ChannelTypeArray;
    public bool ApplyCustomMode;
  }

  public class FSGameModeByCreateRoom
  {
    public List<string> BelongToGameMode;
  }

  public class FSPreQuickJoinInfo
  {
    public string SelectMapID;
    public string SelectModeID;
    public int WeaponTypeMode;
    public int PickUpWeapon;
  }

  public class FSModeInfoSearchCache
  {
    public int GameModeID;
    public string GameModeName;
    public string LocsGameModeName;
    public string GameModeClassName;
    public string LocsGameModeClassName;
    public EGameMode GameModeType;
  }

  public class FSMapInfoSearchCache
  {
    public int MapID;
    public string MapName;
  }

  public class FSModeDispType
  {
    public int GameModeID;
    public int DispType;
  }

  public class FSUnitedMode
  {
    public int GameModeID;
    public List<int> SubGameModeIDArray;
    public List<string> SubGameModeNameArray;
  }

  public class FRotationModeData
  {
    public int GameModeID;
    public List<int> SubGameModeIDArray;
    public List<string> SubGameModeNameArray;
    public List<int> SubGameMapIDArray;
    public List<string> SubGameMapNameArray;
    public List<bool> IsSubMapShowrray;
    public int SubSelectedGameMapIndex;
    public bool IsNextRotaion;
  }

  public class FSCustomModeButton
  {
    public ECUSTOMMODE_WEAPONTYPE CustomModeType;
    public string CustomButtonText;
    public string CustomButtonToolTip;
  }

  public List<FSGameModeByChannel> GameModeByChannelArray;
  public List<FSGameModeByCreateRoom> GameModeByCreateRoomArray;
  public List<string> ApplyCustomModeData;
  public List<int> ApplyPickUpWeaponData;
  public List<USFUIDataProvider_ModeInfo> CurGameModeDataProvider;
  public List<USFUIDataProvider_ModeInfo> NormalGameModeDataProvider;
  public List<USFUIDataProvider_TutorialModeInfo> TutorialModeDataProvider;
  public List<USFUIDataProvider_BeginnerModeInfo> BeginnerModeDataProvider;
  public List<USFUIDataProvider_TrainingModeInfo> TrainingModeDataProvider;
  public List<USFUIDataProvider_ModeInfo> AllModeDataProvider;
  public List<USFUIDataProvider_MapInfo> MapDataProvider;
  public FSPreQuickJoinInfo QuickJoinInfo;
  public List<FSModeInfoSearchCache> ModeInfoSearchCacheArray;
  public List<FSMapInfoSearchCache> MapInfoSearchCacheArray;
  public List<int> ClanPlayerCount;
  public int HostUSN;
  public string HostIP;
  public int HostPort;
  public bool bUseRelay;
  public bool bReportDisableGameMode;
  public bool bNeedUpdateNoTeam;
  public bool bNeedUpdateSnowFight;
  public bool bSeperateMapForRookie;
  public bool bEnableSecondHalf;
  public bool bForceLeaveRookieChannel;
  public bool IsRoomGamingRotationSetting;
  public bool IsVIPMapUnlock;
  public string RelayIP;
  public int RelayPort;
  public int ExtraOption;
  public string GameUniqueKey;
  public USFTypes.FSRoomSetting PendingRoom;
  public USFTypes.FSRoomSetting GamingRoom;
  public USFTypes.FSRoomSetting PartyRoom;
  public USFTypes.FSFindMatchingRoom FindMatchingRoom;
  public int RecvRoomType;
  public int DefPartyRoomUserCount;
  public int SecondHalfWaitingTime;
  public int MatchWaitingDeniedTime;
  public int DisconnetedMactingTime;
  public int ForceExitMatchingRoomType;
  public float fGamingRoomJoinTime;
  public int PrevGameModeID;
  public int PrevMapID;
  public List<int> NoDurabilityModeArray;
  public int RecvLinkedRoomNumber;
  public int RecvMatchOver;
  public int RecvRedScore;
  public int RecvBlueScore;
  public byte RecvGameStartEnable;
  public List<int> PlayerCountArray;
  public List<FSModeDispType> ModeDispTypeArray;
  public List<FSModeDispType> RookieModeDispTypeArray;
  public List<FSModeDispType> VIPModeDispTypeArray;
  public List<FSUnitedMode> UnitedModeArray;
  public List<FRotationModeData> RotationModeList;
  public List<USFTypes.FCachedSupportMap> CachedSupportMapArray;
  public List<USFTypes.FSSupportMap> CachedAllModeSupportMapArray;
  public string RoomGamingVIPIcon;
  public string VIPModeImpossibleMessage;
  public List<string> DisableCreatePasswordModeName;
  public List<FSCustomModeButton> CustomModeListBT;
  public List<string> CustomModeListTitle;
  public FScriptDelegate __MapListSortByNameDelegate__Delegate;
  public FScriptDelegate __ModeSortByDispTypeDelegate__Delegate;
  public FScriptDelegate __CacheSortByDispTypeDelegate__Delegate;
}

public class USFUIDataStore_RoomSettingRef : UUIDataStore_GameResource
{
}

public class USFUIDataStore_RoomUserList : USFUIDataStoreBase
{
  public class FSClanUserCount
  {
    public int CSN;
    public int UserCount;
    public string ClanName;
    public string ClanMark;
  }

  public int DiffLimitPLayer;
  public int MaxAllPlayer;
  public bool bNoCheckBalance;
  public bool bPendingMasterChanged;
  public int BeginPlayerLimit;
  public int MaxTeamType;
  public USFTypes.FSRoomUserInfo GamingRoomUser;
  public USFTypes.FSRoomUserInfo PartyRoomUser;
  public USFTypes.FSRoomUserInfo FindMatchingRoomUser;
  public byte RecvUserStatus;
  public int RecvUSN;
  public int RecvOldSlotIndex;
  public int RecvNewSlotIndex;
  public int RecvRoomType;
  public string RecvCodeName;
}

public class USFUIHelper : UObject
{
  public class FsClanMarkIDInfo
  {
    public eClanMarkType Type;
    public int Min;
    public int Max;
  }

  public class FsViewTeamMarkInfo
  {
    public string ClassName;
    public int StartIndex;
  }

  public class FSItemImageTable
  {
    public int ItemId;
    public string ItemClassName;
    public string UIID;
  }

  public class FRewardImgInfo
  {
    public byte Grade;
    public string Img;
    public string NametagImg;
    public int RollingTime;
  }

  public string LocalizedMinute;
  public string LocalizedSecond;
  public string ClanHomeAM;
  public string ClanHomePM;
  public string MSG_Emblem_Item_Name;
  public string MSG_Remaining_DBNO_Time;
  public string MSG_Remaining_Respawn_Time;
  public string MSG_Exp_ExpRatio;
  public string MSG_BuffNotice;
  public string MSG_BuffOn;
  public string MSG_BuffOff;
  public string MSG_BuffFailed;
  public string Buff_Ripper;
  public string Buff_Stunner;
  public string Buff_Libertine;
  public string ItemCountMessage;
  public string VIPINFO_ADDSP;
  public string VIPINFO_ADDEXP;
  public string ItemUseTimeHourString;
  public string ItemUseTimeDayString;
  public string ItemUseTimeHourHtmlString;
  public string ItemUseTimeDayHtmlString;
  public string ItemRemainTimeMarkHtmlString;
  public string LogoImagePath;
  public List<EChatType> ChatNotColorCodeNameList;
  public List<string> LocalizedTime24List;
  public string DefaultClanMark;
  public string NoClanMark;
  public string TestClanMark;
  public List<string> DefaultLanguageFilePathList;
  public List<string> DefaultAllInOneFolderPathList;
  public List<string> TeamMarkTitleFilePathList;
  public List<string> BeastModeMarkTitleFilePathList;
  public List<FsViewTeamMarkInfo> ViewTeamMarkClassNameList;
  public List<FRewardImgInfo> VipImageList;
  public string VipAniImage;
  public List<FRewardImgInfo> MonthlyRewardImageList;
  public string ImageListHtmlFormat;
  public List<FsClanMarkIDInfo> ClanMarkIDInfoArray;
  public string DefaultUIEmblemID;
  public List<FSItemImageTable> ItemImageTable;
  public List<string> SpectatorDecoColorArray;
  public string RewardSPImage;
  public string RewardTPImage;
  public string RewardLPImage;
  public string RewardCASHImage;
  public string[] HUDTeamColor = new string[10];
  public string VariationShapeIncrease;
  public string VariationShapeDecrease;
  public string VariationShapeEqual;
  public bool bDeclareButton;
}

public class USFUIItemCodeType : UObject
{
  public class FSCharItemType
  {
    public ECharItemType TypeIndex;
    public string strItemType;
  }

  public class FSWeapItemType
  {
    public EWeaponType TypeIndex;
    public string strItemType;
  }

  public class FSWeapPartType
  {
    public EWeapPartType TypeIndex;
    public string strItemType;
  }

  public List<FSCharItemType> CharItemTypeArray;
  public List<FSWeapItemType> WeapItemTypeArray;
  public List<FSWeapPartType> WeapPartTypeArray;
}

public class ASFUIMinimapRadar : AActor
{
  public FVector[] TeamBaseArray = new FVector[8];
  public float RadarRange;
  public float RadarRangeMax;
  public float RadarRangeMin;
  public float RadarRangeDelta;
  public float LerpColorTopHeight;
  public FColor LerpColorTop;
  public float LerpColorBottomHeight;
  public FColor LerpColorBottom;
  public float DeadPawnDurationTime;
  public USFUIMinimapRadarGFxValue RadarGFxValue;
  public int GFxFrameSizeX;
  public int GFxFrameSizeY;
  public int CurrentOverlayLevel;
  public int PrevOverlayLevel;
  public ASFMinimapActor CurrentMiniMapActor;
  public bool bRetrieveFromProfile;
  public bool bRadarVisible;
  public ERadarType RadarType;
  public EZoomType ZoomType;
  public int DefaultMapTextureSizeX;
  public int DefaultMapTextureSizeY;
  public int GFxMiniMapFrameSize;
  public int GFxWholeMapFrameSize;
  public float AdditionalRadarMapScale;
  public int ChangePlayerStartGroupNumber;
}

public class USFUIMinimapRadarGFxValue : UGFxObject
{
  public class FGFxIconRawData
  {
    public UGFxObject GFxIcon;
    public UGFxObject TextField;
    public int FrameIndex;
    public string PrevText;
  }

  public class FGFxIconData
  {
    public List<USFUIMinimapRadarGFxValue.FGFxIconRawData> Icons;
    public UGFxObject Factory;
    public string CreateSymbolName;
    public string FactoryName;
    public int UsedIndex;
  }

  public class FSGFxPingData
  {
    public UGFxObject IconMC;
    public UObject.FVector TargetLocation;
    public EIconType IconType;
    public float RegisteredTime;
  }

  public int MapTexSize;
  public UGFxObject MapMC;
  public UGFxObject MapOverlayMC;
  public UGFxObject MapNavigationOverlayMC;
  public UGFxObject MaskMC;
  public FMatrix IconMatrix;
  public ASFPlayerController SFPlayerOwner;
  public FGFxIconData[] IconDatas = new FGFxIconData[15];
  public List<FSGFxPingData> PingList;
  public UGFxObject CursorMC;
}

public class ASFUnitTestCase_SampleTableData1 : ASFUnitTestCase_Base
{
  public USFLocalDB LocalDB1;
  public USFLocalDB LocalDB2;
}

public class ASFUnitTestGame : ASFDeathGame
{
  public float UnitTestGamePlayTime;
  public float PawnRefreshTime;
  public List<string> TestMapNames;
}

public class ASFUnitTestRunner_SampleTableData1 : ASFUnitTestRunner_Unit
{
}

public class ASFUnitTestRunner_Total : AActor
{
  public bool bAutoTest;
  public bool bExitWithError;
  public int testsRunCount;
  public int failuresCount;
  public int casesRunCount;
  public string LogFilename;
}

public class ASFVehicle : AVehicle
{
  public UDynamicLightEnvironmentComponent LightEnvironment;
  public FVector BaseOffset;
  public float CamDist;
}

public class ASFVehicle_ConvoyTarget : ASFVehicle
{
}

public class USFVehicleSimCar : USVehicleSimCar
{
  public FInterpCurveFloat TorqueVSpeedCurve;
  public FInterpCurveFloat EngineRPMCurve;
  public float LSDFactor;
  public float ThrottleSpeed;
  public float MinRPM;
  public float MaxRPM;
  public float ActualThrottle;
  public bool bForceThrottle;
  public bool bHasForcedThrottle;
  public bool bDriverlessBraking;
  public bool bAutoHandbrake;
  public float SteeringReductionFactor;
  public float SteeringReductionRampUpRate;
  public float CurrentSteeringReduction;
  public int NumWheelsForFullSteering;
  public float SteeringReductionSpeed;
  public float SteeringReductionMinSpeed;
  public float MinHardTurnSpeed;
  public float HardTurnMotorTorque;
  public float HandbrakeSpeed;
  public float ActualHandbrake;
  public float FrontalCollisionGripFactor;
  public float ConsoleHardTurnGripFactor;
  public float SpeedBasedTurnDamping;
  public float AirControlTurnTorque;
  public float InAirUprightTorqueFactor;
  public float InAirUprightMaxTorque;
}

public class ASFWeapon : AGameWeapon
{
  public class FsWeaponEffectPlayTimeInfo
  {
    public string WeapTypeName;
    public int WeapType;
    public float PlayTime;
  }

  public class FsMuzzleFlashPlayTimeInfo
  {
    public string WeapTypeName;
    public int WeapType;
    public float PlayTime;
  }

  public class FPunchAngleInfo
  {
    public int Pitch;
    public int Yaw;
    public float Exp;
    public float RecoveryTime;
  }

  public class FRecoilValue
  {
    public float Spread;
    public float Up_Base;
    public float Lateral_Base;
    public float Up_Modifier;
    public float Lateral_Modifier;
    public float Up_Max;
    public float Lateral_Max;
    public float Direction_Change;
  }

  public EWeaponStateDataPickUpType FireStateDataPickUpType;
  public EWeaponStateDataPickUpType ReloadStateDataPickUpType;
  public EWEAPON_GROUP InventoryGroup;
  public EWEAPON_SLOT SlotIndex;
  public byte bReloaded;
  public byte bReloadedCheck;
  public byte ZoomStateNow;
  public byte ZoomStateNext;
  public EWeapAimProfile WeapAimProfile;
  public byte AdditionalWeaponType;
  public byte bIsInExtension;
  public EHitMarkType HitMarkType;
  public EWeaponHoldType WeaponHoldHand;
  public EWeaponState CurrentAccessoryState;
  public int WeapPartTypeCount;
  public string MSG_Weapon_Is_In_Cooltime;
  public bool bReloadDelay;
  public bool bCanBestWeapon;
  public bool bDirectSelectable;
  public bool bInvalidFullAmmo;
  public bool bNeverForwardPendingFire;
  public bool bAIOnly;
  public bool bRecommendSplashDamage;
  public bool bSniping;
  public bool bLeadTarget;
  public bool bConsiderProjectileAcceleration;
  public bool bFastRepeater;
  public bool bLockedAimWhileFiring;
  public bool bNoAnimDelayFiring;
  public bool bReselectableWeapon;
  public bool bIsProvideWeapon;
  public bool bIsAutomatic;
  public bool bIsBurstAutomatic;
  public bool bPlayWeaponFireForSimulateFlashLocation;
  public bool bReloadStart;
  public bool bPostReloaded;
  public bool bIsExtraMode;
  public bool bInitRecoilCamera;
  public bool bTestRecoil;
  public bool CurrenctPunchDirection;
  public bool bDecayingPunchAngle;
  public bool bNeedWarnAiming;
  public bool bUseCrossHairWhenZoom;
  public bool bDisplayCrosshair;
  public bool bDisplayCrosshairWhenZoom;
  public bool bDisplayCrosshairWhenThirdPerson;
  public bool bDropped;
  public bool bUseMultiChannelSound;
  public bool bWeaponFireLoop;
  public bool bUseShellDropSound;
  public bool bUseWeaponSteady;
  public bool bCrosshairOverride;
  public bool bQuickEquipUpExigency;
  public bool bIgnorePutDownAni;
  public bool bIgnoreEquipUpAni;
  public bool bChangeGLWeapon;
  public bool bAttachWeaponVisible;
  public bool bKeepAnimTimeTransienHitStateChanging;
  public bool bUseCamPunchingLocation;
  public bool bUseCamPunchingRotation;
  public bool bDisplayDebugLines;
  public bool bWeaponMeshUpdated;
  public bool bHideCrosshair;
  public bool bForceSetupWeapMesh;
  public bool bPendingAttach;
  public bool bLocalWeapon;
  public bool bReselectedWeapon;
  public bool bWeaponItemIDTable_Mask;
  public bool bWeaponSetUpdated;
  public bool bSuppressReloadVoice;
  public bool bNeedToAttachBackSide;
  public bool bCanEquipWhenNoAmmo;
  public bool bUseSmallWeaponTextureSet;
  public bool bUseImpulseAnimControl;
  public bool bEnableImpulseAnimControl;
  public bool bPeriodicRecordingForKillCam;
  public bool bForceUpdateAmmoInRep;
  public bool bSetPenalty;
  public bool bUsePenalty;
  public bool bItemListUpdated;
  public bool bAltFireWeapon;
  public bool bNeedToSelfUpdateWeaponSet;
  public bool bIMagazine;
  public bool bInfiniteAmmo;
  public bool bInfiniteAmmoInMgzWhenInfiAmmo;
  public bool bForceShellOutEffect;
  public bool bAllowReActivateSameBuff;
  public bool bIgnoreBuffActiveCondition;
  public bool bUseSpread;
  public bool bSuppressCustomIdleMotion;
  public bool bReloadMgzWhenEquipped;
  public bool bPassthroughCorpses;
  public bool bApplyDOFEffect;
  public bool IgnoreReloadBurstFire;
  public bool IgnoreChangeWeaponBurstFire;
  public bool IgnoreFireStopWeaponBurstFire;
  public bool bNeedAttachWeaponToEx;
  public bool bModifiedByMode;
  public bool bIsAsyncLoading;
  public bool bIsSniper;
  public bool bPriWeaponExigency;
  public bool bOnlyDroneWeapon;
  public ASFPawn SFP;
  public float WeaponRangeDamageMax;
  public float WeaponRangeDamageMin;
  public float InstantHitDamageMin;
  public float HeadPointDist;
  public int WeaponPartsFlag;
  public int WeaponGripType;
  public int AdditionalWeaponDamageRange;
  public int AmmoCount;
  public int AmmoCountInMgz;
  public int OldAmmoCountInMgz;
  public int AmmoCountInMgzForRep;
  public int AmmoCountValidationBuffer;
  public int TotalAmmoCount;
  public int UsedAmmoCountInMgz;
  public int AmmoCountInMgzWhenReloadStart;
  public int SpawnedProjectileCount;
  public int AmmoCountMaxInMgz;
  public int AmmoCountMax;
  public List<int> ShotCost;
  public float GroupWeight;
  public float InventoryWeight;
  public float fFrontCheck;
  public float ProjectileSpawnOffset;
  public float FrontVelocityRatioForProjectile;
  public float BehindVelocityRatioForProjectile;
  public float CurrentRating;
  public float AimError;
  public FVector2D AI_AccCone_Min;
  public FVector2D AI_AccCone_Max;
  public FVector2D AI_AimDelay;
  public float DelayTimeToFire;
  public float WeaponEquipWeight;
  public float WeaponUnequipWeight;
  public List<int> OptionInfo;
  public float RadarDetectNoiseTime;
  public List<float> ReloadTimes;
  public List<float> FiringTime;
  public List<float> PreFiringTime;
  public List<float> FiringAnimOrgTime;
  public List<float> CoolTimes;
  public List<float> LastFiredTimes;
  public float fStartSprintTime;
  public float fEndSprintTime;
  public float fAllowTimeWeaponModeChange;
  public USFTypes.FS_RECOIL RecoilDefault;
  public USFTypes.FS_RECOIL RecoilZoomDefault;
  public float RecoilZoomModifier;
  public float RecoilCrouchModifier;
  public float RecoilRate;
  public int RecoilSeed;
  public USFTypes.FS_RECOIL RecoilCurrent;
  public USFTypes.FS_RECOIL Recoil;
  public USFTypes.FS_RECOIL RecoilZoom;
  public float RecoilCrouchRatio;
  public float RecoilDurationModifier;
  public UPhysicsAsset FirstViewWeaponPhysicsAsset;
  public List<FPunchAngleInfo> ZoomPunchAngle;
  public float PunchAngleDamping;
  public float PunchAngleSpringConstant;
  public float PunchAngleRatio;
  public float SpreadAccuracy;
  public float AccuracyDivisor;
  public float AccuracyOffset;
  public float MaxInaccuracy;
  public FRecoilValue TestRecoil;
  public FVector CurrentPunchAngle;
  public FVector CurrentPunchAngleVelocity;
  public float currentCrouchModifier;
  public float currentZoomModifier;
  public USFTypes.FsWeaponState WeaponStateNow;
  public USFTypes.FsWeaponState WeaponStateNew;
  public USFTypes.FsWeaponState WeaponStateOld;
  public float ZoomStateChangedTime;
  public float CrosshairScaling;
  public float WarnAimingMinDistance;
  public float WarnAimingAngle;
  public float WarnAimingAngleInternal;
  public int CameraInitialShakeChance;
  public int CameraShakeChance;
  public float DamageShakeInitialMinAngle;
  public float DamageShakeInitialMaxAngle;
  public float DamageShakeMinAngle;
  public float DamageShakeMaxAngle;
  public int ReloadingAmmoCountMax;
  public string DisplayName;
  public UPhysicsAsset DroppedPhysicsAsset;
  public USoundCue WeaponHittingGroundSound;
  public List<UAnimSet> AnimSets;
  public List<UAnimSet> GripAnimSets;
  public List<UAnimSet> ThirdPawnAnimSet;
  public List<UAnimSet> ThirdPawnGripAnimSet;
  public List<UAnimSet> ThirdPawnWPProfileAnim;
  public UAnimSet ThirdWeapAnimSet;
  public UAnimTree AnimTreeTemplate;
  public UAnimTree ThirdWeaponAnimTreeTemplate;
  public USoundCue CueWeaponPreFire;
  public USoundCue CueWeaponFire;
  public USoundCue CueWeaponAltFire;
  public USoundCue CueEmptyClick;
  public USoundCue CueWhipping;
  public USoundCue CueEquipSound;
  public USoundCue CueReloadSound3rd;
  public float BobDamping;
  public float JumpDamping;
  public float DashAnimSpeed;
  public float fBobSpeedMux;
  public float fBobWidth;
  public float fBobHeight;
  public float fBobDecRateForZoom;
  public float fBobZDecRateForZoom;
  public USkeletalMesh MeshWeapon1stView;
  public USkeletalMesh MeshWeapon1stViewEx;
  public USkeletalMesh MeshWeapon3rdView;
  public USkeletalMesh MeshWeapon3rdViewEx;
  public FVector vLagMaxDegree;
  public FVector vLagMaxDegreeWhenZoomed;
  public float fLagSpeed;
  public FVector vLagRotSpeed;
  public FVector vLagYawTranslation;
  public FVector vLagPitchTranslation;
  public USoundCue ShellOut3rdSound;
  public UParticleSystem ShellOutPSCTemplate;
  public UParticleSystem ShellOutPSCTemplate1stView;
  public float ShellOutTimming;
  public FVector vShellOut1stScale;
  public FVector vShellOutScale;
  public float ShellDropSoundPlayTime;
  public FName ShellDropSoundGroupName;
  public float fWeaponSteadyLength;
  public float fWeaponSteadyLengthWalk;
  public float fWeaponSteadyLengthFire;
  public FVector vWeaponSteadyTrans;
  public float InnerWidth;
  public float BarLength;
  public float FireNoise;
  public float ZoomBobDamping;
  public float PreReloadTime;
  public float PostReloadTime;
  public FVector vLocZoomIN;
  public FVector vLocZoomOut;
  public FRotator RotZoomIn;
  public FRotator RotZoomOut;
  public float fZoomedFOV;
  public float fZoomedFOVEx;
  public float fZoomOutFOV;
  public float fZoomedMeshFOV;
  public float fZoomOutMeshFOV;
  public FName ImpactEffectType;
  public FName SightBaseSocketName;
  public FName SightCrosshairMaterial;
  public USkeletalMesh SightOnMesh;
  public USkeletalMesh SightOffMesh;
  public UParticleSystem TracerTemplateFriend;
  public UParticleSystem TracerTemplateFoe;
  public List<USFTypes.FMuzzleFlash> MuzzleFlash1stView;
  public List<USFTypes.FMuzzleFlash> MuzzleFlash3rdView;
  public float ShellOutDuration;
  public List<USFTypes.FSWeaponEffect> WeaponEffect1stView;
  public List<USFTypes.FSWeaponEffect> WeaponEffect3rdView;
  public List<USFTypes.FSWeaponEffect> PendingWeaponEffect1stView;
  public List<USFTypes.FSWeaponEffect> PendingWeaponEffect3rdView;
  public string WeaponEffectStyleItemID;
  public string MuzzleColorItemID;
  public string MuzzleStyleItemID;
  public int MuzzleColorIndex;
  public USkeletalMesh ScopeMesh;
  public UParticleSystem ScopeReflectionEffectTemplate;
  public ASFWeapon LinkedWeapon;
  public int GLauncherItemID;
  public float LastHitTime;
  public float CamPunchingLocationRatio;
  public float CamPunchingRotationRatio;
  public USFSkeletalMeshComponent WeaponSkelComponent;
  public USFSkeletalMeshComponent WeaponSkelComponentEx;
  public List<UMaterialInterface> AssistWeaponMeterial;
  public List<USFTypes.FWeaponStateData> StateData;
  public USFAnimNodeSlot FullBodyNodeNormal;
  public USFAnimNodeSlot FullBodyNodeZoom;
  public FName FullBodyNodeNormalName;
  public FName FullBodyNodeZoomName;
  public FName ZoomInNodeName;
  public FName ZoomOutNodeName;
  public UClass WeaponAttachmentClass;
  public ASFWeaponAttachment WeaponAttachment;
  public UClass WeaponTypeCrosshairClass;
  public int CrosshairCircleFull;
  public int CrosshairCircleSmallSize;
  public int CrosshairCircleBigSize;
  public List<USFExplosionLight> MuzzleFlashLight;
  public List<USFParticleSystemComponent> MuzzleFlashPSC;
  public List<USFParticleSystemComponent> ShellOutPSC;
  public List<USFParticleSystemComponent> WeaponEffectPSC;
  public List<FName> ShellOutSocket1stView;
  public float ZoomModeChangeLength;
  public float ZoomModeChangeEnd;
  public float ZoomingFOVTime;
  public float[] ZoomingInTime = new float[2];
  public float ZoomingOutTime;
  public float fZoomStartTime;
  public List<USFWeaponRISBase> RISList;
  public List<UClass> DefaultRISList;
  public List<UClass> OptionRISList;
  public float ActionCamoKillTime;
  public FName SocketNameToAttach;
  public FVector AdditionalMovement;
  public float EquipBlendTime;
  public float EquipUpExBlendTime;
  public float FireBlendTime;
  public float AltFireBlendTime;
  public float ReloadBlendTime;
  public float EquipUpExTime;
  public int[] WeaponItemIDTable = new int[16];
  public int WeaponID;
  public FName WeaponItemCode;
  public List<int> WeaponItemList;
  public FName BackSideSocketName;
  public FName BackSideSocketNameEx;
  public FVector MaxImpulseAnimRelativePosiion;
  public USkelControlLimb ImpulseLeftIK;
  public USkelControlLimb ImpulseRightIK;
  public USkelControlSingleBone ImpulseWeaponFit;
  public FName ImpulseLeftIKControlName;
  public FName ImpulseRightIKControlName;
  public FName ImpulseFitControlName;
  public FName ImpulseLeftIKBoneName;
  public FName ImpulseRightIKBoneName;
  public FName ImpulseFitBoneName;
  public int MaxFireImpulseCount;
  public float FireImpulseBlendOutTime;
  public float FireImpulseCount;
  public string WeaponName;
  public float RecordingPeriod;
  public float PerioicRecordingDeltaTime;
  public float StoppingPower;
  public float StoppingPowerDuration;
  public float AccelRatePctWhenStoppingPowerDuration;
  public float KnockBackPower;
  public FScriptDelegate GetMuzzleLocHook;
  public FScriptDelegate GetAmmoCountMgzHook;
  public FScriptDelegate CauseMuzzleFlashHook;
  public FScriptDelegate GetWeaponStateTimeHook;
  public UTexture2D CamoMaskTexture;
  public int CamoItemID;
  public string WeaponTagString;
  public List<int> RoundBurst;
  public List<float> BurstInterval;
  public List<float> APRatioBodyParts;
  public List<float> DmgScaleBodyParts;
  public string EditorDefaultWeaponMeshPath;
  public float ThicknessForPenetrate;
  public float WeaponRangeMin;
  public List<float> fAttackableYaw;
  public List<float> fAttackableDot;
  public float CriticalHeadShotMul;
  public float BackAttackMul;
  public USFTypes.FAddtionalIdleMotion AdditionalIdle;
  public float CachedThrowMaxRange;
  public int OldRequestedAmmoCountInMgz;
  public int OldRequestedAmmoCount;
  public FName RetargetingControlName;
  public USFSkelControl_Retargeting RetargetingControl;
  public List<float> SpreadMin;
  public List<float> SpreadMax;
  public float SpreadIncRate;
  public float SpreadDecRate;
  public float SpreadRateNow;
  public float SpreadNow;
  public List<UCameraAnim> CameraAnimEffect;
  public float CameraAnimBlendInTime;
  public float CameraAnimBlendOutTime;
  public float ChargeCancelTime;
  public float ChargeStartTime;
  public float ChargeEndTime;
  public UParticleSystem TracerTemplateSetTopViewGame;
  public UParticleSystem ExtraHitPS;
  public float DOFBlurStartDistance;
  public float DOFBlurEndDistance;
  public int BurstFireCount;
  public List<bool> bPendingStopFire;
  public float BeginAltFiringDelay;
  public float LastBeginAltFireTime;
  public float RatioReload;
  public float RatioEquip;
  public int ModifiedWeaponLevel;
  public List<UClass> DefaultItemClasses;
  public USFAnimNodeSlotAccessory AccessoryAnimController;
  public UAnimTree AccessoryAnimTree;
  public UAnimSet AccessoryAnimSet;
  public USkeletalMesh AccessoryMesh;
  public USkeletalMesh AccessoryMesh3rd;
  public List<EWeaponState> CanceledWeaponStateSoundList;
  public List<FsMuzzleFlashPlayTimeInfo> MuzzleFlashPlayTimeInfo;
  public List<FsWeaponEffectPlayTimeInfo> WeaponEffectPlayTimeInfo;
  public List<FName> WeaponPreviewHideBoneName;
  public FScriptDelegate __GetMuzzleLocationHooker__Delegate;
  public FScriptDelegate __GetAmmoCountInMgzHooker__Delegate;
  public FScriptDelegate __CauseMuzzleFlashHooker__Delegate;
  public FScriptDelegate __GetWeaponStateTimeHooker__Delegate;
}

public class ASFVehicleWeapon : ASFWeapon
{
}

public class USFVehicleWheel : USVehicleWheel
{
}

public class USFVeryHardWaveCompleteByMap : USFWaveCompleteByMap
{
}

public class ASFWallPathNode : APathNode
{
  public float MaxJumpDist;
}

public class USFWallShotEventData : USFSpecialKillEventData
{
}

public class USFWarningMessage : USFLocalMessage
{
}

public class ASFWarriorGame : ASFTeamGameInfo
{
  public class FSAIRespawnGroupInfo
  {
    public int Group;
    public float Delay;
    public float LastRespawnedTime;
    public int RespawnCount;
    public int OpenedSpawnPoints;
    public bool bUseRandomStrengthen;
    public bool bShareRespawning;
    public List<ASFGameWarriorAIStart> SpawnPoints;
    public bool bAnnounced;
    public bool bAnnounceOnetime;
    public string SpawnAnnounceMessage;
    public float SpawnAnnounceDelay;
  }

  public USFGameExplosion ExplosionInfo;
  public string ExplosionParticleSystemName;
  public UClass GameSettingClass;
  public int KilledPawnCount;
  public int KilledPawnCountMax;
  public int AllAIDeathCount;
  public float DefaultAIPawnScaleRate;
  public List<FSAIRespawnGroupInfo> AIRespawnGroupList;
  public float LastMissionActorPingtime;
  public float MissionActorPingDelay;
  public float RandomStrengthenRate;
  public float AssistTimeOut;
}

public class ASFWarriorGameReplicationInfo : ASFGameReplicationInfo
{
  public EHeroVersion HeroVersion;
  public USFCCTV CCTVInfo;
  public float BackAttackAbsoluteModeLevelAdditionalRatio;
  public float BackAttackRelativeModeLevelAdditionalRatio;
  public float BackAttackMinimumRatio;
  public AActor[] MoveSubjects = new AActor[2];
}

public class USFWarriorGameScore : USFGameScore
{
  public List<USFTypes.FAIPawnScore> PawnBasisScoreList;
  public float BasisHighLevelKillScore;
}

public class USFWarriorGameSetting : UObject
{
  public float DefaultMoney;
  public float DefaultPay;
  public float DefaultPayPeriod;
  public List<int> ModeExp;
  public List<USFTypes.FDamageRatioByGameMode> arrDamageRatioByGameMode;
  public float ShockWavePeriod;
  public float AssistMoneyRewardRate;
  public float AssistExpRewardRate;
}

public class ASFWarriorHUD : ASFTeamHUD
{
  public float HPBarDrawDistance;
  public USFGFxHUD gfxHUD;
  public USFGFxHUDWidget_CodeName wigetCodeName;
  public int PrevModeMoney;
}

public class USFWarriorKillDeathMessage : USFKillDeathMessage
{
  public string MSG_ContinualKilling;
  public List<string> MSG_ContinualKills;
  public string MSG_OurForce;
}

public class USFWarriorLevelUpMessage : USFLocalMessage
{
  public string ModeLevelUp;
}

public class ASFWarriorPlayerController : ASFPlayerController
{
  public string WarriorLevelUpMessage;
  public string Message_MissionActorDamaged;
  public float RespawningDeltaTime;
  public float WaitForSpectatingDelay;
  public float RecallStartTime;
  public float RecallCastingDelay;
  public float EmergencyNotifyHealthRate;
  public float EmergencyNotifyLoopDelay;
  public float LastEmergencyNoticedTime;
  public bool bTestForceRPCSend;
  public int RecvRewardCount;
}

public class ASFWarriorPlayerReplicationInfo : ASFGrowUpPlayerReplicationInfo
{
  public class FSPolymorphInfo
  {
    public string PolymorphPawnClassName;
    public EModeStatType PolymorphBaseStat;
    public List<USFTypes.FSModeStatInfo> PolymorphBonus;
  }

  public string MSG_StatType_Attack;
  public string MSG_StatType_Defence;
  public string MSG_StatType_Move;
  public float RespawnDelay;
  public float CurrentAttackPoint;
  public float CurrentDefencePoint;
  public int CrustalianScore;
  public int ContinualKills;
  public int LastContinualKills;
  public int ContinualDeaths;
  public float HealthPerModeDefencePoint;
  public float AttackPointDamageMul;
  public float AgilityPointDamageMul;
  public float DefencePointDamageMul;
  public float SpeedUpMul;
  public bool bDisplayCodeNameWithHighestStat;
  public bool bUsePolymorph;
  public float ModeMaxTotalPoint;
  public int PolymorphStatPoint;
  public List<FSPolymorphInfo> PolymorphInfo;
  public int Log_RifleKill;
  public int Log_DefaultWeaponKill;
  public int Log_SpecialWeaponKill;
  public int Log_SpendForHealing;
  public int Log_SpendForStat;
  public int Log_SpendForSummon;
  public int Log_SpendForWeapon;
  public int Log_SpendForEtc;
  public int Log_DestroyedTurrets;
  public int Log_DestroyedTowers;
  public int Log_DamageToTower;
  public int Log_NewtralCS;
  public int Log_WeakKillCS;
}

public class ASFWarriorTeamInfo : ASFTeamInfo
{
  public int AIDeathCount;
  public int AICriticalDeathCount;
}

public class USFWavePlayer : UObject
{
  public USoundCue SoundCue;
  public UAudioComponent WaveComponent;
  public FName WaveParamName;
  public AActor Owner;
}

public class ASFWeap_Projectile : ASFWeapon
{
  public float PenaltySpread;
}

public class ASFWeap_Throw : ASFWeap_Projectile
{
  public bool bThrowingStart;
  public bool bThrowIsReady;
  public bool bDroppableProjectile;
  public bool bUseHangFire;
  public bool bUseTrajectorySimulation;
  public bool bProjectileSpawned;
  public bool bRepeatedWeapon;
  public int FireModeNow;
  public float fThrowSafty;
  public List<ASFProj_Throw> TrajectoryProjectiles;
  public List<UClass> TrajectoryProjectileClasses;
  public float TrajectorySimulationDelayTime;
  public float PreFireStartTime;
}

public class ASFWeap_Beacon : ASFWeap_Throw
{
}

public class ASFWeap_BossSkill : ASFWeapon
{
  public float SkillTimeLength;
  public float CoolTime;
  public float LastUseTime;
}

public class ASFWeap_BossSkill_Barrage : ASFWeap_BossSkill
{
  public int ShotCountNow;
  public FRotator AimDirBase;
  public bool bPlayingFireAnim;
  public float DirectAimRatio;
  public int BaseSetPitch;
  public int PirchErrorRange;
}

public class ASFWeap_BossSkill_CallPawn : ASFWeap_BossSkill_Barrage
{
  public int OverFriendCount;
  public EAITypes SpawnPawn;
}

public class ASFWeap_BossSkill_Kidnaping : ASFWeap_BossSkill_Barrage
{
}

public class ASFWeap_BossSkill_Rage : ASFWeap_BossSkill
{
}

public class ASFWeap_InstantHit : ASFWeapon
{
  public float IncidenceAngle;
}

public class ASFWeap_Bullet : ASFWeap_InstantHit
{
  public class FRifleHitResult
  {
    public List<AActor.FImpactInfo> ImpactInfos;
    public List<AActor.FImpactInfo> PenetrationInfos;
    public List<float> DamageScale;
  }

  public class FsHitPawns2d
  {
    public APawn HitPawn;
    public float Dist;
  }

  public float fPenetrationMax;
  public int MaxPenetrationCount;
  public FRifleHitResult HitResult;
  public bool bPendingZoom;
  public bool bLockManualZoom;
  public bool bUseLoopReload;
  public bool bNeedToStopReloadLoop;
  public bool bUseZoomoutBoltAction;
  public bool bBreanchGunTracer;
  public bool bSkipExtraTracerforFriend;
  public bool bHiddenWeaponAttachmentMagazine;
  public bool bUseSilencer;
  public bool bUseSniperScope;
  public bool bShowPenetrationLine;
  public bool bCanReloadingFire;
  public bool bImmediatelyZoom;
  public int nAvaliableZoomLevel;
  public float fZoomModeChangeEnd;
  public List<FVector2D> PelletSpread;
  public float SGSpread;
  public float SGSpreadSize;
  public int SGPelletCount;
  public float fZoomoutBoltAction;
  public float fMuzzleFlashScale1st;
  public USFTypes.FGunTrailInfo[] GunTrailInfos = new USFTypes.FGunTrailInfo[3];
  public FVector GunTrailColor;
  public int nCountContinuousFireforExtraGunTrail;
  public UParticleSystem ExtraTracerTemplateFriend;
  public UParticleSystem ExtraTracerTemplateFoe;
  public USoundCue ZoomInSound;
  public USoundCue ZoomOutSound;
  public float FireAnimMinSpeedThreshold;
  public float Lens_CubeMap_Intense;
  public float LENS_OPACITY_INTENSE;
  public USFSkeletalMeshComponent SightMeshComponent;
  public USkeletalMeshComponent MagazineMeshComponent;
  public float fGunTrailOutLast;
  public int SightCrosshairSelector;
  public int SightCrosshairSelectorMax;
  public int ScopeZoomeRate;
  public int ScopeZoomeRateMax;
  public int nUsingSight;
  public float LastShotTime;
  public FName MagazineBoneName;
  public FName WeaponRootBoneName;
  public float GrazeDamageRate;
  public float GrazeSize;
  public float AIRecommRange;
  public int TestOldWeaponAmmo;
  public USFPhysicalMaterialProperty LastHitMtrl;
}

public class ASFWeap_Melee : ASFWeap_InstantHit
{
  public class FsDamagedActor
  {
    public AActor DamagedActor;
    public float Dist;
  }

  public float fCriticalDamageRate;
  public float AddRangeWhenForward;
  public List<int> HitDetectSubTicks;
  public List<float> HitDetectVertAngle;
  public List<float> HitDetectHorzAngle;
  public List<MeleeWeaponDetectType> DetectType;
  public int CurrentSubTick;
  public float HitDetectHorzUnitAngle;
  public float FireStartTime;
  public float HitDetectTimer;
  public float FireStartDelta;
  public List<float> FireStartInterval;
  public List<float> FireStartIntervalWhenHit;
  public List<int> HitDecalRotation;
  public USoundCue CueWeaponHitPawn;
  public USoundCue CueWeaponHitFire;
  public bool bPreHitCheck;
  public bool bApplyMultiTargetDamage;
  public UParticleSystem ForceFireImpactEffect;
}

public class ASFWeap_Charge_AI : ASFWeap_Melee
{
  public float MuxSpeed;
  public float PrimaryTargeDamage;
}

public class ASFWeap_Crossbow : ASFWeap_Bullet
{
  public List<FName> BoneNamesToHide;
  public float BoneUpdateTime;
  public float PenaltySpread;
  public float ReloadVoiceDelay;
  public List<float> ProjectileFireDelay;
  public bool bClampAmmoCountForUI;
}

public class ASFWeap_DroneBase : ASFWeap_InstantHit
{
  public List<UMaterialInterface> DroneControllStateMat;
  public int GiveDroneWeaponItemID;
  public int MaxSummonCount;
  public int CurrentSummonCount;
  public EDroneType CurrentDroneType;
  public EDroneControllState CurrentDroneControllState;
  public bool bDroneSpawn;
  public bool bDroneBroken;
  public bool bIgnoreChangeWeapon;
}

public class ASFWeap_Exigency : ASFWeap_Melee
{
}

public class ASFWeap_Explode_AI : ASFWeap_Projectile
{
}

public class ASFWeap_GLauncher : ASFWeap_Projectile
{
  public UClass FatherWeapon;
  public float FireAniCut;
  public int nUsingSight;
  public bool bUseSniperScope;
  public bool bImmediatelyZoom;
  public bool bPendingZoom;
  public bool bLockManualZoom;
  public USoundCue ZoomInSound;
  public USoundCue ZoomOutSound;
  public int ScopeZoomeRate;
  public int ScopeZoomeRateMax;
  public int nAvaliableZoomLevel;
  public float fZoomModeChangeEnd;
  public USFSkeletalMeshComponent SightMeshComponent;
  public int SightCrosshairSelector;
  public int SightCrosshairSelectorMax;
}

public class ASFWeap_HandGrenade : ASFWeap_Throw
{
  public float[] SmokeColor = new float[6];
}

public class ASFWeap_MeleeSwing : ASFWeap_Melee
{
  public class FSSwingPawn
  {
    public float ActivateTime;
    public ASFPawn Pawn;
  }

  public List<FSSwingPawn> SwingPawns;
  public List<bool> EnableMeleeSwingArray;
  public float SwingStartTime;
  public bool bContinuousAttack;
  public FScriptDelegate __SwingPawnSortDelegate__Delegate;
}

public class ASFWeap_Knife : ASFWeap_MeleeSwing
{
  public float ChargeAttackRange;
}

public class ASFWeap_Melee_AI : ASFWeap_Melee
{
  public List<int> EnableHitCount;
  public List<bool> bIsMovingAttack;
  public float SprintAttackMinDist;
}

public class ASFWeap_Mission : ASFWeapon
{
  public bool bAnimationTestMode;
  public bool bExtensionPutdown;
  public bool bHideWeaponWhenPutdown;
  public bool bHideWeaponWhenExtensionPutdown;
  public bool bAutoFireWhenActive;
  public USkeletalMesh SkeletalMesh1st;
  public USkeletalMesh SkeletalMesh3rd;
  public EMissionItemType MissionType;
  public ASFTrigger_Use CurrentMissionTrigger;
  public float ReplaceGaugeTime;
}

public class ASFWeap_Projectile_exigency : ASFWeap_Projectile
{
}

public class ASFWeap_Range_AI : ASFWeap_Projectile
{
}

public class ASFWeap_ThrowingKnife : ASFWeap_Throw
{
}

public class ASFWeap_Shuriken : ASFWeap_ThrowingKnife
{
}

public class ASFWeap_SniperBase : ASFWeap_Bullet
{
}

public class ASFWeap_ThrowingMelee : ASFWeap_Melee
{
  public class FBoneInfoToHide
  {
    public FName BoneName;
    public EWeaponState WeaponState;
    public int FireModeNum;
    public bool bHidden;
  }

  public List<FBoneInfoToHide> BoneNamesToHide;
  public FName EmptyMagazineHideBoneName;
  public USFTypes.FWeaponStateData EmptyMagazineWeaponState;
  public float PenaltySpread;
}

public class ASFWeap_Weaponless : ASFWeap_Mission
{
}

public class ASFWeapon_ETC_Explosive : ASFWeap_Projectile
{
}

public class ASFWeapon_Melee_PlayerZombieWalker : ASFWeap_Melee
{
}

public class ASFWeapon_PriWeapExigency : ASFWeap_Exigency
{
  public FName DefaultThirdPawnAnimName;
}

public class ASFWeaponAttachment : AActor
{
  public USkeletalMeshComponent WeaponSkelComponent;
  public USkeletalMeshComponent WeaponSkelComponentEx;
  public USkeletalMeshComponent WeaponSightComponent;
  public USkeletalMeshComponent WeaponAccessoryComponent;
  public List<UParticleSystemComponent> MuzzleFlashPSC;
  public List<UParticleSystemComponent> WeaponEffectPSC;
  public List<USFExplosionLight> MuzzleFlashLight;
  public List<FName> ShellOutSocket;
  public List<UParticleSystemComponent> ShellOutPSC;
  public UParticleSystemComponent ScopeReflectionEffectPSC;
  public bool bNeedAttachMuzzleFlash;
  public bool bNeedAttachShellOut;
  public bool bNeedAttachWeaponEffect;
  public bool bPendingAttach;
  public bool bForceSetup;
  public bool bForceShellOut;
  public bool bHideMeshWhenDied;
  public bool bDualWeapon;
  public FName AttachmentSocket;
  public FName ScopeReflectionSocket;
  public FName AccessorySocketName;
  public ASFPawn PawnOwner;
  public ASFWeapon WeaponOwner;
  public USkeletalMeshComponent OwnerMesh;
  public FName MagazineBoneName;
  public UAnimNodeSlot NodeSlotForPlay;
  public FName AnimNodeName;
}

public class ASFWeaponAttachment_DualWeapon : ASFWeaponAttachment
{
  public USkeletalMeshComponent WeaponSkelComponentDual;
}

public class ASFWeaponAttachment_Exigency : ASFWeaponAttachment
{
}

public class ASFWeaponAttachment_Mission : ASFWeaponAttachment
{
}

public class ASFWeaponAttachment_Projectile : ASFWeaponAttachment
{
  public FName HideBoneName;
}

public class ASFWeaponAttachment_Throw : ASFWeaponAttachment
{
}

public class ASFWeaponAttachment_ThrowingMelee : ASFWeaponAttachment_DualWeapon
{
  public FName HideBoneName;
}

public class ASFWeaponAttachment_Vehicle : ASFWeaponAttachment
{
}

public class ASFWeaponAttachment_Weaponless : ASFWeaponAttachment
{
}

public class ASFWeaponDischarger : ASFWeap_Bullet
{
  public bool bDischargingNow;
  public bool bPlayDischarging;
  public USoundCue CueWeaponFireEnd;
  public List<EWeaponState> ForceEndDischargeWeaponState;
}

public class ASFWeaponFlamer : ASFWeaponDischarger
{
  public class FsFlame
  {
    public USFParticleSystemComponent FlamePSC;
    public UParticleSystem FlameTemplate;
    public string FlameString;
    public FName SocketName;
  }

  public class FSFlameType
  {
    public EFlameType FlameType;
    public List<ASFWeaponFlamer.FsFlame> Flames;
  }

  public List<FSFlameType> FlameTypeArray;
  public string FlameThrowerAnimTree;
  public string FlameThrowerAnim;
  public List<string> FlameThrowerStringArray;
  public List<USFSkeletalMeshComponent> FlameThrowerSMCArray;
  public List<UAnimNodeAimOffset> FlameAimOffsetArray;
  public bool bFlameShowing;
  public FName FlameSocketName;
  public FName TorchSocketName;
  public UParticleSystem TorchEffect;
  public List<UParticleSystemComponent> TorchEffectPSCArray;
  public FVector CurAim;
  public FVector AimDiff;
  public FVector vPrevFlameDir;
  public int FlameRotSpeed;
  public int FlameYawSensitivity;
  public int FlamePitchSensitivity;
  public float MinAimLimit;
  public float MaxAimLimit;
  public float FlameRadius;
}

public class ASFWeaponMurderKnife_Exigency : ASFWeap_Exigency
{
}

public class USFWeaponRISBase : UObject
{
  public int SupportedFlags;
  public List<int> SupportFlagList;
  public ASFWeapon WeaponOwner;
  public bool bIsHasState;
  public bool bIsProcessForViewTarget;
  public bool bUsePreTestCommand;
  public bool bUsePostTestCommand;
}

public class USFWeaponRIS_SkelComponentBase : USFWeaponRISBase
{
  public USFSkeletalMeshComponent RISkelComponent;
  public UPhysicsAsset RISkelComponentPhysicsAsset;
  public FName RISocketName;
  public bool bIsAttachToSocket;
  public bool bAllowRISkelComponentScreenCenter;
  public bool bIsAttachToSocket3rd;
  public bool bIsParentAnim;
  public bool bAttachRISOnce;
  public bool bIsAttached;
  public bool bCheckMinMax;
  public FVector MaxScreenAlignDistance;
  public FVector MinScreenAlignDistance;
  public USkeletalMeshComponent RISkelComponent3rd;
  public UPhysicsAsset RISkelComponent3rdPhysicsAsset;
  public FName RISocketName3rd;
}

public class USFWeaponRIS_Accessory : USFWeaponRIS_SkelComponentBase
{
  public FName AccSocketName;
  public FName AccAnimNodeName;
  public USFAnimNodeSlotAccessory AccessoryAnimNode;
  public USFSkeletalMeshComponent AccessoryComponent;
}

public class USFWeaponRIS_AccessoryTest : USFWeaponRIS_SkelComponentBase
{
}

public class USFWeaponRIS_AimingBase : USFWeaponRIS_SkelComponentBase
{
  public int AimingStateNow;
  public float CurrentZoomFOV;
  public float ZoomInFOV;
  public float ZoomOutFOV;
  public UMaterialInstanceConstant SightCrosshairMIC;
  public bool bDefaultSightMeshVisible;
  public bool bEnableEnemyDetect;
  public bool bCalculateTargetDistance;
}

public class USFWeaponRIS_DotSight : USFWeaponRIS_AimingBase
{
  public bool bDefaultDotSightVisible;
}

public class USFWeaponRIS_ACOG : USFWeaponRIS_DotSight
{
  public FName DetectParameterName;
}

public class USFWeaponRIS_ActionCamo : USFWeaponRISBase
{
  public FName ActionStateName;
  public float CamoInfiniteTime;
}

public class USFWeaponRIS_AimPoint : USFWeaponRIS_DotSight
{
  public float EnemyDetectedDotSightScale;
}

public class USFWeaponRIS_EOTechSight : USFWeaponRIS_DotSight
{
}

public class USFWeaponRIS_SubWeapon : USFWeaponRIS_SkelComponentBase
{
  public List<UAnimSet> SubWeaponAnimSets;
  public List<UAnimSet> SubWeapon3rdAnimSets;
  public FName SubWeaponMuzzleFlashSocketName;
  public UParticleSystem SubWeaponMuzzleFlashPS;
  public USFParticleSystemComponent SubWeaponMuzzleFlashPSC;
  public UClass SubWeaponMuzzleFlashLightClass;
  public USFExplosionLight SubWeaponMuzzleFlashLight;
  public bool bIsActivated;
  public string SubWeaponAnimPreFix;
  public string OwnerWeaponAnimPreFix;
  public EWeaponFireType OldWeaponFireType;
  public EWeaponFireType SubWeaponFireType;
  public float SubWeaponFiringTime;
  public float OldWeaponFiringTime;
  public float SubWeaponFireBlendTime;
  public float OldWeaponFireBlendTime;
  public float SubWeaponReloadTime;
  public float OldWeaponReloadTime;
  public float SubWeaponReloadBlendTime;
  public float OldWeaponReloadBlendTime;
  public float LastShotTime;
  public float SwitchToSubWeaponTime;
  public float SwitchToOriginalTime;
  public int SubWeaponAmmoCount;
  public int OldWeaponAmmoCount;
  public int OldWeaponAmmoInMgz;
}

public class USFWeaponRIS_GrenadeLauncher : USFWeaponRIS_SubWeapon
{
  public UClass SubWeaponProjectiles;
  public UClass OldWeaponProjectiles;
}

public class USFWeaponRIS_LaserSightBase : USFWeaponRISBase
{
  public class FBeamSocketAlignment
  {
    public FName WeaponClassName;
    public int Yaw;
    public int Pitch;
    public int Roll;
    public float ZoomLength;
  }

  public USFSkeletalMeshComponent RISkelComponent;
  public FName LaserStartSocketName;
  public UParticleSystem LaserParticleTemplate;
  public UParticleSystem LaserHitPointParticleTemplate;
  public UParticleSystem EnemyDetectLaserParticleTemplate;
  public UParticleSystem EnemyDetectLaserHitPointParticleTemplate;
  public FName LaserTargetParameterName;
  public UParticleSystemComponent LaserParticleComponent;
  public UParticleSystemComponent LaserParticle3rdComponent;
  public UParticleSystemComponent LaserHitPointParticleComponent;
  public float LaserHitPointMinDistance;
  public float LaserHitPointMaxDistance;
  public float LaserHitPointScale;
  public float MaxDotVisibleDistance;
  public bool bUseSureFire;
  public bool bHasScope;
  public USpotLightComponent SureFireComponent;
  public FName SureFireSocketName;
  public UStaticMeshComponent SureFireComponent3rd;
  public float LaserParticleLength;
  public float LaserParticle3rdLength;
  public List<FBeamSocketAlignment> AlignmentInfo;
  public USkeletalMeshSocket LaserStartSocket;
  public int AlignIndex;
  public List<FRotator> OriginSocketRotation;
  public float OriginLaserZoomLength;
}

public class USFWeaponRIS_OpenDotSight : USFWeaponRIS_DotSight
{
}

public class USFWeaponRIS_Reflex : USFWeaponRIS_DotSight
{
  public FName GaugeBlendNodeName;
  public FName GaugeSocketName;
  public float ZoomingTime;
  public UAnimNodeBlend GaugeBlendNode;
  public USFSkeletalMeshComponent GaugeComponent;
  public USFSkeletalMeshComponent ReflexScopeComponent;
  public float GaugeMoveTime;
  public int GaugeStep;
  public List<float> LaserDistanceStep;
}

public class USFWeaponRIS_Reflex_RoseSkull : USFWeaponRIS_DotSight
{
  public float ZoomingTime;
}

public class USFWeaponRIS_Scope : USFWeaponRIS_AimingBase
{
  public ASFWeap_Bullet ScopeWeapon;
}

public class USFWeaponRIS_SilencerBase : USFWeaponRIS_SkelComponentBase
{
  public class FsMuzzleFlashEffect
  {
    public UParticleSystemComponent PSC;
    public USFExplosionLight Light;
    public bool PSCLoops;
    public FName Socket;
    public bool Attached;
  }

  public USoundCue SilenceFireSound;
  public List<USFTypes.FMuzzleFlash> MuzzleFlash1stViewDef;
  public List<USFTypes.FMuzzleFlash> MuzzleFlash3rdViewDef;
  public UParticleSystem SilencerTracerTemplateFriend;
  public UParticleSystem SilencerTracerTemplateFoe;
  public USFTypes.FGunTrailInfo[] SilencerTrailInfos = new USFTypes.FGunTrailInfo[3];
  public List<FsMuzzleFlashEffect> SilencerMuzzleFlash1stview;
  public List<FsMuzzleFlashEffect> SilencerMuzzleFlash3rdview;
  public bool AttachedMuzzleFlash1stview;
  public bool AttachedMuzzleFlash3rdview;
}

public class USFWeaponRIS_TacticalLight : USFWeaponRISBase
{
  public float LightRadian;
  public USpotLightComponent SpotLightComponent;
  public UParticleSystem LightHighBeamParticle3rdTemplate;
  public UParticleSystemComponent LightHighBeamParticle3rdComponent;
  public UStaticMeshComponent LightMesh3rdComponent;
  public float LightHighBeam3rdScale;
  public ULensFlareComponent LensFlareComp;
  public FName LightSocketName;
  public float fBrightMax;
  public float fBrightMin;
  public float fAngleMax;
  public float fAngleMin;
  public float fDistNear;
  public float fDistFar;
  public bool IgnoreHighBeamFriend;
  public bool bFlash1stOn;
  public bool bFlash3rdOn;
  public bool bIsAttached;
  public bool bIsAttachToSocket;
  public float LightURadian;
  public float LightUDistance;
  public float LightHighBeamDot;
  public float fCameraDotMax;
  public float fCameraDotMin;
  public float fUDistNear;
  public float fUDistFar;
  public FVector LightMeshScale;
  public FVector LightMesh3rdScale;
  public FVector Light3rdMeshScale;
  public UMaterialInstance LightMaterialInst;
  public float InSightPower;
  public float InSightDelay;
  public float OutSightDelay;
}

public class USFWeaponRIS_TacticalLight_Espionage : USFWeaponRIS_TacticalLight
{
}

public class USFWeaponRIS_TacticalLight_Horror : USFWeaponRIS_TacticalLight
{
}

public class USFWeaponRIS_TargetSeeker : USFWeaponRIS_ACOG
{
  public ASFPawn DetectedPawn;
  public ASFPawn_Player WeaponOwnerPawn;
  public float TargetingMaxDistance;
  public float MaxOutLineDistance;
  public float MinOutLineDistance;
  public float MaxOutLineWidth;
  public float MinOutLineWidth;
  public bool bActiveOutLine;
}

public class USFWeaponRIS_WeaponTag : USFWeaponRIS_SkelComponentBase
{
  public USFGFxMoviePlayer_WeaponNameTag WeaponTagMoviePlayer;
}

public class USFWeapoRIS_SpecialMagazine : USFWeaponRISBase
{
}

public class USFWeapSetUsedCountEventData : USFWeaponEventData
{
}

public class USFWelcomeBackEventData : USFSpecialKillEventData
{
}

public class ASFWillowWhisp : ASFReplicatedEmitter
{
  public FVector[] WayPoints = new FVector[15];
  public int NumPoints;
  public int Position;
}

public class USFWinningMatchEventData : USFPlayerLogEventData
{
}

public class USFWinningRoundCounterEventData : USFPlayerLogEventData
{
}

public class USFWinningRoundEventData : USFPlayerLogEventData
{
}

public class ASFWireEntanglementActor : ASFObstaclesActor
{
  public class FsEffectOn
  {
    public float LastTime;
    public ASFPawn TargetPawn;
  }

  public bool bDamage;
  public bool bDamageSameTeam;
  public bool bSlowDown;
  public bool bSlowDownSameTeam;
  public float DamageCheckTime;
  public int DamagePerSecound;
  public UClass DamageType;
  public float SlowDownPct;
  public float TakeDamagebyWreakedDamage;
  public List<UMaterialInstanceConstant> DamageActivatedMaterials;
  public byte nDamageActivated;
  public List<FsEffectOn> EffectiveTargetList;
  public float OldEffectiveTime;
}

public class USFZombieAggroSystem : USFAggroSystem
{
  public List<AActor> ProjectileAggroList;
}

public class ASFZombieBarricadeActor : ASFBarricadeActor
{
}

public class ASFZombieGame : ASFSurvivalGame
{
}

public class ASFZombieGameReplicationInfo : ASFSurvivalGameReplicationInfo
{
  public class FSGameAggroMultiplier
  {
    public int EarnedMoney;
    public int Ratio;
  }

  public List<FSGameAggroMultiplier> GameAggroMultiplierArray;
  public int AllPlayerEarnedMoney;
  public float GameAggroMultiplier;
}

public class USFZombieGameScoreBase : USFGameScore
{
  public List<USFTypes.FAIPawnScore> PawnClassBasis;
  public float SCORE_WaveEnd;
  public float SCORE_BossClear;
  public float SCORE_WaveEndTeam;
  public float SCORE_BossClearTeam;
}

public class ASFZombieHideSeekGame : ASFTeamGameInfo
{
  public class FFeverWeaponGrade
  {
    public int WeaponMaxKill;
    public List<int> WeaponID;
  }

  public string DefaultZombiePlayerClassName;
  public int KillFailedDamageForHuman;
  public int AttackHealthForZombie;
  public int ZombieTimerDamage;
  public int ZombieTimerDamageDuration;
  public int PrevZombieDamageTime;
  public float FeverTimeGroundSpeedRate;
  public float FeverTimeZombieHealthRatio;
  public int FeverTimeZombieHealth;
  public int ZombieFeverTimeBonusHealth;
  public int ZombieAIKillPoint;
  public int ZombiePlayerKillPoint;
  public List<FFeverWeaponGrade> FeverWeaponGradeList;
}

public class ASFZombieHideSeekGameReplicationInfo : ASFGameReplicationInfo
{
  public int FeverTimeLevel;
  public int CountDownStartTime;
  public int FeverTimeDuration;
  public int FeverTimeCountDown;
  public int FeverMessageCnt;
}

public class USFZombieHideSeekGameScore : USFGameScore
{
}

public class ASFZombieHideSeekHUD : ASFHUD
{
  public List<string> FeverTimeTextList;
}

public class ASFZombieHideSeekPlayerController : ASFPlayerController
{
  public AActor TargetZombie;
  public float KillTimeMax;
  public float KillTimeCurrent;
  public bool IsInteractionUI;
  public bool bOldPressingUsedKey;
  public bool IsBeginInteraction;
  public float KillingZombieGaugeRatio;
  public float CurrentTickTime;
  public float KillingGaugeRatio;
  public float InjectionTime;
  public float AddHP;
  public float EnableZombieInteractionDist;
  public float EnableHumanInteractionDist;
  public float InteractionCancelCounter;
}

public class ASFZombieHUD : ASFSurvivalHUD
{
}

public class USFZombieKillDeathMessage : USFLocalMessage
{
}

public class ASFZombiePlayerController : ASFSurvivalPlayerController
{
  public int PurchasedPistolID;
  public float HealthPackPurchasedTime;
  public float HealthPackDelayTime;
  public string HealthPackFailedMessage;
  public int[] ZombieKillArrayLog = new int[6];
}

public class ASFZombiePlayerReplicationInfo : ASFSurvivalPlayerReplicationInfo
{
  public int PerformWeaponPurchaseCount;
  public int PerformHealthPurchaseCount;
  public int ZombieGameKillCount;
  public List<FName> ZombieMultiKillTypeArray;
  public bool bIsZombieInteraction;
}

public class ASFZombieSurvivalGame : ASFZombieGame
{
}

public class USFZombieSurvivalGameScore : USFZombieGameScoreBase
{
}

public class ASFZombieSurvivalGameTwo : ASFZombieSurvivalGame
{
}

public class USFZombieTypeJoin : UObject
{
  public class FZombieTypeJoin
  {
    public EAITypes ZombieType;
    public List<EAITypes> IncludeTypes;
  }

  public List<FZombieTypeJoin> ZombieTypeJoinArray;
}

public class AStaticMeshActorForBlastingGame : AActor
{
  public UMaterialInterface Material_First;
  public UMaterialInterface Material_Second;
  public UDynamicLightEnvironmentComponent LightEnvironment;
  public UStaticMeshComponent StaticMeshComponent;
  public UStaticMeshComponent BreakedMeshComponent;
  public byte bDrawOutline;
  public UStaticMesh NewStaticMesh;
}

public class AStaticMeshByDamage : AStaticMeshActor
{
  public int DamageThreshold;
  public UParticleSystem ParticleTemplate;
  public float RespawnDelay;
  public int nLimitEmitter;
  public int CurrentDamage;
  public int currentEmitterIndex;
  public List<ASFEmitterSpawnable> arrSpawnedEmitter;
}

public class UUtilBasedAICmdMetaDataPacket : UObject
{
  public float LastActivationTime;
  public int NumberOfActivations;
  public UClass CommandClass;
}

