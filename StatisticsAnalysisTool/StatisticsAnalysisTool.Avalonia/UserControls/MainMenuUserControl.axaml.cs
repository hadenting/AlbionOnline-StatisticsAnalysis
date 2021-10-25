using System.Diagnostics;
using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
// ReSharper disable UnusedParameter.Local
// ReSharper disable UnusedMember.Local

namespace StatisticsAnalysisTool.Avalonia.UserControls
{
    public class MainMenuUserControl : UserControl
    {
        private static string DonateUrl => "https://www.paypal.com/donate?hosted_button_id=4PZ8DB8PSWCK8";
        private static string DiscordUrl => "https://discord.com/invite/sahSrSPmaJ";
        private static string GitHubRepoUrl => "https://github.com/Triky313/AlbionOnline-StatisticsAnalysis";

        public MainMenuUserControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public static void OpenGitHubRepo(string url)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}"));
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }
        }

        private void InputElementGithub_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
        {
            OpenGitHubRepo(GitHubRepoUrl);
        }

        private void InputElementDiscord_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
        {
            OpenGitHubRepo(DiscordUrl);
        }

        private void InputElementDonate_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
        {
            OpenGitHubRepo(DonateUrl);
        }
    }
}