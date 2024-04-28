using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace starSystemV2.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId { get; set; }

        public string UserId { get; set; }

        // Dictionary to store items, which is keyed by the productid
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public void AddItem(Product product,int quantity)
        {
            var existingItem = Items.FirstOrDefault(item => item.ProductId == product.ProductId);
            if(existingItem!=null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem() { ProductId = product.ProductId,Quantity = quantity});
            }
        }
        public void RemoveItem(int productId)
        {
            var removedItem = Items.FirstOrDefault(item => item.ProductId == productId);
            if (removedItem!=null)
            {
                Items.Remove(removedItem);
            }
        }

        public void updateQuantity(int productId, int newQuantity)
        {
            var item = Items.FirstOrDefault(item => item.ProductId == productId);
                if (item!=null)
                {
                if (newQuantity > 0) { 
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
