using UnityEngine;
using PlayFab;

#if UNITY_5_3_OR_NEWER
[CreateAssetMenu(fileName = "PlayFabSharedSettings", menuName = "PlayFab/CreateSharedSettings", order = 1)]
#endif
public class PlayFabSharedSettings : ScriptableObject
{
    public string TitleId = "516EB";
    public string VerticalName = null;
#if ENABLE_PLAYFABSERVER_API || ENABLE_PLAYFABADMIN_API || UNITY_EDITOR
    public string DeveloperSecretKey = "88DORBYN6Q8FK5NOIU9U5OJ1XMJABFM3AAWDCA449PPBQE5UK7";
#endif
#if ENABLE_PLAYFABPLAYSTREAM_API && ENABLE_PLAYFABSERVER_API
    public string ProductionEnvironmentPlayStreamUrl = "";
#endif
    public string ProductionEnvironmentUrl = "";
#if UNITY_2017_2_OR_NEWER
    public WebRequestType RequestType = WebRequestType.UnityWebRequest;
#else
    public WebRequestType RequestType = WebRequestType.UnityWww;
#endif 
    public int RequestTimeout = 2000;
    public bool RequestKeepAlive = true;
    public bool CompressApiData = true;

    public PlayFabLogLevel LogLevel = PlayFabLogLevel.Warning | PlayFabLogLevel.Error;
    public string LoggerHost = "";
    public int LoggerPort = 0;
    public bool EnableRealTimeLogging = false;
    public int LogCapLimit = 30;
}
