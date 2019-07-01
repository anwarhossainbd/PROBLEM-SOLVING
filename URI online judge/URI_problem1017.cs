using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri_problem1017
{
    class URI_problem1017
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int speed = int.Parse(Console.ReadLine());

            double litter = (double)(time * speed) / 12;

            Console.WriteLine(litter.ToString("0.000"));
            Console.ReadKey();



        }
    }
}
