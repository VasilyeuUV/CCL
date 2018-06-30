using System;
using System.Globalization;
using System.Windows.Data;

namespace panelFontParams.Converters
{
    /// <summary>
    /// Конвертор Bool to Bold
    /// </summary>
    class BoolToBoldConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString() == "Bold" ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().ToLower() == "true")
            {
                return "Bold";
            }
            else
            {
                return "Normal";
            }
        }
    }
}
