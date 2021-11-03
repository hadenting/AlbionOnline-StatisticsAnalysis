using ReactiveUI;
using System.Collections.ObjectModel;

namespace StatisticsAnalysisTool.Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            var items = new ObservableCollection<string>
            {
                "TestItem1",
                "TestItem2"
            };

            Items = items;
        }

        #region Helper methods

        public void AllContentControlsToInvisible()
        {
            IsItemSearchUserControlVisible = false;
            IsTrackingGeneralUserControlVisible = false;
        }

        #endregion

        #region Bindings

        private ObservableCollection<string> _items = new();

        public ObservableCollection<string> Items
        {
            get => _items;
            set => this.RaiseAndSetIfChanged(ref _items, value);
        }

        private bool _isItemSearchUserControlVisible;
        private bool _isTrackingGeneralUserControlVisible;

        public bool IsItemSearchUserControlVisible
        {
            get => _isItemSearchUserControlVisible;
            set => this.RaiseAndSetIfChanged(ref _isItemSearchUserControlVisible, value);
        }

        public bool IsTrackingGeneralUserControlVisible
        {
            get => _isTrackingGeneralUserControlVisible;
            set => this.RaiseAndSetIfChanged(ref _isTrackingGeneralUserControlVisible, value);
        }

        #endregion
    }
}
