using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_next_level
{
    public class Shapes
    {
        protected int color;
        protected char centerpoint;
        protected string name;

        public Shapes(string Shapename, char Shapecenterpoint = '+', int Shapecolor = 10) {
            this.name = Shapename;
            this.centerpoint = Shapecenterpoint;
            this.color = Shapecolor;
            }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
        public virtual void Render()
    {
        Console.WriteLine("I'm a shape");
    }
    }
}
