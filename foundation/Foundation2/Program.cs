using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak St", "Vancouver", "BC", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", "A123", 999.99m, 1);
        Product product2 = new Product("Mouse", "B456", 19.99m, 2);
        Product product3 = new Product("Keyboard", "C789", 49.99m, 1);

        Product product4 = new Product("Phone", "D012", 499.99m, 1);
        Product product5 = new Product("Charger", "E345", 24.99m, 2);

        // Create orders and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}
