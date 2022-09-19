using JuliaEf.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JuliaEf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet("{gender}")]
        public async Task<IActionResult> GetAllCategories(string gender)
        {
            var categories = await _categoryRepository.GetCategoriesAsync(gender);
            return Ok(categories);
        }
    }
}
