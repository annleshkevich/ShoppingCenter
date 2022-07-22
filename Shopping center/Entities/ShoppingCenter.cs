using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_center.Entities
{
    internal class ShoppingCenter
    {
        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public List<Shop>? Shops { get; set; } = new();
        public List<Cafe> Cafes { get; set; } = new();
        [ForeignKey("CityId")]
        public int? CityId { get; set; }
        public City? City { get; set; }
    }
}
