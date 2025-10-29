using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int number = int.Parse(Console.ReadLine());
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > number)
            {
                Console.WriteLine("lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        while (number != guess);
    }
}