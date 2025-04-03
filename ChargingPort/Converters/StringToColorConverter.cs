using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using System;
using ChargingPort.Helpers;

namespace ChargingPort.Converters
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is string resourceKey)
            {
                // Try to get the resource directly if it's a resource key
                if (Application.Current.Resources.TryGetValue(resourceKey, out object resource) && 
                    resource is SolidColorBrush brush)
                {
                    return brush;
                }
                
                // If it's a hex color, map it to a theme resource
                string themeResourceKey = ColorHelper.ConvertHexToResourceKey(resourceKey);
                
                if (Application.Current.Resources.TryGetValue(themeResourceKey, out object themeResource) && 
                    themeResource is SolidColorBrush themeBrush)
                {
                    return themeBrush;
                }
            }
            
            // Default color
            return Application.Current.Resources["OnSurfaceColor"] as SolidColorBrush ?? 
                   new SolidColorBrush(Microsoft.UI.Colors.Black);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
