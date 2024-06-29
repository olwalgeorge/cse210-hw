using System;
using System.Collections.Generic;
using System.IO;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Week 03 Develop: Scripture Memorizer
/// program that displays the full scripture and then hides a few words at a time until the complete scripture is hidden.
/// Handles the main loop, displaying the scripture, and prompting the user for input.
/// Uses the Scripture class to hide words and check if all words are hidden.
/// </summary>
/// <commentary>
/// Additional Features:
/// Library of Scriptures: The LoadScriptures method reads scriptures from a file named scriptures.txt, where each line contains a scripture reference and text separated by a | character.
/// Random Scripture Selection: The program randomly selects a scripture from the loaded library to present to the user.
/// Hints: The ShowHint method reveals one hidden word at random to aid the user.
/// File Loading: Scriptures are loaded from a text file, making it easy to manage and update the library.
/// </commentary>

class Program
{
    static void Main(string[] args)
    {
        var scriptures = LoadScriptures("scriptures.txt");
        var random = new Random();
        var scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words, type 'hint' for a hint, or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input.ToLower() == "hint")
            {
                scripture.ShowHint();
            }
            else
            {
                scripture.HideRandomWords(3);
            }

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nCongratulations! You've memorized the scripture.");
                break;
            }
        }
    }

    static List<Scripture> LoadScriptures(string filePath)
    {
        var scriptures = new List<Scripture>();
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            var referenceParts = parts[0].Split(' ');
            var book = referenceParts[0];
            var chapterVerse = referenceParts[1].Split(':');
            var chapter = int.Parse(chapterVerse[0]);
            var verses = chapterVerse[1].Split('-');
            var startVerse = int.Parse(verses[0]);
            var endVerse = verses.Length > 1 ? int.Parse(verses[1]) : (int?)null;
            var reference = new ScriptureReference(book, chapter, startVerse, endVerse);
            var text = parts[1];
            scriptures.Add(new Scripture(reference, text));
        }
        return scriptures;
    }
}