using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("George Olwal", "Trigonometry");

        Console.WriteLine(assignment1.GetSummary());
    }
}