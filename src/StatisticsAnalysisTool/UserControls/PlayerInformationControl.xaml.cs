using StatisticsAnalysisTool.ViewModels;
using System.Linq;
using System.Windows.Controls;

namespace StatisticsAnalysisTool.UserControls
{
    /// <summary>
    /// Interaction logic for PlayerInformationControl.xaml
    /// </summary>
    public partial class PlayerInformationControl
    {
        private readonly PlayerInformationViewModel _playerInformationViewModel;

        public PlayerInformationControl()
        {
            InitializeComponent();
            _playerInformationViewModel = new PlayerInformationViewModel();
            DataContext = _playerInformationViewModel;
        }

        private async void ListBoxUserSearch_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = e?.AddedItems?.OfType<PlayerInformationViewModel.PlayerSearchStruct>().FirstOrDefault();
            if (selectedItem?.Value?.Name == null)
            {
                return;
            }

            await _playerInformationViewModel.LoadPlayerDataAsync(selectedItem?.Value?.Name);
        }

        private async void TextBoxPlayerSearch_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                await _playerInformationViewModel.UpdateUsernameListBoxAsync(textBox.Text);
            }
        }
    }
}
