using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", "A123", 1200.00m, 1);
        Product product2 = new Product("Mouse", "B456", 25.00m, 2);
        Product product3 = new Product("Monitor", "C789", 300.00m, 1);
        Product product4 = new Product("Keyboard", "D012", 45.00m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"Total Cost: ${order.TotalCost():F2}");
        Console.WriteLine("-------------------------------\n");
    }
}
