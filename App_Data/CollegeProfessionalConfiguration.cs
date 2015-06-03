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
    // collegeProfessionals
    internal class CollegeProfessionalConfiguration : EntityTypeConfiguration<CollegeProfessional>
    {
        public CollegeProfessionalConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".collegeProfessionals");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired();
            Property(x => x.Email).HasColumnName("email").IsRequired().HasMaxLength(100);
            Property(x => x.Description).HasColumnName("description").IsOptional().HasMaxLength(500);
            Property(x => x.AreaOfStudy).HasColumnName("areaOfStudy").IsOptional().HasMaxLength(500);
            Property(x => x.YearsWorked).HasColumnName("yearsWorked").IsOptional();
            Property(x => x.HowDidYouHearAboutUs).HasColumnName("howDidYouHearAboutUs").IsOptional();
            Property(x => x.Name).HasColumnName("name").IsOptional().HasMaxLength(500);
            Property(x => x.AllowFeedbackEmail).HasColumnName("allowFeedbackEmail").IsRequired();
            Property(x => x.AllowSurvey).HasColumnName("allowSurvey").IsRequired();
            Property(x => x.AllowCall).HasColumnName("allowCall").IsRequired();
            Property(x => x.PhoneNumber).HasColumnName("phoneNumber").IsOptional().HasMaxLength(50);
            Property(x => x.UniversityInvolvement).HasColumnName("universityInvolvement").IsOptional();
        }
    }

}
