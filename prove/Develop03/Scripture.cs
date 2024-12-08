using System;
public class Scripture
{
    private List<Word> _wordList = new List<Word>();
    private string _scriptureText;
    private int _countOfWords;
    private bool _allHidden;


    public string Text
    {
        get=> _scriptureText;
    }
    public int CountOfWords
    {
        get => _countOfWords;
    }

    public bool AllHidden{
        get => _allHidden;
    }
    

    public Scripture(string scriptureText)
    {
        _scriptureText = scriptureText.Trim();
        ParseToWords();
    }

     public void ParseToWords()
    {
        string[] words = _scriptureText.Split(' ');
        foreach(string str in words)
        {
            
            _wordList.Add(new Word(str));
          
        }
        _countOfWords = _wordList.Count;
        
    }

    private void HideOneWordAndResetText(int indexToHide)
    {
        _wordList[indexToHide].Hide();
        ResetScriptureText();
    }    
   
    public void HideRandomWords()
    {

        List<int> indexOfUnHiddenWords = new List<int>();
        for (int idx = 0; idx < _wordList.Count; idx++)
        {
            if (_wordList[idx].IsHidden == false)
            {
                indexOfUnHiddenWords.Add(idx);
            }
        }

        if (indexOfUnHiddenWords.Count > 0)
        {
            Random rnd = new Random();
            int r = rnd.Next(indexOfUnHiddenWords.Count());
            HideOneWordAndResetText(indexOfUnHiddenWords[r]);
        } else
        {
            _allHidden = true;
        }      

    }

    public void HideThreeWords()
    {
        HideRandomWords();
        HideRandomWords();
        HideRandomWords();
    }
    private void ResetScriptureText()
    {
        List<string> strArray = _wordList.ConvertAll(wordElement => wordElement.Text).ToList();
        _scriptureText = string.Join(" ", strArray);
    }
}

