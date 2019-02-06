using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_Demo.MD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage_DemoMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage_DemoMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPage_DemoMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage_DemoMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPage_DemoMenuItem> MenuItems { get; set; }
            
            public MasterDetailPage_DemoMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPage_DemoMenuItem>(new[]
                {
                    new MasterDetailPage_DemoMenuItem(typeof(MasterDetailPage_DemoDetail)) { Id = 0, Title = "Page 1" },
                    new MasterDetailPage_DemoMenuItem(typeof(MasterDetailPage_DemoDetail)) { Id = 1, Title = "Page 2" },
                    new MasterDetailPage_DemoMenuItem(typeof(MasterDetailPage_DemoDetail)) { Id = 2, Title = "Page 3" },
                    new MasterDetailPage_DemoMenuItem(typeof(MainPage)) { Id = 3, Title = "Page 4" },
                    new MasterDetailPage_DemoMenuItem(typeof(Seite2)) { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}