namespace ECommerce.CarrinhoService.Core.Service.Request
{
    public class CartRequest
    {
        public string User { get; set; }

        public List<ProductsRequest> Products { get; set; }

        public decimal Total { get; set; }
    }

    public class ProductsRequest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
