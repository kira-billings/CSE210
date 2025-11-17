using System.Collections.Concurrent;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.IO;
using System.Linq;
using System.Data;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _singleVerse;
    private int _beginVerse;
    private int _endVerse;
   
    TextFile textFile = new TextFile();
    public Reference()
    {
        _book = "";
        _chapter = 0;
        _singleVerse = 0;
        _endVerse = 0;
        _beginVerse = 0;
    }
    public Reference(int beginVerse, int endVerse)
    {
        _book = "";
        _chapter = 0;
        _singleVerse = 0;
        _beginVerse = beginVerse;
        _endVerse = endVerse;
    }
    
    public Reference(int singleVerse)
    {
        _book = "";
        _chapter = 0;
        _singleVerse = singleVerse;
        _beginVerse = 0;
        _endVerse = 0;
    }

    // creates single verse reference
    public string GetSingleDisplayReference()
    {
        _book = textFile.GetBook();
        _chapter = textFile.GetChapter();
        return $"{_book} {_chapter}:{_singleVerse}";
    }
    // creates multiple verse reference
    public string GetMultiDisplayReference()
    {
        _book = textFile.GetBook();
        _chapter = textFile.GetChapter();
        return $"{_book} {_chapter}:{_beginVerse}-{_endVerse}";
    }
}