using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1021
{
    class URI_problem1021
    {
        static void Main(string[] args)
        {

            double money = double.Parse(Console.ReadLine());
            double taka = money * 100;

            Console.WriteLine("NOTAS:");



            double hundred = (int)taka / 10000;
            double fifty = (int)(taka % 10000) / 5000;
            double twinty = (int)((taka % 10000) % 5000) / 2000;
            double ten = (int)(((taka % 10000) % 5000) % 2000) / 1000;
            double five = (int)((((taka % 10000) % 5000) % 2000) % 1000) / 500;
            double two = (int)(((((taka % 10000) % 5000) % 2000) % 1000) % 500) / 200;

            Console.WriteLine("{0} nota(s) de R$ 100.00", hundred);
            Console.WriteLine("{0} nota(s) de R$ 50.00", fifty);
            Console.WriteLine("{0} nota(s) de R$ 20.00", twinty);
            Console.WriteLine("{0} nota(s) de R$ 10.00", ten);
            Console.WriteLine("{0} nota(s) de R$ 5.00", five);
            Console.WriteLine("{0} nota(s) de R$ 2.00", two);


            Console.WriteLine("MOEDAS:");

            double one = (int)((((((taka % 10000) % 5000) % 2000) % 1000) % 500) % 200) / 100;
            double pointfifty = (int)(((((((taka % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) / 50;
            double pointtwintyfive = (int)((((((((taka % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) / 25;
            double pointten = (int)(((((((((taka % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) % 25) / 10;
            double pointfive = (int)((((((((((taka % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) % 25) % 10) / 5;
            double pointone = (int)(((((((((((taka % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) % 25) % 10) % 5) / 1;

            Console.WriteLine("{0} moeda(s) de R$ 1.00", one);
            Console.WriteLine("{0} moeda(s) de R$ 0.50", pointfifty);
            Console.WriteLine("{0} moeda(s) de R$ 0.25", pointtwintyfive);
            Console.WriteLine("{0} moeda(s) de R$ 0.10", pointten);
            Console.WriteLine("{0} moeda(s) de R$ 0.05", pointfive);
            Console.WriteLine("{0} moeda(s) de R$ 0.01", pointone);


            Console.ReadKey();



        }
    }
}
