using System;

public class ListingActivity : Activity
{
    private Animation _animation = new Animation();
    private string _prompt;
    private Random rand = new Random();
    private ActivityLibrary library = new ActivityLibrary();
    private string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string activityType = "Listing";
    private int minDuration = 5;
    //empty new
    public ListingActivity() : base()
    {
        _description = description;
        _activityType = activityType;
        _minDuration = minDuration;

        WelcomeMessage();

        Console.WriteLine("Press 1. to add something yourself ");
        Console.WriteLine("   Or 2. to get a random prompt ");
        if (int.Parse(Console.ReadLine()) == 1)
        {
            Console.Write("Please input a good thing in your life to reflect on: ");
            _prompt = Console.ReadLine();
        }else
        {
            Console.WriteLine("Getting random prompt...");
            _animation.PauseWithSpinner();
            GetRandomPrompt();
        }
        
        _animation.GetReady();
        
    }

    private void GetRandomPrompt()
    {
        int idx = rand.Next(library.ListingPrompts.Count);
        _prompt = library.ListingPrompts[idx];
    }

    public void Animation()
    {
        int numEntries = 0;
        DateTime startAnimation = DateTime.Now;
        DateTime stopAnimation = startAnimation.AddSeconds(_activityDuration);
        TimeSpan elapsedTime;

        Console.Clear();
        //prompt user
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"\n ---- {_prompt} ----");
        Console.Write("You may begin in: ");
        _animation.PauseWithCountdown(5);
    

        Console.Clear();
        Console.WriteLine("\n ---- " + _prompt + " ----");  
        Console.WriteLine("\n Please list a response and press enter:");  
        //get their entries; 
        while (DateTime.Now < stopAnimation || numEntries == 0) //get at least one entry or end at max time
        {
            Console.Write("> ");
            //read the line; get the count of lines entered until they hit _duration
            Console.ReadLine();
            numEntries++;   //increament to how many were entered
        } //end getting entries

        //get actual duration
        elapsedTime = DateTime.Now.Subtract(startAnimation);
        _activityDuration = elapsedTime.Seconds;
        Console.WriteLine("\nYou have listed " + numEntries + " of items!");
        DisplayEndingMessage();
    }// end animation


}