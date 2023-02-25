public class ReflectingActivity : Activity
{
    public ReflectingActivity(string welcome, string propose, string questionActivity) : base(welcome, propose, questionActivity){}

    public void GetReflectingQuestion()
    {
        List<string> promptList = new List<string>();
        promptList.Add("\n --- Thing of time when you did something really difficult. --- ");
        promptList.Add("\n --- Think of a time when you stood up for someone else. --- ");
        promptList.Add("\n --- Think of a time when you helped someone in need. --- ");
        promptList.Add("\n --- Think of a time when you did something truly selfless. --- ");

        Random rPrompt = new Random();
        int getRandomPrompt = rPrompt.Next(0, promptList.Count());

        Console.WriteLine(promptList[getRandomPrompt]);
    }

    public void GetReflectingTime()
    {
        int inputAnswer = int.Parse(GetInputAnswer());

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(inputAnswer);
        Console.Clear();

        Console.WriteLine("Get ready...");
        DisplayAnimation(4);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nConsider the following prompt:");
            
            GetReflectingQuestion();
            
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();
            
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");

            for (int i = 5; i >= 1; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.Clear();

            Console.Write("> How did you feel when it was complete? ");
            DisplayAnimation(10);

            Console.Write("\n> What is your favorite thing about this experience? ");
            DisplayAnimation(10);
        }

        Console.WriteLine("\n\nWell done!!");
        DisplayAnimation(4);

        Console.WriteLine($"\nYou have complete another {inputAnswer} seconds of the Reflecting Activity");
        DisplayAnimation(4);

        Console.Clear();
    }
}

