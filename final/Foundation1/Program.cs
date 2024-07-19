using System;
using System.Collections.Generic;


/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// W06 Prove: Final Project Program #1—Abstraction
/// This program demonstrates how Abstraction is used to keep track of YouTube videos and comments left on them.
/// It defines two classes, Video and Comment, and uses them to create a list of videos, each with
/// its own list of comments. The program then displays the details of each video, including the
/// number of comments and the text of each comment.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Widlife Migration", "George Olwal", 300);
        Video video2 = new Video("Lift", "Kevin Hurt", 600);
        Video video3 = new Video("One Love", "Bob Marley", 900);

        // Add comments to videos
        video1.AddComment(new Comment("Steve Ogendo", "Great video!"));
        video1.AddComment(new Comment("Beth Mugo", "Very informative."));
        video1.AddComment(new Comment("Calvin Osogo", "Loved it!"));

        video2.AddComment(new Comment("Stan Omondi", "Nice explanation."));
        video2.AddComment(new Comment("Raila Odinga", "Thanks for sharing."));
        video2.AddComment(new Comment("Ken Otieno", "Awesome content."));

        video3.AddComment(new Comment("James Maina", "Very helpful."));
        video3.AddComment(new Comment("Henry Okello", "Good job."));
        video3.AddComment(new Comment("Tom Jerry", "Keep it up!"));

        // Add videos to list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
