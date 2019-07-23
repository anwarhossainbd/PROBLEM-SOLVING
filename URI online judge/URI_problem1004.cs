using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1004
{
    class URI_problem1004
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
