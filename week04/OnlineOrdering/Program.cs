using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# Basics", "CodeMaster", 600);
        Video video2 = new Video("OOP Explained", "TechGuru", 750);
        Video video3 = new Video("Abstraction in Programming", "DevWorld", 500);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "I learned a lot!"));

        // Add comments to video2
        video2.AddComment(new Comment("David", "Clear explanation."));
        video2.AddComment(new Comment("Eve", "Nice examples."));
        video2.AddComment(new Comment("Frank", "Awesome video!"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Now I understand abstraction."));
        video3.AddComment(new Comment("Henry", "Well explained."));
        video3.AddComment(new Comment("Ivy", "Good job!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine("-----------------------------------");
        }
    }
}