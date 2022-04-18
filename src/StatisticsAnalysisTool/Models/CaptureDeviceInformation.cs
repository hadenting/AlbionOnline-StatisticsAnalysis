using SharpPcap;

namespace StatisticsAnalysisTool.Models;

public class CaptureDeviceInformation
{
    public string DisplayName { get; set; }
    public ICaptureDevice Device { get; set; }
    public bool IsAllDevicesActive { get; set; }
}