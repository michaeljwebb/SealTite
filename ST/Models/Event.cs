using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ST.Models
{
    public class Event : IAuditable, IIdentifiable
    {
        public Event()
        {
            IsActive = true;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Information { get; set; }

        public Boolean IsActive { get; set; }

        public Boolean IsDeleted { get; set; }
    }
}
