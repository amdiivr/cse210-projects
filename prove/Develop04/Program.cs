using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Develop04 World!");

        string input = "";
        
        while(input != "4")
        {
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("\t1. Start breathing activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                BreathingActivity prompt1 = new BreathingActivity("Welcome to the Breathing Activity.", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "How long, in seconds, would you like for your session? ");
                Console.Write(prompt1.GetPrologue());
                prompt1.GetBreathingTime();
            } 
            else if (input == "2")
            {
                Console.Clear();
                ReflectingActivity prompt2 = new ReflectingActivity("Welcome to the Reflecting Activity.","This activity will help you reflect on times in your life when shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.","How long, in seconds, would you like fo your session? ");
                Console.Write(prompt2.GetPrologue());
                prompt2.GetReflectingTime();
            }
            else if (input == "3")
            {
                Console.Clear();
                ListingActivity prompt3 = new ListingActivity("Welcome to the Listing Activity.","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.","How long, in seconds, would you like for your session? ");
                Console.Write(prompt3.GetPrologue());
                prompt3.GetListingTime();
            }
        }

    }
}