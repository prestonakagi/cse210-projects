public class Word
{
    private string _text;
    private bool _isHidden;

    // constructors
    public Word()
    {
        _text = "This is default for the word's text.";
    }

    public Word(string text)
    {
        // text of the word.
        _text = text;
    }

    // methods
    public void Hide()
    {

    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        return false; // just to stub
    }

    public string DisplayText()
    {
        return "stub"; // just to stub
    }
}