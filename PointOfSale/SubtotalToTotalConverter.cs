using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace PointOfSale
{
    public class SubtotalToTotalConverter : IValueConverter
    {
        /// <summary>
        /// Converts a subtotal to a total by adding 16% tax
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="param"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object param, CultureInfo culture)
        {
            return (double)value * 1.16;
        }

        /// <summary>
        /// Converts a total back to its subtotal
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="param"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object param, CultureInfo culture)
        {
            return (double)value / 1.16;
        }
    }
}
