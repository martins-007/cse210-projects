public class Program
{
    public static void Main(string[] args)
    {
        // Test the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Martins George", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
