using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess My Number");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guessNumber = -1;
        int time = +1;

        //Console.Write($"What is the magic number? ");
        //string magic = Console.ReadLine();
        //int magicNumber = int.Parse(magic);
        while (guessNumber != number)
        {
            Console.Write($"What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);


            if (guessNumber < number)
            {
                Console.WriteLine($"Higher");
                //time +=1;
            }
            else if (guessNumber > number)
            {
                Console.WriteLine($"Lower");
                //time +=1;
            }


            if (guessNumber == number)
            {
                //for (int i = 0; i <= guessNumber.count; i++)
                //{}
                Console.WriteLine($"You guessed it!");
                Console.WriteLine($"And it took you {time} times to get it");

            }

        }


    }
}