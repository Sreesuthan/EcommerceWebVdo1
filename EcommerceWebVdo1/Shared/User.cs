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
        [Required ]
        public string UserName { get; set; } = string.Empty;
        [MaxLength(8)]
        public string Password { get; set; } = string.Empty;
    }
}
