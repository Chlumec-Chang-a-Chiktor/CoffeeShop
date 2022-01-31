using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoffeIngredient>().HasKey(sc => new { sc.CoffeeId, sc.IngredientId });
        }
        public DbSet<CoffeIngredient> CoffeIngredients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
