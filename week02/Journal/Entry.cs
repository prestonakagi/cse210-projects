public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        // the \n works for new line character in C# like Python!
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}");
    }
}