using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week2.Example1
{
    public class Triangle : Shape
    {
        private float b;
        private float h;

        public Triangle(float b, float h)
        {
            name = "Triángulo";
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return b * h / 2;
        }
    }
}
