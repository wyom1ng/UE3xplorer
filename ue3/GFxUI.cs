/*===========================================================================
 *  This file was automatically generated. DO NOT modify!
===========================================================================*/
namespace ue3;

public enum FlashTextureRescale
{
  FlashTextureScale_High,
  FlashTextureScale_Low,
  FlashTextureScale_NextLow,
  FlashTextureScale_Mult4,
  FlashTextureScale_None,
  FlashTextureScale_MAX,
}

public enum GFxScaleMode
{
  SM_NoScale,
  SM_ShowAll,
  SM_ExactFit,
  SM_NoBorder,
  SM_MAX,
}

public enum GFxAlign
{
  Align_Center,
  Align_TopCenter,
  Align_BottomCenter,
  Align_CenterLeft,
  Align_CenterRight,
  Align_TopLeft,
  Align_TopRight,
  Align_BottomLeft,
  Align_BottomRight,
  Align_MAX,
}

public enum GFxTimingMode
{
  TM_Game,
  TM_Real,
  TM_MAX,
}

public enum GFxRenderTextureMode
{
  RTM_Opaque,
  RTM_Alpha,
  RTM_AlphaComposite,
  RTM_MAX,
}

public enum ASType
{
  AS_Undefined,
  AS_Null,
  AS_Number,
  AS_Int,
  AS_String,
  AS_Boolean,
  AS_MAX,
}

public class UGFxRawData : UObject
{
  public List<byte> RawData;
  public List<string> ReferencedSwfs;
  public List<UObject> References;
  public List<UObject> UserReferences;
}

public class USwfMovie : UGFxRawData
{
  public bool bUsesFontlib;
  public bool bSetSRGBOnImportedTextures;
  public bool bPackTextures;
  public bool bForceSquarePacking;
  public string SourceFile;
  public int PackTextureSize;
  public FlashTextureRescale TextureRescale;
  public string TextureFormat;
  public string SourceFileTimestamp;
  public int RTTextures;
  public int RTVideoTextures;
  public ulong ImportTimeStamp;
}

public class UFlashMovie : USwfMovie
{
}

public class UGFxAction_CloseMovie : USequenceAction
{
  public UGFxMoviePlayer Movie;
  public bool bUnload;
}

public class UGFxAction_GetVariable : USequenceAction
{
  public UGFxMoviePlayer Movie;
  public string Variable;
}

public class UGFxMoviePlayer : UObject
{
  public class FExternalTexture
  {
    public string Resource;
    public UTexture Texture;
  }

  public class FSoundThemeBinding
  {
    public FName ThemeName;
    public UUISoundTheme Theme;
    public string ThemeClassName;
  }

  public class FGFxWidgetBinding
  {
    public FName WidgetName;
    public UClass WidgetClass;
    public int WidgetIndex;
  }

  public class FASValue
  {
    public ASType Type;
    public bool B;
    public float N;
    public int I;
    public string S;
  }

  public FPointer pMovie;
  public FPointer pCaptureKeys;
  public FPointer pFocusIgnoreKeys;
  public Dictionary<byte, byte> ASUClasses;
  public Dictionary<byte, byte> ASUObjects;
  public int NextASUObject;
  public USwfMovie MovieInfo;
  public bool bMovieIsOpen;
  public bool bDisplayWithHudOff;
  public bool bEnableGammaCorrection;
  public bool bWidgetsInitializedThisFrame;
  public bool bLogUnhandedWidgetInitializations;
  public bool IsIMECandidateOpen;
  public bool IsIMECompositionStart;
  public bool bDoNotAdvance;
  public bool bDoNotRender;
  public bool bDoNotRenderTexture;
  public bool bAllowInput;
  public bool bAllowFocus;
  public bool bAutoPlay;
  public bool bPauseGameWhileActive;
  public bool bDisableWorldRendering;
  public bool bCaptureWorldRendering;
  public bool bCloseOnLevelChange;
  public bool bOnlyOwnerFocusable;
  public bool bForceFullViewport;
  public bool bDiscardNonOwnerInput;
  public bool bCaptureInput;
  public bool bCaptureMouseInput;
  public bool bIgnoreMouseInput;
  public bool bIsSplitscreenLayoutModified;
  public bool bShowHardwareMouseCursor;
  public bool bBlurLesserMovies;
  public bool bHideLesserMovies;
  public bool bIsPriorityBlurred;
  public bool bIsPriorityHidden;
  public bool bIgnoreVisibilityEffect;
  public bool bIgnoreBlurEffect;
  public UTextureRenderTarget2D RenderTexture;
  public int LocalPlayerOwnerIndex;
  public UObject ExternalInterface;
  public List<FName> CaptureKeys;
  public List<FName> FocusIgnoreKeys;
  public ESceneDepthPriorityGroup SceneDPG;
  public GFxTimingMode TimingMode;
  public GFxRenderTextureMode RenderTextureMode;
  public byte Priority;
  public List<FExternalTexture> ExternalTextures;
  public List<FSoundThemeBinding> SoundThemes;
  public List<FGFxWidgetBinding> WidgetBindings;
  public Dictionary<byte, byte> WidgetPathBindings;
  public string IMECompositingString;
  public float fIMECandidateCloseTime;
  public float fIMECompositionEndTime;
  public int IMEConversion;
  public float IMEKeyInputDisableTime;
  public List<UGFxObject> ObjectValues;
  public UGFxObject SplitscreenLayoutObject;
  public int SplitscreenLayoutYAdjust;
  public List<UObject> ExternalInterfaceListener;
  public FScriptDelegate __OnPostAdvance__Delegate;
}

public class UGFxAction_Invoke : USequenceAction
{
  public UGFxMoviePlayer Movie;
  public string MethodName;
  public List<UGFxMoviePlayer.FASValue> Arguments;
}

public class UGFxAction_OpenMovie : USequenceAction
{
  public USwfMovie Movie;
  public UClass MoviePlayerClass;
  public UGFxMoviePlayer MoviePlayer;
  public bool bTakeFocus;
  public bool bCaptureInput;
  public bool bStartPaused;
  public bool bEnableGammaCorrection;
  public bool bDisplayWithHudOff;
  public GFxRenderTextureMode RenderTextureMode;
  public UTextureRenderTarget2D RenderTexture;
  public List<FName> CaptureKeys;
  public List<FName> FocusIgnoreKeys;
}

public class UGFxAction_SetCaptureKeys : USequenceAction
{
  public UGFxMoviePlayer Movie;
  public List<FName> CaptureKeys;
}

public class UGFxAction_SetVariable : USequenceAction
{
  public UGFxMoviePlayer Movie;
  public string Variable;
}

public class UGFxObject : UObject
{
  public class FASDisplayInfo
  {
    public float X;
    public float Y;
    public float Z;
    public float Rotation;
    public float XRotation;
    public float YRotation;
    public float XScale;
    public float YScale;
    public float ZScale;
    public float Alpha;
    public bool Visible;
    public bool hasX;
    public bool hasY;
    public bool hasZ;
    public bool hasRotation;
    public bool hasXRotation;
    public bool hasYRotation;
    public bool hasXScale;
    public bool hasYScale;
    public bool hasZScale;
    public bool hasAlpha;
    public bool hasVisible;
  }

  public class FASColorTransform
  {
    public UObject.FLinearColor Multiply;
    public UObject.FLinearColor Add;
  }

  public int[] Value = new int[12];
  public List<UGFxMoviePlayer.FGFxWidgetBinding> SubWidgetBindings;
}

public class UGFxClikWidget : UGFxObject
{
  public class FEventData
  {
    public UGFxObject _this;
    public UGFxObject Target;
    public string Type;
    public UGFxObject Data;
    public int mouseIndex;
    public int Button;
    public int Index;
    public int lastIndex;
  }

  public FScriptDelegate __EventListener__Delegate;
}

public class UGFxEngine : UObject
{
  public class FGCReference
  {
    public UObject m_object;
    public int m_count;
    public int m_statid;
  }

  public List<FGCReference> GCReferences;
  public int RefCount;
}

public class UGFxEvent_FSCommand : USequenceEvent
{
  public USwfMovie Movie;
  public string FSCommand;
  public UGFxFSCmdHandler_Kismet Handler;
}

public class UGFxFSCmdHandler : UObject
{
}

public class UGFxFSCmdHandler_Kismet : UGFxFSCmdHandler
{
}

public class UGFxInteraction : UInteraction
{
  public FPointer VfTable_FCallbackEventDevice;
  public bool bFakeMobileTouches;
}

