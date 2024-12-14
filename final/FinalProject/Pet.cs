using System;
using System.ComponentModel;

public class Pet
{
    protected string _name;
    protected string _petType;
    protected string _color;
    protected string _description;
    //set Lists to private so they can't be changed
    private List<string> _movements;
    private List<string> _interactions;
    private List<string> _bodyFeatures;
    private List<string> _vocalizations;

    public Pet() //default constructor
    {        
        //minimum for any type of animal
        _movements = new List<string> {"eat", "sleep"};
        _interactions = new List<string> {"watch"};
        _bodyFeatures = new List<string> {"eyes", "head"};
        _vocalizations = new List<string> {""};  //none is default        
    }

    public string Color{
        get => _color;
    }

    public string Petype
    {
        get => _petType;
    }

    public string Name
    {
        get => _name;
    } 

    public List<string> Movements
    {
        get => _movements;
    }

    public List<string> Interactions
    {
        get => _interactions;
    }

    public List<string> BodyFeatures
    {
        get => _bodyFeatures;
    }

    public List<string> Vocalizations
    {
        get => _vocalizations;
    }

    protected void AddMovements(string[] movementStrArray)
    {
        _movements.AddRange(movementStrArray.ToList());
    }

    protected void AddMovements(List<string> movementList)
    {
        _movements.AddRange(movementList);
    }

    protected void AddInteractions(string[] strArray)
    {
        _interactions.AddRange(strArray.ToList());
    }

    protected void AddInteractions(List<string> strList)
    {
        _interactions.AddRange(strList);
    }

     protected void AddBodyFeatures(string[] strArray)
    {
        _bodyFeatures.AddRange(strArray.ToList());
    }

    protected void AddBodyFeatures(List<string> strList)
    {
        _bodyFeatures.AddRange(strList);
    }

    protected void ReplaceVocalizations(string[] strArray)
    {
        _vocalizations.AddRange(strArray.ToList());
    }

    protected void ReplaceVocalizations(List<string> strList)
    {
        _vocalizations.AddRange(strList);
    }

   
    public virtual string GetPetInfo()
    {
        return $"Your pet's name is {_name}, it is a {_petType}, and it is {_color}.";
    }

}