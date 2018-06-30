using System;
using System.Globalization;
using System.Windows.Data;

namespace panelFontParams.Converters
{

    /// <summary>
    /// Bool to UnderLine Converter
    /// </summary>
    class BoolToUnderlineConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString() == "Underline" ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value.ToString().ToLower() == "true")
            {
                return "Underline";
            }
            else
            {
                return "{x:Null}";
            }
        }
    }
}
