using System;

class Listing : Activity
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
    public Listing() : base()
    {
        //_duration = duration;
    }

    public void Run()
    {
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("Press enter when you have something in mind");
        string input = Console.ReadLine();
        List<string> items = new List<string>();
        int i = _duration;
        
        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).TotalSeconds < i)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
            {
                break;
            }
            items.Add(item);
        }
        Console.WriteLine($"You listed {items.Count} items.");
        Console.Write(".");
        Thread.Sleep(4000);

    }
}