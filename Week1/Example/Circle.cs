using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week1
{
    internal class Circle
    {
        private float r;

        public Circle(float r)
        {
            this.r = r;
        }

        public float GetArea()
        {
            return 3.14f * r * r;
        }
    }
}
