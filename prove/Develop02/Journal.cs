
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// generate random prompt from propmt list through calling Random class
/// Captures writer mood
/// handles entries display, loading and saving
/// </summary>
/// <comments>
/// I added moods and tags capture, save and load to CSV file and JSON file handling
/// </comments>



class Journal
    {
        //List of entries
        private List<Entry> entries;

        private string _author;

        public Journal(string writer)
        {
            entries = new List<Entry>();
            _author = writer;
        }

        public void WriteEntry(string[] prompts)
        {
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            Console.Write("How do you feel today? ");
            string mood = Console.ReadLine();
            Console.Write("Enter tags (comma-separated): ");
            string tags = Console.ReadLine();
            entries.Add(new Entry(prompt, response, mood, tags));
        }

        public void DisplayEntries()
        {
            Console.WriteLine(_author);
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        //CSV file save handling
        public void SaveToCsv(string filename)
        {
            using (StreamWriter writer = new StreamWriter($"{filename}.csv"))
            {
                writer.WriteLine("Date,Prompt,Response,Mood,Tags");
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"\"{entry.Date}\",\"{entry.Prompt}\",\"{entry.Response}\",\"{entry.Mood}\",\"{entry.Tags}\"");
                }
            }
        }

        //CSV file load handling
        public void LoadFromCsv(string filename)
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader($"{filename}.csv"))
            {
                string line;
                reader.ReadLine(); // Skip header
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new[] { "\",\"" }, StringSplitOptions.None);
                    if (parts.Length == 5)
                    {
                        entries.Add(new Entry(parts[1].Trim('"'), parts[2].Trim('"'), parts[3].Trim('"'), parts[4].Trim('"')) { Date = parts[0].Trim('"') });
                    }
                }
            }
        }

        //JSON file save handling
        public void SaveToJson(string filename)
        {
            string jsonString = JsonSerializer.Serialize(entries);
            File.WriteAllText($"{filename}.json", jsonString);
        }

        //JSON file load handling
        public void LoadFromJson(string filename)
        {
            entries.Clear();
            string jsonString = File.ReadAllText($"{filename}.json");
            entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        }
    }
