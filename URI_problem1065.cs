using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1065
{
    class URI_problem1065
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            array[0] = int.Parse(Console.ReadLine());
            array[1] = int.Parse(Console.ReadLine());
            array[2] = int.Parse(Console.ReadLine());
            array[3] = int.Parse(Console.ReadLine());
            array[4] = int.Parse(Console.ReadLine());

            int count = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    count = count + 1;
                }
            }

            Console.WriteLine(count + " valores pares");


            Console.ReadKey();

        }
    }
}
