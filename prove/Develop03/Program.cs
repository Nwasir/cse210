using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        Reference reference = new Reference("Proverb", 3, 5, 6);
        //Console.WriteLine(reference.GetSummary());
        string words = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all they ways ackowledge him and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, words);

        Console.Clear();
        scripture.Reference.GetSummary();
        Console.WriteLine(reference.GetSummary());
        foreach (Word word in scripture.Words)
        {
            word.DisplayWord();
            Console.Write(" ");
        }


        while (true)
        {
            Console.Write("\n\nPress enter to continue or type quit to finish: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {                
                break;
            }
            Console.Clear();

            List<Word> visibleWords = scripture.GetShownWordsList();
            for (int i = 0; i < 3; i++)
            {
                visibleWords[rnd.Next(visibleWords.Count())].SetHidden(true);
            
            }

            scripture.Reference.GetSummary();
            Console.WriteLine(reference.GetSummary());
            
            foreach (Word word in scripture.Words)
            {
                word.DisplayWord();
                Console.Write(" ");
            }

            if (scripture.Words.All(x => x.GetHidden()))
                break;

        }

    }
}

