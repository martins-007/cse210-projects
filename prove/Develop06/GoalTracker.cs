using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class GoalTracker
{
    private List<Goal> goals = new List<Goal>();
    private int totalPoints = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoalEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.GetName() == goalName)
            {
                goal.RecordEvent();
                totalPoints += goal.GetPoints();
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            goal.DisplayGoalStatus();
        }
    }

    public int GetTotalPoints() => totalPoints;

    public void Save(string filename)
    {
        using (FileStream fs = new FileStream(filename, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, this);
        }
    }

    public static GoalTracker Load(string filename)
    {
        using (FileStream fs = new FileStream(filename, FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return (GoalTracker)formatter.Deserialize(fs);
        }
    }
}
