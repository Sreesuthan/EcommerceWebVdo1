using EcommerceWebVdo1.Shared;

namespace EcommerceWebVdo1.Client.Services.CategoryServices
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}
