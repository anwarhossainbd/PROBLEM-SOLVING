using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1050
{
    class URI_problem1050
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());


            if (number == 61)
            {
                Console.WriteLine("Brasilia");
            }

            else if (number == 71)
            {
                Console.WriteLine("Salvador");
            }

            else if (number == 11)
            {
                Console.WriteLine("Sao Paulo");
            }


            else if (number == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }

            else if (number == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }


            else if (number == 19)
            {
                Console.WriteLine("Campinas");
            }


            else if (number == 27)
            {
                Console.WriteLine("Vitoria");
            }


            else if (number == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }

            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }



            Console.ReadKey();
        }
    }
}
