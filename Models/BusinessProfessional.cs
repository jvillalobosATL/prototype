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
using System.ComponentModel.DataAnnotations;
using test_mvc_website.General;
namespace test_mvc_website.App_Data
{
    // businessProfessionals
    public class BusinessProfessional
    {
        public Guid Id { get; set; } // Id (Primary key)
        [Required]
        public string Email { get; set; } // email
        [Display(Name="How did you hear about us")]
        public string HowDidYouHearAboutUs { get; set; } // howDidYouHearAboutUs
        public eIndustry? Industry { get; set; } // industry
         [Display(Name = "Company Size")]
        public eCompanySize? CompanySize { get; set; } // companySize
        public string Title { get; set; } // title
        [Required]
        public string Name { get; set; } // name
        [Display(Name = "Can we email you for additional feedback?")]
        public bool AllowFeedbackEmail { get; set; } // allowFeedbackEmail
        [Display(Name = "Do you mind taking a quick survey?")]
        public bool AllowSurvey { get; set; } // allowSurvey
        [Display(Name = "Can we call you to discuss our solution in more detail?")]
        public bool AllowCall { get; set; } // allowCall
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } // phoneNumber
    }

}
