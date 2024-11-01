using System;

[Serializable]
public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");
    }

    public override void DisplayGoalStatus()
    {
        Console.WriteLine($"[ ] {Name} (Eternal)");
    }
}
