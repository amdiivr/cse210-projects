using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        string input = "";

        string inputGoal = "";

        string fileName = "";

        while(input != "6")
        {
            Console.WriteLine("\nYou have  points.");

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("The types of Goals are");
                Console.WriteLine("\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                inputGoal = Console.ReadLine();

                if (inputGoal == "1")
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        Goal goal = new Goal("name", "description", 0);
                        outputFile.WriteLine(goal.SetGoal());
                    }
                }
                else if (inputGoal == "2")
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        EternalGoal eternalGoal = new EternalGoal("name", "description", 0);
                        outputFile.WriteLine(eternalGoal.SetGoal());
                    }
                }
                else if (inputGoal == "3")
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        ListGoal listGoal = new ListGoal("name", "description", 0);
                        outputFile.WriteLine(listGoal.SetGoal());
                    }
                }
            }
            else if (input == "2")
            {   
                    string[] lines = System.IO.File.ReadAllLines(fileName);foreach (string line in lines)
                    {
                        if (inputGoal == "1" || inputGoal == "2")
                        {
                            string [] parts = line.Split(",");   
                            string name = parts[0];
                            string description = parts[1];
                            Console.WriteLine($"{name} {description}");
                        }
                        else
                        {
                            string [] parts = line.Split(",");   
                            string name = parts[0];
                            string description = parts[1];
                            string times = parts[2];
                            Console.WriteLine($"{name} {description} {times}");  
                        }
                        
                    }          
            }
        }

    }   
}
