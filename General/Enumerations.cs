using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_mvc_website.General
{

        public enum eUniversityInvolvement
        {

            student,
            professor
        }
        public enum eIndustry
        {
            banking,
            biotech,
            energy,
            [Display(Name = "financial services")]
            financial_services,
            [Display(Name = "gaming and hospitality")]
            gaming_and_hospitality,
            [Display(Name = "health care")]
            health_care,
            insurance,
            internet,
            manufacturing,
            [Display(Name = "non profit")]
            non_profit,
            pharmaceutical,
            [Display(Name = "public service")]
            public_service,
            retail,
            telecom,
            [Display(Name = "travel and transportation")]
            travel_and_transportation,
            utilities
        }
        public enum eCompanySize 
        {

            [Display(Name = "Less than $1M Revenue")]
            _less1m,
             [Display(Name = "$1M - $10M Revenue")]
            _1to10,
             [Display(Name = "$10M - $100M Revenue")]
            _10to100,
             [Display(Name = "$100M - $1B Revenue")]
            _100to1b
        }

        public enum eEducationLevel  {
        
            bachelors,
            masters,
            doctoral

        }
        public enum eYearsOfExperience
        {

            [Display(Name = "0 years")]
            _0,
            [Display(Name = "1-2 years")]
            _1_2,
            [Display(Name = "3-5 years")]
            _3_5,
            [Display(Name = "6-10 years")]
            _6_10,
            [Display(Name = "10+ years")]
            _10_more

        }
    }
