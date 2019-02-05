using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Layoutcontainer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Button nullButton = (Button)sender
            Button nullButton = sender as Button;

            nullButton.Style = (Style)this.Resources["SpecialButtonStyle"];
        }
    }
}
