using System;

public class Fraction
{
    // Private attributes (Encapsulation)
    private int _numerator;
    private int _denominator;

    // Default constructor (1/1)
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter (top only, bottom = 1)
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with two parameters
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter and Setter for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int value)
    {
        _numerator = value;
    }

    // Getter and Setter for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int value)
    {
        if (value != 0) // prevent division by zero
        {
            _denominator = value;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero. Keeping previous value.");
        }
    }

    // Method to return fraction as string (e.g., 3/4)
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return decimal value
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}