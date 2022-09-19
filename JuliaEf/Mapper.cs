using AutoMapper;
using JuliaEf.Data;
using JuliaEf.Models;

namespace JuliaEf
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Categories, CategoryModel>();
            CreateMap<Products, ProductModel>();
        }
    }
}
