using System;
using System.Collections.Generic;
using System.Linq;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Week 03 Develop: Scripture Memorizer
/// program that displays the full scripture and then hides a few words at a time until the complete scripture is hidden.
/// Handles the main loop, displaying the scripture, and prompting the user for input.
/// Uses the Scripture class to hide words and check if all words are hidden.
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        var reference = new ScriptureReference("Proverbs", 3, 5, 6);
        var text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        var scripture = new Scripture(reference, text);
        
        while (true)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nAll words are hidden. Program will exit.");
                break;
            }
        }
    }
}