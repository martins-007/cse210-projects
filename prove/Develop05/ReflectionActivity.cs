public class ReflectionActivity : Activity
{
    private static readonly string[] Prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    private static readonly string[] Questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };
    
    private static Random random = new Random();

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times of strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("Reflect on the following prompt:");
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        int elapsed = 0;

        while (elapsed < Duration)
        {
            Console.WriteLine(Questions[random.Next(Questions.Length)]);
            ShowSpinner(3);
            elapsed += 3;
        }
        
        DisplayEndMessage();
    }
}
