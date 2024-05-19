using System.Collections.Generic;
public abstract class JournalStorage
    {
        public abstract void AddEntry(JournalEntry entry);
        public abstract List<JournalEntry> GetAllEntries();
    }

    public class InMemoryJournalStorage : JournalStorage
    {
        private List<JournalEntry> entries = new List<JournalEntry>();

        public override void AddEntry(JournalEntry entry)
        {
            entries.Add(entry);
        }

        public override List<JournalEntry> GetAllEntries()
        {
            return entries;
        }

        public void SaveToFile(string filename)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    file.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Content}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            entries.Clear();
            using (System.IO.StreamReader file = new System.IO.StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string content = parts[2];
                    entries.Add(new JournalEntry(date, prompt, content));
                }
            }
        }
    }

