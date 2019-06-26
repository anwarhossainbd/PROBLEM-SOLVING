using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1045
{
    class URI_problem1045
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split();


            double a = double.Parse(number[0]);
            double b = double.Parse(number[1]);
            double c = double.Parse(number[2]);

            double temp;

            if (b < c)
            {
                temp = c;
                c = b;
                b = temp;
            }

            if (a < b)
            {
                temp = b;
                b = a;
                a = temp;

            }

            if (b < c)
            {
                temp = c;
                c = b;
                b = temp;
            }




            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }

            else
            {
                if (a * a == b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }

                if (a * a > b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }


                if (a * a < b * b + c * c)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }


                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }


            }


            Console.ReadKey();

        }
    }
}
