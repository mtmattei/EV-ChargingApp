using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using System;

namespace ChargingPort.Converters
{
    public class ThemeResourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is string resourceKey && Application.Current?.Resources != null)
            {
                if (Application.Current.Resources.TryGetValue(resourceKey, out var resource))
                {
                    return resource;
                }
                
                // Fallback for ThemeResource syntax
                if (resourceKey.Contains("ThemeResource"))
                {
                    string cleanKey = resourceKey
                        .Replace("{ThemeResource ", "")
                        .Replace("}", "");
                        
                    if (Application.Current.Resources.TryGetValue(cleanKey, out var themeResource))
                    {
                        return themeResource;
                    }
                }
            }
            
            // Fallback to parameter if provided
            if (parameter != null && parameter is string paramResourceKey)
            {
                if (Application.Current.Resources.TryGetValue(paramResourceKey, out var paramResource))
                {
                    return paramResource;
                }
            }
            
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
    
    public class BoolToThemeResourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool boolValue && parameter is string parameters)
            {
                string[] parts = parameters.Split(',');
                if (parts.Length >= 2)
                {
                    string resourceKey = boolValue ? parts[0] : parts[1];
                    
                    if (Application.Current.Resources.TryGetValue(resourceKey, out var resource))
                    {
                        return resource;
                    }
                }
            }
            
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
