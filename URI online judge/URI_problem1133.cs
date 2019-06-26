using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1133
{
    class URI_problem1133
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());


            if (num1 > 0 && num2 > 0)
            {


                if (num1 < num2)
                {


                    for (int i = num1 + 1; i < num2; i++)
                    {
                        if (i % 5 == 2 || i % 5 == 3)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }

                else
                {


                    for (int i = num2 + 1; i < num1; i++)
                    {
                        if (i % 5 == 2 || i % 5 == 3)
                        {
                            Console.WriteLine(i);
                        }


                    }


                }





            }




            Console.ReadKey();



        }
    }
}
