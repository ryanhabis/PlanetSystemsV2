using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace loginAndRegister.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<starSystemV2.Models.Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<starSystemV2.Models.Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2");
            base.OnModelCreating(builder);
        }

        public DbSet<starSystemV2.Models.CartItem> Planets { get; set; }
        public DbSet<starSystemV2.Models.ShoppingCart> ShoppingCarts { get; set; }
    }
}
