using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_next_level
{
    public class Square : Shapes
    {
        public Square(string Shapename, char Shapecenterpoint, int Shapecolor) : base(Shapename, Shapecenterpoint, Shapecolor)
        {
        }
        public override void Render()
        {
            int lines = 2;
            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine();
            }

            var paddingLesft = "\t\t";
            Console.ForegroundColor = (ConsoleColor) color;
            Console.WriteLine(paddingLesft + @"-----");
            Console.Write(paddingLesft + $"| {centerpoint} |");
            Console.WriteLine();
            Console.WriteLine(paddingLesft + "-----");
        }
    }
}
