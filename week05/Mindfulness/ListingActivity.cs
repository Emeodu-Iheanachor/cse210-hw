using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?",
        "Who inspires you?"
    };

    public ListingActivity() 
        : base("Listing Activity",
        "List as many positive things as you can.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine($"\nPrompt: {_prompts[rand.Next(_prompts.Count)]}");

        Console.WriteLine("\nYou may begin in:");
        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        EndActivity();
    }
}