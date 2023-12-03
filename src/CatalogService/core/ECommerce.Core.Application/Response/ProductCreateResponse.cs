namespace ECommerce.Core.Application.Response
{
    public class ProductCreateResponse
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public int Stock {  get; private set; }

        public int CategoryId { get; private set; }

        public ProductCreateResponse(string name,
            string description,
            decimal price,
            int stock,
            int categoryId)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            CategoryId = categoryId;
        }
    }
}
