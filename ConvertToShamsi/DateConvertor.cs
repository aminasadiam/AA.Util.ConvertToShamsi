using System;
using System.Globalization;

namespace ConvertToShamsi
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value) + "/" +
                pc.GetDayOfMonth(value).ToString("00");
        }
    }
}
