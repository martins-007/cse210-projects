using System;

class Program
{
    static void Main()
    {
        GoalTracker tracker = new GoalTracker();

        // Sample goals
        tracker.AddGoal(new SimpleGoal("Run a marathon", 1000));
        tracker.AddGoal(new EternalGoal("Read scriptures", 100));
        tracker.AddGoal(new ChecklistGoal("Attend the temple", 50, 10, 500));

        // Simulating user interaction
        tracker.DisplayGoals();
        tracker.RecordGoalEvent("Run a marathon");
        tracker.RecordGoalEvent("Read scriptures");
        tracker.RecordGoalEvent("Attend the temple");
        tracker.RecordGoalEvent("Attend the temple");
        tracker.RecordGoalEvent("Attend the temple");

        Console.WriteLine($"Total points: {tracker.GetTotalPoints()}");

        // Save to file
        tracker.Save("goals.dat");

        // Load from file
        GoalTracker loadedTracker = GoalTracker.Load("goals.dat");
        loadedTracker.DisplayGoals();
    }
}
