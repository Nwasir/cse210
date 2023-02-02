using System;
using System.IO;
using System.Text;

class Journal
{
    public List<Entry> entryList = new List<Entry>();
    //DateTime theCurrentTime = DateTime.Now;
    //string dateText = theCurrentTime.ToShortDateString();
    string filename;
    public void write()
    {
        Entry myEntry = new Entry();
        myEntry.write();
        entryList.Add(myEntry);
    }
    

    public void SaveToFile()
    {
        //foreach (string )
        Console.WriteLine("enter the filename ");
        filename = Console.ReadLine();
        foreach (Entry entry in entryList)
        {
            using (StreamWriter outputFile = new StreamWriter(filename, append: true))
            {
                outputFile.WriteLine($"{entry._date}");
                outputFile.WriteLine($"{entry._prompt}");
                outputFile.WriteLine($"{entry._answer}");
            }
        }


    }
    public void LoadFromFile()
    {
        //foreach (string )
        Console.WriteLine("Enter the filename ");
        filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        entryList.Clear();
       for (int x = 0; x < lines.Count(); x +=3 )
       {
        Entry myEntry = new Entry();
        myEntry._date = lines[x];
        myEntry._prompt = lines[x + 1];
        myEntry._answer = lines[x + 2];

        myEntry.Display();
       }

    }

    public void Display()
    {        
        foreach (Entry answers in entryList)
        {
            answers.Display();
        }
    }
}