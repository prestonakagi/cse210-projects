public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "How did I progress in one of my goals today?",
        "What was a song I listened to today that I liked, and why did I like it?",
        "Who is one person you look up to and why?",
        "If you could live in one of your favorite stories, which story would it be and why?"
    };

    public string GetRandomPrompt()
    {
        // Random object
        Random rnd = new Random();
        // get random index
        int randomIndex = rnd.Next(_prompts.Count);

        // return a random prompt from _prompts list.
        return _prompts[randomIndex];

        // when stub out code, got/get error "not all code paths return a value".
        // So write a return value just to have one, until write the actual code, so program can compile.
        // return "";
    }    
}