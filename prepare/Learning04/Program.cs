using System;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Week 04 - Inheritance Learning Activity
/// Create the base class "Assignment"
/// Create the MathAssignment class (subclass)
/// Create the WritingAssignment class
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the MathAssignment class
        Assignment assignment1 = new Assignment("George Olwal", "Multiplication");

        Console.WriteLine(assignment1.GetSummary());      
       
        // Create an instance of the MathAssignment class
        MathAssignment assignment2 = new MathAssignment("Ben Ombori", "Trigonometry", "Section 7.3", "Problems 8-19");

        Console.WriteLine(assignment2.GetSummary());

        Console.WriteLine(assignment2.GetHomeworkList());

        // Create an instance of the WritingAssignment class
        WritingAssignment assignment3 = new WritingAssignment("Robert Osir", "European History", "The Causes of World War II");

        Console.WriteLine(assignment3.GetSummary());

        Console.WriteLine(assignment3.GetWritingInformation());
    }
}