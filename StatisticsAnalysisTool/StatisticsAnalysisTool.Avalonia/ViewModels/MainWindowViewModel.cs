using JetBrains.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StatisticsAnalysisTool.Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private bool _isItemSearchUserControlVisible;
        private bool _isTrackingGeneralUserControlVisible;
        
        #region Helper methods

        public void AllContentControlsToInvisible()
        {
            IsItemSearchUserControlVisible = false;
            IsTrackingGeneralUserControlVisible = false;
        }

        #endregion

        #region Bindings

        public bool IsItemSearchUserControlVisible
        {
            get => _isItemSearchUserControlVisible;
            set
            {
                _isItemSearchUserControlVisible = value;
                OnPropertyChanged();
            }
        }

        public bool IsTrackingGeneralUserControlVisible
        {
            get => _isTrackingGeneralUserControlVisible;
            set
            {
                _isTrackingGeneralUserControlVisible = value;
                OnPropertyChanged();
            }
        }

        public new event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
