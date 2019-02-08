using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DatenSpeichernUndLaden
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();

            MainPage = new TabbedPageRoot();

            //Properties["Demo"] = 12345;
            // Speichern erzwingen:
            // Application.Current.SavePropertiesAsync();
            //SavePropertiesAsync();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            // HIER werden die Application.Properties gespeichert !
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
