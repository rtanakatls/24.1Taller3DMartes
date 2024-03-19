using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D
{
    internal class Example1
    {
        public void Execute()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introducir el número de la operación");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("0. Salir");
                string option= Console.ReadLine();
                switch(option)
                {
                    case "1":
                        Addition();
                        break;
                    case "2":
                        Subtraction();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

            }
        }

        private void Addition()
        {
            int a;
            int b;
            Console.WriteLine("Introduce el primer número");    
            a= int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {a+b}");
        }
        private void Subtraction()
        {
            int a;
            int b;
            Console.WriteLine("Introduce el primer número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {a - b}");
        }

    }
}
