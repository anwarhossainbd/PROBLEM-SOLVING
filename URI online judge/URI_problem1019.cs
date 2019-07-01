using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1019
{
    class URI_problem1019
    {
        static void Main(string[] args)
        {


            int s = int.Parse(Console.ReadLine());

            int hour = s / 3600;
            int minute = (s % 3600) / 60;
            int second = ((s % 3600) % 60);


            Console.WriteLine("{0}:{1}:{2}", hour, minute, second);

            Console.ReadKey();
        }
    }
}
