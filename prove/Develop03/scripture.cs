using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    // set attributes to private
    public Reference Reference { get; set; }
    public List<Word> Words = new List<Word>();
    private string scripture;

    public Scripture(Reference reference, string scripture)
    {
        Reference = reference;
        this.scripture = scripture;
        string[] wordsArray = scripture.Split(" ");
        foreach (string word in wordsArray)
        {
            Word wordObj = new Word(word);
            Words.Add(wordObj);
        }
    }

    // method that returns the scripture string
    public string GetScripture()
    {
        return scripture;
    }

    public List<Word> GetShownWordsList()
    {
        List<Word> visibleWords = new List<Word>();
        foreach(Word word in Words)
        {
            if (word.GetHidden() == false)
            {
                visibleWords.Add(word);
            }
        }

        return visibleWords;
    }
     
    
}