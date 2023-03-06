using System;
class Activity
{
    protected int _duration;
    public int _countDown;
    public string _firstQuestin;
    
    public void DisplayFirstQuestion(string question)
    {

        //Console.WriteLine($"This activity will last for {Duration} seconds.");

    }
    public void EndMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the breathing Activity.");
    }

    public void pauseTimer(int _activationCount)
    {
        int countDown = _activationCount;
        Console.WriteLine("Get ready.....\n");

        while (countDown > 0)
        {
            Console.Write(countDown);
            countDown--;
            Thread.Sleep(2000);// pause for 2 seconds
            Console.Write("\b \b");
        }

    }
    public  Activity()
    {
        Console.WriteLine("How long in seconds, would you like for your session? ");
        string text = Console.ReadLine();
        int q = int.Parse(text);
        _duration = q;        
    }
    
}