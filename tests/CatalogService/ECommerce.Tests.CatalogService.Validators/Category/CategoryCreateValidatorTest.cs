using ECommerce.Core.Domain.Entities;
using ECommerce.Core.Services.Validators.Category;

namespace ECommerce.Tests.CatalogService.Validators.Category
{
    public class CategoryCreateValidatorTest
    {

        [Fact]
        public void Return_Error_When_Name_Is_Empty()
        {
            CategoriaEntity entity = new(string.Empty, "teste");

            CategoryCreateValidator validator = new();

            var result = validator.Validate(entity);

            Assert.False(result.IsValid);
            Assert.True(result.Errors.Count == 1);
        }

        [Fact]
        public void Return_Error_When_Description_Is_Empty()
        {
            CategoriaEntity entity = new("teste", string.Empty);

            CategoryCreateValidator validator = new();

            var result = validator.Validate(entity);

            Assert.False(result.IsValid);
            Assert.True(result.Errors.Count == 1);
        }
    }
}
