using System;

[Serializable]
public abstract class Goal
{
    protected string Name { get; set; }
    protected int Points { get; set; }
    protected bool IsCompleted { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public string GetName() => Name;
    public int GetPoints() => Points;
    public bool GetIsCompleted() => IsCompleted;
    public abstract void RecordEvent();
    public abstract void DisplayGoalStatus();
}
