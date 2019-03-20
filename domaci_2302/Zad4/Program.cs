using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{


    //Napisati potprogram koji na osnovu brojne vrednosti promenljive n, 
    //ispisuje "n je neparan broj" ako je broj neparan, u suprotnom "n je paran broj".


    class Program
    {
        static int EnterAndCheckInt()
        {
            bool isItInt;
            int a;

            do
            {
                Console.WriteLine("Unesite broj za koji proveravamo da li je paran ili neparan: ");
                isItInt = Int32.TryParse(Console.ReadLine(), out a);
                if (!isItInt)
                {
                    Console.WriteLine("Neispravan unos! Pokusajte opet:");
                }
            } while (!isItInt);

            return a;
        }

        static void EvenOrOdd (int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"Unet broj {number} je paran.");
            }
            else
            {
                Console.WriteLine($"Unet broj {number} je neparan.");
            }            
        }

        public static void Main(string[] args)
        {
            int a = EnterAndCheckInt();

            EvenOrOdd(a);
            Console.Read();
        }
    }
}
