using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public ScriptureReference Reference { get; private set; }
    private List<ScriptureWord> Words { get; set; }
    private Random random;

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new ScriptureWord(word)).ToList();
        random = new Random();
    }

    public void Display()
    {
        Console.WriteLine(Reference.ToString());
        foreach (var word in Words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        int wordsToHide = Math.Min(3, Words.Count(word => !word.IsHidden)); //3 words are hidden

        for (int i = 0; i < wordsToHide; i++)
        {
            int index;
            do
            {
                index = random.Next(Words.Count);
            } while (Words[index].IsHidden);

            Words[index].Hide();
        }
    }

    public bool AllWordsHidden => Words.All(word => word.IsHidden);
}
