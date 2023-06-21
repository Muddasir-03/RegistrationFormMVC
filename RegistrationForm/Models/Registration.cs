using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class Registration
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Email { get; set; }

    }
}