namespace Shopping_center.Entities
{
    internal class Supplier 
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public List<Company> Companies { get; set; } = new ();
        public List<Manufacturer> Manufacturers { get; set; } = new ();
    }
}
