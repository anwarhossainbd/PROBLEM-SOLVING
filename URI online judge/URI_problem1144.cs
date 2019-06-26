using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1144
{
    class URI_problem1144
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());



            for (int i = 1; i <= num; i++)
            {

                Console.WriteLine(i + " " + i * i + " " + i * i * i);

                Console.WriteLine(i + " " + (i * i + 1) + " " + (i * i * i + 1));

            }



            Console.ReadKey();


        }
    }
}
