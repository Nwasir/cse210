using System;
class Breathing : Activity {
    public Breathing() : base() {
        //_duration = duration;
    }

    public void StartActivity() {
        
        //for (int i = 0; i < _duration; i++) 
        int i = _duration;
        //while (i > 0)
        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).TotalSeconds < i)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000); // Pause for 4 seconds
            Console.WriteLine("Breathe out...");
            Thread.Sleep(4000); // Pause for 6 seconds
            i --;
        }
        Console.Write(".");
        Thread.Sleep(4000);
    }
}