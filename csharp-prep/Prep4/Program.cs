using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        List<int> numbers = new List<int>();
        int largestNum = 0;
        int addNums = 0;
        int listNum = -1;
        while (listNum != 0)
        {
            Console.Write("Enter Number: ");
            listNum = int.Parse(Console.ReadLine()); 
            numbers.Add(listNum);         

        }

        foreach (int num in numbers)
        {
            addNums += num;

            if (num > largestNum)
            {
                largestNum = num;
            }

        }
        double average = (double)addNums / (numbers.Count - 1);
       

        Console.WriteLine("The sum is: " + addNums);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("the largest number is: " + largestNum);

    }
}