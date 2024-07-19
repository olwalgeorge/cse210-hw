using System;

/// <summary>
/// Represents a goal that can be completed by checking items on a checklist.
/// Checklist goals have a target number of items to complete, a bonus points value for completing early,
/// and a number of points that each item on the checklist is worth.
/// </summary>

public class ChecklistGoal : Goal
    {
        // Fields
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        // Constructor. An example of method overloading polymorphism
        public ChecklistGoal(string shortName, string description, int points, int target, int bonus, int amountCompleted = 0)
            : base(shortName, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = amountCompleted;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {_shortName} - {_description} ({_points} points each time, {_bonus} bonus points after {_target} times) Completed {_amountCompleted}/{_target} times";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
        }
    }