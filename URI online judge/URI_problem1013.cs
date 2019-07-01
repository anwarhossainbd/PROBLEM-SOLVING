using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1013
{
    class URI_problem1013
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);


            int big1 = a > b ? a : b;
            int big = big1 > c ? big1 : c;

            Console.WriteLine(big + " eh o maior");
            Console.ReadKey();


        }
    }
}
