using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1142
{
    class URI_problem1142
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());


            int a = 1, b = 2, c = 3;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("{0} {1} {2} PUM", a, b, c);

                a = a + 4;
                b = b + 4;
                c = c + 4;
            }


            Console.ReadKey();


        }
    }
}
