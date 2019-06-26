using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_PROBLEM1071
{
    class URI_problem1071
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = 0;
            int temp;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }


            for (int i = a + 1; i < b; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                    //  Console.WriteLine(sum);

                }

            }

            Console.WriteLine(sum);


            Console.ReadKey();


        }
    }
}
