public class WritingAssignment : Assignment
{
    // Additional property for WritingAssignment
    private string _title;

    // Constructor that calls the base constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Call base constructor
    {
        _title = title;
    }

    // Method to get writing information
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
