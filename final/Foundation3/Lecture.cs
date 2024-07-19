class Lecture : Event
{
    private string Speaker { get; set; }
    private int Capacity { get; set; }

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}

