using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DatenSpeichernUndLaden
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Zugriff auf Application.Properties:
            // Application.Current.Properties
            
        }

        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(entryEingabe.Text))
            {
                DisplayAlert("Speichern", "Textfeld ist leer", "Ok");
                Analytics.TrackEvent("User wollte mit leeren Textfeld speichern :(");
                return;
            }

            string fullPath = Path.Combine(FileSystem.AppDataDirectory, "demo.txt");
            File.WriteAllText(fullPath, entryEingabe.Text);
            DisplayAlert("Speichern", $"Datei wurde unter {fullPath} erfolgreich gespeichert !", "Yay");
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            string fullPath = Path.Combine(FileSystem.AppDataDirectory, "demo.txt");
            DisplayAlert("Laden", File.ReadAllText(fullPath), "Yay");
            Analytics.TrackEvent("User sieht Daten :)");
        }
    }
}
