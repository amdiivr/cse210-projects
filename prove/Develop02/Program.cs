using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal jou1 = new Journal();
        jou1._write = "Write";
        jou1._display = "Display";
        jou1._load = "Load";
        jou1._save = "Save";
        jou1._quit = "Quit";

        jou1.Menu();

        Entry prom1 = new Entry();
        prom1._prompts = "Who was the most interesting person I interacted with today?";

        Entry prom2 = new Entry();
        prom2._prompts = "What was the best part of my day?";

        Entry prom3 = new Entry();
        prom3._prompts = "How did I see the hand of the Lord in my life today?";

        Entry prom4 = new Entry();
        prom4._prompts = "What was the strongest emotion I felt today?";

        Entry prom5 = new Entry();
        prom5._prompts = "If I had one thing I could do over today, what would it be?";

        PromptGenerator random = new PromptGenerator();
        random._randomPrompt.Add(prom1);
        random._randomPrompt.Add(prom2);
        random._randomPrompt.Add(prom3);
        random._randomPrompt.Add(prom4);
        random._randomPrompt.Add(prom5);

        random.Display();

    }
}