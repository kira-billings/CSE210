using System;

class Program
{
    static void Main(string[] args)
    {
        
        // comments
        Comment comment1a = new Comment();
        comment1a._name = "Kira Billings";
        comment1a._text = "Cat's are the best pets ever";
        Comment comment1b = new Comment();
        comment1b._name = "Kira Billings";
        comment1b._text = "Best gamer internet video ever";
        Comment comment1c = new Comment();
        comment1c._name = "Kira Billings";
        comment1c._text = "Good to have you on the team!";
        Comment comment1d = new Comment();
        comment1d._name = "Kira Billings";
        comment1d._text = "Missionaries are the best";

        Comment comment2a = new Comment();
        comment2a._name = "Randy Billings";
        comment2a._text = "Zeb rocks!";
        Comment comment2b = new Comment();
        comment2b._name = "Randy Billings";
        comment2b._text = "Zach rocks!";
        Comment comment2c = new Comment();
        comment2c._name = "Randy Billings";;
        comment2c._text = "Zi rocks!";
        Comment comment2d = new Comment();
        comment2d._name = "Randy Billings";
        comment2d._text = "Zander rocks!";

        Comment comment3a = new Comment();
        comment3a._name = "Kasen Billings";
        comment3a._text = "cat's are furry";
        Comment comment3b = new Comment();
        comment3b._name = "Kasen Billings";
        comment3b._text = "Uncle Zach is cool";
        Comment comment3c = new Comment();
        comment3c._name = "Kasen Billings";
        comment3c._text = "I love you!";
        Comment comment3d = new Comment();
        comment3d._name = "Kasen Billings";
        comment3d._text = "Uncle Zander is cool";
        
          // videos
        Video video1 = new Video();
        video1._author = "Zeb Billings";
        video1._title = "Funny Cat Videos";
        video1._length = 99;
        video1._comments.Add(comment1a);
        video1._comments.Add(comment2a);
        video1._comments.Add(comment3a);
        

        Video video2 = new Video();
        video2._author = "Zach Billings";
        video2._title = "The LDS Gamer";
        video2._length = 78;
        video2._comments.Add(comment1b);
        video2._comments.Add(comment2b);
        video2._comments.Add(comment3b);

        Video video3 = new Video();
        video3._author = "Zander Billings";
        video3._title = "Preach the Gospel";
        video3._length= 222;
        video3._comments.Add(comment1c);
        video3._comments.Add(comment2c);
        video3._comments.Add(comment3c);

        Video video4 = new Video();
        video4._author = "Zi Billings";
        video4._title = "The Church is True";
        video4._length = 444;
        video4._comments.Add(comment1d);
        video4._comments.Add(comment2d);
        video4._comments.Add(comment3d);
        
        Console.WriteLine();
        video1.DisplayVideo();
        video1.DisplayLength();
        video1.DisplayNumberOfComments();
        video1.DisplayComments();
        Console.WriteLine();
        video2.DisplayVideo();
        video2.DisplayLength();
        video2.DisplayNumberOfComments();
        video2.DisplayComments();
        Console.WriteLine();
        video3.DisplayVideo();
        video3.DisplayLength();
        video3.DisplayNumberOfComments();
        video3.DisplayComments();
    }
}