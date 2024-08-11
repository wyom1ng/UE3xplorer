namespace ue3bootstrap.Patch.Engine;

public class UEngineTypes : Core.UObject
{
  public class FLightmassPrimitiveSettings
  {
  }

  public class FQuantizedDirectionalLightSampleBulkData : FUntypedBulkData_Mirror
  {
  }

  public class FQuantizedSimpleLightSampleBulkData : FUntypedBulkData_Mirror
  {
  }

  [Native]
  public class FLightMap
  {
    public FVector2D CoordinateBias;
    public FVector2D CoordinateScale;
    public FQuantizedDirectionalLightSampleBulkData DirectionalSamples;
    public List<FGuid> LightGuids;
    public uint LightMapType;

    public Core.UObject Owner;
    public FVector4[] ScaleVectors = new FVector4[3];
    public FQuantizedSimpleLightSampleBulkData SimpleSamples;

    public ULightMapTexture2D[] Textures = new ULightMapTexture2D[3];
  }

  public class FBasedPosition
  {
    public AActor Base;
    public FVector Position;
  }
}

public class AActor : Core.UObject
{
  [Native]
  public class FActorReference
  {
  }
}

public class UActorComponent : Core.UComponent
{
}

[Native]
public class ULightComponent : UActorComponent
{
  public List<FConvexVolume> ExclusionConvexVolumes;

  public List<FConvexVolume> InclusionConvexVolumes;

  public class FLightingChannelContainer
  {
  }

  [Native]
  public class FConvexVolume
  {
    public List<FPlane> PermutedPlanes;
    public List<FPlane> Planes;
  }
}

public class UDirectionalLightComponent : ULightComponent
{
}

[Native]
public class UDominantDirectionalLightComponent : UDirectionalLightComponent
{
  public List<ushort> DominantLightShadowMap;
}

public class UPointLightComponent : ULightComponent
{
}

public class USpotLightComponent : UPointLightComponent
{
}

[Native]
public class UDominantSpotLightComponent : USpotLightComponent
{
  public List<ushort> DominantLightShadowMap;
}

public class ALight : AActor
{
}

[Native]
public class AStaticLightCollectionActor : ALight
{
}

public class UClient : Core.UObject
{
}

public class ABrush : AActor
{
}

[Native]
public class UModel : Core.UObject
{
  public FBoxSphereBounds Bounds;

  public List<int> LeafHulls;

  public List<FLeaf> Leaves;
  public FGuid LightingGuid;
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

  public Core.UObject SurfsOwner;

  public List<List<FVector>> unknownA4C;
  public List<List<FVector>> unknownA58;
  public List<List<FVector>> unknownA64;
  public List<FBoxSphereBounds> unknownA70;
  public List<uint> unknownA7C;
  public List<uint> unknownA88;

  public List<FTwoVector4DArrays> unknownA94;

  public List<FBoxAndThenSome> unknownAA0;

  public List<char> unknownAAC;
  public uint unknownAB8;

  public List<List<FVector>> unknownABC;
  public List<List<FVector2D>> unknownAC8;
  public List<uint> unknownAD4;

  public List<FVector> Vectors;

  public List<FModelVertex> VertexBuffer;

  public List<FVert> Verts;

  public FZoneProperties[] Zones = new FZoneProperties[64];

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

    public char[] iZone = new char[2];
    public char NodeFlags;
    public char NumVertices;
    public FPlane Plane;
  }

  public class FVert
  {
    public FVector2D BackfaceShadowTexCoord;
    public int iSide;
    public int pVertex;
    public FVector2D ShadowTexCoord;
  }

  public class FBspSurf
  {
    public ABrush Actor;
    public bool bHiddenEdLevel;

    public bool bHiddenEdTemporary;
    public int iBrushPoly;

    public int iLightmassIndex;

    public ULightComponent.FLightingChannelContainer LightingChannels;
    public UMaterialInterface Material;
    public int pBase;
    public FPlane Plane;
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
    public FVector Position;
    public FVector2D ShadowTexCoord;
    public FPackedNormal TangentX;
    public FPackedNormal TangentZ;
    public FVector2D TexCoord;
  }

  public class FZoneProperties
  {
    public ulong Connectivity;
    public float LastRenderTime;
    public ulong Visibility;
    public AZoneInfo ZoneActor;
  }

  public class FTwoVector4DArrays
  {
    public List<FVector4> First;
    public List<FVector4> Second;
  }

  public class FBoxAndThenSome
  {
    public FBox Box;
    public int[] Values = new int[10];
  }
}

public class UParticleSystem : Core.UObject
{
}

[Native]
public class UPolys : Core.UObject
{
  public List<FPoly> Element;

  public class FPoly
  {
    public ABrush Actor;
    public FVector Base;
    public int iBrushPoly;
    public int iLink;
    public FName ItemName;
    public uint LightingChannels;

    public UEngineTypes.FLightmassPrimitiveSettings LightmassSettings;
    public UMaterialInterface Material;
    public FVector Normal;
    public uint PolyFlags;
    public FName RulesetVariation;
    public float ShadowMapScale;
    public uint SmoothingMask;
    public FVector TextureU;
    public FVector TextureV;
    public List<FVector> Vertices;
  }
}

[Native]
public class UShadowMap1D : Core.UObject
{
  public FGuid LightGuid;
  public List<float> Samples;
}

public class UKMeshProps : Core.UObject
{
}

[Native]
public class URB_BodySetup : UKMeshProps
{
  [Native]
  public class FKCachedConvexDataElement
  {
  }

  [Native]
  public class FKCachedConvexData
  {
  }

  public class FKCachedPerTriData
  {
    public List<char> CachedPerTriData;
  }
}

[Native]
public class ULevelBase : Core.UObject
{
  public List<AActor> Actors;
  public Core.UObject ActorsOwner;
  public FURL URL;
}

[Native]
public class ULevel : ULevelBase
{
  public List<char> ApexSDKCachedData;
  public List<char> CachedPhysBSPData;
  public int CachedPhysBSPDataVersion;
  public URB_BodySetup.FKCachedConvexData CachedPhysConvexBSPData;
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

  public FPrecomputedLightVolume PrecomputedLightVolume;
  public APylon PylonListEnd;
  public APylon PylonListStart;
  public float ShadowmapTotalSize;
  public Dictionary<UTexture2D, List<FStreamableTextureInstance>> TextureToInstancesMap;

  public class FStreamableTextureInstance
  {
    public FSphere BoundingSphere;
    public float TexelFactor;
  }

  public class FCachedPhysSMData
  {
    public int CachedDataIndex;
    public FVector Scale3D;
  }

  public class FCachedPerTriPhysSMData
  {
    public int CachedDataIndex;
    public FVector Scale3D;
  }

  [Native]
  public class FCoverIndexPair
  {
    public uint ActorRefItem;
    public char SlotIdx;
  }

  public class FVolumeLightingSample
  {
    public FColor AmbientRadiance;
    public char bShadowedFromDominantLights;
    public char EnvironmentDirectionPhi;

    public char EnvironmentDirectionTheta;
    public FColor EnvironmentRadiance;
    public char IndirectDirectionPhi;
    public char IndirectDirectionTheta;

    public FColor IndirectRadiance;
    public FVector Position;
    public float Radius;
  }

  public class FPrecomputedLightVolume
  {
    public bool bInitialized;
    public FBox Bounds;
    public int NumSamples;
    public List<FVolumeLightingSample> Samples;
  }
}

[Native]
public class UPendingLevel : ULevelBase
{
}

public class UFaceFXAnimSet : Core.UObject
{
}

public class USaveGameSummary : Core.UObject
{
}

[Native]
public class UWorld : Core.UObject
{
  public FLevelViewportInfo[] EditorViews = new FLevelViewportInfo[4];
  public List<Core.UObject> ExtraReferencedObjects;
  public UFaceFXAnimSet PersistentFaceFXAnimSet;

  public ULevel PersistentLevel;
  public USaveGameSummary SaveGameSummary;

  public class FLevelViewportInfo
  {
    public float CamOrthoZoom;
    public FVector CamPosition;
    public FRotator CamRotation;
  }
}

public class UPlayer : Core.UObject
{
}

[Native]
public class UNetConnection : UPlayer
{
}

public class UChildConnection : UNetConnection
{
}

public class USurface : Core.UObject
{
}

[Native]
public class UTexture : USurface
{
}

[Native]
public class UTexture2D : UTexture
{
  public List<FTexture2DMipMap> CachedPVRTCMips;

  public List<FTexture2DMipMap> Mips;

  public class FTexture2DMipMap
  {
  }
}

[Native]
public class ULightMapTexture2D : UTexture2D
{
  public uint LightmapFlags;
}

public class UMaterialInterface : USurface
{
  public class FStaticSwitchParameter
  {
    public bool bOverride;
    public FGuid ExpressionGUID;
    public FName ParameterName;
    public bool Value;
  }

  public class FStaticComponentMaskParameter
  {
    public uint A;
    public uint B;
    public bool bOverride;
    public FGuid ExpressionGUID;
    public uint G;
    public FName ParameterName;
    public uint R;
  }

  public class FNormalParameter
  {
    public bool bOverride;
    public char CompressionSettings;
    public FGuid ExpressionGUID;
    public FName ParameterName;
  }

  public class FStaticTerrainLayerWeightParameter
  {
    public bool bOverride;
    public FGuid ExpressionGUID;
    public FName ParameterName;

    public int WeightmapIndex;
  }

  [Native]
  public class FStaticParameterSet
  {
    public FGuid BaseMaterialId;
    public List<FNormalParameter> NormalParameters;
    public List<FStaticComponentMaskParameter> StaticComponentMaskParameters;
    public List<FStaticSwitchParameter> StaticSwitchParameters;
    public List<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters;
  }

  public class FMaterialUniformExpression
  {
    public FName Type;
  }

  public class FMaterialUniformExpressionRef
  {
    public ulong Index;
  }

  public class FMaterialUniformExpressionAbs : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef X;
  }

  public class FMaterialUniformExpressionCeil : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef X;
  }

  public class FMaterialUniformExpressionClamp : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef Input;
    public FMaterialUniformExpressionRef Max;
    public FMaterialUniformExpressionRef Min;
  }

  public class FMaterialUniformExpressionFloor : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef X;
  }

  public class FMaterialUniformExpressionFmod : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef A;
    public FMaterialUniformExpressionRef B;
  }

  public class FMaterialUniformExpressionFrac : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef X;
  }

  public class FMaterialUniformExpressionMin : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef A;
    public FMaterialUniformExpressionRef B;
  }

  public class FMaterialUniformExpressionMax : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef A;
    public FMaterialUniformExpressionRef B;
  }

  public class FMaterialUniformExpressionSine : FMaterialUniformExpression
  {
    public bool bIsCosine;
    public FMaterialUniformExpressionRef X;
  }

  public class FMaterialUniformExpressionSquareRoot : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef X;
  }

  public class FMaterialUniformExpressionAppendVector : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef A;
    public FMaterialUniformExpressionRef B;
    public uint NumComponentsA;
  }

  public class FMaterialUniformExpressionVectorParameter : FMaterialUniformExpression
  {
    public FLinearColor DefaultValue;
    public FName ParameterName;
  }

  public class FMaterialUniformExpressionConstant : FMaterialUniformExpression
  {
    public FLinearColor Value;
    public char ValueType;
  }

  public class FMaterialUniformExpressionFoldedMath : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef A;
    public FMaterialUniformExpressionRef B;
    public char Op;
  }

  public class FMaterialUniformExpressionLength : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef X;
  }

  public class FMaterialUniformExpressionPeriodic : FMaterialUniformExpression
  {
    public FMaterialUniformExpressionRef X;
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
    public List<char> MaterialUniformExpressionStorage;
    public List<FMaterialUniformExpressionRef> UniformScalarExpressions;

    public List<FMaterialUniformExpressionRef> UniformVectorExpressions;
  }

  public class FUniformExpressionSet
  {
    public FShaderFrequencyUniformExpressions PixelExpressions;
    public FShaderFrequencyUniformExpressions UniformCubeTextureExpressions;
    public FShaderFrequencyUniformExpressions VertexExpressions;
  }
}

public class UMaterialExpression : Core.UObject
{
}

[Native]
public class UMaterial : UMaterialInterface
{
  public FMaterialResource[] MaterialResources = new FMaterialResource[3];
}

[Native]
public class UMaterialInstance : UMaterialInterface
{
  public FStaticParameterSet[] StaticParameters = new FStaticParameterSet[3];
  public FMaterial[] StaticPermutationResources = new FMaterial[3];
}

[Native]
public class UShaderCache : Core.UObject
{
  public FCompressedShaderCodeCache CompressedCache;

  public Dictionary<UMaterialInterface.FStaticParameterSet, FMaterialShaderMap> MaterialShaderMap;
  public char Platform;
  public Dictionary<FGuid, FShader> Shaders;
  public Dictionary<FName, uint> ShaderVersions;
  public Dictionary<FName, uint> VertexFactoryVersions;

  public class FIndividualCompressedShaderInfo
  {
    public ushort ChunkIndex;
    public ushort UncompressedCodeLength;
    public int UncompressedCodeOffset;
  }

  public class FCompressedShaderCodeChunk
  {
    public List<char> CompressedCode;
    public int UncompressedSize;
  }

  public class FTypeSpecificCompressedShaderCode
  {
    public List<FCompressedShaderCodeChunk> CodeChunks;
    public Dictionary<FGuid, FIndividualCompressedShaderInfo> CompressedShaderInfos;
  }

  public class FCompressedShaderCodeCache
  {
    public Dictionary<FName, FTypeSpecificCompressedShaderCode> ShaderTypeCompressedShaderCode;
  }

  public class FShaderKey
  {
    public List<char> Code;
    public uint ParameterMapCRC;
  }

  public class FShaderTarget
  {
    public char Frequency;
    public char Platform;
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
    public FShaderParameter ShaderParameter;
    public char Type;
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
    public FShaderResourceParameter ShaderParameter;
    public char Type;
  }

  public class FDOFShaderParameters
  {
    public FShaderParameter PackedParameters0;
    public FShaderParameter PackedParameters1;
  }

  public class FSceneTextureShaderParameters
  {
    public FShaderResourceParameter NvStereoFixTextureParameter;
    public FShaderResourceParameter SceneColorTextureParameter;
    public FShaderParameter SceneDepthCalcParameter;
    public FShaderResourceParameter SceneDepthTextureParameter;
    public FShaderParameter ScreenPositionScaleBiasParameter;
  }

  public class FMaterialShaderParameters
  {
    public FShaderParameter CameraWorldPosParameter;
    public FShaderParameter FoliageImpParameter;
    public FShaderParameter FoliageNormalizedRotationAxisAndAngleParameter;
    public FShaderParameter InvViewProjectionParameter;
    public FShaderParameter LocalToWorldParameter;
    public FShaderParameter ObjectOrientationParameter;
    public FShaderParameter ObjectWorldPositionAndRadiusParameter;
    public FShaderParameter OcclusionPercentageParameter;
    public FShaderParameter ViewProjectionParameter;
    public FShaderParameter ViewToWorldParameter;
    public FShaderParameter WindDirectionAndSpeedParameter;
    public FShaderParameter WorldToLocalParameter;
    public FShaderParameter WorldToViewParameter;
  }

  public class FMaterialPixelShaderParameters : FMaterialShaderParameters
  {
    public FShaderResourceParameter BeckmannTextureParameter;
    public FShaderParameter bEnableScreenDoorFadeParameter;
    public FShaderParameter DecalFarPlaneDistanceParameter;
    public FShaderParameter MatInverseGammaParameter;
    public FShaderParameter ObjectMacroUVScalesParameter;
    public FShaderParameter ObjectNDCPositionParameter;
    public FShaderParameter ObjectPostProjectionPositionParameter;

    public FSceneTextureShaderParameters SceneTextureParameters;
    public FShaderParameter ScreenDoorFadeSettings2Parameter;
    public FShaderParameter ScreenDoorFadeSettingsParameter;
    public FShaderResourceParameter ScreenDoorNoiseTextureParameter;
    public FShaderParameter TwoSidedSignParameter;
    public List<FUniformShaderResourceParameter> Uniform2DShaderResourceParameters; // or: UniformPixelCubeShaderResourceParameters
    public List<FUniformShaderParameter> UniformPixelScalarParameters; // or: UniformPixelVectorParameters
  }

  public class FMaterialVertexShaderParameters : FMaterialShaderParameters
  {
    public List<FUniformShaderParameter> UniformPixelScalarParameters; // or: UniformPixelVectorParameters
  }

  public class FVertexFactoryParameters
  {
    public List<FName> ParameterOrder;

    public Dictionary<FName, FShaderParameter> ShaderParameters;
    public Dictionary<FName, FShaderResourceParameter> ShaderResourceParameters;
    public FName Type;
  }

  public class FShader
  {
    public FDOFShaderParameters DOFParameters;
    public FGuid Id;
    public FShaderKey Key;

    public FMaterialPixelShaderParameters MaterialPixelParameters;
    public FMaterialVertexShaderParameters MaterialVertexParameters;
    public uint NumInstructions;
    public List<FName> ParameterOrder;
    public FSceneTextureShaderParameters SceneTextureParameters;

    public Dictionary<FName, FShaderParameter> ShaderParameters;
    public Dictionary<FName, FShaderResourceParameter> ShaderResourceParameters;
    public FShaderTarget Target;
    public FName Type;
    public FVertexFactoryParameters VertexFactoryParameters;
  }

  public class FShaderRef
  {
    public FGuid Id;
    public FName Type;
  }

  public class FShaderMap
  {
    public Dictionary<FName, FShaderRef> Shaders;
  }

  public class FMeshMaterialShaderMap : FShaderMap
  {
    public FName VertexFactoryType;
  }

  public class FMaterialShaderMap : FShaderMap
  {
    public string FriendlyName;
    public FGuid MaterialId;
    public List<FMeshMaterialShaderMap> MeshShaderMaps;
    public int Platform;
    public UMaterialInterface.FStaticParameterSet StaticParameters;
    public UMaterialInterface.FUniformExpressionSet UniformExpressionSet;
  }
}

[Native]
public class UStaticMesh : Core.UObject
{
  public bool bCanBecomeDynamic;

  public URB_BodySetup BodySetup;
  public FBoxSphereBounds Bounds;
  public bool bPartitionForEdgeGeometry;
  public bool bUsedForInstancing;
  public bool bUseMaximumStreamingTexelRatio;
  public uint HighResSourceMeshCRC;
  public string HighResSourceMeshName;
  public int InternalVersion;

  public FkDOPTree kDOPTree;
  public FGuid LightingGuid;
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
  public FRotator ThumbnailAngle;
  public float ThumbnailDistance;
  public bool UseFullPrecisionUVs;
  public bool UseSimpleBoxCollision;
  public bool UseSimpleLineCollision;
  public bool UseSimpleRigidBodyCollision;

  public class FStaticMeshVertex
  {
    public FColor Color;
    public ushort FragmentIndex;
    public FVector Position;
    public FPackedNormal TangentX;
    public FPackedNormal TangentY;
    public FPackedNormal TangentZ;
    public FVector2D[] UVs = new FVector2D[4];
  }

  [Native]
  public class FFragmentRange
  {
    public int BaseIndex;
    public int NumPrimitives;
  }

  [Native]
  public class FStaticMeshElement
  {
    public bool bEnableShadowCasting;

    public bool EnableCollision;

    public uint FirstIndex;
    public List<FFragmentRange> Fragments;
    public UMaterialInterface Material;
    public int MaterialIndex;
    public uint MaxVertexIndex;
    public uint MinVertexIndex;
    public string Name;
    public uint NumTriangles;
    public bool OldEnableCollision;
  }

  public class FStaticMeshTriangleBulkData : FUntypedBulkData_Mirror
  {
  }

  [Native]
  public class FStaticMeshVertexBuffer
  {
    public bool bUseFullPrecisionUVs;
    public uint NumTexCoords;
    public uint NumVertices;
    public uint Stride;
    public List<char> UntypedData;
  }

  [Native]
  public class FPositionVertexBuffer
  {
    public List<FVector> Data;
    public uint NumVertices;
    public uint Stride;
  }

  [Native]
  public class FColorVertexBuffer
  {
    public List<FColor> Data;
    public uint NumVertices;
    public uint Stride;
  }

  public class FStaticMeshRenderData
  {
    public FColorVertexBuffer ColorVertexBuffer;
    public List<FStaticMeshElement> Elements;
    public List<ushort> IndexBuffer;
    public uint NumVertices;
    public FPositionVertexBuffer PositionVertexBuffer;
    public FStaticMeshTriangleBulkData RawTriangles;
    public FStaticMeshVertexBuffer VertexBuffer;
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
    public FkDOP BoundingVolume;
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
    public List<FkDOPNode> Nodes;
    public List<FkDOPCollisionTriangle> Triangles;
  }
}

[Native]
public class UFracturedStaticMesh : UStaticMesh
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

[Native]
public class USkeletalMesh : Core.UObject
{
  public List<FStaticLODModel> LODModels;
  public Dictionary<FName, int> NameIndexMap;

  public List<FMeshBone> RefSkeleton;

  public char unknown108;
  public FName unknown10C;

  public class FVJointPos
  {
    public FQuat Orientation;
    public FVector Position;
  }

  [Native]
  public class FMeshBone
  {
    public FColor BoneColor;
    public FVJointPos BonePos;
    public int Depth;
    public uint Flags;
    public FName Name;
    public int NumChildren;
    public int ParentIndex;
  }

  [Native]
  public class FSkelMeshSection
  {
    public uint BaseIndex;
    public char bSelected;
    public ushort ChunkIndex;
    public ushort MaterialIndex;
    public ushort NumTriangles;
    public char TriangleSorting;
  }

  public class FRigidSkinVertex
  {
    public char Bone;
    public FColor Color;
    public FVector Position;
    public FPackedNormal TangentX;
    public FPackedNormal TangentY;
    public FPackedNormal TangentZ;
    public FVector2D[] UVs = new FVector2D[4];
  }

  public class FSoftSkinVertex
  {
    public FColor Color;
    public char[] InfluenceBones = new char[4];
    public char[] InfluenceWeights = new char[4];
    public FVector Position;
    public FPackedNormal TangentX;
    public FPackedNormal TangentY;
    public FPackedNormal TangentZ;
    public FVector2D[] UVs = new FVector2D[4];
  }

  [Native]
  public class FSkelMeshChunk
  {
    public uint BaseVertexIndex;
    public List<ushort> BoneMap;
    public int MaxBoneInfluences;
    public int NumRigidVertices;
    public int NumSoftVertices;
    public List<FRigidSkinVertex> RigidVertices;
    public List<FSoftSkinVertex> SoftVertices;
  }

  public class FSkeletalMeshVertexBuffer
  {
    public bool bUseFullPrecisionUVs;
    public bool bUsePackedPosition;
    public FVector MeshExtension;
    public FVector MeshOrigin;
    public uint NumTexCoords;
    public List<char> UntypedData;
  }

  public class FSkeletalMeshVertexColorBuffer
  {
    public List<FColor> Data;
  }

  public class FVertexInfluence
  {
    public char[] Bones = new char[4];
    public char[] Weights = new char[4];
  }

  public class FBoneIndexPair
  {
    public int[] BoneIdx = new int[2];
  }

  [Native]
  public class FSkeletalMeshVertexInfluences
  {
    public List<FSkelMeshChunk> Chunks;
    public List<FVertexInfluence> Influences;
    public List<char> RequiredBones;
    public List<FSkelMeshSection> Sections;
    public Dictionary<FBoneIndexPair, List<uint>> VertexInfluenceMapping;
  }

  public class FStaticLODModel
  {
    public List<ushort> ActiveBoneIndices;
    public List<FSkelMeshChunk> Chunks;
    public List<FColor> ColorVertexBuffer;

    public List<ushort> DynamicIndexBuffer;
    public uint NumTexCoords;
    public uint NumVertices;
    public FWordBulkData RawPointIndices;
    public List<char> RequiredBones;
    public List<FSkelMeshSection> Sections;
    public uint Size;

    public FSkeletalMeshVertexBuffer VertexBufferGPUSkin;
    public List<FSkeletalMeshVertexInfluences> VertexInfluences;
  }
}

public class AStaticMeshActorBase : AActor
{
}

[Native]
public class AStaticMeshCollectionActor : AStaticMeshActorBase
{
}

[Native]
public class UPhysicsAssetInstance : Core.UObject
{
  public Dictionary<FRigidBodyIndexPair, bool> CollisionDisableTable;

  public class FRigidBodyIndexPair
  {
    public int[] Indices = new int[2];
  }
}

[Native]
public class UGuidCache : Core.UObject
{
  public Dictionary<FName, FGuid> PackageGuidMap;
}

[Native]
public class UPersistentCookerData : Core.UObject
{
  public List<string> ChildCookErrors;

  public List<string> ChildCookWarnings;

  public Dictionary<string, FCookedBulkDataInfo> CookedBulkDataInfoMap;
  public Dictionary<string, FCookedTextureFileCacheInfo> CookedTextureFileCacheInfoMap;
  public Dictionary<string, int> FilenameToCookedVersion;

  public Dictionary<string, FDouble> FilenameToTimeMap;

  public ulong TextureFileCacheWaste;
  public Dictionary<string, FCookedTextureUsageInfo> TextureUsageInfos;
  public ulong Unknown;

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
    public FDouble LastSaved;
    public FGuid TextureFileCacheGuid;
    public FName TextureFileCacheName;
  }

  public class FCookedTextureUsageInfo
  {
    public int DuplicatedMipSize;
    public char Format;
    public char LODGroup;
    public List<string> PackageNames;
    public int SizeX;
    public int SizeY;
    public int StoredOnceMipSize;
  }
}

public class ANavigationPoint : AActor
{
}

public class ACoverLink : ANavigationPoint
{
  [Native]
  public class FCoverReference
  {
  }

  [Native]
  public class FCoverSlot
  {
  }
}

[Native]
public class APylon : ANavigationPoint
{
  [Native]
  public class FPolyReference
  {
  }
}

[Native]
public class UAnimSequence : Core.UObject
{
  [Native]
  public class FRawAnimSequenceTrack
  {
  }
}

public class UAnimObject : Core.UObject
{
}

public class UAnimNode : UAnimObject
{
}

public class UAnimNodeBlendBase : UAnimNode
{
}

public class UAnimNodeAimOffset : UAnimNodeBlendBase
{
  [Native]
  public class FAimTransform
  {
  }

  [Native]
  public class FAimComponent
  {
  }

  [Native]
  public class FAimOffsetProfile
  {
  }
}

[Native]
public class USoundCue : Core.UObject
{
  public Dictionary<USoundNode, FSoundNodeEditorData> EditorData;

  [Native]
  public class FSoundNodeEditorData
  {
  }
}

[Native]
public class UFont : Core.UObject
{
  public Dictionary<ushort, ushort> CharRemap;

  [Native]
  public class FFontCharacter
  {
  }
}

public class UPrimitiveComponent : UActorComponent
{
}

[Native]
public class UFluidSurfaceComponent : UPrimitiveComponent
{
  public UEngineTypes.FLightMap LightMap;
}

[Native]
public class USpeedTreeComponent : UPrimitiveComponent
{
  public UEngineTypes.FLightMap BillboardLightMap;
  public UEngineTypes.FLightMap BranchLightMap;
  public UEngineTypes.FLightMap FrondLightMap;
  public UEngineTypes.FLightMap LeafCardLightMap;
  public UEngineTypes.FLightMap LeafMeshLightMap;
}

[Native]
public class UBrushComponent : UPrimitiveComponent
{
  public URB_BodySetup.FKCachedConvexData CachedPhysBrushData;
}

public class UMeshComponent : UPrimitiveComponent
{
}

[Native]
public class UStaticMeshComponent : UMeshComponent
{
  [Native]
  public class FStaticMeshComponentLODInfo
  {
    public UEngineTypes.FLightMap LightMap;
    public UStaticMesh.FColorVertexBuffer OverrideVertexColors;
    public List<UShadowMap1D> ShadowVertexBuffers;
  }
}

[Native]
public class UDecalComponent : UPrimitiveComponent
{
  public List<FStaticReceiverData> StaticReceivers;

  public class FDecalVertex
  {
    public FVector2D LightMapCoordinate;
    public FVector Position;
    public FPackedNormal TangentX;
    public FPackedNormal TangentZ;
  }

  [Native]
  public class FStaticReceiverData
  {
    public UPrimitiveComponent Component;
    public int Data;
    public List<ushort> Indices;
    public int InstanceIndex;
    public UEngineTypes.FLightMap LightMap1D;
    public uint NumTriangles;
    public List<UShadowMap1D> ShadowMap1D;
    public List<FDecalVertex> Vertices;
  }
}

[Native]
public class UDrawBSPTreeComponent : UPrimitiveComponent
{
  public UModel Model;
}

public class UShadowMap2D : Core.UObject {};

[Native]
public class UModelComponent : UPrimitiveComponent
{
  public int BSPZoneIndex;
  public ushort ComponentIndex;
  public List<FModelElement> Elements;

  public UModel Model;
  public List<ushort> Nodes;
  public int ZoneIndex;

  public class FModelElement
  {
    public UModelComponent Component;
    public List<FGuid> IrrelevantLights;
    public UEngineTypes.FLightMap LightMap;
    public UMaterialInterface Material;
    public List<ushort> Nodes;
    public List<UShadowMap2D> ShadowMaps;
  }
}

public class USequenceObject : Core.UObject
{
}

public class USequenceOp : USequenceObject
{
}

public class USequenceAction : USequenceOp
{
}

public class USequence : USequenceOp
{
}

public class USeqAct_Latent : USequenceAction
{
}

[Native]
public class USeqAct_Interp : USeqAct_Latent
{
  public Dictionary<AActor, FSavedTransform> SavedActorTransforms;

  [Native]
  public class FSavedTransform
  {
  }
}

public class AInfo : AActor
{
}

public class AZoneInfo : AInfo
{
}

[Native]
public class ATerrain : AInfo
{
  [Native]
  public class FAlphaMap
  {
    public List<char> Data;
  }

  [Native]
  public class FTerrainMaterialMask
  {
    public ulong BitMask;
    public int NumBits;
  }

  [Native]
  public class FTerrainMaterialResource : FMaterial
  {
    public FGuid LightingGuid;
    public FTerrainMaterialMask Mask;
    public List<FGuid> MaterialIds;
    public ATerrain Terrain;
  }

  [Native]
  public class FCachedTerrainMaterialArray
  {
    public List<FTerrainMaterialResource> CachedMaterials;
  }

  [Native]
  public class FTerrainHeight
  {
    public ushort Value;
  }

  [Native]
  public class FTerrainInfoData
  {
    public char Data;
  }
}

[Native]
public class UTerrainComponent : UPrimitiveComponent
{
  public UEngineTypes.FLightMap LightMap;
  public List<FTerrainPatchBounds> PatchBounds;

  [Native]
  public class FTerrainkDOPTree
  {
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
    public FBox BoundingVolume;
    public FTerrainSubRegion Region;
  }

  public class FTerrainBVTree
  {
    public List<FTerrainBVNode> Nodes;
  }

  public class FTerrainPatchBounds
  {
    public float MaxDisplacement;
    public float MaxHeight;
    public float MinHeight;
  }
}

public class UUIRoot : Core.UObject
{
  [Native]
  public class FWIDGET_ID : FGuid
  {
  }

  [Native]
  public class FSTYLE_ID : FGuid
  {
  }
}

public class UUIDataProvider : UUIRoot
{
}

[Native]
public class UUIDynamicFieldProvider : UUIDataProvider
{
  public Dictionary<FName, Dictionary<FName, List<string>>> PersistentCollectionData;
}

public class UUIState : UUIRoot
{
}

public class UUITexture : UUIRoot
{
}

public class UUIDataStore : UUIDataProvider
{
}

[Native]
public class UUISkin : UUIDataStore
{
  public Dictionary<FName, FUICursorStyle> CursorMap;

  public class FUICursorStyle
  {
    public UUITexture CursorImage;
    public FName CursorImageStyle;
  }
}

[Native]
public class UUIStyle : UUIRoot
{
  public Dictionary<UUIState, int> StateDataMap;
}

public class USoundNode : Core.UObject
{
}

[Native]
public class USoundNodeWave : USoundNode
{
}

[Native]
public class USoundClass : Core.UObject
{
  public Dictionary<USoundClass, FSoundClassEditorData> EditorData;

  public class FSoundClassEditorData
  {
    public int NodePosX;
    public int NodePosY;
  }
}

[Native]
public class UMorphTarget : Core.UObject
{
  private List<FMorphTargetLODModel> MorphLODModels;

  public class FMorphTargetVertex
  {
    public FVector PositionDelta;
    public ushort SourceIdx;
    public FPackedNormal TangentZDelta;
  }

  public class FMorphTargetLODModel
  {
    public int NumBaseMeshVerts;
    private List<FMorphTargetVertex> Vertices;
  }
}

[Native]
public class APrefabInstance : AActor
{
  public Dictionary<Core.UObject, Core.UObject> ArchetypeToInstanceMap;
  public Dictionary<Core.UObject, int> PI_ObjectMap;
}

[Native]
public class UNavigationMeshBase : Core.UObject
{
  public List<FBorderEdgeInfo> BorderEdgeSegments;
  public FBox BoxBounds;
  public List<FNavMeshEdgeBase> Edges;
  public List<FEdgeStorageDatum> EdgeStorageData;
  public FMatrix LocalToWorld;

  public uint NavMeshVersionNum;
  public List<FNavMeshPolyBase> Polys;
  public uint VersionAtGenerationTime;
  public List<FMeshVertex> Verts;
  public FMatrix WorldToLocal;

  public class FPolyReference
  {
    public AActor.FActorReference OwningPylon;
    public int PolyId;
  }

  public class FNavMeshEdgeBase
  {
    public float DropHeight;
    public FVector EdgeCenter;
    public FVector EdgeExtent;
    public char EdgeGroupID;
    public char EdgeType;
    public float EffectiveEdgeLength;
    public UEngineTypes.FBasedPosition MoveDest;
    public int MoveDir;
    public ushort ObstaclePolyID;

    public ushort OtherPylonVert0;
    public ushort OtherPylonVert1;
    public ushort Poly0;
    public FPolyReference Poly0Ref;
    public ushort Poly1;
    public FPolyReference Poly1Ref;

    public AActor.FActorReference RelActor;
    public int RelItem;
    public ushort Vert0;
    public ushort Vert1;
  }

  public class FMeshVertex : FVector
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
    public FBox BoxBounds;
    public ushort Item;
    public FVector PolyCenter;
    public List<ACoverLink.FCoverReference> PolyCover;
    public List<ushort> PolyEdges;
    public float PolyHeight;
    public FVector PolyNormal;
    public List<ushort> PolyVerts;
  }

  public class FBorderEdgeInfo
  {
    public ushort Poly;
    public ushort Vert0;
    public ushort Vert1;
  }
}