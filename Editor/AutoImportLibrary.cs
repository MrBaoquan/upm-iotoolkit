using System;
using System.Collections;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class IOToolkitPlugin
{
    [InitializeOnLoadMethod]
    static void ImportLibraries()
    {
        if (Directory.Exists(Path.Combine(Application.dataPath, "Plugins/IOToolkit")))
            return;

        ImportIOToolkit(false);
    }

    [MenuItem("Tools/IOToolkit/Reimport", priority = 101)]
    static void Reimport()
    {
        ImportIOToolkit(true);
    }

    public static void ImportIOToolkit(bool interactive)
    {
        AssetDatabase.importPackageCompleted += OnImportPackageCompleted;
        AssetDatabase.importPackageFailed += OnImportPackageFailed;
        AssetDatabase.ImportPackage(
            "Packages/com.parful.iotoolkit/Assets/IOToolkit.unitypackage",
            interactive
        );
    }

    private static void OnImportPackageCompleted(string packageName) { }

    private static void OnImportPackageFailed(string packageName, string errorMessage) { }
}
