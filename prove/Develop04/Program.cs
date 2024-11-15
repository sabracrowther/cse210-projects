using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        string _activityName;

        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity ");
        Console.WriteLine("2. start reflecting avtivity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("\nSelect a coice from the menu: ");

        string _activityChoice = Console.ReadLine();
        
        Console.Write("\n\nHow long, in seconds, would you like this activity to last?  ");
        string _activityDuration = Console.ReadLine();
        
        int _durationInput = int.Parse(_activityDuration); //change user input for choice of activity from string to int
        //string _activityDuration = 
        if (_activityChoice == "1")
        {
            _activityName = "Breathing Activity";
            BreathingActivity breathingActivity = new BreathingActivity(_activityName, _durationInput);
            Console.WriteLine($"activityName is {_activityName}, and activityDuration is {_activityDuration}, activityChoice is {_activityChoice} in program.cs");

            breathingActivity.DisplayWelcomeMessage(_activityChoice);
            breathingActivity.PauseWithSpinner();
            breathingActivity.BreathingAnimation();
            breathingActivity.DisplayEndingMessage();
        }

       // else if (_activity == "2")
        //{
            //ReflectionActivity reflectionActivity = new ReflectionActivity(_activity);
            //reflextionActivity.DisplayWelcomeMessage(_activity);

        //}


        //string duration = activity1.DisplayDurationPrompt();
       // Console.WriteLine($"You entered {duration} seconds for the activity duration.");


    }
}