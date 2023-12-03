using ECommerce.Adapter.EntityFramework.SqlServer.MapperConfig;
using ECommerce.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ECommerce.Adapter.EntityFramework.SqlServer.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {
            
        }

        public DbSet<CategoriaEntity> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaEntityMapperConfig());
            modelBuilder.ApplyConfiguration(new ProdutosEntityMapperConfig());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class ECommerceContextFactory : IDesignTimeDbContextFactory<ECommerceContext>
    {
        public ECommerceContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ECommerceContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=Catalog;Trusted_Connection=True;Encrypt=False");
            return new ECommerceContext(optionsBuilder.Options);
        }
    }
}
