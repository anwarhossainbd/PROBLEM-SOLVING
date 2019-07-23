using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class URI_problem1007
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int res = (a * b) - (c * d);

            Console.WriteLine("DIFERENCA = {0}", res);
            Console.ReadKey();


        }
    }
}
