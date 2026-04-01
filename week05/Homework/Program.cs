using System;

class Program
{
    static void Main(string[] args)
    {
        // Base Assignment Test
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        Console.WriteLine();

        // Math Assignment Test
        MathAssignment math = new MathAssignment(
            "Roberto Rodriguez",
            "Fractions",
            "7.3",
            "8-19"
        );

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        // Writing Assignment Test
        WritingAssignment writing = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}