using ECommerce.CarrinhoService.Core.Domain.Interfaces.Service;
using ECommerce.CarrinhoService.Core.Domain.Models;
using ECommerce.CarrinhoService.Core.Service.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.CarrinhoService.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CartRequest request)
        {
            List<ProductsModel> products = new();
            foreach (var product in request.Products)
            {
                ProductsModel productsModel = new(product.Id,
                    product.Name, product.Price, product.Quantity);

                products.Add(productsModel);
            }

            CartModel model = new(request.User, products, request.Total);

            await _cartService.AddProduct(model);

            return Ok();
        }
    }
}
