using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        string input = "";

        string inputGoal = "";

        while(input != "6")
        {
            Console.WriteLine("\nYou have 0 points.");

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

                string filename = "myFile.txt";

                if (inputGoal == "1")
                {
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        Goal goal = new Goal("name", "description", 0);
                        outputFile.WriteLine(goal.SetGoal());
                    }
                }
                else if (inputGoal == "2")
                {
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        EternalGoal eternalGoal = new EternalGoal("name", "description", 0);
                        outputFile.WriteLine(eternalGoal.SetGoal());
                    }
                }
                else if (inputGoal == "3")
                {
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        ListGoal listGoal = new ListGoal("name", "description", 0);
                        outputFile.WriteLine(listGoal.SetGoal());
                    }
                }
            }
            else if (input == "2")
            {
                    string filename = "myFile.txt";
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    
                    foreach (string line in lines)
                    {
                        System.Console.WriteLine(line);
                    }
                        
            }          
        }
    }

}   

