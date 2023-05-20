
public class Word
{

    public string _word;
    private string _visibility;
    public Word(string word)
    {
        _word = word;
        _visibility = "Show";
    }
    public string getWord()
    {
        return _word;
    }
    public void setWord(string word)
    {
        _word = word;
    }

    public void setVisibility(string visibility)
    {
        _visibility = visibility;
    }
    public string getVisibility()
    {
        return _visibility;
    }
    public Word Hide(Word word)
    {
        string newWord = "";
        foreach (char c in word.getWord())
        {
            newWord = newWord + "_";
        }
        word.setWord(newWord);
        word.setVisibility("Hide");
        return word;
    }

    public string isHidden()
    {
        string status1="";
        if(_visibility=="Hide")
        {
            status1="yes";
        }
        else
        {
            status1="no";
        }
        return status1;
    }

}