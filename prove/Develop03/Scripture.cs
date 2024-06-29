using System;

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
    private ScriptureReference Reference { get; set; }
    private List<Word> Words { get; set; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words));
    }

    public void HideRandomWords(int count)
    {
        var random = new Random();
        var wordsToHide = Words.Where(word => !word.Hidden).OrderBy(x => random.Next()).Take(count).ToList();
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.Hidden);
    }
}
