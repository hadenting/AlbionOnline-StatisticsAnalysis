using ReactiveUI.Fody.Helpers;

namespace StatisticsAnalysisTool.Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ItemSearchViewModel = new ItemSearchViewModel();
            TrackingGeneralViewModel = new TrackingGeneralViewModel();
        }

        #region Bindings

        [Reactive]
        public ItemSearchViewModel ItemSearchViewModel { get; set; }

        [Reactive]
        public TrackingGeneralViewModel TrackingGeneralViewModel { get; set; }

        #endregion
    }
}
