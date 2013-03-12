using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Boring
{
    public class FadeAwayTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string text = "None";
            if (!(value is int))
                return string.Format(System.Globalization.CultureInfo.CurrentUICulture, parameter.ToString(), text);

            int dvalue = (int)value;
            if (dvalue > 6) text = "Fast";
            else if (dvalue > 0) text = "Moderate";
            return string.Format(System.Globalization.CultureInfo.CurrentUICulture, parameter.ToString(), text);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
