using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1012
{
    class URI_problem1012
    {
        static void Main(string[] args)
        {
            double a, b, c;

            string[] number = Console.ReadLine().Split();

            a = double.Parse(number[0]);
            b = double.Parse(number[1]);
            c = double.Parse(number[2]);

            double triangle = .5 * a * c;
            double radious = 3.14159 * c * c;
            double trapezium = (a + b) / 2 * c;
            double area = b * b;
            double rectangle = a * b;

            Console.WriteLine("TRIANGULO: {0}", triangle.ToString("0.000"));
            Console.WriteLine("CIRCULO: {0}", radious.ToString("0.000"));
            Console.WriteLine("TRAPEZIO: {0}", trapezium.ToString("0.000"));
            Console.WriteLine("QUADRADO: {0}", area.ToString("0.000"));
            Console.WriteLine("RETANGULO: {0}", rectangle.ToString("0.000"));


            Console.ReadKey();



        }
    }
}
