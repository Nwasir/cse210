using System;

class Reference
{
    private string Book;
    private int Chapter;
    private int Verse;
    private int VerseEnd;
    private string referenceStr;
   
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        referenceStr = $"{Book} {Chapter}: {Verse}";
    }
    public Reference(string book, int chapter, int verse, int verseEnd)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        VerseEnd = verseEnd;
        referenceStr = $"{Book} {Chapter}: {Verse} - {VerseEnd}";
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
        return Verse;
    }
    public string GetSummary()
    {
        referenceStr = $"{Book} {Chapter}: {Verse} - {VerseEnd}";
        return referenceStr;
    }
}