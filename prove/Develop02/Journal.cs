using System;

public class Journal
{
    public string _write;
    public string _display;
    public string _load;
    public string _save;
    public string _quit;

    public void Menu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine($"1. {_write}");
        Console.WriteLine($"2. {_display}");
        Console.WriteLine($"3. {_load}");
        Console.WriteLine($"4. {_save}");
        Console.WriteLine($"5. {_quit}");
        Console.Write($"What would you like to do? ");
        string toDo = Console.ReadLine();
    }
}