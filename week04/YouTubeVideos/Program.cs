using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of videos
        List<Video> videos = new List<Video>();

        // VIDEO 1
        Video video1 = new Video("Learn C# Basics", "CodeMaster", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        videos.Add(video1);

        // VIDEO 2
        Video video2 = new Video("OOP Concepts Explained", "DevGuru", 750);
        video2.AddComment(new Comment("David", "Clear explanation!"));
        video2.AddComment(new Comment("Eve", "Encapsulation makes sense now."));
        video2.AddComment(new Comment("Frank", "Awesome video!"));
        videos.Add(video2);

        // VIDEO 3
        Video video3 = new Video("Data Structures in 10 Minutes", "QuickLearn", 500);
        video3.AddComment(new Comment("Grace", "Short and useful."));
        video3.AddComment(new Comment("Henry", "Loved the examples."));
        video3.AddComment(new Comment("Ivy", "Please make more videos."));
        videos.Add(video3);

        // Iterate and display
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}