using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
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