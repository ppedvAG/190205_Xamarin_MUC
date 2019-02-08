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
    public partial class TabbedPageRoot : TabbedPage
    {
        public TabbedPageRoot ()
        {
            InitializeComponent();
        }
    }
}