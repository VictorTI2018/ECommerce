using ECommerce.Adapter.EntityFramework.SqlServer.MapperConfig.Base;
using ECommerce.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Adapter.EntityFramework.SqlServer.MapperConfig
{
    public class CategoriaEntityMapperConfig : BaseEntityMapperConfig<CategoriaEntity>
    {
        protected override void ApplyBuilder(EntityTypeBuilder<CategoriaEntity> entityTypeBuilder)
        {
            entityTypeBuilder.ToTable("Category");

            entityTypeBuilder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(80);

            entityTypeBuilder.Property(c => c.Description)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(250);

            entityTypeBuilder.HasMany(c => c.Produtos).WithOne(c => c.Categoria).HasForeignKey(p => p.CategoryId);

        }
    }
}
