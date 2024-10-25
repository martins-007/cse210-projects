using System;
using System.Collections.Generic;

public class Video
{
    // Properties to hold the video details
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> Comments { get; set; }

    // Constructor to initialize Video objects
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to return the number of comments on the video
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Method to return all the comments on the video
    public List<Comment> GetAllComments()
    {
        return Comments;
    }
}
