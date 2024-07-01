using System;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Week 04 - Inheritance Learning Activity
/// Create the base class "Assignment"
/// Create the MathAssignment class (subclass)
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        
        MathAssignment assignment2 = new MathAssignment("George Olwal", "Multiplication", "Section 7.3", "Problems 8-19");

        Console.WriteLine(assignment2.GetSummary());

        Console.WriteLine(assignment2.GetHomeworkList());
    }
}