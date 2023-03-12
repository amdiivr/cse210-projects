using System;
using System.IO;

public class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual string SetGoal()
    {
        Console.Write("What is the name of your goal? ");
        string inputName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string inputDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int inputPoint = int.Parse(Console.ReadLine());
        string concatenate = $"1. [ ] {inputName},({inputDescription})";
        return concatenate;
    }
}