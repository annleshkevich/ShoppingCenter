namespace Shopping_center.Entities
{
    internal class Shop:Company
    {
        public List<Product> Products { get; set; } = new ();
    }
}
