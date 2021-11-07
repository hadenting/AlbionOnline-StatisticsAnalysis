using ReactiveUI.Fody.Helpers;

namespace StatisticsAnalysisTool.Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ItemSearchViewModel = new ItemSearchViewModel();
            TrackingGeneralViewModel = new TrackingGeneralViewModel();
            FooterViewModel = new FooterViewModel();
        }

        #region Bindings

        [Reactive]
        public ItemSearchViewModel ItemSearchViewModel { get; set; }

        [Reactive]
        public TrackingGeneralViewModel TrackingGeneralViewModel { get; set; }

        [Reactive]
        public ViewModelBase FooterViewModel { get; set; }

        #endregion
    }
}
