using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1046
{
    class URI_problem1046
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int start = int.Parse(input[0]);

            int end = int.Parse(input[1]);

            if (start < end)
            {
                int res = end - start;

                Console.WriteLine("O JOGO DUROU {0} HORA(S)", res);
            }

            else if (start > end)
            {
                end = end + 24;
                int res = end - start;
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", res);
            }
            else
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }


            Console.ReadKey();



        }
    }
}
