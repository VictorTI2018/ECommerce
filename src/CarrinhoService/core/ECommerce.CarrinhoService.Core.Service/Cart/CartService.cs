using ECommerce.CarrinhoService.Adapter.RedisCaching.Repositories.Base;
using ECommerce.CarrinhoService.Core.Domain.Interfaces.Service;
using ECommerce.CarrinhoService.Core.Domain.Models;

namespace ECommerce.CarrinhoService.Core.Service.Cart
{
    public class CartService : ICartService
    {
        private readonly BaseCachingRespository _cachingRepository;

        public CartService()
        {
            _cachingRepository = new BaseCachingRespository();
        }

        public async Task AddProduct(CartModel cart)
        {
           try
            {
                var key = $"{cart.User}";

                if (await _cachingRepository.KeyExistsAsync(key))
                {
                    var cartByUser = await _cachingRepository.GetDataAsync<CartModel>(key);

                    foreach(var product in cart.Products)
                    {
                        if (!cartByUser.Products.Any(p => p.Id.Equals(product.Id)))
                            cartByUser.Products.Add(product);
                    }
                }
                else
                    await _cachingRepository.SetData(key, cart);
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
