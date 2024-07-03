using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// WritingAssignment sub class
/// </summary>

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation() 
    {
        return $"{_title} by {_studentName}";
    }
}
   