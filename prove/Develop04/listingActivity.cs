using System;
using System.Collections.Generic;
using System.Threading;

/// <summary>
/// listingActivity class
/// Lists positive aspects in one's life
/// ListingActivity() method initializes the name and description of the activity
/// Executive() method displays a random prompt and expects user inputs which it enumerates
/// </summary>



class ListingActivity : Activity
{
    //Fields
    private static readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    //Methods
    //Constructor method to initialize name and description
    public ListingActivity()
    {
        name = "Listing";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    //Execute method 
    protected override void Execute()
    {
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        ShowSpinner(3);

        Console.WriteLine("Start listing items:");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
    }
}

