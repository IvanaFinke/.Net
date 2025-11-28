
using Microsoft.EntityFrameworkCore;

namespace Pizeria.Components
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pizza> Specials { get; set; }
    }
}
