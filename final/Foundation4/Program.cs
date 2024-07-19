using System;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Program 4: Polymorphism with Exercise Tracking
/// Write a program that has a base Activity class and then has a derived class for each of the three activities. The base class should contain any attributes that are shared among all activities. Then, each derived class can define any additional attributes.
/// In addition, the base class contain virtual methods for getting the distance, speed, pace. These methods are overridden in the derived classes.
/// Finally, GetSummary method to produce a string with all the summary information. The summary method can make use of the other methods to produce its result. This method is available for all classes, so it is defined in the base class (you can override it in the derived classes if needed, but it may not need to be...).
/// the program uses inheritance to avoid duplicating shared attributes and methods, use method overriding for the calculation methods, and follow the principles of encapsulation, making sure each member variable is private.
/// </summary>

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 3), 30, 20),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
