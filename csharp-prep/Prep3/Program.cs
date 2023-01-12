using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        Random randomNumber = new Random();
        
        string keepPlay = "yes";

        while (keepPlay == "yes")
        {
            int number = randomNumber.Next(1, 101);

            int numberGuess = -1;
            int guessNumber = 0;
            
            while (number != numberGuess)
            {
                Console.Write("What is your guess? ");
                numberGuess = int.Parse(Console.ReadLine());
                guessNumber += 1;
                
                if (numberGuess < number){
                Console.WriteLine("Higher");
                }
                else if (numberGuess > number){
                    Console.WriteLine("Lower");
                }
                else {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessNumber} guesses");
            
            Console.Write("Would you like to play again (yes/no)? ");
            keepPlay = Console.ReadLine();

        Console.WriteLine("Thank you for playing. Goodbye.");    
        }    
    } 
}