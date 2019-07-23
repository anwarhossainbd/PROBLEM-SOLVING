using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class URI_problem1009
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double salary, sold;

            salary = double.Parse(Console.ReadLine());
            sold = double.Parse(Console.ReadLine());

            double extra = (sold * 15) / 100;

            double total = salary + extra;

            Console.WriteLine("TOTAL = R$ {0}", total.ToString("0.00"));
            Console.ReadKey();

        }
    }
}
