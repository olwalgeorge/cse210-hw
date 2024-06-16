using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Week 02 Develop: Journal Program
/// The main function of the program.
/// creates or instantiates jounal object 
/// loops on menu options
/// Uses switch to decide on options as entered by the user
/// Captures user mood
/// Displays journal entries
/// loads and saves journal entries to CSV and JSON file depending the user
/// The loop continues until the user chooses to exit.
/// </summary>
/// <comments>
/// I added moods capture, save and load to CSV file and JSON file handling
/// </comments>


    class Program
    {
        static void Main(string[] args)
        {
            //Instatiate journal
            Journal journal = new Journal("George");

            //Prompt list
            string[] prompts = new string[]
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            // Menu loop
            while (true)
            {
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a CSV file");
                Console.WriteLine("4. Load the journal from a CSV file");
                Console.WriteLine("5. Save the journal to a JSON file");
                Console.WriteLine("6. Load the journal from a JSON file");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                // Menu switch
                switch (choice)
                {
                    case "1":
                        journal.WriteEntry(prompts);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        Console.Write("Enter filename without extension to save as CSV: ");
                        string saveCsvFilename = Console.ReadLine();
                        journal.SaveToCsv(saveCsvFilename);
                        break;
                    case "4":
                        Console.Write("Enter filename without extension to load from CSV: ");
                        string loadCsvFilename = Console.ReadLine();
                        journal.LoadFromCsv(loadCsvFilename);
                        break;
                    case "5":
                        Console.Write("Enter filename without extension to save as JSON: ");
                        string saveJsonFilename = Console.ReadLine();
                        journal.SaveToJson(saveJsonFilename);
                        break;
                    case "6":
                        Console.Write("Enter filename without extension to load from JSON: ");
                        string loadJsonFilename = Console.ReadLine();
                        journal.LoadFromJson(loadJsonFilename);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
