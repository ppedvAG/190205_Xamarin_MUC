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
	public partial class DependencyServicePage : ContentPage
	{
		public DependencyServicePage ()
		{
			InitializeComponent ();
            helper = DependencyService.Get<ITextFileHelper>(); // Eine Variante der DependencyInjection
		}
        private readonly ITextFileHelper helper;

        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            helper.SaveTextFile(entryEingabe.Text);
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Laden vom DS", helper.LoadTextFile(), "OK");
        }
    }
}