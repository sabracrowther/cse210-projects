using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magNum = randomGenerator.Next(1, 101);
        Console.WriteLine("Guess the magic number. ");
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());


            if (guess < magNum)
            {
                Console.WriteLine("Higher ");
            }
            else if (guess > magNum)
            {
                Console.WriteLine("Lower ");
            }
            else
            {
                Console.Write("You guessed it!");
            }

        }while (guess != magNum);
        
    }
}