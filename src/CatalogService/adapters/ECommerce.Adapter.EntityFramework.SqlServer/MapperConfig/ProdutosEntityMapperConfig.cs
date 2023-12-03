using ECommerce.Adapter.EntityFramework.SqlServer.MapperConfig.Base;
using ECommerce.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Adapter.EntityFramework.SqlServer.MapperConfig
{
    public class ProdutosEntityMapperConfig : BaseEntityMapperConfig<ProdutoEntity>
    {
        protected override void ApplyBuilder(EntityTypeBuilder<ProdutoEntity> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Products");

            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(60);

            entityTypeBuilder.Property(p => p.Description)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(255);

            entityTypeBuilder.Property(p => p.ImageUrl)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(255);

            entityTypeBuilder.Property(p => p.Price)
                .IsRequired()
                .HasColumnType("decimal")
                .HasPrecision(10, 2);

            entityTypeBuilder.Property(p => p.Stock)
                .IsRequired()
                .HasColumnType("int");

            entityTypeBuilder.HasOne(p => p.Categoria).WithMany(p => p.Produtos).HasForeignKey(p => p.CategoryId);
        }
    }
}
