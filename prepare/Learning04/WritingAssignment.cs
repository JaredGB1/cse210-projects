public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title):base(studentName,topic)
    {
        _title=title;
    }
    public string GetWritingInformation()
    {
        string name=GetStudentName();
        string writingInformation=$"{_title} by {name}";
        return writingInformation;
    }
}