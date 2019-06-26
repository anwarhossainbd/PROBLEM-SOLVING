using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1064
{
    class URI_problem1064
    {
        static void Main(string[] args)
        {

            double[] input = new double[6];

            for (int i = 0; i < 6; i++)
            {
                input[i] = double.Parse(Console.ReadLine());
            }

            int count = 0;
            double sum = 0;

            double avg;




            foreach (double number in input)
            {
                if (number > 0)
                {
                    count = count + 1;

                    sum = sum + number;

                }
            }

            Console.WriteLine(count + " valores positivos");

            avg = sum / count;

            Console.WriteLine(avg.ToString("0.0"));


            Console.ReadKey();

        }
    }
}
