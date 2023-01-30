using System;

public class PromptGenerator 
{
    public List<string> _promptList = new List<string>();

    public void DisplayPrompt()
    {
        Random r = new Random();
        int getRandom = r.Next(0, _promptList.Count());

        Console.WriteLine(_promptList[getRandom]);       
    }    
}

