using System;

[Serializable]
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        IsCompleted = true;
        Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
    }

    public override void DisplayGoalStatus()
    {
        Console.WriteLine(IsCompleted ? $"[X] {Name}" : $"[ ] {Name}");
    }
}
