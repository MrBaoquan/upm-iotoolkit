using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IOToolkit;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class IOToolkitDemo : MonoBehaviour
{
    private void overrideConfigFile()
    {
#if UNITY_EDITOR
        const string sceneName = "IOToolkit Demo";
        string[] guids = AssetDatabase.FindAssets(sceneName + " t:Scene");
        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            if (System.IO.Path.GetFileNameWithoutExtension(path) == sceneName)
            {
                var _configPath = Path.Combine(
                    Path.GetDirectoryName(Application.dataPath),
                    Path.GetDirectoryName(path),
                    "IODevice.xml"
                );
                IOSettings.SetIOConfigPath(_configPath);
                Debug.LogWarning($"Overridden IOToolkit config to {_configPath}");
                break;
            }
        }
#endif
    }

    // Start is called before the first frame update
    void Start()
    {
        // 仅示例程序使用, 正式使用配置文件在 Assets/Plugins/IOToolkit/Config/IODevice.xml
        overrideConfigFile();

        IODeviceController.Load();

        // step1: 加载IO设备
        var _ioDevice = IODeviceController.GetIODevice("extDev");

        // step2: 绑定IO设备的Action
        _ioDevice.BindAction(
            "ToggleLight",
            InputEvent.IE_Pressed,
            () =>
            {
                // 开灯
                _ioDevice.SetDOOn("Light");
            }
        );

        _ioDevice.BindAction(
            "ToggleLight",
            InputEvent.IE_Released,
            () =>
            {
                _ioDevice.SetDOOff("Light");
            }
        );

        _ioDevice.BindAxis(
            "Brightness",
            _val =>
            {
                _ioDevice.SetDO(IOKeyCode.OAxis_00, _val);
            }
        );
    }

    // Update is called once per frame
    void Update()
    {
        // step3 调用Update方法更新IO设备状态
        IODeviceController.Update();
    }

    private void OnDestroy()
    {
        // step4 卸载IO设备
        IODeviceController.Unload();
    }
}
