namespace ECommerce.CarrinhoService.Core.Domain.Models
{
    public sealed class ProductsModel
    {
        public int Id { get; set; }

        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public int Quantity { get; private set; }


        public ProductsModel(int id,
            string name,
            decimal price,
            int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }
}
