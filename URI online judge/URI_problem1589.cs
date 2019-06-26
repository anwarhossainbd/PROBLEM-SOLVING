using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri_problem1589
{
    class URI
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();

                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                Console.WriteLine(a + b);
            }

            Console.ReadKey();
        }
    }
}
