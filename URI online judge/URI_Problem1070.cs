using System;

namespace uri1070a
{
    class URI
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());


            if (number % 2 == 0)
            {
                for (int i = number + 1; i < number + 12; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            else
            {
                for (int i= number; i < number + 12; i = i + 2)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();
        }
    }
}