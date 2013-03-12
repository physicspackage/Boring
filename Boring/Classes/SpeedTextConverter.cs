using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Boring
{
    public class SpeedTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string text = "Slow";
            if (!(value is int))
                return string.Format(System.Globalization.CultureInfo.CurrentUICulture, parameter.ToString(), text);

            int dvalue = (int)value;
            if (dvalue > 5) text = "Fast";
            else if (dvalue > 3) text = "Medium";
            return string.Format(System.Globalization.CultureInfo.CurrentUICulture, parameter.ToString(), text);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
