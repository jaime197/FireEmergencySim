using UnityEngine;

public class CheckGPU : MonoBehaviour
{
    void Start()
    {
        string gpuName = SystemInfo.graphicsDeviceName;
        string gpuVendor = SystemInfo.graphicsDeviceVendor;
        string gpuVersion = SystemInfo.graphicsDeviceVersion;
        int gpuMemory = SystemInfo.graphicsMemorySize;

        Debug.Log("Graphics Device Name: " + gpuName);
        Debug.Log("Graphics Device Vendor: " + gpuVendor);
        Debug.Log("Graphics Device Version: " + gpuVersion);
        Debug.Log("Graphics Device Memory: " + gpuMemory + " MB");
    }
}
