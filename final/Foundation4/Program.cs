using System;

class Program
{
    static void Main(string[] args)
    {
        //private List<Activity> activities = new List<Activity>();
        // create some activities
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 15.0);
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);
        
        // add them to a list
        Activity[] activities = {running, cycling, swimming};
              
        // display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
