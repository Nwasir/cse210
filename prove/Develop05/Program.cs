using System.IO;

class Program
{
    private static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;
    static void Main(string[] args)
    {
        //Goal myGoal = new Goal();  

        int choice = 0;
        while (choice != 6)
        {
            //Console.Write($"You have {totalPoints} points");
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string enter = Console.ReadLine();
            choice = int.Parse(enter);

            if (choice == 1)
            {
                string name;
                string description;
                int point;

                void StandardInput()
                {
                    Console.Write("What is the name of your goal?-- ");
                    name = Console.ReadLine();
                    Console.Write("what is a short description of it?-- ");
                    description = Console.ReadLine();
                    Console.Write("what is the amount of points associated with this goal?-- ");
                    point = int.Parse(Console.ReadLine());
                }

                int secondChoice = 0;
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal ");
                Console.WriteLine("3. CheckList Goal ");

                Console.Write("what type of goal would you like to create? ");
                string secondEnter = Console.ReadLine();
                secondChoice = int.Parse(secondEnter);

                if (secondChoice == 1)
                {
                    StandardInput();
                    SimpleGoal mySimple = new SimpleGoal(name, description, point);
                    goals.Add(mySimple);

                }
                else if (secondChoice == 2)
                {
                    StandardInput();
                    EternalGoal myEternal = new EternalGoal(name, description, point);
                    goals.Add(myEternal);
                }
                else if (secondChoice == 3)
                {
                    int bonus;
                    int target;
                    StandardInput();
                    Console.Write("How many times does this goal need to be accomplished for a bonus?-- ");
                    target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus amount?-- ");
                    bonus = int.Parse(Console.ReadLine());
                    CheckListGoal myCheckList = new CheckListGoal(name, description, point, target, bonus);
                    goals.Add(myCheckList);
                }
            }
            else if (choice == 2)
            {
                ListGoals();
            }
            else if (choice == 3)
            {
                SaveGoal();
            }
            else if (choice == 4)
            {
                LoadGoal();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
        }
    }

    public static void ListGoals()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in goals)
        {
            goal.Status();
        }
        Console.Write($"\nYou have {totalPoints} points\n");
    }
    public static void SaveGoal()
    {

        Console.Write("enter the filename ");
        string filename = Console.ReadLine();
        foreach (Goal goal in goals)
        {

            using (StreamWriter outputFile = new StreamWriter(filename, append: true))
            {
                //Console.Write($"{totalPoints}");
                if (goal is CheckListGoal checklist)
                    outputFile.WriteLine($"{checklist.GetType()}|{checklist.GetName()}|{checklist.GetDescription()}|{checklist.GetPoint()}|{checklist.GetIsComplete()}|{checklist.GetCount()}|{checklist.GetTarget()}|{checklist.GetBonus()}");
                else if (goal is EternalGoal eternal)
                {
                    outputFile.WriteLine($"{eternal.GetType()}|{eternal.GetName()}|{eternal.GetDescription()}|{eternal.GetPoint()}|{eternal.GetIsComplete()}|{eternal.GetCount()}");
                }
                else
                    outputFile.WriteLine($"{goal.GetType()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoint()}|{goal.GetIsComplete()}");
            }
        }
    }
    public static void LoadGoal()
    {
        //foreach (string )
        Console.Write("Enter the filename: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        goals.Clear();
        foreach (string line in lines)
        {
            string[] data = line.Split("|");
            if (data[0] == "SimpleGoal")
            {
                SimpleGoal simple = new SimpleGoal(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]));
                goals.Add(simple);
            }
            else if (data[0] == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]), int.Parse(data[5]));
                goals.Add(eternal);
            }
            else
            {
                CheckListGoal checklist = new CheckListGoal(data[1], data[2], int.Parse(data[3]), bool.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]), int.Parse(data[7]));
                goals.Add(checklist);
            }
        }
    }
    public static void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in goals)
        {
            goal.Status();
           
        }
        Console.Write("Which goal did you accomplish?-- ");
        int goalchoice = int.Parse(Console.ReadLine());
        totalPoints = goals[goalchoice - 1].RecordEvent(totalPoints);

        // else if (goalchoice == 2)
        // {
        //     totalPoints = goals[1].RecordEvent(totalPoints);
        // }
        // else if ()
    }
}
