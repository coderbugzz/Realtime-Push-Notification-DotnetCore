using Microsoft.EntityFrameworkCore;
namespace ProductsUI.Models
{
    public class ProductsContext : DbContext
    {
        private readonly IConfiguration _context;
        public ProductsContext(IConfiguration connectionString)
        {
            _context = connectionString;
        }
        public DbSet<ProductsContext> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_context.GetConnectionString("DefaultConnection"));
        }
    }
}
