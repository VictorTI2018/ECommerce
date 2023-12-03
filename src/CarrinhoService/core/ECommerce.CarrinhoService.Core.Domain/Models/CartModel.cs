namespace ECommerce.CarrinhoService.Core.Domain.Models
{
    public class CartModel
    {
        public string User { get; private set; }

        public List<ProductsModel> Products { get; private set; }

        public decimal Total { get; private set; }

        public CartModel(string user,
            List<ProductsModel> products,
            decimal total)
        {
            User = user;
            Products = products;
            Total = total;
        }
    }
}
