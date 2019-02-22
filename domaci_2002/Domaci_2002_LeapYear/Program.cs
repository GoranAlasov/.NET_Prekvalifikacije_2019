using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_2002_LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {            
            int year;

            Console.WriteLine("Unesite godinu: ");

            bool isItANumber = int.TryParse(Console.ReadLine(), out year);

            if (isItANumber)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    Console.WriteLine("Godina je prestupna.");
                }
                else
                {
                    Console.WriteLine("Godina nije prestupna.");
                }
            }
            else
            {
                Console.WriteLine("Niste uneli ceo broj.");
            }

            Console.ReadKey();
        }
    }
}
