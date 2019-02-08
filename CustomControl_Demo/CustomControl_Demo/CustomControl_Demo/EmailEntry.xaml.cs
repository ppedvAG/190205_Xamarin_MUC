using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControl_Demo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmailEntry : ContentView
	{
		public EmailEntry ()
		{
			InitializeComponent ();
            this.BindingContext = this; // "Ich" bin meine eigene Standarddatenquelle
		}


        // Schritte für ein BindableProperty
        // 1) propdp + TAB + TAB
        // 2) Im Snippetmodus:
        //      * Datentyp wählen
        //      * Namen wählen
        //      * ownerclass durch aktuellen Klassennamen ersetzen
        //      * PropertyMetaData durch den "default"-wert ersetzen
        // 3) DependencyProperty durch "BindableProperty" ersetzen
        // 4) Methode "Register" durch "Create" ersetzen

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text", typeof(string), typeof(EmailEntry), null);

        private void EntryEingabe_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex r = new Regex(@"^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$");
            var result = r.Match(entryEingabe.Text);

            labelValidierung.IsVisible = ! result.Success;
        }
    }
}