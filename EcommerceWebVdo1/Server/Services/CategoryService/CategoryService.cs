using EcommerceWebVdo1.Shared;

namespace EcommerceWebVdo1.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; }=new List<Category> 
        {  
            new Category{Id =1, Name="Video Games", Url="video-games", Icon="aperture"},
            new Category{Id =2, Name="Movies", Url="movies", Icon="camera-slr"},
            new Category { Id = 3, Name = "Novels", Url = "novels", Icon = "book"}
        };
        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
