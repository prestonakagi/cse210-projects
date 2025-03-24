public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>(){};
    private List<string> _testWords;
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
        foreach (string oneWord in textWords)
        {
            _testWords.Add(oneWord);
        }        
        // foreach (string oneWord in textWords)
        // {
        //     Word wword = new Word(oneWord);
        //     _words.Add(wword);
        // }

        Console.WriteLine(_testWords[0]);
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string DisplayText()
    {
        return "stub";
    }

    public bool IsCompletelyHidden()
    {
        return false; // just for stub
    }
}