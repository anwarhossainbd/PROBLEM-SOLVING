using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1066
{
    class URI_problem1066
    {
        static void Main(string[] args)
        {

            int[] number = new int[5];


            for (int i = 0; i < 5; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            int even = 0;
            int odd = 0;
            int pos = 0;
            int neg = 0;

            foreach (int num in number)
            {
                if (num % 2 == 0)
                {

                    even = even + 1;
                }

                if (num % 2 != 0)
                {

                    odd = odd + 1;
                }


                if (num > 0)
                {
                    pos = pos + 1;
                }

                if (num < 0)
                {
                    neg = neg + 1;
                }

            }

            Console.WriteLine(even + " valor(es) par(es)");

            Console.WriteLine(odd + " valor(es) impar(es)");

            Console.WriteLine(pos + " valor(es) positivo(s)");

            Console.WriteLine(neg + " valor(es) negativo(s)");





            Console.ReadKey();


        }
    }
}
