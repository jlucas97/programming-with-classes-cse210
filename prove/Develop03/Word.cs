
class Word
{
    private List<string> _shownWords = new List<string>();
    private List<string> _hiddenWords = new List<string>();
    private bool _isHidden;
    private List<int> numbersUsed = new List<int>();

    public Word()
    {

    }

    public int WordsQuantity(List<string> aList)
    {
        int wordsQuantity = 0;
        wordsQuantity = aList.Count;

        return wordsQuantity;
    }

    public List<string> HideWords()
    {
        Random rd = new Random();
        int randomNumber;
        int randomIndex;
        string replaceWithUnderscores;
        bool numberIsUsed = false;

        int difference;

        randomNumber = rd.Next(3, 5);
        difference = (WordsQuantity(ShownWords) - WordsQuantity(HiddenWords));
        if (difference < 5)
        {
            randomNumber = difference;
        }

        for (int i = 0; i < randomNumber; i++)
        {

            while (numberIsUsed == false)
            {
                randomIndex = rd.Next(WordsQuantity(ShownWords));
                if (!numbersUsed.Contains(randomIndex))
                {
                    numbersUsed.Add(randomIndex);
                    numberIsUsed = true;

                    replaceWithUnderscores = ShownWords[randomIndex];
                    HiddenWords.Add(replaceWithUnderscores);
                    string newWord = new string('_', replaceWithUnderscores.Length);

                    ShownWords[randomIndex] = newWord;
                }
            }

            numberIsUsed = false;
        }

        return ShownWords;
    }

    public bool IsWordHidden()
    {
        int numberOfHiddenWords = WordsQuantity(HiddenWords);
        int numberOfShownWords = WordsQuantity(ShownWords);

        if (numberOfHiddenWords == numberOfShownWords)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public string DisplayShownWords(Scripture aScripture)
    {

        string message = aScripture.MyReference.DisplayReference() + " ";

        if (aScripture.ScripturesList.Count > 1)
        {
            message = $"{aScripture.MyReference.Book} {aScripture.MyReference.Chapter}:" +
            $"{aScripture.MyReference.Verse}-{aScripture.MyReference.LastVerse} ";
        }
        foreach (string wordString in ShownWords)
        {
            message += wordString + " ";
        }


        return message;
    }


    public bool IsHidden { get => _isHidden; set => _isHidden = value; }
    public List<string> ShownWords { get => _shownWords; set => _shownWords = value; }
    public List<string> HiddenWords { get => _hiddenWords; set => _hiddenWords = value; }
}