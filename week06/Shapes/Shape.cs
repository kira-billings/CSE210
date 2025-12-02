using System.Drawing;
using System.Formats.Asn1;

public abstract class Shape
{
    protected string _color;

    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public virtual double GetArea()
    {
        return 0.00;
    }
}
