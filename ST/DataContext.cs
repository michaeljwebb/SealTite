using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ST.Configurations;
using ST.Models;

namespace ST
{
    public class DataContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations
                .Add(new EmployeeEntityConfiguration());
            modelBuilder.Configurations
                .Add(new EventEntityConfiguration());
            modelBuilder.Configurations
                .Add(new NewsEntityConfiguration());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Event> Event { get; set; }

    }
}
