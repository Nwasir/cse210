using System;
class Entry
{
    public string _answer;
    public string _date;
    public string _prompt;
    DateTime theCurrentTime = DateTime.Now;

    public void write()
    {
        List<string> promptList = new List<string>(new string[]
        {
             "If i had one thing i could do over today, what would that be? ",
              "What was the best part of my life today? ",
              "The lesson i learned today? " });

        Random R = new Random();

        // get random number from 0 to 2.
        _date = theCurrentTime.ToShortDateString();
        int someRandomNumber = R.Next(0, promptList.Count());
        _prompt = promptList.ElementAt(someRandomNumber);
        Console.WriteLine(_prompt);
        _answer = Console.ReadLine();
    }
    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_answer);
    }
}




