using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Shared
{
    public class ChangePassword
    {
        public string Email { get; set; }
        [Required(ErrorMessage = "Password must be provided")]
        [MinLength(8)]
        [RegularExpression("((?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[#$^+=!*()@%&]).{8,64})", ErrorMessage = "Passsword must contain a mix of upper and lower case characters, one numeric and one special character")]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
