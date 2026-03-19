using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture with multiple verses
        Reference reference = new Reference("Proverbs", 3, 6);
        Scripture scripture = new Scripture(reference, 
            "Trust in the Lord with all your heart and lean not on your own understanding.");

        // Main loop for hiding words
        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Press any key to exit.");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }
    }
}