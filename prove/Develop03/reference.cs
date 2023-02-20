using System;
using System.Collections.Generic;
using System.Linq;

class Reference
{
    private string Book;
    private int Chapter;
    private int Verses;  

          
    /*public List<Word> words = new List<Word>(new string[]
    {
        "Trust", "in", "Lord", "with", "all", "thine", "heart", "and", "lean", 
        "not", "unto", "thine", "own","understanding;", "in", "all", "thy", "ways",
        "acknowledge", "him", "him,", "and", "he", "shall", "direct",
        "thy", "paths."
    });*/

    public Reference(string book, int chapter, int verses)
    {
        Book = book;
        Chapter = chapter;
        Verses = verses;
    }

    public string GetBook()
    {
        return Book;
    }
    public int GetChapter()
    {
        return Chapter;
    }
    public int GetVerses()
    {
        return Verses;
    }
}