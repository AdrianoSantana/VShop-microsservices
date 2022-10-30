using System.ComponentModel.DataAnnotations;
using VShop.ProductApi.Models;

namespace VShop.ProductApi.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Field name is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Field price is required")]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "Field Stock is required")]
        [Range(1, 2000)]
        public long Stock { get; set; }
        
        public string? ImageURL { get; set; }
        
        public Category? Category { get; set; }
    }
}