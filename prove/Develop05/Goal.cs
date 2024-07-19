using System;

/// <summary>
/// Represents a goal that can be achieved by the user. Goals have a short name, a description,
/// and a number of points. The short name is a unique identifier for the goal, the description
/// provides more details about the goal, and the points represent the number of points that
/// achievement of the goal is worth.

public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public string ShortName => _shortName;
        public string Description => _description;
        public int Points => _points;

        // Initializes a new instance of the Goal class with the specified shortName, description, and points.
        public Goal(string shortName, string description, int points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetDetailsString();
        public abstract string GetStringRepresentation();
    }