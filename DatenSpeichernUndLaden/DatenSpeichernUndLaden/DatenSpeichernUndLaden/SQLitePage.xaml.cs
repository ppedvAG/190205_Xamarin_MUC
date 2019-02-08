using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatenSpeichernUndLaden
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLitePage : ContentPage
	{
		public SQLitePage ()
		{
			InitializeComponent ();

            string fullPath = Path.Combine(FileSystem.AppDataDirectory, "db.sqlite");

            // Erstellt eine neue Datei, wenn sie noch nicht existieren sollte und
            // öffnet bereits existierende Dateien
            con = new SQLiteConnection(fullPath);

            // Erstellt die Tabelle NUR, wenn sie nicht existiert
            con.CreateTable<Person>();
        }
        private readonly SQLiteConnection con;


        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            Person p = new Person
            {
                Vorname = entryVorname.Text,
                Nachname = entryNachname.Text,
                Alter = 100,
                Kontostand = 500m
            };

            con.Insert(p);
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            listViewPersonen.ItemsSource = con.Table<Person>();
        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            listViewPersonen.ItemsSource = con.Table<Person>();
            listViewPersonen.EndRefresh();
        }
    }
}