using System;

class Listing : Parent
{
    private static Random random = new Random();
    private static List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public Listing(int duration) : base(duration)
    {
        Duration = duration;
    }
    public void Run()
    {
        DisplayPrompts();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Starting in...");
        for (int i = 3; i >= 1; i--)
        {
            Console.WriteLine(i + "...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Go!");
        List<string> items = new List<string>();
        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).TotalSeconds < Duration)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
            {
                break;
            }
            items.Add(item);
        }
        Console.WriteLine($"You listed {items.Count} items.");
        Finish();
    }
}