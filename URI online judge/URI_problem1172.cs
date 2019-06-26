using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1172
{
    class URI
    {
        static void Main(string[] args)
        {
            double num;


            for (int i = 0; i < 10; i++)
            {

                num = double.Parse(Console.ReadLine());

                if (num <= 0)
                {
                    Console.WriteLine("X[{0}] = {1}", i, 1);
                }

                else
                {
                    Console.WriteLine("X[{0}] = {1}", i, num);
                }


            }


            Console.ReadKey();



        }
    }
}
