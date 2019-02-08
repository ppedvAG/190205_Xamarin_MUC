using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomControl_Demo.SpezialEntry), typeof(CustomControl_Demo.Droid.SpezialEntryRenderer))]
namespace CustomControl_Demo.Droid
{
    class SpezialEntryRenderer : EntryRenderer
    {
        public SpezialEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.SetBackgroundResource(Resource.Drawable.Gradient);
        }
    }
}