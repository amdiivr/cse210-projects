public class BreathingActivity : Activity
{
    public BreathingActivity(string welcome, string propose, string questionActivity) : base(welcome, propose, questionActivity)
    {}

    public void GetBreathingTime()
    {
        int inputAnswer = int.Parse(GetInputAnswer());

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(inputAnswer);
        Console.Clear();

        Console.WriteLine("Get ready...");
        DisplayAnimation(4);

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
        
            for (int i = 4; i >= 1; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            
            Console.Write("\nNow breathe out...");
             
            for (int i = 6; i >= 1; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        
        Console.WriteLine("\n\nWell done!!");
        DisplayAnimation(4);

        Console.WriteLine($"\nYou have complete another {inputAnswer} seconds of the Breathing Activity");
        DisplayAnimation(4);

        Console.Clear();
    }
}