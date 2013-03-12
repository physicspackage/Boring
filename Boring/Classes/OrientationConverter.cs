using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Sensors;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace Boring
{
    public class OrientationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            switch ((SimpleOrientation)value)
            {
                case SimpleOrientation.Facedown:
                case SimpleOrientation.Faceup:
                case SimpleOrientation.NotRotated:
                case SimpleOrientation.Rotated180DegreesCounterclockwise:
                    return Orientation.Horizontal;
                case SimpleOrientation.Rotated270DegreesCounterclockwise:
                case SimpleOrientation.Rotated90DegreesCounterclockwise:
                    return Orientation.Vertical;
                default:
                    return Orientation.Horizontal;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
