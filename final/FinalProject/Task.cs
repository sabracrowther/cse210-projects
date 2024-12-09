using System;
using System.ComponentModel;

public class Task
{
    private string _description = "pick up everything on my floor and put it away";
    private string _type = "household";
    private string _name = "clean my room";
    private int _timeToComplete = 15;
    private bool _isComplete;
    

    public Task()
    {
        
    }

    public string GetDescrition
    {
        get => _description;
    }

    public string GetTaskType
    {
        get => _type;
    }

    public string GetName
    {
        get => _name;
    }

    public bool IsComplete
    {
        get => _isComplete;
    }  

    public int TimeToComplete
    {
        get => _timeToComplete;
    }

    public void GetTask()
    {
        Console.WriteLine($"The task you chose is {_name}, {_type}, {_description}, {_timeToComplete} minutes to complete");
    }


}