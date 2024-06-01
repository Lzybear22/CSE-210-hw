using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string scriptureText;
    private Reference reference;
    private List<Word> words;
    private Random random;

    public Scripture(string text, Reference reference)
    {
        this.scriptureText = text;
        this.reference = reference;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
        this.random = new Random();
    }

    public void HideRandomWord()
    {
        var visibleWords = words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Count > 0)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
        }
    }

    public string GetFormattedScripture()
    {
        return $"{reference.GetFormattedReference()}\n" + 
               string.Join(" ", words.Select(word => word.GetDisplayedWord()));
    }

    public bool IsFullyHidden()
    {
        return words.All(word => word.IsHidden);
    }
}

