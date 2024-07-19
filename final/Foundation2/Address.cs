using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <sammary>
/// Address Class
/// Represents a physical address with fields for street, city, state, and country.
/// </summary>

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string StreetAddress => _streetAddress;
    public string City => _city;
    public string State => _state;
    public string Country => _country;

    public bool IsInUSA() => _country.ToLower() == "usa";

    public override string ToString()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}