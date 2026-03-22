using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Christiana Chatt", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P101", 20, 2));

        Address address2 = new Address("45 Nepa Road, Kubwa", "Abuja", "FCT", "Nigeria");
        Customer customer2 = new Customer("Chatt Kato", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P200", 500, 1));
        order2.AddProduct(new Product("Charger", "P201", 25, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}