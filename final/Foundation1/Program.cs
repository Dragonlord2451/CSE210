using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Video video1 = new Video("How to Cook Pasta", "Chef John", 300);
        Video video2 = new Video("Python Programming Basics", "CodeAcademy", 1200);
        Video video3 = new Video("10-Minute Yoga", "YogaWithAdriene", 600);

        
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "My kids loved it."));
        video1.AddComment(new Comment("Charlie", "Easy to follow."));

        video2.AddComment(new Comment("Dave", "Very informative."));
        video2.AddComment(new Comment("Eve", "Helped me a lot."));
        video2.AddComment(new Comment("Frank", "Looking forward to more tutorials."));

        video3.AddComment(new Comment("Grace", "Perfect for a quick break."));
        video3.AddComment(new Comment("Heidi", "Felt so relaxed after this."));
        video3.AddComment(new Comment("Ivan", "Great instructions."));

        
        List<Video> videos = new List<Video> { video1, video2, video3 };

        
        foreach (Video video in videos)
        {
            Console.WriteLine(video);
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment}");
            }
            Console.WriteLine(); 
        }
    }
}
