using System.Security;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>(){};
    private List<string> _testWords =  new List<string>(){};
    private string _passage;

    // Constructors
    public Scripture(Reference reference, string text)
    {
        // text is whole text of the scripture not including verse numbers.
        _reference = reference;
        _passage = text;
    }

    // methods
    public void MakeWordList()
    {
        // create empty list of List<Word>, then split up the words in text string, 
        // then create Word objects for each word, then put them in the List<Word>.

        string[] textWords = _passage.Split(" ");
        // foreach (string oneWord in textWords)
        // {
        //     _testWords.Add(oneWord);
        // }        
        foreach (string oneWord in textWords)
        {
            Word wword = new Word(oneWord);
            _words.Add(wword);
        }

        // Console.WriteLine(_testWords[0]);
        // Console.WriteLine(_words[0]);
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int counter = 1;

        while (counter <= numberToHide)
        {
            int randomIndex = random.Next(_words.Count);
            // Console.WriteLine($"randomIndex = {randomIndex}");
            Word randomWord = _words[randomIndex];
            randomWord.Hide(); // now Word's _text is allUnderscores. and _isHidden is true.

            counter++;
        }
    }

    public string DisplayText()
    {
        List<string> currentTexts = new List<string>(){}; // list of Word._text strings.
        foreach (Word word in _words)
        {
            currentTexts.Add(word.getWordText());
        }
        
        string joinedText = String.Join(" ", currentTexts);

        string refstring = _reference.DisplayReferenceText();

        return refstring + " " + joinedText;
    }

    public bool IsCompletelyHidden()
    {
        List<bool> hiddenStatuses = new List<bool>(){};
        foreach (Word word in _words)
        {
            hiddenStatuses.Add(word.IsHidden());
        }
        if (!hiddenStatuses.Contains(false))
        {
            return true;
        }
        else {
            return false;
        }

    }
}