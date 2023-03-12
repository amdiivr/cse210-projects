public class ListGoal : Goal
{
    List<string> _list = new List<string>();
    public ListGoal(string name, string description, int points) : base (name, description, points)
    {}

    public override string SetGoal()
    {
        Console.Write("What is the name of your goal? ");
        string inputName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string inputDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int inputPoint = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int inputBonus = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int inputTimes = int.Parse(Console.ReadLine());
        string concatenate = $"2. [ ] {inputName},({inputDescription}), --- Currently completed: 0/{inputTimes}";
        return concatenate;
    }

    public void GetPerson(string peron)
    {
        _list.Add(peron);
    }

    public void GetList()
    {
        foreach(string cola in _list)
        {
            Console.WriteLine(cola);
        }
    } 
}