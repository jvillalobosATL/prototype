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
    // collegeProfessionals
    public class CollegeProfessional
    {
        public Guid Id { get; set; } // Id (Primary key)

        
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; } // email
        [Display(Name = "What best describes you? (college professor, in phd masters, etc.)")]
        public string Description { get; set; } // description
         [Display(Name = "Area of Study")]
        public string AreaOfStudy { get; set; } // areaOfStudy
        [Display(Name = "Years worked in analytics/business intelligence field")]
         public eYearsOfExperience? YearsWorked { get; set; } // yearsWorked
        [Display(Name = "How did you hear about us")]
        public string HowDidYouHearAboutUs { get; set; } // howDidYouHearAboutUs
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
          [Display(Name = "University Involvement")]
          public eUniversityInvolvement? UniversityInvolvement { get; set; } // phoneNumber
    }

}
