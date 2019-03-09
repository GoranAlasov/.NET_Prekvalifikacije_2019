using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10
{
    class Program
    {
        enum daysOfTheWeek { nedelja, ponedeljak, utorak, sreda, cetvrtak, petak, subota };

        static int CheckInt(int minValue, int maxValue)
        {
            bool numberOK = false;
            int number;

            do
            {
                numberOK = Int32.TryParse(Console.ReadLine(), out number) 
                    && number >= minValue 
                    && number <= maxValue;

                if (!numberOK)
                {
                    Console.WriteLine("Pogresan unos, probaj opet:");
                }
            } while (!numberOK);

            return number;            
        }

        static void DaysOfTheWeek()
        {
            Console.WriteLine("unesite dan u nedelji (0 : nedelja - 6 : subota): ");
            int dayOfTheWeek = CheckInt(0, 6);

            Console.WriteLine("koliko dana u buducnost?");
            int daysToFuture = CheckInt(0, Int32.MaxValue);

            int resultingDay = (dayOfTheWeek + daysToFuture) % 7;

            switch (resultingDay)
            {
                case 0:
                    Console.WriteLine("Za {0} dana ce biti {1}", daysToFuture, daysOfTheWeek.nedelja);
                    break;
                case 1:
                    Console.WriteLine("Za {0} dana ce biti {1}", daysToFuture, daysOfTheWeek.ponedeljak);
                    break;
                case 2:
                    Console.WriteLine("Za {0} dana ce biti {1}", daysToFuture, daysOfTheWeek.utorak);
                    break;
                case 3:
                    Console.WriteLine("Za {0} dana ce biti {1}", daysToFuture, daysOfTheWeek.sreda);
                    break;
                case 4:
                    Console.WriteLine("Za {0} dana ce biti {1}", daysToFuture, daysOfTheWeek.cetvrtak);
                    break;
                case 5:
                    Console.WriteLine("Za {0} dana ce biti {1}", daysToFuture, daysOfTheWeek.petak);
                    break;
                case 6:
                    Console.WriteLine("Za {0} dana ce biti {1}", daysToFuture, daysOfTheWeek.subota);
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            DaysOfTheWeek();
            Console.Read();
        }
    }
}
