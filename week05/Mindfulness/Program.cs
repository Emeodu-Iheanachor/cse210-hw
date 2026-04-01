using System;
using System.Collections.Generic;

class Program
{
    static List<string> activityLog = new List<string>();

    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("\nChoose an option: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var breathing = new BreathingActivity();
                    breathing.Run();
                    activityLog.Add("Breathing completed");
                    break;

                case 2:
                    var reflection = new ReflectionActivity();
                    reflection.Run();
                    activityLog.Add("Reflection completed");
                    break;

                case 3:
                    var listing = new ListingActivity();
                    listing.Run();
                    activityLog.Add("Listing completed");
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

        Console.WriteLine("\nSession Summary:");
        foreach (var log in activityLog)
        {
            Console.WriteLine($"- {log}");
        }
    }
}


// EXCEEDING REQUIREMENTS:
// 1. Added activity logging system to track completed activities.
// 2. Session summary shown at the end.
// 3. Improved animations using spinner and countdown.
// 4. Cleaner user experience with structured menu loop.


