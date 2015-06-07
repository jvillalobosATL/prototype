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
        public string Name { get; set; } // name
        [Required]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; } // email

        [Display(Name = "How did you hear about us")]
        public string HowDidYouHearAboutUs { get; set; } // howDidYouHearAboutUs
        public eIndustry? Industry { get; set; } // industry

        [Display(Name = "Title (e.g. VP Operations)")]
        public string Title { get; set; } // title
        [Display(Name = "Company Size")]
        public eCompanySize? CompanySize { get; set; } // companySize

        [Display(Name = "Can we email you for additional feedback?")]
        public bool AllowFeedbackEmail { get; set; } // allowFeedbackEmail
        [Display(Name = "Do you mind taking a quick survey?")]
        public bool AllowSurvey { get; set; } // allowSurvey
        [Display(Name = "Can we call you to discuss our solution in more detail?")]
        public bool AllowCall { get; set; } // allowCall
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "invalid number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } // phoneNumber
    }

    // businessProfessionals
    public class BusinessProfessionalViewModel
    {
        public Guid Id { get; set; } // Id (Primary key)

        [Required]
        public string Name { get; set; } // name
        [Required]
        [EmailAddress(ErrorMessage="invalid email")]
        public string Email { get; set; } // email

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")] 
        public string ConfirmPassword { get; set; }

        [Display(Name="How did you hear about us")]
        public string HowDidYouHearAboutUs { get; set; } // howDidYouHearAboutUs
        public eIndustry? Industry { get; set; } // industry

        [Display(Name = "Title (e.g. VP Operations)")]
        public string Title { get; set; } // title
        [Display(Name = "Company Size")]
        public eCompanySize? CompanySize { get; set; } // companySize
        
        [Display(Name = "Can we email you for additional feedback?")]
        public bool AllowFeedbackEmail { get; set; } // allowFeedbackEmail
        [Display(Name = "Do you mind taking a quick survey?")]
        public bool AllowSurvey { get; set; } // allowSurvey
        [Display(Name = "Can we call you to discuss our solution in more detail?")]
        public bool AllowCall { get; set; } // allowCall
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "invalid number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } // phoneNumber
    }

}
