using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MessagingCenter_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<Slider, double>(this, "NewValue", EsGibtEinenNeuenWert);
        }

        private void EsGibtEinenNeuenWert(Slider arg1, double arg2)
        {
            labelWert.Text = arg2.ToString();
        }

        private void ButtonSeite2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Seite2());
        }
    }
}
