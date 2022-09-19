using JuliaEf.Models;

namespace JuliaEf.Repository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryModel>> GetCategoriesAsync(string gender);

    }
}
