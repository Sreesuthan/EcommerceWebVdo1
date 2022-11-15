using EcommerceWebVdo1.Shared;

namespace EcommerceWebVdo1.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(string categoryUrl);
        Task<Product> GetProducts(int id);

    }
}
