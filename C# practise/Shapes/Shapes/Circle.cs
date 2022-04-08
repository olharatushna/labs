// See https://aka.ms/new-console-template for more information
internal struct Circle
{
    private int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }
    internal double GetArea()
    {
        return Math.Pow(radius, 2) * Math.PI;
    }
}