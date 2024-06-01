using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        ScriptureReference reference = new ScriptureReference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        while (true)
        {
            scripture.Display();

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();

            if (scripture.AllWordsHidden)
            {
                scripture.Display();
                Console.WriteLine("\nAll words are hidden. the scripture is done.");
                break;
            }
        }
    }
}

    
