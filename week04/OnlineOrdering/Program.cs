using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // create 2 orders with at least 3 items each
        
        Address address1 = new Address("2243 N Mountain Rd", "North Ogden", "Canada");
        Customer customer1 = new Customer("Zeb Billings", address1);
        Product productA = new Product("lettuce", "produce1377", 1.55, 6);
        Product productB = new Product("tomato", "produce7084", 2.43, 7);
        Product productC = new Product("cucumber", "produce6962", 3.87, 3);
        
        Order order1 = new Order(customer1, address1);
        order1.AddProduct(productA);
        order1.AddProduct(productB);
        order1.AddProduct(productC);
        
        Console.WriteLine(order1.GetShippingLabel());
       
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Shipping cost: ${order1.GetShippingCost()}");
        Console.WriteLine($"Product total: ${order1.GetTotalProductCost()}");
        Console.WriteLine($"Order total:   ${order1.GetTotalOrderCost()}");
        
            
        Address address2 = new Address("1035 Hemlock Circle", "Saint George", "USA");
        Customer customer2 = new Customer("Kasen Billings", address2);
        Product productD = new Product("carrot", "produce1398", 4.55, 3);
        Product productE = new Product("potato", "produce7067", 2.13, 13);
        Product productF = new Product("squash", "produce6322", 3.27, 8);
        
        Order order2 = new Order(customer2, address2);
        order2.AddProduct(productD);
        order2.AddProduct(productE);
        order2.AddProduct(productF);
        

        Console.WriteLine(order2.GetShippingLabel());
       
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Shipping cost: ${order2.GetShippingCost()}");
        Console.WriteLine($"Product total: ${order2.GetTotalProductCost()}");
        Console.WriteLine($"Order total:   ${order2.GetTotalOrderCost()}");
    }
}