using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1 (USA Customer)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P200", 20, 2));

        // ORDER 2 (International Customer)
        Address address2 = new Address("45 Lagos Road", "Lagos", "LA", "Nigeria");
        Customer customer2 = new Customer("Emeka Obi", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P300", 500, 1));
        order2.AddProduct(new Product("Headphones", "P400", 50, 2));

        // DISPLAY RESULTS
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}