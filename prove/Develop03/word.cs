using System;
using System.Collections.Generic;
using System.Linq;

class Word
{
    private string Text;
    private bool IsHidden;

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public string GetText()
    {
        return Text;
    }

    public bool GetHidden()
    {
        return IsHidden;
    }

    public void SetHidden(bool input)
    {
        IsHidden = input;
    }

    // displayword()
    // if word is hidden
    //      print a _ for each letter in word
    // else
    //      print word
    public void DisplayWord()
    {
        if (IsHidden == true)
        {
            foreach (char letter in Text)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write(Text);
        }

    }
}