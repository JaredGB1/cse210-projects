public class Comment
{
    public string _commentText;
    public string _name;

    public void DisplayComment()
    {
        Console.WriteLine($"Person Name: {_name}. Comment Text: {_commentText}");
    }
}