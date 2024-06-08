using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Prep 2  Core 1
/// This program will allow the user to input their grade percentage and output
/// their letter grade. 
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
    }

}            