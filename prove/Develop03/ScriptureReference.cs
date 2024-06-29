using System;
using System.Collections.Generic;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Handles the scripture reference, accommodating both single verses and verse ranges.
/// Uses properties with private setters to encapsulate the data.
/// Provides a ToString method to format the reference properly.
/// </summary>
/// <param name="book">The book of the scripture.
/// </param>
/// <param name="chapter">The chapter of the scripture.
/// </param>
/// <param name="startVerse">The start verse of the scripture.
/// </param>
/// <param name="endVerse">The end verse of the scripture.
/// </param>
class ScriptureReference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int? EndVerse { get; }

    public ScriptureReference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" : $"{Book} {Chapter}:{StartVerse}";
    }
}
