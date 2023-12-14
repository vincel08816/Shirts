using System.ComponentModel.DataAnnotations;
using WebApplication1.Models.Validations;

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
        [Shirt_EnsureCorrectSizing]
        public int Size { get; set; }
        public string? Type { get; set; }
        public double Price { get; set; }
        public string? Gender { get; set; }
    }
}


