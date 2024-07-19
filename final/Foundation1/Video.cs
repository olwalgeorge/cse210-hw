using System;

/// <summary>
/// Represents a YouTube video.
/// </summary>
public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    /// <summary>
    /// Adds a comment to the video.
    /// </summary>
    /// <param name="comment">The comment to add.</param>
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    /// <summary>
    /// Returns the number of comments on the video.
    /// </summary>
    /// <returns>The number of comments.</returns>
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    /// <summary>
    /// Returns the list of comments on the video.
    /// </summary>
    /// <returns>The list of comments.</returns>
    public List<Comment> GetComments()
    {
        return Comments;
    }
}
