using System;
using System.Collections.Generic;
using System.IO;


public class Prompts
{   
    public List<string> prompt;
    private Random random;

    public Prompts()
    {
        prompt = new List<string>  //initialize and populate list of prompts in the constructor
        {
            "Someone I helped today was...",
            "I was happy today when...",
            "Three things I accomplished today was...",
            "Something I did to relax today.",
            "What are some ways I can deepen my relationship with loved ones?",
            "What was at least one goal I had for today?"

        };
        random = new Random();
    }


    public string GetRandomPrompt()
    {
        int randomNum = random.Next(prompt.Count); // generate a random index for list 'prompts'
        return prompt[randomNum];
    }
    
}