using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        
        int newNumber = -1;

        while (newNumber != 0)
        {
            Console.Write($"Enter number: ");
            string enter = Console.ReadLine();
            newNumber = int.Parse(enter);            

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }

        }
        int sum = 0;
        //loop through the list and get the sum
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"The sum is: {sum}");
        //find the average 
        float average = ((float)sum) / numbers.Count;
        //print the average
        Console.WriteLine($"The average is: {average}");

        //Loop through the list and get the maximm number
        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (maximum < number)
            {
                maximum = number;
            }
        }
        Console.WriteLine($"The Largest number is: {maximum}");

        int minimum = numbers[0];
        //numbers.Reverse();
        foreach (int number in numbers)
        {
            if (minimum > number)
            {
                minimum = number;
                
            }
        }
        Console.WriteLine($"The smallest positive number is: {minimum}");
         //sort the list 
        numbers.Sort();

        foreach (int number in numbers)
        {
                Console.WriteLine($"{number}");
        }
                

    }
    

}