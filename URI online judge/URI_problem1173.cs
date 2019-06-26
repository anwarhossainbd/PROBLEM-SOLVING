using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1173
{
    class URI
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i < 10; i++)
            {
                // int n = num;
                Console.WriteLine("N[{0}] = {1}", i, num);

                num = num + num;

            }


            Console.ReadKey();

        }
    }
}
