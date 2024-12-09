using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start Breathing Activity ");
        Console.WriteLine("2. start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("\nSelect a choice from the menu: ");

        string _activityChoice = Console.ReadLine();

        //Animation animation = new Animation();

        while (_activityChoice != "4")
        {
            switch (_activityChoice)
            {
                case "1": //breathing
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Animation();
                    break;
                case "2": // reflecting
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Animation();
                    break;
                case "3": //listing
                    ListingActivity listing = new ListingActivity();
                    listing.Animation();
                    break;
                case "4": //quit
                    Console.WriteLine("Have a blessed day!");
                    break;
                default:
                    Console.WriteLine("Invalid entry.");
                    break;
            }
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity ");
            Console.WriteLine("2. start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            _activityChoice = Console.ReadLine();        

        }
        
    }
}