
class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        this.Side = side;
    }

    public override double GetArea()
    {
        return this.Side * this.Side;
    }

    public double Side { get => _side; set => _side = value; }
}