using System;
/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Prep 1
/// The main entry point of the program. Prompts the user for their first name and last name,
/// capitalizes the first letter of each name, and displays the user's full name.
/// </summary>
class Program
{
       
    static void Main(string[] args)
    {
        // Prompt the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        // Capitalize the first letter of the first name
        string capitalizedFirstName = char.ToUpper(firstName[0]) + firstName.Substring(1);

        // Prompt the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        // Capitalize the first letter of the last name
        string capitalizedLastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
        
        // Display the user's full name
        Console.Write($"Your name is {capitalizedLastName}, {capitalizedFirstName} {capitalizedLastName}.");
    }

}