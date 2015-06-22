// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using System.Threading.Tasks;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;
using test_mvc_website.Models;

namespace test_mvc_website.App_Data
{
    public class MyDbContext : DbContext, IMyDbContext
    {
        public IDbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        public IDbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        public IDbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        public IDbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        public IDbSet<BusinessProfessional> BusinessProfessionals { get; set; } // businessProfessionals
        public IDbSet<CollegeProfessional> CollegeProfessionals { get; set; } // collegeProfessionals
        public IDbSet<UserMapping> UserMappings { get; set; }
        
        static MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext()
            : base("Name=DefaultConnection")
        {
        }

        public MyDbContext(string connectionString) : base(connectionString)
        {
        }

        public MyDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AspNetRoleConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration());
            modelBuilder.Configurations.Add(new BusinessProfessionalConfiguration());
            modelBuilder.Configurations.Add(new CollegeProfessionalConfiguration());
            modelBuilder.Configurations.Add(new UserMappingsConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AspNetRoleConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration(schema));
            modelBuilder.Configurations.Add(new BusinessProfessionalConfiguration(schema));
            modelBuilder.Configurations.Add(new CollegeProfessionalConfiguration(schema));
            modelBuilder.Configurations.Add(new UserMappingsConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
    }
}
