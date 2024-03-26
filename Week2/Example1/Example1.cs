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
            bool continueFlag = true;

            while (continueFlag)
            {
                Shape shape = null;

                Console.WriteLine("Introducir el número a operar:");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Rectángulo");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        shape= GetCircle();
                        break;
                    case "2":
                        shape = GetTriangle();
                        break;
                    case "3":
                        shape = GetRectangle();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                if(shape != null)
                {
                    Console.WriteLine($"El área del {shape.Name} es {shape.GetArea()}");
                }
            }

        }

        private Circle GetCircle()
        {
            Console.WriteLine("Introducir el radio del círculo:");
            float r = float.Parse(Console.ReadLine());
            return new Circle(r);
        }

        private Triangle GetTriangle()
        {
            Console.WriteLine("Introducir la base del triángulo:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la altura del triángulo:");
            float h = float.Parse(Console.ReadLine());
            return new Triangle(b, h);
        }

        private Rectangle GetRectangle()
        {
            Console.WriteLine("Introducir la base del rectángulo:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la altura del rectángulo:");
            float h = float.Parse(Console.ReadLine());
            return new Rectangle(b, h);
        }
    }
}
