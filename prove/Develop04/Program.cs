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



class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null,
            };

            if (activity == null)
                break;

            activity.Start();
        }
    }
}
