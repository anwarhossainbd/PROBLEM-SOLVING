using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1067
{
    class URI_problem1067
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
