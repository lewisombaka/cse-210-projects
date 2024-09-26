using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string UsersName = Console.ReadLine();
            return UsersName;
        }

        static int PromptUserNumber ()
        {
            Console.Write("Please enter your favorite number: ");
            String UsersNumberString = Console.ReadLine();
            int UsersNumber = int.Parse(UsersNumberString);
            return UsersNumber;
        }

        static int SquareNumber(int TheNumber)
        {
            return TheNumber*TheNumber;
        }

        static void DisplayResult (string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        DisplayWelcome();
        string namesy = PromptUserName();
        int number = PromptUserNumber();
        int sq = SquareNumber(number);
        DisplayResult(namesy,sq);

    }
}