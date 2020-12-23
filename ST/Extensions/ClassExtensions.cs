using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ST.Extentions
{
    public static class ClassExtensions
    {
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }
    }
}
