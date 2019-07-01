using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1043
{
    class URI_problem1043
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            if (a + b > c && b + c > a && c + a > b)
            {
                double perimetro = a + b + c;
                Console.WriteLine("Perimetro = {0}", perimetro.ToString("0.0"));
            }

            else
            {
                double area = ((a + b) * c) / 2;
                Console.WriteLine("Area = {0}", area.ToString("0.0"));
            }


            Console.ReadKey();


        }
    }
}
