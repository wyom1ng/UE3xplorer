﻿using ue3bootstrap.Patch.Engine;

namespace ue3bootstrap.Patch.Core;

[Native]
public class UObject
{
  [Native]
  public class FQWord
  {
  }

  [Native]
  public class FPointer
  {
  }

  [Native]
  public class FColor
  {
  }

  [Native]
  public class FLinearColor
  {
  }

  [Native]
  public class FPackedNormal
  {
    public uint Packed;
  }

  [Native]
  public class FDouble
  {
  }

  [Native]
  public class FVector2D
  {
  }

  [Native]
  public class FVector2DHalf
  {
    public ushort X;
    public ushort Y;
  }

  [Native]
  public class FVector
  {
  }

  [Native]
  public class FVector4
  {
  }

  [Native]
  public class FTwoVectors
  {
  }

  [Native]
  public class FRotator
  {
  }

  [Native]
  public class FPlane
  {
  }

  [Native]
  public class FQuat
  {
  }

  [Native]
  public class FMatrix
  {
  }

  [Native]
  public class FBox
  {
  }

  [Native]
  public class FSphere
  {
    public FVector Center;
    public float W;
  }

  [Native]
  public class FBoxSphereBounds
  {
  }

  [Native]
  public class FQuantizedSHVector
  {
    public ushort MaxCoefficient;
    public ushort MinCoefficient;
    public char[] V = new char[9];
  }

  [Native]
  public class FQuantizedSHVectorRGB
  {
    public FQuantizedSHVector B;
    public FQuantizedSHVector G;
    public FQuantizedSHVector R;
  }

  [Native]
  public class FUntypedBulkData_Mirror
  {
    public List<char> BulkData;
  }

  public class FWordBulkData : FUntypedBulkData_Mirror
  {
  }

  public class FIntBulkData : FUntypedBulkData_Mirror
  {
  }

  [Native]
  public class FURL
  {
    public string Host;
    public string Map;
    public List<string> Op;
    public int Port;
    public string Portal;
    public string Protocol;
    public int Valid;
  }

  [Native]
  public class FGuid
  {
  }

  [Native]
  public class FGuidPair
  {
    public FGuid Guid;
    public uint RefId;
  }

  [Native]
  public class FPushedState
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
    public List<FPushedState> StateStack;
  }

  [Native]
  public class FTextureLookup
  {
    public int TexCoordIndex;
    public int TextureIndex;
    public float UScale;
    public float VScale;
  }

  // these two really belong to UMaterialInterface, but I put them here, so we can always make the assumption that every struct used by a class is contained within its hierarchy
  // since FMaterial is used under UMaterialInterface, but also under ATerrain, this is the only common class they derive both from
  [Native]
  public class FMaterial
  {
    public bool bUsesDynamicParameter;
    public bool bUsesLightmapUVs;
    public bool bUsesMaterialVertexPositionOffset;
    public bool bUsesSceneColor;
    public bool bUsesSceneDepth;
    public List<string> CompileErrors;

    public uint DummyDroppedFallbackComponents;
    public FGuid Id;
    public int MaxTextureDependencyLength;
    public uint NumUserTexCoords;
    public Dictionary<UMaterialExpression, int> TextureDependencyLengthMap;
    public List<FTextureLookup> TextureLookups;
    public List<UTexture> UniformExpressionTextures;
    public uint unknown8C;
    public uint UsingTransforms;
  }

  public class FMaterialResource : FMaterial
  {
    public UMaterial Material;
  }
  
  public UObject HashNext;
  public UObject HashOuterNext;
  public ULinker Linker;
  public int LinkerIndex;
  public FStateFrame StateFrame;

}

public class UComponent : UObject
{
  public FName TemplateName;
  public UClass TemplateOwnerClass;
}

[Native]
public class UTextBuffer : UObject
{
  public int Pos;
  public string Text;
  public int Top;
}

[Native]
public class UMetaData : UObject
{
  public Dictionary<UObject, Dictionary<FName, string>> ObjectMetaDataMap;
}

[Native]
public class UObjectRedirector : UObject
{
  public UObject DestinationObject;
}

[Native]
public class UPackage : UObject
{
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

  [Native]
  public class FLevelGuids
  {
    public List<FGuid> Guids;
    public FName LevelName;
  }
}

[Native]
public class ULinker : UObject
{
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

  [Native]
  public class FCompressedChunk
  {
    public int CompressedOffset;
    public int CompressedSize;
    public int UncompressedOffset;
    public int UncompressedSize;
  }

  public class FGenerationInfo
  {
    public int ExportCount;
    public int NameCount;
    public int NetObjectCount;
  }

  [Native]
  public class FPackageFileSummary
  {
    public List<string> AdditionalPackagesToCook;
    public List<FCompressedChunk> CompressedChunks;
    public uint CompressionFlags;
    public int CookedContentVersion;
    public int DependsOffset;
    public int EngineVersion;
    public int ExportCount;
    public int ExportGuidsCount;
    public int ExportOffset;
    public ushort FileVersion;
    public ushort FileVersionLicensee;
    public string FolderName;
    public List<FGenerationInfo> Generations;
    public FGuid Guid;
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

  [Native]
  public class FObjectImport
  {
    public FName ClassName;

    public FName ClassPackage;
    public FName ObjectName;
    public int OuterIndex;
    public int SourceIndex;
    public ULinker SourceLinker;
    public UObject XObject;
  }

  [Native]
  public class FObjectExport
  {
    public int _iHashNext;
    public UObject _Object;
    public int ArchetypeIndex;

    public int ClassIndex;
    public uint ExportFlags;
    public List<int> GenerationNetObjectCount;
    public ulong ObjectFlags;
    public FName ObjectName;
    public int OuterIndex;
    public uint PackageFlags;
    public FGuid PackageGuid;
    public int ScriptSerializationEndOffset;
    public int ScriptSerializationStartOffset;
    public int SerialOffset;
    public int SerialSize;
    public int SuperIndex;
  }
}

[Native]
public class UField : UObject
{
  public UField Next;
  public UField SuperField;
}

[Native]
public class UConst : UField
{
  public string Value;
}

[Native]
public class UEnum : UField
{
  public List<FName> Names;
}

[Native]
public class UProperty : UField
{
  public int ArrayDim;
  public FName ArraySizeEnum;
  public FName Category;
  public ulong PropertyFlags;
  public ushort RepOffset;
}

[Native]
public class UStruct : UField
{
  public UField Children;
  public UTextBuffer CppText;
  public int Line;
  public int PropertiesSize;

  // in memory only
  public Dictionary<FName, UProperty> PropertyMap;
  public List<FName> PropertyOrder;
  public List<char> Script;
  public int ScriptBytecodeSize;

  public UTextBuffer ScriptText;
  public int TextPos;

  [Native]
  public class FPropertyTag
  {
    public int ArrayIndex;
    public char BoolVal;
    public FName EnumName;
    public FName Name;
    public int Size;
    public int SizeOffset;
    public FName StructName;
    public FName Type;
  }
}

[Native]
public class UFunction : UStruct
{
  public FName FriendlyName;
  public uint FunctionFlags;
  public ushort NativeIndex;
  public char OperatorPrecedence;
  public ushort ReplicationOffset;
}

[Native]
public class UScriptStruct : UStruct
{
  public List<char> StructDefaults;
  public uint StructFlags;
}

[Native]
public class UState : UStruct
{
  public Dictionary<FName, UFunction> FuncMap;
  public ushort LabelTableOffset;
  public uint ProbeMask;
  public uint StateFlags;
}

[Native]
public class UClass : UState
{
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

  [Native]
  public class FImplementedInterface
  {
    public UClass Class;
    public UProperty PointerProperty;
  }
}

[Native]
public class UArrayProperty : UProperty
{
  public UProperty Inner;
}

public class UBoolProperty : UProperty
{
  public uint BitMask;
}

[Native]
public class UByteProperty : UProperty
{
  public UEnum Enum;
}

[Native]
public class UDelegateProperty : UProperty
{
  public UFunction Function;
  public UFunction SourceDelegate;
}

public class UFloatProperty : UProperty
{
}

[Native]
public class UInterfaceProperty : UProperty
{
  public UClass InterfaceClass;
}

public class UIntProperty : UProperty
{
}

[Native]
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

[Native]
public class UStructProperty : UProperty
{
  public UScriptStruct Struct;
}

[Native]
public class UObjectProperty : UProperty
{
  public UClass PropertyClass;
}

[Native]
public class UClassProperty : UObjectProperty
{
  public UClass MetaClass;
}

public class UComponentProperty : UObjectProperty
{
}