﻿using System;
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

            Console.WriteLine("Geef een getal op voor een check of dit een priemgetal is;");

            
            string invoer = Console.ReadLine();
            Int64 getal1;
            bool succesvolleInvoer = Int64.TryParse(invoer, out getal1);

            while (true)
            {
                if (invoer.Length != 0 && succesvolleInvoer == true && getal1 > 0)
                    break;
                Console.WriteLine("Dit is geen geldige invoer; geef een getal op groter dan 0");
                Console.WriteLine("Geef een getal op voor een check of dit een priemgetal is");
                invoer = Console.ReadLine();
                succesvolleInvoer = Int64.TryParse(invoer, out getal1);
            }
                       
            Int64 y = getal1 -2;
            Int64 getal2;

            if (getal1 == 2)
            {
                Console.WriteLine(getal1 + " is een priemgetal");
                Console.ReadKey();
            }
            else
            { 
                if (getal1 % 2 == 0)
                {
                Console.WriteLine(getal1 + " is GEEN priemgetal");
                Console.ReadKey();
                }
                else
                {
                    for (getal2 = getal1; y > 0; y = y - 2)
                    {
                        if (getal2 % y != 0 || y == 1)
                        {
                            if (y < 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine(getal1 + " is WEL een priemgetal!");
                                Console.ReadKey();
                            }
                            else
                            {
                                if (getal2 % y == 0)
                                {
                                    Console.WriteLine(getal1 + " is GEEN priemgetal");
                                    Console.ReadKey();
                                }
                                else
                                    continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine(getal1 + " is GEEN priemgetal");
                            Console.ReadKey();
                            break;
                        }
                    }
                }  
            }

            Console.WriteLine();
            Console.WriteLine("Druk op een toets om deze applicatie af te sluiten...");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
