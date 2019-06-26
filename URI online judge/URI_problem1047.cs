using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1047
{
    class URI_problem1047
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int initial_hour = int.Parse(input[0]);
            int initial_minute = int.Parse(input[1]);
            int final_hour = int.Parse(input[2]);
            int final_minute = int.Parse(input[3]);


            int hour = initial_hour * 60;

            int totalhour = hour + initial_minute;

            int fhour = final_hour * 60;

            int totalfhour = fhour + final_minute;


            if (totalhour < totalfhour)
            {
                int a = totalfhour - totalhour;

                int res_hour = a / 60;
                int res_min = a % 60;

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", res_hour, res_min);
            }


            else if (totalhour > totalfhour)
            {
                int a = (totalfhour + 1440) - totalhour;

                int res_hour = a / 60;
                int res_min = a % 60;

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", res_hour, res_min);

            }

            else
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }

            Console.ReadKey();
        }
    }
}
