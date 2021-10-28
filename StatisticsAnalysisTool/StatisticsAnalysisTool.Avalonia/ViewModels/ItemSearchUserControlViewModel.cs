using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace StatisticsAnalysisTool.Avalonia.ViewModels
{
    public class ItemSearchUserControlViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<string> _items = new();

        public ItemSearchUserControlViewModel()
        {
            //var items = new ObservableCollection<Item>
            //{
            //    new Item() { UniqueName = "TestItem1" },
            //    new Item() { UniqueName = "TestItem2" }
            //};

            var items = new ObservableCollection<string>
            {
                "TestItem1",
                "TestItem2"
            };

            Items = items;
        }

        #region Bindings

        public ObservableCollection<string> Items
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        public new event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
