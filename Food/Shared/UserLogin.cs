using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Food.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Password must be provided")]
        [MinLength(8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email must be provided")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
