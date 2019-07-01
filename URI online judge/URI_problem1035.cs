using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1035
{
    class URI_problem1035
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int d = int.Parse(input[3]);

            if (b > c && d > a && c + d > a + b && c >= 0 && d >= 0 && a % 2 == 0)

            {
                Console.WriteLine("Valores aceitos");
            }


            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            Console.ReadKey();




        }
    }
}
