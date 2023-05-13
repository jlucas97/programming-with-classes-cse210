
class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        this.Length = length;
        this.Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }

    public double Length { get => _length; set => _length = value; }
    public double Width { get => _width; set => _width = value; }
}