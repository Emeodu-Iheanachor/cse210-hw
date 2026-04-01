using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time you stood up for someone.",
        "Think of a time you showed courage."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made it successful?",
        "How can you apply this again?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity",
        "Reflect on your strength and resilience.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine($"\nPrompt: {_prompts[rand.Next(_prompts.Count)]}");

        Console.WriteLine("\nReflect on the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.Write($"\n{question} ");
            ShowSpinner(5);
        }

        EndActivity();
    }
}