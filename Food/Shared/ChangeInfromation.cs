using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Shared
{
    public class ChangeInfromation
    {
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
