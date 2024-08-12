/*===========================================================================
 *  This file was automatically generated. DO NOT modify!
===========================================================================*/
namespace ue3;

public enum EInterpMethodType
{
  IMT_UseFixedTangentEvalAndNewAutoTangents,
  IMT_UseFixedTangentEval,
  IMT_UseBrokenTangentEval,
  IMT_MAX,
}

public enum EInterpCurveMode
{
  CIM_Linear,
  CIM_CurveAuto,
  CIM_Constant,
  CIM_CurveUser,
  CIM_CurveBreak,
  CIM_CurveAutoClamped,
  CIM_MAX,
}

public enum ETickingGroup
{
  TG_PreAsyncWork,
  TG_DuringAsyncWork,
  TG_PostAsyncWork,
  TG_PostUpdateWork,
  TG_MAX,
}

public enum EAutomatedRunResult
{
  ARR_Unknown,
  ARR_OOM,
  ARR_Passed,
  ARR_MAX,
}

public enum EDebugBreakType
{
  DEBUGGER_NativeOnly,
  DEBUGGER_ScriptOnly,
  DEBUGGER_Both,
  DEBUGGER_MAX,
}

public enum EAxis
{
  AXIS_NONE,
  AXIS_X,
  AXIS_Y,
  AXIS_BLANK,
  AXIS_Z,
  AXIS_MAX,
}

public enum EDistributionVectorLockFlags
{
  EDVLF_None,
  EDVLF_XY,
  EDVLF_XZ,
  EDVLF_YZ,
  EDVLF_XYZ,
  EDVLF_MAX,
}

public enum EDistributionVectorMirrorFlags
{
  EDVMF_Same,
  EDVMF_Different,
  EDVMF_Mirror,
  EDVMF_MAX,
}

public enum EInputEvent
{
  IE_Pressed,
  IE_Released,
  IE_Repeat,
  IE_DoubleClick,
  IE_Axis,
  IE_MAX,
}

public enum AlphaBlendType
{
  ABT_Linear,
  ABT_Cubic,
  ABT_Sinusoidal,
  ABT_EaseInOutExponent2,
  ABT_EaseInOutExponent3,
  ABT_EaseInOutExponent4,
  ABT_EaseInOutExponent5,
  ABT_MAX,
}

public partial class UObject : ISerialisable
{
  public class FInterpCurvePointFloat
  {
    public float InVal;
    public float OutVal;
    public float ArriveTangent;
    public float LeaveTangent;
    public EInterpCurveMode InterpMode;
  }

  public class FInterpCurveFloat
  {
    public List<UObject.FInterpCurvePointFloat> Points;
    public EInterpMethodType InterpMethod;
  }

  public class FInterpCurvePointVector2D
  {
    public float InVal;
    public UObject.FVector2D OutVal = new();
    public UObject.FVector2D ArriveTangent = new();
    public UObject.FVector2D LeaveTangent = new();
    public EInterpCurveMode InterpMode;
  }

  public class FInterpCurveVector2D
  {
    public List<UObject.FInterpCurvePointVector2D> Points;
    public EInterpMethodType InterpMethod;
  }

  public class FInterpCurvePointVector
  {
    public float InVal;
    public UObject.FVector OutVal = new();
    public UObject.FVector ArriveTangent = new();
    public UObject.FVector LeaveTangent = new();
    public EInterpCurveMode InterpMode;
  }

  public class FInterpCurveVector
  {
    public List<UObject.FInterpCurvePointVector> Points;
    public EInterpMethodType InterpMethod;
  }

  public class FInterpCurvePointTwoVectors
  {
    public float InVal;
    public UObject.FTwoVectors OutVal = new();
    public UObject.FTwoVectors ArriveTangent = new();
    public UObject.FTwoVectors LeaveTangent = new();
    public EInterpCurveMode InterpMode;
  }

  public class FInterpCurveTwoVectors
  {
    public List<UObject.FInterpCurvePointTwoVectors> Points;
    public EInterpMethodType InterpMethod;
  }

  public class FInterpCurvePointQuat
  {
    public float InVal;
    public UObject.FQuat OutVal = new();
    public UObject.FQuat ArriveTangent = new();
    public UObject.FQuat LeaveTangent = new();
    public EInterpCurveMode InterpMode;
  }

  public class FInterpCurveQuat
  {
    public List<UObject.FInterpCurvePointQuat> Points;
    public EInterpMethodType InterpMethod;
  }

  public class FInterpCurvePointLinearColor
  {
    public float InVal;
    public UObject.FLinearColor OutVal = new();
    public UObject.FLinearColor ArriveTangent = new();
    public UObject.FLinearColor LeaveTangent = new();
    public EInterpCurveMode InterpMode;
  }

  public class FInterpCurveLinearColor
  {
    public List<UObject.FInterpCurvePointLinearColor> Points;
    public EInterpMethodType InterpMethod;
  }

  public class FRawDistribution
  {
    public byte Type;
    public byte Op;
    public byte LookupTableNumElements;
    public byte LookupTableChunkSize;
    public List<float> LookupTable;
    public float LookupTableTimeScale;
    public float LookupTableStartTime;
  }

  public class FRenderCommandFence
  {
    public int NumPendingFences;
  }

  public class FOctreeElementId
  {
    public UObject.FPointer Node = new();
    public int ElementIndex;
  }

  public class FBoneAtom
  {
    public UObject.FQuat Rotation = new();
    public UObject.FVector Translation = new();
    public float Scale;
  }

  public partial class FPointer : ISerialisable
  {
    public int Dummy;
  }

  public partial class FQWord : ISerialisable
  {
    public int A;
    public int B;
  }

  public partial class FDouble : ISerialisable
  {
    public int A;
    public int B;
  }

  public class FThreadSafeCounter
  {
    public int Value;
  }

  public class FBitArray_Mirror
  {
    public UObject.FPointer IndirectData = new();
    public int[] InlineData = new int[4];
    public int NumBits;
    public int MaxBits;
  }

  public class FSparseArray_Mirror
  {
    public List<int> Elements;
    public UObject.FBitArray_Mirror AllocationFlags = new();
    public int FirstFreeIndex;
    public int NumFreeIndices;
  }

  public class FSet_Mirror
  {
    public UObject.FSparseArray_Mirror Elements = new();
    public UObject.FPointer Hash = new();
    public int InlineHash;
    public int HashSize;
  }

  public class FMap_Mirror
  {
    public UObject.FSet_Mirror Pairs = new();
  }

  public class FMultiMap_Mirror
  {
    public UObject.FSet_Mirror Pairs = new();
  }

  public partial class FUntypedBulkData_Mirror : ISerialisable
  {
    public UObject.FPointer VfTable = new();
    public int BulkDataFlags;
    public int ElementCount;
    public int BulkDataOffsetInFile;
    public int BulkDataSizeOnDisk;
    public int SavedBulkDataFlags;
    public int SavedElementCount;
    public int SavedBulkDataOffsetInFile;
    public int SavedBulkDataSizeOnDisk;
    public byte[] BulkData;
    public int LockStatus;
    public UObject.FPointer AttachedAr = new();
    public int bShouldFreeOnEmpty;
  }

  public class FRenderCommandFence_Mirror
  {
    public int NumPendingFences;
  }

  public class FFColorVertexBuffer_Mirror
  {
    public UObject.FPointer VfTable = new();
    public UObject.FPointer VertexData = new();
    public int Data;
    public int Stride;
    public int NumVertices;
  }

  public class FIndirectArray_Mirror
  {
    public UObject.FPointer Data = new();
    public int ArrayNum;
    public int ArrayMax;
  }

  public class FArray_Mirror
  {
    public UObject.FPointer Data = new();
    public int ArrayNum;
    public int ArrayMax;
  }

  public class FInlinePointerArray_Mirror
  {
    public UObject.FPointer InlineData = new();
    public UObject.FArray_Mirror SecondaryData = new();
  }

  public partial class FGuid : ISerialisable
  {
    public int A;
    public int B;
    public int C;
    public int D;
  }

  public partial class FVector : ISerialisable
  {
    public float X;
    public float Y;
    public float Z;
  }

  public partial class FColor : ISerialisable
  {
    public byte B;
    public byte G;
    public byte R;
    public byte A;
  }

  public partial class FLinearColor : ISerialisable
  {
    public float R;
    public float G;
    public float B;
    public float A;
  }

  public partial class FBox : ISerialisable
  {
    public UObject.FVector Min = new();
    public UObject.FVector Max = new();
    public byte IsValid;
  }

  public partial class FVector4 : ISerialisable
  {
    public float X;
    public float Y;
    public float Z;
    public float W;
  }

  public partial class FVector2D : ISerialisable
  {
    public float X;
    public float Y;
  }

  public partial class FTwoVectors : ISerialisable
  {
    public UObject.FVector v1 = new();
    public UObject.FVector v2 = new();
  }

  public partial class FPlane : FVector
  {
    public float W;
  }

  public partial class FRotator : ISerialisable
  {
    public int Pitch;
    public int Yaw;
    public int Roll;
  }

  public partial class FQuat : ISerialisable
  {
    public float X;
    public float Y;
    public float Z;
    public float W;
  }

  public class FIntPoint
  {
    public int X;
    public int Y;
  }

  public class FSHVector
  {
    public float[] V = new float[9];
    public float[] Padding = new float[3];
  }

  public class FSHVectorRGB
  {
    public UObject.FSHVector R = new();
    public UObject.FSHVector G = new();
    public UObject.FSHVector B = new();
  }

  public class FTPOV
  {
    public UObject.FVector Location = new();
    public UObject.FRotator Rotation = new();
    public float FOV;
  }

  public class FTAlphaBlend
  {
    public float AlphaIn;
    public float AlphaOut;
    public float AlphaTarget;
    public float BlendTime;
    public float BlendTimeToGo;
    public AlphaBlendType BlendType;
  }

  public partial class FBoxSphereBounds : ISerialisable
  {
    public UObject.FVector Origin = new();
    public UObject.FVector BoxExtent = new();
    public float SphereRadius;
  }

  public partial class FMatrix : ISerialisable
  {
    public UObject.FPlane XPlane = new();
    public UObject.FPlane YPlane = new();
    public UObject.FPlane ZPlane = new();
    public UObject.FPlane WPlane = new();
  }

  public class FCylinder
  {
    public float Radius;
    public float Height;
  }

  public partial class FPackedNormal : ISerialisable
  {
    public uint Packed;
  }

  public partial class FVector2DHalf : ISerialisable
  {
    public ushort X;
    public ushort Y;
  }

  public partial class FSphere : ISerialisable
  {
    public UObject.FVector Center = new();
    public float W;
  }

  public partial class FQuantizedSHVector : ISerialisable
  {
    public ushort MaxCoefficient;
    public ushort MinCoefficient;
    public byte[] V = new byte[9];
  }

  public partial class FQuantizedSHVectorRGB : ISerialisable
  {
    public UObject.FQuantizedSHVector B = new();
    public UObject.FQuantizedSHVector G = new();
    public UObject.FQuantizedSHVector R = new();
  }

  public partial class FByteBulkData : FUntypedBulkData_Mirror
  {
  }

  public partial class FWordBulkData : FUntypedBulkData_Mirror
  {
  }

  public partial class FIntBulkData : FUntypedBulkData_Mirror
  {
  }

  public partial class FURL : ISerialisable
  {
    public string Host;
    public string Map;
    public List<string> Op;
    public int Port;
    public string Portal;
    public string Protocol;
    public int Valid;
  }

  public partial class FGuidPair : ISerialisable
  {
    public UObject.FGuid Guid = new();
    public uint RefId;
  }

  public partial class FPushedState : ISerialisable
  {
    public UStruct Node;
    public int Offset;
    public UState State;
  }

  public class FStateFrame
  {
    public ushort LatentAction;
    public UStruct Node;
    public UObject Object;
    public int Offset;
    public uint ProbeMask;
    public UState StateNode;
    public List<UObject.FPushedState> StateStack;
  }

  public partial class FTextureLookup : ISerialisable
  {
    public int TexCoordIndex;
    public int TextureIndex;
    public float UScale;
    public float VScale;
  }

  public partial class FMaterial : ISerialisable
  {
    public bool bUsesDynamicParameter;
    public bool bUsesLightmapUVs;
    public bool bUsesMaterialVertexPositionOffset;
    public bool bUsesSceneColor;
    public bool bUsesSceneDepth;
    public List<string> CompileErrors;
    public uint DummyDroppedFallbackComponents;
    public UObject.FGuid Id = new();
    public int MaxTextureDependencyLength;
    public uint NumUserTexCoords;
    public Dictionary<UMaterialExpression, int> TextureDependencyLengthMap;
    public List<UObject.FTextureLookup> TextureLookups;
    public List<UTexture> UniformExpressionTextures;
    public uint unknown8C;
    public uint UsingTransforms;
  }

  public partial class FMaterialResource : FMaterial
  {
    public UMaterial Material;
  }

  public FPointer VfTableObject = new();
  public int ObjectInternalInteger;
  public ulong ObjectFlags = new();
  public UObject HashNext;
  public UObject HashOuterNext;
  public FStateFrame StateFrame = new();
  public ULinker Linker;
  public int LinkerIndex;
  public int NetIndex;
  public UObject Outer;
  public FName Name;
  public UClass Class;
  public UObject ObjectArchetype;
}

public partial class UComponent : UObject
{
  public UClass TemplateOwnerClass;
  public FName TemplateName;
}

public class UInterface : UObject
{
}

public class USubsystem : UObject
{
  public FPointer VfTable_FExec = new();
}

public class UCommandlet : UObject
{
  public string HelpDescription;
  public string HelpUsage;
  public string HelpWebLink;
  public List<string> HelpParamNames;
  public List<string> HelpParamDescriptions;
  public bool IsServer;
  public bool IsClient;
  public bool IsEditor;
  public bool LogToConsole;
  public bool ShowErrorCount;
}

public class UDistributionFloat : UComponent
{
  public class FRawDistributionFloat : FRawDistribution
  {
    public UDistributionFloat Distribution;
  }

  public FPointer VfTable_FCurveEdInterface = new();
  public bool bCanBeBaked;
  public bool bIsDirty;
}

public class UDistributionVector : UComponent
{
  public class FRawDistributionVector : FRawDistribution
  {
    public UDistributionVector Distribution;
  }

  public FPointer VfTable_FCurveEdInterface = new();
  public bool bCanBeBaked;
  public bool bIsDirty;
}

public class UFactory : UObject
{
  public UClass SupportedClass;
  public UClass ContextClass;
  public string Description;
  public List<string> Formats;
  public bool bCreateNew;
  public bool bEditAfterNew;
  public bool bEditorImport;
  public bool bText;
  public int AutoPriority;
  public List<string> ValidGameNames;
}

public class UHelpCommandlet : UCommandlet
{
}

public partial class UTextBuffer : UObject
{
  public int Pos;
  public string Text;
  public int Top;
}

public partial class UMetaData : UObject
{
  public Dictionary<UObject, Dictionary<FName, string>> ObjectMetaDataMap;
}

public partial class UObjectRedirector : UObject
{
  public UObject DestinationObject;
}

public partial class UPackage : UObject
{
  public partial class FLevelGuids : ISerialisable
  {
    public List<UObject.FGuid> Guids;
    public FName LevelName;
  }

  public bool bHasBeenFullyLoaded;
  public bool bIsBound;
  public int CurrentNumNetObjects;
  public Dictionary<FGuid, UObject> ExportGuids;
  public int FileSize;
  public FName FolderName;
  public FName ForcedExportBasePackageName;
  public List<int> GenerationNetObjectCount;
  public FGuid Guid = new();
  public List<FLevelGuids> ImportGuids;
  public float LoadTime;
  public List<UObject> NetObjects;
  public uint PackageFlags;
}

public partial class ULinker : UObject
{
  public partial class FCompressedChunk : ISerialisable
  {
    public int CompressedOffset;
    public int CompressedSize;
    public int UncompressedOffset;
    public int UncompressedSize;
  }

  public partial class FGenerationInfo : ISerialisable
  {
    public int ExportCount;
    public int NameCount;
    public int NetObjectCount;
  }

  public partial class FPackageFileSummary : ISerialisable
  {
    public string PackageName;
    public string PackagePath;
    public ulong FileSize = new();
    public List<string> AdditionalPackagesToCook;
    public List<ULinker.FCompressedChunk> CompressedChunks;
    public uint CompressionFlags;
    public int CookedContentVersion;
    public int DependsOffset;
    public int EngineVersion;
    public int ExportCount;
    public int ExportGuidsCount;
    public int ExportOffset;
    public ushort FileVersion;
    public uint FileVersionRaw;
    public ushort FileVersionLicensee;
    public string FolderName;
    public List<ULinker.FGenerationInfo> Generations;
    public UObject.FGuid Guid = new();
    public int ImportCount;
    public int ImportExportGuidsOffset;
    public int ImportGuidsCount;
    public int ImportOffset;
    public int NameCount;
    public int NameOffset;
    public uint PackageFlags;
    public uint PackageSource;
    public int Tag;
    public int ThumbnailTableOffset;
    public int TotalHeaderSize;
  }

  public partial class FObjectImport : ISerialisable
  {
    public FName ClassName;
    public FName ClassPackage;
    public FName ObjectName;
    public int OuterIndex;
    public int SourceIndex;
    public ULinker SourceLinker;
    public UObject XObject;
  }

  public partial class FObjectExport : ISerialisable
  {
    public int _iHashNext;
    public UObject _Object;
    public int ArchetypeIndex;
    public int ClassIndex;
    public uint ExportFlags;
    public List<int> GenerationNetObjectCount;
    public ulong ObjectFlags = new();
    public FName ObjectName;
    public int OuterIndex;
    public uint PackageFlags;
    public UObject.FGuid PackageGuid = new();
    public int ScriptSerializationEndOffset;
    public int ScriptSerializationStartOffset;
    public int SerialOffset;
    public int SerialSize;
    public int SuperIndex;
  }

  public string Basepath;
  public List<List<int>> DependsMap;
  public Dictionary<FGuid, int> ExportGuidsAwaitingLookup;
  public List<FObjectExport> ExportMap;
  public string Filename;
  public string Filepath;
  public List<FObjectImport> ImportMap;
  public UPackage LinkerRoot;
  public List<FName> NameMap;
  public FPointer PrecachedBuffer = new();
  public int PrecachedBufferSize;
  public FPackageFileSummary Summary = new();
}

public partial class UField : UObject
{
  public UField Next;
  public UField SuperField;
}

public partial class UConst : UField
{
  public string Value;
}

public partial class UEnum : UField
{
  public List<FName> Names;
}

public partial class UProperty : UField
{
  public int ArrayDim;
  public FName ArraySizeEnum;
  public FName Category;
  public ulong PropertyFlags = new();
  public ushort RepOffset;
}

public partial class UStruct : UField
{
  public partial class FPropertyTag : ISerialisable
  {
    public int ArrayIndex;
    public byte BoolVal;
    public FName EnumName;
    public FName Name;
    public int Size;
    public int SizeOffset;
    public FName StructName;
    public FName Type;
  }

  public UField Children;
  public UTextBuffer CppText;
  public int Line;
  public int PropertiesSize;
  public Dictionary<FName, UProperty> PropertyMap;
  public List<FName> PropertyOrder;
  public List<byte> Script;
  public int ScriptBytecodeSize;
  public UTextBuffer ScriptText;
  public int TextPos;
}

public partial class UFunction : UStruct
{
  public FName FriendlyName;
  public uint FunctionFlags;
  public ushort NativeIndex;
  public byte OperatorPrecedence;
  public ushort ReplicationOffset;
}

public partial class UScriptStruct : UStruct
{
  public List<byte> StructDefaults;
  public uint StructFlags;
}

public partial class UState : UStruct
{
  public Dictionary<FName, UFunction> FuncMap;
  public ushort LabelTableOffset;
  public uint ProbeMask;
  public uint StateFlags;
}

public partial class UClass : UState
{
  public partial class FImplementedInterface : ISerialisable
  {
    public UClass Class;
    public UProperty PointerProperty;
  }

  public List<FName> AutoCollapseCategories;
  public List<FName> AutoExpandCategories;
  public FName ClassConfigName;
  public UObject ClassDefaultObject;
  public uint ClassFlags;
  public UClass ClassWithin;
  public Dictionary<FName, UComponent> ComponentNameToDefaultObjectMap;
  public FName DLLBindName;
  public List<FName> DontSortCategories;
  public List<FName> HideCategories;
  public List<FImplementedInterface> Interfaces;
}

public partial class UArrayProperty : UProperty
{
  public UProperty Inner;
}

public class UBoolProperty : UProperty
{
  public uint BitMask;
}

public partial class UByteProperty : UProperty
{
  public UEnum Enum;
}

public partial class UDelegateProperty : UProperty
{
  public UFunction Function;
  public UFunction SourceDelegate;
}

public class UFloatProperty : UProperty
{
}

public partial class UInterfaceProperty : UProperty
{
  public UClass InterfaceClass;
}

public class UIntProperty : UProperty
{
}

public partial class UMapProperty : UProperty
{
  public UProperty Key;
  public UProperty Value;
}

public class UNameProperty : UProperty
{
}

public class UStrProperty : UProperty
{
}

public partial class UStructProperty : UProperty
{
  public UScriptStruct Struct;
}

public partial class UObjectProperty : UProperty
{
  public UClass PropertyClass;
}

public partial class UClassProperty : UObjectProperty
{
  public UClass MetaClass;
}

public class UComponentProperty : UObjectProperty
{
}

