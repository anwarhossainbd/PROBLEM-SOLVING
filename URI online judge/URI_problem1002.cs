using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1002
{
    class URI_problem1002
    {
        static void Main(string[] args)
        {
            double r, a;
            r = double.Parse(Console.ReadLine());
            a = 3.14159 * (r * r);

            Console.WriteLine("A={0}", a.ToString("0.0000"));
            Console.ReadKey();


        }
    }
}
