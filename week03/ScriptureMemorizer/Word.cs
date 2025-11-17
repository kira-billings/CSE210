using System.IO;
using System.Collections.Concurrent;

public class Word
{
    private string _text;
    private bool _isHidden;
    
    // constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    
    // hides words 
    public void Hide()
    {
        if (!_isHidden)
        {
            _text = new string('_', _text.Length);
            _isHidden = true;
        }
    }
    // didn't use this method
    public void Show()
    {
        
    }

    // converts IsHidden to _isHidden
    public bool IsHidden => _isHidden;

    // returns words in string
        public string GetDisplayText()
    {
        return _text;
    }
}
    
 
