 using System;

        /// <summary>
        /// An eternal goal is a goal that is never complete. Each event adds the
        /// point value to the player's score.
        /// </summary>
 public class EternalGoal : Goal // a subclass of Goal class
    {
        // Constructor
        public EternalGoal(string shortName, string description, int points)
            : base(shortName, description, points)
        {
        }

        // Methods
        public override void RecordEvent()
        {
            // Eternal goals are never complete, just add points
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetDetailsString()
        {
            return $"[ ] {_shortName} - {_description} ({_points} points each time)";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal|{_shortName}|{_description}|{_points}";
        }
    }
