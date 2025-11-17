using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string text = ":)";
        int beginVerse = 0;
        int endVerse = 0;
        int singleVerse = 0;       

        // creativity enhancement: Determine if single verse or multiple verse
        Console.Clear();
        Console.WriteLine("Welcome! Today, we are using the text file called 'myScriptureFile.txt' to memorize.");
        Console.Write("Enter 's' for single verse or 'm' for multiple verses: ");
        string verseChoice = Console.ReadLine();
        if (verseChoice == "s")
        {
            // Creativity enhancement: choose verse from myScriptureFile.txt
            Console.Write("Enter the number of the single verse (from 1 to 25): ");
            singleVerse = int.Parse(Console.ReadLine());
            TextFile singleTextFile = new TextFile(singleVerse);
            Reference singleReference = new Reference(singleVerse);
            Console.WriteLine(singleReference.GetSingleDisplayReference());
            text = singleTextFile.GetSingleText();
        }
        else
        {
             // Creativity enhancement: choose verses from myScriptureFile.txt
            Console.Write("Enter the number of the beginning verse (from 1 to 24): ");
            beginVerse = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the ending verse (must be greater than beginning verse): ");
            endVerse = int.Parse(Console.ReadLine());
            TextFile multiTextFile = new TextFile(beginVerse, endVerse);
            Reference multiReference = new Reference(beginVerse, endVerse);
            Console.WriteLine(multiReference.GetMultiDisplayReference());
            text = multiTextFile.GetMultiText();
        }
        
        // prints the text of the verse
        Scripture scripture = new Scripture(text);
        scripture.CreateList(text);
        Console.WriteLine(scripture.GetDisplayText());
        
        // hide words and enhancement to choose number of words
        Console.WriteLine();
        Console.Write("Enter the number of words to hide: ");
        int numberToHide = int.Parse(Console.ReadLine());
        string quitChoice = "";
        while (quitChoice != "quit")
        {
            scripture.HideRandomWords(numberToHide);
            Console.Clear();
            if (verseChoice == "s")
            {
                Reference singleReference = new Reference(singleVerse);
                Console.WriteLine(singleReference.GetSingleDisplayReference());
            }
            else
            {
                Reference multiReference = new Reference(beginVerse, endVerse);
                Console.WriteLine(multiReference.GetMultiDisplayReference());
            }
            Console.WriteLine(scripture.GetDisplayText());
            
            // continue or quit 
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to end: ");
            string choice = Console.ReadLine();
            if (choice == "quit")
            {
                break;
            }
            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }
        }
    }
}