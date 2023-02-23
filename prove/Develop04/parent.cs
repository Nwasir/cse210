using System;
class Parent
{
    protected int Duration;

    public Parent(int duration)
    {
        Duration = duration;
    }


    public void DisplayPrompts()
    {
        Console.WriteLine("Get Ready...");
        //Console.WriteLine($"This activity will last for {Duration} seconds.");
    }
    public void Finish()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {Duration} seconds of the breathing Activity.");
    }
}