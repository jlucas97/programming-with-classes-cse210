
class Shape
{

    private string _color;

    public Shape(string color)
    {
        this.Color = color;
    }

    public string Color { get => _color; set => _color = value; }

    public virtual double GetArea()
    {
        double area = 0;
        return area;
    }



}