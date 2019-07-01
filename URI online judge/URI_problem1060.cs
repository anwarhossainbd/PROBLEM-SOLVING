using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1060
{
    class URI_problem1060
    {
        static void Main(string[] args)
        {
            double[] number = new double[6];

            for (int i = 0; i < 6; i++)
            {
                number[i] = double.Parse(Console.ReadLine());
            }

            int count = 0;

            foreach (double num in number)
            {
                if (num > 0)
                {
                    count++;

                }
            }


            Console.WriteLine(count + " valores positivos");


            Console.ReadKey();



        }
    }
}
