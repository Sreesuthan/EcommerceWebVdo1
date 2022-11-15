using EcommerceWebVdo1.Server.Services.CategoryService;
using EcommerceWebVdo1.Shared;

namespace EcommerceWebVdo1.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProducts(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category=await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p=> p.CategoryId==category.Id).ToList();
        }
        public List<Product> Products { get; set; } = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Farcry 3",
                    Description = "It is a PC game. Developed by Ubisoft",
                    Image = @"https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/Far_Cry_3_PAL_box_art.jpg/220px-Far_Cry_3_PAL_box_art.jpg",
                    Price = 499.99m,
                    OriginalPrice = 1999.99m
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Assasins Creed 3",
                    Description = "It is a PC game. Developed by Ubisoft",
                    Image = @"https://upload.wikimedia.org/wikipedia/en/thumb/2/29/Assassin%27s_Creed_III_Game_Cover.jpg/220px-Assassin%27s_Creed_III_Game_Cover.jpg",
                    Price = 399.99m,
                    OriginalPrice = 1799.99m
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "GTA 5",
                    Description = "It is a PC game. Developed by Rockstar Games",
                    Image = @"https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Grand_Theft_Auto_V.png/220px-Grand_Theft_Auto_V.png",
                    Price = 459.99m,
                    OriginalPrice = 1899.99m
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 1,
                    Title = "Tomb Raider 2013",
                    Description = "It is a PC game. It is a story of Laura Craft",
                    Image = @"https://upload.wikimedia.org/wikipedia/en/thumb/f/f1/TombRaider2013.jpg/220px-TombRaider2013.jpg",
                    Price = 499.99m,
                    OriginalPrice = 1999.99m
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Avengers EndGame",
                    Description = "It is a Hollywood Movie in MCU",
                    Image = @"https://upload.wikimedia.org/wikipedia/en/0/0d/Avengers_Endgame_poster.jpg",
                    Price = 299.99m,
                    OriginalPrice = 999.99m
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Justice League",
                    Description = "It is a Hollywood Movie in DCU",
                    Image = @"https://upload.wikimedia.org/wikipedia/en/6/6b/Justice_League_%28film%29_poster.jpg",
                    Price = 249.99m,
                    OriginalPrice = 899.99m
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Ponniyin Selvan",
                    Description = "It is noval written by KALKI",
                    Image = @"https://upload.wikimedia.org/wikipedia/en/b/ba/Ponniyin_selvan_volume_1.jpg",
                    Price = 399.99m,
                    OriginalPrice = 1499.99m
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Julius Caeser",
                    Description = "It is a history play and tragedy by William Shakespeare",
                    Image = @"https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Edwin_Austin_Abbey_-_Within_the_Tent_of_Brutus%2C_Enter_the_Ghost_of_Caesar%2C_Julius_Caesar%2C_Act_IV%2C_Scene_III_-_1937.1148_-_Yale_University_Art_Gallery.jpg/220px-Edwin_Austin_Abbey_-_Within_the_Tent_of_Brutus%2C_Enter_the_Ghost_of_Caesar%2C_Julius_Caesar%2C_Act_IV%2C_Scene_III_-_1937.1148_-_Yale_University_Art_Gallery.jpg",
                    Price = 349.99m,
                    OriginalPrice = 1399.99m
                }
            };
        
    }
}
