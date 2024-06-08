using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Prep 5
/// This program demonstrate creation and calling of static functions
/// The program uses satic void function to display welcome message
/// The user is asked for usename by a static string function which returns capitalized name as string
/// The user is asked for their favorite number by a static int function which returns the sqaure of the numer as an int
/// The capitalized username and square are then displayed
/// </summary>
class Program

{
        
        static void DisplayWelcome (string welcomeMessage)

        /// <summary>
        /// Displays a welcome message to the user.
        /// </summary>
        /// <param name="welcomeMessage">The message to display to the user.</param>

        {
            Console.WriteLine(welcomeMessage);
        }

        static string PromptUserName (string promptMessage)

        /// <summary>
        /// Prompts the user for their name and returns the capitalized version of it.
        /// </summary>
        /// <param name="promptMessage">The message to display to the user.</param>
        /// <returns>The capitalized version of the user's name.</returns>

        {
            Console.Write(promptMessage);
            string userName = Console.ReadLine();
            return $"{char.ToUpper(userName[0])}{userName.Substring(1)}";
        }

        static int PromptUserNumber(string promptMessage)
        
        /// <summary>
        /// Prompts the user for their favorite number and returns the square of that number.
        /// </summary>
        /// <param name="promptMessage">The message to display to the user.</param>
        /// <returns>The square of the user's favorite number.</returns>

        {
            Console.Write(promptMessage);
            int userNumber = int.Parse(Console.ReadLine());                        
            return userNumber*userNumber;
        }

    static void Main(string[] args)
    {   
        /// <summary>
        /// The main function of the program.
        /// Displays a welcome message, prompts the user for their name and favorite number,
        /// and displays the capitalized username and the square of the user's favorite number.
        /// </summary>
        /// <param name="args">The command-line arguments passed to the program.</param>

        DisplayWelcome("Welcome to the Program!");
        string capitalizedUserName = PromptUserName("Please enter your name: ");
        int square = PromptUserNumber("Please enter your favorite number: ");
        
        //Display username and the square of user favourite number
        // can use DisplayWelcome($"Brother {userName}, the square of your number is {square}")
        Console.WriteLine($"Brother {capitalizedUserName}, the square of your number is {square}"); 
       
    }
}