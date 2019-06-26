using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1074
{
    class URI_problem1074
    {
        static void Main(string[] args)
        {
            int loopno = int.Parse(Console.ReadLine());

            int number;


            for (int i = 1; i <= loopno; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (number < 0 && number % 2 != 0 && number != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }

                if (number < 0 && number % 2 == 0 && number != 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }


                if (number > 0 && number % 2 != 0 && number != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }

                if (number > 0 && number % 2 == 0 && number != 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }

                if (number == 0)
                {
                    Console.WriteLine("NULL");
                }


                Console.ReadKey();

            }
        }
}
