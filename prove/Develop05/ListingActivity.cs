public class ListingActivity : Activity
{
    private static readonly string[] Prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    private static Random random = new Random();

    public ListingActivity() : base("Listing", "This activity helps you list positive aspects in your life.")
    {
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("List items based on this prompt:");
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        
        Console.WriteLine("Press Enter to start listing items...");
        Console.ReadLine();
        
        int itemCount = 0;
        int startTime = Environment.TickCount;

        while ((Environment.TickCount - startTime) / 1000 < Duration)
        {
            Console.Write("Enter an item (or leave blank to stop): ");
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
                break;
            
            itemCount++;
        }
        
        Console.WriteLine($"\nYou listed {itemCount} items!");
        DisplayEndMessage();
    }
}
