// W02 Project: Journal Program
// by: Kira Billings
// Creativity: used additional list called _loadedEntries to 
// protect the journal file from being overwritten with save. 
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string entryChoice;
        Journal myJournal = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write a journal entry and add to display list \n2. Display the list journal entries\n3. Load from my journal text file into display list\n4. Save to my journal text file and clear display list\n5. Quit");
            Console.Write("What would you like to do? ");
            entryChoice = Console.ReadLine();

            // writes a new journal entry and stores it in the _entries list in Journal class
            if (entryChoice == "1")
            {
                Entry newEntry = new Entry();
                myJournal.AddEntry(newEntry);
            }

            // Choice to display all entries stored in _entries list and _loadedEntries from Journal class
            else if (entryChoice == "2")
            {
                myJournal.DisplayAllEntries();
            }

            // choice to load list of journal entries from file into _loadedEntries list
            // overwrites current contents of _loadedEntries list in Journal class
            else if (entryChoice == "3")
            {
                myJournal.LoadFromFile();
            }

            // appends _entries list to my journal text file
            else if (entryChoice == "4")
            {
                myJournal.SaveToFile();
            }

        } while (entryChoice != "5");

    }
}