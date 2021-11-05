using ReactiveUI;

namespace StatisticsAnalysisTool.Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _navigationContent = new ItemSearchViewModel();
        private ViewModelBase _mainMenuView = new MainMenuViewModel();

        #region Helper methods

        #endregion

        #region Bindings
        
        public ViewModelBase NavigationContent
        {
            get => _navigationContent;
            set => this.RaiseAndSetIfChanged(ref _navigationContent, value);
        }

        public ViewModelBase MainMenuView
        {
            get => _mainMenuView;
            set => this.RaiseAndSetIfChanged(ref _mainMenuView, value);
        }

        #endregion
    }
}
