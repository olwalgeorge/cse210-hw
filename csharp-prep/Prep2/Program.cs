using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Prep 2  Core 2
/// This program will allow the user to input their grade percentage and output
/// their letter grade and whether pass or fail
/// </summary>

class Program
{

    static void Main(string[] args)
    {
        // Get student's percentage
        Console.Write("What is your grade percentage? ");
        int studentMarks = int.Parse(Console.ReadLine()); 

        // Get the student grade and print accordingly       
        if(studentMarks >= 90)
            {
                Console.WriteLine("A");
            }
        else if(studentMarks >= 80)
            {
                Console.WriteLine("B");
            }
        else if(studentMarks >= 70)
            {
                Console.WriteLine("C");
            }
        else if(studentMarks >= 60)
            {
                Console.WriteLine("D");
            }
        else
            {
                Console.WriteLine("F");
            }

        // Determine if the student passed or failed
        if(studentMarks >= 70)
            { 
                Console.WriteLine("Congratulations! You passed");
            }
        else
            {
                Console.WriteLine("Sorry, you failed. Put more efforts in your next trial");
            }
    }

}            