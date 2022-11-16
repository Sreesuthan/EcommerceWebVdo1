using EcommerceWebVdo1.Server.Data;
using EcommerceWebVdo1.Shared;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWebVdo1.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
