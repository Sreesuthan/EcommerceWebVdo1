using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebVdo1.Shared
{
	public class CartItem
	{
		public int ProductId { get; set; }
		public int EditionId { get; set; }
		public string ProductTitle { get; set; } = string.Empty;
		public string EditionName { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public string Image { get; set; } = string.Empty;
		public int Quantity { get; set; }
	}
}
