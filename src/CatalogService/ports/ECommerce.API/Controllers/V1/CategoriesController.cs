using ECommerce.Core.Application.Presenter.Category;
using ECommerce.Core.Application.Request.Category;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers.V1
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryPresenter _categoryPresenter;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryPresenter"></param>
        public CategoriesController(ICategoryPresenter categoryPresenter)
        {
            _categoryPresenter = categoryPresenter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryCreateRequest request)
        {
            var result = await _categoryPresenter.SaveAsync(request);

            if (!result.Status)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
