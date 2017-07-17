public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }
    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public override double CalculateArea()
    {
        return Height * Width;
    }
    public override double CalculatePerimeter()
    {
        return 2 * (Height + Width);
    }
    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}
