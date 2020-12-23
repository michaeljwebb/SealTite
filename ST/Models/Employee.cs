using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ST.Models
{
    public class Employee : IAuditable, IIdentifiable
    {
        public Employee()
        {
            IsActive = true;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Experience { get; set; }

        public string ContactEmail { get; set; }

        public byte[] ActualImage { get; set; }

        public String ImageType { get; set; }

        public Boolean IsActive { get; set; }

        public Boolean IsDeleted { get; set; }
    }

    //public class DataContext : DbContext
    //{
    //    public DbSet<Employee> Employee { get; set; }
    //    public DbSet<News> News { get; set; }
    //    public DbSet<Event> Event { get; set; }
    //}
}
