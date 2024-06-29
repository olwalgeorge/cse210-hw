using System;

/// <author>
/// George Olwal
/// </author>
/// <summary>
/// Initializes a new instance of the <see cref="Word"/> class with the specified text. 
/// </summary>
/// <param name="text">The text of the word.
/// </param>


class Word
{
    public string Text { get; private set; }
    public bool Hidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public override string ToString()
    {
        return Hidden ? "____" : Text;
    }
}