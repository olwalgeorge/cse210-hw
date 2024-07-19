/// <author>
/// <name>George Olwal</name>
/// </author>
/// <sammary>
/// Order class
/// Product: Contains the name, product id, price, and quantity of each product.
/// The total cost of this product is computed by multiplying the price per unit and the quantity. (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
/// </sammary>

public class Product
{
    // Fields
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Read only Properties (Getters)
    public string Name => _name;
    public string ProductId => _productId;
    public decimal Price => _price;
    public int Quantity => _quantity;

    public decimal TotalCost => _price * _quantity;
}