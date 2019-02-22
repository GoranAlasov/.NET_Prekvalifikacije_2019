using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_2002_Quarter
{
    class Program
    {
        static void OutputQuarter (int month)
        {
            if (month < 1)
            {
                Console.WriteLine("Uneti broj je manji od -1. Prekid programa...");
            }
            else if (month > 12)
            {
                Console.WriteLine("Uneti broj je veci od 12. Prekid programa...");
            }
            else if (month >= 1 && month <= 3)
            {
                Console.WriteLine("Prvi kvartal!");
            }
            else if (month >= 4 && month <= 6)
            {
                Console.WriteLine("Drugi kvartal!");
            }
            else if (month >= 7 && month <= 9)
            {
                Console.WriteLine("Treci kvartal!");
            }
            else
            {
                Console.WriteLine("Cetvrti kvartal");
            }
        }

        static void Main(string[] args)
        {
            int month;

            Console.WriteLine("Unesite broj meseca [1-12]: ");
                        
            bool isItNumber = int.TryParse(Console.ReadLine(), out month);
            
            if (isItNumber)
            {
                OutputQuarter(month);
            }
            else
            {
                Console.WriteLine("Niste uneli broj!");
            }

            Console.WriteLine("Pritisnite bilo koji taster za kraj aplikacije");
            Console.ReadKey();
        }
    }
}
