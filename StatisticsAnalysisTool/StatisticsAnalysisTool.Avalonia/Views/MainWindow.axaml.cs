using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using StatisticsAnalysisTool.Avalonia.Controls;
using System;
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedMember.Local

namespace StatisticsAnalysisTool.Avalonia.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void TitleBar_OnPointerPressed(object? sender, PointerPressedEventArgs e)
        {
            if (e.GetCurrentPoint(null).Properties.PointerUpdateKind == PointerUpdateKind.LeftButtonPressed)
            {
                PlatformImpl?.BeginMoveDrag(e);
            }
        }

        private void MainWindow_OnOpened(object? sender, EventArgs e)
        {
            if (DataContext is ICloseWindow vm)
            {
                vm.Close += Close;
            }
        }
    }
}
