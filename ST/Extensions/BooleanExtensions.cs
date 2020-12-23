using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ST.Extentions
{
    public static class BooleanExtensions
    {
        public static string ConvertToYesNo(this bool value)
        {
            return value ? "Yes" : "No";
        }
    }
}
