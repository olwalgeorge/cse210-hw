using System;

/// <author>
/// <name>George Olwal</name>
/// </author>
/// <summary>
/// defines variables, constructor, getters and setters for the entries in journal
/// Returns a string representation of the Entry object in case od ToString()
/// </summary>
/// <comments>
/// I added moods and tags
/// </comments>

class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }
        public string Mood { get; set; }
        public string Tags { get; set; }

        public Entry(string prompt, string response, string mood, string tags)
        {
            Prompt = prompt;
            Response = response;
            Date = DateTime.Now.ToString("yyyy-MM-dd");
            Mood = mood;
            Tags = tags;
        }

        public override string ToString()
        {
            return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nMood: {Mood}\nTags: {Tags}\n";
        }
    }