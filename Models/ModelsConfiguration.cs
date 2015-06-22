using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace test_mvc_website.Models
{
     // collegeProfessionals
    internal class UserMappingsConfiguration : EntityTypeConfiguration<UserMapping>
    {
        public UserMappingsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".userMappings");
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.Type).HasColumnName("Type").IsRequired().HasMaxLength(100);
            Property(x => x.EntityId).HasColumnName("EntityId").IsRequired();
        }
    }
}