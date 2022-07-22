using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Shopping_center;
using Shopping_center.Entities;

using (ShoppingCenterContext db = new ShoppingCenterContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    Country belarus = new() { Name = "Belarus" };
    db.Countries.Add(belarus);
    City pinsk = new() { Name = "Pinsk", Country = belarus };
    db.Cities.Add(pinsk);
    ShoppingCenter scarletSails = new() { Name = "Scarlet Sails", City = pinsk };
    db.ShoppingCenters.Add(scarletSails);
    Cafe comeIn = new() { Name = "Come in", ShoppingCenter = scarletSails };
    db.Cafes.Add(comeIn);
    Shop babulon = new() { Name = "Babylon", ShoppingCenter = scarletSails };
    db.Shops.Add(babulon);
    Client bob = new() { Name = "Bob" };
    Client alice = new() { Name = "Alice" };
    db.Clients.AddRange(bob, alice);
    Post director = new() { Name = "Director" };
    db.Posts.Add(director);
    Post salesman = new() { Name = "Salesman" };
    db.Posts.Add(director);
    Employee tom = new() { Name = "Tom", Post = director, Company = babulon };
    db.Employees.Add(tom);
    Employee kate = new() { Name = "Kate", Post = salesman, Company = comeIn };
    db.Employees.Add(kate);
    Employee ron = new() { Name = "Ron", Post = director, Company = comeIn };
    db.Employees.Add(ron);
    Manufacturer jon = new() { Name = "Jon" };
    db.Manufacturers.Add(jon);
    ProductCategory electronics = new() { Name = "Electronics" };
    db.ProductCategories.Add(electronics);
    Product computer = new() { Name = "Computer", Price = 223.00, ProductCategory = electronics, Shop = babulon };
    //Product phone = new() { Name = "Phone", Price = 145.00, ProductCategory = electronics, Shop = babulon };
    db.Products.Add(computer);
    Service feed = new() { Name = "Feed", Cafe = comeIn, Price = 14 };
    db.Services.Add(feed);
    Supplier roman = new() { Name = "Roman" };
    db.Suppliers.Add(roman);

    comeIn.Services.Add(feed);
    bob.Shops.Add(babulon);
    alice.Cafes.Add(comeIn);
    jon.Products.Add(computer);
    jon.Suppliers.Add(roman);
    babulon.Products.Add(computer);
    roman.Companies.Add(babulon);
    db.SaveChanges();
    Console.WriteLine("Saved objects");

    Console.WriteLine("\nList of employees:");
    var employees = db.Employees.ToList();
    foreach (var employee in employees) Console.WriteLine(employee.Name);
    var shop = db.Shops.FirstOrDefault();
    if (shop != null) db.Shops.Remove(shop);
    db.SaveChanges();
    Console.WriteLine("\nList of employees after deleting a company:");
    employees = db.Employees.ToList();
    foreach (var employee in employees) Console.WriteLine(employee.Name);

}
using (ShoppingCenterContext db = new ShoppingCenterContext())
{
    Console.WriteLine("\nEmployees and the companies they work for:");
    var employees = db.Employees
        .Include(u => u.Company)
        .ToList();
    foreach (var employee in employees)
        Console.WriteLine($"{employee.Name} - {employee.Company.Name}");

    SqlParameter param = new("@name", "ComeIn");
    var people = db.People.FromSqlRaw("GetPeopleByCompany @name", param).ToList();
    foreach (var person in people)
        Console.WriteLine($"{person.Id} - {person.Name}");
}