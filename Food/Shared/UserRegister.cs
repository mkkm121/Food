using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Food.Shared
{
    public class UserRegister
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name must be provided")]
        [MinLength(5)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password must be provided")]
        [MinLength(8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email must be provided")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Name must be provided")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Name must be provided")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Name must be provided")]
        public string City { get; set; }
        [Required(ErrorMessage = "Name must be provided")]
        public string PostCode { get; set; }
    }
}
