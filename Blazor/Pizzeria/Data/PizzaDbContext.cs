using Microsoft.EntityFrameworkCore;
using Pizeria.Components;

namespace Pizeria.Data
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options) { }

        public DbSet<PizzaDatos> Pizzas { get; set; } = null!;
    }
}