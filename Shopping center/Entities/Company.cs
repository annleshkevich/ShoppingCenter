using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_center.Entities
{
    internal class Company
    {
        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public List<Employee>? Employees { get; set; } = new ();
        public List<Client>? Clients { get; set; } = new ();
        [ForeignKey("ShoppingCenterId")]
        public int? ShoppingCenterId { get; set; }
        public ShoppingCenter ShoppingCenter { get; set; }
        public List<Supplier> Suppliers { get; set; } = new();
    }
}
