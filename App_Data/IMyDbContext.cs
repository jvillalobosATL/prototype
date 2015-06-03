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

namespace test_mvc_website.App_Data
{
    public interface IMyDbContext : IDisposable
    {
        IDbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        IDbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        IDbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        IDbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        IDbSet<BusinessProfessional> BusinessProfessionals { get; set; } // businessProfessionals
        IDbSet<CollegeProfessional> CollegeProfessionals { get; set; } // collegeProfessionals

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
    }

}
