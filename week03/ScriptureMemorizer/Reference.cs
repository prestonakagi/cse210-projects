public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructors
    // One verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Multiple verses
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Methods
    public string DisplayTextSingle()
    {
        return $"{_book} {_chapter}:{_verse}"; // for stub
    }

        public string DisplayTextMultiple()
    {
        return $"{_book} {_chapter}:{_verse} - {_endVerse}"; // for stub
    }
}