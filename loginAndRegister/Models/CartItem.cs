namespace starSystemV2.Models
{
    public class CartItem
    {    public int CartItemId {get; set; }

        public int ProductId { get; set;}
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
