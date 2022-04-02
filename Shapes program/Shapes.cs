namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter few shapes: Type C for circle,  S for square, Q for Quit");
            char[]shapes = Console.ReadLine();
            char figure = ProvideUserInput();
            while ((figure == (char)'C') && (figure == 'S'))
            {
                if (figure == 'C')
                {
                    Circle circle = new Circle(3, 0, 0);
                    Circle area = circle.GetArea();
        }
                else if(figure == 'S')
                {
                    Square square = new Square(4, 0, 0);
                    Square area = square.GetArea();
                }
                else if (figure == "Q")
                {
                    break;
                }
                else {Console.WriteLine("ERROR. Type C for circle, S for square, Q for quit");}

            }
            int []areas = new int[shapes.Length];
            int sum=0;
            for (i=0; i<areas.Length; i++)
            {shapes[i] = (areas[i]=area;)
                sum=sum+shapes.length(i);
            Console.WriteLine("Total area = "+ sum);
            }
    }
}
}
