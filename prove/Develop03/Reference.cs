public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _reference;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _reference = $"{_book} {_chapter}:{_startVerse}";
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }

    public string GetReference()
    {
        return _reference;
    }
}