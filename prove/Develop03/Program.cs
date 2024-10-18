using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        );

        // Main loop
        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("\nPress enter to hide words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Goodbye!");
                break;
            }

            scripture.HideRandomWords();
        }
    }
}
