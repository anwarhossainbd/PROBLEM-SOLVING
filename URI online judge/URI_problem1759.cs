using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1759
{
    class URI
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            Console.Write("Ho");

            for (int i = 0; i < num - 1; i++)
            {
                Console.Write(" Ho");
            }

            Console.WriteLine("!");

            Console.ReadKey();
        }
    }
}
