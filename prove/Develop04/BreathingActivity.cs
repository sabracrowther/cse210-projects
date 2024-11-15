using System;

public class BreathingActivity : Activity
{
    
     public BreathingActivity( string activityName, int activityDuration) : base(activityName, activityDuration)
    {
        
    }
    
    public void BreathingAnimation()
    {
        

        DateTime startAnimation = DateTime.Now;
        DateTime stopAnimation = startAnimation.AddSeconds(_activityDuration);
        Console.WriteLine($"the duration time is {_activityDuration} in breathingAnimation");

        while (DateTime.Now < stopAnimation)
        {
            Console.Write("\nBreathe in...  ");
            for (int j = 5; j > 0; j--)
            {
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();

            Console.Write("Breathe out...  ");
            for (int k = 5; k > 0; k--)
            {
                Console.Write(k);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
                
            
       
            }
    }

}