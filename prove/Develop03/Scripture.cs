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
        int visibleWords = VisibleWords();
        if (visibleWords > 5)
        {
            int numberOfRandomWords = random.Next(1, 5);
            for (int i = 0; i < numberOfRandomWords; i++)
            {
                int index = 0;
                int randomIndex = random.Next(numberOfWords);
                string status2 = _wordsList[randomIndex].isHidden();
                if (status2 == "yes")
                {
                    while (status2 == "yes")
                    {
                        if (index < 27)
                        {
                            status2 = _wordsList[index].isHidden();
                            _wordsList[index].Hide(_wordsList[index]);
                            index += 1;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    _wordsList[randomIndex].Hide(_wordsList[randomIndex]);
                }
            }
        }
        else
        {
            for (int i = 0; i < visibleWords; i++)
            {
                int index = 0;
                int randomIndex = random.Next(numberOfWords);
                string status2 = _wordsList[randomIndex].isHidden();
                if (status2 == "yes")
                {
                    while (status2 == "yes")
                    {
                        if (index < 27)
                        {
                            status2 = _wordsList[index].isHidden();
                            _wordsList[index].Hide(_wordsList[index]);
                            index += 1;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    _wordsList[randomIndex].Hide(_wordsList[randomIndex]);
                }
            }
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

    public void IsCompletelyHidden()
    {
        int numberOfVisibleWords = 0;
        foreach (Word word4 in _wordsList)
        {
            string visibility = word4.getVisibility();
            if (visibility == "Show")
            {
                numberOfVisibleWords = +1;
            }
        }
        if (numberOfVisibleWords == 0)
        {
            getRenderedText();
            Environment.Exit(0);
        }

    }

    private int VisibleWords()
    {
        int numberOfVisibleWords = 0;
        foreach (Word word4 in _wordsList)
        {
            string visibility = word4.getVisibility();
            if (visibility == "Show")
            {
                numberOfVisibleWords= numberOfVisibleWords + 1;
            }
        }
        return numberOfVisibleWords;
    }
}