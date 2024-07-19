using System;

/// <summary>
/// Represents a simple goal with completion status.
/// </summary>
/// <remarks>
/// SimpleGoal class extends the Goal class, providing a straightforward representation 
/// of a goal with a completion status. It includes properties for managing the goal's 
/// completion and methods for goal-related operations.
/// </remarks>
public class SimpleGoal : Goal
    {
        // Fields
        private bool _isComplete;

        // Constructor
        public SimpleGoal(string shortName, string description, int points, bool isComplete = false)
            : base(shortName, description, points)
        {
            _isComplete = isComplete;
        }

        // Methods
        public override void RecordEvent() //Example of method overriding polymophism
        {
            _isComplete = true;
        }

        public override bool IsComplete() //Example of method overriding polymophism
        {
            return _isComplete;
        }

        public override string GetDetailsString() //Example of method overriding polymophism
        {
            return $"[{(_isComplete ? "X" : " ")}] {_shortName} - {_description} ({_points} points)";
        }

        public override string GetStringRepresentation() //Example of method overriding polymophism
        {
            return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
        }
    }
