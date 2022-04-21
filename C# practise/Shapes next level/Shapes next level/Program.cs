using System;
using Shapes_next_level;
namespace Shapes_next_level
{
    public static class Program
    {
        const int shapeCount = 6;

        static void Main(string[] args)
        {
            Shapes[] shapess = new Shapes[shapeCount];

            for (int i = 0; i < shapeCount; i++)
            {
                Shapes shapes;
                if (i < 3)
                {
                    shapes = new Circle("Round" + i, '+', 10);
                }
                else
                {
                    shapes = new Square("Quadratic" + i, '+', 10);
                }
                shapess[i] = shapes;
            }

            foreach (var shapes in shapess)
            {
                shapes.Render();
            }

            Console.ReadLine();
        }




    }
}