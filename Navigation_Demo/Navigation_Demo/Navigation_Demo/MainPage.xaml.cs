using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigation_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //if(Device.Idiom == TargetIdiom.Phone && Device.RuntimePlatform == Device.iOS)
            //{
            //    // ....
            //}

        }

        private void ButtonModal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Seite2());
        }

        private void ButtonNavigationPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Seite2());
        }
    }
}
