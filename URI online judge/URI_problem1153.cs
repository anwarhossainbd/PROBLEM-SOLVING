using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1153
{
    class URI_problem1153
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 1;

            for (int i = num; i >= 1; i--)
            {
                sum = sum * i;

            }

            Console.WriteLine(sum);


            Console.ReadKey();

        }
    }
}
