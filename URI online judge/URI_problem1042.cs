using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1042
{
    class URI_problem1042
    {
        static void Main(string[] args)
        {


            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);


            int i = a;
            int j = b;
            int k = c;

            int temp;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            if (a > c)
            {
                temp = a;
                a = c;
                c = temp;

            }

            if (b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


            Console.WriteLine();

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);


            Console.ReadKey();

        }
    }
}
