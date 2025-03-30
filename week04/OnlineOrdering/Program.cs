using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4321 S 700 E", "Las Vegas", "NV", "USA");
        Customer customer1 = new Customer("John Taylor", address1);
        Product book = new Product("Elantris", 1234, 22.33, 5);
        Product sandwich = new Product("Reuben", 567, 10.50, 1);
        Product shoe = new Product("New Balance", 888, 30.30, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(book);
        order1.AddProduct(sandwich);
        order1.AddProduct(shoe);
        Console.WriteLine("Order 1:\n");
        Console.WriteLine($"Packing Label: \n{order1.PackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{order1.ShippingLabel()}");
        Console.WriteLine($"\nTotal price = ${order1.TotalPrice()}\n");

        Address address2 = new Address("5631 S Frozen Lake Ln", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Mario Plummer", address2);
        Product noodle = new Product("Spaghetti", 34, 2.15, 8);
        Product hat = new Product("Cowboy hat", 586, 35.25, 1);
        Product spice = new Product("Vietnamese cinnamon", 1000, 7.50, 4);

        Order order2 = new Order(customer2);
        order2.AddProduct(noodle);
        order2.AddProduct(hat);
        order2.AddProduct(spice);
        Console.WriteLine("Order 2:\n");
        Console.WriteLine($"Packing Label: \n{order2.PackingLabel()}");
        Console.WriteLine($"Shipping Label: \n{order2.ShippingLabel()}");
        Console.WriteLine($"\nTotal price = ${order2.TotalPrice()}\n");
    }
}