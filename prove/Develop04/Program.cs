using System;
using System.Collections.Generic;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Week 04 Develop: Mindfulness Program 
/// Core requirement
/// Program class has menu of activities
/// One abstract class defines the blueprint and common features of the activities
/// Each activity(Breathing, Listing and Reflecton) has unique behaviour 
/// </summary>
/// <comments>
/// Showing Creativity and Exceeding Requirements
/// Added Meditation activity
/// Keeping log of activities in activity_log. txt
/// Ensuring the Prompts are uniquely and randomly selected
/// Saving and loading a log file.
/// </comments>



class Program
{
    // Fields 
    // dictionary to store list of done activities and store in activity log
    static Dictionary<string, int> activityLog = new Dictionary<string, int>();
    static string logFilePath = "activity_log.txt";
    
    // Load activity log
    static void LoadActivityLog()
    {
        if (File.Exists(logFilePath))
        {
            var lines = File.ReadAllLines(logFilePath);
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts.Length == 2)
                {
                    activityLog[parts[0]] = int.Parse(parts[1]);
                }
            }
        }
    }

    // Save activity log
    static void SaveActivityLog()
    {
        var lines = new List<string>();
        foreach (var entry in activityLog)
        {
            lines.Add($"{entry.Key}:{entry.Value}");
        }
        File.WriteAllLines(logFilePath, lines);
    }

    // Log activity
    static void LogActivity(string activityName)
    {
        if (activityLog.ContainsKey(activityName))
        {
            activityLog[activityName]++;
        }
        else
        {
            activityLog[activityName] = 1;
        }
        SaveActivityLog();
    }

    // Show activity log
    static void ShowActivityLog()
    {
        Console.WriteLine("Activity Log:");
        foreach (var entry in activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
    }

    // Main program
    static void Main(string[] args)
    {
        LoadActivityLog();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Meditation");
            Console.WriteLine("5. Show Activity Log");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => new MeditationActivity(),
                "5" => null,
                "6" => null,
                _ => null,
            };

            if (choice == "5")
            {
                ShowActivityLog();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                continue;
            }

            if (activity == null)
                break;

            LogActivity(activity.GetType().Name);
            activity.Start();
        }
    }
}