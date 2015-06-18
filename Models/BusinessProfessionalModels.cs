
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
using System.ComponentModel.DataAnnotations;
using test_mvc_website.General;
namespace test_mvc_website.App_Data
{


    // businessProfessionals
    public class BusinessProfessional
    {
        public Guid Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // name
        public string Email { get; set; } // email

        public string HowDidYouHearAboutUs { get; set; } // howDidYouHearAboutUs

        public eIndustry? Industry { get; set; } // industry
        public string Title { get; set; } // title
        public eCompanySize? CompanySize { get; set; } // companySize
        public bool AllowFeedbackEmail { get; set; } // allowFeedbackEmail
        public bool AllowSurvey { get; set; } // allowSurvey
        public bool AllowCall { get; set; } // allowCall
        public string PhoneNumber { get; set; } // phoneNumber
    }

    // businessProfessionals
    public class BusinessProfessionalViewModel
    {
        public Guid Id { get; set; } // Id (Primary key)

        [Required(ErrorMessage="name required")]
        public string Name { get; set; } // name
        [Required(ErrorMessage = "email required")]
        [EmailAddress(ErrorMessage="invalid email")]
        public string Email { get; set; } // email

        [Required(ErrorMessage = "password required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")] 
        public string ConfirmPassword { get; set; }

        [Display(Name="How did you hear about us")]
        public string HowDidYouHearAboutUs { get; set; } // howDidYouHearAboutUs
        [Required(ErrorMessage = "Industry required")]
        public eIndustry? Industry { get; set; } // industry

        [Required(ErrorMessage = "title required")]
        [Display(Name = "Title (e.g. VP Operations)")]
        public string Title { get; set; } // title
        [Required(ErrorMessage = "Company Size required")]
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
