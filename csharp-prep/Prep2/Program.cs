using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write($"Please enter your grade: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter;

        if (number >= 93)
        {
            letter = "A";
        }
        else if (number <= 92 && number >= 90)
        {
            letter = "A-";
        }
        else if (number <= 89 && number >= 87)
        {
            letter = "B+";
        }
        else if (number <= 86 && number >= 83)
        {
            letter ="B";
        }
        else if (number <= 82 && number >= 80)
        {
            letter = "B-";
        }
        else if (number <= 79 && number >= 77)
        {
            letter = "C+";
        }
        else if (number <= 76 && number >= 73)
        {
            letter = "C";
        }
        else if (number <= 72 && number >= 70)
        {
            letter = "C-";
        }
        else if (number <= 69 && number >= 67)
        {
            letter = "D+";
        }
        else if (number <= 66 && number >= 63)
        {
            letter = "D";
        }
        else if (number <= 62 && number >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}");

        if (number >= 70)
        {
            Console.WriteLine($"Congratulation! You just passed the course and will be promoted to next course");
        }
        else
        {
            Console.WriteLine($"Sorry you could not make it to a higher course. Try harder you will make it next course");
        }
    }
}