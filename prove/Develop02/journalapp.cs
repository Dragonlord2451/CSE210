using System;
using System.Collections.Generic;
public class JournalApp
    {
        private JournalStorage storage;
        private List<string> prompts = new List<string>
        {
            "What is the funnest thing you did?",
            "What was the a blessing you saw today?",
            "what was the highlight of the day?",
            "what kind of adventure are we planning in the future?",
            
        };

        public JournalApp(JournalStorage storage)
        {
            this.storage = storage;
        }

        public void AddEntry()
        {
            Random rand = new Random();
            string prompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Your response: ");
            string content = Console.ReadLine();

            JournalEntry entry = new JournalEntry(DateTime.Now, prompt, content);
            storage.AddEntry(entry);
            Console.WriteLine("Journal entry added.");
        }

        public void ListEntries()
        {
            List<JournalEntry> entries = storage.GetAllEntries();
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void SaveJournal()
        {
            Console.Write("Enter filename to save: ");
            string filename = Console.ReadLine();
            (storage as InMemoryJournalStorage)?.SaveToFile(filename);
            Console.WriteLine("Journal saved.");
        }

        public void LoadJournal()
        {
            Console.Write("Enter filename to load: ");
            string filename = Console.ReadLine();
            (storage as InMemoryJournalStorage)?.LoadFromFile(filename);
            Console.WriteLine("Journal loaded.");
        }
    }

