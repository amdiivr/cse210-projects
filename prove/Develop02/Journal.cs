using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Journal
{
    public List<Entry> _menu = new List<Entry>();
    public string _toDo;
    public string _chooseFile;
    public string _answer = "warehouse.txt";
    public string _readAnswer;
    public void Menu()
    {
        while (_toDo != "5")
        {   
            foreach (Entry menuTotal in _menu)
            {
                menuTotal.Display();
                Console.Write($"What would you like to do? ");
                _toDo = Console.ReadLine();
            }

            if (_toDo == "1")
            {
                AddEntry();
            }
            else if (_toDo == "2")
            {
                DisplayContents();
            }
            else if (_toDo == "3")
            {
                LoadText();
            }
            else if (_toDo == "4")
            {
                FileChoose();
            }
        }
    }

    public void WearHouse()
    {
        if (!File.Exists(_answer))
        {
        File.CreateText(_answer);
        }
    }
    public void AddEntry()
    {
        _readAnswer = Console.ReadLine();
        File.AppendAllText(_answer, $"{_readAnswer}\n");
    }
    
    public void DisplayContents()
    { 
        _readAnswer = File.ReadAllText(_answer);
        Console.WriteLine(_readAnswer);
    }

    public void FileChoose()
    {
        Console.WriteLine("what's the file name?");
        _chooseFile = Console.ReadLine();
        
        if (!File.Exists(_chooseFile))
        {
            File.CreateText(_chooseFile);
        }
    }

    public void LoadText()
    {
        Console.WriteLine("What is the filename");
        _chooseFile = Console.ReadLine();
    }
    
}

