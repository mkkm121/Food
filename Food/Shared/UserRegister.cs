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
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password must be provided")]
        [MinLength(8)]
        [RegularExpression("((?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[#$^+=!*()@%&]).{8,64})", ErrorMessage = "Passsword must contain a mix of upper and lower case characters, one numeric and one special character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email must be provided")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone must be provided")]
        [Phone(ErrorMessage = "Only use decimal or +,(,), .")]
        [MinLength(9)]
        [MaxLength(15)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Street must be provided")]
        public string Street { get; set; }
        [Required(ErrorMessage = "City must be provided")]
        public string City { get; set; }
        [Required(ErrorMessage = "PostCode must be provided")]
        [RegularExpression("^[0-9]{2}-[0-9]{3}", ErrorMessage = "PostCode Format XX-XXX")]
        public string PostCode { get; set; }
    }
}
