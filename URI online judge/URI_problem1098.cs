using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1098
{
    class URI_problem1098
    {
        static void Main(string[] args)
        {

            int a = 1, b = 2, c = 3;


            for (double i = 0; i <= 2; i = i + .2)
            {
                Console.WriteLine("I={0} J={1}\nI={2} J={3}\nI={4} J={5}", i, a + i, i, b + i, i, c + i);

            }

            Console.ReadKey();

        }
    }
}
