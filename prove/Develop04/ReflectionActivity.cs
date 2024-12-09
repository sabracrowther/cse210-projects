using System;

public class ReflectionActivity : Activity
{
    private string _prompt;
    private string _question;
    private Animation _animation = new Animation();    
    private Random rand = new Random();
    private ActivityLibrary library = new ActivityLibrary();
    private string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string activityType = "Reflection";
    private int minDuration = 10;

     public ReflectionActivity() : base()
    {
        _description = description;
        _activityType = activityType;
        _minDuration = minDuration;
        GetRandomPrompt();

        WelcomeMessage();

        _animation.GetReady();        
    }

    private void GetRandomPrompt()
    {
        int idx = rand.Next(library.reflectionPrompts.Count);
        _prompt = library.reflectionPrompts[idx];
    }

    private void GetRandomQuestion()
    {
        int idx = rand.Next(library.reflectionQuestions.Count);
        _question = library.reflectionQuestions[idx];
    }

    public void Animation()
    {
        DateTime startAnimation = DateTime.Now;
        DateTime stopAnimation = startAnimation.AddSeconds(_activityDuration);
        TimeSpan elapsedTime;
        int numQuestions = 0; //must prompt at least 1 question
        
        Console.Write(stopAnimation);
         while (DateTime.Now < stopAnimation)
        {
            //prompt a reflection
            Console.WriteLine("\nConsider the following: ");
            Console.WriteLine($"\n ---- {_prompt} ----");
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            ConsoleKeyInfo keyInfo = Console.ReadKey(); //get enter when they are ready to start
            while(keyInfo.Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\nPress enter when you are ready.");
                keyInfo = Console.ReadKey();
            }

            //ponder random questions
            Console.Clear();
            Console.WriteLine($"\n ---- {_prompt} ----");
            Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
            Console.Write("\nYou may begin in: ");
            _animation.PauseWithCountdown(5);
            
            //prompt questions until time runs out
            while(DateTime.Now < stopAnimation || numQuestions ==0)
            {
                GetRandomQuestion();
                Console.WriteLine($"\n{_question}");
                _animation.PauseWithSpinner(5); // gives them 5 seconds to think
                numQuestions++; //number of questions increments
            }
                 
        }
       
        //exit main timer
        elapsedTime = DateTime.Now.Subtract(startAnimation);
        _minDuration = elapsedTime.Seconds;
        DisplayEndingMessage();

    }


}