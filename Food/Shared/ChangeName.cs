using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Shared
{
    public class ChangeName
    {
        public string Email { get; set; }

        [Required(ErrorMessage = "Name must be provided")]
        [MinLength(5)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Name { get; set; }
    }
}
