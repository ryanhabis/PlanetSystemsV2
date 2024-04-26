using System.ComponentModel.DataAnnotations;

namespace starSystems.Models
{
    public class Planets
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int StarId { get; set; }
        [Required]
        public string? StarSystem { get; set; }
    }
}
