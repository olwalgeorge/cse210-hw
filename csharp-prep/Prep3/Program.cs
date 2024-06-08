using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Prep 3 Core 3
/// Generate random number between 1 to 100 and ask user to guess it
/// program will continously tell if the guess is higher or lower than the magic number untill the guess is right
/// </summary>
class Program
{
    static void Main(string[] args)
    {   
        // Generate random number between 1 and 100 as the magic number
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

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