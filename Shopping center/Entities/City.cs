using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_center.Entities
{
    internal class City
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<ShoppingCenter> ShoppingCenters { get; set; } = new ();
        [ForeignKey("CompanyId")]
        public int CountryId { get; set; }
        public Country? Country { get; set; } 
        public int Population { get; set; }
    }
}