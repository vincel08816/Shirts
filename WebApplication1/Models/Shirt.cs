using System.ComponentModel.DataAnnotations;

// when a type is required, then you can use the [Required] attribute
// otherwise you can make the variable nullable

namespace WebApplication1.Models
{
    public class Shirt
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Color { get; set; }
        public int Size { get; set; }
        public string? Type { get; set; }
        public double Price { get; set; }
    }
}


