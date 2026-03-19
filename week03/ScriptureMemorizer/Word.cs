using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Returns the display text (underscores if hidden)
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    // Checks if the word is already hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
}