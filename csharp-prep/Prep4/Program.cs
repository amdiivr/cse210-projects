using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        // First Part
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();

        int numberUser = -1;

        while (numberUser != 0)
        {
            Console.Write("Enter number: ");
            numberUser = int.Parse(Console.ReadLine());

            if (numberUser != 0)
            {
                numbers.Add(numberUser);
            }
        }

        // Second Part
        int totalNumbers = 0;

        foreach (int number in numbers)
        {
            totalNumbers += number;
        }

        Console.WriteLine($"The sum is: {totalNumbers}");

        // Third Part
        int count = numbers.Count();
        float average = ((float)totalNumbers) / count;

        Console.WriteLine($"The average is: {average}");

        // Fourth Part
        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        
        Console.WriteLine($"The largest number is: {maxNumber}");

        // Fifth Part
        int smallerNumber = 9999; 

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallerNumber)
            {
                smallerNumber = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallerNumber}");
    }
}