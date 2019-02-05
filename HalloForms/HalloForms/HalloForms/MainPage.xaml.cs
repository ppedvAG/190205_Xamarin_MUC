using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HalloForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            #region Dialogmöglichkeiten
            // MessageBox - 1 Button
            // DisplayAlert("Meine erste Nachricht", "Hallo Welt", "OK");

            // "Ja/Nein" Messagebox
            // DisplayAlert("Eine simple Frage", "Mittagspause ?", "Ja", "Verdammt nochmal JA !");

            // Mehrfach-Frage
            // DisplayActionSheet("Wähle dein Obst", "Ok", "Abbrechen", "Apfel", "Birne", "Banane", "Orange");

            #endregion

            if (string.IsNullOrWhiteSpace(entryEingabe.Text))
                DisplayAlert("Deine Eingabe", "---LEER---", "Na geh....");
            else
                DisplayAlert("Deine Eingabe", entryEingabe.Text, "Ok");
        }
    }
}
