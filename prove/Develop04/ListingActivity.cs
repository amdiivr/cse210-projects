public class ListingActivity : Activity
{
    public ListingActivity(string welcome, string propose, string questionActivity) : base(welcome, propose, questionActivity){}

    public void GetListingQuestion()
    {
        List<string> promptList = new List<string>();
        promptList.Add(" --- When have you felt the holy Ghost this month? --- ");
        promptList.Add(" --- Who are people that you appreciate? --- ");
        promptList.Add(" --- What are personal strengths of yours? --- ");
        promptList.Add(" --- Who are people that you have helped this week? --- ");
        promptList.Add(" --- Who are some of your personal heroes? --- ");

        Random rPrompt = new Random();
        int getRandomPrompt = rPrompt.Next(0, promptList.Count());

        Console.WriteLine(promptList[getRandomPrompt]);
    } 

    public void GetListingTime()
    {
        int inputAnswer = int.Parse(GetInputAnswer());

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(inputAnswer);
        Console.Clear();

        Console.WriteLine("Get ready...");
        DisplayAnimation(4);

    
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        GetListingQuestion();
        Console.Write("You may begin in: ");
        for (int i = 5; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();

        List<string> answers = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            answers.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {answers.Count} items");
        
        Console.WriteLine("\nWell done!!");
        DisplayAnimation(4);

        Console.WriteLine($"\nYou have complete another {inputAnswer} seconds of the Listing Activity");
        DisplayAnimation(4);

        Console.Clear();
    }
}
