using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their names
        Console.Write("What is your first name? ");
        String first = Console.ReadLine();
        Console.Write("What is your last name? ");
        String last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}