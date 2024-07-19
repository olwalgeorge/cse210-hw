using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Order class
/// Represents an order, which contains a list of products and a customer. It can calculate the total cost of the order, and return strings for the packing label and shipping label.
/// </summary>
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.TotalCost;
        }
        totalCost += _customer.LivesInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.Name} ({product.ProductId})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.Address}";
    }
}