using System;

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
        while (startAnimation < stopAnimation)
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


}