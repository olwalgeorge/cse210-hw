using System;

/// <summary>
/// Represents a wedding reception event
/// </summary>

class Reception : Event
{
    private string RSVPEmail { get; set; }

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RSVPEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nRSVP Email: {RSVPEmail}";
    }
}