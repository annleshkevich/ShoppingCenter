using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_center.Entities
{
    internal class Service
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }

        [ForeignKey("CafeId")]
        public int CafeId { get; set; }
        public Cafe Cafe { get; set; }
    }
}
