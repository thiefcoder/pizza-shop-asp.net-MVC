using Microsoft.EntityFrameworkCore;
using RazorPizzeia.Models;

namespace RazorPizzeia.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<pizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
