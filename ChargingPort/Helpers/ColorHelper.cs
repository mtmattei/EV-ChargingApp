using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;

namespace ChargingPort.Helpers
{
    public static class ColorHelper
    {
        public static SolidColorBrush GetThemeResourceBrush(string resourceKey)
        {
            if (Application.Current.Resources.TryGetValue(resourceKey, out object resource) && 
                resource is SolidColorBrush brush)
            {
                return brush;
            }
            
            // Default fallback if resource not found
            return new SolidColorBrush(Microsoft.UI.Colors.Black);
        }
        
        public static string ConvertHexToResourceKey(string hexColor)
        {
            // Map common hex colors to appropriate theme resources
            switch (hexColor.ToUpperInvariant())
            {
                case "#4CD3A5":
                    return "PrimaryColor";
                case "#4D7FF0":
                    return "SecondaryColor";
                case "#E0F8E0":
                    return "PrimaryContainerColor";  
                case "#FFF9E0":
                    return "SecondaryContainerColor";
                case "#4CAF50":
                    return "PrimaryColor";
                case "#F0AD4E":
                    return "TertiaryColor";
                case "#AAAAAA":
                    return "OutlineColor";
                default:
                    return "SurfaceColor";
            }
        }
    }
}
