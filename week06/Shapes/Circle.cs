public class Circle : Shape
{
    private double _radius;
    public Circle(double radius, string color)
    {
        _radius = radius;
        _color = color;
    }
    public override double GetArea()
    {
        double pi = Math.PI;
        return _radius * pi;
    }

}