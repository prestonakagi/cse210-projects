public class Word
{
    private string _text;
    private bool _isHidden = false;

    // constructors
    public Word(string text)
    {
        // text of the word.
        _text = text;
    }

    // methods
    public void Hide()
    {
        int letterCount = _text.Count();
        string allUnderscores = new string('_', letterCount);
        _text = allUnderscores;
        _isHidden = true;
    }

    // Core requirements can select already hidden words, so why need Show()?? 
    // public void Show()
    // {

    // }

    public bool IsHidden()
    {
        if (_text.Contains("_") && (_isHidden == true))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string DisplayText()
    {
       return _text;
    }
}