public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructors
    public Scripture(Reference reference, string text)
    {
        // text is whole text of the scripture not including verse numbers.
        _reference = reference;
        
        // create empty list of List<Word>, then split up the words in text string, 
        // then create Word objects for each word, then put them in the List<Word>.
    }

    // methods
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