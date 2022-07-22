using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_center.Entities
{
    internal class Employee:Person
    {
        public decimal Salary { get; set; }
        public Post Post { get; set; }
        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
