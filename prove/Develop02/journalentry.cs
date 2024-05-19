using System;
public class JournalEntry
    {
        public DateTime Date { get; set; }
        public string Prompt { get; set; }
        public string Content { get; set; }

        public JournalEntry(DateTime date, string prompt, string content)
        {
            Date = date;
            Prompt = prompt;
            Content = content;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - {Prompt}: {Content}";
        }
    }

