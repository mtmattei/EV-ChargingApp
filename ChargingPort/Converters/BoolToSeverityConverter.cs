using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using System;

namespace ChargingPort.Converters
{
    public class BoolToSeverityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool isGood)
            {
                // Return Success for good availability, Informational for limited availability
                return isGood ? InfoBarSeverity.Success : InfoBarSeverity.Warning;
            }
            
            return InfoBarSeverity.Informational; // Default
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
