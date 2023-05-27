public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _reference;
//Reference() Constructor in case the reference only has 1 verse.
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _reference = $"{_book} {_chapter}:{_startVerse}";
    }
//Reference() Constructor in case the reference has a verse range.    
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
//GetReference Method used to get the string _reference variable.
    public string GetReference()
    {
        return _reference;
    }
}