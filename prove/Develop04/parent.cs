using System;
class Activity
{
    protected int _duration;
        
    public void EndMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the breathing Activity.");
    }

    public void pauseTimer(int _activationCount)
    {
        int countDown = _activationCount;
        Console.Write("Get ready...\n\n");

        while (countDown > 0)
        {
            Console.Write($"{countDown}");
            countDown--;
            Thread.Sleep(2000);// pause for 2 seconds
            Console.Write("\b \b");
        }

    }
    public  Activity()
    {
        Console.Write("How long in seconds, would you like for your session? ");
        string text = Console.ReadLine();
        int q = int.Parse(text);
        _duration = q;        
    }
    
}