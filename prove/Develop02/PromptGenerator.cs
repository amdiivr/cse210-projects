using System;

public class PromptGenerator
{
    public List<Entry> _randomPrompt = new List<Entry>();

    public void Display()
    {
        Console.WriteLine(_randomPrompt);
        
        foreach (Entry prompt in _randomPrompt)
        {
            prompt.Display();
        }
        
    }
}