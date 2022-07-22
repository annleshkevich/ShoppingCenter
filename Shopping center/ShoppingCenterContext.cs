using Microsoft.EntityFrameworkCore;
using Shopping_center.Entities;

namespace Shopping_center
{
    internal class ShoppingCenterContext : DbContext
    {
       public ShoppingCenterContext() => Database.EnsureCreated();
        public DbSet<Cafe> Cafes { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<Person> People { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<Shop> Shops { get; set; } = null!;
        public DbSet<ShoppingCenter> ShoppingCenters { get; set; } = null!;
        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<Company> Сompanies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANNLE;Database=ShoppingCenter;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity <Client>().HasData(
                new Client { Id = 1, Name = "Harry" },
                new Client { Id = 2, Name = "Lucy" },
                new Client { Id = 3, Name = "Sam" }
                );
        }
    }
}