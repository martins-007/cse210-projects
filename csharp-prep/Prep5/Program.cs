using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the DisplayWelcome function
        DisplayWelcome();

        // Call the PromptUserName function and store the result
        string userName = PromptUserName();

        // Call the PromptUserNumber function and store the result
        int userNumber = PromptUserNumber();

        // Call the SquareNumber function with userNumber as the parameter and store the result
        int squaredNumber = SquareNumber(userNumber);

        // Call the DisplayResult function to display the name and squared number
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine()); // Convert the string input to an integer
    }

    // Function to square the user's favorite number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
