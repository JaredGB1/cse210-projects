using static System.Random;
public class Scripture
{

    private string _reference;
    private string _scriptureText;
    private List<Word> _wordsList = new List<Word>();
//Scripture() constructor is in charge of creating a list of scriptures and references.
//Scripture() constructor will also add the words from the _scriptureText variable to the _wordsList.
    public Scripture(string reference, string scriptureText)
    {
        _reference=reference;
        _scriptureText=scriptureText;
        string[] wordsList = _scriptureText.Split(" ");
        foreach (string words in wordsList)
        {
            Word word = new Word(words);
            _wordsList.Add(word);
        }

    }
    public Scripture()
    {
        //Creating a List of references and Scripture text.
        List<string> referenceList = new List<string>();
        List<string> scriptureList = new List<string>();
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);
        referenceList.Add(reference1.GetReference());
        scriptureList.Add("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Reference reference2 = new Reference("Nephi", 3, 7);
        referenceList.Add(reference2.GetReference());
        scriptureList.Add("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Reference reference3 = new Reference("Doctrine and Covenants", 1, 37, 38);
        referenceList.Add(reference3.GetReference());
        scriptureList.Add("Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same.");
        Reference reference4=new Reference("John",3,5);
        referenceList.Add(reference4.GetReference());
        scriptureList.Add("Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
        //Selecting a random index from 0 to 3 from the reference and scripture list to add the value  _scriptureText and _reference variables.
        Random random1 = new Random();
        int randomIndex1 = random1.Next(0, 3);
        _scriptureText = scriptureList[randomIndex1];
        _reference = referenceList[randomIndex1];
        //Adding the words from the scripture to the _wordsList 
        string[] wordsList = _scriptureText.Split(" ");
        foreach (string words in wordsList)
        {
            Word word = new Word(words);
            _wordsList.Add(word);
        }
    }
    //HideWords() method is in charge of using the Hide method from the Word class.
    //It will hide random words from the _wordsList.
    public List<Word> HideWords()
    {
        int numberOfWords = _wordsList.Count();
        Random random = new Random();
        int visibleWords = VisibleWords();
        //If the number of visible words is more than 5, the program will hide a random amount of words between 1 to 5.
        if (visibleWords > 5)
        {
            int numberOfRandomWords = random.Next(1, 5);
            for (int i = 0; i < numberOfRandomWords; i++)
            {
                int index = 0;
                int randomIndex = random.Next(numberOfWords);
                //The program will check if the word is hidden or shown.
                string status2 = _wordsList[randomIndex].IsHidden();
                //If the word is hidden the program will do a while to find a word from the _wordsList that is shown to hide it.
                if (status2 == "yes")
                {
                    while (status2 == "yes")
                    {
                        if (index < _wordsList.Count())
                        {
                            status2 = _wordsList[index].IsHidden();
                            _wordsList[index].Hide(_wordsList[index]);
                            index += 1;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                }
                //If the word is shown, the program will hide the word.
                else
                {
                    _wordsList[randomIndex].Hide(_wordsList[randomIndex]);
                }
            }
        }
        //If the number of visible words is Less than 5, the program will hide the rest of the Shown words.
        else
        {
            for (int i = 0; i < visibleWords; i++)
            {
                int index = 0;
                int randomIndex = random.Next(numberOfWords);
                //The program will check if the word is hidden or shown.
                string status2 = _wordsList[randomIndex].IsHidden();
                 //If the word is hidden the program will do a while to find a word from the _wordsList that is shown to hide it.
                if (status2 == "yes")
                {
                    while (status2 == "yes")
                    {
                        if (index < _wordsList.Count())
                        {
                            status2 = _wordsList[index].IsHidden();
                            _wordsList[index].Hide(_wordsList[index]);
                            index += 1;
                        }
                        else
                        {
                            index = 0;
                        }
                    }
                }
                //If the word is shown, the program will hide the word.
                else
                {
                    _wordsList[randomIndex].Hide(_wordsList[randomIndex]);
                }
            }
        }

        return _wordsList;
    }
    //GetRenderedText() Method will show the updated _wordsList values on the console.
    public void GetRenderedText()
    {
        string scriptureWords = "";

        foreach (Word word1 in _wordsList)
        {
            scriptureWords = scriptureWords + " " + word1.GetWord();
        }
        Console.WriteLine($"{_reference} {scriptureWords}");
    }

    //IsCompletelyHidden() Method will end the program if all the words on the _wordsList variable is hidden.
    public void IsCompletelyHidden()
    {
        int numberOfVisibleWords = 0;
        //For loop to check if there is a visible word on the _wordsList variable.
        foreach (Word word4 in _wordsList)
        {
            string visibility = word4.GetVisibility();
            if (visibility == "Show")
            {
                numberOfVisibleWords = +1;
            }
        }
        if (numberOfVisibleWords == 0)
        {
            Console.Clear();
            GetRenderedText();
            Environment.Exit(0);
        }
    }

    //VisibleWords() method is used to get the number of visible words on the _wordsList variable.
    private int VisibleWords()
    {
        int numberOfVisibleWords = 0;
        foreach (Word word4 in _wordsList)
        {
            string visibility = word4.GetVisibility();
            if (visibility == "Show")
            {
                numberOfVisibleWords = numberOfVisibleWords + 1;
            }
        }
        return numberOfVisibleWords;
    }
}