using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StatisticsAnalysisTool.Avalonia.UserControls
{
    public sealed class ItemSearchUserControl : UserControl
    {
        public ItemSearchUserControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}