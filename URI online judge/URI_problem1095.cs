using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1095
{
    class URI_problem1095
    {
        static void Main(string[] args)
        {
            int i = 1;

            for (int j = 60; j >= 0; j = j - 5)
            {


                Console.WriteLine("I={0} J={1}", i, j);


                i = i + 3;


            }


            Console.ReadKey();


        }
    }
}
