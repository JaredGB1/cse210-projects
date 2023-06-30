public class Video
{
    public string _title;
    public string _author;
    public int _lenghtInSeconds;
    public List<Comment> _commentList=new List<Comment>();

    public int GetNumberOfComments()
    {
        return _commentList.Count();
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Video Author: {_author}. Video Title: {_title}. Lenght in Seconds: {_lenghtInSeconds}. Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments: ");
        foreach(Comment comment in _commentList)
        {
            comment.DisplayComment();
        }
    }
}