using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [DisplayName("List Price")]
        [Range(1, 1000)]
        public int ListPrice { get; set; }

        [DisplayName("Price for 1-50")]
        [Range(1, 1000)]
        public int Price { get; set; }

        [DisplayName("Price for 50+")]
        [Range(1, 1000)]
        public int Price50 { get; set; }

        [DisplayName("Price for 100+")]
        [Range(1, 1000)]
        public int Price100 { get; set; }
    }
}
