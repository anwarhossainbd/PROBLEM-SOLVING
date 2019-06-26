using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1175
{
    class URI
    {
        static void Main(string[] args)
        {

            int[] array = new int[20];

            for (int i = 0; i <= 19; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            int k = 0;

            for (int i = 19; i >= 0; i--)
            {
                Console.WriteLine("N[{0}] = {1}", k, array[i]);

                k = k + 1;
            }
            Console.ReadKey();
        }
    }
}
