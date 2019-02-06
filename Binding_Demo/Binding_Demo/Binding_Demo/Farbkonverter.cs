using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Binding_Demo
{
    class Farbkonverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string farbe = (string)value;
            var fieldInfo = typeof(Color).GetFields().FirstOrDefault(x => x.Name == farbe);

            if (fieldInfo == null)
                return Color.Black;
            else
                return fieldInfo.GetValue(typeof(Color));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
