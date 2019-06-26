using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1174
{
    class URI
    {
        static void Main(string[] args)
        {

            double num;


            for (int i = 0; i < 100; i++)
            {

                num = double.Parse(Console.ReadLine());

                if (num <= 10)
                {
                    Console.WriteLine("A[{0}] = {1}", i, num.ToString("0.0"));
                }


            }


            Console.ReadKey();


        }
    }
}
