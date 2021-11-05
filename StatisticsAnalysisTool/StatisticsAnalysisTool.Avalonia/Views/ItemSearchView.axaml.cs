using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace StatisticsAnalysisTool.Avalonia.Views
{
    public class ItemSearchView : UserControl
    {
        public ItemSearchView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}