using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ST.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToSqlDateTime(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
