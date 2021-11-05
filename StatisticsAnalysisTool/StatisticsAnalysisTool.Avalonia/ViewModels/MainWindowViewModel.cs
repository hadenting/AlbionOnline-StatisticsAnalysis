using System.Windows.Input;
using ReactiveUI;

namespace StatisticsAnalysisTool.Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _navigationContent = new ItemSearchViewModel();
        private ViewModelBase _mainMenuView = new MainMenuViewModel();

        public ICommand OpenItemSearchClicked { get; }

        public MainWindowViewModel()
        {
            OpenItemSearchClicked = ReactiveCommand.Create(OpenItemSearch);
        }

        private void OpenItemSearch()
        {
            NavigationContent = new ItemSearchViewModel();
        }

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
