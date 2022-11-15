using EcommerceWebVdo1.Shared;

namespace EcommerceWebVdo1.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}