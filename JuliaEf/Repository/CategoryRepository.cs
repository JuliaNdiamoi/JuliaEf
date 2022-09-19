using JuliaEf.Data;
using JuliaEf.Models;
using Microsoft.EntityFrameworkCore;

namespace JuliaEf.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
        {
            _context = context;
        }

        //will use automapper
        public async Task<List<CategoryModel>> GetCategoriesAsync(string gender)
        {
            var categories = await _context.Categories.Select(x => new CategoryModel()
            {
                Id = x.Id,
                Name = x.Name,
                Gender = x.Gender
            }).Where(x => x.Gender == gender).ToListAsync();

            return categories;
        }
    }
}
