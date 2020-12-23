﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ST.Models;
using System.Data.Entity.ModelConfiguration;

namespace ST.Configurations
{
    public class EmployeeEntityConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeEntityConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
