using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1003
{
    class URI_problem1003
    {
        static void Main(string[] args)
        {
            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int prob = a * b;

            Console.WriteLine("PROD = {0}", prob);
            Console.ReadKey();

        }
    }
}
