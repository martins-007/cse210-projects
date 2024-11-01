public class Assignment
{
    // Private member variables
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get the summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Optional getter method to access student name in derived classes
    public string GetStudentName()
    {
        return _studentName;
    }
}
