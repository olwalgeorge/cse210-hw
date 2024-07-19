using System;

/// <summary>
/// Represents an event, which is a specific occurrence with a defined start and end time,
/// a title, a description, and an address.
/// </summary>

class Event
{
    private string Title { get; set; }
    private string Description { get; set; }
    private string Date { get; set; }
    private string Time { get; set; }
    private Address Address { get; set; }

    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string StandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public virtual string ShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {Title}\nDate: {Date}";
    }
}

