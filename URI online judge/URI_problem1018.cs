using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1018
{
    class URI_problem1018
    {
        static void Main(string[] args)
        {
            int taka = int.Parse(Console.ReadLine());
            Console.WriteLine(taka);

            int humdred = taka / 100;
            Console.WriteLine(humdred + " nota(s) de R$ 100,00");

            int fifty = (taka % 100) / 50;
            Console.WriteLine(fifty + " nota(s) de R$ 50,00");

            int twinty = ((taka % 100) % 50) / 20;
            Console.WriteLine(twinty + " nota(s) de R$ 20,00");

            int ten = (((taka % 100) % 50) % 20) / 10;
            Console.WriteLine(ten + " nota(s) de R$ 10,00");

            int five = ((((taka % 100) % 50) % 20) % 10) / 5;
            Console.WriteLine(five + " nota(s) de R$ 5,00");

            int two = (((((taka % 100) % 50) % 20) % 10) % 5) / 2;
            Console.WriteLine(two + " nota(s) de R$ 2,00");

            int one = ((((((taka % 100) % 50) % 20) % 10) % 5) % 2) / 1;
            Console.WriteLine(one + " nota(s) de R$ 1,00");


            Console.ReadKey();




        }
    }
}
