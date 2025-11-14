using System.ComponentModel.DataAnnotations;

namespace Vetrina.Models
{
    public class ProductType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string? NameProduct { get; set; }
        [Required]
        public decimal PriceProduct { get; set; }
        [Required]
        public string? PreviewImage { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? SecondaryImage1 { get; set; }
        [Required]
        public string? SecondaryImage2 { get; set; }
    }
}