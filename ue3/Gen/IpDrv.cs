/*===========================================================================
 *  This file was automatically generated. DO NOT modify!
===========================================================================*/
namespace ue3;

public enum ELinkMode
{
  MODE_Text,
  MODE_Line,
  MODE_Binary,
  MODE_MAX,
}

public enum ELineMode
{
  LMODE_auto,
  LMODE_DOS,
  LMODE_UNIX,
  LMODE_MAC,
  LMODE_MAX,
}

public enum EReceiveMode
{
  RMODE_Manual,
  RMODE_Event,
  RMODE_MAX,
}

public enum EMeshBeaconPacketType
{
  MB_Packet_UnknownType,
  MB_Packet_ClientNewConnectionRequest,
  MB_Packet_ClientBeginBandwidthTest,
  MB_Packet_ClientCreateNewSessionResponse,
  MB_Packet_HostNewConnectionResponse,
  MB_Packet_HostBandwidthTestRequest,
  MB_Packet_HostCompletedBandwidthTest,
  MB_Packet_HostTravelRequest,
  MB_Packet_HostCreateNewSessionRequest,
  MB_Packet_DummyData,
  MB_Packet_Heartbeat,
  MB_Packet_MAX,
}

public enum EMeshBeaconConnectionResult
{
  MB_ConnectionResult_Succeeded,
  MB_ConnectionResult_Duplicate,
  MB_ConnectionResult_Timeout,
  MB_ConnectionResult_Error,
  MB_ConnectionResult_MAX,
}

public enum EMeshBeaconBandwidthTestState
{
  MB_BandwidthTestState_NotStarted,
  MB_BandwidthTestState_RequestPending,
  MB_BandwidthTestState_StartPending,
  MB_BandwidthTestState_InProgress,
  MB_BandwidthTestState_Completed,
  MB_BandwidthTestState_Incomplete,
  MB_BandwidthTestState_Timeout,
  MB_BandwidthTestState_Error,
  MB_BandwidthTestState_MAX,
}

public enum EMeshBeaconBandwidthTestResult
{
  MB_BandwidthTestResult_Succeeded,
  MB_BandwidthTestResult_Timeout,
  MB_BandwidthTestResult_Error,
  MB_BandwidthTestResult_MAX,
}

public enum EMeshBeaconBandwidthTestType
{
  MB_BandwidthTestType_Upstream,
  MB_BandwidthTestType_Downstream,
  MB_BandwidthTestType_RoundtripLatency,
  MB_BandwidthTestType_MAX,
}

public enum EMeshBeaconClientState
{
  MBCS_None,
  MBCS_Connecting,
  MBCS_Connected,
  MBCS_ConnectionFailed,
  MBCS_AwaitingResponse,
  MBCS_Closed,
  MBCS_MAX,
}

public enum EEventUploadType
{
  EUT_GenericStats,
  EUT_ProfileData,
  EUT_HardwareData,
  EUT_MatchmakingData,
  EUT_MAX,
}

public enum EReservationPacketType
{
  RPT_UnknownPacketType,
  RPT_ClientReservationRequest,
  RPT_ClientReservationUpdateRequest,
  RPT_ClientCancellationRequest,
  RPT_HostReservationResponse,
  RPT_HostReservationCountUpdate,
  RPT_HostTravelRequest,
  RPT_HostIsReady,
  RPT_HostHasCancelled,
  RPT_Heartbeat,
  RPT_MAX,
}

public enum EPartyReservationResult
{
  PRR_GeneralError,
  PRR_PartyLimitReached,
  PRR_IncorrectPlayerCount,
  PRR_RequestTimedOut,
  PRR_ReservationDuplicate,
  PRR_ReservationNotFound,
  PRR_ReservationAccepted,
  PRR_ReservationDenied,
  PRR_MAX,
}

public enum EPartyBeaconClientState
{
  PBCS_None,
  PBCS_Connecting,
  PBCS_Connected,
  PBCS_ConnectionFailed,
  PBCS_AwaitingResponse,
  PBCS_Closed,
  PBCS_MAX,
}

public enum EPartyBeaconClientRequest
{
  PBClientRequest_NewReservation,
  PBClientRequest_UpdateReservation,
  PBClientRequest_MAX,
}

public enum EPartyBeaconHostState
{
  PBHS_AllowReservations,
  PBHS_DenyReservations,
  PBHS_MAX,
}

public enum ELinkState
{
  STATE_Initialized,
  STATE_Ready,
  STATE_Listening,
  STATE_Connecting,
  STATE_Connected,
  STATE_ListenClosePending,
  STATE_ConnectClosePending,
  STATE_ListenClosing,
  STATE_ConnectClosing,
  STATE_MAX,
}

public enum ERequestType
{
  Request_GET,
  Request_POST,
  Request_MAX,
}

public class UClientBeaconAddressResolver : UObject
{
  public int BeaconPort;
  public FName BeaconName;
}

public class UWebApplication : UObject
{
  public AWorldInfo WorldInfo;
  public AWebServer WebServer;
  public string Path;
}

public class UHelloWeb : UWebApplication
{
}

public class UImageServer : UWebApplication
{
}

public class UIniLocPatcherMcp : UIniLocPatcher
{
  public FName McpDownloaderName;
  public UOnlineTitleFileDownloadMcp Downloader;
}

public class AInternetLink : AInfo
{
  public class FIpAddr
  {
    public int Addr;
    public int Port;
  }

  public ELinkMode LinkMode;
  public ELineMode InLineMode;
  public ELineMode OutLineMode;
  public EReceiveMode ReceiveMode;
  public FPointer Socket;
  public int Port;
  public FPointer RemoteSocket;
  public FPointer PrivateResolveInfo;
  public int DataPending;
}

public class UMCPBase : UObject
{
  public FPointer VfTable_FTickableObject;
}

public class UMeshBeacon : UObject
{
  public class FConnectionBandwidthStats
  {
    public int UpstreamRate;
    public int DownstreamRate;
    public int RoundtripLatency;
  }

  public class FPlayerMember
  {
    public int TeamNum;
    public int Skill;
    public UOnlineSubsystem.FUniqueNetId NetId;
  }

  public FPointer VfTable_FTickableObject;
  public int MeshBeaconPort;
  public FPointer Socket;
  public bool bIsInTick;
  public bool bWantsDeferredDestroy;
  public bool bShouldTick;
  public float HeartbeatTimeout;
  public float ElapsedHeartbeatTime;
  public FName BeaconName;
  public int SocketSendBufferSize;
  public int SocketReceiveBufferSize;
  public int MaxBandwidthTestBufferSize;
  public int MinBandwidthTestBufferSize;
  public float MaxBandwidthTestSendTime;
  public float MaxBandwidthTestReceiveTime;
  public int MaxBandwidthHistoryEntries;
}

public class UMeshBeaconClient : UMeshBeacon
{
  public class FClientConnectionRequest
  {
    public UOnlineSubsystem.FUniqueNetId PlayerNetId;
    public ENATType NatType;
    public bool bCanHostVs;
    public float GoodHostRatio;
    public List<UMeshBeacon.FConnectionBandwidthStats> BandwidthHistory;
    public int MinutesSinceLastTest;
  }

  public class FClientBandwidthTestData
  {
    public EMeshBeaconBandwidthTestType TestType;
    public EMeshBeaconBandwidthTestState CurrentState;
    public int NumBytesToSendTotal;
    public int NumBytesSentTotal;
    public int NumBytesSentLast;
    public float ElapsedTestTime;
  }

  public UOnlineGameSearch.FOnlineGameSearchResult HostPendingRequest;
  public FClientConnectionRequest ClientPendingRequest;
  public FClientBandwidthTestData CurrentBandwidthTest;
  public EMeshBeaconClientState ClientBeaconState;
  public EMeshBeaconPacketType ClientBeaconRequestType;
  public float ConnectionRequestTimeout;
  public float ConnectionRequestElapsedTime;
  public string ResolverClassName;
  public UClass ResolverClass;
  public UClientBeaconAddressResolver Resolver;
  public bool bUsingRegisteredAddr;
  public FScriptDelegate __OnConnectionRequestResult__Delegate;
  public FScriptDelegate __OnReceivedBandwidthTestRequest__Delegate;
  public FScriptDelegate __OnReceivedBandwidthTestResults__Delegate;
  public FScriptDelegate __OnTravelRequestReceived__Delegate;
  public FScriptDelegate __OnCreateNewSessionRequestReceived__Delegate;
}

public class UMeshBeaconHost : UMeshBeacon
{
  public class FClientConnectionBandwidthTestData
  {
    public EMeshBeaconBandwidthTestState CurrentState;
    public EMeshBeaconBandwidthTestType TestType;
    public int BytesTotalNeeded;
    public int BytesReceived;
    public double RequestTestStartTime;
    public double TestStartTime;
    public UMeshBeacon.FConnectionBandwidthStats BandwidthStats;
  }

  public class FClientMeshBeaconConnection
  {
    public UOnlineSubsystem.FUniqueNetId PlayerNetId;
    public float ElapsedHeartbeatTime;
    public UObject.FPointer Socket;
    public bool bConnectionAccepted;
    public UMeshBeaconHost.FClientConnectionBandwidthTestData BandwidthTest;
    public ENATType NatType;
    public bool bCanHostVs;
    public float GoodHostRatio;
    public List<UMeshBeacon.FConnectionBandwidthStats> BandwidthHistory;
    public int MinutesSinceLastTest;
  }

  public List<FClientMeshBeaconConnection> ClientConnections;
  public List<UOnlineSubsystem.FUniqueNetId> PendingPlayerConnections;
  public UOnlineSubsystem.FUniqueNetId OwningPlayerId;
  public bool bAllowBandwidthTesting;
  public int ConnectionBacklog;
  public FScriptDelegate __OnReceivedClientConnectionRequest__Delegate;
  public FScriptDelegate __OnStartedBandwidthTest__Delegate;
  public FScriptDelegate __OnFinishedBandwidthTest__Delegate;
  public FScriptDelegate __OnAllPendingPlayersConnected__Delegate;
  public FScriptDelegate __OnReceivedClientCreateNewSessionResult__Delegate;
}

public class UOnlineEventsInterfaceMcp : UMCPBase
{
  public class FEventUploadConfig
  {
    public EEventUploadType UploadType;
    public string UploadUrl;
    public float TimeOut;
    public bool bUseCompression;
  }

  public List<FEventUploadConfig> EventUploadConfigs;
  public List<FPointer> HttpPostObjects;
  public List<EEventUploadType> DisabledUploadTypes;
  public bool bBinaryStats;
}

public class UOnlineGameInterfaceImpl : UObject
{
  public UOnlineSubsystemCommonImpl OwningSubsystem;
  public UOnlineGameSettings GameSettings;
  public UOnlineGameSearch GameSearch;
  public EOnlineGameState CurrentGameState;
  public ELanBeaconState LanBeaconState;
  public byte[] LanNonce = new byte[8];
  public List<FScriptDelegate> CreateOnlineGameCompleteDelegates;
  public List<FScriptDelegate> UpdateOnlineGameCompleteDelegates;
  public List<FScriptDelegate> DestroyOnlineGameCompleteDelegates;
  public List<FScriptDelegate> JoinOnlineGameCompleteDelegates;
  public List<FScriptDelegate> StartOnlineGameCompleteDelegates;
  public List<FScriptDelegate> EndOnlineGameCompleteDelegates;
  public List<FScriptDelegate> FindOnlineGamesCompleteDelegates;
  public List<FScriptDelegate> CancelFindOnlineGamesCompleteDelegates;
  public int LanAnnouncePort;
  public int LanGameUniqueId;
  public int LanPacketPlatformMask;
  public float LanQueryTimeLeft;
  public float LanQueryTimeout;
  public FPointer LanBeacon;
  public FPointer SessionInfo;
  public FScriptDelegate __OnFindOnlineGamesComplete__Delegate;
  public FScriptDelegate __OnCreateOnlineGameComplete__Delegate;
  public FScriptDelegate __OnUpdateOnlineGameComplete__Delegate;
  public FScriptDelegate __OnDestroyOnlineGameComplete__Delegate;
  public FScriptDelegate __OnCancelFindOnlineGamesComplete__Delegate;
  public FScriptDelegate __OnJoinOnlineGameComplete__Delegate;
  public FScriptDelegate __OnRegisterPlayerComplete__Delegate;
  public FScriptDelegate __OnUnregisterPlayerComplete__Delegate;
  public FScriptDelegate __OnStartOnlineGameComplete__Delegate;
  public FScriptDelegate __OnEndOnlineGameComplete__Delegate;
  public FScriptDelegate __OnArbitrationRegistrationComplete__Delegate;
  public FScriptDelegate __OnGameInviteAccepted__Delegate;
}

public class UOnlineNewsInterfaceMcp : UMCPBase
{
  public class FNewsCacheEntry
  {
    public string NewsUrl;
    public EOnlineEnumerationReadState ReadState;
    public EOnlineNewsType NewsType;
    public string NewsItem;
    public float TimeOut;
    public bool bIsUnicode;
    public UObject.FPointer HttpDownloader;
  }

  public List<FNewsCacheEntry> NewsItems;
  public List<FScriptDelegate> ReadNewsDelegates;
  public bool bNeedsTicking;
  public FScriptDelegate __OnReadNewsCompleted__Delegate;
}

public class UOnlineSubsystemCommonImpl : UOnlineSubsystem
{
  public FPointer VoiceEngine;
  public int MaxLocalTalkers;
  public int MaxRemoteTalkers;
  public bool bIsUsingSpeechRecognition;
  public UOnlineGameInterfaceImpl GameInterfaceImpl;
}

public class UOnlineTitleFileDownloadMcp : UMCPBase
{
  public List<FScriptDelegate> ReadTitleFileCompleteDelegates;
  public List<UOnlineSubsystem.FTitleFile> TitleFiles;
  public FPointer HttpDownloader;
  public int CurrentIndex;
  public string BaseUrl;
  public float TimeOut;
  public FScriptDelegate __OnReadTitleFileComplete__Delegate;
}

public class UPartyBeacon : UObject
{
  public class FPlayerReservation
  {
    public UOnlineSubsystem.FUniqueNetId NetId;
    public int Skill;
    public int XpLevel;
    public double Mu;
    public double Sigma;
    public float ElapsedSessionTime;
  }

  public class FPartyReservation
  {
    public int TeamNum;
    public UOnlineSubsystem.FUniqueNetId PartyLeader;
    public List<UPartyBeacon.FPlayerReservation> PartyMembers;
  }

  public FPointer VfTable_FTickableObject;
  public int PartyBeaconPort;
  public FPointer Socket;
  public bool bIsInTick;
  public bool bWantsDeferredDestroy;
  public bool bShouldTick;
  public float HeartbeatTimeout;
  public float ElapsedHeartbeatTime;
  public FName BeaconName;
  public FScriptDelegate __OnDestroyComplete__Delegate;
}

public class UPartyBeaconClient : UPartyBeacon
{
  public UOnlineGameSearch.FOnlineGameSearchResult HostPendingRequest;
  public FPartyReservation PendingRequest;
  public EPartyBeaconClientState ClientBeaconState;
  public EPartyBeaconClientRequest ClientBeaconRequestType;
  public float ReservationRequestTimeout;
  public float ReservationRequestElapsedTime;
  public string ResolverClassName;
  public UClass ResolverClass;
  public UClientBeaconAddressResolver Resolver;
  public FScriptDelegate __OnReservationRequestComplete__Delegate;
  public FScriptDelegate __OnReservationCountUpdated__Delegate;
  public FScriptDelegate __OnTravelRequestReceived__Delegate;
  public FScriptDelegate __OnHostIsReady__Delegate;
  public FScriptDelegate __OnHostHasCancelled__Delegate;
}

public class UPartyBeaconHost : UPartyBeacon
{
  public class FClientBeaconConnection
  {
    public UOnlineSubsystem.FUniqueNetId PartyLeader;
    public float ElapsedHeartbeatTime;
    public UObject.FPointer Socket;
  }

  public List<FClientBeaconConnection> Clients;
  public int NumTeams;
  public int NumPlayersPerTeam;
  public int NumReservations;
  public int NumConsumedReservations;
  public List<FPartyReservation> Reservations;
  public FName OnlineSessionName;
  public int ConnectionBacklog;
  public int ReservedHostTeamNum;
  public bool bBestFitTeamAssignment;
  public EPartyBeaconHostState BeaconState;
  public FScriptDelegate __OnReservationChange__Delegate;
  public FScriptDelegate __OnReservationsFull__Delegate;
  public FScriptDelegate __OnClientCancellationReceived__Delegate;
}

public class ATcpLink : AInternetLink
{
  public ELinkState LinkState;
  public FIpAddr RemoteAddr;
  public UClass AcceptClass;
  public List<byte> SendFIFO;
  public string RecvBuf;
}

public class AWebConnection : ATcpLink
{
  public AWebServer WebServer;
  public string ReceivedData;
  public UWebRequest Request;
  public UWebResponse Response;
  public UWebApplication Application;
  public bool bDelayCleanup;
  public int RawBytesExpecting;
  public int MaxValueLength;
  public int MaxLineLength;
  public int ConnId;
}

public class UWebRequest : UObject
{
  public string RemoteAddr;
  public string URI;
  public string UserName;
  public string Password;
  public int ContentLength;
  public string ContentType;
  public ERequestType RequestType;
  public FMap_Mirror HeaderMap;
  public FMap_Mirror VariableMap;
}

public class UWebResponse : UObject
{
  public List<string> headers;
  public FMap_Mirror ReplacementMap;
  public string IncludePath;
  public string CharSet;
  public AWebConnection Connection;
  public bool bSentText;
  public bool bSentResponse;
}

public class AWebServer : ATcpLink
{
  public string ServerName;
  public string[] Applications = new string[10];
  public string[] ApplicationPaths = new string[10];
  public bool bEnabled;
  public int ListenPort;
  public int MaxConnections;
  public int DefaultApplication;
  public int ExpirationSeconds;
  public string ServerURL;
  public UWebApplication[] ApplicationObjects = new UWebApplication[10];
  public int ConnectionCount;
  public int ConnId;
}

