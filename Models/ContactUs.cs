using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_mvc_website.App_Data
{
    public class ContactUs
    {

        public Guid Id { get; set; }
        [Required]
        [Display(Name="Name")]
        public string Name { get; set; } // name
        [Required]
        [EmailAddress(ErrorMessage = "invalid email")]
        [Display(Name="Email")]
        public string Email { get; set; } // email

        [Required]
        [Display(Name="Your Message")]
        public string Message { get; set; }
    }
}