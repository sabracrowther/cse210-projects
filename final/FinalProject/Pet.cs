using System;
using System.ComponentModel;

public class Pet
{
    private string _name = "Fifi";
    private string _petType = "dog";
    private string _color = "brown";
     

    public Pet()
    {
        
    }

    public string GetColor{
        get => _color;
    }

    public string GetPetype
    {
        get => _petType;
    }

    public string GetName
    {
        get => _name;
    }    

    public string SetPetType(string petType)
    {
        _petType = petType;
        return _petType;
    }   


    public void GetPet()
    {
        Console.WriteLine($"The pet you chose is {_name}, it is a {_petType}, and the color is {_color}.");
    }

    public void CreateNewPet()
    {
        Console.Write("What type of pet would you like to create? Dog, Cat, Bird, Hamster, Fish ");
        _petType = Console.ReadLine();
        Console.Write("What color is your pet? ");
        _color = Console.ReadLine();
        Console.Write("What is the name of your pet? ");
        _name = Console.ReadLine();
        Console.WriteLine($"You have created a {_color} {_petType}, named {_name}.");
    }


}