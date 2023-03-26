using System;
using System.Collections.Generic;


class Program {
    static void Main(string[] args) {
        List<Video> videos = new List<Video>();

        // create 3-4 videos with comments
        Video video1 = new Video("Title of Video 1", "Author of Video 1", 60);
        video1.Comments.Add(new Comment("Commenter 1", "This is a comment on video 1"));
        video1.Comments.Add(new Comment("Commenter 2", "Another comment on video 1"));
        video1.Comments.Add(new Comment("Commenter 3", "Third comment on video 1"));
        videos.Add(video1);

        Video video2 = new Video("Title of Video 2", "Author of Video 2", 120);
        video2.Comments.Add(new Comment("Commenter 1", "This is a comment on video 2"));
        video2.Comments.Add(new Comment("Commenter 2", "Another comment on video 2"));
        video2.Comments.Add(new Comment("Commenter 3", "Third comment on video 2"));
        video2.Comments.Add(new Comment("Commenter 4", "Fourth comment on video 2"));
        videos.Add(video2);

        Video video3 = new Video("Title of Video 3", "Author of Video 3", 180);
        video3.Comments.Add(new Comment("Commenter 1", "This is a comment on video 3"));
        video3.Comments.Add(new Comment("Commenter 2", "Another comment on video 3"));
        videos.Add(video3);

        // iterate through the list of videos and display information about each one
        foreach (Video video in videos) {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.NumComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments) {
                Console.WriteLine($" - {comment._name} : {comment._text}");
            }

            Console.WriteLine(); 
        }
    }
}
