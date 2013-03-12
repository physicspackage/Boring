using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Boring
{
    public class ShowFPSToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool bvalue = (bool)value;
            if (bvalue)
                return "Show FPS";
            else
                return "Hide FPS";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
