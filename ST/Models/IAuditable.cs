using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ST.Models
{
    public interface IAuditable
    {
        bool IsActive { get; set; }

        bool IsDeleted { get; set; }
    }
}
