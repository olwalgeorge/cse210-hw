using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Prep 3 Core 1
/// This is a number guessing game where user is asked to guess a number and the 
/// program will tell them if their guess is higher or lower than the magic number.
/// </summary>
class Program
{
    static void Main(string[] args)
    {   
        // Ask the user for magic number and store in a viariable
        Console.Write("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        // Ask user for a guess and stor in a viariable
        Console.Write("What i your guess? ");
        int guess = int.Parse(Console.ReadLine());

        // Compare the guess to the magic number and print higher or lower 
         if(guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }  
        else if(guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }  
    }
}