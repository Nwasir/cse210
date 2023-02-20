using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Assignment myAssignment = new Assignment("Samuel", "Multiplication");
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine();

        MathAssignment mymathAssignment = new MathAssignment("Roberto Rodriquez", "Fraction", "7.3", "8-19");
        Console.WriteLine(mymathAssignment.GetSummary());
        Console.WriteLine(mymathAssignment.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment mywritingAssignment = new WritingAssignment("Mary Waters", "European History", "The causes of world war II ");
        Console.WriteLine(mywritingAssignment.GetSummary());
        Console.WriteLine(mywritingAssignment.GetWritingInformation());
    }
}
