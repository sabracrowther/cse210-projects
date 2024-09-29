using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome(); // call display welcome message function
        string userName = PromptUserName(); // call function to get users name
        int favNum = PromptUserNumber(); //call function to get users favorite number
        int squaredNum = SquareNumber(favNum);
        DisplayResult(userName, squaredNum); // call function display name and squared number

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    } 

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
        
    }   

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
         
    }   

    static int SquareNumber(int num)
    {
    
        return num * num;
    } 
    
    static void DisplayResult(string name, int sqNum)
    {
        
        Console.WriteLine($"{name}, the square of your number is {sqNum}");
    }
}