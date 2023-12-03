using ECommerce.Adapter.EntityFramework.SqlServer.Context;
using ECommerce.Adapter.EntityFramework.SqlServer.Repositories;
using ECommerce.Core.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Adapter.EntityFramework.SqlServer
{
    public static class SqlServerInjectionModule
    {
        public static void AddRepositoriesModule(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }

        public static void AddSqlServerModule(this IServiceCollection services, string connection)
        {
            services.AddDbContext<ECommerceContext>(options =>
            {
                options.UseSqlServer(connection);
            });
        }
    }
}
