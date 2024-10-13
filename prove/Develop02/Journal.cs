using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>(); // initialize a new entries list
    }
    public void DisplayMenu()
    {        
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do?");

        string _menuOptionChosen = Console.ReadLine();

        while (_menuOptionChosen != "5")
        {
            switch (_menuOptionChosen)
            {
                case "1":
                    AddNewEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    entries = LoadEntriesFromFile(); // put entries from file onto list
                    break;
                case "4":
                    SaveEntriesToFile();
                    break;
                default:
                    Console.WriteLine("Option not valid. Please select a valid option.");
                    break;
            }           
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");

             _menuOptionChosen = Console.ReadLine();
        }
        
    }

    public void AddNewEntry()
    {   
        Prompts prompts = new Prompts(); // create a new Prompts object
        
        string prompt = prompts.GetRandomPrompt();  // get random prompt
        Console.WriteLine(prompt);   // display random prompt
        string _entryInput = Console.ReadLine();  //save new entry 

        Entry newEntry = new Entry
        {
            _date = DateOnly.FromDateTime(DateTime.Now),
            _prompt = prompt,
            _entry = _entryInput 
        };

        entries.Add(newEntry); //add the new entry to the list            
        
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry._date} -  Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._entry}");
        }
    }

    public void SaveEntriesToFile()
    {
        Console.WriteLine("Saving entry to file...");
        Console.WriteLine("Which file would you like to save to?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries) 
            {
                outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._entry}");
            }
        }

    }

    public List<Entry> LoadEntriesFromFile()
    {
        Console.WriteLine("Which file would you like to load from?");
        string filename = Console.ReadLine();

        List<Entry> entriesInFile = new List<Entry>();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            Entry newEntry = new Entry
            {
                _date = DateOnly.Parse(parts[0]),
                _prompt = parts[1],
                _entry = parts[2]
            };

            entriesInFile.Add(newEntry);

        }
        return entriesInFile;
    }
        
        
}
