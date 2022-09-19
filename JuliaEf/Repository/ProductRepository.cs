using AutoMapper;
using JuliaEf.Data;
using JuliaEf.Migrations;
using JuliaEf.Models;
using Microsoft.EntityFrameworkCore;

namespace JuliaEf.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public ProductRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //will use automapper
        public async Task<List<ProductModel>> GetProductsAsync(string gender, string category)
        {
            return await _mapper.ProjectTo<ProductModel>(_context.Products
                .Where(x => x.Gender == gender && x.Category == category))
                .ToListAsync();

        }

        public async Task<ProductModel>GetProductById(int id)
        {       
            var product = await _context.Products.FindAsync(id);
            return _mapper.Map<ProductModel>(product);
        }
    }
}
