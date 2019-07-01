using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1036
{
    class URI_problem1036
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            double root = ((b * b) - (4 * a * c));

            if (a == 0 || root < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }


            else
            {
                double r1 = (-b + Math.Sqrt(root)) / (2 * a);
                double r2 = (-b - Math.Sqrt(root)) / (2 * a);

                Console.WriteLine("R1 = " + r1.ToString("0.00000"));
                Console.WriteLine("R2 = " + r2.ToString("0.00000"));

            }



            Console.ReadKey();


        }
    }
}
