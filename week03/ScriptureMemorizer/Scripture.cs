using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.IO;

public class Scripture
{
    // private Reference _reference;
    private List<Word> _words = new List<Word>();
    // private string _choiceOfLines;
    // private string _text;

    public Scripture(string text)
    {

    }
    public List<Word> CreateList(string text)
    {
        _words = new List<Word>();
        string[] wordString = text.Split(' ');
        foreach (string w in wordString)
        {
            _words.Add(new Word(w));
        }
        return _words;
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            // build a list of visible words
            var visibleWords = _words.Where(w => !w.IsHidden).ToList();

            if (visibleWords.Count == 0)
                break;

            // pick a random visible word
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }

    }


    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden)
                return false;
        }
        return true;
    }
}
