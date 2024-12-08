using System;

public class Reference
{
    private static string _verseCitation; //formatted verse citation for one or more verses
    public string Text{             //read only text
        get => _verseCitation;
    }  //read only

    public Reference(){     //empty constructor
        _verseCitation = "";
    }

    public Reference(string book, int chapter, int verseNum){ //one verse
        SetForOne(book, chapter, verseNum);
    }

    public Reference(string book, int chapter, int verseNumBegin, int verseNumEnd){//multiple verses
        if (verseNumBegin == verseNumEnd) {//jic someone sends in one verse
            SetForOne(book, chapter, verseNumBegin);
        } else {//verse range
            _verseCitation = book + " " + chapter + ":" + verseNumBegin +"-" + verseNumEnd; 
        }
    }

    private void SetForOne(string book, int chapter, int verseNum){ //one verse
        _verseCitation = book + " " + chapter + ":" + verseNum;
    }
    
}