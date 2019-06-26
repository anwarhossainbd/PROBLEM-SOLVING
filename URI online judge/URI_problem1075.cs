using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1075
{
    class URI_problem1075
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i < 10000; i = i + number)
            {

                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
