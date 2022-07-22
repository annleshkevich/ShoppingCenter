namespace Shopping_center.Entities
{
    internal class Cafe:Company
    {
        public List<Service> Services { get; set; } = new();
    }
}
