using System;
using System.Globalization;
using Xamarin.Forms;

namespace My_sporting_achievments.Converters
{
    public class ColorConverter : IValueConverter
    {
        //Меняем цвет текста в поле "password"
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = value?.ToString();
            Color color;
            //Если колличество введенных символов меньше чем 6 и более 14 - текст становится красным цветом
            if (text.Length >= 6 && text.Length < 14)
            {
                color = Color.Black;
            }
            else color = Color.Red;

            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
