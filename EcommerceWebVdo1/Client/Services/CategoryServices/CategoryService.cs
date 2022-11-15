using EcommerceWebVdo1.Shared;

namespace EcommerceWebVdo1.Client.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category{Id =1, Name="Video Games", Url="video-games", Icon="aperture"},
                new Category{Id =2, Name="Movies", Url="movies", Icon="movie"},
                new Category{Id =3, Name="Novels", Url="novels", Icon="book"}
            };
        }
    }
}
