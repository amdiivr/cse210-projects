using System;

public class Word 
{
    private string _random = "random";

    public string HideWord(string scripture)
    {
        Random random = new Random();
        
        string[] words = scripture.Split(" ");
        int hideWords = random.Next(1, words.Length);
        words[hideWords] = "_";

        string alteredVerse = "";

        foreach(var part in words) {
            alteredVerse += part + " ";
        }
        return alteredVerse;
    }
}