using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Abstraction Learning Activity
/// Test your Job class
/// Create 2 job instances and display companies using dot notation
/// </summary>

class Program
{
    static void Main(string[] args)
    {   
        //Create job1 instance 
        Job job1 = new Job();
        job1._company = "Simbasoft";
        job1._jobTitle = "Juniour Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2022;

        //Create job2 instance
        Job job2 = new Job();
        job2._company = "Etec Communications Ltd";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2022;
        job2._endYear = 2024;

        //Test if companies displays using dot notation
        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);
    }
}