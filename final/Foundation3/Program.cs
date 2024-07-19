using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1600 Pennsylvania Avenue NW", "Washington", "DC", "20500");
        Address address2 = new Address("1000 Rockefeller Plaza", "New York", "NY", "10111");
        Address address3 = new Address("100 1st Avenue SW", "Washington", "DC", "20220");

        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in tech.", "2024-08-01", "10:00 AM", address1, "John Doe", 100);
        Reception reception = new Reception("Networking Event", "An event to network with professionals.", "2024-08-02", "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic", "A fun outdoor picnic.", "2024-08-03", "12:00 PM", address3, "Sunny");

        Console.WriteLine("Lecture Standard Details:\n" + lecture.StandardDetails());
        Console.WriteLine("\nLecture Full Details:\n" + lecture.FullDetails());
        Console.WriteLine("\nLecture Short Description:\n" + lecture.ShortDescription());

        Console.WriteLine("\nReception Standard Details:\n" + reception.StandardDetails());
        Console.WriteLine("\nReception Full Details:\n" + reception.FullDetails());
        Console.WriteLine("\nReception Short Description:\n" + reception.ShortDescription());

        Console.WriteLine("\nOutdoor Gathering Standard Details:\n" + outdoorGathering.StandardDetails());
        Console.WriteLine("\nOutdoor Gathering Full Details:\n" + outdoorGathering.FullDetails());
        Console.WriteLine("\nOutdoor Gathering Short Description:\n" + outdoorGathering.ShortDescription());
    }
}