using JuliaEf.Models;

namespace JuliaEf.Repository
{
    public interface IProductRepository
    {
        Task<List<ProductModel>> GetProductsAsync(string gender, string Category);
        Task <ProductModel> GetProductById(int id);


    }
}
