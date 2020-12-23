using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ST.Models;
using System.Data.Entity.ModelConfiguration;

namespace ST.Configurations
{
    public class EventEntityConfiguration : EntityTypeConfiguration<Event>
    {
        public EventEntityConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Name)
                .IsRequired();

            Property(x => x.Information)
                .IsRequired();

        }
    }
}
