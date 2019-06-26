using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1073
{
    class URI_problem1073
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            if (number % 2 == 0)
            {
                for (int i = 2; i <= number; i = i + 2)

                {
                    int a = i * i;
                    Console.WriteLine("{0}^2 = {1}", i, a);
                }
            }

            else
            {
                for (int i = 2; i < number; i = i + 2)
                {
                    int a = i * i;
                    Console.WriteLine("{0}^2 = {1}", i, a);
                }
            }
            Console.ReadKey();


        }
    }
}
