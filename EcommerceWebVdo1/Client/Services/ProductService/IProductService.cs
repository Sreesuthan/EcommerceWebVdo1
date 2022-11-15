using EcommerceWebVdo1.Shared;

namespace EcommerceWebVdo1.Client.Services.ProductService
{
	public interface IProductService
	{
		List<Product> Products { get; set; }
		void LoadProducts();
	}
}
