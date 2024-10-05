using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        // Outer loop to allow the user to play again
        while (playAgain)
        {
            // Generate a random number between 1 and 100
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;  // To keep track of the number of guesses
            int guess = -1;  // Initialize guess to a value that is not equal to magicNumber

            Console.WriteLine("I have chosen a magic number between 1 and 100.");

            // Inner loop to keep asking the user for a guess until they get it right
            while (guess != magicNumber)
            {
                // Ask the user for their guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Check if the guess is higher, lower, or correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Inform the user of how many guesses they made
            Console.WriteLine($"You guessed the magic number in {guessCount} guesses!");

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            // Determine if the user wants to play another round
            if (response != "yes")
            {
                playAgain = false;
                Console.WriteLine("Thanks for playing! Goodbye.");
            }
        }
    }
}
