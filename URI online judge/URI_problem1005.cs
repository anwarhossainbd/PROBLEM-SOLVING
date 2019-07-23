using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1005
{
    class URI_problem1005
    {
        static void Main(string[] args)
        {
            double a, b;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());


            a = a * 3.5;
            b = b * 7.5;
            double result = (a + b) / 11;

            Console.WriteLine("MEDIA = {0}", result.ToString("0.00000"));

            Console.ReadKey();



        }
    }
}
