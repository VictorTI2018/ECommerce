using ECommerce.CarrinhoService.Core.Domain.Models;

namespace ECommerce.CarrinhoService.Core.Domain.Interfaces.Service
{
    public interface ICartService
    {
        Task AddProduct(CartModel cart);
    }
}
