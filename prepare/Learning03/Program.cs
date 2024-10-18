using System;

public class Fraction
{
    // Step 2: Private attributes for numerator and denominator
    private int _top;
    private int _bottom;

    // Step 3: Constructors

    // Constructor that initializes fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor that initializes fraction with a numerator and denominator 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor that initializes fraction with both numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Step 4: Getters and Setters

    // Getter for numerator
    public int GetTop()
    {
        return _top;
    }

    // Setter for numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for denominator
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Step 5: Methods

    // Method to return the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value of the fraction (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

    // Test the Fraction class
    public static void Main(string[] args)
    {
        // Test the constructors
        Fraction f1 = new Fraction();  // 1/1
        Fraction f2 = new Fraction(5); // 5/1
        Fraction f3 = new Fraction(3, 4); // 3/4
        Fraction f4 = new Fraction(1, 3); // 1/3

        // Test the methods and display results
        Console.WriteLine(f1.GetFractionString()); // 1/1
        Console.WriteLine(f1.GetDecimalValue());   // 1.0

        Console.WriteLine(f2.GetFractionString()); // 5/1
        Console.WriteLine(f2.GetDecimalValue());   // 5.0

        Console.WriteLine(f3.GetFractionString()); // 3/4
        Console.WriteLine(f3.GetDecimalValue());   // 0.75

        Console.WriteLine(f4.GetFractionString()); // 1/3
        Console.WriteLine(f4.GetDecimalValue());   // 0.3333333

        // Test getters and setters
        f3.SetTop(6);
        f3.SetBottom(7);
        Console.WriteLine(f3.GetFractionString()); // 6/7
        Console.WriteLine(f3.GetDecimalValue());   // ~0.857
    }
}
