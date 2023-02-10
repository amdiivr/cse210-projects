using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference reference = new Reference();
        Scripture scripture = new Scripture();
        Word wor = new Word();

        Console.WriteLine("\n" + reference.FormalReference() + scripture.GetScripture() + "\n");

        Console.WriteLine("Press enter  continue or type 'quit' to finish: ");

        string input = "";

        while(input != "quit") {
            
            input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(reference.FormalReference() + wor.HideWord(scripture.GetScripture()));

            Console.WriteLine("\nPress enter  continue or type 'quit' to finish: ");
        }
        Console.WriteLine("Bye!");
    }
}