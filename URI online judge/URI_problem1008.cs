using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class URI_problem1008
    {
        static void Main(string[] args)
        {
            int number, hour;
            double money;

            number = int.Parse(Console.ReadLine());
            hour = int.Parse(Console.ReadLine());
            money = double.Parse(Console.ReadLine());

            double salary = hour * money;

            Console.WriteLine("NUMBER = {0}", number);
            Console.WriteLine("SALARY = U$ {0}", salary.ToString("0.00"));

            Console.ReadKey();





        }
    }
}
