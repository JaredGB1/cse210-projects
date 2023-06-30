using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList= new List<Video>();
        //Adding Video 1 values
        Video video1= new Video();
        video1._author="Caedrel";
        video1._title="THESHY VS SHADOW";
        video1._lenghtInSeconds=1012;

        //Creating comments for the video 1
        Comment comment1Video1= new Comment();
        Comment comment2Video1= new Comment();
        Comment comment3Video1= new Comment();
        comment1Video1._name="tuananh8124";
        comment1Video1._commentText="love Caedrel when he talk about TheShy";
        comment2Video1._name="SUKUNA57";
        comment2Video1._commentText="We need Caedrel photo with TheShy of Weibo makes it to worlds";
        comment3Video1._name="HmoobXican";
        comment3Video1._commentText="Editor works harder then MAD vs T1";
        //Adding the comments to the video1 _commentList
        video1._commentList.Add(comment1Video1);
        video1._commentList.Add(comment2Video1);
        video1._commentList.Add(comment3Video1);
        //Adding Video 1 to the videoList
        videoList.Add(video1);
        //Adding Video 2 values
        Video video2= new Video();
        video2._author="MKLeo";
        video2._title="I WENT 24-1 AT LUDWIG'S INVITATIONAL!";
        video2._lenghtInSeconds=1651;
        //Creating comments for the video 2
        Comment comment1Video2= new Comment();
        Comment comment2Video2= new Comment();
        Comment comment3Video2= new Comment();
        comment1Video2._name="jmanuel2069";
        comment1Video2._commentText="I will never doubt Leo ever again";
        comment2Video2._name="SoloSalo";
        comment2Video2._commentText="This man really played Joker for a single set and still dropped a bunch of clips... GOAT";
        comment3Video2._name="wolfking4430";
        comment3Video2._commentText="The king is back, although to be real he never really left.  Also the requiem tag was FUCKING RAW!!";
        //Adding the comments to the video2 _commentList
        video2._commentList.Add(comment1Video2);
        video2._commentList.Add(comment2Video2);
        video2._commentList.Add(comment3Video2);
        //Adding Video 2 to the videoList
        videoList.Add(video2);
        //Adding Video 3 values
        Video video3= new Video();
        video3._author="EazySpeezy";
        video3._title="I tried the hardest Bloons TD 5 speedrun";
        video3._lenghtInSeconds=691;
        //Creating comments for the video 3
        Comment comment1Video3= new Comment();
        Comment comment2Video3= new Comment();
        Comment comment3Video3= new Comment();
        comment1Video3._name="ichigloo";
        comment1Video3._commentText="eazy speedy is the nostalgia maker";
        comment2Video3._name="RyG99";
        comment2Video3._commentText="Am I the only one that uses this man speed runs as tutorials";
        comment3Video3._name="stickbruhyt345";
        comment3Video3._commentText="The tower defense games bring alot of nostagia";
        //Adding the comments to the video3 _commentList
        video3._commentList.Add(comment1Video3);
        video3._commentList.Add(comment2Video3);
        video3._commentList.Add(comment3Video3);
        //Adding Video 3 to the videoList
        videoList.Add(video3);
        //Doing a for loop to display the values inside the videoList
        foreach(Video video in videoList)
        {
            video.DisplayVideoInformation();
            Console.WriteLine();
        }
    }
}