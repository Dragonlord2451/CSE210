using System;
class Program
    {
        static void Main(string[] args)
        {
            JournalStorage storage = new InMemoryJournalStorage();
            JournalApp app = new JournalApp(storage);

            while (true)
            {
                Console.WriteLine("1. Add Entry");
                Console.WriteLine("2. JournalEntries");
                Console.WriteLine("3. Save Journal (please do this before loading journal)");
                Console.WriteLine("4. Load Journal");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        app.AddEntry();
                        break;
                    case 2:
                        app.ListEntries();
                        break;
                    case 3:
                        app.SaveJournal();
                        break;
                    case 4:
                        app.LoadJournal();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }

