using System;
using System.Collections.Generic;
using System.Linq;
class Word
{
    public string Text;
    public bool IsHidden {get; set;}

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    /*public string GetText()
    {
        return Text;
    }*/


}