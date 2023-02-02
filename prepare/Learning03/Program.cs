using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Journal");
        Journal myjournal = new Journal();
        int questions = 0;
        while (questions != 5)
        {
            Console.WriteLine($"Please select one of the following program");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("what would you like to do? ");
            string enter = Console.ReadLine();
            questions = int.Parse(enter);

            if (questions == 1)
            {                
                myjournal.write();
            }
            else if (questions == 2)
            {                
                myjournal.Display();
            }
            else if (questions == 3)
            {
                myjournal.LoadFromFile();
            }
            else if (questions == 4)
            {
                myjournal.SaveToFile();
            }
        }        

    }

}