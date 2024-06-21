using KhumaloCrafts.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCrafts.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Contact> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                 .Property(p => p.Price)
                 .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ShoppingCart>()
                .Property(t => t.TotalPrice)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .Property(ta => ta.TotalAmount)
            .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<OrderItems>()
                .Property(u => u.UnitPrice)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);




        }

    }
}




