using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1154
{
    class URI
    {
        static void Main(string[] args)
        {
            int num;

            int add = 0;
            int count = 0;

            while ((num = int.Parse(Console.ReadLine())) > -1)
            {
                add = add + num;
                count = count + 1;




            }


            double d = (double)add / count;

            Console.WriteLine(d.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
