using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List <int> listNumbers = new List<int>();
        Console.WriteLine("Type 0 to exit");
        int guess = 1;
        int sum = 0;
        while(guess != 0)
        {   
            Console.Write("Enter Number: ");
            string guessUser = Console.ReadLine();
            guess = int.Parse(guessUser);
            listNumbers.Add(guess);
        }
        foreach(int li in listNumbers)
        {
            sum += li;

        }

        float average = sum / ((listNumbers.Count)-1); 
        int max = listNumbers[0];
        foreach(int li in listNumbers)
        {
            if (li > max)
            {
                max = li;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest numbers is: {max}");

    }
}