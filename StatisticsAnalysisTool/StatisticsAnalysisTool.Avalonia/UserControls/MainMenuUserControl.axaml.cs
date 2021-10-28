using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using StatisticsAnalysisTool.Avalonia.ViewModels;
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedParameter.Local

namespace StatisticsAnalysisTool.Avalonia.UserControls
{
    public class MainMenuUserControl : UserControl
    {
        private readonly MainMenuUserControlViewModel _mainMenuUserControlViewModel;

        public MainMenuUserControl()
        {
            InitializeComponent();

            _mainMenuUserControlViewModel = new MainMenuUserControlViewModel();
            DataContext = _mainMenuUserControlViewModel;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void InputElementGithub_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
        {
            _mainMenuUserControlViewModel.OpenGitHubRepo(_mainMenuUserControlViewModel.GitHubRepoUrl);
        }

        private void InputElementDiscord_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
        {
            _mainMenuUserControlViewModel.OpenGitHubRepo(_mainMenuUserControlViewModel.DiscordUrl);
        }

        private void InputElementDonate_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
        {
            _mainMenuUserControlViewModel.OpenGitHubRepo(_mainMenuUserControlViewModel.DonateUrl);
        }
    }
}