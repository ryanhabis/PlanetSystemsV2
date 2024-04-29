using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace starSystemV2.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Name field is required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "The price field is necessary")]
        [Range(0.01,double.MaxValue,ErrorMessage ="The price must be greater than 0")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
