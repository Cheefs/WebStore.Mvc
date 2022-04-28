using WebStore.Mvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebStore.Mvc.DataAccessLayer
{
    public class WebStoreDbContext: DbContext
    {
        public DbSet<Product>? Products { get; set; }
        public DbSet<Section>? Sections { get; set; }
        public DbSet<Brand>? Brands { get; set; }
        public WebStoreDbContext(DbContextOptions options): base(options) { }
    }
}
