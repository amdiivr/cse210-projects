using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List <Activity> activityChose = new List<Activity>();

        Running run1 = new Running("03 Nov 2022", 50, 30);
        activityChose.Add(run1);

        StationaryBike bike1 = new StationaryBike("23 Feb 2023", 60, 40);
        activityChose.Add(bike1);

        Swimming swim1 = new Swimming("05 Apr 2023", 30, 50);
        activityChose.Add(swim1);

        foreach (Activity a in activityChose)
        {
            a.GetSummary();
        }

    }
}