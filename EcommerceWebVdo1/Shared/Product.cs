using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebVdo1.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }=string.Empty;   
        public string Image { get; set; } = string.Empty;
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public List<ProductVariant>? Variants { get; set; } = new List<ProductVariant>(); 
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public int Views { get; set; }
    }
}
