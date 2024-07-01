using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Contains the scripture reference and a list of words.
/// Provides methods to display the scripture, hide random words, and check if all words are hidden.
/// </summary>
/// <param name="book">The book of the scripture.
/// </param>
/// <param name="chapter">The chapter of the scripture.
/// </param>
/// <param name="startVerse">The start verse of the scripture.
/// </param>
/// <param name="endVerse">The end verse of the scripture.
/// </param>


class Scripture
{
    public ScriptureReference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split().Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words));
    }

    public void HideRandomWords(int count)
    {
        var random = new Random();
        var wordsToHide = Words.Where(word => !word.Hidden).OrderBy(_ => random.Next()).Take(count);
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public void ShowHint()
    {
        var random = new Random();
        var hiddenWords = Words.Where(word => word.Hidden).OrderBy(_ => random.Next()).FirstOrDefault();
        if (hiddenWords != null)
        {
            hiddenWords.Show();
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.Hidden);
    }
}
