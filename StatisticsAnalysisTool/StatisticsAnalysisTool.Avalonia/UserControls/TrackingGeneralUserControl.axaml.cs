using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StatisticsAnalysisTool.Avalonia.UserControls
{
    public partial class TrackingGeneralUserControl : UserControl
    {
        public TrackingGeneralUserControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
