using Microsoft.EntityFrameworkCore;
namespace ProductsAPI.Models
{
    
    public class ProductContext : DbContext
    {
        private readonly IConfiguration _context;
        public ProductContext(IConfiguration connectionString)
        {
            _context = connectionString;
        }
        public DbSet<Product> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_context.GetConnectionString("EmployeeDbContext"));
        }
    }
}
