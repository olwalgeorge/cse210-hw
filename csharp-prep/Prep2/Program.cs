using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Prep 2  Core 3
/// This program will allow the user to input their grade percentage and store in 'letter' variable
/// Use $ to output pass or fail message and grade
/// </summary>

class Program
{

    static void Main(string[] args)
    {
        // Get student's percentage
        Console.Write("What is your grade percentage? ");
        int studentMarks = int.Parse(Console.ReadLine()); 

        // Get the student grade and print accordingly       
        string letter;
        if(studentMarks >= 90)
            {
                letter = "A";
            }
        else if(studentMarks >= 80)
            {
                letter = "B";
            }
        else if(studentMarks >= 70)
            {
                letter = "C";
            }
        else if(studentMarks >= 60)
            {
                letter = "D";
            }
        else
            {
                letter = "F";
            }

        // Determine if the student passed or failed
        if(studentMarks >= 70)
            { 
                Console.WriteLine($"Congratulations! You passed with a grade of '{letter}'");
            }
        else
            {
                Console.WriteLine($"Sorry, you failed with a grade of '{letter}'. Put more efforts in your next trial");
            }
    }

}            