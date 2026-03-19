using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    // Displays the scripture including reference
    public void Display()
    {
        Console.WriteLine(_reference.GetReferenceText());
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    // Hides a few random words (core requirement allows any words)
    public void HideRandomWords(int numberToHide = 3)
    {
        Random random = new Random();
        int count = 0;
        while (count < numberToHide && _words.Exists(w => !w.IsHidden()))
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    // Checks if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}