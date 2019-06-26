using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri_problem1164
{
    class URI
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());



            for (int i = 0; i < a; i++)
            {
                int num = int.Parse(Console.ReadLine());

                int sum = 0;

                for (int j = 1; j < num; j++)
                {
                    if (num % j == 0)
                    {
                        sum = sum + j;
                    }
                }


                if (sum == num)
                {
                    Console.WriteLine(num + " eh perfeito");

                }

                if (sum != num)
                {
                    Console.WriteLine(num + " nao eh perfeito");
                }
            }

            Console.ReadKey();
        }
    }
}
