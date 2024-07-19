using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <sammary>
/// customer class
/// Contains the customer's name and address.
/// A customer's name is a string, and their address is of type Address.
/// </summary>

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string Name => _name;
    public Address Address => _address;

    public bool LivesInUSA() => _address.IsInUSA();
}
