using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Activity
{
    protected string _activityName = "";
    protected string _activityChoice = "";
    protected int _activityDuration = 0;
    protected List<string> _clockAnimationString;

    public Activity(string activityName, int activityDuration)
    {
        _activityName = activityName;
        _activityDuration = activityDuration;
        
        
    }

    public string GetActivityName()
    {
        return _activityName;
    }
    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void DisplayWelcomeMessage(string activityChoice)
    {
        
        switch (activityChoice)
        {
            case "1":
                Console.WriteLine("\nWelcome to the Breathing Activity. \n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                break;
            case "2":
                Console.WriteLine("\nWelcome to the Reflection Activity. \n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you hav and how you can use it in other aspects of your life.");
                break;
            case "3":
                Console.WriteLine("\nWelcome to the Listing Activity. \n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                break;
            case "4":
                Console.WriteLine("\nHave a blessed day!");
                break;
            default:
                Console.WriteLine("\nInvalid entry.");
                break;
        }

    }

    public void PauseWithSpinner()
    {
        List<string> clockAnimationString = new List<string>();
        _clockAnimationString.Add("|");
        _clockAnimationString.Add("/");
        _clockAnimationString.Add("-");
        _clockAnimationString.Add("\\");
        _clockAnimationString.Add("|");
        _clockAnimationString.Add("/");
        _clockAnimationString.Add("-");
        _clockAnimationString.Add("\\");

        

        DateTime startAnimation = DateTime.Now;
        DateTime stopAnimation = startAnimation.AddSeconds(5);

        Console.WriteLine("Get ready...");
        int i = 0;
        while (DateTime.Now < stopAnimation)
        {
            string animation = clockAnimationString[i];
            Console.Write(animation);
            Thread.Sleep(800);
            Console.Write("\b \b");

            i++;

            if (i >= clockAnimationString.Count)
            {
                i=0;
            }
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
        PauseWithCountdown();
        Console.WriteLine($"\n\nYou have completed another {GetActivityDuration()} seconds of the {GetActivityName()}.");
    }
}