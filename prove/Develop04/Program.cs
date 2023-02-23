using System;

class Program
{
    static void Main(string[] args)
    {
        Parent myParent = new Parent();
        //Breathing myBreathing = new Breathing();
        //Listing myListing = new Listing();
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Menu Options:  ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine("Select a choice from the menu: ");
            string enter = Console.ReadLine();
            choice = int.Parse(enter);

            if (choice == 1)
            {
                Console.WriteLine("Welcome to Breathing activity.\n");
                Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. clear your mind and focus on your breathing");
                myParent.DisplayPrompts();
                //myParent.Breathing.StartActivity();
                //myBreathing.DisplayBreathing();
            }
            if (choice == 2)
            {
                Console.WriteLine("Welcome to Reflecting activity.\n");
                Console.WriteLine("This activity will help you reflect on the times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspect of your life");
                
            }
            if (choice == 3)
            {
                Console.WriteLine("Welcome to Listing activity.\n");
            }
        }
    }
}