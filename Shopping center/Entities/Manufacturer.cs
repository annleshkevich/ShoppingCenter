namespace Shopping_center.Entities
{
    internal class Manufacturer : Person
    {
        public List<Product> Products { get; set; } = new();
        public List<Supplier> Suppliers { get; set; } = new();
    }
}
