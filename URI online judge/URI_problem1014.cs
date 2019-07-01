using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1014
{
    class URI_problem1014
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double f = x / y;


            Console.WriteLine(f.ToString("0.000") + " km/l");
            Console.ReadKey();

        }
    }
}
