using Microsoft.EntityFrameworkCore;

namespace PizzaPlace.Models
{
    public class PizzaPlaceDbContext : DbContext
    {
        public PizzaPlaceDbContext(DbContextOptions<PizzaPlaceDbContext> options) : base(options)
        {

        }

        public DbSet<Offer> Offers{ get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
    }
}
