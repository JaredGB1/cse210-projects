using static System.Random;
public class Scripture
{

    private string _reference;
    private string _scriptureText;
    private List<Word> _wordsList = new List<Word>();

    public Scripture(string scriptureText, string reference)
    {
        _scriptureText = scriptureText;
        string[] wordsList = scriptureText.Split(" ");
        foreach (string words in wordsList)
        {
            Word word = new Word(words);
            _wordsList.Add(word);
        }

        _reference = reference;
    }

    public List<Word> HideWords()
    {

        int numberOfWords = _wordsList.Count();
        Random random = new Random();
        
        int numberOfRandomWords = random.Next(1,5);
        for (int i = 0; i < numberOfRandomWords; i++)
        {
            int randomIndex = random.Next(numberOfWords);
            string status2=_wordsList[randomIndex].isHidden();
            while(status2 =="yes")
            {
                randomIndex = random.Next(numberOfWords);
                status2=_wordsList[randomIndex].isHidden();          
            }
            _wordsList[randomIndex].Hide(_wordsList[randomIndex]);
            
        }
        return _wordsList;
    }
    public void getRenderedText()
    {
        string scriptureWords = "";

        foreach (Word word1 in _wordsList)
        {
            scriptureWords = scriptureWords + " " + word1.getWord();
        }
        Console.WriteLine($"{_reference} {scriptureWords}");
    }

    public string IsCompletelyHidden()
    {
        string status="";
        int numberOfVisibleWords=0;

        foreach(Word word4 in _wordsList)
        {
            string visibility=word4.getVisibility();
            if (visibility=="Show")
            {
                numberOfVisibleWords=+1;
            }
        }
        if (numberOfVisibleWords==0)
        {
            status="quit";
        }
        return status;
    }
}