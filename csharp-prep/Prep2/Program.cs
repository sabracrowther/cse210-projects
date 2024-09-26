using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage. ");
        string userInput = Console.ReadLine();
        
        int gradePerc = int.Parse(userInput);
        string letter;

        if (gradePerc <= 100 && gradePerc >= 90)
        {
            letter = "A";
        }
        else if (gradePerc < 90 && gradePerc >= 80)
        {
            letter = "B";
        }
        else if (gradePerc < 80 && gradePerc >= 70)
        {
            letter = "C";
        }
        else if (gradePerc < 70 && gradePerc >= 60)
        {
            letter = "D";
        }
        else if (gradePerc < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");

        if (gradePerc >= 70)
        {
            Console.WriteLine("Congradulations! You Passed!");
        }
        else
        {
            Console.WriteLine("You'll do better next time!");
        }
        
    }
}