
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        // code here to display text
    }
    public void HideRandomWords(int numberToHide)
    {
        // code here to hide the words
    }
    public string GetDisplayText()
    {
        return _reference.GetDisplayText();
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}