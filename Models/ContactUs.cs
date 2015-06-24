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
        public string Name { get; set; } // name
        [Required]
        [EmailAddress(ErrorMessage = "invalid email")]
        public string Email { get; set; } // email

        [Required]
        public string Message { get; set; }
    }
}