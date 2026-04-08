using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private string _fileName = "goals.txt";

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Eternal Quest Menu ---");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": RecordEvent(); break;
                case "3": ShowGoals(); break;
                case "4": ShowScore(); break;
                case "5": SaveGoals(); break;
                case "6": LoadGoals(); break;
                case "0": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select Goal Type: 1-Simple, 2-Eternal, 3-Checklist");
        string type = Console.ReadLine();
        Console.Write("Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1": _goals.Add(new SimpleGoal(name, points)); break;
            case "2": _goals.Add(new EternalGoal(name, points)); break;
            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, points, target, bonus));
                break;
            default: Console.WriteLine("Invalid type."); break;
        }
    }

    private void RecordEvent()
    {
        ShowGoals();
        Console.Write("Enter goal number to record event: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
        else Console.WriteLine("Invalid goal number.");
    }

    private void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    private void ShowScore()
    {
        Console.WriteLine($"Your total score: {_score}");
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                string type = g.GetType().Name;
                writer.WriteLine($"{type}:{g.GetDetailsString()}");
            }
        }
        Console.WriteLine("Goals saved!");
    }

    private void LoadGoals()
    {
        if (!File.Exists(_fileName)) { Console.WriteLine("No save file found."); return; }

        string[] lines = File.ReadAllLines(_fileName);
        _goals.Clear();
        _score = int.Parse(lines[0]);
        Console.WriteLine("Goals loaded!");
    }
}