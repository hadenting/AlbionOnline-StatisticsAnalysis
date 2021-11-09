using System;

namespace StatisticsAnalysisTool.Avalonia.Controls
{
    public interface ICloseWindow
    {
        Action? Close { get; set; }
    }
}