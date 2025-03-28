// Create the BuildScript.cs file in /Assets/Editor/ and write this code in it.
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Linq;

public class BuildScript
{
    [MenuItem("Build/Build APK")]
    public static void BuildAPK()
    {
        // Configure keystore settings for APK signing
        PlayerSettings.Android.useCustomKeystore = true; //IF YOU'R USING DEBUGMODE, CHANGE IT TO FALSE AND COMMENT NEXT 3 LINES
        PlayerSettings.Android.keystoreName = @"YOUR .KEYSTORE FILE PATH C:\...";
        PlayerSettings.Android.keystorePass = "KEYSTOREPASS";
        PlayerSettings.Android.keyaliasName = "KEYALIASNAME";
        PlayerSettings.Android.keyaliasPass = "KEYALIASPASS";

        // Get the list of enabled scenes from Build Settings
        string[] scenes = EditorBuildSettings.scenes
            .Where(scene => scene.enabled)
            .Select(scene => scene.path)
            .ToArray();

        // Define the build output path
        string buildPath = @"C:\agent\_work\1\a\APK-NAME.apk"; #SET THE OUTPUT APK FILE NAME
        
        // Log the start of the build process
        Debug.Log("🚀 Starting APK Build...");

        // Build the APK
        BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.Android, BuildOptions.None);
        
        // Confirm build completion
        Debug.Log("✅ APK Build Completed: " + buildPath);
    }
}
