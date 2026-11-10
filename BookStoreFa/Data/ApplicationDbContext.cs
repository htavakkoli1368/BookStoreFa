using BookStoreFa.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreFa.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Products> Product { get; set; }
    }
}
