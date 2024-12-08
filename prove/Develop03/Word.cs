using System;
using System.Dynamic;
public class Word
{
    private string _word;
    private bool isHidden;

    //accessors
    public string Text
    {
        get => _word;
    }
    public bool IsHidden
    {
        get => isHidden;
    } 
    

    public Word(string text) {
        _word = text;
        isHidden = false;
    }

    public void Hide() {
        isHidden = true;
        _word = new string('_', Text.Length);
    }   

}