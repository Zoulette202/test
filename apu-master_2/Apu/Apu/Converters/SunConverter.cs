using Apu.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Apu.Converters
{
    public class SunConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var sun = value as Sun;
            return $"Levé: {sun.Sunrise.ToString("HH:mm")}, couché: {sun.Sunset.ToString("HH:mm")}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "";
        }
    }
}
