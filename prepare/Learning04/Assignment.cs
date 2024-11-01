

using System.Diagnostics.Contracts;

public class Assignment
{
    protected string _name = "";
    protected string _topic = "";

    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    } 

    public string GetName()
    {
        return _name;
    }

    public string GetTopic()
    {
        return _topic;
    }
   
    public string GetSummary()
    {
        return $"{_name}, {_topic}";
        
    }
}