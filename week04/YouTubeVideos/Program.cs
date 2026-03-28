using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Intro to Programming", "TechWithSam", 600);
        v1.AddComment(new Comment("Alice", "Great explanation!"));
        v1.AddComment(new Comment("Bob", "Very helpful."));
        v1.AddComment(new Comment("Charlie", "Loved this video."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("C# Basics Tutorial", "CodeMaster", 800);
        v2.AddComment(new Comment("David", "Clear and simple."));
        v2.AddComment(new Comment("Eve", "Thanks for this!"));
        v2.AddComment(new Comment("Frank", "Good pace."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Object-Oriented Programming", "DevAcademy", 900);
        v3.AddComment(new Comment("Grace", "Now I understand OOP."));
        v3.AddComment(new Comment("Hannah", "Very informative."));
        v3.AddComment(new Comment("Isaac", "Awesome content."));
        videos.Add(v3);

        // Video 4
        Video v4 = new Video("Advanced C# Concepts", "ProCoder", 1200);
        v4.AddComment(new Comment("Jack", "Challenging but good."));
        v4.AddComment(new Comment("Karen", "Learned a lot."));
        v4.AddComment(new Comment("Leo", "Well explained."));
        videos.Add(v4);

        // Display Videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments Count: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine("-----------------------------------");
        }
    }
}