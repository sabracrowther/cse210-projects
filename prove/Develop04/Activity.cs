using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Activity
{
    protected string _description;
    protected string _activityType;
    protected int _activityDuration;
    protected int _minDuration;
    //protected List<string> _clockAnimationString;
    private Animation _animation = new Animation();
    protected Activity() //empty default constructor
    {

    }
    public string ActivityType
    {
        get => _activityType;
    }
    public string Description
    {
        get => _description;
    }
    public int Duration
    {
        get => _activityDuration;
    }
    public void WelcomeMessage()
    {
        Console.Clear();
        string str = $"Welcome to the {_activityType} \n{_description}";
        Console.WriteLine(str);
        GetDurationInput();
        Console.WriteLine("Get Ready...");
        _animation.PauseWithSpinner();        
    }

    protected void GetDurationInput()
    {
        Console.WriteLine($"The minimum duration for this activity is {_activityDuration} seconds");
        Console.Write("\nHow long, in seconds, would you like this activity to last? ");
        string instr = Console.ReadLine();
        _activityDuration = int.Parse(instr); // change user input from string to int
        SetMinDuration();
    }

    protected void SetMinDuration()
    {
        if (Duration < _minDuration)
        {
            _activityDuration = _minDuration; //if input user wants for duration of activity is less then the minimun reset it to the minimun duration time
            Console.WriteLine($"The minimum duration for this activity is {_activityDuration} seconds");
        }
    }
    
    public void PauseWithCountdown()
    {
        

        for (int j = 5; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
       
        Console.WriteLine($"activity duration is {_activityDuration} in Activity pause with countdown method");       
       
    }

    public void DisplayEndingMessage()
    {
        
        Console.WriteLine("\n\n\nWell done!!");
        _animation.PauseWithSpinner();
        Console.WriteLine($"\n\nYou have completed another {_activityDuration} seconds of the {_activityType}.");
        _animation.PauseWithSpinner();
        Console.WriteLine();
    }
}