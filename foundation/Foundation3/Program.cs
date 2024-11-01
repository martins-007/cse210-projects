using System;
using System.Collections.Generic;

// Base class
public abstract class Activity
{
    // Private member variables
    private DateTime date;
    private double minutes;

    // Constructor
    protected Activity(DateTime date, double minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    // Properties for shared attributes
    public DateTime Date => date;
    public double Minutes => minutes;

    // Virtual methods to be overridden
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Summary method
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Minutes} min) - Distance {GetDistance()} " +
               $"{(IsKilometers() ? "km" : "miles")}, Speed: {GetSpeed()} " +
               $"{(IsKilometers() ? "kph" : "mph")}, Pace: {GetPace()} min per {(IsKilometers() ? "km" : "mile")}";
    }

    protected virtual bool IsKilometers() => false; // Assume miles by default
}

// Derived class for Running
public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, double minutes, double distance) 
        : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / Minutes) * 60; // Speed in mph

    public override double GetPace() => Minutes / distance; // Pace in min per mile
}

// Derived class for Cycling
public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, double minutes, double speed) 
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * Minutes) / 60; // Distance in miles

    public override double GetSpeed() => speed; // Speed in mph

    public override double GetPace() => 60 / speed; // Pace in min per mile
}

// Derived class for Swimming
public class Swimming : Activity
{
    private int laps; // Number of laps

    public Swimming(DateTime date, double minutes, int laps) 
        : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        // Distance in miles
        return (laps * 50 / 1000.0) * 0.62;
    }

    public override double GetSpeed()
    {
        // Speed in mph
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        // Pace in min per mile
        return Minutes / GetDistance();
    }

    protected override bool IsKilometers() => true; // Swimming is in km
}

// Main program to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0), // 3 miles run
            new Cycling(new DateTime(2022, 11, 4), 45, 12.0), // 12 mph cycling
            new Swimming(new DateTime(2022, 11, 5), 30, 20)   // 20 laps swimming
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
