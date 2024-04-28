using System.ComponentModel.DataAnnotations;

namespace starSystemV2.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId { get; set; }

        public string UserId { get; set; }

        // Dictionary to store items, which is keyed by the productid
        public Dictionary<int, CartItem> Items { get; set; } = new Dictionary<int, CartItem>();

        public void AddItem(Product product,int quantity)
        {
            if(Items.TryGetValue(product.ProductId,out CartItem existingItem))
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items[product.ProductId] = new CartItem { Product = product, Quantity = quantity };
            }
        }
        public void RemoveItem(int productId)
        {
            if (Items.ContainsKey(productId))
            {
                Items.Remove(productId);
            }
        }

        public void updateQuantity(int productId, int newQuantity)
        {
            if (Items.TryGetValue(productId,out CartItem item))
            {
                if (newQuantity>0)
                {
                    item.Quantity = newQuantity;
                }
                else
                {
                    RemoveItem(productId);
                }
            }
        }

    }
}
