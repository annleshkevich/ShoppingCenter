namespace Shopping_center.Entities
{
    internal class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new ();
    }
}
