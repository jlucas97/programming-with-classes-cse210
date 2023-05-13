
class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius) : base(color)
    {
        this.Radius = radius;
    }

    public override double GetArea()
    {
        return Math.Pow(Radius, 2) * Math.PI;
    }

    public double Radius { get => _radius; set => _radius = value; }
}