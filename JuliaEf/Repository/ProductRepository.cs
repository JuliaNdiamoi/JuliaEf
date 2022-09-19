using JuliaEf.Data;
using JuliaEf.Models;
using Microsoft.EntityFrameworkCore;

namespace JuliaEf.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        //will use automapper
        public async Task<List<ProductModel>> GetProductsAsync(string gender, string Category)
        {
            var products = await _context.Products.Select(x => new ProductModel()
            {
                Id = x.Id,
                Name = x.Name,
                Gender = x.Gender,
                Category = x.Category,
                Description = x.Description,
                Price = x.Price,
                Size = x.Size              


            }).Where(x => x.Gender == gender && x.Category == Category).ToListAsync();

            return products;
        }

        public async Task<ProductModel>GetProductById(int id)
        {
            var product = await _context.Products.Select(x => new ProductModel()
            {
                Id = x.Id,
                Name = x.Name,
                Gender = x.Gender,
                Category = x.Category,
                Description = x.Description,
                Price = x.Price,
                Size = x.Size


            }).Where(x => x.Id == id).FirstOrDefaultAsync(); 

            return product;
        }
    }
}
