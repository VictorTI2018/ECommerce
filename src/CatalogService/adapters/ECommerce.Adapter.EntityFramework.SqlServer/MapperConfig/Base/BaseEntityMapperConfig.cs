using ECommerce.Core.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Adapter.EntityFramework.SqlServer.MapperConfig.Base
{
    public abstract class BaseEntityMapperConfig<T> : IEntityTypeConfiguration<T>
        where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id).IsClustered();

            ApplyBuilder(builder);
        }

        protected abstract void ApplyBuilder(EntityTypeBuilder<T> entityTypeBuilder);
    }
}
