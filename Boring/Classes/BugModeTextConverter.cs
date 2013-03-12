using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Boring
{
    public enum BugMode
    {
        Active = 0,
        Hiding = 1,
        Sporadic = 2,
        Spawn = 3
    }

    public class BugModeTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string text = string.Empty;
            if (!(value is BugMode))
                return string.Format(System.Globalization.CultureInfo.CurrentUICulture, parameter.ToString(), text);

            switch ((BugMode)value)
            {
                case BugMode.Active:
                    text = "Active";
                    break;
                case BugMode.Hiding:
                    text = "Hiding";
                    break;
                case BugMode.Sporadic:
                    text = "Sporadic";
                    break;
                case BugMode.Spawn:
                    text = "Spawn";
                    break;
                default:
                    break;
            }

            return string.Format(System.Globalization.CultureInfo.CurrentUICulture, parameter.ToString(), text);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class BugModeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (double)(BugMode)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return (BugMode)(double)value;
        }
    }
}
