using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// Abstraction Learning Activity
/// Add a Display method to the Job class
/// </summary>


public class Job
{
    //Fields
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    //display method
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
