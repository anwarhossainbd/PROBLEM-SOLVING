using System;


namespace URI1099
{
    class URI
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {

                string[] input = Console.ReadLine().Split();

                int num1 = int.Parse(input[0]);
                int num2 = int.Parse(input[1]);

                int temp;

                if (num1 > num2)
                {
                    temp = num1;
                    num1 = num2;
                    num2 = temp;

                    
                }

                int sum = 0;

                for (int ii = num1+1  ; ii < num2; ii++)
                {
                    if (ii % 2 != 0)
                    {
                        sum = sum + ii;
                    }
                   // Console.WriteLine(sum);
                }
                Console.WriteLine(sum);


            }
            

            Console.ReadKey();
        }
    }
}