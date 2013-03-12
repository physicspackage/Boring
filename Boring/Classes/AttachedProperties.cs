using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using WindowsStore.FalafelUtility;

namespace Boring
{
    public class StyleAttachedProperty : GenericAttachedProperty<Style> { }
    public class BindingAttachedProperty : GenericAttachedPropertyValueChanged<BindingAttachedProperty, Binding> { }
    public class TextBindingAttachedProperty : GenericAttachedPropertyValueChanged<TextBindingAttachedProperty, Binding> { }
}
