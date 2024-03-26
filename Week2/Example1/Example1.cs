using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week2.Example1
{
    public class Example1
    {
        public void Execute()
        {
            Rectangle r = new Rectangle(5, 10);
            Circle c = new Circle(5);

            Shape[] shapes = new Shape[2];
            shapes[0] = r;
            shapes[1] = c;

            Console.WriteLine($"El área del {r.Name} es: {r.GetArea()}");
            Console.WriteLine($"El área del {c.Name} es: {c.GetArea()}");

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"El área del {shapes[i].Name} es: {shapes[i].GetArea()}");
            }
            Console.ReadLine();
        }
    }
}
