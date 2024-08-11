/*===========================================================================
 *  This file was automatically generated. DO NOT modify!
===========================================================================*/
namespace ue3;

public enum ECryptReturnValue
{
  UNKNOWN_ERROR,
  CRYPT_SUCCESS,
  ENCRYPTION_ERROR_ALGORITHM_IS_NULL,
  ENCRYPTION_ERROR_BUFFERSIZE_IS_NULL,
  ENCRYPTION_ERROR_AESKEY_SETTING,
  DECRYPTION_ERROR_ALGORITHM_IS_NULL,
  DECRYPTION_ERROR_BUFFERSIZE_IS_NULL,
  DECRYPTION_ERROR_AESKEY_SETTING,
  DECRYPTION_ERROR_MD5_CHECK,
  ECryptReturnValue_MAX,
}

public class UOnlineSubsystemPC : UOnlineSubsystemCommonImpl
{
  public string ProfileDataDirectory;
  public string ProfileDataExtension;
  public List<FScriptDelegate> ReadProfileSettingsDelegates;
  public List<FScriptDelegate> WriteProfileSettingsDelegates;
  public UOnlineProfileSettings CachedProfile;
  public FScriptDelegate __OnReadProfileSettingsComplete__Delegate;
  public FScriptDelegate __OnWriteProfileSettingsComplete__Delegate;
  public FScriptDelegate __OnLoginChange__Delegate;
  public FScriptDelegate __OnLoginCancelled__Delegate;
  public FScriptDelegate __OnMutingChange__Delegate;
  public FScriptDelegate __OnFriendsChange__Delegate;
  public FScriptDelegate __OnLoginFailed__Delegate;
  public FScriptDelegate __OnLogoutCompleted__Delegate;
  public FScriptDelegate __OnLoginStatusChange__Delegate;
  public FScriptDelegate __OnReadFriendsComplete__Delegate;
  public FScriptDelegate __OnKeyboardInputComplete__Delegate;
  public FScriptDelegate __OnAddFriendByNameComplete__Delegate;
  public FScriptDelegate __OnFriendInviteReceived__Delegate;
  public FScriptDelegate __OnReceivedGameInvite__Delegate;
  public FScriptDelegate __OnJoinFriendGameComplete__Delegate;
  public FScriptDelegate __OnFriendMessageReceived__Delegate;
  public FScriptDelegate __OnWritePlayerStorageComplete__Delegate;
  public FScriptDelegate __OnReadPlayerStorageForNetIdComplete__Delegate;
  public FScriptDelegate __OnReadPlayerStorageComplete__Delegate;
  public FScriptDelegate __OnReadAchievementsComplete__Delegate;
  public FScriptDelegate __OnUnlockAchievementComplete__Delegate;
}

public class UPacket : UObject
{
  public class FData
  {
    public byte[] data_size = new byte[2];
    public byte[] Command = new byte[2];
    public byte[] Buffer = new byte[2048];
  }

  public FData _data;
  public FPointer Buffer;
  public int total_size;
  public int st_point;
  public int Point;
  public bool mcopy;
}

public class USFPacketCryptHelper : UObject
{
  public byte[] Key = new byte[17];
  public int KeyLengthMaxForCPP;
}

