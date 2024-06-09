using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Abstraction Learning Activity
/// Create a Job class
/// Add a Display method to the Job class
/// Create 2 job instances and display jobs details using method calls
/// Create resume class
/// Test Resume class
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
        job2._company = "Etec Communications";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2022;
        job2._endYear = 2024;

        //Display jobs details using method calls
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        //Create resume instance
        Resume myResume = new Resume();
        myResume._name = "George Olwal";
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);
        
        //Display resume job1 title using dot notation
        Console.WriteLine(myResume._name);
        Console.WriteLine(myResume._jobList[0]._jobTitle);     
        

    }
}