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
            biotech,
            pharmaceutical,
            [Display(Name="health care")]
            health_care,
            energy,
            utilities,
            telecom,
            banking,
            [Display(Name = "financial services")]
            financial_services,
            insurance,
            manufacturing,
             [Display(Name = "public service")]
            public_service,
             [Display(Name = "travel and transportation")]
            travel_and_transportation,
             [Display(Name = "gaming and hospitality")]
            gaming_and_hospitality,
            retail,
            internet,
             [Display(Name = "non profit")]
            non_profit
        }
        public enum eCompanySize 
        {

            [Display(Name = "1-9")]
            _1_9,
             [Display(Name = "10-24")]
            _10_24,
             [Display(Name = "25-99")]
            _25_99,
             [Display(Name = "100-499")]
            _100_499,
             [Display(Name = "500-999")]
            _500_999,
             [Display(Name = "1000-1999")]
            _1000_1999,
             [Display(Name = "2000-4999")]
            _2000_4999,
             [Display(Name = "5000-9999")]
            _5000_9999,
             [Display(Name = "10000 or more")]
            _10000_or_more
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
