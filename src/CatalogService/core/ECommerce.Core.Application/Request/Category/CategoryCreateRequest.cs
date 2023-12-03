using System.ComponentModel.DataAnnotations;

namespace ECommerce.Core.Application.Request.Category
{
    public class CategoryCreateRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
