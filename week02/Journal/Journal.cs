using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>(){};

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        // Prompt user for a filename, then save complete current journal "to that file location"; 
            // is user input for just a name or for the path?? I'm going with (relative) path for now.
        // The below file is a string of the path (doesn't need start with @ before opening ") of where to save the file 
            // with filename at end and .filetype.
        // For core requirements, delimiter is ~ instead of a comma.

        Console.Write("Enter a text filename to save; example: 'filename.txt': ");
        string file = Console.ReadLine();

        using(System.IO.StreamWriter objFile = new System.IO.StreamWriter(file, false)) // true appends, false overwrites.
        {
            for (int i = 0; i < _entries.Count; i++)
            {
                objFile.WriteLine($"{_entries[i]._date}~{_entries[i]._promptText}~{_entries[i]._entryText}");
            }
        }
        
    }

    public void LoadFromFile()
    {
        // Prompt user for a filename, then load complete current journal. 
            // is user input for just a name or for the path?? I'm going with (relative) path for now.
        // This should replace any entries currently stored in the journal.
            // Do by removing each entry in list _entries OR by putting _entries to an empty list. 
            // Then do .AddEntry() process.

        // Clear (or make list empty) _entries list.
        _entries.Clear();
        
        Console.Write("Enter a text filename to load; example: 'filename.txt': ");
        string file = Console.ReadLine();

        using (StreamReader sr = new StreamReader(file))
        {
            // while not at end of "Stream"
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] values = line.Split("~");  //not sure what the [] means
                List<string> lists = new List<string>(values); // lists is (Python syntax) [date, promptText, entryText] of current line.

                // Console.WriteLine($"This is lists[0] = {lists[0]}");

                // foreach (string value in lists)
                // {
                //     Console.Write($"{value} "); // each value, which is each attribute, displayed to terminal
                // }
                // Console.WriteLine(); // each line ends with new line character in terminal
                
                // Re-assign each loadedEntry attribute from lists, then add the Entry to _entries.
                    // Each time of loop should overwrite lists from the current line from file.
                // make a global instance of Entry each loop
                Entry loadedEntry = new Entry();
                loadedEntry._date = lists[0];
                loadedEntry._promptText = lists[1];
                loadedEntry._entryText = lists[2];
                // Console.WriteLine($"date = {loadedEntry._date}, prompt = {loadedEntry._promptText}, answer = {loadedEntry._entryText}");
                _entries.Add(loadedEntry);
            }
        }
    }
}