using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomControl_Demo
{
    class ZahlenBehaviour : Behavior<Entry>
    {

        public bool IsValid
        {
            get { return (bool)GetValue(IsValidProperty); }
            set { SetValue(IsValidProperty, value); }
        }
        public static readonly BindableProperty IsValidProperty =
         BindableProperty.Create("IsValid", typeof(bool), typeof(ZahlenBehaviour), true);


        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            // initialisierung
            bindable.TextChanged += TextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            // aufräumen
            bindable.TextChanged -= TextChanged;
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Int32.TryParse(e.NewTextValue,out _)) // out _ == out verwerfen 
            {
                IsValid = true;
                (sender as Entry).TextColor = Color.Black; // OK
            }
            else
            {
                IsValid = false;
                (sender as Entry).TextColor = Color.Red; // Nicht OK
            }
        }
    }
}
