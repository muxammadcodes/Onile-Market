using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.Service.DTOs
{
    public class ProductCreationDto
    {
        [Required(ErrorMessage = "Name is required"),DisplayName("Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Count is required"), DisplayName("Count")]

        public int Count { get; set; }

        [Required(ErrorMessage = "Price is required"), DisplayName("Price")]

        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
