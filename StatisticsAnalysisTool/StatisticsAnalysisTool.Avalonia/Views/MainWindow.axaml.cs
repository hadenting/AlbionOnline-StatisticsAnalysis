using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using StatisticsAnalysisTool.Avalonia.ViewModels;
using System.Diagnostics;

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

        public void TrackingGeneral_OnPointerReleased()
        {
            var vm = (MainWindowViewModel)DataContext!;
            vm.IsTrackingGeneralUserControlVisible = true;
        }

        public void ItemSearch_OnClick()
        {
            var vm = (MainWindowViewModel)DataContext!;
            vm.IsItemSearchUserControlVisible = true;
        }

        private void TitleBar_OnPointerPressed(object? sender, PointerPressedEventArgs e)
        {
            if (e.GetCurrentPoint(null).Properties.PointerUpdateKind == PointerUpdateKind.LeftButtonPressed)
            {
                BeginMoveDrag(e);
            }
        }
    }
}
