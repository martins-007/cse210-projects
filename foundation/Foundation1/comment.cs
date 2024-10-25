public class Comment
{
    // Properties to hold the commenter's name and the comment text
    public string CommenterName { get; set; }
    public string Text { get; set; }

    // Constructor to initialize Comment objects
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}
