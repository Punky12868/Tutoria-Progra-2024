using UnityEngine;
public abstract class Message
{
    public static void Log(string message) { Debug.Log(message); }
    public static void Log(bool debug, string message) { if(debug) Debug.Log(message); }
    public static void Log(Color color, string message) { Debug.Log($"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{message}</color>"); }
    public static void Log(bool debug, Color color, string message) { if(debug) Debug.Log($"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{message}</color>"); }
}
