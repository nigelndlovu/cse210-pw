using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        int yourGuess = -1;

        while (yourGuess != magicNum)
        {
            Console.Write("What is your guess? ");
            yourGuess = int.Parse(Console.ReadLine());

            if (magicNum > yourGuess)
            {
                Console.WriteLine("Guess Higher");
            }
            else if (magicNum < yourGuess)
            {
                Console.WriteLine("Guess Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}