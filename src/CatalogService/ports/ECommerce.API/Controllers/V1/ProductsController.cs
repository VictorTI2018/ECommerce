using ECommerce.Core.Application.Presenter.Product;
using ECommerce.Core.Application.Request.Product;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers.V1
{
    /// <summary>
    /// Controller para gerenciar ações de [Produtos]
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductPresenter _productPresenter;

        /// <summary>
        /// Construtor padrão
        /// </summary>
        /// <param name="productPresenter"></param>
        public ProductsController(IProductPresenter productPresenter)
        {
            _productPresenter = productPresenter;
        }

        /// <summary>
        /// Listar todos os produtos por categoria
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [HttpGet("{categoryId}")]
        public async Task<IActionResult> Get(int categoryId)
            => Ok(await _productPresenter.GetAllByCategory(categoryId));


        /// <summary>
        /// Cadastrar um novo produto
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductCreateRequest request)
        {
            var result = await _productPresenter.SaveAsync(request);

            if (!result.Status)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
