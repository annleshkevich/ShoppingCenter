using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_center.Entities
{
    internal class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
        [ForeignKey("ProductCategoryId")]
        public int ProductCategoryId { get; set; }
        public ProductCategory? ProductCategory { get; set; }
        [ForeignKey("ShopId")]
        public int ShopId { get; set; }
        public Shop? Shop { get; set; }
    }
}
