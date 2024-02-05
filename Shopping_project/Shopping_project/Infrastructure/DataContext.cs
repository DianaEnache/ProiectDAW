using Microsoft.EntityFrameworkCore;
using Shopping_project.Models;


namespace Shopping_project.Infrastructure
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        
            public DbSet<Product> Products {  get; set; }
            public DbSet<Category> Categories { get; set; }




    }

}

