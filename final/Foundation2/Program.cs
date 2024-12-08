using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address and Customer
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", "1234", 800, 1, 10); // 10% discount
        Product product2 = new Product("Mouse", "5678", 25, 2);
        Product product3 = new Product("Keyboard", "9101", 50, 1);

        // Create order and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotal()}");
        Console.WriteLine(order1.GetEstimatedDelivery());

        Console.WriteLine("\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotal()}");
        Console.WriteLine(order2.GetEstimatedDelivery());
    }
}
