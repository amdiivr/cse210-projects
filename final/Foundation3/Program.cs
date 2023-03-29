using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello Foundation3 World!");

        Console.WriteLine("\n----------------- Standard details -----------------!");

        Event firstEvent = new Event("Friday Party", "This is the party of the weekend.", "23/04/2023", "18:00PM", "Av. Las Esmeraldas #1053");
        firstEvent.GetStandardInfo();

        Console.WriteLine("\n----------------- Full details -----------------!");

        Lecture firstEventLecture = new Lecture("Halloween Event", "The new way to celebrate Halloween.", "10/05/2023", "20:00PM", "Jr.Cuzco #2618", "Antonella Hidalgo", 40);
        firstEventLecture.GetStandardInfo();
        Console.WriteLine(firstEventLecture.GetLecture());

        Console.WriteLine("\n----------------- Short description -----------------!");

        Reception firstReception = new Reception("Jinkana on Saturdays", "Games to spend with family.", "18/06/2023",
        "16:00PM", "Av. Jose carlos Mariategui #3250", "Confirm reception");
        firstReception.ShortDescription("Reception");

        Console.WriteLine("\n----------------- Full details -----------------!");

        OutdoorGathering firstOutdoorGathering = new OutdoorGathering("Youth football championship", "Soccer game between company employees.", "05/04/2023","15:00PM", "Cll. Estadio Nacional #4030", 28);
        firstOutdoorGathering.GetStandardInfo();
        Console.WriteLine("Weather Broadcast: " + firstOutdoorGathering.GetWeatherInfo() + "ºC");
    }
}