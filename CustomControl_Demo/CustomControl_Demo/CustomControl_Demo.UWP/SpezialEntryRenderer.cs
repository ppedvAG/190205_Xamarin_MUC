using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomControl_Demo.SpezialEntry),typeof(CustomControl_Demo.UWP.SpezialEntryRenderer))]
namespace CustomControl_Demo.UWP
{
    class SpezialEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.Background = new LinearGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop{Offset=0,Color=Windows.UI.Colors.MediumSpringGreen},
                    new GradientStop{Offset=1,Color=Windows.UI.Colors.Firebrick}
                }
            };
        }
    }
}
