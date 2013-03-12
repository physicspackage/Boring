using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Boring
{
    public class SelectedTileOpacity : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            FrameworkElement element = value as FrameworkElement;
            bool elementDimmed = element != null && element.Name != parameter.ToString();
            return elementDimmed ? 0.5 : 1.0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
