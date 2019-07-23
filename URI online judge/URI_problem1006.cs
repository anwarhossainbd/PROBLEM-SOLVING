using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class URI_problem1006
    {
        static void Main(string[] args)
        {

            double num1, num2, num3;

            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());

            num1 = num1 * 2;
            num2 = num2 * 3;
            num3 = num3 * 5;

            double res = (num1 + num2 + num3) / 10;


            Console.WriteLine("MEDIA = {0}", res.ToString("0.0"));
            Console.ReadKey();



        }
    }
}
