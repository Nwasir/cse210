using System;

class Program
{
    static void Main()
    {
        // Create two orders
        Order order1 = new Order(
            new Customer("John Smith", new Address("123 Main St", "Anytown", "CA", "USA")),
            new[] {
                new Product("Widget", "W1", 9.99f, 3),
                new Product("Gizmo", "G2", 4.99f, 2)
            });
        Order order2 = new Order(
            new Customer("Jane Doe", new Address("456 Elm St", "Somecity", "BC", "Canada")),
            new[] {
                new Product("Thingamabob", "T3", 19.99f, 1),
                new Product("Doodad", "D4", 14.99f, 2),
                new Product("Whatsit", "W5", 7.99f, 4)
            });

        Order order3 = new Order(
        new Customer("Nwasir Jim", new Address("192 jubilee road", "Aba", "Abia", "Nigeria")),
        new[] {
                new Product("Industral machine", "M3", 40.09f, 2),
                new Product("shoes", "S4", 22.99f, 1),
                new Product("Nylon thread", "NT2", 17.99f, 23)
        });

        // Display order information
        Console.WriteLine("\nOrder 1");
        Console.WriteLine("-------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total price: ${order1.GetTotalPrice()}");
       
        Console.WriteLine("\nOrder 2");
        Console.WriteLine("-------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total price: ${order2.GetTotalPrice()}");

        Console.WriteLine("\nOrder 3");
        Console.WriteLine("-------");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total price: ${order3.GetTotalPrice()}\n");
    }
}
