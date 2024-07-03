using System;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// MathAssignment subclass
/// </summary>


public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;


    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textbookSection;
        _problems = problems;
    }


    public string GetHomeworkList()
    {
        return $"{_textBookSection} {_problems}";
    }
}