using Microsoft.EntityFrameworkCore;

namespace JuliaEf.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            :base(options)
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }


    }
}
