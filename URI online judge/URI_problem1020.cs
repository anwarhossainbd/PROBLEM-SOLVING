using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1020
{
    class URI_problem1020
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int year = days / 365;
            int months = (days % 365) / 30;
            int day = (days % 365) % 30;

            Console.WriteLine(year + " ano(s)");
            Console.WriteLine(months + " mes(es)");
            Console.WriteLine(day + " dia(s)");

            Console.ReadKey();



        }
    }
}
