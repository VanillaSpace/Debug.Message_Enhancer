#define EventDebug
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    void Start()
    {
        EventDebug("EventManger Started");
    }
    public static void EventDebug(string message)
    {
#if EventDebug
        Debug.Log($"{GlobalSettings.EventManagerDebugHeader} This is the Event Manager Debug Header!");
        Debug.Log($"{GlobalSettings.RunOnStartDebugHeader} Loading Main Camera");
        Debug.Log($"{GlobalSettings.StatDataDebugHeader} Initializing StatData");
        Debug.Log($"{GlobalSettings.AchievementDebugHeader} Achievement Unlocked!");
        Debug.Log($"{GlobalSettings.GameManagerDebugHeader} Resetting Level");
        Debug.Log($"{GlobalSettings.AudioDebugHeader} Starting BGM Controller");
        Debug.Log($"{GlobalSettings.UIDebugHeader} Initializing Main UI");
        Debug.Log($"{GlobalSettings.TrackDebugHeader} The Player Location");
        Debug.Log($"{GlobalSettings.WorldDebugHeader} Initializing Final Boss");
#endif
    }
}

public class GlobalSettings
{
    public const string EventManagerDebugHeader = "<color=yellow>☀ </color><color=#72d47f><b>Event:</b></color>";
    public const string RunOnStartDebugHeader = "<color=yellow>→ </color><color=cyan><b>RunOnStart:</b></color>";
    public const string StatDataDebugHeader = "<color=yellow>⌺ <b><color=#73a1de>StatData:</color></b> </color>";
    public const string AchievementDebugHeader = "<color=yellow>⌺ <b><color=green>Achievement:</color></b> </color>";
    public const string GameManagerDebugHeader = "<color=yellow>♦ <b><color=lightblue>GameManager:</color></b> </color>";
    public const string AudioDebugHeader = "<color=yellow>♫ <b><color=#aa73bf>Audio:</color></b> </color>";
    public const string UIDebugHeader = "<color=yellow>▣ <b><color=#d4d28e>UI:</color></b> </color>";
    public const string TrackDebugHeader = "<color=yellow>≡ <b><color=#6f818c>Track:</color></b> </color>";
    public const string WorldDebugHeader = "<color=yellow>∾ </color><color=#798bf2><b>Level Data:</b></color>";
}
