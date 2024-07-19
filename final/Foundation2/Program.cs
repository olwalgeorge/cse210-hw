
using System;
using System.Collections.Generic;
/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Program 2: Encapsulation with Online Ordering
/// 
/// This program simulates the ordering process of an online company.
/// The program demonstrates use of Encapusaltion in classes for Product, Customer, Address, and Order.
/// The responsibilities of these classes are as follows:
/// 
/// Order: Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
/// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
/// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
/// A packing label should list the name and product id of each product in the order.
/// A shipping label should list the name and address of the customer
/// Product: Contains the name, product id, price, and quantity of each product.
/// The total cost of this product is computed by multiplying the price per unit and the quantity. (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
/// Customer: The customer contains a name and an address.
/// The name is a string, but the Address is a class.
/// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
/// Address: The address contains a string for the street address, the city, state/province, and country.
/// The address should have a method that can return whether it is in the USA or not.
/// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
       Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("Moi Avenue", "Mombasa", "MSA", "KENYA");

        // Create customers
        Customer customer1 = new Customer("Ken Smith", address1);
        Customer customer2 = new Customer("George Omondi", address2);

        // Create products
        Product product1 = new Product("Phone Case", "P123", 12.00m, 2);
        Product product2 = new Product("Earphones", "E456", 18.00m, 1);
        Product product3 = new Product("USB Cable", "C789", 5.00m, 3);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}");
    }
}

