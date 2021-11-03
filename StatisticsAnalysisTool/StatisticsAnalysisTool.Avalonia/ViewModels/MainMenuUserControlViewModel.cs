using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace StatisticsAnalysisTool.Avalonia.ViewModels
{
    public class MainMenuUserControlViewModel : ViewModelBase
    {
        public string DonateUrl => "https://www.paypal.com/donate?hosted_button_id=4PZ8DB8PSWCK8";
        public string DiscordUrl => "https://discord.com/invite/sahSrSPmaJ";
        public string GitHubRepoUrl => "https://github.com/Triky313/AlbionOnline-StatisticsAnalysis";

        public void OpenGitHubRepo(string url)
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

        #region Binding

        public static string Version => $"v{Assembly.GetExecutingAssembly().GetName().Version}";

        #endregion
    }
}
