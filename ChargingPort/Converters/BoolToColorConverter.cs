using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using System;
using ChargingPort.Helpers;

namespace ChargingPort.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool isTrue = value is bool boolValue && boolValue;
            
            if (parameter is string resourceParams)
            {
                string[] resources = resourceParams.Split('|');
                if (resources.Length == 2)
                {
                    string resourceKey = isTrue ? resources[0] : resources[1];
                    
                    // Try to get the resource directly
                    if (Application.Current.Resources.TryGetValue(resourceKey, out object resource) && 
                        resource is SolidColorBrush brush)
                    {
                        return brush;
                    }
                }
            }
            
            // Default value
            return isTrue ? 
                Application.Current.Resources["PrimaryColor"] : 
                Application.Current.Resources["OutlineColor"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
