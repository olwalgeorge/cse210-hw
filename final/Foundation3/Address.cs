class Address
{
    private string Street { get; set; }
    private string City { get; set; }
    private string State { get; set; }
    private string ZipCode { get; set; }

    public Address(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}