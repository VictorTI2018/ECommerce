using ECommerce.CarrinhoService.Core.Domain.Interfaces.Service;
using ECommerce.CarrinhoService.Core.Service.Cart;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.CarrinhoService.Core.Service
{
    public static class ServiceInjectionModule
    {
        public static void AddServiceModule(this IServiceCollection services)
        {
            services.AddScoped<ICartService, CartService>();
        }
    }
}
