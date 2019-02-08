using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatenSpeichernUndLaden
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FehlerPage : ContentPage
    {
        public FehlerPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Crashes.TrackError(new DivideByZeroException());
        }

        private void Buttontest_Clicked(object sender, EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }
    }
}