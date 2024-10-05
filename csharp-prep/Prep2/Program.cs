using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        // Declare a variable to hold the letter grade
        string letter = "";

        // Determine the letter grade using if-elif-else
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the "+" or "-" for A, B, C, D (F doesn't have one)
        if (letter != "F")
        {
            int lastDigit = percentage % 10;

            if (lastDigit >= 7)
            {
                letter += "+";
            }
            else if (lastDigit < 3)
            {
                letter += "-";
            }
        }

        // Display the letter grade
        Console.WriteLine($"Your grade is: {letter}");

        // Check if the user passed or not
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You'll get it next time.");
        }
    }
}
