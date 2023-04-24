global using Microsoft.EntityFrameworkCore;

namespace Shopping;

public class ShopDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=cdaclab.bkc.met.edu;Database=Shop1;User Id=dac1;Password=Dac1@1234;Encrypt=false");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .ToTable("ProductInfo")
            .Property(e => e.Id)
            .HasColumnName("ProductNo");
        modelBuilder.Entity<Order>()
            .ToTable("OrderDetail")
            .Property(e => e.Id)
            .HasColumnName("OrderNo");
        modelBuilder.Entity<Order>()
            .Property(e => e.ProductId)
            .HasColumnName("ProductNo");
    }
}