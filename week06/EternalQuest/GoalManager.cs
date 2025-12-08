using System.ComponentModel;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _filename = "eternalQuestFile.txt";
    public GoalManager()
    {
        
    }
    public void Start()
    {
        string entryChoice;
        do
        {
            Console.WriteLine();
            DisplayTotalPoints();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal\n2. List All Goals\n3. Load Goals (clears list before loading)\n4. Save Goals (clears file before saving)\n5. Record Event\n6. List Completed Goals\n7. List Uncompleted and Eternal Goals\n8. Quit\n");
            Console.Write("Select a choice from the menu: ");
            entryChoice = Console.ReadLine();
            Console.WriteLine();
            if (entryChoice == "1")
            {
                CreateGoal();
            } 
            else if (entryChoice == "2" )
            {
                ListGoalDetails();
            }
            else if (entryChoice == "3")
            {
                LoadGoals();
            }
            else if (entryChoice == "4")
            {
                SaveGoals();
            }
            else if (entryChoice == "5")
            {
                RecordEvent();
            }
            else if (entryChoice == "6")
            {
                ListCompletedGoals();
            }
            else if (entryChoice == "7")
            {
                ListUncompletedGoals();
            }
        } while (entryChoice != "8");
    }
    public void DisplayTotalPoints()
    {
        Console.WriteLine($"Total Points: {_score}");
    }
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string x = " ";
            if (_goals[i].IsComplete() != true)
            {
                Console.WriteLine($"[{x}] {i +1}. {_goals[i].GetDetailsString()}");
            }
            else
            {
                x = "X";
                Console.WriteLine($"[{x}] {i +1}. {_goals[i].GetDetailsString()}");
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:\n 1. Simple Goal\n 2. Eternal goal\n 3. Checklist goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine ();
        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with the goal? ");
        int points = int.Parse(Console.ReadLine());
        if (goalChoice == "1")
        {
            SimpleGoal newGoal = new SimpleGoal(shortName, description, points, false);
            _goals.Add(newGoal);
        }
        else if (goalChoice == "2")
        {
            EternalGoal newGoal = new EternalGoal(shortName, description, points, false);
            _goals.Add(newGoal);
        }
        else if (goalChoice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal newGoal = new ChecklistGoal(shortName, description, points, false, target, bonus, 0);
            _goals.Add(newGoal); 
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListUncompletedGoals();
        Console.Write("Which goal did you accomplish? ");
        int i = int.Parse(Console.ReadLine()) - 1;
        _goals[i].RecordEvent();
        _score = _goals[i].GetPoints() + _score;
    }
    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader (_filename))
        {
            _score = int.Parse(reader.ReadLine());
        }

        string[] lines = System.IO.File.ReadAllLines(_filename);
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            AddGoalToList(line);
        }
    }
    public void AddGoalToList(string line)
    {
        string[] parts = line.Split(":");
        string className = parts[0];
        string objectAttributes = parts[1];
        string[] partsB = objectAttributes.Split(",");
        string shortName = partsB[0];
        string description = partsB[1];
        int points = int.Parse(partsB[2]);
        bool isComplete = bool.Parse(partsB[3]);

        if (className == "SimpleGoal")
        {
            _goals.Add(new SimpleGoal(shortName, description, points, isComplete));
        }
        else if (className == "EternalGoal")
        {
            _goals.Add(new EternalGoal(shortName, description, points, isComplete));
        }
        else
        {
            int target = int.Parse(partsB[4]);
            int bonus = int.Parse(partsB[5]);
            int amountCompleted = int.Parse(partsB[6]);
            _goals.Add(new ChecklistGoal(shortName, description, points, isComplete, target, bonus, amountCompleted));
        }
    }
    public void ListUncompletedGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string x = " ";
            if (_goals[i].IsComplete() != true)
            {
                Console.WriteLine($"[{x}] {i +1}. {_goals[i].GetDetailsString()}");
            }
        }
    }
    public void ListCompletedGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            string x = "X";
            if (_goals[i].IsComplete() == true)
            {
                Console.WriteLine($"[{x}] {i +1}. {_goals[i].GetDetailsString()}");
            }
        }
    }
}