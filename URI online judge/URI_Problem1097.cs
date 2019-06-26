using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1097
{
    class URI_Problem1097
    {
        static void Main(string[] args)
        {
            int a = 7, b = 6, c = 5;


            for (int i = 1; i <= 9; i = i + 2)
            {
                Console.WriteLine("I={0} J={1}\nI={2} J={3}\nI={4} J={5}", i, a, i, b, i, c);

                a = a + 2;
                b = b + 2;
                c = c + 2;

            }



            Console.ReadKey();


        }
    }
}
