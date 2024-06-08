using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Prep 3 Core 2
/// This is a number guessing game where user is asked to guess a number and the 
/// program will continously tell them if their guess is higher or lower than the magic number untill the guess is right
/// </summary>
class Program
{
    static void Main(string[] args)
    {   
        // Ask the user for magic number and store in a viariable
        Console.Write("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        // Initialize guess
        int guess = 0;

        // Continously ask user for a guess and compare with the magic number untill guess is right
        while(guess != magicNumber)        
        {
            
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if(guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }  
            else if(guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }  
        }

        Console.WriteLine("You guessed it!");
    }
}