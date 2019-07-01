using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int code = int.Parse(input[0]);

            int quentity = int.Parse(input[1]);




            if (code == 1)
            {
                Console.WriteLine("Total: R$ " + (4 * quentity).ToString("0.00"));
            }
            else if (code == 2)
            {
                Console.WriteLine("Total: R$ " + (4.50 * quentity).ToString("0.00"));
            }

            else if (code == 3)
            {
                Console.WriteLine("Total: R$ " + (5 * quentity).ToString("0.00"));
            }

            else if (code == 4)
            {
                Console.WriteLine("Total: R$ " + (2 * quentity).ToString("0.00"));
            }

            else if (code == 5)
            {
                Console.WriteLine("Total: R$ " + (1.50 * quentity).ToString("0.00"));
            }


            Console.ReadKey();




        }
    }
}
