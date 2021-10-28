using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using StatisticsAnalysisTool.Avalonia.ViewModels;
using System.ComponentModel;

namespace StatisticsAnalysisTool.Avalonia.UserControls
{
    public sealed class ItemSearchUserControl : UserControl
    {
        private readonly ItemSearchUserControlViewModel _itemSearchUserControlViewModel;

        public ItemSearchUserControl()
        {
            InitializeComponent();

            _itemSearchUserControlViewModel = new ItemSearchUserControlViewModel();
            DataContext = _itemSearchUserControlViewModel;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}