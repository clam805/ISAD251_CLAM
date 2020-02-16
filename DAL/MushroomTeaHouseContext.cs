using MushroomTeaHouse.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MushroomTeaHouse.DAL
{
    public class MushroomTeaHouseContext : DbContext
    {

        public MushroomTeaHouseContext() : base("MushroomTeaHouseContext")
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
