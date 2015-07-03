

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
    public class CollegeProfessional
    {
        public Guid Id { get; set; } // Id (Primary key)

        public string Name { get; set; } // name     
        public string Email { get; set; } // email
        public string Description { get; set; } // description
        public string AreaOfStudy { get; set; } // areaOfStudy
        public eYearsOfExperience? YearsWorked { get; set; } // yearsWorked
        public string HowDidYouHearAboutUs { get; set; } // howDidYouHearAboutUs
        public bool AllowFeedbackEmail { get; set; } // allowFeedbackEmail
        public bool AllowSurvey { get; set; } // allowSurvey
        public bool AllowCall { get; set; } // allowCall
        public string PhoneNumber { get; set; } // phoneNumber
        public eUniversityInvolvement? UniversityInvolvement { get; set; } // phoneNumber
        public string DegreeMayor { get; set; } 
        public string UniversityName { get; set; } 


    }
    // collegeProfessionals
    public class CollegeProfessionalViewModel
    {
        public Guid Id { get; set; } // Id (Primary key)


        [Required]
        public string Name { get; set; } // name
        [Required]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; } // email

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "What best describes you? (college professor, in phd masters, etc.)")]
        public string Description { get; set; } // description
         [Display(Name = "Area of Study")]
        public string AreaOfStudy { get; set; } // areaOfStudy
        [Display(Name = "Years worked in analytics/bi")]
         public eYearsOfExperience? YearsWorked { get; set; } // yearsWorked
        [Display(Name = "How did you hear about us")]
        public string HowDidYouHearAboutUs { get; set; } // howDidYouHearAboutUs
  
        [Display(Name = "Can we email you for additional feedback?")]
        public bool AllowFeedbackEmail { get; set; } // allowFeedbackEmail
        [Display(Name = "Do you mind taking a quick survey?")]
        public bool AllowSurvey { get; set; } // allowSurvey
        [Display(Name = "Can we call you to discuss our solution in more detail?")]
        public bool AllowCall { get; set; } // allowCall

          [Display(Name = "Phone Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "invalid number")]
        public string PhoneNumber { get; set; } // phoneNumber
          [Display(Name = "University Involvement")]
          public eUniversityInvolvement? UniversityInvolvement { get; set; } // phoneNumber

          [Display(Name = "Degree/Mayor (e.g. MS Applied Statistics)")]
          public string DegreeMayor { get; set; }
          [Display(Name = "University Name")]
          public string UniversityName { get; set; } 
    }

}
