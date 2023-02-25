using System;

public class Activity
{
    private string _welcome;
    private string _propose;
    private string _questionActivity;
    private string _input;
    
    public Activity(string welcome, string propose, string questionActivity)
    {
        _welcome = welcome;
        _propose = propose;
        _questionActivity = questionActivity;
    }
    public string GetWelcome()
    {
        return _welcome;
    }

    public string GetPropose()
    {
        return _propose;
    }

    public string GetQuestionActivity()
    {
        return _questionActivity;
    }

    public string GetPrologue()
    {
        string prologue = $"\n{_welcome}\n\n{_propose}\n\n{_questionActivity}";
        return prologue;

    }

    public void DisplayAnimation(int time)
    {
        for (int i = 0; i < time; i++)
        {
            Console.Write("-");
            Thread.Sleep(300);
            
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }

    public string GetInputAnswer()
    {
        _input = Console.ReadLine();
        return _input;
    }
}