using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1132
{
    class URI_problem1132
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int sum = 0;

            int temp;

            if (X > Y)
            {
                temp = X;
                X = Y;
                Y = temp;
            }

            for (int i = X; i <= Y; i++)
            {
                if (i % 13 != 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine(sum);

            Console.ReadKey();

        }
    }
}
