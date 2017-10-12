using System;
using System.Globalization;
using System.Windows.Data;

namespace CommentBoardRefine.Models
{
    class ColorConverter : IValueConverter
    {
        string NowDay;
        string TomorrowDay;

        public ColorConverter()
        {
            DateTime nowdate = DateTime.Now;
            string NowdayX = nowdate.Date.ToString().Replace(" 0:00:00", "");
            NowDay = NowdayX.Remove(0, 5);

            DateTime tomorrowdate = DateTime.Now.AddDays(1);
            string Tomorrowday = tomorrowdate.Date.ToString().Replace(" 0:00:00", "");
            TomorrowDay = Tomorrowday.Remove(0, 5);
        }

        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
            //掲示期限前日～当日のセルは、背景を赤くする
            if (value.ToString().Equals(NowDay)|| value.ToString().Equals(TomorrowDay))
            {
                return "#FF6666";
            }

            return "#EEEEEE";
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
