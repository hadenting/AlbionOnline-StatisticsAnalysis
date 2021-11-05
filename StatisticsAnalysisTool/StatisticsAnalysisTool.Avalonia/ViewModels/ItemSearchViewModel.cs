using ReactiveUI;
using System.Collections.ObjectModel;

namespace StatisticsAnalysisTool.Avalonia.ViewModels
{
    public class ItemSearchViewModel : ViewModelBase
    {
        private ObservableCollection<string> _items = new();

        public ItemSearchViewModel()
        {
            //var items = new ObservableCollection<ItemSearchObject>
            //{
            //    new () { UniqueName = "TestItem1" },
            //    new () { UniqueName = "TestItem1" },
            //    new () { UniqueName = "TestItem1" },
            //    new () { UniqueName = "TestItem1" },
            //    new () { UniqueName = "TestItem1" },
            //    new () { UniqueName = "TestItem1" },
            //    new () { UniqueName = "TestItem1" }
            //};

            var items = new ObservableCollection<string>
            {
                "TestItem1",
                "TestItem2",
                "TestItem3"
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
