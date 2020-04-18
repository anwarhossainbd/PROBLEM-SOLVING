using System;


namespace ConsoleApp6
{
    class URI
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int i;

            int a = 0;

            int b = 0;


            int num;

            for( i = 0; i < x; i++)
            {
              

               num= int.Parse(Console.ReadLine());

                if(num>=10 &&  num <=20)
                {
                    a++;
                }

                else
                {
                    b++;
                }

            }

                
            Console.WriteLine(a + " in");
            Console.WriteLine(b + " out");


            Console.ReadKey();

        }
    }
}