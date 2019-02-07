using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListView_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private ObservableCollection<Person> data;
        private void LoadData()
        {
            data = new ObservableCollection<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100m},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=20m},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=3000m},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=-4000m},
                new Person{Vorname="Klara",Nachname="Fall",Alter=50,Kontostand=55500m},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=60,Kontostand=123456m},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=-7721100m},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=80,Kontostand=1876500m},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=90,Kontostand=987m},
                new Person{Vorname="Max",Nachname="Mustermann",Alter=100,Kontostand=10000000000m},
            };
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            LoadData();
            listViewPersonen.ItemsSource = data;
        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            LoadData();
            listViewPersonen.ItemsSource = data;

            // 2 Möglichkeiten
            // listViewPersonen.IsRefreshing = false;
            listViewPersonen.EndRefresh();
        }

        private void SearchBarPerson_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (data == null || data.Count == 0)
                return;

            listViewPersonen.ItemsSource = data.Where(x => x.Vorname
                                                            .StartsWith(searchBarPerson.Text,StringComparison.CurrentCultureIgnoreCase));
        }

        private void MenuItemInfo_Clicked(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            Person p = (Person)item.BindingContext;
            listViewPersonen.SelectedItem = p;

            DisplayAlert($"{p.Vorname} {p.Nachname}", $"Alter:{p.Alter}, Kontostand:{p.Kontostand}", "Ok");
        }

        private void MenuItemDelete_Clicked(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            Person p = (Person)item.BindingContext;

            data.Remove(p);
            if(!string.IsNullOrWhiteSpace(searchBarPerson.Text))
                SearchBarPerson_TextChanged(sender, null);

            // Hässlicher Hack:
            // listViewPersonen.ItemsSource = null;
            // listViewPersonen.ItemsSource = data;
        }
    }
}
