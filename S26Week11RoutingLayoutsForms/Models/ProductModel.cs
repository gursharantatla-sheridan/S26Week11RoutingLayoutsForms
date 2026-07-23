using System.ComponentModel.DataAnnotations;

namespace S26Week11RoutingLayoutsForms.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Range(0.01, 10000, ErrorMessage = "Price must be greater than 0")]
        public double Price { get; set; }
    }
}
