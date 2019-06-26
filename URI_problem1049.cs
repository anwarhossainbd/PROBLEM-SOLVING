using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI_problem1049
{
    class URI_problem1049
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();

            string second = Console.ReadLine();

            string third = Console.ReadLine();

            //first
            if (first == "vertebrado")
            {
                if (second == "ave")
                {
                    if (third == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }

                }
            }

            //second 

            if (first == "vertebrado")
            {
                if (second == "ave")
                {
                    if (third == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }

                }
            }

            //third 

            /*  if (first == "vertebrado")
              {
                  if (second == "ave")
                  {
                      if (third == "onivoro")
                      {
                          Console.WriteLine("pomba");
                      }

                  }
              }  */

            //fourth 

            if (first == "vertebrado")
            {
                if (second == "mamifero")
                {
                    if (third == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }

                }
            }

            //fivth 


            if (first == "vertebrado")
            {
                if (second == "mamifero")
                {
                    if (third == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }

                }
            }

            //six 


            if (first == "invertebrado")
            {
                if (second == "inseto")
                {
                    if (third == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }

                }
            }


            //seven




            if (first == "invertebrado")
            {
                if (second == "inseto")
                {
                    if (third == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }

                }
            }

            //eight 


            /*  if (first == "invertebrado")
              {
                  if (second == "inseto")
                  {
                      if (third == "herbivoro")
                      {
                          Console.WriteLine("lagarta");
                      }

                  }
              }*/

            //nine

            if (first == "invertebrado")
            {
                if (second == "anelideo")
                {
                    if (third == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }

                }
            }

            //ten

            if (first == "invertebrado")
            {
                if (second == "anelideo")
                {
                    if (third == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }

                }
            }



            Console.ReadKey();

        }
    }
}
