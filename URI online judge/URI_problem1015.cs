using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1015
{
    class URI_problem1015
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            double x1 = double.Parse(inputs[0]);
            double y1 = double.Parse(inputs[1]);

            string[] inputs1 = Console.ReadLine().Split();
            double x2 = double.Parse(inputs1[0]);
            double y2 = double.Parse(inputs1[1]);

            double a = Math.Pow((x2 - x1), 2);
            double b = Math.Pow((y2 - y1), 2);

            double distance = Math.Sqrt(a + b);

            Console.WriteLine(distance.ToString("0.0000"));

            Console.ReadKey();


        }
    }
}
