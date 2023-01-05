using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";

        int lastDigit = number % 10; 

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (number >= 93)
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }


        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations you have passed the course.");
        }
        else
        {
            Console.WriteLine("You must have at least a 70 to pass the class");
            Console.WriteLine("Keep going and don't give up");
        }
    }
}