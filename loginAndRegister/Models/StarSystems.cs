using System.ComponentModel.DataAnnotations;

namespace starSystems.Models
{
    public class StarSystems
    {
        [Key]
        public int StarId { get; set; }
        [MaxLength(200)]
        public string StarName { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
    }
}