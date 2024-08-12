/*===========================================================================
 *  This file was automatically generated. DO NOT modify!
===========================================================================*/
namespace ue3;

public enum EShakeParam
{
  ESP_OffsetRandom,
  ESP_OffsetZero,
  ESP_MAX,
}

public enum EConformType
{
  CFM_NavMesh,
  CFM_BSP,
  CFM_World,
  CFM_None,
  CFM_MAX,
}

public enum ECrowdBehaviorEvent
{
  CBE_None,
  CBE_Spawn,
  CBE_Random,
  CBE_SeePlayer,
  CBE_EncounterAgent,
  CBE_TakeDamage,
  CBE_GroupWaiting,
  CBE_Uneasy,
  CBE_Alert,
  CBE_Panic,
  CBE_MAX,
}

public enum ERecoilStart
{
  ERS_Zero,
  ERS_Random,
  ERS_MAX,
}

public enum ECameraViewportTypes
{
  CVT_16to9_Full,
  CVT_16to9_VertSplit,
  CVT_16to9_HorizSplit,
  CVT_4to3_Full,
  CVT_4to3_HorizSplit,
  CVT_4to3_VertSplit,
  CVT_MAX,
}

public enum EZoneType
{
  ZoneType_Button,
  ZoneType_Joystick,
  ZoneType_Trackball,
  ZoneType_Tilt,
  ZoneType_MAX,
}

public enum EZoneState
{
  ZoneState_Inactive,
  ZoneState_Activating,
  ZoneState_Active,
  ZoneState_Deactivating,
  ZoneState_MAX,
}

public class AGameCrowdInteractionPoint : AActor
{
  public bool bIsEnabled;
  public UCylinderComponent CylinderComponent;
}

public class UGameTypes : UObject
{
  public class FScreenShakeAnimStruct
  {
    public UCameraAnim Anim;
    public bool bUseDirectionalAnimVariants;
    public UCameraAnim Anim_Left;
    public UCameraAnim Anim_Right;
    public UCameraAnim Anim_Rear;
    public float AnimPlayRate;
    public float AnimScale;
    public float AnimBlendInTime;
    public float AnimBlendOutTime;
    public bool bRandomSegment;
    public float RandomSegmentDuration;
    public bool bSingleInstance;
  }

  public class FShakeParams
  {
    public EShakeParam X;
    public EShakeParam Y;
    public EShakeParam Z;
    public byte Padding;
  }

  public class FScreenShakeStruct
  {
    public float TimeToGo;
    public float TimeDuration;
    public UObject.FVector RotAmplitude = new();
    public UObject.FVector RotFrequency = new();
    public UObject.FVector RotSinOffset = new();
    public UGameTypes.FShakeParams RotParam = new();
    public UObject.FVector LocAmplitude = new();
    public UObject.FVector LocFrequency = new();
    public UObject.FVector LocSinOffset = new();
    public UGameTypes.FShakeParams LocParam = new();
    public float FOVAmplitude;
    public float FOVFrequency;
    public float FOVSinOffset;
    public EShakeParam FOVParam;
    public FName ShakeName;
    public bool bOverrideTargetingDampening;
    public float TargetingDampening;
  }

  public class FTakeHitInfo
  {
    public UObject.FVector HitLocation = new();
    public UObject.FVector Momentum = new();
    public UClass DamageType;
    public APawn InstigatedBy;
    public byte HitBoneIndex;
    public UPhysicalMaterial PhysicalMaterial;
    public float Damage;
    public UObject.FVector RadialDamageOrigin = new();
  }

  public class FGameSpecialMoveInfo
  {
    public FName SpecialMoveName;
    public UClass SpecialMoveClass;
    public UGameSpecialMove SpecialMoveInstance;
  }

  public class FSpecialMoveStruct
  {
    public FName SpecialMoveName;
    public AGamePawn InteractionPawn;
    public AActor InteractionActor;
    public int Flags;
  }

  public class FAICmdHistoryItem
  {
    public UClass CmdClass;
    public float TimeStamp;
    public string VerboseString;
  }

  public class FNearbyDynamicItem
  {
    public AActor Dynamic;
  }

  public class FCrowdSpawnerPlayerInfo
  {
    public UObject.FVector ViewLocation = new();
    public UObject.FRotator ViewRotation = new();
    public UObject.FVector PredictLocation = new();
    public APlayerController PC;
  }

  public class FAgentArchetypeInfo
  {
    public UObject AgentArchetype;
    public float FrequencyModifier;
    public int MaxAllowed;
    public int CurrSpawned;
    public List<UObject> GroupMembers;
  }

  public class FCrowdSpawnInfoItem
  {
    public USeqAct_GameCrowdPopulationManagerToggle SeqSpawner;
    public bool bSpawningActive;
    public float SpawnRate;
    public int SpawnNum;
    public float Remainder;
    public List<AGameCrowdAgent> ActiveAgents;
    public List<UGameTypes.FAgentArchetypeInfo> AgentArchetypes;
    public float AgentFrequencySum;
    public float MaxSpawnDist;
    public float MaxSpawnDistSq;
    public float MinBehindSpawnDist;
    public float MinBehindSpawnDistSq;
    public float AgentWarmupTime;
    public bool bForceObstacleChecking;
    public bool bForceNavMeshPathing;
    public bool bEnableCrowdLightEnvironment;
    public bool bCastShadows;
    public ULightComponent.FLightingChannelContainer AgentLightingChannel = new();
    public int NumAgentsToTickPerFrame;
    public int LastAgentTickedIndex;
    public List<AGameCrowdDestination> PotentialSpawnPoints;
    public float SpawnPrioritizationInterval;
    public int PrioritizationIndex;
    public int PrioritizationUpdateIndex;
    public List<AGameCrowdDestination> PrioritizedSpawnPoints;
    public float PlayerPositionPredictionTime;
  }

}

public class AGameCrowdDestination : AGameCrowdInteractionPoint
{
  public FPointer VfTable_IEditorLinkSelectionInterface = new();
  public bool bKillWhenReached;
  public bool bAllowAsPreviousDestination;
  public bool bAvoidWhenPanicked;
  public bool bSkipBehaviorIfPanicked;
  public bool bFleeDestination;
  public bool bMustReachExactly;
  public bool bHasRestrictions;
  public bool bAllowsSpawning;
  public bool bAllowCloudSpawning;
  public bool bAllowVisibleSpawning;
  public bool bLineSpawner;
  public bool bSpawnAtEdge;
  public bool bSoftPerimeter;
  public bool bIsVisible;
  public bool bWillBeVisible;
  public bool bCanSpawnHereNow;
  public bool bIsBeyondSpawnDistance;
  public bool bAdjacentToVisibleNode;
  public bool bHasNavigationMesh;
  public List<AGameCrowdDestination> NextDestinations;
  public AGameCrowdDestinationQueuePoint QueueHead;
  public int Capacity;
  public float Frequency;
  public int CustomerCount;
  public List<UClass> SupportedAgentClasses;
  public List<UObject> SupportedArchetypes;
  public List<UClass> RestrictedAgentClasses;
  public List<UObject> RestrictedArchetypes;
  public float ExactReachTolerance;
  public FName InteractionTag;
  public float InteractionDelay;
  public List<AGameCrowdAgent.FBehaviorEntry> ReachedBehaviors;
  public AGameCrowdAgent AgentEnRoute;
  public float Priority;
  public float LastSpawnTime;
  public AGameCrowdPopulationManager MyPopMgr;
}

public class ADynamicGameCrowdDestination : AGameCrowdDestination
{
}

public class UGameAICommand : UAICommandBase
{
  public UGameAICommand ChildCommand;
  public FName ChildStatus;
  public AGameAIController GameAIOwner;
  public FName Status;
  public bool bAllowNewSameClassInstance;
  public bool bReplaceActiveSameClassInstance;
  public bool bAborted;
  public bool bIgnoreNotifies;
  public bool bIgnoreStepAside;
  public bool bPendingPop;
}

public class UGameAICmd_Hover_MoveToGoal : UGameAICommand
{
  public AActor Path;
  public AActor Find;
  public AActor Goal;
  public float Radius;
  public bool bWasFiring;
  public float DesiredHoverHeight;
  public float CurrentHoverHeight;
  public float SubGoalReachDist;
  public float GoalDistance;
  public FVector MoveVectDest = new();
  public UReachSpec CurrentSpec;
}

public class UGameAICmd_Hover_MoveToGoal_Mesh : UGameAICommand
{
  public AActor Find;
  public float Radius;
  public bool bWasFiring;
  public bool bFinalApproach;
  public bool bFallbackMoveToMesh;
  public float DesiredHoverHeight;
  public float CurrentHoverHeight;
  public float SubGoalReachDist;
  public float GoalDistance;
  public FVector IntermediatePoint = new();
  public FVector LastMovePoint = new();
  public int NumMovePointFails;
  public int MaxMovePointFails;
  public FVector FallbackDest = new();
  public AActor MoveToActor;
  public AActor.FBasedPosition LastMoveTargetPathLocation = new();
  public FVector InitialFinalDestination = new();
}

public class AGameAIController : AAIController
{
  public UGameAICommand CommandList;
  public bool bHasRunawayCommandList;
  public bool bAILogging;
  public bool bAILogToWindow;
  public bool bFlushAILogEachLine;
  public bool bMapBasedLogName;
  public bool bAIDrawDebug;
  public bool bAIBroken;
  public AFileLog AILogFile;
  public float DebugTextMaxLen;
  public List<UGameTypes.FAICmdHistoryItem> CommandHistory;
  public int CommandHistoryNum;
  public List<FName> AILogFilter;
  public string DemoActionString;
}

public class UGameCameraBase : UObject
{
  public AGamePlayerCamera PlayerCamera;
  public bool bResetCameraInterpolation;
}

public class AGameCameraBlockingVolume : ABlockingVolume
{
}

public class UGameCrowd_ListOfAgents : UObject
{
  public List<UGameTypes.FAgentArchetypeInfo> ListOfAgents;
}

public class UGameCrowdAgentBehavior : UObject
{
  public ECrowdBehaviorEvent MyEventType;
  public ECrowdBehaviorEvent ViralBehaviorEvent;
  public float DurationOfBehavior;
  public float TimeUntilStopBehavior;
  public bool bIdleBehavior;
  public bool bFaceActionTargetFirst;
  public bool bIsViralBehavior;
  public bool bPassOnIsViralBehaviorFlag;
  public AActor ActionTarget;
  public float MaxPlayerDistance;
  public float ViralRadius;
  public float DurationBeforeBecomesViral;
  public float TimeToBecomeViral;
  public float DurationOfViralBehaviorPropagation;
  public float TimeToStopPropagatingViralBehavior;
  public AGameCrowdAgent MyAgent;
  public FColor DebugBehaviorColor = new();
}

public class AGameCrowdAgent : ACrowdAgentBase
{
  public class FAvoidOtherSampleItem
  {
    public int RotOffset;
    public byte NumMagSamples;
    public bool bFallbackOnly;
  }

  public class FRecentInteraction
  {
    public FName InteractionTag;
    public float InteractionDelay;
  }

  public class FBehaviorEntry
  {
    public UGameCrowdAgentBehavior BehaviorArchetype;
    public AActor LookAtActor;
    public float BehaviorFrequency;
    public bool bNeverRepeat;
    public bool bHasBeenUsed;
    public bool bCanBeUsed;
  }

  public FPointer VfTable_IInterface_RVO = new();
  public UGameCrowdGroup MyGroup;
  public FVector PreferredVelocity = new();
  public FVector PendingVelocity = new();
  public AGameCrowdDestination CurrentDestination;
  public AGameCrowdDestination BehaviorDestination;
  public AGameCrowdDestination PreviousDestination;
  public float InterpZTranslation;
  public int Health;
  public float DeadBodyDuration;
  public UDynamicLightEnvironmentComponent LightEnvironment;
  public int ConformTraceFrameCount;
  public List<UGameTypes.FNearbyDynamicItem> NearbyDynamics;
  public bool bUniformScale;
  public bool bCheckForObstacles;
  public bool bUseNavMeshPathing;
  public bool bWantsSeePlayerNotification;
  public bool bAllowPitching;
  public bool bHitObstacle;
  public bool bBadHitNormal;
  public bool bSimulateThisTick;
  public bool bPotentialEncounter;
  public bool bIsPanicked;
  public bool bWantsGroupIdle;
  public bool bPreferVisibleDestination;
  public bool bPreferVisibleDestinationOnSpawn;
  public bool bHasNotifiedSpawner;
  public bool bIsInSpawnPool;
  public bool bPaused;
  public EConformType ConformType;
  public float ConformTraceDist;
  public int ConformTraceInterval;
  public int CurrentConformTraceInterval;
  public float LastGroundZ;
  public float AwareRadius;
  public float AvoidOtherRadius;
  public List<FAvoidOtherSampleItem> AvoidOtherSampleList;
  public float PENALTY_COEFF_ANGLETOGOAL;
  public float PENALTY_COEFF_ANGLETOVEL;
  public float PENALTY_COEFF_MAG;
  public float MIN_PENALTY_THRESHOLD;
  public float LastProgressTime;
  public float LastFallbackActiveTime;
  public float MaxPathLaneValue;
  public float CurrentPathLaneValue;
  public int ExtraPathCost;
  public float RotateToTargetSpeed;
  public float MaxYawRate;
  public FVector MeshMinScale3D = new();
  public FVector MeshMaxScale3D = new();
  public float EyeZOffset;
  public float ProximityLODDist;
  public float VisibleProximityLODDist;
  public FVector LastKnownGoodPosition = new();
  public float GroundOffset;
  public FVector IntermediatePoint = new();
  public FVector SearchExtent = new();
  public UClass NavigationHandleClass;
  public UNavigationHandle NavigationHandle;
  public int ObstacleCheckCount;
  public float WalkableFloorZ;
  public float LastPathingAttempt;
  public float LastUpdateTime;
  public float NotVisibleLifeSpan;
  public AGameCrowdAgent MyArchetype;
  public float MaxWalkingSpeed;
  public float MaxRunningSpeed;
  public float MaxSpeed;
  public List<FRecentInteraction> RecentInteractions;
  public float BeaconMaxDist;
  public FVector BeaconOffset = new();
  public UTexture2D BeaconTexture;
  public FLinearColor BeaconColor = new();
  public USoundCue AmbientSoundCue;
  public UAudioComponent AmbientSoundComponent;
  public UGameCrowdAgentBehavior CurrentBehavior;
  public float CurrentBehaviorActivationTime;
  public List<FBehaviorEntry> EncounterAgentBehaviors;
  public List<FBehaviorEntry> SeePlayerBehaviors;
  public float MaxSeePlayerDistSq;
  public float SeePlayerInterval;
  public List<FBehaviorEntry> SpawnBehaviors;
  public List<FBehaviorEntry> UneasyBehaviors;
  public List<FBehaviorEntry> AlertBehaviors;
  public List<FBehaviorEntry> PanicBehaviors;
  public List<FBehaviorEntry> RandomBehaviors;
  public List<FBehaviorEntry> TakeDamageBehaviors;
  public float RandomBehaviorInterval;
  public float ForceUpdateTime;
  public float ReachThreshold;
  public List<FBehaviorEntry> GroupWaitingBehaviors;
  public float DesiredGroupRadius;
  public float DesiredGroupRadiusSq;
  public float MaxLOSLifeDistanceSq;
  public FScriptInterface MySpawner;
  public FVector SpawnOffset = new();
  public float InitialLastRenderTime;
  public FColor DebugAgentColor = new();
  public AGameCrowdDestination DebugSpawnDest;
}

public class AGameCrowdAgentSkeletal : AGameCrowdAgent
{
  public class FGameCrowdAttachmentInfo
  {
    public UStaticMesh StaticMesh;
    public float Chance;
    public UObject.FVector Scale3D = new();
  }

  public class FGameCrowdAttachmentList
  {
    public FName SocketName;
    public List<AGameCrowdAgentSkeletal.FGameCrowdAttachmentInfo> List;
  }

  public USkeletalMeshComponent SkeletalMeshComponent;
  public UAnimNodeBlend SpeedBlendNode;
  public UAnimNodeSlot FullBodySlot;
  public UAnimNodeSequence ActionSeqNode;
  public UAnimNodeSequence WalkSeqNode;
  public UAnimNodeSequence RunSeqNode;
  public UAnimTree AgentTree;
  public List<FName> WalkAnimNames;
  public List<FName> RunAnimNames;
  public List<FName> IdleAnimNames;
  public List<FName> DeathAnimNames;
  public float SpeedBlendStart;
  public float SpeedBlendEnd;
  public float AnimVelRate;
  public float MaxSpeedBlendChangeSpeed;
  public FName MoveSyncGroupName;
  public List<FGameCrowdAttachmentList> Attachments;
  public float MaxTargetAcquireTime;
  public bool bUseRootMotionVelocity;
  public bool bIsPlayingIdleAnimation;
  public bool bIsPlayingDeathAnimation;
  public bool bAnimateThisTick;
  public float MaxAnimationDistance;
  public float MaxAnimationDistanceSq;
}

public class AGameCrowdAgentSM : AGameCrowdAgent
{
  public UStaticMeshComponent Mesh;
  public UMaterialInstanceConstant MeshColor;
}

public class UGameCrowdBehavior_PlayAnimation : UGameCrowdAgentBehavior
{
  public List<FName> AnimationList;
  public float BlendInTime;
  public float BlendOutTime;
  public bool bUseRootMotion;
  public bool bLookAtPlayer;
  public bool bLooping;
  public bool bBlendBetweenAnims;
  public AActor CustomActionTarget;
  public int LoopIndex;
  public float LoopTime;
  public USeqAct_PlayAgentAnimation AnimSequence;
  public int AnimationIndex;
}

public class UGameCrowdBehavior_RunFromPanic : UGameCrowdAgentBehavior
{
  public AActor PanicFocus;
}

public class UGameCrowdBehavior_WaitForGroup : UGameCrowdAgentBehavior
{
}

public class UGameCrowdBehavior_WaitInQueue : UGameCrowdAgentBehavior
{
  public bool bStoppingBehavior;
  public AGameCrowdDestinationQueuePoint QueuePosition;
}

public class AGameCrowdBehaviorPoint : AGameCrowdInteractionPoint
{
  public float RadiusOfBehaviorEvent;
  public float DurationOfBehaviorEvent;
  public ECrowdBehaviorEvent EventType;
  public bool bRequireLOS;
  public AActor Initiator;
}

public class AGameCrowdDestinationQueuePoint : AGameCrowdInteractionPoint
{
  public AGameCrowdDestinationQueuePoint NextQueuePosition;
  public AGameCrowdInteractionPoint PreviousQueuePosition;
  public AGameCrowdAgent QueuedAgent;
  public AGameCrowdDestination QueueDestination;
  public bool bClearingQueue;
  public bool bPendingAdvance;
  public float AverageReactionTime;
  public UClass QueueBehaviorClass;
}

public class UGameCrowdGroup : UObject
{
  public List<AGameCrowdAgent> Members;
}

public class AGameCrowdInfoVolume : AVolume
{
  public List<AGameCrowdDestination> PotentialSpawnPoints;
}

public class AGameCrowdInteractionDestination : AGameCrowdDestination
{
}

public class AGameCrowdPopulationManager : ACrowdPopulationManagerBase
{
  public FPointer VfTable_IInterface_NavigationHandle = new();
  public UGameTypes.FCrowdSpawnInfoItem CloudSpawnInfo = new();
  public List<UGameTypes.FCrowdSpawnInfoItem> ScriptedSpawnInfo;
  public AGameCrowdInfoVolume ActiveCrowdInfoVolume;
  public List<AGameCrowdDestination> GlobalPotentialSpawnPoints;
  public float SplitScreenNumReduction;
  public float PlayerPositionPredictionTime;
  public float HeadVisibilityOffset;
  public UClass NavigationHandleClass;
  public UNavigationHandle NavigationHandle;
  public AGameCrowdAgent QueryingAgent;
  public List<UGameTypes.FCrowdSpawnerPlayerInfo> PlayerInfo;
  public float LastPlayerInfoUpdateTime;
  public bool bDebugSpawns;
  public bool bPauseCrowd;
}

public class AGameCrowdReplicationActor : AActor
{
  public USeqAct_GameCrowdSpawner Spawner;
  public bool bSpawningActive;
  public int DestroyAllCount;
}

public class UGameCrowdSpawnerInterface : UInterface
{
}

public class UGameCrowdSpawnInterface : UInterface
{
}

public class AGameCrowdSpawnRelativeActor : AActor
{
}

public class UGameDamageType : UDamageType
{
  public UMaterialInterface MI_DamageOverlay;
  public USoundCue ExtraSoundToPlayWhenDamaged;
  public bool bEnvironmentalDamage;
  public bool bHighKickDeathAnimation;
  public bool bForceRagdollDeath;
  public bool bSuppressImpactFX;
  public bool bSuppressBloodDecals;
  public bool bSuppressPlayExplosiveRadialDamageEffects;
  public bool bAllowHeadShotGib;
  public float DistFromHitLocToGib;
  public UCanvas.FCanvasIcon KilledByIcon = new();
  public UCanvas.FCanvasIcon HeadshotIcon = new();
  public float IconScale;
}

public class UGameDecal : UDecalComponent
{
  public UMaterialInstanceTimeVarying MITV_Decal;
  public APawn Instigator;
}

public class AGameDecalManager : ADecalManager
{
  public float MinDecalDistanceSq;
}

public class UGameDestinationConnRenderingComponent : UPrimitiveComponent
{
}

public class UGameExplosion : UObject
{
  public bool bDirectionalExplosion;
  public bool bDamageNeverBlocked;
  public bool bAllowTeammateCringes;
  public bool bFullDamageToAttachee;
  public bool bAttachExplosionEmitterToAttachee;
  public bool bCausesFracture;
  public bool bAllowPerMaterialFX;
  public bool bParticleSystemIsBeingOverriddenDontUsePhysMatVersion;
  public bool bUseMapSpecificValues;
  public bool bUseOverlapCheck;
  public bool bOrientCameraShakeTowardsEpicenter;
  public bool bAutoControllerVibration;
  public bool bUsingBBLocationWhenExplode;
  public float DirectionalExplosionAngleDeg;
  public float DamageDelay;
  public float Damage;
  public float DamageRadius;
  public float DamageFalloffExponent;
  public AActor ActorToIgnoreForDamage;
  public UClass ActorClassToIgnoreForDamage;
  public UClass ActorClassToIgnoreForKnockdownsAndCringes;
  public UClass MyDamageType;
  public float KnockDownRadius;
  public float KnockDownStrength;
  public float CringeRadius;
  public FVector2D CringeDuration = new();
  public float MomentumTransferScale;
  public UParticleSystem ParticleEmitterTemplate;
  public UParticleSystem ExtraParticleEmitterTemplate;
  public float ExplosionEmitterScale;
  public AActor HitActor;
  public FVector HitLocation = new();
  public FVector HitNormal = new();
  public USoundCue ExplosionSound;
  public UPointLightComponent ExploLight;
  public float ExploLightFadeOutTime;
  public URadialBlurComponent ExploRadialBlur;
  public float ExploRadialBlurFadeOutTime;
  public float ExploRadialBlurMaxBlur;
  public float FractureMeshRadius;
  public float FracturePartVel;
  public UCameraShake CamShake;
  public UCameraShake CamShake_Left;
  public UCameraShake CamShake_Right;
  public UCameraShake CamShake_Rear;
  public float CamShakeInnerRadius;
  public float CamShakeOuterRadius;
  public float CamShakeFalloff;
  public UClass CameraLensEffect;
  public float CameraLensEffectRadius;
}

public class AGameExplosionActor : AActor
{
  public bool bHasExploded;
  public bool bActiveReloadBonusActive;
  public bool bDrawDebug;
  public UPointLightComponent ExplosionLight;
  public float LightFadeTime;
  public float LightFadeTimeRemaining;
  public float LightInitialBrightness;
  public URadialBlurComponent ExplosionRadialBlur;
  public float RadialBlurFadeTime;
  public float RadialBlurFadeTimeRemaining;
  public float RadialBlurMaxBlurAmount;
  public UGameExplosion ExplosionTemplate;
  public URB_RadialImpulseComponent RadialImpulseComponent;
  public AController InstigatorController;
  public AActor HitActorFromPhysMaterialTrace;
  public FVector HitLocationFromPhysMaterialTrace = new();
  public AActor Attachee;
  public AController AttacheeController;
  public float DirectionalExplosionMinDot;
  public FVector ExplosionDirection = new();
  public float ExtraHowLongToLive;
}

public class UGameExplosionContent : UObject
{
  public bool bAutoControllerVibration;
  public bool bOrientCameraShakeTowardsEpicenter;
  public USoundCue ExplosionSound;
  public UCameraShake CamShake;
  public UCameraShake CamShake_Left;
  public UCameraShake CamShake_Right;
  public UCameraShake CamShake_Rear;
  public float CamShakeInnerRadius;
  public float CamShakeOuterRadius;
  public float CamShakeFalloff;
  public UClass CameraLensEffect;
  public float CameraLensEffectRadius;
  public UPointLightComponent ExploLight;
  public float ExploLightFadeOutTime;
  public URadialBlurComponent ExploRadialBlur;
  public float ExploRadialBlurFadeOutTime;
  public float ExploRadialBlurMaxBlur;
  public UParticleSystem ParticleEmitterTemplate;
  public AFogVolumeSphericalDensityInfo FogVolumeArchetype;
}

public class UGameFixedCamera : UGameCameraBase
{
  public float DefaultFOV;
}

public class AGameHUD : AHUD
{
}

public class AGameKActorSpawnableEffect : AKActor
{
}

public class AGameParticleEventManager : AParticleEventManager
{
}

public class AGamePawn : APawn
{
  public bool bLastHitWasHeadShot;
  public bool bRespondToExplosions;
}

public class AGamePlayerCamera : ACamera
{
  public UGameCameraBase ThirdPersonCam;
  public UClass ThirdPersonCameraClass;
  public UGameCameraBase FixedCam;
  public UClass FixedCameraClass;
  public UGameCameraBase CurrentCamera;
  public bool bUseForcedCamFOV;
  public bool bInterpolateCamChanges;
  public bool bResetInterp;
  public float ForcedCamFOV;
  public AActor LastViewTarget;
  public float SplitScreenShakeScale;
  public AActor LastTargetBase;
  public FMatrix LastTargetBaseTM = new();
}

public class AGamePlayerController : APlayerController
{
  public bool bWarnCrowdMembers;
  public bool bDebugCrowdAwareness;
  public bool bIsWarmupPaused;
  public float AgentAwareRadius;
  public FName CurrentSoundMode;
}

public class UGamePlayerInput : UPlayerInput
{
}

public class AGameProjectile : AProjectile
{
}

public class UGameSkelCtrl_Recoil : USkelControlBase
{
  public class FRecoilParams
  {
    public ERecoilStart X;
    public ERecoilStart Y;
    public ERecoilStart Z;
    public byte Padding;
  }

  public class FRecoilDef
  {
    public float TimeToGo;
    public float TimeDuration;
    public UObject.FVector RotAmplitude = new();
    public UObject.FVector RotFrequency = new();
    public UObject.FVector RotSinOffset = new();
    public UGameSkelCtrl_Recoil.FRecoilParams RotParams = new();
    public UObject.FRotator RotOffset = new();
    public UObject.FVector LocAmplitude = new();
    public UObject.FVector LocFrequency = new();
    public UObject.FVector LocSinOffset = new();
    public UGameSkelCtrl_Recoil.FRecoilParams LocParams = new();
    public UObject.FVector LocOffset = new();
  }

  public bool bBoneSpaceRecoil;
  public bool bPlayRecoil;
  public bool bOldPlayRecoil;
  public bool bApplyControl;
  public FRecoilDef Recoil = new();
  public FVector2D Aim = new();
}

public class UGameSpecialMove : UObject
{
  public AGamePawn PawnOwner;
  public FName Handle;
  public float LastCanDoSpecialMoveTime;
  public bool bLastCanDoSpecialMove;
  public bool bReachPreciseDestination;
  public bool bReachedPreciseDestination;
  public bool bReachPreciseRotation;
  public bool bReachedPreciseRotation;
  public bool bForcePrecisePosition;
  public FVector PreciseDestination = new();
  public AActor PreciseDestBase;
  public FVector PreciseDestRelOffset = new();
  public float PreciseRotationInterpolationTime;
  public FRotator PreciseRotation = new();
}

public class UGameThirdPersonCamera : UGameCameraBase
{
  public class FCamFocusPointParams
  {
    public AActor FocusActor;
    public FName FocusBoneName;
    public UObject.FVector FocusWorldLoc = new();
    public float CameraFOV;
    public UObject.FVector2D InterpSpeedRange = new();
    public UObject.FVector2D InFocusFOV = new();
    public bool bAlwaysFocus;
    public bool bAdjustCamera;
    public bool bIgnoreTrace;
    public float FocusPitchOffsetDeg;
  }

  public class FPenetrationAvoidanceFeeler
  {
    public UObject.FRotator AdjustmentRot = new();
    public float WorldWeight;
    public float PawnWeight;
    public UObject.FVector Extent = new();
  }

  public FVector LastActualCameraOrigin = new();
  public float WorstLocBlockedPct;
  public float WorstLocPenetrationExtentScale;
  public float PenetrationBlendOutTime;
  public float PenetrationBlendInTime;
  public float PenetrationBlockedPct;
  public float PenetrationExtentScale;
  public FVector LastActualOriginOffset = new();
  public FRotator LastActualCameraOriginRot = new();
  public float OriginOffsetInterpSpeed;
  public FVector LastViewOffset = new();
  public float LastCamFOV;
  public UGameThirdPersonCameraMode ThirdPersonCamDefault;
  public UClass ThirdPersonCamDefaultClass;
  public UGameThirdPersonCameraMode CurrentCamMode;
  public float LastHeightAdjustment;
  public float LastPitchAdjustment;
  public float LastYawAdjustment;
  public float LeftoverPitchAdjustment;
  public float Focus_BackOffStrength;
  public float Focus_StepHeightAdjustment;
  public int Focus_MaxTries;
  public float Focus_FastAdjustKickInTime;
  public float LastFocusChangeTime;
  public FVector ActualFocusPointWorldLoc = new();
  public FVector LastFocusPointLoc = new();
  public FCamFocusPointParams FocusPoint = new();
  public bool bFocusPointSet;
  public bool bFocusPointSuccessful;
  public bool bDoingACameraTurn;
  public bool bTurnAlignTargetWhenFinished;
  public bool bDrawDebug;
  public bool bDoingDirectLook;
  public bool bDebugChangedCameraMode;
  public float TurnCurTime;
  public int TurnStartAngle;
  public int TurnEndAngle;
  public float TurnTotalTime;
  public float TurnDelay;
  public int LastPostCamTurnYaw;
  public int DirectLookYaw;
  public float DirectLookInterpSpeed;
  public float WorstLocInterpSpeed;
  public FVector LastWorstLocationLocal = new();
  public FVector LastPreModifierCameraLoc = new();
  public FRotator LastPreModifierCameraRot = new();
  public List<FPenetrationAvoidanceFeeler> PenetrationAvoidanceFeelers;
  public float OffsetAdjustmentInterpSpeed;
  public FVector LastOffsetAdjustment = new();
}

public class UGameThirdPersonCameraMode : UObject
{
  public class FViewOffsetData
  {
    public UObject.FVector OffsetHigh = new();
    public UObject.FVector OffsetMid = new();
    public UObject.FVector OffsetLow = new();
  }

  public UGameThirdPersonCamera ThirdPersonCam;
  public float FOVAngle;
  public float BlendTime;
  public bool bLockedToViewTarget;
  public bool bDirectLook;
  public bool bFollowTarget;
  public bool bInterpLocation;
  public bool bUsePerAxisOriginLocInterp;
  public bool bInterpRotation;
  public bool bRotInterpSpeedConstant;
  public bool bDoPredictiveAvoidance;
  public bool bValidateWorstLoc;
  public bool bSkipCameraCollision;
  public bool bApplyDeltaViewOffset;
  public bool bAdjustDOF;
  public bool bDOFUpdated;
  public bool bInterpViewOffsetOnlyForCamTransition;
  public float FollowingInterpSpeed_Pitch;
  public float FollowingInterpSpeed_Yaw;
  public float FollowingInterpSpeed_Roll;
  public float FollowingCameraVelThreshold;
  public float OriginLocInterpSpeed;
  public FVector PerAxisOriginLocInterpSpeed = new();
  public float OriginRotInterpSpeed;
  public FVector StrafeLeftAdjustment = new();
  public FVector StrafeRightAdjustment = new();
  public float StrafeOffsetScalingThreshold;
  public float StrafeOffsetInterpSpeedIn;
  public float StrafeOffsetInterpSpeedOut;
  public FVector LastStrafeOffset = new();
  public FVector RunFwdAdjustment = new();
  public FVector RunBackAdjustment = new();
  public float RunOffsetScalingThreshold;
  public float RunOffsetInterpSpeedIn;
  public float RunOffsetInterpSpeedOut;
  public FVector LastRunOffset = new();
  public FVector WorstLocOffset = new();
  public FVector TargetRelativeCameraOriginOffset = new();
  public FViewOffsetData ViewOffset = new();
  public FViewOffsetData[] ViewOffset_ViewportAdjustments = new FViewOffsetData[6];
  public float DOF_FalloffExponent;
  public float DOF_BlurKernelSize;
  public float DOF_FocusInnerRadius;
  public float DOF_MaxNearBlurAmount;
  public float DOF_MaxFarBlurAmount;
  public float LastDOFRadius;
  public float LastDOFDistance;
  public float DOFDistanceInterpSpeed;
  public FVector DOFTraceExtent = new();
  public float DOF_RadiusFalloff;
  public FVector2D DOF_RadiusRange = new();
  public FVector2D DOF_RadiusDistRange = new();
  public float ViewOffsetInterp;
}

public class UGameThirdPersonCameraMode_Default : UGameThirdPersonCameraMode
{
  public float WorstLocAimingZOffset;
  public bool bTemporaryOriginRotInterp;
  public float TemporaryOriginRotInterpSpeed;
}

public class AGameVehicle : ASVehicle
{
}

public class UGameWaveForms : UObject
{
  public UForceFeedbackWaveform CameraShakeMediumShort;
  public UForceFeedbackWaveform CameraShakeMediumLong;
  public UForceFeedbackWaveform CameraShakeBigShort;
  public UForceFeedbackWaveform CameraShakeBigLong;
}

public class AGameWeapon : AWeapon
{
}

public class AMobileHUD : AGameHUD
{
  public class FMobileInputZone
  {
    public FName InputKey;
    public FName HorizontalInputKey;
    public FName TapInputKey;
    public string Desc;
    public int Config;
    public int X;
    public int Y;
    public int SizeX;
    public int SizeY;
    public int Border;
    public bool bIsInvisible;
    public EZoneType Type;
    public EZoneState State;
    public float VertMultiplier;
    public float HorizMultiplier;
    public int CurX;
    public int CurY;
    public int CurCenterX;
    public int CurCenterY;
  }

  public bool bShowGameHUD;
  public bool bForceMobileHUD;
  public UTexture2D ZoneBackgroundOn;
  public UTexture2D ZoneBackgroundSmallOn;
  public UTexture2D ZoneBackgroundTinyOn;
  public UTexture2D FireZoneBackground;
  public UTexture2D MoveZoneBackground;
  public UTexture2D SteerZoneBackground;
  public FColor ZoneTileColor = new();
  public FColor ZoneTextColor = new();
  public UTexture2D AnalogHat;
  public List<FMobileInputZone> MobileInputZones;
  public int MobileInputConfig;
  public int MobileInputConfigMAX;
}

public class UNavMeshGoal_OutOfViewFrom : UNavMeshPathGoalEvaluator
{
  public FPointer GoalPoly = new();
  public FVector OutOfViewLocation = new();
  public bool bShowDebug;
}

public class UNavMeshPath_BiasAgainstPolysWithinDistanceOfLocations : UNavMeshPathConstraint
{
  public float DistanceToCheck;
  public List<FVector> LocationsToCheck;
}

public class UPMESTG_LeaveADecalBase : UParticleModuleEventSendToGame
{
  public UClass PhysicalMaterialPropertyClass;
}

public class USeqAct_ControlGameMovie : USeqAct_Latent
{
  public string MovieName;
  public int StartOfRenderingMovieFrame;
  public int EndOfRenderingMovieFrame;
}

public class USeqAct_GameCrowdPopulationManagerToggle : USequenceAction
{
  public float WarmupPopulationPct;
  public UGameCrowd_ListOfAgents CrowdAgentList;
  public bool bClearOldArchetypes;
  public bool bEnableCrowdLightEnvironment;
  public bool bCastShadows;
  public bool bFillPotentialSpawnPoints;
  public bool bForceObstacleChecking;
  public bool bForceNavMeshPathing;
  public bool bIndividualSpawner;
  public int MaxAgents;
  public float SpawnRate;
  public ULightComponent.FLightingChannelContainer AgentLightingChannel = new();
  public float MaxSpawnDist;
  public float MinBehindSpawnDist;
  public List<AGameCrowdDestination> PotentialSpawnPoints;
  public float AgentWarmupTime;
  public int NumAgentsToTickPerFrame;
  public List<AGameCrowdAgent> LastSpawnedList;
}

public class USeqAct_GameCrowdSpawner : USeqAct_GameCrowdPopulationManagerToggle
{
}

public class USeqAct_ModifyProperty : USequenceAction
{
  public class FPropertyInfo
  {
    public FName PropertyName;
    public bool bModifyProperty;
    public string PropertyValue;
  }

  public List<FPropertyInfo> Properties;
}

public class USeqAct_PlayAgentAnimation : USeqAct_Latent
{
  public List<FName> AnimationList;
  public float BlendInTime;
  public float BlendOutTime;
  public bool bUseRootMotion;
  public bool bFaceActionTargetFirst;
  public bool bLooping;
  public bool bBlendBetweenAnims;
  public int LoopIndex;
  public float LoopTime;
  public AActor ActionTarget;
}

public class USeqEvent_CrowdAgentReachedDestination : USequenceEvent
{
}

