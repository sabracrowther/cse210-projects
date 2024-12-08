using System;

public class ListingActivity
{
    private Animation _animation = new Animation();
    private string _prompt;
    private Random rand = new Random();
    private ActivityLibrary library = new ActivityLibrary();
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string _activityType = "Listing";
    private int _minDuration = 5;
    //empty new
    public ListingActivity() : base()
    {
        _description = description;
        _activityType = activityType;

        
    }
}