using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        DisplayResult(userName,squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string str = Console.ReadLine();
        int userNumber = int.Parse(str); 
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int squared = userNumber * userNumber;
        return squared;
    }
    static void DisplayResult(string userName, int squareNumber)
    {
        string stringNumber = Convert.ToString(squareNumber);
        Console.Write($"{userName}, the square of your number is {stringNumber}");
    }
}