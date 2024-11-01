using System;

[Serializable]
public class ChecklistGoal : Goal
{
    private int CompletionCount { get; set; }
    private int RequiredCount { get; set; }
    private int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int requiredCount, int bonusPoints) : base(name, points)
    {
        RequiredCount = requiredCount;
        BonusPoints = bonusPoints;
        CompletionCount = 0;
    }

    public override void RecordEvent()
    {
        CompletionCount++;
        int earnedPoints = Points;
        if (CompletionCount == RequiredCount)
        {
            IsCompleted = true;
            earnedPoints += BonusPoints;
            Console.WriteLine($"Goal '{Name}' completed! You earned {earnedPoints} points (including bonus).");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' recorded! You earned {earnedPoints} points.");
        }
    }

    public override void DisplayGoalStatus()
    {
        Console.WriteLine(IsCompleted ? $"[X] {Name} - Completed {CompletionCount}/{RequiredCount} times" : $"[ ] {Name} - Completed {CompletionCount}/{RequiredCount} times");
    }
}
