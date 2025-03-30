using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment();
        comment1._name = "Batman";
        comment1._text = "I'm Batman!";

        Comment comment2 = new Comment();
        comment2._name = "Robin";
        comment2._text = "What's wrong Batman?!";

        Comment comment3 = new Comment();
        comment3._name = "Joker";
        comment3._text = "Wanna know how I got these scars?";

        Video video1 = new Video();
        video1._title = "Crime Watch";
        video1._author = "Jeff Gordon";
        video1._length = 600;
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Comment comment4 = new Comment();
        comment4._name = "Ironman";
        comment4._text = "Earth is closed today!";

        Comment comment5 = new Comment();
        comment5._name = "Captain America";
        comment5._text = "Language!";

        Comment comment6 = new Comment();
        comment6._name = "Thor";
        comment6._text = "He doesn't look that big.";

        Video video2 = new Video();
        video2._title = "Inevitable Destiny";
        video2._author = "Thanos";
        video2._length = 60;
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Comment comment7 = new Comment();
        comment7._name = "GoodBoy1";
        comment7._text = "Every owner needs these!";

        Comment comment8 = new Comment();
        comment8._name = "Spot";
        comment8._text = "I love the bells and squeakers!";

        Comment comment9 = new Comment();
        comment9._name = "Daisy";
        comment9._text = "Wish I had one of those...";

        Video video3 = new Video();
        video3._title = "New Chewtoys";
        video3._author = "Rover";
        video3._length = 360;
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        // make list of the videos and then loop thru with .DisplayVideo()
        List<Video> videos = new List<Video>(){};
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach (Video vid in videos)
        {
            vid.DisplayVideo();
        }
    }
}