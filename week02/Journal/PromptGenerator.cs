public class PromptGenerator
{
    public List<string> _prompts = new List<string> { "What is the best part of your day today?", "How many hours were you productive this day?", "How many hours have you wasted today?", "What is an important lesson that you have learned today?", "What would you like to accomplish tomorrow?", "Write of something that is in your mind." };

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int promptIndex = randomPrompt.Next(_prompts.Count);
        return _prompts[promptIndex];
    }
}