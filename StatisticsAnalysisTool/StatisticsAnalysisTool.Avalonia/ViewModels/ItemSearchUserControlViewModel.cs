using ReactiveUI;
using System.Collections.ObjectModel;

namespace StatisticsAnalysisTool.Avalonia.ViewModels
{
    public class ItemSearchUserControlViewModel : ViewModelBase
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
            set => this.RaiseAndSetIfChanged(ref _items, value);
        }

        #endregion
    }
}
