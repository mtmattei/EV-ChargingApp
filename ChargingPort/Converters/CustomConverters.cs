using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using System;
using Windows.UI;

namespace ChargingPort.Converters
{
    public class AvailabilityColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool isGood)
            {
                return isGood 
                    ? new SolidColorBrush(Color.FromArgb(255, 52, 139, 215))  // PrimaryContainerColor - blue
                    : new SolidColorBrush(Color.FromArgb(255, 202, 115, 0));  // SecondaryContainerColor - amber
            }
            
            return new SolidColorBrush(Color.FromArgb(255, 52, 139, 215));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
    
    public class DirectionsBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool isActive)
            {
                return isActive 
                    ? new SolidColorBrush(Color.FromArgb(255, 0, 102, 204))  // PrimaryColor - blue
                    : new SolidColorBrush(Color.FromArgb(255, 31, 41, 55));  // SurfaceVariantColor - dark gray
            }
            
            return new SolidColorBrush(Color.FromArgb(255, 31, 41, 55));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
    
    public class DirectionsForegroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool isActive)
            {
                return isActive 
                    ? new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))  // White
                    : new SolidColorBrush(Color.FromArgb(255, 176, 176, 176)); // Gray
            }
            
            return new SolidColorBrush(Color.FromArgb(255, 176, 176, 176));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
    
    public class DirectionsBorderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool isActive)
            {
                return isActive ? 0 : 1;
            }
            
            return 1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
