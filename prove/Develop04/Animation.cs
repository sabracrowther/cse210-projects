using System;
using System.ComponentModel;

public class Animation{
    private string[] _clockAnimationString = {"|", "/", "-", "\\", "|", "-", "\\"};


    public void PauseWithSpinner()
    {
        PauseWithSpinner(4);
    }

    public void PauseWithSpinner(int numSeconds)
    {
        DateTime startAnimation = DateTime.Now;
        DateTime stopAnimation = startAnimation.AddSeconds(numSeconds);
        int i = 0;
        while (DateTime.Now < stopAnimation)
        {
            Console.Write(_clockAnimationString[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= _clockAnimationString.Count())
            {
                i=0;
            }
        }
    }

    public void PauseWithCountdown()
    {
        PauseWithCountdown(4);
    }

    public void PauseWithCountdown(int Seconds)
    {
        for (int j = Seconds; j > 0; j--)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (j > 9)
            {
                Console.Write("\b \b");
            }
        }
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        PauseWithSpinner();
    }


}