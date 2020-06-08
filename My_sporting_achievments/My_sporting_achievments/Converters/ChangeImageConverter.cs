using System;
using System.Globalization;
using Xamarin.Forms;

namespace My_sporting_achievments.Converters
{
    public class ChangeImageConverter : IValueConverter
    {
        //меняем изображение кнопки "показать пароль"
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string changeImage;
            if (value == null) return changeImage = "closeEye.png";
            changeImage = (bool)value ? "closeEye.png" : "openEye.png";
            return changeImage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
