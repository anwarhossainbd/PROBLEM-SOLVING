using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1048
{
    class URI_problem1048
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());




            if (a >= 0 && a <= 400)
            {


                double salary = a + ((a * 15) / 100);

                Console.WriteLine("Novo salario: " + salary.ToString("0.00"));

                double increase = salary - a;

                Console.WriteLine("Reajuste ganho: {0}", increase.ToString("0.00"));

                Console.WriteLine("Em percentual: 15 %");

            }


            else if (a > 400 && a <= 800)
            {
                double salary = a + ((a * 12) / 100);
                Console.WriteLine("Novo salario: " + salary.ToString("0.00"));

                double increase = salary - a;

                Console.WriteLine("Reajuste ganho: {0}", increase.ToString("0.00"));

                Console.WriteLine("Em percentual: 12 %");

            }




            else if (a > 800 && a <= 1200)
            {
                double salary = a + ((a * 10) / 100);
                Console.WriteLine("Novo salario: " + salary.ToString("0.00"));

                double increase = salary - a;

                Console.WriteLine("Reajuste ganho: {0}", increase.ToString("0.00"));

                Console.WriteLine("Em percentual: 10 %");

            }


            else if (a > 1200 && a <= 2000)
            {
                double salary = a + ((a * 7) / 100);
                Console.WriteLine("Novo salario: " + salary.ToString("0.00"));

                double increase = salary - a;

                Console.WriteLine("Reajuste ganho: {0}", increase.ToString("0.00"));

                Console.WriteLine("Em percentual: 7 %");

            }


            else if (a > 2000)
            {
                double salary = a + ((a * 4) / 100);
                Console.WriteLine("Novo salario: " + salary.ToString("0.00"));

                double increase = salary - a;

                Console.WriteLine("Reajuste ganho: {0}", increase.ToString("0.00"));

                Console.WriteLine("Em percentual: 4 %");

            }



            Console.ReadKey();



        }
    }
}
