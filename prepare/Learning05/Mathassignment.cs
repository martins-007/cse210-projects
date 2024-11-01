public class MathAssignment : Assignment
{
    // Additional properties for MathAssignment
    private string _textbookSection;
    private string _problems;

    // Constructor that calls the base constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic) // Call base constructor
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to get the homework list
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
