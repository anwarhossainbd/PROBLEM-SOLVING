using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1146
{
    class URI
    {
        static void Main(string[] args)
        {
            int X;

            //  Console.WriteLine(1);

            while ((X = int.Parse(Console.ReadLine())) != 0)
            {
                Console.Write(1);

                for (int i = 2; i <= X; i++)
                {

                    Console.Write(" " + i);


                }

                Console.WriteLine();

            }


            Console.ReadKey();


        }
    }
}
