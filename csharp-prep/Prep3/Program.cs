using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);
        while (userGuess != magicNumber)
        {
            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            userGuess = int.Parse(guess);

        }
        Console.WriteLine("You guessed it!");

    }
}