using exam_creator;
using System.Globalization;
using System.Windows.Data;


namespace exam_creator.Converters
{
    public class WidthSubtractionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double originalWidth)
            {
                if (double.TryParse(parameter.ToString(), out double subtraction))
                {
                    return originalWidth - subtraction;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}