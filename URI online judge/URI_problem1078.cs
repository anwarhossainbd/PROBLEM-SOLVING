using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1078
{
    class URI_problem1078
    {
        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, number * i);
            }


            Console.ReadKey();


        }
    }
}
