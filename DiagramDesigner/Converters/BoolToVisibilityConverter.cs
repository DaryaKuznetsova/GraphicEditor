using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace DiagramDesigner.Converters
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    class BoolToVisibilityConverter : IValueConverter
    {
        static BoolToVisibilityConverter()
        {
            Instance = new BoolToVisibilityConverter();
        }

        public static BoolToVisibilityConverter Instance
        {
            get;
            private set;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((bool)value) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
