using System;

class Program
{
    static void Main(string[] args)
    {
        //Activity myActivity = new Activity();
        Breathing myBreathing = new Breathing();
        Reflection myReflection = new Reflection();
        Listing myListing = new Listing();
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Menu Options:  ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string enter = Console.ReadLine();
            choice = int.Parse(enter);

            if (choice == 1)
            {
                
                Console.WriteLine("Welcome to Breathing activity.\n");
                Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. clear your mind and focus on your breathing");
                myBreathing.pauseTimer(3);
                myBreathing.StartActivity();
                myBreathing.EndMessage();
            }
            if (choice == 2)
            {
                Console.WriteLine("Welcome to Reflecting activity.\n");
                Console.WriteLine("This activity will help you reflect on the times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspect of your life.\n");
                myReflection.pauseTimer(3);
                myReflection.Run();
                myReflection.EndMessage();
            }
            if (choice == 3)
            {
                Console.WriteLine("Welcome to Listing activity.\n");
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in certain area");
                myListing.pauseTimer(3);
                myListing.Run();
                myListing.EndMessage();
                
            }
        }
    }
}