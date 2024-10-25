using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store multiple video objects
        List<Video> videos = new List<Video>();

        // Create 3-4 video objects and add them to the list
        Video video1 = new Video("Exploring Space", "John Doe", 600); // Length in seconds
        Video video2 = new Video("Cooking 101", "Jane Smith", 900);
        Video video3 = new Video("Programming with C#", "Alex Johnson", 1200);

        // Add comments to each video
        video1.AddComment(new Comment("Alice", "Amazing video!"));
        video1.AddComment(new Comment("Bob", "Very informative!"));
        video1.AddComment(new Comment("Charlie", "Loved the visuals!"));

        video2.AddComment(new Comment("David", "Great recipe!"));
        video2.AddComment(new Comment("Eve", "I will definitely try this!"));
        video2.AddComment(new Comment("Frank", "Nice and easy to follow."));

        video3.AddComment(new Comment("Grace", "This really helped me understand C#."));
        video3.AddComment(new Comment("Hank", "Clear explanation, thanks!"));
        video3.AddComment(new Comment("Ivy", "Good examples and explanation."));

        // Add the video objects to the videos list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos and display their information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // Display each comment for the current video
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetAllComments())
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
