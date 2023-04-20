using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebVdo1.Shared
{
    public class User
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "{0} is a mandatory feild")]
        [MaxLength(15)]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [StringLength(maximumLength:15 ,MinimumLength =8, ErrorMessage ="The {0} should have {1} maximum characters and {2} minimum characters")]
        public string Password { get; set; } = string.Empty;
    }
}
