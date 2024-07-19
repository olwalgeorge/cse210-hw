using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


/// <author>
/// George Olwal
/// </author>  
/// <summary>
/// GoalManager class
/// Initializes a new instance of the <see cref="GoalManager"/> class.
/// </summary>
/// <remarks>
/// This constructor initializes the <see cref="_goals"/> field with an empty list and sets the <see cref="_score"/> field to 0.
/// DisplayPlayerInfo: This method displays the current score to the console.
/// ListGoalNames: This method lists the names of all the goals in the _goals list.
/// ListGoalDetails: This method lists the details of all the goals in the _goals list.
/// CreateGoal: This method allows the user to create a new goal. The user selects the type of goal, enters the short name, description, and points, and the goal is added to the _goals list.
/// RecordEvent: This method allows the user to record an event for a goal. The user selects the goal and the method checks if the selection is valid. If it is, the event is recorded and the score is updated.
/// SaveGoals: This method saves the current score and the details of all the goals in the _goals list to a file named "goals.txt".
/// LoadGoals: This method loads the saved goals and score from the "goals.txt" file. If the file exists, the method reads the score and the details of each goal and adds them to the _goals list.
/// Added bonus
/// </remarks>
 public class GoalManager
    {
        // Fields
        private List<Goal> _goals;
        private int _score;

        // Constructor
        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        // Methods
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Menu Options");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current Score: {_score}");
        }

        public void ListGoalNames()
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
            }
        }

        public void ListGoalDetails()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("Select Goal Type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string choice = Console.ReadLine();

            Console.Write("Enter short name: ");
            string name = Console.ReadLine();
            Console.Write("Enter description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Enter target: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus: ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Goal not created.");
                    break;
            }
        }

        public void RecordEvent()
        {
            ListGoalNames();
            Console.Write("Select a goal to record: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                _goals[index].RecordEvent();
                _score += _goals[index].Points;
                Console.WriteLine("Event recorded.");
            }
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
        }

        public void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved.");
        }

        public void LoadGoals()
        {
            if (File.Exists("goals.txt"))
            {
                using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    _score = int.Parse(reader.ReadLine());
                    _goals.Clear();
                    while (!reader.EndOfStream)
                    {
                        string[] parts = reader.ReadLine().Split('|');
                        string type = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);

                        switch (type)
                        {
                            case "SimpleGoal":
                                bool isComplete = bool.Parse(parts[4]);
                                _goals.Add(new SimpleGoal(name, description, points, isComplete));
                                break;
                            case "EternalGoal":
                                _goals.Add(new EternalGoal(name, description, points));
                                break;
                            case "ChecklistGoal":
                                int amountCompleted = int.Parse(parts[4]);
                                int target = int.Parse(parts[5]);
                                int bonus = int.Parse(parts[6]);
                                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
                                break;
                        }
                    }
                }
                Console.WriteLine("Goals loaded.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
    }
