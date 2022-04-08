// See https://aka.ms/new-console-template for more information
internal struct Square
{
    private int side;

    public Square(int side)
    {
        this.side = side;
    }
    internal double GetArea()
    {
        return Math.Pow(side, 2);
    }
}