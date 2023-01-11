using System;

class Program
{
    static void Main(string[] args)
    //static void Main(string name, int square)
    {
        Console.WriteLine("Welcome to the Program!");

        Console.Write($"Please enter your name: ");
        String name = Console.ReadLine();

        Console.Write($"Please enter your favorite number: ");
        string favorite = Console.ReadLine();
        int number = int.Parse(favorite);

        int square = number * number;

        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}