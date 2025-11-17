using System;
using System.Collections.Concurrent;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.IO;
using System.Linq;
using System.Data;

// creativity enhancement: I created class to work with 'myScriptureFile.txt'
public class TextFile
{
    private string _book;
    private int _chapter;
    private int _singleVerse;
    private int _beginVerse;
    private int _endVerse;
    private string _textAllVerse;
    
    // the text file must have the book name and chapter number separated by ~ in the first line and each verse in a new line
    private string _filename = "myScriptureFile.txt";

    public TextFile()
    {
        _filename = "myScriptureFile.txt"; 
        _book = "";
        _chapter = 0;
        _singleVerse = 0;
        _endVerse = 0;
        _beginVerse = 0;
        _textAllVerse = "";
    } 
    public TextFile(int singleVerse)
    {
        _filename = "myScriptureFile.txt"; 
        _book = "";
        _chapter = 0;
        _singleVerse = singleVerse;
        _endVerse = 0;
        _beginVerse = 0;
        _textAllVerse = "";
    }
    public TextFile(int beginVerse, int endVerse)
    {
        _filename = "myScriptureFile.txt"; 
        _book = "";
        _chapter = 0;
        _singleVerse = 0;
        _endVerse = endVerse;
        _beginVerse = beginVerse;
        _textAllVerse = "";
    }

    // Get name of book from file
    public string GetBook()
    {
        string[] lines = File.ReadAllLines(_filename);
        string firstLine = lines.Length >= 1 ? lines[0] : null;
        string[] bookChapter = firstLine.Split("~");
        return bookChapter[0];
    }

    // Get chapter number from file
    public int GetChapter()
    {
        string[] lines = File.ReadAllLines(_filename);
        string firstLine = lines.Length >= 1 ? lines[0] : null;
        string[] bookChapter = firstLine.Split("~");
        return int.Parse(bookChapter[1]);
    }

    // return number of lines to grab from text file
    private int GetIntLines()
    {
        return _endVerse - _beginVerse + 1;
    }
    
    // returns string text of single verse
    public string GetSingleText()
    {
        string[] lines = File.ReadAllLines(_filename);
        return lines.Length >= _singleVerse ? lines[_singleVerse] : null;
    }
    
    // returns string text of multiple verses
    public string GetMultiText()
    {
        string[] lines = File.ReadAllLines(_filename);
        int startLine = _beginVerse;
        return string.Join("\n", lines.Skip(startLine).Take(GetIntLines()));
    }
}