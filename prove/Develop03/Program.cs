using System;
using System.Collections;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("Matthew", 2, 10, 12);
        Scripture s = new Scripture("But glory, honour, and peace, to every man that worketh good...");
      
        Console.Clear();
        Console.Write($"{r.Text}  {s.Text} \n");
        

        
        
        Console.WriteLine("Press 1. to add your own scripture. ");
        Console.WriteLine("Press 2. to memorize a scripture. ");
        Console.Write("Press 3. 'quit' to quit. ");
        string instr = Console.ReadLine().ToString();
        switch (instr) //main menu
        {
            case "1":  //add a scripture
                Console.WriteLine("You chose to add a scripture.");
                Console.WriteLine("Please enter the book where your scripture comes from: ");
                string book = Console.ReadLine();
                Console.WriteLine("Please enter the chapter your verse(es) are in.");
                int chapter = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the starting verse of your scripture.");
                int startVerse = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the ending verse. If it is only one verse, enter the verse number again. ");
                int endVerse = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter the text of your verse(s)");
                string scriptureText = Console.ReadLine();
                Reference userR = new Reference(book, chapter, startVerse, endVerse);
                Scripture userS = new Scripture(scriptureText);
                MemorizeScripture(userR, userS);
                break;
            case "2": //memorize scripture
                MemorizeScripture(r, s);
                break;
            case "3": //quit the program
            default:
                break;

        }
       
    } 

    public static void MemorizeScripture(Reference r, Scripture s)
    {
        string instr = "";
        Console.WriteLine(instr); 
        while (instr == "")
        {
            while (instr !="quit")
            {
                Console.Clear();
                s.HideThreeWords();
                Console.Write($"{r.Text}  {s.Text} \n");
                Console.Write("Press enter or type 'quit' ");
                instr = Console.ReadLine();
                if (s.AllHidden == true)
                {
                    instr = "quit";
                }
            }                
        } 
    }
       
}