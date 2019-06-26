using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1079
{
    class URI_problem1079
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            double a, b, c;




            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();

                a = double.Parse(input[0]);
                b = double.Parse(input[1]);
                c = double.Parse(input[2]);

                a = a * 2;
                b = b * 3;
                c = c * 5;

                double res = (a + b + c) / 10;
                Console.WriteLine(res.ToString("0.0"));

            }



            Console.ReadKey();


        }
    }
}
