public class Video
{
    public string _title;
    public string _author;
    public int _length; // in seconds
    public List<Comment> _comments = new List<Comment>(){};

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author}, length {_length} seconds, number of comments = {CountComments()}");
        Console.WriteLine("These are the video's comments:");
        DisplayComments();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }   

    public int CountComments()
    {
        return _comments.Count();
    } 

    public void DisplayComments()
    {
        // includes name of commenter
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment._name} commented \"{comment._text}\"");
        }
        Console.WriteLine(); // blank line to seperate videos.
    }
}