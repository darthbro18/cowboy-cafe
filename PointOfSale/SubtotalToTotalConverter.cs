using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace PointOfSale
{
    public class SubtotalToTotalConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object param, CultureInfo culture)
        {
            return (double)value * 1.16;
        }

        public object ConvertBack(object value, Type targetType, object param, CultureInfo culture)
        {
            return (double)value / 1.16;
        }
    }
}
