using System;

public class ListingActivity
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
        

        
    }
}