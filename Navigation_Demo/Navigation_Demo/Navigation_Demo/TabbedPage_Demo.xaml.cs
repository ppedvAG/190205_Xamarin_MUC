using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage_Demo : TabbedPage
    {
        public TabbedPage_Demo ()
        {
            InitializeComponent();
        }
    }
}