using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Boring
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            StyleAttachedProperty.SetValue(countTile, Application.Current.Resources["countStyle"] as Style);
            StyleAttachedProperty.SetValue(speedTile, Application.Current.Resources["speedStyle"] as Style);
            StyleAttachedProperty.SetValue(fadeAwayTile, Application.Current.Resources["fadeAwayStyle"] as Style);
            StyleAttachedProperty.SetValue(bugModeTile, Application.Current.Resources["bugModeStyle"] as Style);
            StyleAttachedProperty.SetValue(showFPSTile, Application.Current.Resources["showFPSStyle"] as Style);
            BindingAttachedProperty.SetValue(countTile, Application.Current.Resources["countBinding"] as Binding);
            BindingAttachedProperty.SetValue(speedTile, Application.Current.Resources["speedBinding"] as Binding);
            BindingAttachedProperty.SetValue(fadeAwayTile, Application.Current.Resources["fadeAwayBinding"] as Binding);
            BindingAttachedProperty.SetValue(bugModeTile, Application.Current.Resources["bugModeBinding"] as Binding);
            BindingAttachedProperty.SetValue(showFPSTile, Application.Current.Resources["showFPSBinding"] as Binding);
            TextBindingAttachedProperty.SetValue(countTile, Application.Current.Resources["countTextBinding"] as Binding);
            TextBindingAttachedProperty.SetValue(speedTile, Application.Current.Resources["speedTextBinding"] as Binding);
            TextBindingAttachedProperty.SetValue(fadeAwayTile, Application.Current.Resources["fadeAwayTextBinding"] as Binding);
            TextBindingAttachedProperty.SetValue(bugModeTile, Application.Current.Resources["bugModeTextBinding"] as Binding);
            TextBindingAttachedProperty.SetValue(showFPSTile, Application.Current.Resources["showFPSTextBinding"] as Binding);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Tile_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            if (App.ViewModel.SelectedTile == null || App.ViewModel.SelectedTile != sender as FrameworkElement)
            {
                ClearSliderValue();
                App.ViewModel.SelectedTile = sender as FrameworkElement;
                valueSlider.Style = StyleAttachedProperty.GetValue(sender as DependencyObject);
                valueSlider.SetBinding(Slider.ValueProperty, BindingAttachedProperty.GetValue(sender as DependencyObject) as Binding);
                valueText.SetBinding(TextBlock.TextProperty, TextBindingAttachedProperty.GetValue(sender as DependencyObject) as Binding);
            }
            else if (App.ViewModel.SelectedTile == showFPSTile)
            {
                App.ViewModel.ShowFPS = !App.ViewModel.ShowFPS;
            }
            else
            {
                ClearSliderValue();
            }
            e.Handled = true;
        }

        private void Page_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            ClearSliderValue();
        }

        private void ClearSliderValue()
        {
            valueSlider.ClearValue(Slider.ValueProperty);
            valueSlider.Style = null;
            valueSlider.Value = valueSlider.Minimum;

            valueText.Text = string.Empty;
            App.ViewModel.SelectedTile = null;
        }
    }
}
