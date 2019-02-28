using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad8
{


    //Napisati program koji određuje procenat brojeva deljivih sa 3 od N brojeva.
    //Korisnik unosi N, a zatim same brojeve(15-62). Koristiti neku od petlji.


    class Program
    {
        static int EnterAndCheckN()
        {
            bool isItInt;
            int a;            

            do
            {
                Console.WriteLine("Unesite koliko ce biti cifara [maksimalno {0}]: ", (62-15) + 1);
                isItInt = Int32.TryParse(Console.ReadLine(), out a);
                if (!isItInt || a > (62-15) + 1)
                {
                    Console.WriteLine("Neispravan unos! Pokusajte opet:");
                }
            } while (!isItInt || a > (62 - 15) + 1);            

            return a;
        }

        static int EnterAndCheckRulesForEveryInt(int place)
        {        
            bool isItInt;
            int a;

            do
            {
                Console.WriteLine("Unesite {0}. broj [15-62]: ", place);
                isItInt = Int32.TryParse(Console.ReadLine(), out a);
                if (!isItInt || a < 15 || a > 62)
                {
                    Console.WriteLine("Neispravan unos! Pokusajte opet:");
                }
            } while (!isItInt || a < 15 || a > 62);

            return a;
        }

        static void Main(string[] args)
        {            
            int counterDivisiveBy3 = 0;

            int n = EnterAndCheckN();

            for (int i = 1; i <= n; i++)
            {
                int number = EnterAndCheckRulesForEveryInt(i);

                if (number % 3 == 0)
                {
                    counterDivisiveBy3++;
                }
            }

            double percent = ((double)counterDivisiveBy3 / (double)n) * 100;

            Console.WriteLine("Uneli ste {0} brojeva ukupno. Od toga je njih {1} deljivih sa 3.", n, counterDivisiveBy3);
            Console.WriteLine("To znaci da je {0}% od unetih brojeva deljivo sa 3.", Math.Round(percent, 2));
            Console.ReadLine();
        }
    }
}
