using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using System;

namespace ChargingPort.Converters
{
    public class BoolToStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool isTrue = value is bool boolValue && boolValue;
            
            if (parameter is string styleParams)
            {
                string[] styles = styleParams.Split('|');
                if (styles.Length == 2)
                {
                    string styleKey = isTrue ? styles[0] : styles[1];
                    
                    if (Application.Current.Resources.TryGetValue(styleKey, out object style))
                    {
                        return style;
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
