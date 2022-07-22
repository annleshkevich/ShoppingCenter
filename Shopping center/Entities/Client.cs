namespace Shopping_center.Entities
{
    internal class Client:Person
    {
        public List<Shop> Shops { get; set; } = new ();
        public List<Cafe> Cafes { get; set; } = new (); 
    }
}
