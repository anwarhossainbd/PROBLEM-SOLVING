using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1165
{
    class URI
    {
        static void Main(string[] args)
        {

            int i, n, i1 = 2, n1;
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                n1 = int.Parse(Console.ReadLine());
                for (i1 = 2; i1 <= (n1 - 1); i1++)
                {
                    if (n1 % i1 == 0)
                    {
                        Console.WriteLine(n1 + " nao eh primo");
                        break;
                    }
                }
                if (i1 == n1)
                {
                    Console.WriteLine(n1 + " eh primo");

                }

            }


            Console.ReadKey();

        }
    }
}
