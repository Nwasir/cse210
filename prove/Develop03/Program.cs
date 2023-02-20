using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverb", 3, 5-6);
        List<Word> words = new List<Word>()
        {
            new Word("Trust"),
            new Word("in"),
            new Word("the"),
            new Word("Lord"),
            new Word("with"),
            new Word("all"),
            new Word("thine"),
            new Word("heart"),
            new Word("and"),
            new Word("lean"),
            new Word("not"),
            new Word("unto"),
            new Word("thine"),
            new Word("won,"),
            new Word("understanding;"),
            new Word("in"),
            new Word("all"),
            new Word("thy"),
            new Word("ways"),
            new Word("acknowledge"),
            new Word("him,"),
            new Word("and"),
            new Word("he"),
            new Word("shall"),
            new Word("direct"),
            new Word("thy"),
            new Word("part.")
        };
        Scripture scripture = new Scripture(reference, words);

        Console.WriteLine("Press enter to continue or type quit to finish:");
        while (true)
        {
            Display(scripture);

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            int wordIndex = new Random().Next(scripture.Words.Count);
            scripture.Words[wordIndex].IsHidden = true;

            if (scripture.Words.All(x => x.IsHidden))
            {                
                break;
            }
        }

    }
        
        static void Display(Scripture scripture)
    {
        Console.Clear();
        //Console.WriteLine($"{scripture.Reference.GetBook} {scripture.Reference.GetChapter}:{string.Join(",", scripture.Reference.GetVerses)}");
        //Console.WriteLine($"{scripture.Reference.GetBook} {scripture.Reference.GetChapter}:{string.Join({scripture.Reference.GetVerses}");

        Console.WriteLine(string.Join(" ", scripture.Words.Select(x => x.IsHidden ? "____" : x.Text)));

        //string words = Console.ReadLine();
        /*for (int i = 0; i < words.Length; i++)
            {
                if (words.Contains(i))
                {
                    Console.Write("____ ");
                }
                else
                {
                    Console.Write(words[i] + " ");
                }
            }

            Console.WriteLine();*/

    }

}

