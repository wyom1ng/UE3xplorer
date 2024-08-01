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

public class UObject
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
    public UObject.FVector2D OutVal;
    public UObject.FVector2D ArriveTangent;
    public UObject.FVector2D LeaveTangent;
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
    public UObject.FVector OutVal;
    public UObject.FVector ArriveTangent;
    public UObject.FVector LeaveTangent;
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
    public UObject.FTwoVectors OutVal;
    public UObject.FTwoVectors ArriveTangent;
    public UObject.FTwoVectors LeaveTangent;
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
    public UObject.FQuat OutVal;
    public UObject.FQuat ArriveTangent;
    public UObject.FQuat LeaveTangent;
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
    public UObject.FLinearColor OutVal;
    public UObject.FLinearColor ArriveTangent;
    public UObject.FLinearColor LeaveTangent;
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
    public UObject.FPointer Node;
    public int ElementIndex;
  }

  public class FBoneAtom
  {
    public UObject.FQuat Rotation;
    public UObject.FVector Translation;
    public float Scale;
  }

  public class FPointer
  {
    public int Dummy;
  }

  public class FQWord
  {
    public int A;
    public int B;
  }

  public class FDouble
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
    public UObject.FPointer IndirectData;
    public int[] InlineData = new int[4];
    public int NumBits;
    public int MaxBits;
  }

  public class FSparseArray_Mirror
  {
    public List<int> Elements;
    public UObject.FBitArray_Mirror AllocationFlags;
    public int FirstFreeIndex;
    public int NumFreeIndices;
  }

  public class FSet_Mirror
  {
    public UObject.FSparseArray_Mirror Elements;
    public UObject.FPointer Hash;
    public int InlineHash;
    public int HashSize;
  }

  public class FMap_Mirror
  {
    public UObject.FSet_Mirror Pairs;
  }

  public class FMultiMap_Mirror
  {
    public UObject.FSet_Mirror Pairs;
  }

  public class FUntypedBulkData_Mirror
  {
    public UObject.FPointer VfTable;
    public int BulkDataFlags;
    public int ElementCount;
    public int BulkDataOffsetInFile;
    public int BulkDataSizeOnDisk;
    public int SavedBulkDataFlags;
    public int SavedElementCount;
    public int SavedBulkDataOffsetInFile;
    public int SavedBulkDataSizeOnDisk;
    public UObject.FPointer BulkData;
    public int LockStatus;
    public UObject.FPointer AttachedAr;
    public int bShouldFreeOnEmpty;
  }

  public class FRenderCommandFence_Mirror
  {
    public int NumPendingFences;
  }

  public class FFColorVertexBuffer_Mirror
  {
    public UObject.FPointer VfTable;
    public UObject.FPointer VertexData;
    public int Data;
    public int Stride;
    public int NumVertices;
  }

  public class FIndirectArray_Mirror
  {
    public UObject.FPointer Data;
    public int ArrayNum;
    public int ArrayMax;
  }

  public class FArray_Mirror
  {
    public UObject.FPointer Data;
    public int ArrayNum;
    public int ArrayMax;
  }

  public class FInlinePointerArray_Mirror
  {
    public UObject.FPointer InlineData;
    public UObject.FArray_Mirror SecondaryData;
  }

  public class FGuid
  {
    public int A;
    public int B;
    public int C;
    public int D;
  }

  public class FVector
  {
    public float X;
    public float Y;
    public float Z;
  }

  public class FColor
  {
    public byte B;
    public byte G;
    public byte R;
    public byte A;
  }

  public class FLinearColor
  {
    public float R;
    public float G;
    public float B;
    public float A;
  }

  public class FBox
  {
    public UObject.FVector Min;
    public UObject.FVector Max;
    public byte IsValid;
  }

  public class FVector4
  {
    public float X;
    public float Y;
    public float Z;
    public float W;
  }

  public class FVector2D
  {
    public float X;
    public float Y;
  }

  public class FTwoVectors
  {
    public UObject.FVector v1;
    public UObject.FVector v2;
  }

  public class FPlane : FVector
  {
    public float W;
  }

  public class FRotator
  {
    public int Pitch;
    public int Yaw;
    public int Roll;
  }

  public class FQuat
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
    public UObject.FSHVector R;
    public UObject.FSHVector G;
    public UObject.FSHVector B;
  }

  public class FTPOV
  {
    public UObject.FVector Location;
    public UObject.FRotator Rotation;
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

  public class FBoxSphereBounds
  {
    public UObject.FVector Origin;
    public UObject.FVector BoxExtent;
    public float SphereRadius;
  }

  public class FMatrix
  {
    public UObject.FPlane XPlane;
    public UObject.FPlane YPlane;
    public UObject.FPlane ZPlane;
    public UObject.FPlane WPlane;
  }

  public class FCylinder
  {
    public float Radius;
    public float Height;
  }

  public class FPackedNormal
  {
  }

  public class FVector2DHalf
  {
  }

  public class FSphere
  {
  }

  public class FQuantizedSHVector
  {
  }

  public class FQuantizedSHVectorRGB
  {
  }

  public class FWordBulkData
  {
  }

  public class FIntBulkData
  {
  }

  public class FURL
  {
  }

  public class FGuidPair
  {
  }

  public class FPushedState
  {
  }

  public class FStateFrame
  {
  }

  public class FTextureLookup
  {
  }

  public class FMaterial
  {
  }

  public class FMaterialResource
  {
  }

  public FPointer VfTableObject;
  public int ObjectInternalInteger;
  public ulong ObjectFlags;
  public UObject HashNext;
  public UObject HashOuterNext;
  public FStateFrame StateFrame;
  public ULinker Linker;
  public int LinkerIndex;
  public int NetIndex;
  public UObject Outer;
  public FName Name;
  public UClass Class;
  public UObject ObjectArchetype;
}

public class UComponent : UObject
{
  public UClass TemplateOwnerClass;
  public FName TemplateName;
}

public class UInterface : UObject
{
}

public class USubsystem : UObject
{
  public FPointer VfTable_FExec;
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

  public FPointer VfTable_FCurveEdInterface;
  public bool bCanBeBaked;
  public bool bIsDirty;
}

public class UDistributionVector : UComponent
{
  public class FRawDistributionVector : FRawDistribution
  {
    public UDistributionVector Distribution;
  }

  public FPointer VfTable_FCurveEdInterface;
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

public class UTextBuffer : UObject
{
  public int Pos;
  public string Text;
  public int Top;
}

public class UMetaData : UObject
{
  public Dictionary<UObject, Dictionary<FName, string>> ObjectMetaDataMap;
}

public class UObjectRedirector : UObject
{
  public UObject DestinationObject;
}

public class UPackage : UObject
{
  public class FLevelGuids
  {
  }

  public bool bHasBeenFullyLoaded;
  public bool bIsBound;
  public int CurrentNumNetObjects;
  public Dictionary<FGuid, UObject> ExportGuids;
  public int FileSize;
  public FName FolderName;
  public FName ForcedExportBasePackageName;
  public List<int> GenerationNetObjectCount;
  public FGuid Guid;
  public List<FLevelGuids> ImportGuids;
  public float LoadTime;
  public List<UObject> NetObjects;
  public uint PackageFlags;
}

public class ULinker : UObject
{
  public class FCompressedChunk
  {
  }

  public class FGenerationInfo
  {
  }

  public class FPackageFileSummary
  {
  }

  public class FObjectImport
  {
  }

  public class FObjectExport
  {
  }

  public string Basepath;
  public List<List<int>> DependsMap;
  public Dictionary<FGuid, int> ExportGuidsAwaitingLookup;
  public List<FObjectExport> ExportMap;
  public string Filename;
  public string Filepath;
  public List<FObjectImport> ImportMap;
  public UPackage LinkerRoot;
  public List<int> NameMap;
  public FPointer PrecachedBuffer;
  public int PrecachedBufferSize;
  public FPackageFileSummary Summary;
}

public class UField : UObject
{
  public UField Next;
  public UField SuperField;
}

public class UConst : UField
{
  public string Value;
}

public class UEnum : UField
{
  public List<FName> Names;
}

public class UProperty : UField
{
  public int ArrayDim;
  public FName ArraySizeEnum;
  public FName Category;
  public ulong PropertyFlags;
  public ushort RepOffset;
}

public class UStruct : UField
{
  public class FPropertyTag
  {
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

public class UFunction : UStruct
{
  public FName FriendlyName;
  public uint FunctionFlags;
  public ushort NativeIndex;
  public byte OperatorPrecedence;
  public ushort ReplicationOffset;
}

public class UScriptStruct : UStruct
{
  public List<byte> StructDefaults;
  public uint StructFlags;
}

public class UState : UStruct
{
  public Dictionary<FName, UFunction> FuncMap;
  public ushort LabelTableOffset;
  public uint ProbeMask;
  public uint StateFlags;
}

public class UClass : UState
{
  public class FImplementedInterface
  {
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

public class UArrayProperty : UProperty
{
  public UProperty Inner;
}

public class UBoolProperty : UProperty
{
  public uint BitMask;
}

public class UByteProperty : UProperty
{
  public UEnum Enum;
}

public class UDelegateProperty : UProperty
{
  public UFunction Function;
  public UFunction SourceDelegate;
}

public class UFloatProperty : UProperty
{
}

public class UInterfaceProperty : UProperty
{
  public UClass InterfaceClass;
}

public class UIntProperty : UProperty
{
}

public class UMapProperty : UProperty
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

public class UStructProperty : UProperty
{
  public UScriptStruct Struct;
}

public class UObjectProperty : UProperty
{
  public UClass PropertyClass;
}

public class UClassProperty : UObjectProperty
{
  public UClass MetaClass;
}

public class UComponentProperty : UObjectProperty
{
}

