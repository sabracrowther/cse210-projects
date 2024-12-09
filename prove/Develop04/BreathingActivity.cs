using System;

public class BreathingActivity : Activity
{
    private Animation _animation = new Animation();
    private string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string activityType = "Breathing";
    private int minDuration = 10;
     public BreathingActivity() : base()
    {
        _description = description;
        _activityType = activityType;
        _minDuration = minDuration;
        WelcomeMessage(); //display welcome message and get duration time  
        _animation.GetReady();      
    }
    
    public void Animation()
    {
        DateTime startAnimation = DateTime.Now;
        DateTime stopAnimation = startAnimation.AddSeconds(_activityDuration);
        TimeSpan elapsedTime;
        int iLoop = 0;
        

        while (DateTime.Now < stopAnimation || iLoop == 0)
        {
            Console.Write("\nBreathe in...  ");
            _animation.PauseWithCountdown();
            Console.WriteLine();

            Console.Write("Breathe out...  ");
             _animation.PauseWithCountdown();  

            iLoop++;
        }

        elapsedTime = DateTime.Now.Subtract(startAnimation);
        _minDuration = elapsedTime.Seconds;
        DisplayEndingMessage();
    }

}