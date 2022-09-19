using AutoMapper;
using AutoMapper.QueryableExtensions;
using JuliaEf.Data;
using JuliaEf.Models;
using Microsoft.EntityFrameworkCore;

namespace JuliaEf.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;


        public CategoryRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //will use automapper
        public async Task<List<CategoryModel>> GetCategoriesAsync(string gender)
        {       
            return await _mapper.ProjectTo<CategoryModel>(_context.Categories.Where(x => x.Gender == gender)).ToListAsync();
        }
    }
}
