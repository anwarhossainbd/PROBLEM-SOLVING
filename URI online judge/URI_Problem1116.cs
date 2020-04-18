using System;

namespace uriproblem
{
    class URI
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            int a, b;
            double c;

            for(int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                 a = int.Parse(input[0]);
                 b = int.Parse(input[1]);

                if (b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }

                else
                {
                   
                    c =(double) a/b;
                    Console.WriteLine(c.ToString("0.0"));
                }
            }


            

            Console.ReadKey();
        }
    }
}
