using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week1
{
    internal class Example2
    {
        public void Execute()
        {
            Rectangle();
            Triangle();
        }

        private void Rectangle()
        {
            int b;
            int h;
            Console.WriteLine("Introduce la base del rectángulo");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del rectángulo");
            h= int.Parse(Console.ReadLine());
            Console.WriteLine($"El área del rectángulo es: {b*h}");
        }

        private void Triangle()
        {
            float b;
            float h;
            Console.WriteLine("Introduce la base del triángulo");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del triángulo");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine($"El área del triángulo es: {b * h / 2}");
        }
    }
}
