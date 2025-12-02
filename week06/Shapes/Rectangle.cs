public class Rectangle : Shape
{
    private double _shortSide;
    private double _longSide;
    public Rectangle(double longSide, double shortSide, string color)
    {
        _longSide = longSide;
        _shortSide = shortSide;
        _color = color;
    }

    public override double GetArea()
    {
        return _shortSide * _longSide;
    }
}