using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Prep 3 stretch challenge
/// This is a number guessing game where user is asked to guess a number and the 
/// program will tell them if their guess is higher or lower than the magic number.
/// The program calculates number of attempts and displays it when the guess is right.
/// User is then asked to continue the game, where by programs starts through loop ccall of Main(args)
/// Otherwise game ends
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        
        int guess = 0;
        int attempts = 0;
        while(guess != magicNumber)
            {
                attempts++;
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());                    
                }
                if(guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }  
                else if(guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }  
                
            }
        Console.WriteLine($"You guessed it! It took you {attempts} guesses");
        Console.Write("Do you want to continue with the game(y=Yes)? ");
        string answer = Console.ReadLine().ToLower();
        if(answer == "y")
            {   
                Main(args);

            }  
        else
            {
                Console.WriteLine("Goodbye");
            }
    }

}
