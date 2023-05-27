
public class Word
{

    public string _word;
    private string _visibility;
    //Word() Constructor created to give the information to the _word and _visibility data.
    public Word(string word)
    {
        _word = word;
        _visibility = "Show";
    }
    //GetWord() method used to get the information from the _word variable.
    public string GetWord()
    {
        return _word;
    }
    //SetWord() method used to change the value of the _word variable.
    public void SetWord(string word)
    {
        _word = word;
    }
    //SetVisibility() method used to change the value of the _visibility variable.
    public void SetVisibility(string visibility)
    {
        _visibility = visibility;
    }
    //GetVisibility() method used to get the value of the _visibility variable.
    public string GetVisibility()
    {
        return _visibility;
    }
    //Method Hide() used to change the word to the format "_ _ _ _ _"
    public Word Hide(Word word)
    {
        string newWord = "";
        foreach (char c in word.GetWord())
        {
            newWord = newWord + "_";
        }
        word.SetWord(newWord);
        word.SetVisibility("Hide");
        return word;
    }
    //IsHidden returns the status of the visibility of the word.
    //If the word is Hidden, the method will return yes.
    //If the word is Shown, the method will return no.
    public string IsHidden()
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