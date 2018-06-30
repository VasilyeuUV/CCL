using System;
using System.Globalization;
using System.Windows.Data;

namespace panelFontParams.Converters
{

    /// <summary>
    /// Bool to Italic Converter
    /// </summary>
    class BoolToItalicConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString() == "Italic" ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().ToLower() == "true")
            {
                return "Italic";
            }
            else
            {
                return "Normal";
            }
        }
    }
}
