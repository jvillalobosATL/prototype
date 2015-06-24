using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using test_mvc_website.App_Data;

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

    internal class ContactUsConfiguration : EntityTypeConfiguration<ContactUs>
    {
        public ContactUsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ContactUs");
            //HasKey(x => x.);
            HasKey(x => x.Id);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);
            Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(100);
            Property(x => x.Message).HasColumnName("Message").IsRequired().HasMaxLength(2000);
        }

    }


}