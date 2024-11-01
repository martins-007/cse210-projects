using System;
using System.Threading;

public class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void SetDuration()
    {
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"\nStarting {Name} Activity");
        Console.WriteLine(Description);
        SetDuration();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"You spent {Duration} seconds on {Name}.\n");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
