using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1041
{
    class URI_problem1041
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();

            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }

            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }

            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }

            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }

            else if (y == 0 && x != 0)
            {
                Console.WriteLine("Eixo X");
            }


            Console.ReadKey();


        }
    }
}
