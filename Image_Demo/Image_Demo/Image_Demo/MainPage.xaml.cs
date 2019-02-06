using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Xamarin.Forms;

namespace Image_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Variante: Uri 

            //UriImageSource source = (UriImageSource)ImageSource.FromUri(new Uri("http://www.zooroyal.de/magazin/wp-content/uploads/2017/04/hamster-760x560.jpg"));
            //// Cache: Default True
            //// CacheValiditiy: 24h
            //source.CacheValidity = TimeSpan.FromHours(1);
            //imageBild.Source = source;

            // Variante: Natives Projekt

            // Variante: Image im .NET Standard-Projekt
            // imageBild.Source = ImageSource.FromResource("Image_Demo.Images.hamster.jpg");
        }
    }
}
