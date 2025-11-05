using System.IO;
public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    public List<Entry> _loadedEntries = new List<Entry>();
    public Journal()
    {
        _entries = new List<Entry>();
        _loadedEntries = new List<Entry>();
    }

    // the following AddEntry adds a new entry into _entries list
    public void AddEntry(Entry newEntry)
    {
        // Getting date into the newEntry
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;
        // Getting prompt text into the newEntry
        PromptGenerator generator = new PromptGenerator();
        string randomPrompt = generator.GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        newEntry._promptText = randomPrompt;
        // Getting new journal entry text into the newEntry
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
    }

    // The following prints all items from the _entries
    // and _loadedEntries list
    public void DisplayAllEntries()
    {
        Console.WriteLine("Displaying all entries from lists...");
        foreach (Entry e in _loadedEntries)
        {
            Console.WriteLine($"{e._date}: {e._promptText}\n{e._entryText}");
        }
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"{e._date}: {e._promptText}\n{e._entryText}");
        }
    }

    // The following saves the current _entries list to myJournalFile
    // and clears the _entries list
    public void SaveToFile()
    {
        Console.WriteLine("Saving entries to the storage file...");
        string filename = "myJournalFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~~{e._promptText}~~{e._entryText}");
            }
        }
        _entries.Clear();
    }
    
    // The following loads the entries from the myJournal file
    // into the _loadedEntries after clearing whatever is there.
    public List<Entry> LoadFromFile()
    {
        Console.WriteLine("Loading list of journal entries from file...");
        // clears list _loadedEntries and loads all content from file
        _loadedEntries.Clear();
        string filename = "myJournalFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        // This initiates the Journal object to allow reading to a list
        Journal myJournal = new Journal();
        foreach (string line in lines)
        {
            // this reads the file into strings that are ~~ separated
            string[] parts = line.Split("~~");
            // this accesses and gives a variable to the parts of the entry
            string entryDate = parts[0];
            string entryPrompt = parts[1];
            string entryText = parts[2];
            Entry entry = new Entry
            {
                _date = entryDate,
                _promptText = entryPrompt,
                _entryText = entryText
            };
            _loadedEntries.Add(entry);
        }
        return myJournal._loadedEntries;
    }
}