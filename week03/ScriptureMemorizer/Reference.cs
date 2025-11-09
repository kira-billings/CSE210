
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // following return single verse
    public string GetDisplayText()
    {
        string text = $"{_book} {_chapter}:{_verse}";
        return text;
    }
    // following returns multiple verses in the reference
    public string GetDisplayText2()
    {
        string text = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        return text;  
     }

}