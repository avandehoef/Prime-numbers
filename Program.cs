using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("geef een getal op voor de eerste poging om een priemgetal te bepalen");

            int getal1 = int.Parse(Console.ReadLine());
            int y = getal1 -2;
            int getal2;

            if (getal1 % 2 == 0)
            {
                Console.WriteLine("Dit is geen priemgetal");
                Console.ReadKey();
            }
            else
            {
                for (getal2 = getal1; y > 2; y = y - 2)

                    if (getal2 % y == 0)
                    {

                        Console.WriteLine("Dit is geen priemgetal");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        if (y > 2)
                        {
                            continue;
                        }
                                        
                    }


                    Console.WriteLine("Dit is een priemgetal!");



            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
