using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1151
{
    class URI_problem1151
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            int aa = a;
            int bb = b;
            int c;
            Console.Write(aa + " " + bb);

            for (int i = 0; i < num - 2; i++)
            {

                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;




            }

            Console.WriteLine();

            Console.ReadKey();



        }
    }
}
